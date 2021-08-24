namespace ClientRule.MergeLot
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboEquipmentId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEquipmentType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.cboStage = new System.Windows.Forms.ComboBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scChildLot = new System.Windows.Forms.SplitContainer();
            this.lvwLots = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.carChildCarrier = new mesRelease.Controls.CarrierInformation();
            this.compChildComponent = new mesRelease.Controls.WIPComponentInformation();
            this.tblChildCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.btnMoveCarrier = new System.Windows.Forms.Button();
            this.cboChildCarrier = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabChildLot = new System.Windows.Forms.TabControl();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carParentCarrier = new mesRelease.Controls.CarrierInformation();
            this.compParentComponent = new mesRelease.Controls.WIPComponentInformation();
            this.tblParentCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.cboParentCarrier = new System.Windows.Forms.ComboBox();
            this.btnAddCarrier = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtParentLotId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblContents = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.lotInfomation1 = new mesRelease.Controls.LotInfomation();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChildLot)).BeginInit();
            this.scChildLot.Panel1.SuspendLayout();
            this.scChildLot.Panel2.SuspendLayout();
            this.scChildLot.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tblChildCarrier.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tblParentCarrier.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(191, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scChildLot);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(827, 714);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Location = new System.Drawing.Point(121, 60);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(66, 29);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Tag = "clearAll";
            this.btnClearAll.Text = "clearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click_1);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(125, 681);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(68, 31);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Tag = "buttonQuery";
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Equipment";
            this.groupBox2.Text = "Equipment";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnClearAll, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboEquipmentId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboEquipmentType, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 92);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // cboEquipmentId
            // 
            this.cboEquipmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipmentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEquipmentId.FormattingEnabled = true;
            this.cboEquipmentId.Location = new System.Drawing.Point(121, 34);
            this.cboEquipmentId.MaxDropDownItems = 20;
            this.cboEquipmentId.Name = "cboEquipmentId";
            this.cboEquipmentId.Size = new System.Drawing.Size(66, 24);
            this.cboEquipmentId.Sorted = true;
            this.cboEquipmentId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 0;
            this.label7.Tag = "equipmentId";
            this.label7.Text = "equipmentId";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 6;
            this.label8.Tag = "equipmentType";
            this.label8.Text = "equipmentType";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEquipmentType
            // 
            this.cboEquipmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipmentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEquipmentType.FormattingEnabled = true;
            this.cboEquipmentType.Location = new System.Drawing.Point(121, 8);
            this.cboEquipmentType.MaxDropDownItems = 20;
            this.cboEquipmentType.Name = "cboEquipmentType";
            this.cboEquipmentType.Size = new System.Drawing.Size(66, 24);
            this.cboEquipmentType.Sorted = true;
            this.cboEquipmentType.TabIndex = 7;
            this.cboEquipmentType.SelectedIndexChanged += new System.EventHandler(this.cboEquipmentType_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtLotId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboStepId, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblStep, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cboStage, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStage, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cboRoute, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboProduct, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboOrderId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 182);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotId.Location = new System.Drawing.Point(73, 8);
            this.txtLotId.MaxLength = 40;
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(120, 26);
            this.txtLotId.TabIndex = 9;
            // 
            // cboStepId
            // 
            this.cboStepId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(73, 144);
            this.cboStepId.MaxDropDownItems = 20;
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(120, 24);
            this.cboStepId.Sorted = true;
            this.cboStepId.TabIndex = 5;
            // 
            // lblStep
            // 
            this.lblStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(27, 146);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(40, 16);
            this.lblStep.TabIndex = 4;
            this.lblStep.Tag = "step";
            this.lblStep.Text = "step";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStage
            // 
            this.cboStage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStage.FormattingEnabled = true;
            this.cboStage.Location = new System.Drawing.Point(73, 118);
            this.cboStage.MaxDropDownItems = 20;
            this.cboStage.Name = "cboStage";
            this.cboStage.Size = new System.Drawing.Size(120, 24);
            this.cboStage.Sorted = true;
            this.cboStage.TabIndex = 9;
            // 
            // lblStage
            // 
            this.lblStage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(19, 120);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(48, 16);
            this.lblStage.TabIndex = 8;
            this.lblStage.Tag = "stage";
            this.lblStage.Text = "stage";
            this.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoute
            // 
            this.cboRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(73, 92);
            this.cboRoute.MaxDropDownItems = 20;
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(120, 24);
            this.cboRoute.Sorted = true;
            this.cboRoute.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Tag = "route";
            this.label3.Text = "route";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(73, 66);
            this.cboProduct.MaxDropDownItems = 20;
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(120, 24);
            this.cboProduct.Sorted = true;
            this.cboProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Tag = "product";
            this.label2.Text = "product";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOrderId
            // 
            this.cboOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(73, 40);
            this.cboOrderId.MaxDropDownItems = 20;
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(120, 24);
            this.cboOrderId.Sorted = true;
            this.cboOrderId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Tag = "orderId";
            this.label4.Text = "orderId";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Tag = "lotId";
            this.label6.Text = "lotId";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "queryCondition";
            this.label1.Text = "queryCondition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scChildLot
            // 
            this.scChildLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scChildLot.Location = new System.Drawing.Point(0, 0);
            this.scChildLot.Name = "scChildLot";
            this.scChildLot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scChildLot.Panel1
            // 
            this.scChildLot.Panel1.Controls.Add(this.lvwLots);
            // 
            // scChildLot.Panel2
            // 
            this.scChildLot.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.scChildLot.Panel2.Controls.Add(this.lblContents);
            this.scChildLot.Panel2MinSize = 0;
            this.scChildLot.Size = new System.Drawing.Size(627, 679);
            this.scChildLot.SplitterDistance = 305;
            this.scChildLot.TabIndex = 5;
            // 
            // lvwLots
            // 
            this.lvwLots.allowUserFilter = true;
            this.lvwLots.allowUserSorting = true;
            this.lvwLots.autoSizeColumn = true;
            this.lvwLots.careModifyDate = false;
            this.lvwLots.CheckBoxes = true;
            this.lvwLots.columnHide = null;
            this.lvwLots.columnNames = null;
            this.lvwLots.columnTags = null;
            this.lvwLots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLots.FullRowSelect = true;
            this.lvwLots.HideSelection = false;
            this.lvwLots.imageKeyColumn = "";
            this.lvwLots.keyPressSearch = false;
            this.lvwLots.keyPressSearchColumn = "";
            this.lvwLots.Location = new System.Drawing.Point(0, 0);
            this.lvwLots.makesureNewItemVisible = false;
            this.lvwLots.MultiSelect = false;
            this.lvwLots.Name = "lvwLots";
            this.lvwLots.OwnerDraw = true;
            this.lvwLots.ShowItemTipSecond = ((byte)(3));
            this.lvwLots.Size = new System.Drawing.Size(627, 305);
            this.lvwLots.TabIndex = 3;
            this.lvwLots.UseCompatibleStateImageBehavior = false;
            this.lvwLots.View = System.Windows.Forms.View.Details;
            this.lvwLots.MESItemCheckChanged += new idv.mesCore.Controls.MESListView.delMESItemCheckChanged(this.lvwLots_MESItemCheckChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(627, 348);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.carChildCarrier);
            this.panel3.Controls.Add(this.compChildComponent);
            this.panel3.Controls.Add(this.tblChildCarrier);
            this.panel3.Controls.Add(this.tabChildLot);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(334, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 348);
            this.panel3.TabIndex = 4;
            // 
            // carChildCarrier
            // 
            this.carChildCarrier.allowAdd = true;
            this.carChildCarrier.allowChangeCarrier = false;
            this.carChildCarrier.allowDelete = true;
            this.carChildCarrier.allowEdit = false;
            this.carChildCarrier.allowGenerateId = true;
            this.carChildCarrier.carrierList = null;
            this.carChildCarrier.componentInfo = null;
            this.carChildCarrier.Location = new System.Drawing.Point(22, 188);
            this.carChildCarrier.lotId = "";
            this.carChildCarrier.Name = "carChildCarrier";
            this.carChildCarrier.showCarrierType = false;
            this.carChildCarrier.Size = new System.Drawing.Size(259, 72);
            this.carChildCarrier.TabIndex = 8;
            this.carChildCarrier.DoubleClick += new System.EventHandler(this.carChildCarrier_DoubleClick);
            // 
            // compChildComponent
            // 
            this.compChildComponent.allowEdit = false;
            this.compChildComponent.allowGenerateId = false;
            this.compChildComponent.allowMoveLocation = false;
            this.compChildComponent.carrier = null;
            this.compChildComponent.componentInfo = null;
            this.compChildComponent.expectedQuantity = 0;
            this.compChildComponent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.compChildComponent.Location = new System.Drawing.Point(22, 69);
            this.compChildComponent.lotId = "";
            this.compChildComponent.Name = "compChildComponent";
            this.compChildComponent.showCarrierInfo = false;
            this.compChildComponent.Size = new System.Drawing.Size(259, 96);
            this.compChildComponent.TabIndex = 7;
            this.compChildComponent.DoubleClick += new System.EventHandler(this.compChildComponent_DoubleClick);
            // 
            // tblChildCarrier
            // 
            this.tblChildCarrier.ColumnCount = 4;
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblChildCarrier.Controls.Add(this.btnMoveCarrier, 0, 0);
            this.tblChildCarrier.Controls.Add(this.cboChildCarrier, 2, 0);
            this.tblChildCarrier.Controls.Add(this.label13, 1, 0);
            this.tblChildCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblChildCarrier.Location = new System.Drawing.Point(0, 47);
            this.tblChildCarrier.Name = "tblChildCarrier";
            this.tblChildCarrier.RowCount = 1;
            this.tblChildCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblChildCarrier.Size = new System.Drawing.Size(293, 25);
            this.tblChildCarrier.TabIndex = 6;
            // 
            // btnMoveCarrier
            // 
            this.btnMoveCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveCarrier.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMoveCarrier.Location = new System.Drawing.Point(3, 0);
            this.btnMoveCarrier.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMoveCarrier.Name = "btnMoveCarrier";
            this.btnMoveCarrier.Size = new System.Drawing.Size(34, 26);
            this.btnMoveCarrier.TabIndex = 7;
            this.btnMoveCarrier.Tag = "";
            this.btnMoveCarrier.Text = "f";
            this.btnMoveCarrier.UseVisualStyleBackColor = true;
            this.btnMoveCarrier.Click += new System.EventHandler(this.btnMoveCarrier_Click);
            // 
            // cboChildCarrier
            // 
            this.cboChildCarrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChildCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChildCarrier.FormattingEnabled = true;
            this.cboChildCarrier.Location = new System.Drawing.Point(129, 3);
            this.cboChildCarrier.Name = "cboChildCarrier";
            this.cboChildCarrier.Size = new System.Drawing.Size(138, 24);
            this.cboChildCarrier.Sorted = true;
            this.cboChildCarrier.TabIndex = 5;
            this.cboChildCarrier.SelectedIndexChanged += new System.EventHandler(this.cboChildCarrier_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 0;
            this.label13.Tag = "carrier";
            this.label13.Text = "carrierId";
            // 
            // tabChildLot
            // 
            this.tabChildLot.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabChildLot.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabChildLot.Location = new System.Drawing.Point(0, 17);
            this.tabChildLot.Name = "tabChildLot";
            this.tabChildLot.SelectedIndex = 0;
            this.tabChildLot.Size = new System.Drawing.Size(293, 30);
            this.tabChildLot.TabIndex = 2;
            this.tabChildLot.SelectedIndexChanged += new System.EventHandler(this.tabChildLot_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Navy;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 17);
            this.label12.TabIndex = 1;
            this.label12.Tag = "child";
            this.label12.Text = "child";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnUnSelect, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnSelect, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnSelectAll, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(296, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(35, 342);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.Location = new System.Drawing.Point(4, 174);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(27, 52);
            this.btnUnSelect.TabIndex = 3;
            this.btnUnSelect.Text = "c";
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.Location = new System.Drawing.Point(4, 113);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(27, 52);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "d";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelectAll.Location = new System.Drawing.Point(4, 235);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(27, 52);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "H";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.carParentCarrier);
            this.panel2.Controls.Add(this.compParentComponent);
            this.panel2.Controls.Add(this.tblParentCarrier);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 348);
            this.panel2.TabIndex = 3;
            // 
            // carParentCarrier
            // 
            this.carParentCarrier.allowAdd = true;
            this.carParentCarrier.allowChangeCarrier = false;
            this.carParentCarrier.allowDelete = true;
            this.carParentCarrier.allowEdit = true;
            this.carParentCarrier.allowGenerateId = true;
            this.carParentCarrier.carrierList = null;
            this.carParentCarrier.componentInfo = null;
            this.carParentCarrier.Location = new System.Drawing.Point(20, 201);
            this.carParentCarrier.lotId = "";
            this.carParentCarrier.Name = "carParentCarrier";
            this.carParentCarrier.showCarrierType = false;
            this.carParentCarrier.Size = new System.Drawing.Size(277, 70);
            this.carParentCarrier.TabIndex = 8;
            this.carParentCarrier.CarrierAdded += new mesRelease.Controls.CarrierAddedEventHandler(this.carParentCarrier_CarrierAdded);
            this.carParentCarrier.CarrierRemoved += new mesRelease.Controls.CarrierRemovedEventHandler(this.carParentCarrier_CarrierRemoved);
            this.carParentCarrier.DoubleClick += new System.EventHandler(this.carParentCarrier_DoubleClick);
            // 
            // compParentComponent
            // 
            this.compParentComponent.allowEdit = false;
            this.compParentComponent.allowGenerateId = false;
            this.compParentComponent.allowMoveLocation = true;
            this.compParentComponent.carrier = null;
            this.compParentComponent.componentInfo = null;
            this.compParentComponent.expectedQuantity = 0;
            this.compParentComponent.Location = new System.Drawing.Point(20, 73);
            this.compParentComponent.lotId = "";
            this.compParentComponent.Name = "compParentComponent";
            this.compParentComponent.showCarrierInfo = true;
            this.compParentComponent.Size = new System.Drawing.Size(223, 94);
            this.compParentComponent.TabIndex = 7;
            this.compParentComponent.DoubleClick += new System.EventHandler(this.compParentComponent_DoubleClick);
            // 
            // tblParentCarrier
            // 
            this.tblParentCarrier.ColumnCount = 4;
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblParentCarrier.Controls.Add(this.label14, 0, 0);
            this.tblParentCarrier.Controls.Add(this.cboParentCarrier, 1, 0);
            this.tblParentCarrier.Controls.Add(this.btnAddCarrier, 2, 0);
            this.tblParentCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblParentCarrier.Location = new System.Drawing.Point(0, 47);
            this.tblParentCarrier.Name = "tblParentCarrier";
            this.tblParentCarrier.RowCount = 1;
            this.tblParentCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblParentCarrier.Size = new System.Drawing.Size(293, 25);
            this.tblParentCarrier.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 0;
            this.label14.Tag = "carrier";
            this.label14.Text = "carrierId";
            // 
            // cboParentCarrier
            // 
            this.cboParentCarrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboParentCarrier.FormattingEnabled = true;
            this.cboParentCarrier.Location = new System.Drawing.Point(89, 3);
            this.cboParentCarrier.Name = "cboParentCarrier";
            this.cboParentCarrier.Size = new System.Drawing.Size(138, 24);
            this.cboParentCarrier.Sorted = true;
            this.cboParentCarrier.TabIndex = 5;
            this.cboParentCarrier.SelectedIndexChanged += new System.EventHandler(this.cboParentCarrier_SelectedIndexChanged);
            this.cboParentCarrier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboParentCarrier_KeyUp);
            // 
            // btnAddCarrier
            // 
            this.btnAddCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCarrier.Location = new System.Drawing.Point(233, 0);
            this.btnAddCarrier.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddCarrier.Name = "btnAddCarrier";
            this.btnAddCarrier.Size = new System.Drawing.Size(75, 26);
            this.btnAddCarrier.TabIndex = 6;
            this.btnAddCarrier.Tag = "addCarrier";
            this.btnAddCarrier.Text = "addCarrier";
            this.btnAddCarrier.UseVisualStyleBackColor = true;
            this.btnAddCarrier.Click += new System.EventHandler(this.btnAddCarrier_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtQuantity, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtParentLotId, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(293, 30);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(248, 1);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(49, 26);
            this.txtQuantity.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 30);
            this.label11.TabIndex = 2;
            this.label11.Tag = "quantity";
            this.label11.Text = "quantity";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 30);
            this.label10.TabIndex = 0;
            this.label10.Tag = "parent";
            this.label10.Text = "parentLot";
            // 
            // txtParentLotId
            // 
            this.txtParentLotId.Location = new System.Drawing.Point(61, 1);
            this.txtParentLotId.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtParentLotId.Name = "txtParentLotId";
            this.txtParentLotId.ReadOnly = true;
            this.txtParentLotId.Size = new System.Drawing.Size(131, 26);
            this.txtParentLotId.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 17);
            this.label9.TabIndex = 0;
            this.label9.Tag = "parent";
            this.label9.Text = "parent";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblContents
            // 
            this.lblContents.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContents.ForeColor = System.Drawing.SystemColors.Window;
            this.lblContents.Location = new System.Drawing.Point(0, 0);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(627, 22);
            this.lblContents.TabIndex = 4;
            this.lblContents.Tag = "reasonCode";
            this.lblContents.Text = "Carrier / Components";
            this.lblContents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 679);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(473, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(550, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(191, 714);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(827, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // lotInfomation1
            // 
            this.lotInfomation1.AutoScroll = true;
            this.lotInfomation1.displayProperties = null;
            this.lotInfomation1.displayPropertyTags = null;
            this.lotInfomation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lotInfomation1.editable = true;
            this.lotInfomation1.Location = new System.Drawing.Point(0, 0);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = false;
            this.lotInfomation1.showDueDate = false;
            this.lotInfomation1.Size = new System.Drawing.Size(191, 739);
            this.lotInfomation1.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1018, 739);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Controls.Add(this.lotInfomation1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "MergeLot";
            this.Text = "MergeLot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.scChildLot.Panel1.ResumeLayout(false);
            this.scChildLot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChildLot)).EndInit();
            this.scChildLot.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tblChildCarrier.ResumeLayout(false);
            this.tblChildCarrier.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tblParentCarrier.ResumeLayout(false);
            this.tblParentCarrier.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.ComboBox cboStage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboEquipmentId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEquipmentType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.SplitContainer scChildLot;
        private idv.mesCore.Controls.MESListView lvwLots;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tblParentCarrier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboParentCarrier;
        private System.Windows.Forms.Button btnAddCarrier;
        private System.Windows.Forms.TableLayoutPanel tblChildCarrier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboChildCarrier;
        private System.Windows.Forms.TabControl tabChildLot;
        private mesRelease.Controls.WIPComponentInformation compChildComponent;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnMoveCarrier;
        private mesRelease.Controls.CarrierInformation carChildCarrier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtParentLotId;
        private mesRelease.Controls.CarrierInformation carParentCarrier;
        private mesRelease.Controls.WIPComponentInformation compParentComponent;
        private mesRelease.Controls.LotInfomation lotInfomation1;

    }
}