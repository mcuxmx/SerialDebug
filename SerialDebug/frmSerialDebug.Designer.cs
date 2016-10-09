namespace SerialDebug
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.btnPortOpt = new System.Windows.Forms.Button();
            this.picPortState = new System.Windows.Forms.PictureBox();
            this.cbStreamControl = new System.Windows.Forms.ComboBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.imglistTop = new System.Windows.Forms.ImageList(this.components);
            this.cmenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelet = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStringToHex = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHexToString = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHexToDec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDecToHex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStringToDec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDecToString = new System.Windows.Forms.ToolStripMenuItem();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.labTx = new System.Windows.Forms.Label();
            this.labIsSerialOpen = new System.Windows.Forms.Label();
            this.labRx = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkDisplay = new System.Windows.Forms.CheckBox();
            this.groupReceive = new System.Windows.Forms.GroupBox();
            this.btnNormalToHyperTerminal = new System.Windows.Forms.Button();
            this.chkTimeStamp = new System.Windows.Forms.CheckBox();
            this.chkWrap = new System.Windows.Forms.CheckBox();
            this.chkReceiveHex = new System.Windows.Forms.CheckBox();
            this.groupSend = new System.Windows.Forms.GroupBox();
            this.numSendCount = new System.Windows.Forms.NumericUpDown();
            this.numSendInterval = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numSendOnceBytes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.chkFormat = new System.Windows.Forms.CheckBox();
            this.chkSendHex = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.oFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picReceiveFont = new System.Windows.Forms.PictureBox();
            this.btnAddSendList = new System.Windows.Forms.Button();
            this.btnDeleteSendList = new System.Windows.Forms.Button();
            this.btnSetupSendList = new System.Windows.Forms.Button();
            this.btnSetdownSendList = new System.Windows.Forms.Button();
            this.sFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.cmenuSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSaveStringToText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveStringToBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveHexToBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelSendParam = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.numSendListDelayTime = new System.Windows.Forms.NumericUpDown();
            this.cbSendMode = new System.Windows.Forms.ComboBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.txtSendParamData = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbFormat = new System.Windows.Forms.Label();
            this.panelSendList = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvSendList = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupHyperTerminal = new System.Windows.Forms.GroupBox();
            this.cbHTEOFChars = new System.Windows.Forms.ComboBox();
            this.btnHyperTerminalToNormal = new System.Windows.Forms.Button();
            this.txtEofChars = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkSendByEnter = new System.Windows.Forms.CheckBox();
            this.chkHTShowback = new System.Windows.Forms.CheckBox();
            this.labClearReceive = new System.Windows.Forms.LinkLabel();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.lnkSaveData = new System.Windows.Forms.LinkLabel();
            this.panelNormalSend = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.chkSendThenClear = new System.Windows.Forms.CheckBox();
            this.labClearSend = new System.Windows.Forms.LinkLabel();
            this.Label7 = new System.Windows.Forms.Label();
            this.lnkOpen = new System.Windows.Forms.LinkLabel();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.btnSaveSendParam = new System.Windows.Forms.Button();
            this.btnCancelSaveParam = new System.Windows.Forms.Button();
            this.linkLabelClearData = new System.Windows.Forms.LinkLabel();
            this.chkShowSend = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortState)).BeginInit();
            this.cmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.groupReceive.SuspendLayout();
            this.groupSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendOnceBytes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReceiveFont)).BeginInit();
            this.cmenuSave.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelSendParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendListDelayTime)).BeginInit();
            this.panelSendList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).BeginInit();
            this.groupHyperTerminal.SuspendLayout();
            this.panelNormalSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDTR);
            this.groupBox1.Controls.Add(this.chkRTS);
            this.groupBox1.Controls.Add(this.btnPortOpt);
            this.groupBox1.Controls.Add(this.picPortState);
            this.groupBox1.Controls.Add(this.cbStreamControl);
            this.groupBox1.Controls.Add(this.cbStopBit);
            this.groupBox1.Controls.Add(this.cbDataBit);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.cbComName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDTR.Location = new System.Drawing.Point(107, 153);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(48, 17);
            this.chkDTR.TabIndex = 41;
            this.chkDTR.Text = "DTR";
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.CheckedChanged += new System.EventHandler(this.chkDTR_CheckedChanged);
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Checked = true;
            this.chkRTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRTS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkRTS.Location = new System.Drawing.Point(53, 153);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(48, 17);
            this.chkRTS.TabIndex = 40;
            this.chkRTS.Text = "RTS";
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.Click += new System.EventHandler(this.chkRTS_Click);
            // 
            // btnPortOpt
            // 
            this.btnPortOpt.Location = new System.Drawing.Point(51, 172);
            this.btnPortOpt.Name = "btnPortOpt";
            this.btnPortOpt.Size = new System.Drawing.Size(104, 28);
            this.btnPortOpt.TabIndex = 5;
            this.btnPortOpt.Text = "打开串口";
            this.btnPortOpt.UseVisualStyleBackColor = true;
            this.btnPortOpt.Click += new System.EventHandler(this.btnPortOpt_Click);
            // 
            // picPortState
            // 
            this.picPortState.Location = new System.Drawing.Point(10, 167);
            this.picPortState.Name = "picPortState";
            this.picPortState.Size = new System.Drawing.Size(34, 34);
            this.picPortState.TabIndex = 2;
            this.picPortState.TabStop = false;
            // 
            // cbStreamControl
            // 
            this.cbStreamControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStreamControl.FormattingEnabled = true;
            this.cbStreamControl.Items.AddRange(new object[] {
            "无",
            "软件Xon/Xoff",
            "硬件",
            "硬件和软件"});
            this.cbStreamControl.Location = new System.Drawing.Point(53, 130);
            this.cbStreamControl.Name = "cbStreamControl";
            this.cbStreamControl.Size = new System.Drawing.Size(102, 20);
            this.cbStreamControl.TabIndex = 4;
            this.cbStreamControl.SelectedIndexChanged += new System.EventHandler(this.cbStreamControl_SelectedIndexChanged);
            // 
            // cbStopBit
            // 
            this.cbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Location = new System.Drawing.Point(53, 107);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(102, 20);
            this.cbStopBit.TabIndex = 4;
            this.cbStopBit.SelectedIndexChanged += new System.EventHandler(this.cbStopBit_SelectedIndexChanged);
            // 
            // cbDataBit
            // 
            this.cbDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Location = new System.Drawing.Point(53, 84);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(102, 20);
            this.cbDataBit.TabIndex = 3;
            this.cbDataBit.SelectedIndexChanged += new System.EventHandler(this.cbDataBit_SelectedIndexChanged);
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(53, 61);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(102, 20);
            this.cbParity.TabIndex = 2;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBaudRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "128000",
            "115200",
            "256000"});
            this.cbBaudRate.Location = new System.Drawing.Point(53, 38);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(102, 20);
            this.cbBaudRate.TabIndex = 1;
            this.cbBaudRate.Text = "9600";
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // cbComName
            // 
            this.cbComName.FormattingEnabled = true;
            this.cbComName.Location = new System.Drawing.Point(53, 15);
            this.cbComName.Name = "cbComName";
            this.cbComName.Size = new System.Drawing.Size(102, 20);
            this.cbComName.TabIndex = 0;
            this.cbComName.SelectedIndexChanged += new System.EventHandler(this.cbComName_SelectedIndexChanged);
            this.cbComName.DropDown += new System.EventHandler(this.cbComName_DropDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "流控制";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串  口";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "open");
            this.ImageList.Images.SetKeyName(1, "close");
            // 
            // serialPort
            // 
            this.serialPort.WriteBufferSize = 65536;
            // 
            // imglistTop
            // 
            this.imglistTop.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistTop.ImageStream")));
            this.imglistTop.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistTop.Images.SetKeyName(0, "TopOn");
            this.imglistTop.Images.SetKeyName(1, "TopOff");
            this.imglistTop.Images.SetKeyName(2, "nailon");
            this.imglistTop.Images.SetKeyName(3, "nailoff");
            // 
            // cmenuStrip
            // 
            this.cmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.ToolStripMenuItem1,
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.menuDelet,
            this.ToolStripMenuItem2,
            this.menuSelectAll,
            this.ToolStripMenuItem3,
            this.menuStringToHex,
            this.menuHexToString,
            this.ToolStripMenuItem4,
            this.menuHexToDec,
            this.menuDecToHex,
            this.toolStripMenuItem5,
            this.menuStringToDec,
            this.menuDecToString});
            this.cmenuStrip.Name = "ContextMenuStrip1";
            this.cmenuStrip.Size = new System.Drawing.Size(197, 298);
            this.cmenuStrip.Opened += new System.EventHandler(this.cmenuStrip_Opened);
            this.cmenuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmenuStrip_Closed);
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(196, 22);
            this.menuUndo.Text = "撤消(&U)";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(196, 22);
            this.menuCut.Text = "剪切(&T)";
            this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(196, 22);
            this.menuCopy.Text = "复制(&C)";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPaste.Size = new System.Drawing.Size(196, 22);
            this.menuPaste.Text = "粘贴(&P)";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // menuDelet
            // 
            this.menuDelet.Name = "menuDelet";
            this.menuDelet.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelet.Size = new System.Drawing.Size(196, 22);
            this.menuDelet.Text = "删除(&D)";
            this.menuDelet.Click += new System.EventHandler(this.menuDelet_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuSelectAll.Size = new System.Drawing.Size(196, 22);
            this.menuSelectAll.Text = "全选(&A)";
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(193, 6);
            // 
            // menuStringToHex
            // 
            this.menuStringToHex.Name = "menuStringToHex";
            this.menuStringToHex.Size = new System.Drawing.Size(196, 22);
            this.menuStringToHex.Text = "字符串转十六进制数组";
            this.menuStringToHex.Click += new System.EventHandler(this.menuStringToHex_Click);
            // 
            // menuHexToString
            // 
            this.menuHexToString.Name = "menuHexToString";
            this.menuHexToString.Size = new System.Drawing.Size(196, 22);
            this.menuHexToString.Text = "十六进制数组转字符串";
            this.menuHexToString.Click += new System.EventHandler(this.menuHexToString_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(193, 6);
            // 
            // menuHexToDec
            // 
            this.menuHexToDec.Name = "menuHexToDec";
            this.menuHexToDec.Size = new System.Drawing.Size(196, 22);
            this.menuHexToDec.Text = "十六进制转十进制";
            this.menuHexToDec.Click += new System.EventHandler(this.menuHexToDec_Click);
            // 
            // menuDecToHex
            // 
            this.menuDecToHex.Name = "menuDecToHex";
            this.menuDecToHex.Size = new System.Drawing.Size(196, 22);
            this.menuDecToHex.Text = "十进制转十六进制";
            this.menuDecToHex.Click += new System.EventHandler(this.menuDecToHex_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(193, 6);
            // 
            // menuStringToDec
            // 
            this.menuStringToDec.Name = "menuStringToDec";
            this.menuStringToDec.Size = new System.Drawing.Size(196, 22);
            this.menuStringToDec.Text = "字符串转十进制数组";
            this.menuStringToDec.Click += new System.EventHandler(this.menuStringToDec_Click);
            // 
            // menuDecToString
            // 
            this.menuDecToString.Name = "menuDecToString";
            this.menuDecToString.Size = new System.Drawing.Size(196, 22);
            this.menuDecToString.Text = "十进制数组转字符串";
            this.menuDecToString.Click += new System.EventHandler(this.menuDecToString_Click);
            // 
            // picTop
            // 
            this.picTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picTop.Location = new System.Drawing.Point(4, 461);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(18, 18);
            this.picTop.TabIndex = 38;
            this.picTop.TabStop = false;
            this.ToolTip.SetToolTip(this.picTop, "置顶");
            this.picTop.Click += new System.EventHandler(this.picTop_Click);
            // 
            // labTx
            // 
            this.labTx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labTx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTx.Location = new System.Drawing.Point(404, 459);
            this.labTx.Name = "labTx";
            this.labTx.Size = new System.Drawing.Size(88, 20);
            this.labTx.TabIndex = 35;
            this.labTx.Text = "TX:0";
            this.labTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.labTx, "双击清零");
            this.labTx.DoubleClick += new System.EventHandler(this.labTx_DoubleClick);
            // 
            // labIsSerialOpen
            // 
            this.labIsSerialOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labIsSerialOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labIsSerialOpen.Location = new System.Drawing.Point(23, 459);
            this.labIsSerialOpen.Name = "labIsSerialOpen";
            this.labIsSerialOpen.Size = new System.Drawing.Size(281, 20);
            this.labIsSerialOpen.TabIndex = 36;
            this.labIsSerialOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labRx
            // 
            this.labRx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labRx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labRx.Location = new System.Drawing.Point(310, 459);
            this.labRx.Name = "labRx";
            this.labRx.Size = new System.Drawing.Size(88, 20);
            this.labRx.TabIndex = 37;
            this.labRx.Text = "RX:0";
            this.labRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip.SetToolTip(this.labRx, "双击清零");
            this.labRx.DoubleClick += new System.EventHandler(this.labRx_DoubleClick);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnd.Location = new System.Drawing.Point(638, 459);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(64, 20);
            this.btnEnd.TabIndex = 33;
            this.btnEnd.Text = "退出程序";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Location = new System.Drawing.Point(568, 459);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(64, 20);
            this.btnHelp.TabIndex = 32;
            this.btnHelp.Text = "帮  助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(498, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 20);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "计数清零";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkDisplay
            // 
            this.chkDisplay.AutoSize = true;
            this.chkDisplay.Checked = true;
            this.chkDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkDisplay.Location = new System.Drawing.Point(10, 20);
            this.chkDisplay.Name = "chkDisplay";
            this.chkDisplay.Size = new System.Drawing.Size(78, 17);
            this.chkDisplay.TabIndex = 39;
            this.chkDisplay.Text = "是否显示";
            this.chkDisplay.UseVisualStyleBackColor = true;
            // 
            // groupReceive
            // 
            this.groupReceive.Controls.Add(this.btnNormalToHyperTerminal);
            this.groupReceive.Controls.Add(this.chkShowSend);
            this.groupReceive.Controls.Add(this.chkTimeStamp);
            this.groupReceive.Controls.Add(this.chkWrap);
            this.groupReceive.Controls.Add(this.chkReceiveHex);
            this.groupReceive.Controls.Add(this.chkDisplay);
            this.groupReceive.Location = new System.Drawing.Point(2, 215);
            this.groupReceive.Name = "groupReceive";
            this.groupReceive.Size = new System.Drawing.Size(161, 88);
            this.groupReceive.TabIndex = 40;
            this.groupReceive.TabStop = false;
            this.groupReceive.Text = "接收显示";
            // 
            // btnNormalToHyperTerminal
            // 
            this.btnNormalToHyperTerminal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNormalToHyperTerminal.Location = new System.Drawing.Point(81, 62);
            this.btnNormalToHyperTerminal.Name = "btnNormalToHyperTerminal";
            this.btnNormalToHyperTerminal.Size = new System.Drawing.Size(69, 24);
            this.btnNormalToHyperTerminal.TabIndex = 40;
            this.btnNormalToHyperTerminal.Text = "超级终端";
            this.btnNormalToHyperTerminal.UseVisualStyleBackColor = true;
            this.btnNormalToHyperTerminal.Click += new System.EventHandler(this.btnNormalToHyperTerminal_Click);
            // 
            // chkTimeStamp
            // 
            this.chkTimeStamp.AutoSize = true;
            this.chkTimeStamp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkTimeStamp.Location = new System.Drawing.Point(10, 64);
            this.chkTimeStamp.Name = "chkTimeStamp";
            this.chkTimeStamp.Size = new System.Drawing.Size(66, 17);
            this.chkTimeStamp.TabIndex = 26;
            this.chkTimeStamp.Text = "时间戳";
            this.chkTimeStamp.UseVisualStyleBackColor = true;
            // 
            // chkWrap
            // 
            this.chkWrap.AutoSize = true;
            this.chkWrap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkWrap.Location = new System.Drawing.Point(10, 42);
            this.chkWrap.Name = "chkWrap";
            this.chkWrap.Size = new System.Drawing.Size(78, 17);
            this.chkWrap.TabIndex = 26;
            this.chkWrap.Text = "自动换行";
            this.chkWrap.UseVisualStyleBackColor = true;
            // 
            // chkReceiveHex
            // 
            this.chkReceiveHex.AutoSize = true;
            this.chkReceiveHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkReceiveHex.Location = new System.Drawing.Point(83, 20);
            this.chkReceiveHex.Name = "chkReceiveHex";
            this.chkReceiveHex.Size = new System.Drawing.Size(72, 17);
            this.chkReceiveHex.TabIndex = 6;
            this.chkReceiveHex.Text = "HEX显示";
            this.chkReceiveHex.UseVisualStyleBackColor = true;
            // 
            // groupSend
            // 
            this.groupSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupSend.Controls.Add(this.numSendCount);
            this.groupSend.Controls.Add(this.numSendInterval);
            this.groupSend.Controls.Add(this.label10);
            this.groupSend.Controls.Add(this.numSendOnceBytes);
            this.groupSend.Controls.Add(this.label6);
            this.groupSend.Controls.Add(this.btnSend);
            this.groupSend.Controls.Add(this.chkAutoSend);
            this.groupSend.Controls.Add(this.chkFormat);
            this.groupSend.Controls.Add(this.chkSendHex);
            this.groupSend.Controls.Add(this.label11);
            this.groupSend.Controls.Add(this.label12);
            this.groupSend.Controls.Add(this.Label9);
            this.groupSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupSend.Location = new System.Drawing.Point(2, 308);
            this.groupSend.Name = "groupSend";
            this.groupSend.Size = new System.Drawing.Size(161, 146);
            this.groupSend.TabIndex = 41;
            this.groupSend.TabStop = false;
            this.groupSend.Text = "发送设置";
            // 
            // numSendCount
            // 
            this.numSendCount.Location = new System.Drawing.Point(75, 119);
            this.numSendCount.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSendCount.Name = "numSendCount";
            this.numSendCount.Size = new System.Drawing.Size(48, 21);
            this.numSendCount.TabIndex = 16;
            this.ToolTip.SetToolTip(this.numSendCount, "串口自动发送的次数，为0表示循环发送。");
            // 
            // numSendInterval
            // 
            this.numSendInterval.Location = new System.Drawing.Point(59, 93);
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
            this.numSendInterval.Size = new System.Drawing.Size(64, 21);
            this.numSendInterval.TabIndex = 16;
            this.ToolTip.SetToolTip(this.numSendInterval, "串口发送的时间间隔。");
            this.numSendInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "发送间隔";
            // 
            // numSendOnceBytes
            // 
            this.numSendOnceBytes.Location = new System.Drawing.Point(59, 67);
            this.numSendOnceBytes.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSendOnceBytes.Name = "numSendOnceBytes";
            this.numSendOnceBytes.Size = new System.Drawing.Size(64, 21);
            this.numSendOnceBytes.TabIndex = 14;
            this.ToolTip.SetToolTip(this.numSendOnceBytes, "串口一次发送的字节数，直到发送区域数据发送完成。\r\n为0时表示一次发送所有字节。");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "单次发送";
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(84, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 40);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "开始发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.BackColor = System.Drawing.SystemColors.Control;
            this.chkAutoSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkAutoSend.Location = new System.Drawing.Point(10, 121);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(78, 17);
            this.chkAutoSend.TabIndex = 9;
            this.chkAutoSend.Text = "自动发送";
            this.chkAutoSend.UseVisualStyleBackColor = false;
            this.chkAutoSend.CheckedChanged += new System.EventHandler(this.chkAutoSend_CheckedChanged);
            // 
            // chkFormat
            // 
            this.chkFormat.AutoSize = true;
            this.chkFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkFormat.Location = new System.Drawing.Point(10, 44);
            this.chkFormat.Name = "chkFormat";
            this.chkFormat.Size = new System.Drawing.Size(84, 17);
            this.chkFormat.TabIndex = 8;
            this.chkFormat.Text = "HEX格式化";
            this.chkFormat.UseVisualStyleBackColor = true;
            // 
            // chkSendHex
            // 
            this.chkSendHex.AutoSize = true;
            this.chkSendHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSendHex.Location = new System.Drawing.Point(10, 21);
            this.chkSendHex.Name = "chkSendHex";
            this.chkSendHex.Size = new System.Drawing.Size(72, 17);
            this.chkSendHex.TabIndex = 8;
            this.chkSendHex.Text = "HEX发送";
            this.chkSendHex.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(121, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "次";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(121, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "字节";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(121, 97);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(29, 12);
            this.Label9.TabIndex = 10;
            this.Label9.Text = "毫秒";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oFileDlg
            // 
            this.oFileDlg.CheckFileExists = false;
            this.oFileDlg.CheckPathExists = false;
            this.oFileDlg.Title = "打开数据";
            // 
            // picReceiveFont
            // 
            this.picReceiveFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReceiveFont.BackColor = System.Drawing.SystemColors.Control;
            this.picReceiveFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReceiveFont.Image = ((System.Drawing.Image)(resources.GetObject("picReceiveFont.Image")));
            this.picReceiveFont.Location = new System.Drawing.Point(512, 2);
            this.picReceiveFont.Name = "picReceiveFont";
            this.picReceiveFont.Size = new System.Drawing.Size(18, 18);
            this.picReceiveFont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReceiveFont.TabIndex = 45;
            this.picReceiveFont.TabStop = false;
            this.ToolTip.SetToolTip(this.picReceiveFont, "设置接收区字体");
            this.picReceiveFont.Click += new System.EventHandler(this.picReceiveFont_Click);
            // 
            // btnAddSendList
            // 
            this.btnAddSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSendList.Image")));
            this.btnAddSendList.Location = new System.Drawing.Point(62, 0);
            this.btnAddSendList.Name = "btnAddSendList";
            this.btnAddSendList.Size = new System.Drawing.Size(30, 24);
            this.btnAddSendList.TabIndex = 35;
            this.ToolTip.SetToolTip(this.btnAddSendList, "添加");
            this.btnAddSendList.UseVisualStyleBackColor = true;
            this.btnAddSendList.Click += new System.EventHandler(this.btnAddSendList_Click);
            // 
            // btnDeleteSendList
            // 
            this.btnDeleteSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSendList.Image")));
            this.btnDeleteSendList.Location = new System.Drawing.Point(91, 0);
            this.btnDeleteSendList.Name = "btnDeleteSendList";
            this.btnDeleteSendList.Size = new System.Drawing.Size(30, 24);
            this.btnDeleteSendList.TabIndex = 35;
            this.ToolTip.SetToolTip(this.btnDeleteSendList, "删除");
            this.btnDeleteSendList.UseVisualStyleBackColor = true;
            this.btnDeleteSendList.Click += new System.EventHandler(this.btnDeleteSendList_Click);
            // 
            // btnSetupSendList
            // 
            this.btnSetupSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnSetupSendList.Image")));
            this.btnSetupSendList.Location = new System.Drawing.Point(120, 0);
            this.btnSetupSendList.Name = "btnSetupSendList";
            this.btnSetupSendList.Size = new System.Drawing.Size(30, 24);
            this.btnSetupSendList.TabIndex = 35;
            this.ToolTip.SetToolTip(this.btnSetupSendList, "上移");
            this.btnSetupSendList.UseVisualStyleBackColor = true;
            this.btnSetupSendList.Click += new System.EventHandler(this.btnSetupSendList_Click);
            // 
            // btnSetdownSendList
            // 
            this.btnSetdownSendList.Image = ((System.Drawing.Image)(resources.GetObject("btnSetdownSendList.Image")));
            this.btnSetdownSendList.Location = new System.Drawing.Point(149, 0);
            this.btnSetdownSendList.Name = "btnSetdownSendList";
            this.btnSetdownSendList.Size = new System.Drawing.Size(30, 24);
            this.btnSetdownSendList.TabIndex = 35;
            this.ToolTip.SetToolTip(this.btnSetdownSendList, "下移");
            this.btnSetdownSendList.UseVisualStyleBackColor = true;
            this.btnSetdownSendList.Click += new System.EventHandler(this.btnSetdownSendList_Click);
            // 
            // sFileDlg
            // 
            this.sFileDlg.Title = "保存接收区数据";
            // 
            // cmenuSave
            // 
            this.cmenuSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSaveStringToText,
            this.toolStripMenuItem6,
            this.menuSaveStringToBinary,
            this.toolStripMenuItem7,
            this.menuSaveHexToBinary});
            this.cmenuSave.Name = "cmenuSave";
            this.cmenuSave.Size = new System.Drawing.Size(209, 82);
            // 
            // menuSaveStringToText
            // 
            this.menuSaveStringToText.Name = "menuSaveStringToText";
            this.menuSaveStringToText.Size = new System.Drawing.Size(208, 22);
            this.menuSaveStringToText.Text = "保存为文本文件";
            this.menuSaveStringToText.ToolTipText = "保持接收区域格式不变";
            this.menuSaveStringToText.Click += new System.EventHandler(this.menuSaveStringToText_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(205, 6);
            // 
            // menuSaveStringToBinary
            // 
            this.menuSaveStringToBinary.Name = "menuSaveStringToBinary";
            this.menuSaveStringToBinary.Size = new System.Drawing.Size(208, 22);
            this.menuSaveStringToBinary.Text = "从字符串到二进制文件";
            this.menuSaveStringToBinary.ToolTipText = "将接收区域内容转换为字节\r\n并保存为二进制文件";
            this.menuSaveStringToBinary.Click += new System.EventHandler(this.menuSaveStringToBinary_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(205, 6);
            // 
            // menuSaveHexToBinary
            // 
            this.menuSaveHexToBinary.Name = "menuSaveHexToBinary";
            this.menuSaveHexToBinary.Size = new System.Drawing.Size(208, 22);
            this.menuSaveHexToBinary.Text = "从十六进制到二进制文件";
            this.menuSaveHexToBinary.ToolTipText = "接收区为十六进制显示";
            this.menuSaveHexToBinary.Click += new System.EventHandler(this.menuSaveHexToBinary_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(166, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelSendParam);
            this.splitContainer1.Panel1.Controls.Add(this.panelSendList);
            this.splitContainer1.Panel1.Controls.Add(this.groupHyperTerminal);
            this.splitContainer1.Panel1.Controls.Add(this.picReceiveFont);
            this.splitContainer1.Panel1.Controls.Add(this.labClearReceive);
            this.splitContainer1.Panel1.Controls.Add(this.Label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtReceive);
            this.splitContainer1.Panel1.Controls.Add(this.lnkSaveData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelNormalSend);
            this.splitContainer1.Size = new System.Drawing.Size(536, 448);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 42;
            // 
            // panelSendParam
            // 
            this.panelSendParam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSendParam.Controls.Add(this.linkLabelClearData);
            this.panelSendParam.Controls.Add(this.btnCancelSaveParam);
            this.panelSendParam.Controls.Add(this.btnSaveSendParam);
            this.panelSendParam.Controls.Add(this.label18);
            this.panelSendParam.Controls.Add(this.numSendListDelayTime);
            this.panelSendParam.Controls.Add(this.cbSendMode);
            this.panelSendParam.Controls.Add(this.cbFormat);
            this.panelSendParam.Controls.Add(this.txtSendParamData);
            this.panelSendParam.Controls.Add(this.label17);
            this.panelSendParam.Controls.Add(this.label16);
            this.panelSendParam.Controls.Add(this.lbFormat);
            this.panelSendParam.Location = new System.Drawing.Point(7, 61);
            this.panelSendParam.Name = "panelSendParam";
            this.panelSendParam.Size = new System.Drawing.Size(506, 95);
            this.panelSendParam.TabIndex = 47;
            this.panelSendParam.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "数据内容：";
            // 
            // numSendListDelayTime
            // 
            this.numSendListDelayTime.Location = new System.Drawing.Point(423, 5);
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
            this.cbSendMode.Location = new System.Drawing.Point(220, 5);
            this.cbSendMode.Name = "cbSendMode";
            this.cbSendMode.Size = new System.Drawing.Size(139, 20);
            this.cbSendMode.TabIndex = 1;
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "ASCII",
            "HEX"});
            this.cbFormat.Location = new System.Drawing.Point(59, 5);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(84, 20);
            this.cbFormat.TabIndex = 1;
            // 
            // txtSendParamData
            // 
            this.txtSendParamData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendParamData.Location = new System.Drawing.Point(3, 49);
            this.txtSendParamData.Multiline = true;
            this.txtSendParamData.Name = "txtSendParamData";
            this.txtSendParamData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendParamData.Size = new System.Drawing.Size(439, 43);
            this.txtSendParamData.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(365, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "延时(ms)：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "发送模式：";
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.Location = new System.Drawing.Point(3, 9);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(65, 12);
            this.lbFormat.TabIndex = 3;
            this.lbFormat.Text = "数据格式：";
            // 
            // panelSendList
            // 
            this.panelSendList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSendList.Controls.Add(this.btnSetdownSendList);
            this.panelSendList.Controls.Add(this.btnSetupSendList);
            this.panelSendList.Controls.Add(this.btnDeleteSendList);
            this.panelSendList.Controls.Add(this.btnAddSendList);
            this.panelSendList.Controls.Add(this.label15);
            this.panelSendList.Controls.Add(this.dgvSendList);
            this.panelSendList.Location = new System.Drawing.Point(20, 160);
            this.panelSendList.Name = "panelSendList";
            this.panelSendList.Size = new System.Drawing.Size(506, 131);
            this.panelSendList.TabIndex = 46;
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
            this.dgvSendList.Size = new System.Drawing.Size(500, 102);
            this.dgvSendList.TabIndex = 0;
            // 
            // colNo
            // 
            this.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNo.FillWeight = 48.73096F;
            this.colNo.HeaderText = "序号";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNo.Width = 36;
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
            this.colData.FillWeight = 114.2795F;
            this.colData.HeaderText = "数据";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupHyperTerminal
            // 
            this.groupHyperTerminal.Controls.Add(this.cbHTEOFChars);
            this.groupHyperTerminal.Controls.Add(this.btnHyperTerminalToNormal);
            this.groupHyperTerminal.Controls.Add(this.txtEofChars);
            this.groupHyperTerminal.Controls.Add(this.label14);
            this.groupHyperTerminal.Controls.Add(this.chkSendByEnter);
            this.groupHyperTerminal.Controls.Add(this.chkHTShowback);
            this.groupHyperTerminal.Location = new System.Drawing.Point(332, 15);
            this.groupHyperTerminal.Name = "groupHyperTerminal";
            this.groupHyperTerminal.Size = new System.Drawing.Size(161, 223);
            this.groupHyperTerminal.TabIndex = 43;
            this.groupHyperTerminal.TabStop = false;
            this.groupHyperTerminal.Text = "超级终端模式";
            // 
            // cbHTEOFChars
            // 
            this.cbHTEOFChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHTEOFChars.FormattingEnabled = true;
            this.cbHTEOFChars.Items.AddRange(new object[] {
            "NONE",
            "NULL（\\0）",
            "LF（\\n）",
            "CR+LF（\\r\\n）",
            "LF+CR（\\n\\r）",
            "CR（\\r）"});
            this.cbHTEOFChars.Location = new System.Drawing.Point(15, 144);
            this.cbHTEOFChars.Name = "cbHTEOFChars";
            this.cbHTEOFChars.Size = new System.Drawing.Size(140, 20);
            this.cbHTEOFChars.TabIndex = 41;
            this.cbHTEOFChars.SelectedIndexChanged += new System.EventHandler(this.cbHTEOFChars_SelectedIndexChanged);
            // 
            // btnHyperTerminalToNormal
            // 
            this.btnHyperTerminalToNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHyperTerminalToNormal.Location = new System.Drawing.Point(13, 21);
            this.btnHyperTerminalToNormal.Name = "btnHyperTerminalToNormal";
            this.btnHyperTerminalToNormal.Size = new System.Drawing.Size(140, 37);
            this.btnHyperTerminalToNormal.TabIndex = 40;
            this.btnHyperTerminalToNormal.Text = "返回普通模式";
            this.btnHyperTerminalToNormal.UseVisualStyleBackColor = true;
            this.btnHyperTerminalToNormal.Click += new System.EventHandler(this.btnHyperTerminalToNormal_Click);
            // 
            // txtEofChars
            // 
            this.txtEofChars.Location = new System.Drawing.Point(15, 170);
            this.txtEofChars.Name = "txtEofChars";
            this.txtEofChars.Size = new System.Drawing.Size(140, 21);
            this.txtEofChars.TabIndex = 29;
            this.txtEofChars.Text = "\\r\\n";
            this.txtEofChars.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "包含下面结束符";
            // 
            // chkSendByEnter
            // 
            this.chkSendByEnter.AutoSize = true;
            this.chkSendByEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSendByEnter.Location = new System.Drawing.Point(15, 100);
            this.chkSendByEnter.Name = "chkSendByEnter";
            this.chkSendByEnter.Size = new System.Drawing.Size(102, 17);
            this.chkSendByEnter.TabIndex = 27;
            this.chkSendByEnter.Text = "输入回车发送";
            this.chkSendByEnter.UseVisualStyleBackColor = true;
            // 
            // chkHTShowback
            // 
            this.chkHTShowback.AutoSize = true;
            this.chkHTShowback.Checked = true;
            this.chkHTShowback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHTShowback.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkHTShowback.Location = new System.Drawing.Point(15, 77);
            this.chkHTShowback.Name = "chkHTShowback";
            this.chkHTShowback.Size = new System.Drawing.Size(78, 17);
            this.chkHTShowback.TabIndex = 27;
            this.chkHTShowback.Text = "字符回显";
            this.chkHTShowback.UseVisualStyleBackColor = true;
            // 
            // labClearReceive
            // 
            this.labClearReceive.AutoSize = true;
            this.labClearReceive.Location = new System.Drawing.Point(62, 6);
            this.labClearReceive.Name = "labClearReceive";
            this.labClearReceive.Size = new System.Drawing.Size(77, 12);
            this.labClearReceive.TabIndex = 34;
            this.labClearReceive.TabStop = true;
            this.labClearReceive.Text = " 清空接收区 ";
            this.labClearReceive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labClearReceive_LinkClicked);
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Location = new System.Drawing.Point(3, 4);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 12);
            this.Label8.TabIndex = 32;
            this.Label8.Text = "接收区：";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReceive
            // 
            this.txtReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtReceive.Location = new System.Drawing.Point(5, 20);
            this.txtReceive.MaxLength = 0;
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(528, 275);
            this.txtReceive.TabIndex = 35;
            this.txtReceive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtReceive_MouseDown);
            this.txtReceive.MouseEnter += new System.EventHandler(this.txtReceive_MouseEnter);
            // 
            // lnkSaveData
            // 
            this.lnkSaveData.AutoSize = true;
            this.lnkSaveData.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkSaveData.Location = new System.Drawing.Point(163, 6);
            this.lnkSaveData.Name = "lnkSaveData";
            this.lnkSaveData.Size = new System.Drawing.Size(53, 12);
            this.lnkSaveData.TabIndex = 33;
            this.lnkSaveData.TabStop = true;
            this.lnkSaveData.Text = "保存数据";
            this.lnkSaveData.Enter += new System.EventHandler(this.lnkSaveData_Enter);
            this.lnkSaveData.MouseEnter += new System.EventHandler(this.lnkSaveData_Enter);
            // 
            // panelNormalSend
            // 
            this.panelNormalSend.Controls.Add(this.txtSend);
            this.panelNormalSend.Controls.Add(this.chkSendThenClear);
            this.panelNormalSend.Controls.Add(this.labClearSend);
            this.panelNormalSend.Controls.Add(this.Label7);
            this.panelNormalSend.Controls.Add(this.lnkOpen);
            this.panelNormalSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNormalSend.Location = new System.Drawing.Point(0, 0);
            this.panelNormalSend.Name = "panelNormalSend";
            this.panelNormalSend.Size = new System.Drawing.Size(536, 142);
            this.panelNormalSend.TabIndex = 36;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(3, 17);
            this.txtSend.MaxLength = 0;
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSend.Size = new System.Drawing.Size(530, 122);
            this.txtSend.TabIndex = 32;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            this.txtSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSend_MouseDown);
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            this.txtSend.MouseEnter += new System.EventHandler(this.txtSend_MouseEnter);
            // 
            // chkSendThenClear
            // 
            this.chkSendThenClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSendThenClear.AutoSize = true;
            this.chkSendThenClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSendThenClear.Location = new System.Drawing.Point(443, 0);
            this.chkSendThenClear.Name = "chkSendThenClear";
            this.chkSendThenClear.Size = new System.Drawing.Size(90, 17);
            this.chkSendThenClear.TabIndex = 8;
            this.chkSendThenClear.Text = "发送后清除";
            this.chkSendThenClear.UseVisualStyleBackColor = true;
            // 
            // labClearSend
            // 
            this.labClearSend.AutoSize = true;
            this.labClearSend.Location = new System.Drawing.Point(62, 2);
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
            this.Label7.Location = new System.Drawing.Point(3, 2);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(53, 12);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "发送区：";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkOpen
            // 
            this.lnkOpen.AutoSize = true;
            this.lnkOpen.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkOpen.Location = new System.Drawing.Point(161, 2);
            this.lnkOpen.Name = "lnkOpen";
            this.lnkOpen.Size = new System.Drawing.Size(53, 12);
            this.lnkOpen.TabIndex = 34;
            this.lnkOpen.TabStop = true;
            this.lnkOpen.Text = "打开文件";
            this.lnkOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpen_LinkClicked);
            // 
            // btnSaveSendParam
            // 
            this.btnSaveSendParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSendParam.Location = new System.Drawing.Point(448, 46);
            this.btnSaveSendParam.Name = "btnSaveSendParam";
            this.btnSaveSendParam.Size = new System.Drawing.Size(55, 23);
            this.btnSaveSendParam.TabIndex = 5;
            this.btnSaveSendParam.Text = "确定";
            this.btnSaveSendParam.UseVisualStyleBackColor = true;
            this.btnSaveSendParam.Click += new System.EventHandler(this.btnSaveSendParam_Click);
            // 
            // btnCancelSaveParam
            // 
            this.btnCancelSaveParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelSaveParam.Location = new System.Drawing.Point(448, 69);
            this.btnCancelSaveParam.Name = "btnCancelSaveParam";
            this.btnCancelSaveParam.Size = new System.Drawing.Size(55, 23);
            this.btnCancelSaveParam.TabIndex = 5;
            this.btnCancelSaveParam.Text = "取消";
            this.btnCancelSaveParam.UseVisualStyleBackColor = true;
            this.btnCancelSaveParam.Click += new System.EventHandler(this.btnCancelSaveParam_Click);
            // 
            // linkLabelClearData
            // 
            this.linkLabelClearData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelClearData.AutoSize = true;
            this.linkLabelClearData.Location = new System.Drawing.Point(389, 36);
            this.linkLabelClearData.Name = "linkLabelClearData";
            this.linkLabelClearData.Size = new System.Drawing.Size(53, 12);
            this.linkLabelClearData.TabIndex = 6;
            this.linkLabelClearData.TabStop = true;
            this.linkLabelClearData.Text = "清空数据";
            this.linkLabelClearData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearData_LinkClicked);
            // 
            // chkShowSend
            // 
            this.chkShowSend.AutoSize = true;
            this.chkShowSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkShowSend.Location = new System.Drawing.Point(83, 42);
            this.chkShowSend.Name = "chkShowSend";
            this.chkShowSend.Size = new System.Drawing.Size(78, 17);
            this.chkShowSend.TabIndex = 6;
            this.chkShowSend.Text = "显示发送";
            this.chkShowSend.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 482);
            this.Controls.Add(this.groupSend);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.labIsSerialOpen);
            this.Controls.Add(this.labTx);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupReceive);
            this.Controls.Add(this.labRx);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 520);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortState)).EndInit();
            this.cmenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.groupReceive.ResumeLayout(false);
            this.groupReceive.PerformLayout();
            this.groupSend.ResumeLayout(false);
            this.groupSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSendOnceBytes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReceiveFont)).EndInit();
            this.cmenuSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panelSendParam.ResumeLayout(false);
            this.panelSendParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendListDelayTime)).EndInit();
            this.panelSendList.ResumeLayout(false);
            this.panelSendList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).EndInit();
            this.groupHyperTerminal.ResumeLayout(false);
            this.groupHyperTerminal.PerformLayout();
            this.panelNormalSend.ResumeLayout(false);
            this.panelNormalSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbDataBit;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbComName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPortOpt;
        private System.Windows.Forms.PictureBox picPortState;
        internal System.Windows.Forms.ImageList ImageList;
        private System.IO.Ports.SerialPort serialPort;
        internal System.Windows.Forms.ImageList imglistTop;
        internal System.Windows.Forms.PictureBox picTop;
        internal System.Windows.Forms.Label labTx;
        internal System.Windows.Forms.Label labIsSerialOpen;
        internal System.Windows.Forms.Label labRx;
        internal System.Windows.Forms.Button btnEnd;
        internal System.Windows.Forms.Button btnHelp;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkDisplay;
        internal System.Windows.Forms.GroupBox groupReceive;
        internal System.Windows.Forms.CheckBox chkWrap;
        internal System.Windows.Forms.CheckBox chkReceiveHex;
        internal System.Windows.Forms.GroupBox groupSend;
        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.CheckBox chkAutoSend;
        internal System.Windows.Forms.CheckBox chkSendHex;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.OpenFileDialog oFileDlg;
        internal System.Windows.Forms.ContextMenuStrip cmenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem menuUndo;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem menuCut;
        internal System.Windows.Forms.ToolStripMenuItem menuCopy;
        internal System.Windows.Forms.ToolStripMenuItem menuPaste;
        internal System.Windows.Forms.ToolStripMenuItem menuDelet;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem menuStringToHex;
        internal System.Windows.Forms.ToolStripMenuItem menuHexToString;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem menuHexToDec;
        internal System.Windows.Forms.ToolStripMenuItem menuDecToHex;
        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.SaveFileDialog sFileDlg;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuStringToDec;
        private System.Windows.Forms.ToolStripMenuItem menuDecToString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSendOnceBytes;
        private System.Windows.Forms.NumericUpDown numSendInterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSendCount;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip cmenuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveStringToText;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem menuSaveStringToBinary;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem menuSaveHexToBinary;
        private System.Windows.Forms.ComboBox cbStreamControl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.LinkLabel labClearReceive;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtReceive;
        internal System.Windows.Forms.LinkLabel lnkSaveData;
        internal System.Windows.Forms.LinkLabel labClearSend;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.LinkLabel lnkOpen;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.GroupBox groupHyperTerminal;
        internal System.Windows.Forms.CheckBox chkHTShowback;
        internal System.Windows.Forms.CheckBox chkSendByEnter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEofChars;
        internal System.Windows.Forms.Button btnNormalToHyperTerminal;
        internal System.Windows.Forms.Button btnHyperTerminalToNormal;
        private System.Windows.Forms.ComboBox cbHTEOFChars;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.PictureBox picReceiveFont;
        internal System.Windows.Forms.CheckBox chkFormat;
        private System.Windows.Forms.TextBox txtSend;
        internal System.Windows.Forms.CheckBox chkSendThenClear;
        internal System.Windows.Forms.CheckBox chkTimeStamp;
        private System.Windows.Forms.Panel panelSendList;
        private System.Windows.Forms.DataGridView dgvSendList;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelSendParam;
        private System.Windows.Forms.ComboBox cbSendMode;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.TextBox txtSendParamData;
        private System.Windows.Forms.NumericUpDown numSendListDelayTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAddSendList;
        private System.Windows.Forms.Button btnSetdownSendList;
        private System.Windows.Forms.Button btnSetupSendList;
        private System.Windows.Forms.Button btnDeleteSendList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.Panel panelNormalSend;
        private System.Windows.Forms.Button btnCancelSaveParam;
        private System.Windows.Forms.Button btnSaveSendParam;
        private System.Windows.Forms.LinkLabel linkLabelClearData;
        internal System.Windows.Forms.CheckBox chkShowSend;

    }
}

