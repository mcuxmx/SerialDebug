namespace SerialDebug
{
    partial class FormQueueSend
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueueSend));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelSendParam = new System.Windows.Forms.Panel();
            this.chkSendHex = new System.Windows.Forms.CheckBox();
            this.lnkAddCheckCode = new System.Windows.Forms.LinkLabel();
            this.linkLabelClearData = new System.Windows.Forms.LinkLabel();
            this.btnCancelSaveParam = new System.Windows.Forms.Button();
            this.btnSaveSendParam = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.numSendListDelayTime = new System.Windows.Forms.NumericUpDown();
            this.cbSendMode = new System.Windows.Forms.ComboBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelSendList = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSetdownSendList = new System.Windows.Forms.Button();
            this.btnSetupSendList = new System.Windows.Forms.Button();
            this.btnDeleteSendList = new System.Windows.Forms.Button();
            this.btnAddSendList = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvSendList = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelSendParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendListDelayTime)).BeginInit();
            this.panelSendList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelSendParam);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelSendList);
            this.splitContainer1.Size = new System.Drawing.Size(536, 242);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelSendParam
            // 
            this.panelSendParam.Controls.Add(this.chkSendHex);
            this.panelSendParam.Controls.Add(this.lnkAddCheckCode);
            this.panelSendParam.Controls.Add(this.linkLabelClearData);
            this.panelSendParam.Controls.Add(this.btnCancelSaveParam);
            this.panelSendParam.Controls.Add(this.btnSaveSendParam);
            this.panelSendParam.Controls.Add(this.label18);
            this.panelSendParam.Controls.Add(this.numSendListDelayTime);
            this.panelSendParam.Controls.Add(this.cbSendMode);
            this.panelSendParam.Controls.Add(this.txtSend);
            this.panelSendParam.Controls.Add(this.label17);
            this.panelSendParam.Controls.Add(this.label16);
            this.panelSendParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSendParam.Location = new System.Drawing.Point(0, 0);
            this.panelSendParam.Name = "panelSendParam";
            this.panelSendParam.Size = new System.Drawing.Size(536, 100);
            this.panelSendParam.TabIndex = 48;
            this.panelSendParam.Visible = false;
            // 
            // chkSendHex
            // 
            this.chkSendHex.AutoSize = true;
            this.chkSendHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSendHex.Location = new System.Drawing.Point(6, 4);
            this.chkSendHex.Name = "chkSendHex";
            this.chkSendHex.Size = new System.Drawing.Size(72, 17);
            this.chkSendHex.TabIndex = 37;
            this.chkSendHex.Text = "HEX发送";
            this.chkSendHex.UseVisualStyleBackColor = true;
            // 
            // lnkAddCheckCode
            // 
            this.lnkAddCheckCode.AutoSize = true;
            this.lnkAddCheckCode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkAddCheckCode.Location = new System.Drawing.Point(160, 29);
            this.lnkAddCheckCode.Name = "lnkAddCheckCode";
            this.lnkAddCheckCode.Size = new System.Drawing.Size(65, 12);
            this.lnkAddCheckCode.TabIndex = 35;
            this.lnkAddCheckCode.TabStop = true;
            this.lnkAddCheckCode.Text = "添加校验码";
            this.lnkAddCheckCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddCheckCode_LinkClicked);
            // 
            // linkLabelClearData
            // 
            this.linkLabelClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelClearData.AutoSize = true;
            this.linkLabelClearData.Location = new System.Drawing.Point(62, 29);
            this.linkLabelClearData.Name = "linkLabelClearData";
            this.linkLabelClearData.Size = new System.Drawing.Size(77, 12);
            this.linkLabelClearData.TabIndex = 6;
            this.linkLabelClearData.TabStop = true;
            this.linkLabelClearData.Text = " 清空发送区 ";
            this.linkLabelClearData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearData_LinkClicked_1);
            // 
            // btnCancelSaveParam
            // 
            this.btnCancelSaveParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSaveParam.Location = new System.Drawing.Point(478, 66);
            this.btnCancelSaveParam.Name = "btnCancelSaveParam";
            this.btnCancelSaveParam.Size = new System.Drawing.Size(55, 23);
            this.btnCancelSaveParam.TabIndex = 5;
            this.btnCancelSaveParam.Text = "取消";
            this.btnCancelSaveParam.UseVisualStyleBackColor = true;
            this.btnCancelSaveParam.Click += new System.EventHandler(this.btnCancelSaveParam_Click);
            // 
            // btnSaveSendParam
            // 
            this.btnSaveSendParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSendParam.Location = new System.Drawing.Point(478, 43);
            this.btnSaveSendParam.Name = "btnSaveSendParam";
            this.btnSaveSendParam.Size = new System.Drawing.Size(55, 23);
            this.btnSaveSendParam.TabIndex = 5;
            this.btnSaveSendParam.Text = "确定";
            this.btnSaveSendParam.UseVisualStyleBackColor = true;
            this.btnSaveSendParam.Click += new System.EventHandler(this.btnSaveSendParam_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "数据内容：";
            // 
            // numSendListDelayTime
            // 
            this.numSendListDelayTime.Location = new System.Drawing.Point(423, 2);
            this.numSendListDelayTime.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.numSendListDelayTime.Name = "numSendListDelayTime";
            this.numSendListDelayTime.Size = new System.Drawing.Size(80, 21);
            this.numSendListDelayTime.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numSendListDelayTime, "两种模式下均会延时\r\n若不想延时将该值设为0");
            // 
            // cbSendMode
            // 
            this.cbSendMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSendMode.FormattingEnabled = true;
            this.cbSendMode.Items.AddRange(new object[] {
            "上帧发送完成后",
            "接收到数据帧后"});
            this.cbSendMode.Location = new System.Drawing.Point(170, 2);
            this.cbSendMode.Name = "cbSendMode";
            this.cbSendMode.Size = new System.Drawing.Size(139, 20);
            this.cbSendMode.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(3, 44);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(469, 53);
            this.txtSend.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(365, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "延时(ms)：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "发送模式：";
            // 
            // panelSendList
            // 
            this.panelSendList.Controls.Add(this.btnOpen);
            this.panelSendList.Controls.Add(this.btnSave);
            this.panelSendList.Controls.Add(this.btnSetdownSendList);
            this.panelSendList.Controls.Add(this.btnSetupSendList);
            this.panelSendList.Controls.Add(this.btnDeleteSendList);
            this.panelSendList.Controls.Add(this.btnAddSendList);
            this.panelSendList.Controls.Add(this.label15);
            this.panelSendList.Controls.Add(this.dgvSendList);
            this.panelSendList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSendList.Location = new System.Drawing.Point(0, 0);
            this.panelSendList.Name = "panelSendList";
            this.panelSendList.Size = new System.Drawing.Size(536, 141);
            this.panelSendList.TabIndex = 47;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(473, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(30, 24);
            this.btnOpen.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnOpen, "从文件中加载发送队列");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(503, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 24);
            this.btnSave.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnSave, "保存发送队列");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSetdownSendList
            // 
            this.btnSetdownSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnSetdownSendList.Image")));
            this.btnSetdownSendList.Location = new System.Drawing.Point(149, 0);
            this.btnSetdownSendList.Name = "btnSetdownSendList";
            this.btnSetdownSendList.Size = new System.Drawing.Size(30, 24);
            this.btnSetdownSendList.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnSetdownSendList, "下移");
            this.btnSetdownSendList.UseVisualStyleBackColor = true;
            this.btnSetdownSendList.Click += new System.EventHandler(this.btnSetdownSendList_Click);
            // 
            // btnSetupSendList
            // 
            this.btnSetupSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnSetupSendList.Image")));
            this.btnSetupSendList.Location = new System.Drawing.Point(120, 0);
            this.btnSetupSendList.Name = "btnSetupSendList";
            this.btnSetupSendList.Size = new System.Drawing.Size(30, 24);
            this.btnSetupSendList.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnSetupSendList, "上移");
            this.btnSetupSendList.UseVisualStyleBackColor = true;
            this.btnSetupSendList.Click += new System.EventHandler(this.btnSetupSendList_Click);
            // 
            // btnDeleteSendList
            // 
            this.btnDeleteSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSendList.Image")));
            this.btnDeleteSendList.Location = new System.Drawing.Point(91, 0);
            this.btnDeleteSendList.Name = "btnDeleteSendList";
            this.btnDeleteSendList.Size = new System.Drawing.Size(30, 24);
            this.btnDeleteSendList.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnDeleteSendList, "删除选中数据");
            this.btnDeleteSendList.UseVisualStyleBackColor = true;
            this.btnDeleteSendList.Click += new System.EventHandler(this.btnDeleteSendList_Click);
            // 
            // btnAddSendList
            // 
            this.btnAddSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSendList.Image")));
            this.btnAddSendList.Location = new System.Drawing.Point(62, 0);
            this.btnAddSendList.Name = "btnAddSendList";
            this.btnAddSendList.Size = new System.Drawing.Size(30, 24);
            this.btnAddSendList.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnAddSendList, "添加发送数据");
            this.btnAddSendList.UseVisualStyleBackColor = true;
            this.btnAddSendList.Click += new System.EventHandler(this.btnAddSendList_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(3, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 34;
            this.label15.Text = "发送区：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSendList
            // 
            this.dgvSendList.AllowUserToAddRows = false;
            this.dgvSendList.AllowUserToResizeRows = false;
            this.dgvSendList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSendList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSendList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSendList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSendList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colSend,
            this.colEnable,
            this.colMode,
            this.colData});
            this.dgvSendList.Location = new System.Drawing.Point(3, 26);
            this.dgvSendList.MultiSelect = false;
            this.dgvSendList.Name = "dgvSendList";
            this.dgvSendList.ReadOnly = true;
            this.dgvSendList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSendList.RowHeadersVisible = false;
            this.dgvSendList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSendList.RowTemplate.Height = 23;
            this.dgvSendList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSendList.Size = new System.Drawing.Size(530, 112);
            this.dgvSendList.TabIndex = 0;
            this.dgvSendList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSendList_CellClick);
            this.dgvSendList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSendList_CellMouseDoubleClick);
            // 
            // colNo
            // 
            this.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNo.FillWeight = 48.73096F;
            this.colNo.HeaderText = "序号";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNo.Width = 36;
            // 
            // colSend
            // 
            this.colSend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSend.FillWeight = 104.8391F;
            this.colSend.HeaderText = "手动";
            this.colSend.Name = "colSend";
            this.colSend.ReadOnly = true;
            this.colSend.Width = 64;
            // 
            // colEnable
            // 
            this.colEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEnable.FillWeight = 127.1243F;
            this.colEnable.HeaderText = "使能";
            this.colEnable.Name = "colEnable";
            this.colEnable.ReadOnly = true;
            this.colEnable.Width = 36;
            // 
            // colMode
            // 
            this.colMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMode.FillWeight = 117.0897F;
            this.colMode.HeaderText = "模式";
            this.colMode.Name = "colMode";
            this.colMode.ReadOnly = true;
            this.colMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMode.Width = 72;
            // 
            // colData
            // 
            this.colData.FillWeight = 82.31606F;
            this.colData.HeaderText = "数据";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormQueueSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 242);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQueueSend";
            this.Text = "FormNormalSend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQueueSend_FormClosing);
            this.Load += new System.EventHandler(this.FormQueueSend_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panelSendParam.ResumeLayout(false);
            this.panelSendParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendListDelayTime)).EndInit();
            this.panelSendList.ResumeLayout(false);
            this.panelSendList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelSendList;
        private System.Windows.Forms.Button btnSetdownSendList;
        private System.Windows.Forms.Button btnSetupSendList;
        private System.Windows.Forms.Button btnDeleteSendList;
        private System.Windows.Forms.Button btnAddSendList;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvSendList;
        private System.Windows.Forms.Panel panelSendParam;
        private System.Windows.Forms.LinkLabel linkLabelClearData;
        private System.Windows.Forms.Button btnCancelSaveParam;
        private System.Windows.Forms.Button btnSaveSendParam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numSendListDelayTime;
        private System.Windows.Forms.ComboBox cbSendMode;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.LinkLabel lnkAddCheckCode;
        internal System.Windows.Forms.CheckBox chkSendHex;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewButtonColumn colSend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
    }
}