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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menumBinaryToHex = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHexToBinary = new System.Windows.Forms.ToolStripMenuItem();
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
            this.chkShowReceive = new System.Windows.Forms.CheckBox();
            this.groupReceive = new System.Windows.Forms.GroupBox();
            this.chkReceiveHex = new System.Windows.Forms.CheckBox();
            this.btnNormalToHyperTerminal = new System.Windows.Forms.Button();
            this.chkShowSend = new System.Windows.Forms.CheckBox();
            this.chkTimeStamp = new System.Windows.Forms.CheckBox();
            this.chkWrap = new System.Windows.Forms.CheckBox();
            this.numReceiveTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupSend = new System.Windows.Forms.GroupBox();
            this.radSendModeFile = new System.Windows.Forms.RadioButton();
            this.radSendModeQueue = new System.Windows.Forms.RadioButton();
            this.radSendModeNormal = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.oFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picReceiveFont = new System.Windows.Forms.PictureBox();
            this.txtReceive = new System.Windows.Forms.RichTextBox();
            this.picSetFont = new System.Windows.Forms.PictureBox();
            this.picReloadConfig = new System.Windows.Forms.PictureBox();
            this.sFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.cmenuSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSaveStringToText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveStringToBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveHexToBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.groupHyperTerminal = new System.Windows.Forms.GroupBox();
            this.cbHTEOFChars = new System.Windows.Forms.ComboBox();
            this.btnHyperTerminalToNormal = new System.Windows.Forms.Button();
            this.txtEofChars = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkSendByEnter = new System.Windows.Forms.CheckBox();
            this.chkHTCharEcho = new System.Windows.Forms.CheckBox();
            this.cbCharacterEncoding = new System.Windows.Forms.ComboBox();
            this.labClearReceive = new System.Windows.Forms.LinkLabel();
            this.Label8 = new System.Windows.Forms.Label();
            this.lnkSaveData = new System.Windows.Forms.LinkLabel();
            this.panelNormalSend = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.chkSendThenClear = new System.Windows.Forms.CheckBox();
            this.labClearSend = new System.Windows.Forms.LinkLabel();
            this.Label7 = new System.Windows.Forms.Label();
            this.lnkOpen = new System.Windows.Forms.LinkLabel();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortState)).BeginInit();
            this.cmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.groupReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReceiveTimeOut)).BeginInit();
            this.groupSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReceiveFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadConfig)).BeginInit();
            this.cmenuSave.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            "115200",
            "128000",
            "256000",
            "460800",
            "921600"});
            this.cbBaudRate.Location = new System.Drawing.Point(53, 38);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(102, 20);
            this.cbBaudRate.TabIndex = 1;
            this.cbBaudRate.Text = "115200";
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // cbComName
            // 
            this.cbComName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbComName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbComName.DropDownWidth = 300;
            this.cbComName.FormattingEnabled = true;
            this.cbComName.Location = new System.Drawing.Point(53, 15);
            this.cbComName.Name = "cbComName";
            this.cbComName.Size = new System.Drawing.Size(102, 20);
            this.cbComName.TabIndex = 0;
            this.cbComName.DropDown += new System.EventHandler(this.cbComName_DropDown);
            this.cbComName.SelectedIndexChanged += new System.EventHandler(this.cbComName_SelectedIndexChanged);
            this.cbComName.DropDownClosed += new System.EventHandler(this.cbComName_DropDownClosed);
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
            this.toolStripSeparator1,
            this.menumBinaryToHex,
            this.menuHexToBinary,
            this.ToolStripMenuItem4,
            this.menuHexToDec,
            this.menuDecToHex,
            this.toolStripMenuItem5,
            this.menuStringToDec,
            this.menuDecToString});
            this.cmenuStrip.Name = "ContextMenuStrip1";
            this.cmenuStrip.Size = new System.Drawing.Size(197, 348);
            this.cmenuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmenuStrip_Closed);
            this.cmenuStrip.Opened += new System.EventHandler(this.cmenuStrip_Opened);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // menumBinaryToHex
            // 
            this.menumBinaryToHex.Name = "menumBinaryToHex";
            this.menumBinaryToHex.Size = new System.Drawing.Size(196, 22);
            this.menumBinaryToHex.Text = "二进制转十六进制";
            this.menumBinaryToHex.Click += new System.EventHandler(this.menuBinaryToHex_Click);
            // 
            // menuHexToBinary
            // 
            this.menuHexToBinary.Name = "menuHexToBinary";
            this.menuHexToBinary.Size = new System.Drawing.Size(196, 22);
            this.menuHexToBinary.Text = "十六进制转二进制";
            this.menuHexToBinary.Click += new System.EventHandler(this.menuHexToBinary_Click);
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
            this.picTop.Location = new System.Drawing.Point(4, 540);
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
            this.labTx.Location = new System.Drawing.Point(544, 538);
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
            this.labIsSerialOpen.Location = new System.Drawing.Point(23, 538);
            this.labIsSerialOpen.Name = "labIsSerialOpen";
            this.labIsSerialOpen.Size = new System.Drawing.Size(421, 20);
            this.labIsSerialOpen.TabIndex = 36;
            this.labIsSerialOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labRx
            // 
            this.labRx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labRx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labRx.Location = new System.Drawing.Point(450, 538);
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
            this.btnEnd.Location = new System.Drawing.Point(778, 538);
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
            this.btnHelp.Location = new System.Drawing.Point(708, 538);
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
            this.btnClear.Location = new System.Drawing.Point(638, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 20);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "计数清零";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkShowReceive
            // 
            this.chkShowReceive.AutoSize = true;
            this.chkShowReceive.Checked = true;
            this.chkShowReceive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowReceive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkShowReceive.Location = new System.Drawing.Point(10, 20);
            this.chkShowReceive.Name = "chkShowReceive";
            this.chkShowReceive.Size = new System.Drawing.Size(78, 17);
            this.chkShowReceive.TabIndex = 39;
            this.chkShowReceive.Text = "显示接收";
            this.chkShowReceive.UseVisualStyleBackColor = true;
            // 
            // groupReceive
            // 
            this.groupReceive.Controls.Add(this.chkReceiveHex);
            this.groupReceive.Controls.Add(this.btnNormalToHyperTerminal);
            this.groupReceive.Controls.Add(this.chkShowSend);
            this.groupReceive.Controls.Add(this.chkTimeStamp);
            this.groupReceive.Controls.Add(this.chkWrap);
            this.groupReceive.Controls.Add(this.chkShowReceive);
            this.groupReceive.Controls.Add(this.numReceiveTimeOut);
            this.groupReceive.Controls.Add(this.label6);
            this.groupReceive.Location = new System.Drawing.Point(2, 215);
            this.groupReceive.Name = "groupReceive";
            this.groupReceive.Size = new System.Drawing.Size(161, 163);
            this.groupReceive.TabIndex = 40;
            this.groupReceive.TabStop = false;
            this.groupReceive.Text = "接收显示";
            // 
            // chkReceiveHex
            // 
            this.chkReceiveHex.AutoSize = true;
            this.chkReceiveHex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkReceiveHex.Location = new System.Drawing.Point(81, 45);
            this.chkReceiveHex.Name = "chkReceiveHex";
            this.chkReceiveHex.Size = new System.Drawing.Size(72, 17);
            this.chkReceiveHex.TabIndex = 6;
            this.chkReceiveHex.Text = "HEX显示";
            this.chkReceiveHex.UseVisualStyleBackColor = true;
            // 
            // btnNormalToHyperTerminal
            // 
            this.btnNormalToHyperTerminal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNormalToHyperTerminal.Location = new System.Drawing.Point(81, 75);
            this.btnNormalToHyperTerminal.Name = "btnNormalToHyperTerminal";
            this.btnNormalToHyperTerminal.Size = new System.Drawing.Size(69, 24);
            this.btnNormalToHyperTerminal.TabIndex = 40;
            this.btnNormalToHyperTerminal.Text = "超级终端";
            this.btnNormalToHyperTerminal.UseVisualStyleBackColor = true;
            this.btnNormalToHyperTerminal.Click += new System.EventHandler(this.btnNormalToHyperTerminal_Click);
            // 
            // chkShowSend
            // 
            this.chkShowSend.AutoSize = true;
            this.chkShowSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkShowSend.Location = new System.Drawing.Point(81, 20);
            this.chkShowSend.Name = "chkShowSend";
            this.chkShowSend.Size = new System.Drawing.Size(78, 17);
            this.chkShowSend.TabIndex = 6;
            this.chkShowSend.Text = "显示发送";
            this.chkShowSend.UseVisualStyleBackColor = true;
            // 
            // chkTimeStamp
            // 
            this.chkTimeStamp.AutoSize = true;
            this.chkTimeStamp.Checked = true;
            this.chkTimeStamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimeStamp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkTimeStamp.Location = new System.Drawing.Point(10, 77);
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
            this.chkWrap.Location = new System.Drawing.Point(10, 45);
            this.chkWrap.Name = "chkWrap";
            this.chkWrap.Size = new System.Drawing.Size(78, 17);
            this.chkWrap.TabIndex = 26;
            this.chkWrap.Text = "自动换行";
            this.chkWrap.UseVisualStyleBackColor = true;
            // 
            // numReceiveTimeOut
            // 
            this.numReceiveTimeOut.Location = new System.Drawing.Point(92, 111);
            this.numReceiveTimeOut.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numReceiveTimeOut.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numReceiveTimeOut.Name = "numReceiveTimeOut";
            this.numReceiveTimeOut.Size = new System.Drawing.Size(54, 21);
            this.numReceiveTimeOut.TabIndex = 46;
            this.ToolTip.SetToolTip(this.numReceiveTimeOut, "该值用于接收数据断帧时间\r\n若接收汉字有乱码可适当调大该值");
            this.numReceiveTimeOut.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numReceiveTimeOut.ValueChanged += new System.EventHandler(this.numReceiveTimeOut_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 47;
            this.label6.Text = "接收超时ms)：";
            // 
            // groupSend
            // 
            this.groupSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupSend.Controls.Add(this.radSendModeFile);
            this.groupSend.Controls.Add(this.radSendModeQueue);
            this.groupSend.Controls.Add(this.radSendModeNormal);
            this.groupSend.Controls.Add(this.btnSend);
            this.groupSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupSend.Location = new System.Drawing.Point(2, 387);
            this.groupSend.Name = "groupSend";
            this.groupSend.Size = new System.Drawing.Size(161, 146);
            this.groupSend.TabIndex = 41;
            this.groupSend.TabStop = false;
            this.groupSend.Text = "发送设置";
            // 
            // radSendModeFile
            // 
            this.radSendModeFile.AutoSize = true;
            this.radSendModeFile.Location = new System.Drawing.Point(10, 66);
            this.radSendModeFile.Name = "radSendModeFile";
            this.radSendModeFile.Size = new System.Drawing.Size(95, 16);
            this.radSendModeFile.TabIndex = 13;
            this.radSendModeFile.Text = "文件发送模式";
            this.radSendModeFile.UseVisualStyleBackColor = true;
            this.radSendModeFile.CheckedChanged += new System.EventHandler(this.radSendMode_CheckedChanged);
            // 
            // radSendModeQueue
            // 
            this.radSendModeQueue.AutoSize = true;
            this.radSendModeQueue.Location = new System.Drawing.Point(10, 44);
            this.radSendModeQueue.Name = "radSendModeQueue";
            this.radSendModeQueue.Size = new System.Drawing.Size(95, 16);
            this.radSendModeQueue.TabIndex = 13;
            this.radSendModeQueue.Text = "队列发送模式";
            this.radSendModeQueue.UseVisualStyleBackColor = true;
            this.radSendModeQueue.CheckedChanged += new System.EventHandler(this.radSendMode_CheckedChanged);
            // 
            // radSendModeNormal
            // 
            this.radSendModeNormal.AutoSize = true;
            this.radSendModeNormal.Checked = true;
            this.radSendModeNormal.Location = new System.Drawing.Point(10, 22);
            this.radSendModeNormal.Name = "radSendModeNormal";
            this.radSendModeNormal.Size = new System.Drawing.Size(95, 16);
            this.radSendModeNormal.TabIndex = 13;
            this.radSendModeNormal.TabStop = true;
            this.radSendModeNormal.Text = "普通发送模式";
            this.radSendModeNormal.UseVisualStyleBackColor = true;
            this.radSendModeNormal.CheckedChanged += new System.EventHandler(this.radSendMode_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(21, 88);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 40);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "开始发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
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
            this.picReceiveFont.Location = new System.Drawing.Point(652, 2);
            this.picReceiveFont.Name = "picReceiveFont";
            this.picReceiveFont.Size = new System.Drawing.Size(18, 18);
            this.picReceiveFont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReceiveFont.TabIndex = 45;
            this.picReceiveFont.TabStop = false;
            this.ToolTip.SetToolTip(this.picReceiveFont, "设置接收区字体");
            this.picReceiveFont.Visible = false;
            this.picReceiveFont.Click += new System.EventHandler(this.picReceiveFont_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtReceive.Location = new System.Drawing.Point(5, 20);
            this.txtReceive.MaxLength = 1048576;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtReceive.Size = new System.Drawing.Size(668, 327);
            this.txtReceive.TabIndex = 35;
            this.txtReceive.Text = "";
            this.ToolTip.SetToolTip(this.txtReceive, "右键菜单有进制转换功能");
            this.txtReceive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtReceive_MouseDown);
            this.txtReceive.MouseEnter += new System.EventHandler(this.txtReceive_MouseEnter);
            // 
            // picSetFont
            // 
            this.picSetFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSetFont.BackColor = System.Drawing.SystemColors.Control;
            this.picSetFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSetFont.Image = ((System.Drawing.Image)(resources.GetObject("picSetFont.Image")));
            this.picSetFont.Location = new System.Drawing.Point(631, 1);
            this.picSetFont.Name = "picSetFont";
            this.picSetFont.Size = new System.Drawing.Size(18, 18);
            this.picSetFont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSetFont.TabIndex = 45;
            this.picSetFont.TabStop = false;
            this.ToolTip.SetToolTip(this.picSetFont, "设置接收区字体");
            this.picSetFont.Click += new System.EventHandler(this.picReceiveFont_Click);
            // 
            // picReloadConfig
            // 
            this.picReloadConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReloadConfig.BackColor = System.Drawing.SystemColors.Control;
            this.picReloadConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReloadConfig.Image = ((System.Drawing.Image)(resources.GetObject("picReloadConfig.Image")));
            this.picReloadConfig.Location = new System.Drawing.Point(652, 2);
            this.picReloadConfig.Name = "picReloadConfig";
            this.picReloadConfig.Size = new System.Drawing.Size(18, 18);
            this.picReloadConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picReloadConfig.TabIndex = 45;
            this.picReloadConfig.TabStop = false;
            this.ToolTip.SetToolTip(this.picReloadConfig, "恢复默认设置");
            this.picReloadConfig.Click += new System.EventHandler(this.picReloadConfig_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.groupHyperTerminal);
            this.splitContainer1.Panel1.Controls.Add(this.cbCharacterEncoding);
            this.splitContainer1.Panel1.Controls.Add(this.picSetFont);
            this.splitContainer1.Panel1.Controls.Add(this.picReloadConfig);
            this.splitContainer1.Panel1.Controls.Add(this.picReceiveFont);
            this.splitContainer1.Panel1.Controls.Add(this.labClearReceive);
            this.splitContainer1.Panel1.Controls.Add(this.Label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtReceive);
            this.splitContainer1.Panel1.Controls.Add(this.lnkSaveData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelNormalSend);
            this.splitContainer1.Size = new System.Drawing.Size(676, 527);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "字符编码";
            // 
            // groupHyperTerminal
            // 
            this.groupHyperTerminal.Controls.Add(this.cbHTEOFChars);
            this.groupHyperTerminal.Controls.Add(this.btnHyperTerminalToNormal);
            this.groupHyperTerminal.Controls.Add(this.txtEofChars);
            this.groupHyperTerminal.Controls.Add(this.label14);
            this.groupHyperTerminal.Controls.Add(this.chkSendByEnter);
            this.groupHyperTerminal.Controls.Add(this.chkHTCharEcho);
            this.groupHyperTerminal.Location = new System.Drawing.Point(332, 45);
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
            // chkHTCharEcho
            // 
            this.chkHTCharEcho.AutoSize = true;
            this.chkHTCharEcho.Checked = true;
            this.chkHTCharEcho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHTCharEcho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkHTCharEcho.Location = new System.Drawing.Point(15, 77);
            this.chkHTCharEcho.Name = "chkHTCharEcho";
            this.chkHTCharEcho.Size = new System.Drawing.Size(78, 17);
            this.chkHTCharEcho.TabIndex = 27;
            this.chkHTCharEcho.Text = "字符回显";
            this.chkHTCharEcho.UseVisualStyleBackColor = true;
            // 
            // cbCharacterEncoding
            // 
            this.cbCharacterEncoding.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCharacterEncoding.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCharacterEncoding.FormattingEnabled = true;
            this.cbCharacterEncoding.Location = new System.Drawing.Point(317, 1);
            this.cbCharacterEncoding.Name = "cbCharacterEncoding";
            this.cbCharacterEncoding.Size = new System.Drawing.Size(219, 20);
            this.cbCharacterEncoding.TabIndex = 41;
            this.cbCharacterEncoding.SelectedIndexChanged += new System.EventHandler(this.cbCharacterEncoding_SelectedIndexChanged);
            // 
            // labClearReceive
            // 
            this.labClearReceive.AutoSize = true;
            this.labClearReceive.Location = new System.Drawing.Point(62, 4);
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
            // lnkSaveData
            // 
            this.lnkSaveData.AutoSize = true;
            this.lnkSaveData.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkSaveData.Location = new System.Drawing.Point(163, 4);
            this.lnkSaveData.Name = "lnkSaveData";
            this.lnkSaveData.Size = new System.Drawing.Size(53, 12);
            this.lnkSaveData.TabIndex = 33;
            this.lnkSaveData.TabStop = true;
            this.lnkSaveData.Text = "保存数据";
            this.lnkSaveData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSaveData_LinkClicked);
            this.lnkSaveData.Enter += new System.EventHandler(this.lnkSaveData_Enter);
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
            this.panelNormalSend.Size = new System.Drawing.Size(676, 169);
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
            this.txtSend.Size = new System.Drawing.Size(670, 149);
            this.txtSend.TabIndex = 32;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            this.txtSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSend_MouseDown);
            this.txtSend.MouseEnter += new System.EventHandler(this.txtSend_MouseEnter);
            // 
            // chkSendThenClear
            // 
            this.chkSendThenClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSendThenClear.AutoSize = true;
            this.chkSendThenClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSendThenClear.Location = new System.Drawing.Point(583, 0);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
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
            this.MinimumSize = new System.Drawing.Size(768, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortState)).EndInit();
            this.cmenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.groupReceive.ResumeLayout(false);
            this.groupReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReceiveTimeOut)).EndInit();
            this.groupSend.ResumeLayout(false);
            this.groupSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReceiveFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReloadConfig)).EndInit();
            this.cmenuSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chkShowReceive;
        internal System.Windows.Forms.GroupBox groupReceive;
        internal System.Windows.Forms.CheckBox chkWrap;
        internal System.Windows.Forms.CheckBox chkReceiveHex;
        internal System.Windows.Forms.GroupBox groupSend;
        internal System.Windows.Forms.Button btnSend;
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
        internal System.Windows.Forms.ToolStripMenuItem menuDecToHex;
        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.SaveFileDialog sFileDlg;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuStringToDec;
        private System.Windows.Forms.ToolStripMenuItem menuDecToString;
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
        internal System.Windows.Forms.RichTextBox txtReceive;
        internal System.Windows.Forms.LinkLabel lnkSaveData;
        internal System.Windows.Forms.LinkLabel labClearSend;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.LinkLabel lnkOpen;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.GroupBox groupHyperTerminal;
        internal System.Windows.Forms.CheckBox chkHTCharEcho;
        internal System.Windows.Forms.CheckBox chkSendByEnter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEofChars;
        internal System.Windows.Forms.Button btnNormalToHyperTerminal;
        internal System.Windows.Forms.Button btnHyperTerminalToNormal;
        private System.Windows.Forms.ComboBox cbHTEOFChars;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.PictureBox picReceiveFont;
        private System.Windows.Forms.TextBox txtSend;
        internal System.Windows.Forms.CheckBox chkSendThenClear;
        internal System.Windows.Forms.CheckBox chkTimeStamp;
        private System.Windows.Forms.Panel panelNormalSend;
        internal System.Windows.Forms.CheckBox chkShowSend;
        private System.Windows.Forms.RadioButton radSendModeFile;
        private System.Windows.Forms.RadioButton radSendModeQueue;
        private System.Windows.Forms.RadioButton radSendModeNormal;
        private System.Windows.Forms.NumericUpDown numReceiveTimeOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picReloadConfig;
        private System.Windows.Forms.PictureBox picSetFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menumBinaryToHex;
        private System.Windows.Forms.ToolStripMenuItem menuHexToBinary;
        internal System.Windows.Forms.ToolStripMenuItem menuHexToDec;
        private System.Windows.Forms.ComboBox cbCharacterEncoding;
        private System.Windows.Forms.Label label9;

    }
}

