namespace SerialDebug
{
    partial class frmQueueSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSendParam = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.chkTitleAuto = new System.Windows.Forms.CheckBox();
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
            this.panelSendParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendListDelayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSendParam
            // 
            this.panelSendParam.Controls.Add(this.txtTitle);
            this.panelSendParam.Controls.Add(this.chkTitleAuto);
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
            this.panelSendParam.Size = new System.Drawing.Size(520, 200);
            this.panelSendParam.TabIndex = 49;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(102, 31);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(401, 21);
            this.txtTitle.TabIndex = 38;
            // 
            // chkTitleAuto
            // 
            this.chkTitleAuto.AutoSize = true;
            this.chkTitleAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkTitleAuto.Location = new System.Drawing.Point(6, 33);
            this.chkTitleAuto.Name = "chkTitleAuto";
            this.chkTitleAuto.Size = new System.Drawing.Size(90, 17);
            this.chkTitleAuto.TabIndex = 37;
            this.chkTitleAuto.Text = "与内容一致";
            this.chkTitleAuto.UseVisualStyleBackColor = true;
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
            this.lnkAddCheckCode.Location = new System.Drawing.Point(168, 65);
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
            this.linkLabelClearData.Location = new System.Drawing.Point(72, 65);
            this.linkLabelClearData.Name = "linkLabelClearData";
            this.linkLabelClearData.Size = new System.Drawing.Size(77, 12);
            this.linkLabelClearData.TabIndex = 6;
            this.linkLabelClearData.TabStop = true;
            this.linkLabelClearData.Text = " 清空发送区 ";
            this.linkLabelClearData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearData_LinkClicked);
            // 
            // btnCancelSaveParam
            // 
            this.btnCancelSaveParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSaveParam.Location = new System.Drawing.Point(462, 165);
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
            this.btnSaveSendParam.Location = new System.Drawing.Point(462, 136);
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
            this.label18.Location = new System.Drawing.Point(12, 65);
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
            this.txtSend.Location = new System.Drawing.Point(3, 80);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(453, 117);
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
            // frmQueueSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(520, 200);
            this.Controls.Add(this.panelSendParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQueueSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "队列发送设置";
            this.Load += new System.EventHandler(this.frmQueueSetting_Load);
            this.panelSendParam.ResumeLayout(false);
            this.panelSendParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendListDelayTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSendParam;
        internal System.Windows.Forms.CheckBox chkSendHex;
        internal System.Windows.Forms.LinkLabel lnkAddCheckCode;
        private System.Windows.Forms.LinkLabel linkLabelClearData;
        private System.Windows.Forms.Button btnCancelSaveParam;
        private System.Windows.Forms.Button btnSaveSendParam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numSendListDelayTime;
        private System.Windows.Forms.ComboBox cbSendMode;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.CheckBox chkTitleAuto;
    }
}