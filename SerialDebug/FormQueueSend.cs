using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SerialDebug
{
    public partial class FormQueueSend : Form, ISendForm
    {
        public delegate void ManualSendEventHandler(object sender, ManualSendEventArgs e);
        public event ManualSendEventHandler ManualSendEvent;
        public event System.EventHandler ParamSetOpend;
        public event System.EventHandler ParamSetClosed;

        //private readonly int RowNoIndex = 0;
        //private readonly int RowSendIndex = 1;
        private readonly int RowEnableIndex = 2;
        private readonly int RowParamIndex = 3;
        private readonly int RowContentIndex = 4;

        double splitPercent = 0;
        public FormQueueSend()
        {
            InitializeComponent();
        }


        private void LoadSendQueueByContent(string content)
        {
            dgvSendList.Rows.Clear();
            dgvSendList.Columns[1].Width = 64;
            string[] listArray = content.Split(new string[] { "}{", "}\r\n{", "}\n{" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string list in listArray)
            {
                object[] array = new object[5];
                string title = "";
                string[] cells = list.Trim(new char[] { '\r', '\n' }).Trim(new char[] { '<', '>' }).Split(new string[] { "><", "{<", ">}", ">}\r\n", ">}\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (cells.Length == dgvSendList.Columns.Count - 2)
                {

                    array[0] = dgvSendList.Rows.Count;
                    array[1] = "Send";
                    array[2] = Convert.ToBoolean(cells[0]);
                    array[3] = cells[1];
                    array[4] = cells[2];

                }
                else if (cells.Length == dgvSendList.ColumnCount)
                {
                    array[0] = dgvSendList.Rows.Count;
                    array[1] = cells[1];
                    array[2] = Convert.ToBoolean(cells[2]);
                    array[3] = cells[3];
                    array[4] = cells[4];

                }

                title = Convert.ToString(array[1]);
                int width = System.Text.ASCIIEncoding.ASCII.GetByteCount(Convert.ToString(array[1])) * 16;

                if (width < 200 && dgvSendList.Columns[1].Width < width)
                {
                    dgvSendList.Columns[1].Width = width;
                }
                dgvSendList.Rows.Add(array);
            }
        }

        public void LoadConfig()
        {
            chkSendHex.Checked = Properties.Settings.Default.queueHexSend;
            cbSendMode.SelectedIndex = Properties.Settings.Default.queueSendMode;
            numSendListDelayTime.Value = Properties.Settings.Default.queueDelayTime;
            txtSend.Text = Properties.Settings.Default.queueContent;
            //txtSend.Font = Properties.Settings.Default.receiveFont;
            LoadSendQueueByContent(Properties.Settings.Default.queueList);

        }

        private string GetSendQueueString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow row in dgvSendList.Rows)
            {
                sb.Append(@"{");
                for (int i = 0; i < dgvSendList.Columns.Count; i++)
                {
                    sb.AppendFormat(@"<{0}>", row.Cells[i].Value.ToString());
                }
                sb.Append(@"}");
                sb.Append("\r\n");
            }

            return sb.ToString();
        }

        public void SaveConfig()
        {
            Properties.Settings.Default.queueHexSend = chkSendHex.Checked;
            Properties.Settings.Default.queueSendMode = cbSendMode.SelectedIndex;
            Properties.Settings.Default.queueDelayTime = (int)numSendListDelayTime.Value;
            Properties.Settings.Default.queueContent = txtSend.Text;


            Properties.Settings.Default.queueList = GetSendQueueString();

            Properties.Settings.Default.Save();
        }

        private void FormQueueSend_Load(object sender, EventArgs e)
        {
            chkSendHex.Checked = true;
            cbSendMode.SelectedIndex = 0;
            numSendListDelayTime.Value = 10;

            splitPercent = (double)splitContainer1.SplitterDistance / splitContainer1.Height;
            splitContainer1.Panel1Collapsed = true;

            LoadConfig();
        }

        private void FormQueueSend_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        private void btnAddSendList_Click(object sender, EventArgs e)
        {
            //if (panelSendParam.Visible == false)
            //{

            //    panelSendParam.Visible = true;


            //    btnAddSendList.Image = Properties.Resources.round_minus;
            //    //btnAddSendList.Enabled = false;
            //    btnDeleteSendList.Enabled = false;
            //    btnSetupSendList.Enabled = false;
            //    btnSetdownSendList.Enabled = false;

            //    OpenParamSet(sender, e);
            //}
            //else
            //{
            //    panelSendParam.Visible = false;


            //    btnAddSendList.Image = Properties.Resources.round_plus;
            //    //btnAddSendList.Enabled = false;
            //    btnDeleteSendList.Enabled = true;
            //    btnSetupSendList.Enabled = true;
            //    btnSetdownSendList.Enabled = true;

            //    CloseParamSet(sender, e);
            //}

            bool topMost = this.ParentForm.TopMost;
            this.ParentForm.TopMost = false;

            frmQueueSetting frm = new frmQueueSetting();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                QueueSendObject obj = frm.SendObject;

                object[] array = new object[5];
                array[0] = dgvSendList.Rows.Count;
                array[1] = obj.Title;
                array[2] = obj.Enable;
                array[3] = obj.Mode;
                array[4] = obj.Content;
                dgvSendList.Rows.Add(array);
            }

            this.ParentForm.TopMost = topMost;

        }

        /// <summary>
        /// 退出保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelSaveParam_Click(object sender, EventArgs e)
        {

            panelSendParam.Visible = false;

            btnAddSendList.Image = Properties.Resources.round_plus;

            btnAddSendList.Enabled = true;
            btnDeleteSendList.Enabled = true;
            btnSetupSendList.Enabled = true;
            btnSetdownSendList.Enabled = true;


            CloseParamSet(sender, e);
        }

        /// <summary>
        /// 保存发送参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                object[] array = new object[5];
                array[0] = dgvSendList.Rows.Count;
                array[1] = "Send";
                array[2] = true;
                array[3] = param.ParameterString;
                array[4] = param.Data;
                dgvSendList.Rows.Add(array);

                btnCancelSaveParam.PerformClick();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        /// <summary>
        /// 删除发送项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteSendList_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSendList.SelectedRows == null)
                {
                    return;
                }

                if (dgvSendList.SelectedRows.Count <= 0)
                {
                    return;
                }
                DataGridViewRow selectedRow = dgvSendList.SelectedRows[0];


                int rowNo = Convert.ToInt32(selectedRow.Cells[0].Value);
                dgvSendList.Rows.RemoveAt(selectedRow.Index);
                while (rowNo < dgvSendList.Rows.Count)
                {
                    dgvSendList.Rows[rowNo].Cells[0].Value = rowNo;
                    rowNo++;
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        /// <summary>
        /// 发送项上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetupSendList_Click(object sender, EventArgs e)
        {
            if (dgvSendList.SelectedRows == null)
            {
                return;
            }

            if (dgvSendList.SelectedRows.Count <= 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvSendList.SelectedRows[0];

            if (selectedRow.Index > 0)
            {
                DataGridViewRow row = dgvSendList.Rows[selectedRow.Index - 1];
                for (int i = 1; i < dgvSendList.Columns.Count; i++)
                {
                    object value = selectedRow.Cells[i].Value;
                    selectedRow.Cells[i].Value = row.Cells[i].Value;
                    row.Cells[i].Value = value;

                }

                row.Selected = true;
            }

        }

        /// <summary>
        /// 发送项下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetdownSendList_Click(object sender, EventArgs e)
        {
            if (dgvSendList.SelectedRows == null)
            {
                return;
            }

            if (dgvSendList.SelectedRows.Count <= 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvSendList.SelectedRows[0];

            if (selectedRow.Index < dgvSendList.Rows.Count - 1)
            {
                DataGridViewRow row = dgvSendList.Rows[selectedRow.Index + 1];
                for (int i = 1; i < dgvSendList.Columns.Count; i++)
                {
                    object value = selectedRow.Cells[i].Value;
                    selectedRow.Cells[i].Value = row.Cells[i].Value;
                    row.Cells[i].Value = value;

                }

                row.Selected = true;
            }
        }

        private void linkLabelClearData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSend.Clear();
        }


        void OpenParamSet(object sender, EventArgs e)
        {

            splitContainer1.Panel1Collapsed = false;
            splitContainer1.SplitterDistance = 59;//Convert.ToInt32(splitPercent * splitContainer1.Height);
            if (ParamSetOpend != null)
            {
                ParamSetOpend(sender, e);
            }
        }

        void CloseParamSet(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            if (ParamSetClosed != null)
            {
                ParamSetClosed(sender, e);
            }
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


        public int ParamSetHeight
        {
            get
            {
                return 100;
            }
        }

        #region ISendForm 成员

        public List<CSendParam> GetSendList()
        {
            List<CSendParam> list = new List<CSendParam>();
            foreach (DataGridViewRow row in dgvSendList.Rows)
            {
                if ((bool)row.Cells[RowEnableIndex].Value == true)
                {
                    //string[] paramsArray = row.Cells[3].Value.ToString().Split(new char[] { ':' });
                    //CSendParam sendParam = new CSendParam(
                    //    (SendParamFormat)Convert.ToInt32(paramsArray[0]),
                    //    (SendParamMode)Convert.ToInt32(paramsArray[1]),
                    //    Convert.ToInt32(paramsArray[2]),
                    //    row.Cells[4].Value.ToString());

                    CSendParam sendParam = getSendParamByMode(row.Cells[RowParamIndex].Value.ToString(),
                        row.Cells[RowContentIndex].Value.ToString());
                    list.Add(sendParam);
                }

            }

            return list;
        }

        public int LoopCount
        {
            get { return 1; }
        }

        private bool _EditEnable = true;
        public bool EditEnable
        {
            get
            {
                return _EditEnable;
            }
            set
            {
                _EditEnable = value;
                //btnAddSendList.Enabled = value;
                //btnDeleteSendList.Enabled = value;
                //btnSetupSendList.Enabled = value;
                //btnSetdownSendList.Enabled = value;
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
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvSendList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvSendList.Rows[e.RowIndex];
            if (e.ColumnIndex == 1)   // Send button
            {
                CSendParam sendParam = getSendParamByMode(row.Cells[RowParamIndex].Value.ToString(),
                        row.Cells[RowContentIndex].Value.ToString());
                sendParam.Mode = SendParamMode.SendAfterLastSend;
                sendParam.DelayTime = 0;
                if (ManualSendEvent != null)
                {
                    ManualSendEvent(this, new ManualSendEventArgs(sendParam));
                }
            }
            else if (e.ColumnIndex == RowEnableIndex) // enable
            {
                row.Cells[e.ColumnIndex].Value = !Convert.ToBoolean(row.Cells[e.ColumnIndex].Value);
            }
        }

        private void dgvSendList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            if (e.RowIndex >= dgvSendList.RowCount || 
                e.ColumnIndex == 1 || e.ColumnIndex == 2)    // 发送列和使能列不允许双击操作
            {
                return;
            }


            DataGridViewRow row = dgvSendList.Rows[e.RowIndex];

            object[] items = new object[row.Cells.Count];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = row.Cells[i].Value;
            }


            bool topMost = this.ParentForm.TopMost;
            this.ParentForm.TopMost = false;

            frmQueueSetting frm = new frmQueueSetting(items);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                QueueSendObject obj = frm.SendObject;
                row.Cells[1].Value = obj.Title;
                row.Cells[2].Value = obj.Enable;
                row.Cells[3].Value = obj.Mode;
                row.Cells[4].Value = obj.Content;
            }

            this.ParentForm.TopMost = topMost;
        }

        private void linkLabelClearData_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSend.Clear();
        }

        private readonly string QueueFileHeader = "Serial Debug Queue List V1.1";

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog oFileDlg = new OpenFileDialog();
                oFileDlg.Filter = "Serial Debug List(*.sdlist)|*.sdlist";
                oFileDlg.DefaultExt = Application.StartupPath;
                oFileDlg.Multiselect = false;

                if (oFileDlg.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(oFileDlg.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    StreamReader sr = new StreamReader(oFileDlg.FileName, Encoding.Unicode);

                    try
                    {
                        string header = sr.ReadLine();
                        if (header == QueueFileHeader || header.StartsWith("Serial Debug") || header.ToLower().StartsWith("serialdebug"))
                        {
                            string content = sr.ReadToEnd();
                            LoadSendQueueByContent(content);
                        }
                        else
                        {
                            MessageBox.Show("无法识别该文件", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sr.Close();
                        fs.Close();
                    }

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sFileDlg = new SaveFileDialog();
                sFileDlg.Filter = "Serial Debug List(*.sdlist)|*.sdlist";
                sFileDlg.DefaultExt = "*.sdlist";
                sFileDlg.FileName = "serial_debug_sendlist";
                sFileDlg.InitialDirectory = Application.StartupPath;
                sFileDlg.OverwritePrompt = true;

                if (sFileDlg.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(QueueFileHeader);
                    sb.Append(GetSendQueueString());


                    FileStream fs = new FileStream(sFileDlg.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sr = new StreamWriter(fs, Encoding.Unicode);

                    sr.Write(sb.ToString());
                    sr.Close();
                    fs.Close();

                    //File.WriteAllText(sFileDlg.FileName, sb.ToString());
                    //MessageBox.Show("文件已保存到\n" + sFileDlg.FileName, sFileDlg.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




    }


    public class ManualSendEventArgs : EventArgs
    {
        public readonly List<CSendParam> _SendList;

        public ManualSendEventArgs(CSendParam sendParam)
        {
            _SendList = new List<CSendParam>();
            _SendList.Clear();
            _SendList.Add(sendParam);
        }

        public List<CSendParam> SendList
        {
            get { return _SendList; }
        }
    }
}