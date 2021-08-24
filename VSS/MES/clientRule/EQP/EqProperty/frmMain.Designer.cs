namespace ClientRule.EqProperty
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnExportHistory = new System.Windows.Forms.Button();
            this.btnHistoryDetail = new System.Windows.Forms.Button();
            this.lvwHistory = new System.Windows.Forms.ListView();
            this.activity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prevstate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recipe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lotId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.counter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modify_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modify_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQueryHistory = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.tblSetupInfo = new System.Windows.Forms.TabPage();
            this.pnlCurToolingInfo = new System.Windows.Forms.Panel();
            this.lvwCurTooling = new idv.mesCore.Controls.MESListView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCurMaterial = new System.Windows.Forms.Panel();
            this.lvwCurSetupMaterial = new idv.mesCore.Controls.MESListView();
            this.label6 = new System.Windows.Forms.Label();
            this.tblEqParameter = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtEqParmDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtEqParmDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnQueryEqParm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshEqParm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpCurParameter = new System.Windows.Forms.GroupBox();
            this.tblCurParameter = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lvwEqParmHistory = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblSetupInfo.SuspendLayout();
            this.pnlCurToolingInfo.SuspendLayout();
            this.pnlCurMaterial.SuspendLayout();
            this.tblEqParameter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpCurParameter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(910, 618);
            this.splitContainer1.SplitterDistance = 217;
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
            this.equipmentInformation1.Size = new System.Drawing.Size(217, 596);
            this.equipmentInformation1.TabIndex = 6;
            this.equipmentInformation1.TimeoutMilliseconds = ((long)(500));
            this.equipmentInformation1.ToolTipFontSize = 11.25F;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 5;
            this.label1.Tag = "eqpInformation";
            this.label1.Text = "Equipment Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Controls.Add(this.tblSetupInfo);
            this.tabControl1.Controls.Add(this.tblEqParameter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(54, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 583);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.btnExportHistory);
            this.tabHistory.Controls.Add(this.btnHistoryDetail);
            this.tabHistory.Controls.Add(this.lvwHistory);
            this.tabHistory.Controls.Add(this.label5);
            this.tabHistory.Controls.Add(this.label2);
            this.tabHistory.Controls.Add(this.groupBox1);
            this.tabHistory.Location = new System.Drawing.Point(4, 26);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(681, 553);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Tag = "history";
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // btnExportHistory
            // 
            this.btnExportHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportHistory.Location = new System.Drawing.Point(596, 520);
            this.btnExportHistory.Name = "btnExportHistory";
            this.btnExportHistory.Size = new System.Drawing.Size(79, 31);
            this.btnExportHistory.TabIndex = 9;
            this.btnExportHistory.Tag = "buttonExport";
            this.btnExportHistory.Text = "Export";
            this.btnExportHistory.UseVisualStyleBackColor = true;
            this.btnExportHistory.Click += new System.EventHandler(this.btnExportHistory_Click);
            // 
            // btnHistoryDetail
            // 
            this.btnHistoryDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistoryDetail.Location = new System.Drawing.Point(515, 520);
            this.btnHistoryDetail.Name = "btnHistoryDetail";
            this.btnHistoryDetail.Size = new System.Drawing.Size(79, 31);
            this.btnHistoryDetail.TabIndex = 8;
            this.btnHistoryDetail.Tag = "detail";
            this.btnHistoryDetail.Text = "Detail";
            this.btnHistoryDetail.UseVisualStyleBackColor = true;
            this.btnHistoryDetail.Click += new System.EventHandler(this.btnHistoryDetail_Click);
            // 
            // lvwHistory
            // 
            this.lvwHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.activity,
            this.state,
            this.prevstate,
            this.recipe,
            this.lotId,
            this.counter,
            this.modify_user,
            this.modify_date});
            this.lvwHistory.FullRowSelect = true;
            this.lvwHistory.HideSelection = false;
            this.lvwHistory.Location = new System.Drawing.Point(12, 153);
            this.lvwHistory.Name = "lvwHistory";
            this.lvwHistory.Size = new System.Drawing.Size(663, 363);
            this.lvwHistory.TabIndex = 7;
            this.lvwHistory.UseCompatibleStateImageBehavior = false;
            this.lvwHistory.View = System.Windows.Forms.View.Details;
            this.lvwHistory.DoubleClick += new System.EventHandler(this.lvwHistory_DoubleClick);
            // 
            // activity
            // 
            this.activity.Name = "activity";
            this.activity.Tag = "activity";
            this.activity.Text = "Activity";
            this.activity.Width = 101;
            // 
            // state
            // 
            this.state.Tag = "state";
            this.state.Text = "state";
            this.state.Width = 66;
            // 
            // prevstate
            // 
            this.prevstate.Tag = "previousState";
            this.prevstate.Text = "previousState";
            this.prevstate.Width = 67;
            // 
            // recipe
            // 
            this.recipe.Tag = "recipe";
            this.recipe.Text = "recipe";
            this.recipe.Width = 88;
            // 
            // lotId
            // 
            this.lotId.Tag = "lotId";
            this.lotId.Text = "lotId";
            this.lotId.Width = 82;
            // 
            // counter
            // 
            this.counter.Tag = "counter";
            this.counter.Text = "counter";
            this.counter.Width = 50;
            // 
            // modify_user
            // 
            this.modify_user.Name = "modify_user";
            this.modify_user.Tag = "modifyUser";
            this.modify_user.Text = "ModifyUser";
            this.modify_user.Width = 69;
            // 
            // modify_date
            // 
            this.modify_date.Name = "modify_date";
            this.modify_date.Tag = "modifyDate";
            this.modify_date.Text = "ModifyDate";
            this.modify_date.Width = 162;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(11, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 22);
            this.label5.TabIndex = 6;
            this.label5.Tag = "eqHistory";
            this.label5.Text = "Equipment History";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 4;
            this.label2.Tag = "queryCondition";
            this.label2.Text = "Query Condition";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnQueryHistory, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label34, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtTo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboActivity, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 74);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnQueryHistory
            // 
            this.btnQueryHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryHistory.Location = new System.Drawing.Point(582, 35);
            this.btnQueryHistory.Name = "btnQueryHistory";
            this.btnQueryHistory.Size = new System.Drawing.Size(68, 33);
            this.btnQueryHistory.TabIndex = 2;
            this.btnQueryHistory.Tag = "buttonQuery";
            this.btnQueryHistory.Text = "Query";
            this.btnQueryHistory.UseVisualStyleBackColor = true;
            this.btnQueryHistory.Click += new System.EventHandler(this.btnQueryHistory_Click);
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 43);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(72, 16);
            this.label34.TabIndex = 4;
            this.label34.Tag = "activity";
            this.label34.Text = "activity";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTo.CustomFormat = "  yyyy / MM / dd HH:mm:ss";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(343, 3);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(236, 26);
            this.dtTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Tag = "date";
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtFrom.CustomFormat = "  yyyy / MM / dd HH:mm:ss";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(81, 3);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(236, 26);
            this.dtFrom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(323, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboActivity
            // 
            this.cboActivity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(81, 39);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(236, 24);
            this.cboActivity.Sorted = true;
            this.cboActivity.TabIndex = 5;
            // 
            // tblSetupInfo
            // 
            this.tblSetupInfo.Controls.Add(this.pnlCurToolingInfo);
            this.tblSetupInfo.Controls.Add(this.pnlCurMaterial);
            this.tblSetupInfo.Location = new System.Drawing.Point(4, 26);
            this.tblSetupInfo.Name = "tblSetupInfo";
            this.tblSetupInfo.Size = new System.Drawing.Size(681, 553);
            this.tblSetupInfo.TabIndex = 1;
            this.tblSetupInfo.Tag = "currentSetupInfo";
            this.tblSetupInfo.Text = "SetupInfo";
            this.tblSetupInfo.UseVisualStyleBackColor = true;
            // 
            // pnlCurToolingInfo
            // 
            this.pnlCurToolingInfo.Controls.Add(this.lvwCurTooling);
            this.pnlCurToolingInfo.Controls.Add(this.label7);
            this.pnlCurToolingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurToolingInfo.Location = new System.Drawing.Point(0, 270);
            this.pnlCurToolingInfo.Name = "pnlCurToolingInfo";
            this.pnlCurToolingInfo.Size = new System.Drawing.Size(681, 283);
            this.pnlCurToolingInfo.TabIndex = 12;
            // 
            // lvwCurTooling
            // 
            this.lvwCurTooling.allowUserFilter = false;
            this.lvwCurTooling.allowUserSorting = false;
            this.lvwCurTooling.autoSizeColumn = false;
            this.lvwCurTooling.careModifyDate = false;
            this.lvwCurTooling.columnHide = null;
            this.lvwCurTooling.columnNames = new string[] {
        "toolingType",
        "partNo",
        "name"};
            this.lvwCurTooling.columnTags = new string[] {
        "ToolingType",
        "ToolingPart",
        "ToolingId"};
            this.lvwCurTooling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCurTooling.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwCurTooling.FullRowSelect = true;
            this.lvwCurTooling.HideSelection = false;
            this.lvwCurTooling.imageKeyColumn = "";
            this.lvwCurTooling.keyPressSearch = false;
            this.lvwCurTooling.keyPressSearchColumn = "";
            this.lvwCurTooling.Location = new System.Drawing.Point(0, 22);
            this.lvwCurTooling.makesureNewItemVisible = true;
            this.lvwCurTooling.MultiSelect = false;
            this.lvwCurTooling.Name = "lvwCurTooling";
            this.lvwCurTooling.OwnerDraw = true;
            this.lvwCurTooling.ShowItemTipSecond = ((byte)(3));
            this.lvwCurTooling.Size = new System.Drawing.Size(681, 261);
            this.lvwCurTooling.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwCurTooling.TabIndex = 11;
            this.lvwCurTooling.UseCompatibleStateImageBehavior = false;
            this.lvwCurTooling.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(681, 22);
            this.label7.TabIndex = 6;
            this.label7.Tag = "currentToolingInfo";
            this.label7.Text = "currentToolingInfo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCurMaterial
            // 
            this.pnlCurMaterial.Controls.Add(this.lvwCurSetupMaterial);
            this.pnlCurMaterial.Controls.Add(this.label6);
            this.pnlCurMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurMaterial.Location = new System.Drawing.Point(0, 0);
            this.pnlCurMaterial.Name = "pnlCurMaterial";
            this.pnlCurMaterial.Size = new System.Drawing.Size(681, 270);
            this.pnlCurMaterial.TabIndex = 0;
            // 
            // lvwCurSetupMaterial
            // 
            this.lvwCurSetupMaterial.allowUserFilter = false;
            this.lvwCurSetupMaterial.allowUserSorting = false;
            this.lvwCurSetupMaterial.autoSizeColumn = false;
            this.lvwCurSetupMaterial.careModifyDate = false;
            this.lvwCurSetupMaterial.columnHide = null;
            this.lvwCurSetupMaterial.columnNames = new string[] {
        "position",
        "name",
        "partNo",
        "materialLotId",
        "quantity"};
            this.lvwCurSetupMaterial.columnTags = new string[] {
        "position",
        "materialType",
        "materialPartNo",
        "materialLotId",
        "quantity"};
            this.lvwCurSetupMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCurSetupMaterial.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwCurSetupMaterial.FullRowSelect = true;
            this.lvwCurSetupMaterial.HideSelection = false;
            this.lvwCurSetupMaterial.imageKeyColumn = "";
            this.lvwCurSetupMaterial.keyPressSearch = false;
            this.lvwCurSetupMaterial.keyPressSearchColumn = "";
            this.lvwCurSetupMaterial.Location = new System.Drawing.Point(0, 22);
            this.lvwCurSetupMaterial.makesureNewItemVisible = true;
            this.lvwCurSetupMaterial.MultiSelect = false;
            this.lvwCurSetupMaterial.Name = "lvwCurSetupMaterial";
            this.lvwCurSetupMaterial.OwnerDraw = true;
            this.lvwCurSetupMaterial.ShowItemTipSecond = ((byte)(3));
            this.lvwCurSetupMaterial.Size = new System.Drawing.Size(681, 248);
            this.lvwCurSetupMaterial.TabIndex = 11;
            this.lvwCurSetupMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwCurSetupMaterial.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(681, 22);
            this.label6.TabIndex = 6;
            this.label6.Tag = "currentSetupInfo";
            this.label6.Text = "currentSetupInfo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblEqParameter
            // 
            this.tblEqParameter.Controls.Add(this.lvwEqParmHistory);
            this.tblEqParameter.Controls.Add(this.panel3);
            this.tblEqParameter.Controls.Add(this.tableLayoutPanel2);
            this.tblEqParameter.Controls.Add(this.panel2);
            this.tblEqParameter.Controls.Add(this.grpCurParameter);
            this.tblEqParameter.Location = new System.Drawing.Point(4, 26);
            this.tblEqParameter.Name = "tblEqParameter";
            this.tblEqParameter.Size = new System.Drawing.Size(681, 553);
            this.tblEqParameter.TabIndex = 2;
            this.tblEqParameter.Tag = "eqParameter";
            this.tblEqParameter.Text = "EqParameter";
            this.tblEqParameter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtEqParmDateFrom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtEqParmDateTo, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQueryEqParm, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(681, 42);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 0;
            this.label10.Tag = "date";
            this.label10.Text = "Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtEqParmDateFrom
            // 
            this.dtEqParmDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtEqParmDateFrom.CustomFormat = "  yyyy / MM / dd HH:mm:ss";
            this.dtEqParmDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEqParmDateFrom.Location = new System.Drawing.Point(49, 6);
            this.dtEqParmDateFrom.Name = "dtEqParmDateFrom";
            this.dtEqParmDateFrom.Size = new System.Drawing.Size(236, 26);
            this.dtEqParmDateFrom.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(291, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "~";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtEqParmDateTo
            // 
            this.dtEqParmDateTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtEqParmDateTo.CustomFormat = "  yyyy / MM / dd HH:mm:ss";
            this.dtEqParmDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEqParmDateTo.Location = new System.Drawing.Point(311, 6);
            this.dtEqParmDateTo.Name = "dtEqParmDateTo";
            this.dtEqParmDateTo.Size = new System.Drawing.Size(236, 26);
            this.dtEqParmDateTo.TabIndex = 3;
            // 
            // btnQueryEqParm
            // 
            this.btnQueryEqParm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryEqParm.Location = new System.Drawing.Point(601, 3);
            this.btnQueryEqParm.Name = "btnQueryEqParm";
            this.btnQueryEqParm.Size = new System.Drawing.Size(77, 33);
            this.btnQueryEqParm.TabIndex = 2;
            this.btnQueryEqParm.Tag = "buttonQuery";
            this.btnQueryEqParm.Text = "Query";
            this.btnQueryEqParm.UseVisualStyleBackColor = true;
            this.btnQueryEqParm.Click += new System.EventHandler(this.btnQueryEqParm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefreshEqParm);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 27);
            this.panel2.TabIndex = 1;
            // 
            // btnRefreshEqParm
            // 
            this.btnRefreshEqParm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshEqParm.Location = new System.Drawing.Point(601, 0);
            this.btnRefreshEqParm.Name = "btnRefreshEqParm";
            this.btnRefreshEqParm.Size = new System.Drawing.Size(77, 23);
            this.btnRefreshEqParm.TabIndex = 7;
            this.btnRefreshEqParm.Tag = "";
            this.btnRefreshEqParm.Text = "Refresh";
            this.btnRefreshEqParm.UseVisualStyleBackColor = true;
            this.btnRefreshEqParm.Click += new System.EventHandler(this.btnRefreshEqParm_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 22);
            this.label8.TabIndex = 5;
            this.label8.Tag = "queryCondition";
            this.label8.Text = "Query Condition";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCurParameter
            // 
            this.grpCurParameter.AutoSize = true;
            this.grpCurParameter.Controls.Add(this.tblCurParameter);
            this.grpCurParameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCurParameter.Location = new System.Drawing.Point(0, 0);
            this.grpCurParameter.Name = "grpCurParameter";
            this.grpCurParameter.Size = new System.Drawing.Size(681, 25);
            this.grpCurParameter.TabIndex = 0;
            this.grpCurParameter.TabStop = false;
            // 
            // tblCurParameter
            // 
            this.tblCurParameter.AutoSize = true;
            this.tblCurParameter.ColumnCount = 4;
            this.tblCurParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCurParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCurParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurParameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCurParameter.Location = new System.Drawing.Point(3, 22);
            this.tblCurParameter.Name = "tblCurParameter";
            this.tblCurParameter.RowCount = 1;
            this.tblCurParameter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCurParameter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCurParameter.Size = new System.Drawing.Size(675, 0);
            this.tblCurParameter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(612, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
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
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 618);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(910, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 27);
            this.panel3.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 22);
            this.label9.TabIndex = 5;
            this.label9.Tag = "";
            this.label9.Text = "History";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwEqParmHistory
            // 
            this.lvwEqParmHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEqParmHistory.FullRowSelect = true;
            this.lvwEqParmHistory.HideSelection = false;
            this.lvwEqParmHistory.Location = new System.Drawing.Point(0, 121);
            this.lvwEqParmHistory.Name = "lvwEqParmHistory";
            this.lvwEqParmHistory.Size = new System.Drawing.Size(681, 432);
            this.lvwEqParmHistory.TabIndex = 8;
            this.lvwEqParmHistory.UseCompatibleStateImageBehavior = false;
            this.lvwEqParmHistory.View = System.Windows.Forms.View.Details;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(910, 643);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "EqProperty";
            this.Text = "EqProperty";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblSetupInfo.ResumeLayout(false);
            this.pnlCurToolingInfo.ResumeLayout(false);
            this.pnlCurMaterial.ResumeLayout(false);
            this.tblEqParameter.ResumeLayout(false);
            this.tblEqParameter.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.grpCurParameter.ResumeLayout(false);
            this.grpCurParameter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private mesRelease.Controls.EquipmentInformation equipmentInformation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Button btnExportHistory;
        private System.Windows.Forms.Button btnHistoryDetail;
        private System.Windows.Forms.ListView lvwHistory;
        private System.Windows.Forms.ColumnHeader activity;
        private System.Windows.Forms.ColumnHeader modify_user;
        private System.Windows.Forms.ColumnHeader modify_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQueryHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader prevstate;
        private System.Windows.Forms.ColumnHeader recipe;
        private System.Windows.Forms.ColumnHeader lotId;
        private System.Windows.Forms.ColumnHeader counter;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.TabPage tblSetupInfo;
        private System.Windows.Forms.Panel pnlCurToolingInfo;
        protected internal idv.mesCore.Controls.MESListView lvwCurTooling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlCurMaterial;
        protected internal idv.mesCore.Controls.MESListView lvwCurSetupMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tblEqParameter;
        private System.Windows.Forms.GroupBox grpCurParameter;
        private System.Windows.Forms.TableLayoutPanel tblCurParameter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtEqParmDateFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtEqParmDateTo;
        private System.Windows.Forms.Button btnQueryEqParm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshEqParm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvwEqParmHistory;

    }
}