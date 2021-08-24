namespace ClientRule.StartLot
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOrderProductId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOrderFab = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOrderType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboOrderCustomerId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwOrder = new idv.mesCore.Controls.MESListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCarrier = new System.Windows.Forms.TabPage();
            this.carrierInformation1 = new mesRelease.Controls.CarrierInformation();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.wipComponentInformation1 = new mesRelease.Controls.WIPComponentInformation();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.btnGenerateLot = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLotId = new System.Windows.Forms.Label();
            this.cboCustomerLotId = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboSourceParent = new System.Windows.Forms.ComboBox();
            this.cboSpecId = new System.Windows.Forms.ComboBox();
            this.cboFab = new System.Windows.Forms.ComboBox();
            this.lblSpecId = new System.Windows.Forms.Label();
            this.lblFab = new System.Windows.Forms.Label();
            this.cboStartStep = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.cboProductId = new System.Windows.Forms.ComboBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.cboLotType = new System.Windows.Forms.ComboBox();
            this.lblLotType = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cboOwner = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpCustomerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.cboCustomerId = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCarrier.SuspendLayout();
            this.tabMembers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 646);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboOrderProductId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboOrderFab, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboOrderType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboOrderCustomerId, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboStatus, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 190);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(24, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 24);
            this.btnClear.TabIndex = 14;
            this.btnClear.Tag = "buttonClear";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(155, 163);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(67, 24);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Tag = "buttonQuery";
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Tag = "productId";
            this.label3.Text = "productId";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOrderProductId
            // 
            this.cboOrderProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderProductId.BackColor = System.Drawing.SystemColors.Window;
            this.cboOrderProductId.FormattingEnabled = true;
            this.cboOrderProductId.Location = new System.Drawing.Point(97, 43);
            this.cboOrderProductId.Name = "cboOrderProductId";
            this.cboOrderProductId.Size = new System.Drawing.Size(125, 24);
            this.cboOrderProductId.Sorted = true;
            this.cboOrderProductId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 6;
            this.label4.Tag = "fab";
            this.label4.Text = "fab";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOrderFab
            // 
            this.cboOrderFab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderFab.BackColor = System.Drawing.SystemColors.Window;
            this.cboOrderFab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderFab.FormattingEnabled = true;
            this.cboOrderFab.Location = new System.Drawing.Point(97, 13);
            this.cboOrderFab.Name = "cboOrderFab";
            this.cboOrderFab.Size = new System.Drawing.Size(125, 24);
            this.cboOrderFab.Sorted = true;
            this.cboOrderFab.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 8;
            this.label5.Tag = "orderType";
            this.label5.Text = "orderType";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOrderType
            // 
            this.cboOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderType.BackColor = System.Drawing.SystemColors.Window;
            this.cboOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderType.FormattingEnabled = true;
            this.cboOrderType.Location = new System.Drawing.Point(97, 73);
            this.cboOrderType.Name = "cboOrderType";
            this.cboOrderType.Size = new System.Drawing.Size(125, 24);
            this.cboOrderType.Sorted = true;
            this.cboOrderType.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 10;
            this.label7.Tag = "customerId";
            this.label7.Text = "customerId";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOrderCustomerId
            // 
            this.cboOrderCustomerId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderCustomerId.BackColor = System.Drawing.SystemColors.Window;
            this.cboOrderCustomerId.FormattingEnabled = true;
            this.cboOrderCustomerId.Location = new System.Drawing.Point(97, 103);
            this.cboOrderCustomerId.Name = "cboOrderCustomerId";
            this.cboOrderCustomerId.Size = new System.Drawing.Size(125, 24);
            this.cboOrderCustomerId.Sorted = true;
            this.cboOrderCustomerId.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 12;
            this.label8.Tag = "status";
            this.label8.Text = "status";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(97, 133);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(125, 24);
            this.cboStatus.Sorted = true;
            this.cboStatus.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "queryCondition";
            this.label1.Text = "queryCondition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwOrder);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Size = new System.Drawing.Size(889, 611);
            this.splitContainer2.SplitterDistance = 274;
            this.splitContainer2.TabIndex = 6;
            // 
            // lvwOrder
            // 
            this.lvwOrder.allowUserFilter = true;
            this.lvwOrder.allowUserSorting = true;
            this.lvwOrder.autoSizeColumn = true;
            this.lvwOrder.careModifyDate = false;
            this.lvwOrder.columnHide = null;
            this.lvwOrder.columnNames = new string[] {
        "name",
        "orderType",
        "fab",
        "priority",
        "routeId",
        "specId",
        "quantity",
        "receiveQuantity",
        "startQuantity",
        "lotCount",
        "owner",
        "customerId",
        "status",
        "remark"};
            this.lvwOrder.columnTags = new string[] {
        "orderId",
        "orderType",
        "fab",
        "priority",
        "routeId",
        "specId",
        "quantity",
        "receiveQuantity",
        "quantityStarted",
        "lotCount",
        "owner",
        "customerId",
        "status",
        "remark"};
            this.lvwOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwOrder.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwOrder.FullRowSelect = true;
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.imageKeyColumn = "";
            this.lvwOrder.keyPressSearch = true;
            this.lvwOrder.keyPressSearchColumn = "";
            this.lvwOrder.Location = new System.Drawing.Point(0, 22);
            this.lvwOrder.makesureNewItemVisible = false;
            this.lvwOrder.MultiSelect = false;
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.OwnerDraw = true;
            this.lvwOrder.ShowItemTipSecond = ((byte)(3));
            this.lvwOrder.Size = new System.Drawing.Size(889, 252);
            this.lvwOrder.TabIndex = 16;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.View = System.Windows.Forms.View.Details;
            this.lvwOrder.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwOrder_MESItemSelectionChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(889, 22);
            this.label2.TabIndex = 15;
            this.label2.Tag = "orderInformation";
            this.label2.Text = "Order Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCarrier);
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(553, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 311);
            this.tabControl1.TabIndex = 17;
            // 
            // tabCarrier
            // 
            this.tabCarrier.Controls.Add(this.carrierInformation1);
            this.tabCarrier.Location = new System.Drawing.Point(4, 24);
            this.tabCarrier.Name = "tabCarrier";
            this.tabCarrier.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tabCarrier.Size = new System.Drawing.Size(328, 283);
            this.tabCarrier.TabIndex = 0;
            this.tabCarrier.Tag = "carrier";
            this.tabCarrier.Text = "carrier";
            this.tabCarrier.UseVisualStyleBackColor = true;
            // 
            // carrierInformation1
            // 
            this.carrierInformation1.allowAdd = true;
            this.carrierInformation1.allowChangeCarrier = true;
            this.carrierInformation1.allowDelete = true;
            this.carrierInformation1.allowEdit = true;
            this.carrierInformation1.allowGenerateId = true;
            this.carrierInformation1.carrierList = null;
            this.carrierInformation1.componentInfo = null;
            this.carrierInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carrierInformation1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.carrierInformation1.Location = new System.Drawing.Point(0, 3);
            this.carrierInformation1.lotId = "";
            this.carrierInformation1.Name = "carrierInformation1";
            this.carrierInformation1.showCarrierType = false;
            this.carrierInformation1.Size = new System.Drawing.Size(328, 277);
            this.carrierInformation1.TabIndex = 0;
            this.carrierInformation1.CarrierAdded += new mesRelease.Controls.CarrierAddedEventHandler(this.carrierInformation1_CarrierAdded);
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.wipComponentInformation1);
            this.tabMembers.Location = new System.Drawing.Point(4, 24);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(328, 283);
            this.tabMembers.TabIndex = 1;
            this.tabMembers.Tag = "members";
            this.tabMembers.Text = "members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // wipComponentInformation1
            // 
            this.wipComponentInformation1.allowEdit = true;
            this.wipComponentInformation1.allowGenerateId = true;
            this.wipComponentInformation1.allowMoveLocation = true;
            this.wipComponentInformation1.carrier = null;
            this.wipComponentInformation1.componentInfo = null;
            this.wipComponentInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wipComponentInformation1.expectedQuantity = 0;
            this.wipComponentInformation1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wipComponentInformation1.Location = new System.Drawing.Point(3, 3);
            this.wipComponentInformation1.lotId = "";
            this.wipComponentInformation1.Margin = new System.Windows.Forms.Padding(4);
            this.wipComponentInformation1.Name = "wipComponentInformation1";
            this.wipComponentInformation1.showCarrierInfo = false;
            this.wipComponentInformation1.Size = new System.Drawing.Size(322, 277);
            this.wipComponentInformation1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblLotId, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboCustomerLotId, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtOrderId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cboSourceParent, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cboSpecId, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.cboFab, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSpecId, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblFab, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboStartStep, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label19, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.cboRoute, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblRouteId, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboProductId, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblProductId, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboLotType, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLotType, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUnit, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboUnit, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblQuantity, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtQuantity, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cboPriority, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label21, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.cboOwner, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.label23, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.dtpDueDate, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label25, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.dtpCustomerDueDate, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.label24, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.cboCustomerId, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtRemark, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(553, 311);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtLotId, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGenerateLot, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(118, 32);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(163, 32);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotId.BackColor = System.Drawing.SystemColors.Info;
            this.txtLotId.Location = new System.Drawing.Point(3, 3);
            this.txtLotId.MaxLength = 40;
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(122, 26);
            this.txtLotId.TabIndex = 0;
            this.txtLotId.Leave += new System.EventHandler(this.txtLotId_Leave);
            // 
            // btnGenerateLot
            // 
            this.btnGenerateLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerateLot.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnGenerateLot.Location = new System.Drawing.Point(131, 4);
            this.btnGenerateLot.Name = "btnGenerateLot";
            this.btnGenerateLot.Size = new System.Drawing.Size(29, 23);
            this.btnGenerateLot.TabIndex = 13;
            this.btnGenerateLot.Text = "7";
            this.btnGenerateLot.UseVisualStyleBackColor = true;
            this.btnGenerateLot.Click += new System.EventHandler(this.btnGenerateLot_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 18;
            this.label13.Tag = "customerLotId";
            this.label13.Text = "customerLotId";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLotId
            // 
            this.lblLotId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLotId.AutoSize = true;
            this.lblLotId.Location = new System.Drawing.Point(67, 40);
            this.lblLotId.Name = "lblLotId";
            this.lblLotId.Size = new System.Drawing.Size(48, 16);
            this.lblLotId.TabIndex = 11;
            this.lblLotId.Tag = "lotId";
            this.lblLotId.Text = "lotId";
            this.lblLotId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCustomerLotId
            // 
            this.cboCustomerLotId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCustomerLotId.BackColor = System.Drawing.SystemColors.Window;
            this.cboCustomerLotId.FormattingEnabled = true;
            this.cboCustomerLotId.Location = new System.Drawing.Point(121, 159);
            this.cboCustomerLotId.Name = "cboCustomerLotId";
            this.cboCustomerLotId.Size = new System.Drawing.Size(160, 24);
            this.cboCustomerLotId.Sorted = true;
            this.cboCustomerLotId.TabIndex = 5;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderId.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderId.Location = new System.Drawing.Point(121, 3);
            this.txtOrderId.MaxLength = 40;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(160, 26);
            this.txtOrderId.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 11;
            this.label18.Tag = "orderId";
            this.label18.Text = "orderId";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 16;
            this.label12.Tag = "sourceParent";
            this.label12.Text = "sourceParent";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSourceParent
            // 
            this.cboSourceParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSourceParent.BackColor = System.Drawing.SystemColors.Window;
            this.cboSourceParent.FormattingEnabled = true;
            this.cboSourceParent.Location = new System.Drawing.Point(121, 129);
            this.cboSourceParent.Name = "cboSourceParent";
            this.cboSourceParent.Size = new System.Drawing.Size(160, 24);
            this.cboSourceParent.Sorted = true;
            this.cboSourceParent.TabIndex = 4;
            // 
            // cboSpecId
            // 
            this.cboSpecId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSpecId.BackColor = System.Drawing.SystemColors.Info;
            this.cboSpecId.FormattingEnabled = true;
            this.cboSpecId.Location = new System.Drawing.Point(389, 159);
            this.cboSpecId.Name = "cboSpecId";
            this.cboSpecId.Size = new System.Drawing.Size(161, 24);
            this.cboSpecId.Sorted = true;
            this.cboSpecId.TabIndex = 3;
            // 
            // cboFab
            // 
            this.cboFab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFab.BackColor = System.Drawing.SystemColors.Info;
            this.cboFab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFab.FormattingEnabled = true;
            this.cboFab.Location = new System.Drawing.Point(389, 4);
            this.cboFab.Name = "cboFab";
            this.cboFab.Size = new System.Drawing.Size(91, 24);
            this.cboFab.Sorted = true;
            this.cboFab.TabIndex = 8;
            // 
            // lblSpecId
            // 
            this.lblSpecId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSpecId.AutoSize = true;
            this.lblSpecId.Location = new System.Drawing.Point(327, 163);
            this.lblSpecId.Name = "lblSpecId";
            this.lblSpecId.Size = new System.Drawing.Size(56, 16);
            this.lblSpecId.TabIndex = 22;
            this.lblSpecId.Tag = "specId";
            this.lblSpecId.Text = "specId";
            this.lblSpecId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFab
            // 
            this.lblFab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFab.AutoSize = true;
            this.lblFab.Location = new System.Drawing.Point(351, 8);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(32, 16);
            this.lblFab.TabIndex = 13;
            this.lblFab.Tag = "fab";
            this.lblFab.Text = "fab";
            this.lblFab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStartStep
            // 
            this.cboStartStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStartStep.BackColor = System.Drawing.SystemColors.Window;
            this.cboStartStep.FormattingEnabled = true;
            this.cboStartStep.Location = new System.Drawing.Point(389, 129);
            this.cboStartStep.Name = "cboStartStep";
            this.cboStartStep.Size = new System.Drawing.Size(161, 24);
            this.cboStartStep.TabIndex = 12;
            this.cboStartStep.SelectedIndexChanged += new System.EventHandler(this.cboStartStep_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(311, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 16);
            this.label19.TabIndex = 21;
            this.label19.Tag = "fromStep";
            this.label19.Text = "fromStep";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoute
            // 
            this.cboRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoute.BackColor = System.Drawing.SystemColors.Info;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(389, 99);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(161, 24);
            this.cboRoute.Sorted = true;
            this.cboRoute.TabIndex = 11;
            this.cboRoute.SelectedIndexChanged += new System.EventHandler(this.cboRoute_SelectedIndexChanged);
            // 
            // lblRouteId
            // 
            this.lblRouteId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.Location = new System.Drawing.Point(319, 103);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(64, 16);
            this.lblRouteId.TabIndex = 18;
            this.lblRouteId.Tag = "routeId";
            this.lblRouteId.Text = "routeId";
            this.lblRouteId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProductId
            // 
            this.cboProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProductId.BackColor = System.Drawing.SystemColors.Info;
            this.cboProductId.FormattingEnabled = true;
            this.cboProductId.Location = new System.Drawing.Point(389, 68);
            this.cboProductId.Name = "cboProductId";
            this.cboProductId.Size = new System.Drawing.Size(161, 24);
            this.cboProductId.Sorted = true;
            this.cboProductId.TabIndex = 10;
            this.cboProductId.SelectedIndexChanged += new System.EventHandler(this.cboProductId_SelectedIndexChanged);
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(303, 72);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(80, 16);
            this.lblProductId.TabIndex = 16;
            this.lblProductId.Tag = "productId";
            this.lblProductId.Text = "productId";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLotType
            // 
            this.cboLotType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLotType.BackColor = System.Drawing.SystemColors.Info;
            this.cboLotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLotType.FormattingEnabled = true;
            this.cboLotType.Location = new System.Drawing.Point(389, 36);
            this.cboLotType.Name = "cboLotType";
            this.cboLotType.Size = new System.Drawing.Size(91, 24);
            this.cboLotType.Sorted = true;
            this.cboLotType.TabIndex = 9;
            // 
            // lblLotType
            // 
            this.lblLotType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLotType.AutoSize = true;
            this.lblLotType.Location = new System.Drawing.Point(319, 40);
            this.lblLotType.Name = "lblLotType";
            this.lblLotType.Size = new System.Drawing.Size(64, 16);
            this.lblLotType.TabIndex = 15;
            this.lblLotType.Tag = "lotType";
            this.lblLotType.Text = "lotType";
            this.lblLotType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(75, 103);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 16);
            this.lblUnit.TabIndex = 15;
            this.lblUnit.Tag = "unit";
            this.lblUnit.Text = "unit";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboUnit
            // 
            this.cboUnit.BackColor = System.Drawing.SystemColors.Info;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(121, 99);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(91, 24);
            this.cboUnit.Sorted = true;
            this.cboUnit.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(43, 72);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 16);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Tag = "quantity";
            this.lblQuantity.Text = "quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.txtQuantity.Location = new System.Drawing.Point(121, 67);
            this.txtQuantity.MaxLength = 6;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(91, 26);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(59, 255);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 20;
            this.label22.Tag = "remark";
            this.label22.Text = "remark";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(43, 193);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 23;
            this.label20.Tag = "priority";
            this.label20.Text = "priority";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPriority
            // 
            this.cboPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPriority.BackColor = System.Drawing.SystemColors.Window;
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(121, 189);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(91, 24);
            this.cboPriority.Sorted = true;
            this.cboPriority.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(335, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 16);
            this.label21.TabIndex = 24;
            this.label21.Tag = "owner";
            this.label21.Text = "owner";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOwner
            // 
            this.cboOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOwner.BackColor = System.Drawing.SystemColors.Window;
            this.cboOwner.FormattingEnabled = true;
            this.cboOwner.Location = new System.Drawing.Point(389, 189);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Size = new System.Drawing.Size(161, 24);
            this.cboOwner.Sorted = true;
            this.cboOwner.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(51, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 16);
            this.label23.TabIndex = 25;
            this.label23.Tag = "dueDate";
            this.label23.Text = "dueDate";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDueDate.Checked = false;
            this.dtpDueDate.Location = new System.Drawing.Point(121, 219);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShowCheckBox = true;
            this.dtpDueDate.Size = new System.Drawing.Size(160, 26);
            this.dtpDueDate.TabIndex = 15;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(287, 224);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 16);
            this.label25.TabIndex = 28;
            this.label25.Tag = "customerDueDate";
            this.label25.Text = "custDueDate";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCustomerDueDate
            // 
            this.dtpCustomerDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCustomerDueDate.Checked = false;
            this.dtpCustomerDueDate.Location = new System.Drawing.Point(389, 219);
            this.dtpCustomerDueDate.Name = "dtpCustomerDueDate";
            this.dtpCustomerDueDate.ShowCheckBox = true;
            this.dtpCustomerDueDate.Size = new System.Drawing.Size(161, 26);
            this.dtpCustomerDueDate.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(295, 255);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 16);
            this.label24.TabIndex = 27;
            this.label24.Tag = "customerId";
            this.label24.Text = "customerId";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCustomerId
            // 
            this.cboCustomerId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCustomerId.BackColor = System.Drawing.SystemColors.Window;
            this.cboCustomerId.FormattingEnabled = true;
            this.cboCustomerId.Location = new System.Drawing.Point(389, 251);
            this.cboCustomerId.Name = "cboCustomerId";
            this.cboCustomerId.Size = new System.Drawing.Size(161, 24);
            this.cboCustomerId.Sorted = true;
            this.cboCustomerId.TabIndex = 16;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.SetColumnSpan(this.txtRemark, 4);
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Location = new System.Drawing.Point(3, 281);
            this.txtRemark.MaxLength = 255;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(547, 27);
            this.txtRemark.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(889, 22);
            this.label6.TabIndex = 14;
            this.label6.Tag = "lotInformation";
            this.label6.Text = "lotInformation";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(812, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(735, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 0;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 646);
            this.standardStatusbar1.MinimumSize = new System.Drawing.Size(0, 25);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(1118, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1118, 671);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "StartLot";
            this.Text = "StartLot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCarrier.ResumeLayout(false);
            this.tabMembers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboOrderProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOrderFab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOrderType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboOrderCustomerId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClear;
        private idv.mesCore.Controls.MESListView lvwOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLotId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cboSourceParent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboCustomerLotId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.ComboBox cboProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox cboLotType;
        private System.Windows.Forms.Label lblLotType;
        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.ComboBox cboFab;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboStartStep;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboOwner;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtpCustomerDueDate;
        private System.Windows.Forms.ComboBox cboCustomerId;
        private System.Windows.Forms.Label lblSpecId;
        private System.Windows.Forms.ComboBox cboSpecId;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.Button btnGenerateLot;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCarrier;
        private System.Windows.Forms.TabPage tabMembers;
        private mesRelease.Controls.WIPComponentInformation wipComponentInformation1;
        private mesRelease.Controls.CarrierInformation carrierInformation1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    }
}