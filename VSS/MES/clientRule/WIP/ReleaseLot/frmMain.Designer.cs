namespace ClientRule.ReleaseLot
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwLots = new idv.mesCore.Controls.MESListView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lvwHoldReason = new idv.mesCore.Controls.MESListView();
            this.label10 = new System.Windows.Forms.Label();
            this.reasonCode1 = new mesRelease.Controls.ReasonCode();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(769, 500);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Location = new System.Drawing.Point(154, 60);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(82, 29);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Tag = "clearAll";
            this.btnClearAll.Text = "clearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click_1);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(157, 468);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 31);
            this.btnQuery.TabIndex = 9;
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
            this.groupBox2.Location = new System.Drawing.Point(0, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 117);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 92);
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
            this.cboEquipmentId.Size = new System.Drawing.Size(115, 24);
            this.cboEquipmentId.Sorted = true;
            this.cboEquipmentId.TabIndex = 7;
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
            this.cboEquipmentType.Size = new System.Drawing.Size(115, 24);
            this.cboEquipmentType.Sorted = true;
            this.cboEquipmentType.TabIndex = 6;
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
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 172);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotId.Location = new System.Drawing.Point(73, 8);
            this.txtLotId.MaxLength = 40;
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(169, 26);
            this.txtLotId.TabIndex = 0;
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
            this.cboStepId.Size = new System.Drawing.Size(169, 24);
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
            this.cboStage.Size = new System.Drawing.Size(169, 24);
            this.cboStage.Sorted = true;
            this.cboStage.TabIndex = 4;
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
            this.cboRoute.Size = new System.Drawing.Size(169, 24);
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
            this.cboProduct.Size = new System.Drawing.Size(169, 24);
            this.cboProduct.Sorted = true;
            this.cboProduct.TabIndex = 2;
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
            this.cboOrderId.Size = new System.Drawing.Size(169, 24);
            this.cboOrderId.Sorted = true;
            this.cboOrderId.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "queryCondition";
            this.label1.Text = "queryCondition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwLots);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(520, 465);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 3;
            // 
            // lvwLots
            // 
            this.lvwLots.allowUserFilter = true;
            this.lvwLots.allowUserSorting = true;
            this.lvwLots.autoSizeColumn = true;
            this.lvwLots.careModifyDate = false;
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
            this.lvwLots.Size = new System.Drawing.Size(520, 220);
            this.lvwLots.TabIndex = 2;
            this.lvwLots.UseCompatibleStateImageBehavior = false;
            this.lvwLots.View = System.Windows.Forms.View.Details;
            this.lvwLots.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwLots_MESItemSelectionChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lvwHoldReason);
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.reasonCode1);
            this.splitContainer3.Panel2.Controls.Add(this.label9);
            this.splitContainer3.Size = new System.Drawing.Size(520, 241);
            this.splitContainer3.SplitterDistance = 101;
            this.splitContainer3.TabIndex = 0;
            // 
            // lvwHoldReason
            // 
            this.lvwHoldReason.allowUserFilter = true;
            this.lvwHoldReason.allowUserSorting = true;
            this.lvwHoldReason.autoSizeColumn = true;
            this.lvwHoldReason.careModifyDate = false;
            this.lvwHoldReason.CheckBoxes = true;
            this.lvwHoldReason.columnHide = null;
            this.lvwHoldReason.columnNames = new string[] {
        "holdReason",
        "description",
        "holdUser",
        "holdDate",
        "ownerDept"};
            this.lvwHoldReason.columnTags = new string[] {
        "holdReason",
        "description",
        "holdUser",
        "holdDate",
        "ownerDept"};
            this.lvwHoldReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwHoldReason.FullRowSelect = true;
            this.lvwHoldReason.HideSelection = false;
            this.lvwHoldReason.imageKeyColumn = "";
            this.lvwHoldReason.keyPressSearch = false;
            this.lvwHoldReason.keyPressSearchColumn = "";
            this.lvwHoldReason.Location = new System.Drawing.Point(0, 22);
            this.lvwHoldReason.makesureNewItemVisible = false;
            this.lvwHoldReason.MultiSelect = false;
            this.lvwHoldReason.Name = "lvwHoldReason";
            this.lvwHoldReason.OwnerDraw = true;
            this.lvwHoldReason.ShowItemTipSecond = ((byte)(3));
            this.lvwHoldReason.Size = new System.Drawing.Size(520, 79);
            this.lvwHoldReason.TabIndex = 7;
            this.lvwHoldReason.UseCompatibleStateImageBehavior = false;
            this.lvwHoldReason.View = System.Windows.Forms.View.Details;
            this.lvwHoldReason.MESItemCheckChanged += new idv.mesCore.Controls.MESListView.delMESItemCheckChanged(this.lvwHoldReason_MESItemCheckChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(520, 22);
            this.label10.TabIndex = 5;
            this.label10.Tag = "holdReason";
            this.label10.Text = "holdReason";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reasonCode1
            // 
            this.reasonCode1.comments = "";
            this.reasonCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonCode1.Location = new System.Drawing.Point(0, 22);
            this.reasonCode1.maxDropDownItemCount = 20;
            this.reasonCode1.Name = "reasonCode1";
            this.reasonCode1.required = true;
            this.reasonCode1.showCommentOnly = false;
            this.reasonCode1.Size = new System.Drawing.Size(520, 114);
            this.reasonCode1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(520, 22);
            this.label9.TabIndex = 4;
            this.label9.Tag = "releaseReason";
            this.label9.Text = "releaseReason";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(366, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(443, 0);
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
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 500);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(769, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(769, 525);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "ReleaseLot";
            this.Text = "ReleaseLot";
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
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
        private idv.mesCore.Controls.MESListView lvwLots;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnOK;
        private mesRelease.Controls.ReasonCode reasonCode1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private idv.mesCore.Controls.MESListView lvwHoldReason;

    }
}