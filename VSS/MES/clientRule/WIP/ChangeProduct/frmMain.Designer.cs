namespace ClientRule.ChangeProduct
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboEquipmentId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEquipmentType = new System.Windows.Forms.ComboBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lvwStatus = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.cboStage = new System.Windows.Forms.ComboBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lblRoute = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnUnCheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.lvwLots = new idv.mesCore.Controls.MESListView();
            this.reasonCode1 = new mesRelease.Controls.ReasonCode();
            this.lblReasonCode = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewStep = new System.Windows.Forms.Label();
            this.lblNewRoute = new System.Windows.Forms.Label();
            this.cboNewRoute = new System.Windows.Forms.ComboBox();
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.cboNewProduct = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboNewStep = new mesRelease.Controls.routeCombo();
            this.lblNewSpec = new System.Windows.Forms.Label();
            this.cboNewSpec = new System.Windows.Forms.ComboBox();
            this.lblRouteVersion = new System.Windows.Forms.Label();
            this.lblStepVersion = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(848, 526);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(156, 492);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 31);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 125);
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
            this.tableLayoutPanel2.Controls.Add(this.cboEquipmentId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboEquipmentType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClearAll, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(241, 100);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // cboEquipmentId
            // 
            this.cboEquipmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipmentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEquipmentId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboEquipmentId.FormattingEnabled = true;
            this.cboEquipmentId.Location = new System.Drawing.Point(121, 38);
            this.cboEquipmentId.MaxDropDownItems = 20;
            this.cboEquipmentId.Name = "cboEquipmentId";
            this.cboEquipmentId.Size = new System.Drawing.Size(117, 24);
            this.cboEquipmentId.Sorted = true;
            this.cboEquipmentId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(19, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 0;
            this.label7.Tag = "equipmentId";
            this.label7.Text = "equipmentId";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 30);
            this.label8.TabIndex = 6;
            this.label8.Tag = "equipmentType";
            this.label8.Text = "equipmentType";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEquipmentType
            // 
            this.cboEquipmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipmentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEquipmentType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboEquipmentType.FormattingEnabled = true;
            this.cboEquipmentType.Location = new System.Drawing.Point(121, 8);
            this.cboEquipmentType.MaxDropDownItems = 20;
            this.cboEquipmentType.Name = "cboEquipmentType";
            this.cboEquipmentType.Size = new System.Drawing.Size(117, 24);
            this.cboEquipmentType.Sorted = true;
            this.cboEquipmentType.TabIndex = 7;
            this.cboEquipmentType.SelectedIndexChanged += new System.EventHandler(this.cboEquipmentType_SelectedIndexChanged);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClearAll.Location = new System.Drawing.Point(156, 68);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(82, 29);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Tag = "clearAll";
            this.btnClearAll.Text = "clearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.lvwStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "status";
            this.groupBox1.Text = "status";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(175, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Tag = "clearAll";
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectAll.Location = new System.Drawing.Point(175, 17);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(68, 29);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Tag = "selectAll";
            this.btnSelectAll.Text = "selectAll";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lvwStatus
            // 
            this.lvwStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwStatus.CheckBoxes = true;
            this.lvwStatus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwStatus.Location = new System.Drawing.Point(6, 16);
            this.lvwStatus.Name = "lvwStatus";
            this.lvwStatus.Size = new System.Drawing.Size(163, 122);
            this.lvwStatus.TabIndex = 0;
            this.lvwStatus.UseCompatibleStateImageBehavior = false;
            this.lvwStatus.View = System.Windows.Forms.View.List;
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
            this.tableLayoutPanel1.Controls.Add(this.lblRoute, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboProduct, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboOrderId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLot, 0, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 192);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotId.Location = new System.Drawing.Point(73, 8);
            this.txtLotId.MaxLength = 40;
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(171, 26);
            this.txtLotId.TabIndex = 9;
            // 
            // cboStepId
            // 
            this.cboStepId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(73, 160);
            this.cboStepId.MaxDropDownItems = 20;
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(171, 24);
            this.cboStepId.Sorted = true;
            this.cboStepId.TabIndex = 5;
            // 
            // lblStep
            // 
            this.lblStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(27, 164);
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
            this.cboStage.Location = new System.Drawing.Point(73, 130);
            this.cboStage.MaxDropDownItems = 20;
            this.cboStage.Name = "cboStage";
            this.cboStage.Size = new System.Drawing.Size(171, 24);
            this.cboStage.Sorted = true;
            this.cboStage.TabIndex = 9;
            // 
            // lblStage
            // 
            this.lblStage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(19, 134);
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
            this.cboRoute.Location = new System.Drawing.Point(73, 100);
            this.cboRoute.MaxDropDownItems = 20;
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(171, 24);
            this.cboRoute.Sorted = true;
            this.cboRoute.TabIndex = 3;
            // 
            // lblRoute
            // 
            this.lblRoute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(19, 104);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(48, 16);
            this.lblRoute.TabIndex = 2;
            this.lblRoute.Tag = "route";
            this.lblRoute.Text = "route";
            this.lblRoute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(73, 70);
            this.cboProduct.MaxDropDownItems = 20;
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(171, 24);
            this.cboProduct.Sorted = true;
            this.cboProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
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
            this.cboOrderId.Size = new System.Drawing.Size(171, 24);
            this.cboOrderId.Sorted = true;
            this.cboOrderId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Tag = "orderId";
            this.label4.Text = "orderId";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLot
            // 
            this.lblLot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLot.AutoSize = true;
            this.lblLot.Location = new System.Drawing.Point(19, 13);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(48, 16);
            this.lblLot.TabIndex = 10;
            this.lblLot.Tag = "lotId";
            this.lblLot.Text = "lotId";
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 22);
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
            this.splitContainer2.Panel1.Controls.Add(this.btnUnCheckAll);
            this.splitContainer2.Panel1.Controls.Add(this.btnCheckAll);
            this.splitContainer2.Panel1.Controls.Add(this.lvwLots);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.reasonCode1);
            this.splitContainer2.Panel2.Controls.Add(this.lblReasonCode);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(597, 491);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 3;
            // 
            // btnUnCheckAll
            // 
            this.btnUnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnCheckAll.Location = new System.Drawing.Point(490, 268);
            this.btnUnCheckAll.Name = "btnUnCheckAll";
            this.btnUnCheckAll.Size = new System.Drawing.Size(104, 28);
            this.btnUnCheckAll.TabIndex = 4;
            this.btnUnCheckAll.Tag = "clearSelect";
            this.btnUnCheckAll.Text = "ClearSelect";
            this.btnUnCheckAll.UseVisualStyleBackColor = true;
            this.btnUnCheckAll.Click += new System.EventHandler(this.btnUnCheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAll.Location = new System.Drawing.Point(369, 268);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(104, 28);
            this.btnCheckAll.TabIndex = 3;
            this.btnCheckAll.Tag = "selectAll";
            this.btnCheckAll.Text = "SelectAll";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // lvwLots
            // 
            this.lvwLots.allowUserFilter = true;
            this.lvwLots.allowUserSorting = true;
            this.lvwLots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLots.autoSizeColumn = true;
            this.lvwLots.careModifyDate = false;
            this.lvwLots.CheckBoxes = true;
            this.lvwLots.columnHide = null;
            this.lvwLots.columnNames = null;
            this.lvwLots.columnTags = null;
            this.lvwLots.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.lvwLots.Size = new System.Drawing.Size(597, 265);
            this.lvwLots.TabIndex = 2;
            this.lvwLots.UseCompatibleStateImageBehavior = false;
            this.lvwLots.View = System.Windows.Forms.View.Details;
            // 
            // reasonCode1
            // 
            this.reasonCode1.comments = "";
            this.reasonCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonCode1.Location = new System.Drawing.Point(304, 22);
            this.reasonCode1.maxDropDownItemCount = 20;
            this.reasonCode1.Name = "reasonCode1";
            this.reasonCode1.required = true;
            this.reasonCode1.showCommentOnly = false;
            this.reasonCode1.Size = new System.Drawing.Size(293, 165);
            this.reasonCode1.TabIndex = 8;
            // 
            // lblReasonCode
            // 
            this.lblReasonCode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblReasonCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReasonCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReasonCode.ForeColor = System.Drawing.SystemColors.Window;
            this.lblReasonCode.Location = new System.Drawing.Point(304, 0);
            this.lblReasonCode.Name = "lblReasonCode";
            this.lblReasonCode.Size = new System.Drawing.Size(293, 22);
            this.lblReasonCode.TabIndex = 7;
            this.lblReasonCode.Tag = "reasonCode";
            this.lblReasonCode.Text = "reasonCode";
            this.lblReasonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Controls.Add(this.lblNewStep, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblNewRoute, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cboNewRoute, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNewProduct, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboNewProduct, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboNewStep, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblNewSpec, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cboNewSpec, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblRouteVersion, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblStepVersion, 2, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(304, 187);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lblNewStep
            // 
            this.lblNewStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewStep.AutoSize = true;
            this.lblNewStep.Location = new System.Drawing.Point(27, 90);
            this.lblNewStep.Name = "lblNewStep";
            this.lblNewStep.Size = new System.Drawing.Size(40, 16);
            this.lblNewStep.TabIndex = 4;
            this.lblNewStep.Tag = "step";
            this.lblNewStep.Text = "step";
            this.lblNewStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewRoute
            // 
            this.lblNewRoute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewRoute.AutoSize = true;
            this.lblNewRoute.Location = new System.Drawing.Point(19, 59);
            this.lblNewRoute.Name = "lblNewRoute";
            this.lblNewRoute.Size = new System.Drawing.Size(48, 16);
            this.lblNewRoute.TabIndex = 2;
            this.lblNewRoute.Tag = "route";
            this.lblNewRoute.Text = "route";
            this.lblNewRoute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNewRoute
            // 
            this.cboNewRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNewRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboNewRoute.BackColor = System.Drawing.SystemColors.Info;
            this.cboNewRoute.FormattingEnabled = true;
            this.cboNewRoute.Location = new System.Drawing.Point(73, 55);
            this.cboNewRoute.MaxDropDownItems = 20;
            this.cboNewRoute.Name = "cboNewRoute";
            this.cboNewRoute.Size = new System.Drawing.Size(196, 24);
            this.cboNewRoute.Sorted = true;
            this.cboNewRoute.TabIndex = 3;
            this.cboNewRoute.SelectedIndexChanged += new System.EventHandler(this.cboNewRoute_SelectedIndexChanged);
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Location = new System.Drawing.Point(3, 29);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(64, 16);
            this.lblNewProduct.TabIndex = 0;
            this.lblNewProduct.Tag = "product";
            this.lblNewProduct.Text = "product";
            this.lblNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNewProduct
            // 
            this.cboNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNewProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboNewProduct.BackColor = System.Drawing.SystemColors.Info;
            this.cboNewProduct.FormattingEnabled = true;
            this.cboNewProduct.Location = new System.Drawing.Point(73, 25);
            this.cboNewProduct.MaxDropDownItems = 20;
            this.cboNewProduct.Name = "cboNewProduct";
            this.cboNewProduct.Size = new System.Drawing.Size(196, 24);
            this.cboNewProduct.Sorted = true;
            this.cboNewProduct.TabIndex = 1;
            this.cboNewProduct.SelectedIndexChanged += new System.EventHandler(this.cboNewProduct_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel3.SetColumnSpan(this.label14, 3);
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(298, 22);
            this.label14.TabIndex = 25;
            this.label14.Tag = "inputData";
            this.label14.Text = "inputData";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboNewStep
            // 
            this.cboNewStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNewStep.AutoSize = true;
            this.cboNewStep.complexMode = false;
            this.cboNewStep.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboNewStep.Location = new System.Drawing.Point(74, 86);
            this.cboNewStep.Margin = new System.Windows.Forms.Padding(4);
            this.cboNewStep.Name = "cboNewStep";
            this.cboNewStep.required = true;
            this.cboNewStep.selectedStep = null;
            this.cboNewStep.showHandle = false;
            this.cboNewStep.Size = new System.Drawing.Size(194, 24);
            this.cboNewStep.TabIndex = 26;
            this.cboNewStep.MESStepSelectionChanged += new mesRelease.Controls.routeCombo.MESStepSelectionChangedHandler(this.cboNewStep_MESStepSelectionChanged);
            // 
            // lblNewSpec
            // 
            this.lblNewSpec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNewSpec.AutoSize = true;
            this.lblNewSpec.Location = new System.Drawing.Point(11, 119);
            this.lblNewSpec.Name = "lblNewSpec";
            this.lblNewSpec.Size = new System.Drawing.Size(56, 16);
            this.lblNewSpec.TabIndex = 23;
            this.lblNewSpec.Tag = "specId";
            this.lblNewSpec.Text = "specId";
            this.lblNewSpec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNewSpec
            // 
            this.cboNewSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNewSpec.BackColor = System.Drawing.SystemColors.Info;
            this.cboNewSpec.FormattingEnabled = true;
            this.cboNewSpec.Location = new System.Drawing.Point(73, 117);
            this.cboNewSpec.Name = "cboNewSpec";
            this.cboNewSpec.Size = new System.Drawing.Size(196, 24);
            this.cboNewSpec.Sorted = true;
            this.cboNewSpec.TabIndex = 24;
            // 
            // lblRouteVersion
            // 
            this.lblRouteVersion.AutoSize = true;
            this.lblRouteVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRouteVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRouteVersion.Location = new System.Drawing.Point(272, 55);
            this.lblRouteVersion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblRouteVersion.Name = "lblRouteVersion";
            this.lblRouteVersion.Size = new System.Drawing.Size(29, 24);
            this.lblRouteVersion.TabIndex = 27;
            this.lblRouteVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStepVersion
            // 
            this.lblStepVersion.AutoSize = true;
            this.lblStepVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStepVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStepVersion.Location = new System.Drawing.Point(272, 85);
            this.lblStepVersion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblStepVersion.Name = "lblStepVersion";
            this.lblStepVersion.Size = new System.Drawing.Size(29, 26);
            this.lblStepVersion.TabIndex = 28;
            this.lblStepVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(443, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(520, 0);
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
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 526);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(848, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(848, 551);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "ChangeProduct";
            this.Text = "ChangeProduct";
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
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.ComboBox cboStage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cboEquipmentId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEquipmentType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblLot;
        private idv.mesCore.Controls.MESListView lvwLots;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnUnCheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private mesRelease.Controls.ReasonCode reasonCode1;
        private System.Windows.Forms.Label lblReasonCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNewProduct;
        private System.Windows.Forms.ComboBox cboNewProduct;
        private System.Windows.Forms.Label lblNewRoute;
        private System.Windows.Forms.ComboBox cboNewRoute;
        private System.Windows.Forms.Label lblNewStep;
        private System.Windows.Forms.Label lblNewSpec;
        private System.Windows.Forms.ComboBox cboNewSpec;
        private System.Windows.Forms.Label label14;
        private mesRelease.Controls.routeCombo cboNewStep;
        private System.Windows.Forms.Label lblRouteVersion;
        private System.Windows.Forms.Label lblStepVersion;

    }
}