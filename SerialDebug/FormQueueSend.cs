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
        public event System.EventHandler ParamSetOpend;
        public event System.EventHandler ParamSetClosed;

        double splitPercent = 0;
        public FormQueueSend()
        {
            InitializeComponent();
        }

        private void FormQueueSend_Load(object sender, EventArgs e)
        {
            cbFormat.SelectedIndex = 0;
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

            if (txtSendParamData.Text == string.Empty)
            {
                MessageBox.Show("发送数据不能为空", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {

                CSendParam param = new CSendParam((SendParamFormat)cbFormat.SelectedIndex,
                (SendParamMode)cbSendMode.SelectedIndex,
                Convert.ToInt32(numSendListDelayTime.Value),
                txtSendParamData.Text);

                object[] array = new object[3];
                array[0] = dgvSendList.Rows.Count;
                array[1] = param.ParameterString;
                array[2] = param.Data;
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
            txtSendParamData.Clear();
        }


        void OpenParamSet(object sender, EventArgs e)
        {

            splitContainer1.Panel1Collapsed = false;
            splitContainer1.SplitterDistance = 59;//Convert.ToInt32(splitPercent * splitContainer1.Height);
            if (ParamSetOpend!=null)
            {
                ParamSetOpend(sender, e);
            }
        }

        void CloseParamSet(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            if (ParamSetClosed!=null)
            {
                ParamSetClosed(sender, e);
            }
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
                string[] paramsArray = row.Cells[1].Value.ToString().Split(new char[] { ':' });
                CSendParam sendParam = new CSendParam(
                    (SendParamFormat)Convert.ToInt32(paramsArray[0]),
                    (SendParamMode)Convert.ToInt32(paramsArray[1]),
                    Convert.ToInt32(paramsArray[2]),
                    row.Cells[2].Value.ToString());
                list.Add(sendParam);
            }

            return list;
        }

        public int LoopCount
        {
            get { return 1; }
        }

        #endregion
    }
}