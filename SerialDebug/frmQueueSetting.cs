using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialDebug
{


    public partial class frmQueueSetting : Form
    {
        QueueSendObject sendObj;

        public frmQueueSetting()
        {
            InitializeComponent();
        }


        public frmQueueSetting(object[] obj)
            : this()
        {
            if (obj != null && obj.Length >= 5)
            {
                sendObj = new QueueSendObject();
                sendObj.Index = Convert.ToInt32(obj[0]);
                sendObj.Title = Convert.ToString(obj[1]);
                sendObj.Enable = Convert.ToBoolean(obj[2]);
                sendObj.Mode = Convert.ToString(obj[3]);
                sendObj.Content = Convert.ToString(obj[4]);

                CSendParam sp = getSendParamByMode(sendObj.Mode, sendObj.Content);

                chkSendHex.Checked = sp.Format == SendParamFormat.Hex ? true : false;
                cbSendMode.SelectedIndex = (int)sp.Mode;
                numSendListDelayTime.Value = sp.DelayTime;
                txtTitle.Text = sendObj.Title;

                if (sp.Format == SendParamFormat.Hex)
                {
                    txtSend.Text = sp.HexString;
                }
                else
                {
                    txtSend.Text = sp.ASCIIString;
                }
            }
        }


        public QueueSendObject SendObject
        {
            get { return sendObj; }
        }


        CSendParam getSendParamByMode(string mode, string content)
        {
            string[] paramsArray = mode.Split(new char[] { ':' });
            CSendParam sendParam = new CSendParam(
                (SendParamFormat)Convert.ToInt32(paramsArray[0]),
                (SendParamMode)Convert.ToInt32(paramsArray[1]),
                Convert.ToInt32(paramsArray[2]),
                content);

            return sendParam;
        }

        private void btnSaveSendParam_Click(object sender, EventArgs e)
        {
            if (txtSend.Text == string.Empty)
            {
                MessageBox.Show("发送数据不能为空", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                SendParamFormat format = SendParamFormat.ASCII;
                if (chkSendHex.Checked)
                {
                    format = SendParamFormat.Hex;
                }

                CSendParam param = new CSendParam(format,
                (SendParamMode)cbSendMode.SelectedIndex,
                Convert.ToInt32(numSendListDelayTime.Value),
                txtSend.Text);

                if (sendObj == null)
                {
                    sendObj = new QueueSendObject();
                    sendObj.Index = -1;
                    sendObj.Enable = true;
                }

                if (chkTitleAuto.Checked)
                {
                    sendObj.Title = txtSend.Text;
                }
                else
                {
                    sendObj.Title = txtTitle.Text;
                }
                
                sendObj.Mode = param.ParameterString;
                sendObj.Content = param.Data;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelSaveParam_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void linkLabelClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSend.Clear();
        }

        private void lnkAddCheckCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtSend.Text != String.Empty)
                {
                    bool IsHex = chkSendHex.Checked;

                   
                    bool topMost = this.TopMost;
                    this.TopMost = false;


                    frmDataCheck frm = new frmDataCheck();
                    frm.CalculateCheckData(txtSend.Text, IsHex);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (IsHex)
                        {
                            CSendParam p = new CSendParam(SendParamFormat.Hex, SendParamMode.SendAfterLastSend, 0, frm.CrcResult);
                            txtSend.AppendText(string.Format(" {0}", p.Data));
                        }
                        else
                        {
                            txtSend.AppendText(string.Format("{0}", frm.CrcResult));
                        }

                    }

                    this.TopMost = topMost;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQueueSetting_Load(object sender, EventArgs e)
        {
            cbSendMode.SelectedIndex = 0;
        }
    }



    public class QueueSendObject
    {
        private int _Index = 0;
        private string _Title = "";
        private bool _Enable = true;
        private string _Mode = "0:0:10";
        private string _Content = "";

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public bool Enable
        {
            get { return _Enable; }
            set { _Enable = value; }
        }

        public string Mode
        {
            get { return _Mode; }
            set { _Mode = value; }
        }

        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }
    }

}
