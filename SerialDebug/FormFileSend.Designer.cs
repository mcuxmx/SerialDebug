namespace SerialDebug
{
    partial class FormFileSend
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFileProtocol = new System.Windows.Forms.ComboBox();
            this.chkSlipPacket = new System.Windows.Forms.CheckBox();
            this.numPacketLen = new System.Windows.Forms.NumericUpDown();
            this.chkSendByLine = new System.Windows.Forms.CheckBox();
            this.labDelayTime = new System.Windows.Forms.Label();
            this.numDelayTime = new System.Windows.Forms.NumericUpDown();
            this.chkSendCRRF = new System.Windows.Forms.CheckBox();
            this.chkShowDataStream = new System.Windows.Forms.CheckBox();
            this.labReport = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPacketLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择文件：";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(84, 36);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(359, 21);
            this.txtFile.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.Location = new System.Drawing.Point(446, 35);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "浏览...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(20, 113);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(499, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "传输协议：";
            // 
            // cbFileProtocol
            // 
            this.cbFileProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileProtocol.FormattingEnabled = true;
            this.cbFileProtocol.Location = new System.Drawing.Point(84, 6);
            this.cbFileProtocol.Name = "cbFileProtocol";
            this.cbFileProtocol.Size = new System.Drawing.Size(187, 20);
            this.cbFileProtocol.TabIndex = 5;
            this.cbFileProtocol.SelectedIndexChanged += new System.EventHandler(this.cbFileProtocol_SelectedIndexChanged);
            // 
            // chkSlipPacket
            // 
            this.chkSlipPacket.AutoSize = true;
            this.chkSlipPacket.Location = new System.Drawing.Point(20, 72);
            this.chkSlipPacket.Name = "chkSlipPacket";
            this.chkSlipPacket.Size = new System.Drawing.Size(144, 16);
            this.chkSlipPacket.TabIndex = 6;
            this.chkSlipPacket.Text = "分包发送，每包字节：";
            this.chkSlipPacket.UseVisualStyleBackColor = true;
            // 
            // numPacketLen
            // 
            this.numPacketLen.Location = new System.Drawing.Point(156, 70);
            this.numPacketLen.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numPacketLen.Name = "numPacketLen";
            this.numPacketLen.Size = new System.Drawing.Size(55, 21);
            this.numPacketLen.TabIndex = 7;
            this.numPacketLen.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // chkSendByLine
            // 
            this.chkSendByLine.AutoSize = true;
            this.chkSendByLine.Location = new System.Drawing.Point(20, 72);
            this.chkSendByLine.Name = "chkSendByLine";
            this.chkSendByLine.Size = new System.Drawing.Size(72, 16);
            this.chkSendByLine.TabIndex = 6;
            this.chkSendByLine.Text = "按行发送";
            this.chkSendByLine.UseVisualStyleBackColor = true;
            // 
            // labDelayTime
            // 
            this.labDelayTime.AutoSize = true;
            this.labDelayTime.Location = new System.Drawing.Point(238, 74);
            this.labDelayTime.Name = "labDelayTime";
            this.labDelayTime.Size = new System.Drawing.Size(89, 12);
            this.labDelayTime.TabIndex = 8;
            this.labDelayTime.Text = "延时时间(ms)：";
            // 
            // numDelayTime
            // 
            this.numDelayTime.Location = new System.Drawing.Point(324, 70);
            this.numDelayTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDelayTime.Name = "numDelayTime";
            this.numDelayTime.Size = new System.Drawing.Size(55, 21);
            this.numDelayTime.TabIndex = 7;
            this.numDelayTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkSendCRRF
            // 
            this.chkSendCRRF.AutoSize = true;
            this.chkSendCRRF.Location = new System.Drawing.Point(129, 72);
            this.chkSendCRRF.Name = "chkSendCRRF";
            this.chkSendCRRF.Size = new System.Drawing.Size(84, 16);
            this.chkSendCRRF.TabIndex = 6;
            this.chkSendCRRF.Text = "发送换行符";
            this.chkSendCRRF.UseVisualStyleBackColor = true;
            // 
            // chkShowDataStream
            // 
            this.chkShowDataStream.AutoSize = true;
            this.chkShowDataStream.Location = new System.Drawing.Point(301, 10);
            this.chkShowDataStream.Name = "chkShowDataStream";
            this.chkShowDataStream.Size = new System.Drawing.Size(84, 16);
            this.chkShowDataStream.TabIndex = 9;
            this.chkShowDataStream.Text = "显示数据流";
            this.toolTip1.SetToolTip(this.chkShowDataStream, "显示文件传输过程中的数据流\r\n同时也需要将接收区对应设置显示");
            this.chkShowDataStream.UseVisualStyleBackColor = true;
            // 
            // labReport
            // 
            this.labReport.AutoSize = true;
            this.labReport.Location = new System.Drawing.Point(21, 98);
            this.labReport.Name = "labReport";
            this.labReport.Size = new System.Drawing.Size(41, 12);
            this.labReport.TabIndex = 10;
            this.labReport.Text = "label3";
            // 
            // FormFileSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 142);
            this.Controls.Add(this.labReport);
            this.Controls.Add(this.chkShowDataStream);
            this.Controls.Add(this.numDelayTime);
            this.Controls.Add(this.labDelayTime);
            this.Controls.Add(this.numPacketLen);
            this.Controls.Add(this.chkSendCRRF);
            this.Controls.Add(this.chkSendByLine);
            this.Controls.Add(this.chkSlipPacket);
            this.Controls.Add(this.cbFileProtocol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFileSend";
            this.Text = "FormNormalSend";
            this.Load += new System.EventHandler(this.FormFileSend_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFileSend_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numPacketLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFileProtocol;
        private System.Windows.Forms.CheckBox chkSlipPacket;
        private System.Windows.Forms.NumericUpDown numPacketLen;
        private System.Windows.Forms.CheckBox chkSendByLine;
        private System.Windows.Forms.Label labDelayTime;
        private System.Windows.Forms.NumericUpDown numDelayTime;
        private System.Windows.Forms.CheckBox chkSendCRRF;
        private System.Windows.Forms.CheckBox chkShowDataStream;
        private System.Windows.Forms.Label labReport;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}