using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XMX;

namespace SerialDebug
{
    public partial class frmDataCheck : Form
    {
        private int dataWidth = 8;
        private byte[] _DataBytes = null;
        private UInt32 CheckResultValue;

        public string CrcResult
        {
            get { return txtResult.Text; }
        }

        public frmDataCheck()
        {
            InitializeComponent();
        }

        public void CalculateCheckData(string text, bool IsHex)
        {
            try
            {
                SendParamFormat format = SendParamFormat.ASCII;
                if (IsHex)
                {
                    format = SendParamFormat.Hex;
                }

                CSendParam param = new CSendParam(format, SendParamMode.SendAfterLastSend, 0, text);
                _DataBytes = param.DataBytes;
                CalCheckData();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }



        private void frmDataCheck_Load(object sender, EventArgs e)
        {
            cbDataCheckType.Items.Clear();

            cbDataCheckType.Items.Add("CheckSum_16");
            cbDataCheckType.Items.Add("CheckSum_8");
            cbDataCheckType.Items.Add("LRC");
            cbDataCheckType.Items.Add("CRC16_IBM");
            cbDataCheckType.Items.Add("CRC16_MAXIM");
            cbDataCheckType.Items.Add("CRC16_USB");
            cbDataCheckType.Items.Add("CRC16_MODBUS");
            cbDataCheckType.Items.Add("CRC16_CCITT");
            cbDataCheckType.Items.Add("CRC16_CCITT_FALSE");
            cbDataCheckType.Items.Add("CRC16_X25");
            cbDataCheckType.Items.Add("CRC16_XMODEM");
            cbDataCheckType.Items.Add("CRC16_DNP");
            cbDataCheckType.Items.Add("CRC32");
            cbDataCheckType.Items.Add("CRC32_MPEG2");

            cbDataCheckType.SelectedIndex = 0;
            gbCRCParam.Enabled = false;
        }

        private void cbDataCheckType_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataWidth = 8;

            if (_DataBytes == null)
            {
                return;
            }

            gbCRCParam.Enabled = false;

            int index = cbDataCheckType.SelectedIndex;
            if (index == 0)
            {
                dataWidth = 16;
            }
            else if (index == 1)
            {
                dataWidth = 8;
            }
            else if (index == 2)
            {
                dataWidth = 8;
            }
            else
            {
                gbCRCParam.Enabled = true;
                CRCType crcType = (CRCType)(index - 3);
                CRCInfo crcInfo = DataCheck.GetCRCInfo(crcType);

                chkRefIn.Checked = crcInfo.RefIn;
                chkRefOut.Checked = crcInfo.RefOut;
                chkXorOut.Checked = crcInfo.XorOut == 0 ? false : true;

                if (crcType >= CRCType.CRC16_IBM && crcType <= CRCType.CRC16_DNP)
                {
                    txtPoly.Text = string.Format("{0:X4}", crcInfo.Poly);
                    txtInit.Text = string.Format("{0:X4}", crcInfo.Init);

                    dataWidth = 16;
                }
                else if (crcType >= CRCType.CRC32 && crcType <= CRCType.CRC32_MPEG2)
                {
                    txtPoly.Text = string.Format("{0:X8}", crcInfo.Poly);
                    txtInit.Text = string.Format("{0:X8}", crcInfo.Init);

                    dataWidth = 32;
                }
            }


            CalCheckData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalCheckData();
        }


        private string getStringByUint32(UInt32 value, bool IsMSBFirst, int dataWidth)
        {
            byte[] array = new byte[4];

            array[0] = Convert.ToByte((value >> 24) & 0xFF);
            array[1] = Convert.ToByte((value >> 16) & 0xFF);
            array[2] = Convert.ToByte((value >> 8) & 0xFF);
            array[3] = Convert.ToByte((value >> 0) & 0xFF);

            StringBuilder sb = new StringBuilder();
            if (IsMSBFirst)
            {
                switch (dataWidth)
                {
                    case 8:
                        sb.AppendFormat("{0:X2}", array[3]);
                        break;
                    case 16:
                        sb.AppendFormat("{0:X2}", array[2]);
                        sb.AppendFormat("{0:X2}", array[3]);
                        break;
                    case 32:
                        sb.AppendFormat("{0:X2}", array[0]);
                        sb.AppendFormat("{0:X2}", array[1]);
                        sb.AppendFormat("{0:X2}", array[2]);
                        sb.AppendFormat("{0:X2}", array[3]);
                        break;
                }
            }
            else
            {
                switch (dataWidth)
                {
                    case 8:
                        sb.AppendFormat("{0:X2}", array[3]);
                        break;
                    case 16:
                        sb.AppendFormat("{0:X2}", array[3]);
                        sb.AppendFormat("{0:X2}", array[2]);

                        break;
                    case 32:
                        sb.AppendFormat("{0:X2}", array[3]);
                        sb.AppendFormat("{0:X2}", array[2]);
                        sb.AppendFormat("{0:X2}", array[1]);
                        sb.AppendFormat("{0:X2}", array[0]);
                        break;
                }
            }

            return sb.ToString();
        }

        private void CalCheckData()
        {
            try
            {
                UInt32 checkResult = 0;


                if (_DataBytes == null)
                {
                    return;
                }

                gbCRCParam.Enabled = false;

                int index = cbDataCheckType.SelectedIndex;
                if (index == -1)
                {
                    return;
                }
                if (index == 0)
                {
                    checkResult = Convert.ToUInt16(DataCheck.GetCheckSum(_DataBytes) & 0xFFFF);
                    dataWidth = 16;
                }
                else if (index == 1)
                {
                    checkResult = Convert.ToByte(DataCheck.GetCheckSum(_DataBytes) & 0xFF);
                    dataWidth = 8;
                }
                else if (index == 2)
                {
                    checkResult = DataCheck.GetXor(_DataBytes);
                    dataWidth = 8;
                }
                else
                {
                    gbCRCParam.Enabled = true;

                    CRCType crcType = (CRCType)(index - 3);


                    CRCInfo crcInfo = DataCheck.GetCRCInfo(crcType);
                    crcInfo.Poly = Convert.ToUInt32(txtPoly.Text, 16);
                    crcInfo.Init = Convert.ToUInt32(txtInit.Text, 16);
                    crcInfo.RefIn = chkRefIn.Checked;
                    crcInfo.RefOut = chkRefOut.Checked;
                    crcInfo.XorOut = chkXorOut.Checked ? 0xFFFFFFFF : 0x00000000;

                    

                    if (crcType >= CRCType.CRC16_IBM && crcType <= CRCType.CRC16_DNP)
                    {
                        checkResult = DataCheck.GetCRC16(crcInfo, _DataBytes);
                        dataWidth = 16;
                    }
                    else if (crcType >= CRCType.CRC32 && crcType <= CRCType.CRC32_MPEG2)
                    {
                        checkResult = DataCheck.GetCRC32(crcInfo, _DataBytes);
                        dataWidth = 32;
                    }
                }

                CheckResultValue = checkResult;
                txtResult.Text = getStringByUint32(CheckResultValue, chkIsLittleEndian.Checked, dataWidth);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CalCheckData();

            this.DialogResult = DialogResult.OK;
        }

        private void chkIsLittleEndian_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = getStringByUint32(CheckResultValue, chkIsLittleEndian.Checked, dataWidth);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }



    }
}