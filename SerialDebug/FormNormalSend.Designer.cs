namespace SerialDebug
{
    partial class FormNormalSend
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
            this.panelNormalSend = new System.Windows.Forms.Panel();
            this.numSendCount = new System.Windows.Forms.NumericUpDown();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numSendInterval = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.numSendOnceBytes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkFormat = new System.Windows.Forms.CheckBox();
            this.chkSendHex = new System.Windows.Forms.CheckBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.chkSendThenClear = new System.Windows.Forms.CheckBox();
            this.labClearSend = new System.Windows.Forms.LinkLabel();
            this.Label7 = new System.Windows.Forms.Label();
            this.lnkAddCheckCode = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelNormalSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendOnceBytes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNormalSend
            // 
            this.panelNormalSend.Controls.Add(this.numSendCount);
            this.panelNormalSend.Controls.Add(this.chkAutoSend);
            this.panelNormalSend.Controls.Add(this.label11);
            this.panelNormalSend.Controls.Add(this.numSendInterval);
            this.panelNormalSend.Controls.Add(this.label10);
            this.panelNormalSend.Controls.Add(this.Label9);
            this.panelNormalSend.Controls.Add(this.numSendOnceBytes);
            this.panelNormalSend.Controls.Add(this.label6);
            this.panelNormalSend.Controls.Add(this.label12);
            this.panelNormalSend.Controls.Add(this.chkFormat);
            this.panelNormalSend.Controls.Add(this.chkSendHex);
            this.panelNormalSend.Controls.Add(this.txtSend);
            this.panelNormalSend.Controls.Add(this.chkSendThenClear);
            this.panelNormalSend.Controls.Add(this.labClearSend);
            this.panelNormalSend.Controls.Add(this.Label7);
            this.panelNormalSend.Controls.Add(this.lnkAddCheckCode);
            this.panelNormalSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNormalSend.Location = new System.Drawing.Point(0, 0);
            this.panelNormalSend.Name = "panelNormalSend";
            this.panelNormalSend.Size = new System.Drawing.Size(536, 142);
            this.panelNormalSend.TabIndex = 37;
            this.panelNormalSend.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNormalSend_Paint);
            // 
            // numSendCount
            // 
            this.numSendCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numSendCount.Location = new System.Drawing.Point(89, 118);
            this.numSendCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSendCount.Name = "numSendCount";
            this.numSendCount.Size = new System.Drawing.Size(48, 21);
            this.numSendCount.TabIndex = 46;
            this.toolTip1.SetToolTip(this.numSendCount, "输入0时无限循环");
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.BackColor = System.Drawing.SystemColors.Control;
            this.chkAutoSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkAutoSend.Location = new System.Drawing.Point(15, 120);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(90, 17);
            this.chkAutoSend.TabIndex = 44;
            this.chkAutoSend.Text = "循环发送：";
            this.chkAutoSend.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(137, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "次";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSendInterval
            // 
            this.numSendInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numSendInterval.Location = new System.Drawing.Point(420, 118);
            this.numSendInterval.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSendInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSendInterval.Name = "numSendInterval";
            this.numSendInterval.Size = new System.Drawing.Size(48, 21);
            this.numSendInterval.TabIndex = 43;
            this.toolTip1.SetToolTip(this.numSendInterval, "输入0时无延时");
            this.numSendInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 42;
            this.label10.Text = "发送间隔：";
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(468, 122);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(29, 12);
            this.Label9.TabIndex = 41;
            this.Label9.Text = "毫秒";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSendOnceBytes
            // 
            this.numSendOnceBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numSendOnceBytes.Location = new System.Drawing.Point(261, 118);
            this.numSendOnceBytes.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSendOnceBytes.Name = "numSendOnceBytes";
            this.numSendOnceBytes.Size = new System.Drawing.Size(48, 21);
            this.numSendOnceBytes.TabIndex = 40;
            this.toolTip1.SetToolTip(this.numSendOnceBytes, "输入0时表示不分包");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "分包发送：每包";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(309, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "字节";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkFormat
            // 
            this.chkFormat.AutoSize = true;
            this.chkFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFormat.Location = new System.Drawing.Point(329, 2);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(108, 17);
            this.chkFormat.TabIndex = 37;
            this.chkFormat.Text = "HEX格式化显示";
            this.chkFormat.UseVisualStyleBackColor = true;
            this.chkFormat.CheckedChanged += new System.EventHandler(this.chkFormat_CheckedChanged);
            // 
            // chkSendHex
            // 
            this.chkSendHex.AutoSize = true;
            this.chkSendHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSendHex.Location = new System.Drawing.Point(254, 2);
            this.chkSendHex.Name = "chkSendHex";
            this.chkSendHex.Size = new System.Drawing.Size(72, 17);
            this.chkSendHex.TabIndex = 36;
            this.chkSendHex.Text = "HEX发送";
            this.chkSendHex.UseVisualStyleBackColor = true;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(3, 19);
            this.txtSend.MaxLength = 0;
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(530, 97);
            this.txtSend.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtSend, "上下键可直接键入历史发送数据\r\nCtrl+Enter快捷发送");
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // chkSendThenClear
            // 
            this.chkSendThenClear.AutoSize = true;
            this.chkSendThenClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSendThenClear.Location = new System.Drawing.Point(440, 2);
            this.chkSendThenClear.Name = "chkSendThenClear";
            this.chkSendThenClear.Size = new System.Drawing.Size(90, 17);
            this.chkSendThenClear.TabIndex = 8;
            this.chkSendThenClear.Text = "发送后清空";
            this.chkSendThenClear.UseVisualStyleBackColor = true;
            // 
            // labClearSend
            // 
            this.labClearSend.AutoSize = true;
            this.labClearSend.Location = new System.Drawing.Point(62, 4);
            this.labClearSend.Name = "labClearSend";
            this.labClearSend.Size = new System.Drawing.Size(77, 12);
            this.labClearSend.TabIndex = 35;
            this.labClearSend.TabStop = true;
            this.labClearSend.Text = " 清空发送区 ";
            this.labClearSend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labClearSend_LinkClicked);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Location = new System.Drawing.Point(3, 4);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(53, 12);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "发送区：";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkAddCheckCode
            // 
            this.lnkAddCheckCode.AutoSize = true;
            this.lnkAddCheckCode.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkAddCheckCode.Location = new System.Drawing.Point(161, 4);
            this.lnkAddCheckCode.Name = "lnkAddCheckCode";
            this.lnkAddCheckCode.Size = new System.Drawing.Size(65, 12);
            this.lnkAddCheckCode.TabIndex = 34;
            this.lnkAddCheckCode.TabStop = true;
            this.lnkAddCheckCode.Text = "添加校验码";
            this.lnkAddCheckCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddCheckCode_LinkClicked);
            // 
            // FormNormalSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 142);
            this.Controls.Add(this.panelNormalSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNormalSend";
            this.Text = "FormNormalSend";
            this.Load += new System.EventHandler(this.FormNormalSend_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNormalSend_FormClosing);
            this.panelNormalSend.ResumeLayout(false);
            this.panelNormalSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendOnceBytes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNormalSend;
        private System.Windows.Forms.TextBox txtSend;
        internal System.Windows.Forms.CheckBox chkSendThenClear;
        internal System.Windows.Forms.LinkLabel labClearSend;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.LinkLabel lnkAddCheckCode;
        internal System.Windows.Forms.CheckBox chkSendHex;
        internal System.Windows.Forms.CheckBox chkFormat;
        private System.Windows.Forms.NumericUpDown numSendOnceBytes;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numSendInterval;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.NumericUpDown numSendCount;
        internal System.Windows.Forms.CheckBox chkAutoSend;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}