using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialDebug
{
    public partial class FormQueueSend : Form, ISendForm
    {
        public delegate void ManualSendEventHandler(object sender, ManualSendEventArgs e);
        public event ManualSendEventHandler ManualSendEvent;
        public event System.EventHandler ParamSetOpend;
        public event System.EventHandler ParamSetClosed;

        private readonly int RowNoIndex = 0;
        private readonly int RowSendIndex = 1;
        private readonly int RowEnableIndex = 2;
        private readonly int RowParamIndex = 3;
        private readonly int RowContentIndex = 4;

        double splitPercent = 0;
        public FormQueueSend()
        {
            InitializeComponent();
        }

        private void FormQueueSend_Load(object sender, EventArgs e)
        {
            chkSendHex.Checked = true;
            cbSendMode.SelectedIndex = 0;
            numSendListDelayTime.Value = 10;

            splitPercent = (double)splitContainer1.SplitterDistance / splitContainer1.Height;
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnAddSendList_Click(object sender, EventArgs e)
        {
            if (panelSendParam.Visible == false)
            {

                panelSendParam.Visible = true;


                btnAddSendList.Image = Properties.Resources.round_minus;
                //btnAddSendList.Enabled = false;
                btnDeleteSendList.Enabled = false;
                btnSetupSendList.Enabled = false;
                btnSetdownSendList.Enabled = false;

                OpenParamSet(sender, e);
            }
            else
            {
                panelSendParam.Visible = false;


                btnAddSendList.Image = Properties.Resources.round_plus;
                //btnAddSendList.Enabled = false;
                btnDeleteSendList.Enabled = true;
                btnSetupSendList.Enabled = true;
                btnSetdownSendList.Enabled = true;

                CloseParamSet(sender, e);
            }

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

        public List<CSendParam> getSendList()
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

        private void linkLabelClearData_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSend.Clear();
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