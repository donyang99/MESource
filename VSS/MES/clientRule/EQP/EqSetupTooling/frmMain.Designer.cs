namespace ClientRule.EqSetupTooling
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.equipmentInformation1 = new mesRelease.Controls.EquipmentInformation();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tblTarget = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblStepId = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.pnlSetupToolingInfo = new System.Windows.Forms.Panel();
            this.lvwSetupTooling = new idv.mesCore.Controls.MESListView();
            this.tblToolingInfo = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelTooling = new System.Windows.Forms.Button();
            this.btnAddTooling = new System.Windows.Forms.Button();
            this.txtToolingPart = new System.Windows.Forms.TextBox();
            this.lblToolingId = new System.Windows.Forms.Label();
            this.txtToolingId = new System.Windows.Forms.TextBox();
            this.lblToolingType = new System.Windows.Forms.Label();
            this.lblToolingPart = new System.Windows.Forms.Label();
            this.txtToolingType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tblTarget.SuspendLayout();
            this.pnlSetupToolingInfo.SuspendLayout();
            this.tblToolingInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.equipmentInformation1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(825, 473);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 5;
            // 
            // equipmentInformation1
            // 
            this.equipmentInformation1.AutoScroll = true;
            this.equipmentInformation1.AutoScrollMinSize = new System.Drawing.Size(100, 196);
            this.equipmentInformation1.CheckInputChar = false;
            this.equipmentInformation1.displayProperties = new string[] {
        "name",
        "state",
        "type",
        "recipe",
        "owner",
        "counter",
        "fab"};
            this.equipmentInformation1.displayPropertyTags = new string[] {
        "equipmentId",
        "state",
        "equipmentType",
        "recipe",
        "owner",
        "counter",
        "fab"};
            this.equipmentInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentInformation1.editable = true;
            this.equipmentInformation1.EnableBarcodeControl = false;
            this.equipmentInformation1.Location = new System.Drawing.Point(0, 22);
            this.equipmentInformation1.Name = "equipmentInformation1";
            this.equipmentInformation1.ShowPopupMessage = false;
            this.equipmentInformation1.Size = new System.Drawing.Size(213, 451);
            this.equipmentInformation1.TabIndex = 8;
            this.equipmentInformation1.TimeoutMilliseconds = ((long)(500));
            this.equipmentInformation1.ToolTipFontSize = 11.25F;
            this.equipmentInformation1.EquipmentChanged += new mesRelease.Controls.EquipmentChangeEventHandler(this.equipmentInformation1_EquipmentChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 7;
            this.label1.Tag = "eqpInformation";
            this.label1.Text = "Equipment Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tblTarget);
            this.splitContainer2.Panel1.Controls.Add(this.lblTarget);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnlSetupToolingInfo);
            this.splitContainer2.Size = new System.Drawing.Size(608, 438);
            this.splitContainer2.SplitterDistance = 95;
            this.splitContainer2.TabIndex = 6;
            // 
            // tblTarget
            // 
            this.tblTarget.ColumnCount = 5;
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTarget.Controls.Add(this.btnClearOrder, 3, 2);
            this.tblTarget.Controls.Add(this.btnConfirmOrder, 2, 2);
            this.tblTarget.Controls.Add(this.cboOrderId, 1, 2);
            this.tblTarget.Controls.Add(this.cboStepId, 1, 1);
            this.tblTarget.Controls.Add(this.lblOrderId, 0, 2);
            this.tblTarget.Controls.Add(this.lblStepId, 0, 1);
            this.tblTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTarget.Location = new System.Drawing.Point(0, 22);
            this.tblTarget.Name = "tblTarget";
            this.tblTarget.RowCount = 4;
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTarget.Size = new System.Drawing.Size(608, 73);
            this.tblTarget.TabIndex = 7;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearOrder.Enabled = false;
            this.btnClearOrder.Location = new System.Drawing.Point(350, 39);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(59, 24);
            this.btnClearOrder.TabIndex = 1;
            this.btnClearOrder.Tag = "buttonClear";
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(285, 39);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(59, 24);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Tag = "buttonOK";
            this.btnConfirmOrder.Text = "OK";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // cboOrderId
            // 
            this.cboOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboOrderId.Location = new System.Drawing.Point(73, 39);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(206, 24);
            this.cboOrderId.Sorted = true;
            this.cboOrderId.TabIndex = 1;
            this.cboOrderId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboOrderId_KeyUp);
            // 
            // cboStepId
            // 
            this.cboStepId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStepId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(73, 9);
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(206, 24);
            this.cboStepId.Sorted = true;
            this.cboStepId.TabIndex = 0;
            this.cboStepId.SelectedIndexChanged += new System.EventHandler(this.cboStepId_SelectedIndexChanged);
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(3, 43);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(64, 16);
            this.lblOrderId.TabIndex = 10;
            this.lblOrderId.Tag = "orderId";
            this.lblOrderId.Text = "orderId";
            // 
            // lblStepId
            // 
            this.lblStepId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStepId.AutoSize = true;
            this.lblStepId.Location = new System.Drawing.Point(3, 13);
            this.lblStepId.Name = "lblStepId";
            this.lblStepId.Size = new System.Drawing.Size(56, 16);
            this.lblStepId.TabIndex = 9;
            this.lblStepId.Tag = "stepId";
            this.lblStepId.Text = "stepId";
            // 
            // lblTarget
            // 
            this.lblTarget.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarget.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTarget.Location = new System.Drawing.Point(0, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(608, 22);
            this.lblTarget.TabIndex = 6;
            this.lblTarget.Tag = "target";
            this.lblTarget.Text = "Target";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSetupToolingInfo
            // 
            this.pnlSetupToolingInfo.Controls.Add(this.lvwSetupTooling);
            this.pnlSetupToolingInfo.Controls.Add(this.tblToolingInfo);
            this.pnlSetupToolingInfo.Controls.Add(this.label8);
            this.pnlSetupToolingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSetupToolingInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlSetupToolingInfo.Name = "pnlSetupToolingInfo";
            this.pnlSetupToolingInfo.Size = new System.Drawing.Size(608, 339);
            this.pnlSetupToolingInfo.TabIndex = 13;
            // 
            // lvwSetupTooling
            // 
            this.lvwSetupTooling.allowUserFilter = false;
            this.lvwSetupTooling.allowUserSorting = false;
            this.lvwSetupTooling.autoSizeColumn = false;
            this.lvwSetupTooling.careModifyDate = false;
            this.lvwSetupTooling.CheckBoxes = true;
            this.lvwSetupTooling.columnHide = null;
            this.lvwSetupTooling.columnNames = new string[] {
        "toolingType",
        "partNo",
        "name"};
            this.lvwSetupTooling.columnTags = new string[] {
        "ToolingType",
        "ToolingPart",
        "ToolingId"};
            this.lvwSetupTooling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSetupTooling.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSetupTooling.FullRowSelect = true;
            this.lvwSetupTooling.HideSelection = false;
            this.lvwSetupTooling.imageKeyColumn = "";
            this.lvwSetupTooling.keyPressSearch = false;
            this.lvwSetupTooling.keyPressSearchColumn = "";
            this.lvwSetupTooling.Location = new System.Drawing.Point(0, 72);
            this.lvwSetupTooling.makesureNewItemVisible = true;
            this.lvwSetupTooling.MultiSelect = false;
            this.lvwSetupTooling.Name = "lvwSetupTooling";
            this.lvwSetupTooling.OwnerDraw = true;
            this.lvwSetupTooling.ShowItemTipSecond = ((byte)(3));
            this.lvwSetupTooling.Size = new System.Drawing.Size(608, 267);
            this.lvwSetupTooling.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwSetupTooling.TabIndex = 12;
            this.lvwSetupTooling.UseCompatibleStateImageBehavior = false;
            this.lvwSetupTooling.View = System.Windows.Forms.View.Details;
            this.lvwSetupTooling.MESItemCheckChanged += new idv.mesCore.Controls.MESListView.delMESItemCheckChanged(this.lvwSetupTooling_MESItemCheckChanged);
            // 
            // tblToolingInfo
            // 
            this.tblToolingInfo.ColumnCount = 5;
            this.tblToolingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblToolingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblToolingInfo.Controls.Add(this.btnDelTooling, 4, 1);
            this.tblToolingInfo.Controls.Add(this.btnAddTooling, 3, 1);
            this.tblToolingInfo.Controls.Add(this.txtToolingPart, 1, 1);
            this.tblToolingInfo.Controls.Add(this.lblToolingId, 0, 0);
            this.tblToolingInfo.Controls.Add(this.txtToolingId, 0, 1);
            this.tblToolingInfo.Controls.Add(this.lblToolingType, 2, 0);
            this.tblToolingInfo.Controls.Add(this.lblToolingPart, 1, 0);
            this.tblToolingInfo.Controls.Add(this.txtToolingType, 2, 1);
            this.tblToolingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblToolingInfo.Location = new System.Drawing.Point(0, 22);
            this.tblToolingInfo.Name = "tblToolingInfo";
            this.tblToolingInfo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tblToolingInfo.RowCount = 3;
            this.tblToolingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblToolingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblToolingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblToolingInfo.Size = new System.Drawing.Size(608, 50);
            this.tblToolingInfo.TabIndex = 13;
            // 
            // btnDelTooling
            // 
            this.btnDelTooling.Location = new System.Drawing.Point(555, 19);
            this.btnDelTooling.Name = "btnDelTooling";
            this.btnDelTooling.Size = new System.Drawing.Size(50, 30);
            this.btnDelTooling.TabIndex = 11;
            this.btnDelTooling.Tag = "toolingEventUNLOAD";
            this.btnDelTooling.Text = "delete";
            this.btnDelTooling.UseVisualStyleBackColor = true;
            this.btnDelTooling.Click += new System.EventHandler(this.btnDelTooling_Click);
            // 
            // btnAddTooling
            // 
            this.btnAddTooling.Location = new System.Drawing.Point(499, 19);
            this.btnAddTooling.Name = "btnAddTooling";
            this.btnAddTooling.Size = new System.Drawing.Size(50, 30);
            this.btnAddTooling.TabIndex = 10;
            this.btnAddTooling.Tag = "toolingEventHWSETUP";
            this.btnAddTooling.Text = "add";
            this.btnAddTooling.UseVisualStyleBackColor = true;
            this.btnAddTooling.Click += new System.EventHandler(this.btnAddTooling_Click);
            // 
            // txtToolingPart
            // 
            this.txtToolingPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolingPart.BackColor = System.Drawing.SystemColors.Control;
            this.txtToolingPart.Enabled = false;
            this.txtToolingPart.Location = new System.Drawing.Point(247, 21);
            this.txtToolingPart.Name = "txtToolingPart";
            this.txtToolingPart.Size = new System.Drawing.Size(136, 26);
            this.txtToolingPart.TabIndex = 14;
            // 
            // lblToolingId
            // 
            this.lblToolingId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToolingId.AutoSize = true;
            this.lblToolingId.Location = new System.Drawing.Point(6, 0);
            this.lblToolingId.Name = "lblToolingId";
            this.lblToolingId.Size = new System.Drawing.Size(80, 16);
            this.lblToolingId.TabIndex = 3;
            this.lblToolingId.Tag = "ToolingId";
            this.lblToolingId.Text = "ToolingId";
            // 
            // txtToolingId
            // 
            this.txtToolingId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolingId.BackColor = System.Drawing.SystemColors.Window;
            this.txtToolingId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtToolingId.Location = new System.Drawing.Point(6, 21);
            this.txtToolingId.MaxLength = 40;
            this.txtToolingId.Name = "txtToolingId";
            this.txtToolingId.Size = new System.Drawing.Size(235, 26);
            this.txtToolingId.TabIndex = 9;
            this.txtToolingId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtToolingId_KeyUp);
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.Location = new System.Drawing.Point(389, 0);
            this.lblToolingType.Name = "lblToolingType";
            this.lblToolingType.Size = new System.Drawing.Size(96, 16);
            this.lblToolingType.TabIndex = 0;
            this.lblToolingType.Tag = "ToolingType";
            this.lblToolingType.Text = "ToolingType";
            // 
            // lblToolingPart
            // 
            this.lblToolingPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToolingPart.AutoSize = true;
            this.lblToolingPart.Location = new System.Drawing.Point(247, 0);
            this.lblToolingPart.Name = "lblToolingPart";
            this.lblToolingPart.Size = new System.Drawing.Size(96, 16);
            this.lblToolingPart.TabIndex = 1;
            this.lblToolingPart.Tag = "ToolingPart";
            this.lblToolingPart.Text = "ToolingPart";
            // 
            // txtToolingType
            // 
            this.txtToolingType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolingType.BackColor = System.Drawing.SystemColors.Control;
            this.txtToolingType.Enabled = false;
            this.txtToolingType.Location = new System.Drawing.Point(389, 21);
            this.txtToolingType.Name = "txtToolingType";
            this.txtToolingType.Size = new System.Drawing.Size(104, 26);
            this.txtToolingType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(608, 22);
            this.label8.TabIndex = 6;
            this.label8.Tag = "setupToolingInfo";
            this.label8.Text = "setupToolingInfo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(531, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 473);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(825, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(825, 498);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "EqSetupTooling";
            this.Text = "EqSetupTooling";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tblTarget.ResumeLayout(false);
            this.tblTarget.PerformLayout();
            this.pnlSetupToolingInfo.ResumeLayout(false);
            this.tblToolingInfo.ResumeLayout(false);
            this.tblToolingInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private mesRelease.Controls.EquipmentInformation equipmentInformation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblTarget;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblStepId;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Panel pnlSetupToolingInfo;
        protected internal idv.mesCore.Controls.MESListView lvwSetupTooling;
        private System.Windows.Forms.TableLayoutPanel tblToolingInfo;
        private System.Windows.Forms.Button btnDelTooling;
        private System.Windows.Forms.Button btnAddTooling;
        private System.Windows.Forms.TextBox txtToolingPart;
        private System.Windows.Forms.Label lblToolingId;
        private System.Windows.Forms.TextBox txtToolingId;
        private System.Windows.Forms.Label lblToolingType;
        private System.Windows.Forms.Label lblToolingPart;
        private System.Windows.Forms.TextBox txtToolingType;
        private System.Windows.Forms.Label label8;

    }
}