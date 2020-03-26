using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialDebug
{
    public partial class FormNormalSend : Form, ISendForm
    {

        public delegate void SendByCtrlEnterHandler(object sender, EventArgs e);
        public event SendByCtrlEnterHandler OnSendByCtrlEnter;

        private List<string> SendTempList = new List<string>();
        private int SendTempIndex = 0;

        public FormNormalSend()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 格式化显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFormat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CSendParam param = new CSendParam(SendParamFormat.Hex, SendParamMode.SendAfterLastSend, Convert.ToInt32(numSendInterval.Value), txtSend.Text);
                if (chkSendHex.Checked && chkFormat.Checked)
                {
                    txtSend.Text = param.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 按下按键的特殊操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            string text = "";
            if (e.Modifiers == Keys.Control)
            {
                IsCtrlPressed = true;
            }
            else
            {
                IsCtrlPressed = false;
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                if (OnSendByCtrlEnter != null)
                {
                    OnSendByCtrlEnter(this, e);
                }
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Up)
            {
                SendTempIndex--;
                if (SendTempIndex < 0)
                {
                    SendTempIndex = 0;
                    Console.Beep();
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                SendTempIndex++;
                if (SendTempIndex > SendTempList.Count)
                {
                    SendTempIndex = SendTempList.Count;
                    Console.Beep();
                }
                e.Handled = true;
            }
            else
            {
                return;
            }

            lock (SendTempList)
            {
                if (SendTempList.Count > 0)
                {
                    if (SendTempIndex < SendTempList.Count)
                    {
                        text = SendTempList[SendTempIndex];
                    }
                }
            }

            txtSend.Clear();
            txtSend.AppendText(text);
        }

        private bool IsCtrlPressed = false;
        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsCtrlPressed)
            {
                if (e.KeyChar == '\r' || e.KeyChar == '\n') // 回车
                {
                    e.Handled = true;
                }
            }

        }

        private void updateSendState()
        {
            lock (SendTempList)
            {
                if (SendTempList.Count == 0 || SendTempList[SendTempList.Count - 1] != txtSend.Text)
                {
                    SendTempList.Add(txtSend.Text);
                }

                if (chkSendThenClear.Checked)
                {
                    SendTempIndex = SendTempList.Count;
                    //txtSendUpdate("");
                    txtSend.Clear();
                }
                else
                {
                    SendTempIndex = SendTempList.Count - 1;
                }
            }
        }


        #region ISendForm 成员

        public List<CSendParam> GetSendList()
        {
            try
            {
                List<CSendParam> list = new List<CSendParam>();

                if (txtSend.Text.Trim() == string.Empty)
                {
                    return list;
                }

                SendParamFormat format = SendParamFormat.ASCII;
                if (chkSendHex.Checked)
                {
                    format = SendParamFormat.Hex;
                }

                int sendInterval = Convert.ToInt32(numSendInterval.Value);
                CSendParam param = new CSendParam(format, SendParamMode.SendAfterLastSend, sendInterval, txtSend.Text);

                if (chkSendHex.Checked && chkFormat.Checked)
                {
                    txtSend.Text = param.Data;
                }

                int packetLen = Convert.ToInt32(numSendOnceBytes.Value);

                if (packetLen == 0)
                {
                    list.Add(param);
                }
                else
                {
                    byte[] dataBytes = param.DataBytes;

                    int bytesIndex = 0;
                    while (bytesIndex < param.DataLen)
                    {
                        int len = packetLen;
                        if (bytesIndex + packetLen > param.DataLen)
                        {
                            len = param.DataLen - bytesIndex;
                        }

                        int delayTime = sendInterval;

                        //if (bytesIndex==0)
                        //{
                        //    //delayTime = 0;
                        //}
                        CSendParam p = new CSendParam(format, SendParamMode.SendAfterLastSend, delayTime, dataBytes, bytesIndex, len);
                        list.Add(p);

                        bytesIndex += len;
                    }
                }

                updateSendState();

                return list;

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        public int LoopCount
        {
            get
            {
                if (chkAutoSend.Checked)
                {
                    return Convert.ToInt32(numSendCount.Value);
                }
                else
                {
                    return 1;
                }

            }
        }

        public bool EditEnable
        {
            get
            {
                return this.Enabled;
                //return txtSend.ReadOnly;
            }
            set
            {
                this.Enabled = value;
            }
        }

        #endregion

        private void lnkAddCheckCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtSend.Text != String.Empty)
                {
                    bool IsHex = chkSendHex.Checked;

                    bool topMost = this.ParentForm.TopMost;
                    this.ParentForm.TopMost = false;

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

                    this.ParentForm.TopMost = topMost;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labClearSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSend.Clear();
        }

        private void FormNormalSend_Load(object sender, EventArgs e)
        {
            LoadConfig();

        }

        private void FormNormalSend_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }


        public void LoadConfig()
        {
            chkSendHex.Checked = Properties.Settings.Default.normalHexSend;
            chkFormat.Checked = Properties.Settings.Default.normalHexFormat;
            chkSendThenClear.Checked = Properties.Settings.Default.normalSendClear;
            chkAutoSend.Checked = Properties.Settings.Default.normalLoopSend;
            numSendCount.Value = Properties.Settings.Default.normalLoopCount;
            numSendOnceBytes.Value = Properties.Settings.Default.normalPacketBytes;
            numSendInterval.Value = Properties.Settings.Default.normalInterval;
            txtSend.Text = Properties.Settings.Default.normalContent;

            SendTempIndex = 0;
            if (Properties.Settings.Default.HistorySendList == null)
            {
                Properties.Settings.Default.HistorySendList = new System.Collections.Specialized.StringCollection();
            }
            for (int i = 0; i < Properties.Settings.Default.HistorySendList.Count; i++)
            {
                lock (SendTempList)
                {
                    //SendTempList.Add(Properties.Settings.Default.HistorySendList[i]);
                    CSendParam param = new CSendParam(SendParamFormat.Hex, SendParamMode.SendAfterLastSend, 0, Properties.Settings.Default.HistorySendList[i]);
                    SendTempList.Add(param.ASCIIString);
                    SendTempIndex++;
                    if (SendTempIndex == 100)
                    {
                        SendTempList.RemoveAt(0);
                        SendTempIndex--;
                    }
                }

            }
        }

        public void SaveConfig()
        {
            Properties.Settings.Default.normalHexSend = chkSendHex.Checked;
            Properties.Settings.Default.normalHexFormat = chkFormat.Checked;
            Properties.Settings.Default.normalSendClear = chkSendThenClear.Checked;
            Properties.Settings.Default.normalLoopSend = chkAutoSend.Checked;
            Properties.Settings.Default.normalLoopCount = (int)numSendCount.Value;
            Properties.Settings.Default.normalPacketBytes = (int)numSendOnceBytes.Value;
            Properties.Settings.Default.normalInterval = (int)numSendInterval.Value;
            Properties.Settings.Default.normalContent = txtSend.Text;

            Properties.Settings.Default.HistorySendList.Clear();
            for (int i = 0; i < SendTempList.Count; i++)
            {

                CSendParam param = new CSendParam(SendParamFormat.ASCII, SendParamMode.SendAfterLastSend, 0, SendTempList[i]);
                Properties.Settings.Default.HistorySendList.Add(param.HexString);
            }

            Properties.Settings.Default.Save();
        }

        private void panelNormalSend_Paint(object sender, PaintEventArgs e)
        {
            //txtSend.Font = Properties.Settings.Default.receiveFont;
        }




        
    }
}