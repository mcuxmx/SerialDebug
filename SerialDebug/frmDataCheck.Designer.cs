namespace SerialDebug
{
    partial class frmDataCheck
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
            this.cbDataCheckType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbCRCParam = new System.Windows.Forms.GroupBox();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.txtPoly = new System.Windows.Forms.TextBox();
            this.chkRefOut = new System.Windows.Forms.CheckBox();
            this.chkRefIn = new System.Windows.Forms.CheckBox();
            this.chkXorOut = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsLittleEndian = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbCRCParam.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDataCheckType
            // 
            this.cbDataCheckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataCheckType.FormattingEnabled = true;
            this.cbDataCheckType.Location = new System.Drawing.Point(128, 17);
            this.cbDataCheckType.Name = "cbDataCheckType";
            this.cbDataCheckType.Size = new System.Drawing.Size(150, 20);
            this.cbDataCheckType.TabIndex = 0;
            this.cbDataCheckType.SelectedIndexChanged += new System.EventHandler(this.cbDataCheckType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择校验类型：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(98, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbCRCParam
            // 
            this.gbCRCParam.Controls.Add(this.txtInit);
            this.gbCRCParam.Controls.Add(this.txtPoly);
            this.gbCRCParam.Controls.Add(this.chkRefOut);
            this.gbCRCParam.Controls.Add(this.chkRefIn);
            this.gbCRCParam.Controls.Add(this.chkXorOut);
            this.gbCRCParam.Controls.Add(this.label5);
            this.gbCRCParam.Controls.Add(this.label3);
            this.gbCRCParam.Location = new System.Drawing.Point(14, 48);
            this.gbCRCParam.Name = "gbCRCParam";
            this.gbCRCParam.Size = new System.Drawing.Size(364, 83);
            this.gbCRCParam.TabIndex = 1;
            this.gbCRCParam.TabStop = false;
            this.gbCRCParam.Text = "CRC参数";
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(246, 23);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(109, 21);
            this.txtInit.TabIndex = 3;
            // 
            // txtPoly
            // 
            this.txtPoly.Location = new System.Drawing.Point(69, 23);
            this.txtPoly.Name = "txtPoly";
            this.txtPoly.Size = new System.Drawing.Size(109, 21);
            this.txtPoly.TabIndex = 3;
            // 
            // chkRefOut
            // 
            this.chkRefOut.AutoSize = true;
            this.chkRefOut.Location = new System.Drawing.Point(161, 59);
            this.chkRefOut.Name = "chkRefOut";
            this.chkRefOut.Size = new System.Drawing.Size(72, 16);
            this.chkRefOut.TabIndex = 2;
            this.chkRefOut.Text = "输出逆序";
            this.chkRefOut.UseVisualStyleBackColor = true;
            // 
            // chkRefIn
            // 
            this.chkRefIn.AutoSize = true;
            this.chkRefIn.Location = new System.Drawing.Point(21, 59);
            this.chkRefIn.Name = "chkRefIn";
            this.chkRefIn.Size = new System.Drawing.Size(72, 16);
            this.chkRefIn.TabIndex = 2;
            this.chkRefIn.Text = "输入逆序";
            this.chkRefIn.UseVisualStyleBackColor = true;
            // 
            // chkXorOut
            // 
            this.chkXorOut.AutoSize = true;
            this.chkXorOut.Location = new System.Drawing.Point(286, 59);
            this.chkXorOut.Name = "chkXorOut";
            this.chkXorOut.Size = new System.Drawing.Size(72, 16);
            this.chkXorOut.TabIndex = 2;
            this.chkXorOut.Text = "异或输出";
            this.chkXorOut.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "初始值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "多项式：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkIsLittleEndian);
            this.groupBox2.Location = new System.Drawing.Point(14, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出结果";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(280, 19);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "复制结果";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(94, 20);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(97, 21);
            this.txtResult.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "校验码(HEX)：";
            // 
            // chkIsLittleEndian
            // 
            this.chkIsLittleEndian.AutoSize = true;
            this.chkIsLittleEndian.Checked = true;
            this.chkIsLittleEndian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsLittleEndian.Location = new System.Drawing.Point(195, 23);
            this.chkIsLittleEndian.Name = "chkIsLittleEndian";
            this.chkIsLittleEndian.Size = new System.Drawing.Size(84, 16);
            this.chkIsLittleEndian.TabIndex = 8;
            this.chkIsLittleEndian.Text = "高字节在前";
            this.chkIsLittleEndian.UseVisualStyleBackColor = true;
            this.chkIsLittleEndian.CheckedChanged += new System.EventHandler(this.chkIsLittleEndian_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(284, 15);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmDataCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 253);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCRCParam);
            this.Controls.Add(this.cbDataCheckType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDataCheck";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "校验码计算";
            this.Load += new System.EventHandler(this.frmDataCheck_Load);
            this.gbCRCParam.ResumeLayout(false);
            this.gbCRCParam.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDataCheckType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbCRCParam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInit;
        private System.Windows.Forms.TextBox txtPoly;
        private System.Windows.Forms.CheckBox chkRefOut;
        private System.Windows.Forms.CheckBox chkRefIn;
        private System.Windows.Forms.CheckBox chkXorOut;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsLittleEndian;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCopy;
    }
}