namespace alarmModule
{
    partial class frmAlarmReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlarmReason));
            this.spMain = new System.Windows.Forms.SplitContainer();
            this.lvwAlarmReason = new idv.mesCore.Controls.MESListView();
            this.grpAlarmReason = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtLevelCount = new System.Windows.Forms.TextBox();
            this.lblLevelCount = new System.Windows.Forms.Label();
            this.lblAlarmType = new System.Windows.Forms.Label();
            this.cboAlarmType = new System.Windows.Forms.ComboBox();
            this.lblReasonCode = new System.Windows.Forms.Label();
            this.cboReasonCode = new System.Windows.Forms.ComboBox();
            this.actionAlarmReason = new idv.mesCore.Controls.ActionToolbar();
            this.tblSendInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.tblLine = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditLine = new System.Windows.Forms.Button();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.lstLine = new System.Windows.Forms.ListBox();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.pnlWeChat = new System.Windows.Forms.Panel();
            this.tblWeChat = new System.Windows.Forms.TableLayoutPanel();
            this.lstWeChat = new System.Windows.Forms.ListBox();
            this.btnAddWeChat = new System.Windows.Forms.Button();
            this.btnDeleteWeChat = new System.Windows.Forms.Button();
            this.txtWeChat = new System.Windows.Forms.TextBox();
            this.lblWeChat = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.tblEmail = new System.Windows.Forms.TableLayoutPanel();
            this.lstEmail = new System.Windows.Forms.ListBox();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.btnDeleteEmail = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSendEmail = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.lblCycle = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lblAlarmLevelSetting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).BeginInit();
            this.spMain.Panel1.SuspendLayout();
            this.spMain.Panel2.SuspendLayout();
            this.spMain.SuspendLayout();
            this.grpAlarmReason.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.tblSendInfo.SuspendLayout();
            this.pnlLine.SuspendLayout();
            this.tblLine.SuspendLayout();
            this.pnlWeChat.SuspendLayout();
            this.tblWeChat.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.tblEmail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spMain
            // 
            this.spMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spMain.Location = new System.Drawing.Point(0, 0);
            this.spMain.Name = "spMain";
            // 
            // spMain.Panel1
            // 
            this.spMain.Panel1.Controls.Add(this.lvwAlarmReason);
            this.spMain.Panel1.Controls.Add(this.grpAlarmReason);
            this.spMain.Panel1.Controls.Add(this.actionAlarmReason);
            // 
            // spMain.Panel2
            // 
            this.spMain.Panel2.Controls.Add(this.tblSendInfo);
            this.spMain.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.spMain.Panel2.Controls.Add(this.lblAlarmLevelSetting);
            this.spMain.Size = new System.Drawing.Size(1262, 560);
            this.spMain.SplitterDistance = 467;
            this.spMain.TabIndex = 0;
            // 
            // lvwAlarmReason
            // 
            this.lvwAlarmReason.allowUserFilter = true;
            this.lvwAlarmReason.allowUserSorting = true;
            this.lvwAlarmReason.autoSizeColumn = false;
            this.lvwAlarmReason.careModifyDate = false;
            this.lvwAlarmReason.columnHide = null;
            this.lvwAlarmReason.columnNames = new string[] {
        "alarmType",
        "name",
        "levelCount"};
            this.lvwAlarmReason.columnTags = new string[] {
        "alarmType",
        "reasonCode",
        "levelCount"};
            this.lvwAlarmReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAlarmReason.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAlarmReason.FullRowSelect = true;
            this.lvwAlarmReason.GridLines = true;
            this.lvwAlarmReason.HideSelection = false;
            this.lvwAlarmReason.imageKeyColumn = "";
            this.lvwAlarmReason.keyPressSearch = false;
            this.lvwAlarmReason.keyPressSearchColumn = "";
            this.lvwAlarmReason.Location = new System.Drawing.Point(0, 152);
            this.lvwAlarmReason.makesureNewItemVisible = true;
            this.lvwAlarmReason.MultiSelect = false;
            this.lvwAlarmReason.Name = "lvwAlarmReason";
            this.lvwAlarmReason.OwnerDraw = true;
            this.lvwAlarmReason.ShowItemTipSecond = ((byte)(3));
            this.lvwAlarmReason.Size = new System.Drawing.Size(467, 408);
            this.lvwAlarmReason.TabIndex = 8;
            this.lvwAlarmReason.UseCompatibleStateImageBehavior = false;
            this.lvwAlarmReason.View = System.Windows.Forms.View.Details;
            this.lvwAlarmReason.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwAlarmReason_MESItemSelectionChanged);
            // 
            // grpAlarmReason
            // 
            this.grpAlarmReason.AutoSize = true;
            this.grpAlarmReason.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAlarmReason.Controls.Add(this.pnlExt);
            this.grpAlarmReason.Controls.Add(this.tblDetail);
            this.grpAlarmReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAlarmReason.Location = new System.Drawing.Point(0, 25);
            this.grpAlarmReason.Name = "grpAlarmReason";
            this.grpAlarmReason.Size = new System.Drawing.Size(467, 127);
            this.grpAlarmReason.TabIndex = 10;
            this.grpAlarmReason.TabStop = false;
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 96);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(461, 28);
            this.pnlExt.TabIndex = 8;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDetail.ColumnCount = 4;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.Controls.Add(this.txtLevelCount, 3, 0);
            this.tblDetail.Controls.Add(this.lblLevelCount, 2, 0);
            this.tblDetail.Controls.Add(this.lblAlarmType, 0, 0);
            this.tblDetail.Controls.Add(this.cboAlarmType, 1, 0);
            this.tblDetail.Controls.Add(this.lblReasonCode, 0, 1);
            this.tblDetail.Controls.Add(this.cboReasonCode, 1, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Location = new System.Drawing.Point(3, 26);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(461, 70);
            this.tblDetail.TabIndex = 0;
            // 
            // txtLevelCount
            // 
            this.txtLevelCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLevelCount.BackColor = System.Drawing.SystemColors.Info;
            this.txtLevelCount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLevelCount.Location = new System.Drawing.Point(390, 3);
            this.txtLevelCount.MaxLength = 1;
            this.txtLevelCount.Name = "txtLevelCount";
            this.txtLevelCount.Size = new System.Drawing.Size(68, 30);
            this.txtLevelCount.TabIndex = 2;
            this.txtLevelCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtLevelCount.Validated += new System.EventHandler(this.txtLevelCount_Validated);
            // 
            // lblLevelCount
            // 
            this.lblLevelCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLevelCount.AutoSize = true;
            this.lblLevelCount.Location = new System.Drawing.Point(275, 8);
            this.lblLevelCount.Name = "lblLevelCount";
            this.lblLevelCount.Size = new System.Drawing.Size(109, 20);
            this.lblLevelCount.TabIndex = 11;
            this.lblLevelCount.Tag = "levelCount";
            this.lblLevelCount.Text = "LevelCount";
            // 
            // lblAlarmType
            // 
            this.lblAlarmType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlarmType.AutoSize = true;
            this.lblAlarmType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlarmType.Location = new System.Drawing.Point(3, 7);
            this.lblAlarmType.Name = "lblAlarmType";
            this.lblAlarmType.Size = new System.Drawing.Size(91, 22);
            this.lblAlarmType.TabIndex = 2;
            this.lblAlarmType.Tag = "alarmType";
            this.lblAlarmType.Text = "報警類型";
            // 
            // cboAlarmType
            // 
            this.cboAlarmType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlarmType.BackColor = System.Drawing.SystemColors.Info;
            this.cboAlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlarmType.FormattingEnabled = true;
            this.cboAlarmType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboAlarmType.Location = new System.Drawing.Point(120, 4);
            this.cboAlarmType.MaxLength = 40;
            this.cboAlarmType.Name = "cboAlarmType";
            this.cboAlarmType.Size = new System.Drawing.Size(149, 28);
            this.cboAlarmType.Sorted = true;
            this.cboAlarmType.TabIndex = 1;
            this.cboAlarmType.SelectedValueChanged += new System.EventHandler(this.cboAlarmType_SelectedValueChanged);
            // 
            // lblReasonCode
            // 
            this.lblReasonCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReasonCode.AutoSize = true;
            this.lblReasonCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonCode.Location = new System.Drawing.Point(3, 42);
            this.lblReasonCode.Name = "lblReasonCode";
            this.lblReasonCode.Size = new System.Drawing.Size(111, 22);
            this.lblReasonCode.TabIndex = 9;
            this.lblReasonCode.Tag = "reasonCode";
            this.lblReasonCode.Text = "ReasonCode";
            // 
            // cboReasonCode
            // 
            this.cboReasonCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDetail.SetColumnSpan(this.cboReasonCode, 3);
            this.cboReasonCode.FormattingEnabled = true;
            this.cboReasonCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboReasonCode.Location = new System.Drawing.Point(120, 39);
            this.cboReasonCode.MaxLength = 40;
            this.cboReasonCode.MinimumSize = new System.Drawing.Size(1, 0);
            this.cboReasonCode.Name = "cboReasonCode";
            this.cboReasonCode.Size = new System.Drawing.Size(338, 28);
            this.cboReasonCode.Sorted = true;
            this.cboReasonCode.TabIndex = 3;
            // 
            // actionAlarmReason
            // 
            this.actionAlarmReason.apPrivilegeString = "";
            this.actionAlarmReason.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionAlarmReason.functionPrivilegeString = "";
            this.actionAlarmReason.Location = new System.Drawing.Point(0, 0);
            this.actionAlarmReason.modulePrivilegeString = "";
            this.actionAlarmReason.Name = "actionAlarmReason";
            this.actionAlarmReason.Size = new System.Drawing.Size(467, 25);
            this.actionAlarmReason.TabIndex = 9;
            this.actionAlarmReason.Text = "actionToolbar1";
            this.actionAlarmReason.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionAlarmReason_ActionClicked);
            // 
            // tblSendInfo
            // 
            this.tblSendInfo.ColumnCount = 3;
            this.tblSendInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSendInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSendInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSendInfo.Controls.Add(this.pnlLine, 2, 0);
            this.tblSendInfo.Controls.Add(this.pnlWeChat, 1, 0);
            this.tblSendInfo.Controls.Add(this.pnlEmail, 0, 0);
            this.tblSendInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSendInfo.Location = new System.Drawing.Point(0, 55);
            this.tblSendInfo.Name = "tblSendInfo";
            this.tblSendInfo.RowCount = 1;
            this.tblSendInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSendInfo.Size = new System.Drawing.Size(791, 505);
            this.tblSendInfo.TabIndex = 3;
            // 
            // pnlLine
            // 
            this.pnlLine.Controls.Add(this.tblLine);
            this.pnlLine.Controls.Add(this.lblLine);
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine.Location = new System.Drawing.Point(529, 3);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(259, 499);
            this.pnlLine.TabIndex = 11;
            // 
            // tblLine
            // 
            this.tblLine.ColumnCount = 2;
            this.tblLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLine.Controls.Add(this.btnEditLine, 1, 0);
            this.tblLine.Controls.Add(this.cboLine, 0, 0);
            this.tblLine.Controls.Add(this.lstLine, 0, 2);
            this.tblLine.Controls.Add(this.btnAddLine, 0, 1);
            this.tblLine.Controls.Add(this.btnDeleteLine, 1, 1);
            this.tblLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLine.Location = new System.Drawing.Point(0, 19);
            this.tblLine.Name = "tblLine";
            this.tblLine.RowCount = 3;
            this.tblLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLine.Size = new System.Drawing.Size(259, 480);
            this.tblLine.TabIndex = 11;
            // 
            // btnEditLine
            // 
            this.btnEditLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditLine.Location = new System.Drawing.Point(186, 3);
            this.btnEditLine.Name = "btnEditLine";
            this.btnEditLine.Size = new System.Drawing.Size(70, 27);
            this.btnEditLine.TabIndex = 11;
            this.btnEditLine.Tag = "buttonEdit";
            this.btnEditLine.Text = "Edit";
            this.btnEditLine.UseVisualStyleBackColor = true;
            this.btnEditLine.Click += new System.EventHandler(this.btnEditLine_Click);
            // 
            // cboLine
            // 
            this.cboLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLine.FormattingEnabled = true;
            this.cboLine.Location = new System.Drawing.Point(3, 5);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(177, 28);
            this.cboLine.Sorted = true;
            this.cboLine.TabIndex = 10;
            this.cboLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLine_KeyPress);
            // 
            // lstLine
            // 
            this.tblLine.SetColumnSpan(this.lstLine, 2);
            this.lstLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLine.FormattingEnabled = true;
            this.lstLine.ItemHeight = 20;
            this.lstLine.Location = new System.Drawing.Point(3, 69);
            this.lstLine.Name = "lstLine";
            this.lstLine.Size = new System.Drawing.Size(253, 408);
            this.lstLine.Sorted = true;
            this.lstLine.TabIndex = 20;
            // 
            // btnAddLine
            // 
            this.btnAddLine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddLine.Location = new System.Drawing.Point(110, 36);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(70, 27);
            this.btnAddLine.TabIndex = 16;
            this.btnAddLine.Tag = "buttonAdd";
            this.btnAddLine.Text = "Add";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteLine.Location = new System.Drawing.Point(186, 36);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(70, 27);
            this.btnDeleteLine.TabIndex = 17;
            this.btnDeleteLine.Tag = "buttonDelete";
            this.btnDeleteLine.Text = "Delete";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.DarkCyan;
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLine.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLine.Location = new System.Drawing.Point(0, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(259, 19);
            this.lblLine.TabIndex = 4;
            this.lblLine.Tag = "sendLine";
            this.lblLine.Text = "Line";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWeChat
            // 
            this.pnlWeChat.Controls.Add(this.tblWeChat);
            this.pnlWeChat.Controls.Add(this.lblWeChat);
            this.pnlWeChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWeChat.Location = new System.Drawing.Point(266, 3);
            this.pnlWeChat.Name = "pnlWeChat";
            this.pnlWeChat.Size = new System.Drawing.Size(257, 499);
            this.pnlWeChat.TabIndex = 1;
            // 
            // tblWeChat
            // 
            this.tblWeChat.ColumnCount = 2;
            this.tblWeChat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblWeChat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblWeChat.Controls.Add(this.lstWeChat, 0, 2);
            this.tblWeChat.Controls.Add(this.btnAddWeChat, 0, 1);
            this.tblWeChat.Controls.Add(this.btnDeleteWeChat, 1, 1);
            this.tblWeChat.Controls.Add(this.txtWeChat, 0, 0);
            this.tblWeChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblWeChat.Location = new System.Drawing.Point(0, 19);
            this.tblWeChat.Name = "tblWeChat";
            this.tblWeChat.RowCount = 4;
            this.tblWeChat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblWeChat.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblWeChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblWeChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblWeChat.Size = new System.Drawing.Size(257, 480);
            this.tblWeChat.TabIndex = 4;
            // 
            // lstWeChat
            // 
            this.tblWeChat.SetColumnSpan(this.lstWeChat, 2);
            this.lstWeChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWeChat.FormattingEnabled = true;
            this.lstWeChat.ItemHeight = 20;
            this.lstWeChat.Location = new System.Drawing.Point(3, 72);
            this.lstWeChat.Name = "lstWeChat";
            this.lstWeChat.Size = new System.Drawing.Size(251, 385);
            this.lstWeChat.Sorted = true;
            this.lstWeChat.TabIndex = 19;
            // 
            // btnAddWeChat
            // 
            this.btnAddWeChat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddWeChat.Location = new System.Drawing.Point(108, 39);
            this.btnAddWeChat.Name = "btnAddWeChat";
            this.btnAddWeChat.Size = new System.Drawing.Size(70, 27);
            this.btnAddWeChat.TabIndex = 14;
            this.btnAddWeChat.Tag = "buttonAdd";
            this.btnAddWeChat.Text = "Add";
            this.btnAddWeChat.UseVisualStyleBackColor = true;
            this.btnAddWeChat.Click += new System.EventHandler(this.btnAddWeChat_Click);
            // 
            // btnDeleteWeChat
            // 
            this.btnDeleteWeChat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteWeChat.Location = new System.Drawing.Point(184, 39);
            this.btnDeleteWeChat.Name = "btnDeleteWeChat";
            this.btnDeleteWeChat.Size = new System.Drawing.Size(70, 27);
            this.btnDeleteWeChat.TabIndex = 15;
            this.btnDeleteWeChat.Tag = "buttonDelete";
            this.btnDeleteWeChat.Text = "Delete";
            this.btnDeleteWeChat.UseVisualStyleBackColor = true;
            this.btnDeleteWeChat.Click += new System.EventHandler(this.btnDeleteWeChat_Click);
            // 
            // txtWeChat
            // 
            this.txtWeChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblWeChat.SetColumnSpan(this.txtWeChat, 2);
            this.txtWeChat.Location = new System.Drawing.Point(3, 3);
            this.txtWeChat.MaxLength = 30;
            this.txtWeChat.Name = "txtWeChat";
            this.txtWeChat.Size = new System.Drawing.Size(251, 30);
            this.txtWeChat.TabIndex = 9;
            this.txtWeChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeChat_KeyPress);
            // 
            // lblWeChat
            // 
            this.lblWeChat.BackColor = System.Drawing.Color.Green;
            this.lblWeChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWeChat.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWeChat.Location = new System.Drawing.Point(0, 0);
            this.lblWeChat.Name = "lblWeChat";
            this.lblWeChat.Size = new System.Drawing.Size(257, 19);
            this.lblWeChat.TabIndex = 3;
            this.lblWeChat.Tag = "weChat";
            this.lblWeChat.Text = "WeChat";
            this.lblWeChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.tblEmail);
            this.pnlEmail.Controls.Add(this.lblSendEmail);
            this.pnlEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmail.Location = new System.Drawing.Point(3, 3);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(257, 499);
            this.pnlEmail.TabIndex = 0;
            // 
            // tblEmail
            // 
            this.tblEmail.ColumnCount = 2;
            this.tblEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEmail.Controls.Add(this.lstEmail, 0, 2);
            this.tblEmail.Controls.Add(this.btnAddEmail, 0, 1);
            this.tblEmail.Controls.Add(this.btnDeleteEmail, 1, 1);
            this.tblEmail.Controls.Add(this.txtEmail, 0, 0);
            this.tblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmail.Location = new System.Drawing.Point(0, 19);
            this.tblEmail.Name = "tblEmail";
            this.tblEmail.RowCount = 3;
            this.tblEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEmail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEmail.Size = new System.Drawing.Size(257, 480);
            this.tblEmail.TabIndex = 3;
            // 
            // lstEmail
            // 
            this.tblEmail.SetColumnSpan(this.lstEmail, 2);
            this.lstEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEmail.FormattingEnabled = true;
            this.lstEmail.ItemHeight = 20;
            this.lstEmail.Location = new System.Drawing.Point(3, 72);
            this.lstEmail.Name = "lstEmail";
            this.lstEmail.Size = new System.Drawing.Size(251, 405);
            this.lstEmail.Sorted = true;
            this.lstEmail.TabIndex = 18;
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddEmail.Location = new System.Drawing.Point(108, 39);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(70, 27);
            this.btnAddEmail.TabIndex = 12;
            this.btnAddEmail.Tag = "buttonAdd";
            this.btnAddEmail.Text = "Add";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // btnDeleteEmail
            // 
            this.btnDeleteEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteEmail.Location = new System.Drawing.Point(184, 39);
            this.btnDeleteEmail.Name = "btnDeleteEmail";
            this.btnDeleteEmail.Size = new System.Drawing.Size(70, 27);
            this.btnDeleteEmail.TabIndex = 13;
            this.btnDeleteEmail.Tag = "buttonDelete";
            this.btnDeleteEmail.Text = "Delete";
            this.btnDeleteEmail.UseVisualStyleBackColor = true;
            this.btnDeleteEmail.Click += new System.EventHandler(this.btnDeleteEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEmail.SetColumnSpan(this.txtEmail, 2);
            this.txtEmail.Location = new System.Drawing.Point(3, 3);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 30);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblSendEmail
            // 
            this.lblSendEmail.BackColor = System.Drawing.Color.Lavender;
            this.lblSendEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSendEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSendEmail.Location = new System.Drawing.Point(0, 0);
            this.lblSendEmail.Name = "lblSendEmail";
            this.lblSendEmail.Size = new System.Drawing.Size(257, 19);
            this.lblSendEmail.TabIndex = 2;
            this.lblSendEmail.Tag = "email";
            this.lblSendEmail.Text = "Email";
            this.lblSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboLanguage, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLanguage, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMinutes, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInterval, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInterval, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCycle, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCycle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLevel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboLevel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 36);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cboLanguage
            // 
            this.cboLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLanguage.BackColor = System.Drawing.SystemColors.Info;
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboLanguage.Location = new System.Drawing.Point(666, 6);
            this.cboLanguage.MaxLength = 40;
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(94, 28);
            this.cboLanguage.Sorted = true;
            this.cboLanguage.TabIndex = 7;
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(571, 8);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(89, 20);
            this.lblLanguage.TabIndex = 13;
            this.lblLanguage.Tag = "language";
            this.lblLanguage.Text = "language";
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(486, 8);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(79, 20);
            this.lblMinutes.TabIndex = 13;
            this.lblMinutes.Tag = "minutes";
            this.lblMinutes.Text = "minutes";
            // 
            // txtInterval
            // 
            this.txtInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInterval.BackColor = System.Drawing.SystemColors.Info;
            this.txtInterval.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtInterval.Location = new System.Drawing.Point(431, 3);
            this.txtInterval.MaxLength = 3;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(49, 30);
            this.txtInterval.TabIndex = 6;
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            // 
            // lblInterval
            // 
            this.lblInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(336, 8);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(89, 20);
            this.lblInterval.TabIndex = 12;
            this.lblInterval.Tag = "interval";
            this.lblInterval.Text = "interval";
            // 
            // txtCycle
            // 
            this.txtCycle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCycle.BackColor = System.Drawing.SystemColors.Info;
            this.txtCycle.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCycle.Location = new System.Drawing.Point(297, 3);
            this.txtCycle.MaxLength = 1;
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Size = new System.Drawing.Size(33, 30);
            this.txtCycle.TabIndex = 5;
            this.txtCycle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            // 
            // lblCycle
            // 
            this.lblCycle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCycle.AutoSize = true;
            this.lblCycle.Location = new System.Drawing.Point(182, 8);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(109, 20);
            this.lblCycle.TabIndex = 11;
            this.lblCycle.Tag = "alarmCycle";
            this.lblCycle.Text = "alarmCycle";
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(3, 8);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(109, 20);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Tag = "alarmLevel";
            this.lblLevel.Text = "alarmLevel";
            // 
            // cboLevel
            // 
            this.cboLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLevel.BackColor = System.Drawing.SystemColors.Info;
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboLevel.Location = new System.Drawing.Point(118, 6);
            this.cboLevel.MaxLength = 40;
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(58, 28);
            this.cboLevel.Sorted = true;
            this.cboLevel.TabIndex = 4;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.cboLevel_SelectedIndexChanged);
            // 
            // lblAlarmLevelSetting
            // 
            this.lblAlarmLevelSetting.BackColor = System.Drawing.Color.Blue;
            this.lblAlarmLevelSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAlarmLevelSetting.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAlarmLevelSetting.Location = new System.Drawing.Point(0, 0);
            this.lblAlarmLevelSetting.Name = "lblAlarmLevelSetting";
            this.lblAlarmLevelSetting.Size = new System.Drawing.Size(791, 19);
            this.lblAlarmLevelSetting.TabIndex = 1;
            this.lblAlarmLevelSetting.Tag = "levelSetting";
            this.lblAlarmLevelSetting.Text = "Alarm Level Setting";
            this.lblAlarmLevelSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAlarmReason
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 560);
            this.Controls.Add(this.spMain);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlarmReason";
            this.Tag = "alarmReason";
            this.Text = "frmAlarmReason";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmAlarmReason_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAlarmReason_FormClosed);
            this.Load += new System.EventHandler(this.frmAlarmReason_Load);
            this.spMain.Panel1.ResumeLayout(false);
            this.spMain.Panel1.PerformLayout();
            this.spMain.Panel2.ResumeLayout(false);
            this.spMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).EndInit();
            this.spMain.ResumeLayout(false);
            this.grpAlarmReason.ResumeLayout(false);
            this.grpAlarmReason.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.tblSendInfo.ResumeLayout(false);
            this.pnlLine.ResumeLayout(false);
            this.tblLine.ResumeLayout(false);
            this.pnlWeChat.ResumeLayout(false);
            this.tblWeChat.ResumeLayout(false);
            this.tblWeChat.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.tblEmail.ResumeLayout(false);
            this.tblEmail.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spMain;
        private idv.mesCore.Controls.MESListView lvwAlarmReason;
        private System.Windows.Forms.GroupBox grpAlarmReason;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.ComboBox cboAlarmType;
        private System.Windows.Forms.Label lblReasonCode;
        private System.Windows.Forms.Label lblAlarmType;
        private idv.mesCore.Controls.ActionToolbar actionAlarmReason;
        private System.Windows.Forms.ComboBox cboReasonCode;
        private System.Windows.Forms.Label lblLevelCount;
        private System.Windows.Forms.TextBox txtLevelCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCycle;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblAlarmLevelSetting;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TableLayoutPanel tblSendInfo;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblWeChat;
        private System.Windows.Forms.Label lblSendEmail;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlWeChat;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TableLayoutPanel tblLine;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.TableLayoutPanel tblWeChat;
        private System.Windows.Forms.Button btnAddWeChat;
        private System.Windows.Forms.Button btnDeleteWeChat;
        private System.Windows.Forms.TextBox txtWeChat;
        private System.Windows.Forms.TableLayoutPanel tblEmail;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.Button btnDeleteEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ListBox lstLine;
        private System.Windows.Forms.ListBox lstWeChat;
        private System.Windows.Forms.ListBox lstEmail;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnEditLine;
        private System.Windows.Forms.ComboBox cboLine;
    }
}