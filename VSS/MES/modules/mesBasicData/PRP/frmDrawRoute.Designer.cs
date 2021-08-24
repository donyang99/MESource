namespace mesBasicData
{
    partial class frmDrawRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawRoute));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRouteType = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.lblRouteType = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvwStep = new idv.mesCore.Controls.MESListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvwRoute = new idv.mesCore.Controls.MESListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tblRoutePanelAction = new System.Windows.Forms.ToolStrip();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.buttonValid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonModify = new System.Windows.Forms.ToolStripButton();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.buttonAddPath = new System.Windows.Forms.ToolStripButton();
            this.cboPathName = new System.Windows.Forms.ToolStripComboBox();
            this.buttonClear = new System.Windows.Forms.ToolStripButton();
            this.buttonView = new System.Windows.Forms.ToolStripButton();
            this.scrSize = new System.Windows.Forms.HScrollBar();
            this.routePanel1 = new idv.mesCore.Controls.routePanel();
            this.scrFont = new System.Windows.Forms.HScrollBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tblRoutePanelAction.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1028, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "route";
            this.groupBox1.Text = "route";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtRouteType, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVersion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRoute, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRoute, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRouteType, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtRouteType
            // 
            this.txtRouteType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRouteType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRouteType.Location = new System.Drawing.Point(437, 3);
            this.txtRouteType.MaxLength = 40;
            this.txtRouteType.Name = "txtRouteType";
            this.txtRouteType.ReadOnly = true;
            this.txtRouteType.Size = new System.Drawing.Size(104, 26);
            this.txtRouteType.TabIndex = 5;
            this.txtRouteType.TabStop = false;
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVersion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtVersion.Location = new System.Drawing.Point(307, 3);
            this.txtVersion.MaxLength = 40;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(38, 26);
            this.txtVersion.TabIndex = 8;
            this.txtVersion.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVersion.Location = new System.Drawing.Point(237, 8);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(64, 16);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Tag = "version";
            this.lblVersion.Text = "version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescription.Location = new System.Drawing.Point(649, 3);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(370, 26);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(547, 8);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 16);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Tag = "description";
            this.lblDescription.Text = "description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoute
            // 
            this.lblRoute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoute.AutoSize = true;
            this.lblRoute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRoute.Location = new System.Drawing.Point(3, 8);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(48, 16);
            this.lblRoute.TabIndex = 0;
            this.lblRoute.Tag = "route";
            this.lblRoute.Text = "route";
            this.lblRoute.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRoute
            // 
            this.txtRoute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRoute.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRoute.Location = new System.Drawing.Point(57, 3);
            this.txtRoute.MaxLength = 40;
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.ReadOnly = true;
            this.txtRoute.Size = new System.Drawing.Size(174, 26);
            this.txtRoute.TabIndex = 1;
            this.txtRoute.TabStop = false;
            // 
            // lblRouteType
            // 
            this.lblRouteType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRouteType.AutoSize = true;
            this.lblRouteType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRouteType.Location = new System.Drawing.Point(351, 8);
            this.lblRouteType.Name = "lblRouteType";
            this.lblRouteType.Size = new System.Drawing.Size(80, 16);
            this.lblRouteType.TabIndex = 2;
            this.lblRouteType.Tag = "routeType";
            this.lblRouteType.Text = "routeType";
            this.lblRouteType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(234, 618);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvwStep);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(226, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "Step";
            this.tabPage1.Text = "step";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvwStep
            // 
            this.lvwStep.allowUserFilter = true;
            this.lvwStep.allowUserSorting = true;
            this.lvwStep.autoSizeColumn = true;
            this.lvwStep.careModifyDate = false;
            this.lvwStep.columnHide = null;
            this.lvwStep.columnNames = new string[] {
        "name",
        "version",
        "fab"};
            this.lvwStep.columnTags = new string[] {
        "Step",
        "version",
        "fab"};
            this.lvwStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStep.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwStep.FullRowSelect = true;
            this.lvwStep.GridLines = true;
            this.lvwStep.HideSelection = false;
            this.lvwStep.imageKeyColumn = "";
            this.lvwStep.keyPressSearch = false;
            this.lvwStep.keyPressSearchColumn = "";
            this.lvwStep.Location = new System.Drawing.Point(3, 3);
            this.lvwStep.makesureNewItemVisible = true;
            this.lvwStep.MultiSelect = false;
            this.lvwStep.Name = "lvwStep";
            this.lvwStep.OwnerDraw = true;
            this.lvwStep.ShowItemTipSecond = ((byte)(3));
            this.lvwStep.Size = new System.Drawing.Size(220, 582);
            this.lvwStep.TabIndex = 0;
            this.lvwStep.UseCompatibleStateImageBehavior = false;
            this.lvwStep.View = System.Windows.Forms.View.Details;
            this.lvwStep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvwRoute);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(226, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "route";
            this.tabPage2.Text = "route";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvwRoute
            // 
            this.lvwRoute.allowUserFilter = true;
            this.lvwRoute.allowUserSorting = true;
            this.lvwRoute.autoSizeColumn = true;
            this.lvwRoute.careModifyDate = false;
            this.lvwRoute.columnHide = null;
            this.lvwRoute.columnNames = new string[] {
        "name",
        "version"};
            this.lvwRoute.columnTags = new string[] {
        "route",
        "version"};
            this.lvwRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRoute.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwRoute.FullRowSelect = true;
            this.lvwRoute.GridLines = true;
            this.lvwRoute.HideSelection = false;
            this.lvwRoute.imageKeyColumn = "";
            this.lvwRoute.keyPressSearch = false;
            this.lvwRoute.keyPressSearchColumn = "";
            this.lvwRoute.Location = new System.Drawing.Point(3, 3);
            this.lvwRoute.makesureNewItemVisible = true;
            this.lvwRoute.MultiSelect = false;
            this.lvwRoute.Name = "lvwRoute";
            this.lvwRoute.OwnerDraw = true;
            this.lvwRoute.ShowItemTipSecond = ((byte)(3));
            this.lvwRoute.Size = new System.Drawing.Size(220, 595);
            this.lvwRoute.TabIndex = 1;
            this.lvwRoute.UseCompatibleStateImageBehavior = false;
            this.lvwRoute.View = System.Windows.Forms.View.Details;
            this.lvwRoute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvw_MouseDown);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(234, 54);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 618);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // tblRoutePanelAction
            // 
            this.tblRoutePanelAction.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblRoutePanelAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSave,
            this.buttonValid,
            this.toolStripSeparator1,
            this.buttonModify,
            this.buttonDelete,
            this.buttonAddPath,
            this.cboPathName,
            this.buttonClear,
            this.buttonView});
            this.tblRoutePanelAction.Location = new System.Drawing.Point(0, 0);
            this.tblRoutePanelAction.Name = "tblRoutePanelAction";
            this.tblRoutePanelAction.Size = new System.Drawing.Size(503, 25);
            this.tblRoutePanelAction.TabIndex = 8;
            this.tblRoutePanelAction.Text = "toolStrip1";
            this.tblRoutePanelAction.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tblRoutePanelAction_ItemClicked);
            // 
            // buttonSave
            // 
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(44, 22);
            this.buttonSave.Tag = "save";
            this.buttonSave.Text = "Save";
            // 
            // buttonValid
            // 
            this.buttonValid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonValid.Enabled = false;
            this.buttonValid.Image = ((System.Drawing.Image)(resources.GetObject("buttonValid.Image")));
            this.buttonValid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(41, 22);
            this.buttonValid.Tag = "validRoute";
            this.buttonValid.Text = "Valid";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonModify
            // 
            this.buttonModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonModify.Enabled = false;
            this.buttonModify.Image = ((System.Drawing.Image)(resources.GetObject("buttonModify.Image")));
            this.buttonModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(53, 22);
            this.buttonModify.Tag = "Modify";
            this.buttonModify.Text = "Modify";
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(49, 22);
            this.buttonDelete.Tag = "Delete";
            this.buttonDelete.Text = "Delete";
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAddPath.Enabled = false;
            this.buttonAddPath.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPath.Image")));
            this.buttonAddPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(65, 22);
            this.buttonAddPath.Tag = "AddPath";
            this.buttonAddPath.Text = "Add Path";
            // 
            // cboPathName
            // 
            this.cboPathName.Items.AddRange(new object[] {
            "",
            "PASS",
            "REWORK"});
            this.cboPathName.Name = "cboPathName";
            this.cboPathName.Size = new System.Drawing.Size(121, 25);
            this.cboPathName.Text = "PASS";
            this.cboPathName.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonClear.Enabled = false;
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(42, 22);
            this.buttonClear.Tag = "buttonClear";
            this.buttonClear.Text = "Clear";
            // 
            // buttonView
            // 
            this.buttonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonView.Image = ((System.Drawing.Image)(resources.GetObject("buttonView.Image")));
            this.buttonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(39, 22);
            this.buttonView.Tag = "buttonView";
            this.buttonView.Text = "View";
            // 
            // scrSize
            // 
            this.scrSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrSize.LargeChange = 1;
            this.scrSize.Location = new System.Drawing.Point(222, 0);
            this.scrSize.Maximum = 16;
            this.scrSize.Minimum = 5;
            this.scrSize.Name = "scrSize";
            this.scrSize.Size = new System.Drawing.Size(66, 25);
            this.scrSize.TabIndex = 10;
            this.scrSize.Value = 9;
            this.scrSize.ValueChanged += new System.EventHandler(this.scrSize_ValueChanged);
            // 
            // routePanel1
            // 
            this.routePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routePanel1.fontSizePlus = 2F;
            this.routePanel1.gridSize = 9F;
            this.routePanel1.Location = new System.Drawing.Point(237, 79);
            this.routePanel1.Name = "routePanel1";
            this.routePanel1.Size = new System.Drawing.Size(791, 593);
            this.routePanel1.TabIndex = 9;
            this.routePanel1.CellDragDrop += new idv.mesCore.Controls.routePanel.degCellDragDrop(this.routePanel1_CellDragDrop);
            this.routePanel1.CellClick += new idv.mesCore.Controls.routePanel.degCellClick(this.routePanel1_CellClick);
            this.routePanel1.LineClick += new idv.mesCore.Controls.routePanel.degLineClick(this.routePanel1_LineClick);
            // 
            // scrFont
            // 
            this.scrFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrFont.LargeChange = 1;
            this.scrFont.Location = new System.Drawing.Point(78, 0);
            this.scrFont.Maximum = 5;
            this.scrFont.Minimum = -3;
            this.scrFont.Name = "scrFont";
            this.scrFont.Size = new System.Drawing.Size(66, 25);
            this.scrFont.TabIndex = 11;
            this.scrFont.Value = 2;
            this.scrFont.ValueChanged += new System.EventHandler(this.scrFont_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.scrFont, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.scrSize, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFont, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSize, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(503, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 25);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // lblFont
            // 
            this.lblFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(3, 4);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(72, 16);
            this.lblFont.TabIndex = 12;
            this.lblFont.Tag = "font";
            this.lblFont.Text = "調整字體";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(147, 4);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(72, 16);
            this.lblSize.TabIndex = 13;
            this.lblSize.Tag = "size";
            this.lblSize.Text = "調整尺寸";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tblRoutePanelAction);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(237, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 25);
            this.panel1.TabIndex = 13;
            // 
            // frmDrawRoute
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1028, 672);
            this.Controls.Add(this.routePanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDrawRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "buttonDrawRoute";
            this.Text = "frmDrawRoute";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDrawRoute_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tblRoutePanelAction.ResumeLayout(false);
            this.tblRoutePanelAction.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.Label lblRouteType;
        private System.Windows.Forms.TextBox txtRouteType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private idv.mesCore.Controls.MESListView lvwStep;
        private System.Windows.Forms.TabPage tabPage2;
        private idv.mesCore.Controls.MESListView lvwRoute;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip tblRoutePanelAction;
        private System.Windows.Forms.ToolStripButton buttonModify;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.ToolStripButton buttonAddPath;
        private System.Windows.Forms.ToolStripComboBox cboPathName;
        private System.Windows.Forms.ToolStripButton buttonClear;
        private System.Windows.Forms.ToolStripButton buttonView;
        private idv.mesCore.Controls.routePanel routePanel1;
        private System.Windows.Forms.HScrollBar scrSize;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonValid;
        private System.Windows.Forms.HScrollBar scrFont;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblSize;
    }
}