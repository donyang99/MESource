namespace ClientRule.EqSetup
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
            this.splSetupInfo = new System.Windows.Forms.SplitContainer();
            this.lvwCurSetupMaterial = new idv.mesCore.Controls.MESListView();
            this.tblModifyQty = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCurMaterial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModifyQty = new System.Windows.Forms.TextBox();
            this.btnModifyCurQty = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurRecipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCurToolingInfo = new System.Windows.Forms.Panel();
            this.lvwCurTooling = new idv.mesCore.Controls.MESListView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSetupMaterial = new System.Windows.Forms.Panel();
            this.lvwSetupMaterial = new idv.mesCore.Controls.MESListView();
            this.pnlSetupMatButton = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblMaterialInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaterialType = new System.Windows.Forms.TextBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtMaterialQty = new System.Windows.Forms.TextBox();
            this.lblMaterialQty = new System.Windows.Forms.Label();
            this.txtMaterialLotId = new System.Windows.Forms.TextBox();
            this.lblMaterialLotId = new System.Windows.Forms.Label();
            this.lblMaterialPartNo = new System.Windows.Forms.Label();
            this.txtMaterialPartNo = new System.Windows.Forms.TextBox();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInputRecipe = new System.Windows.Forms.Label();
            this.txtInputRecipe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTarget = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.lblStepId = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splSetupInfo)).BeginInit();
            this.splSetupInfo.Panel1.SuspendLayout();
            this.splSetupInfo.Panel2.SuspendLayout();
            this.splSetupInfo.SuspendLayout();
            this.tblModifyQty.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCurToolingInfo.SuspendLayout();
            this.pnlSetupMaterial.SuspendLayout();
            this.pnlSetupMatButton.SuspendLayout();
            this.tblMaterialInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlSetupToolingInfo.SuspendLayout();
            this.tblToolingInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTarget.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splSetupInfo);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTarget);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 765);
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
            this.equipmentInformation1.Margin = new System.Windows.Forms.Padding(4);
            this.equipmentInformation1.Name = "equipmentInformation1";
            this.equipmentInformation1.ShowPopupMessage = false;
            this.equipmentInformation1.Size = new System.Drawing.Size(213, 743);
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
            // splSetupInfo
            // 
            this.splSetupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splSetupInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splSetupInfo.Location = new System.Drawing.Point(0, 82);
            this.splSetupInfo.Name = "splSetupInfo";
            // 
            // splSetupInfo.Panel1
            // 
            this.splSetupInfo.Panel1.Controls.Add(this.lvwCurSetupMaterial);
            this.splSetupInfo.Panel1.Controls.Add(this.tblModifyQty);
            this.splSetupInfo.Panel1.Controls.Add(this.groupBox1);
            this.splSetupInfo.Panel1.Controls.Add(this.label2);
            this.splSetupInfo.Panel1.Controls.Add(this.pnlCurToolingInfo);
            // 
            // splSetupInfo.Panel2
            // 
            this.splSetupInfo.Panel2.Controls.Add(this.pnlSetupMaterial);
            this.splSetupInfo.Panel2.Controls.Add(this.tblMaterialInfo);
            this.splSetupInfo.Panel2.Controls.Add(this.groupBox2);
            this.splSetupInfo.Panel2.Controls.Add(this.label5);
            this.splSetupInfo.Panel2.Controls.Add(this.pnlSetupToolingInfo);
            this.splSetupInfo.Size = new System.Drawing.Size(967, 648);
            this.splSetupInfo.SplitterDistance = 425;
            this.splSetupInfo.TabIndex = 0;
            // 
            // lvwCurSetupMaterial
            // 
            this.lvwCurSetupMaterial.allowUserFilter = false;
            this.lvwCurSetupMaterial.allowUserSorting = false;
            this.lvwCurSetupMaterial.autoSizeColumn = false;
            this.lvwCurSetupMaterial.careModifyDate = false;
            this.lvwCurSetupMaterial.columnHide = null;
            this.lvwCurSetupMaterial.columnNames = null;
            this.lvwCurSetupMaterial.columnTags = null;
            this.lvwCurSetupMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCurSetupMaterial.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwCurSetupMaterial.FullRowSelect = true;
            this.lvwCurSetupMaterial.HideSelection = false;
            this.lvwCurSetupMaterial.imageKeyColumn = "";
            this.lvwCurSetupMaterial.keyPressSearch = false;
            this.lvwCurSetupMaterial.keyPressSearchColumn = "";
            this.lvwCurSetupMaterial.Location = new System.Drawing.Point(0, 126);
            this.lvwCurSetupMaterial.makesureNewItemVisible = true;
            this.lvwCurSetupMaterial.MultiSelect = false;
            this.lvwCurSetupMaterial.Name = "lvwCurSetupMaterial";
            this.lvwCurSetupMaterial.OwnerDraw = true;
            this.lvwCurSetupMaterial.ShowItemTipSecond = ((byte)(3));
            this.lvwCurSetupMaterial.showRowNum = false;
            this.lvwCurSetupMaterial.Size = new System.Drawing.Size(425, 318);
            this.lvwCurSetupMaterial.TabIndex = 10;
            this.lvwCurSetupMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwCurSetupMaterial.View = System.Windows.Forms.View.Details;
            this.lvwCurSetupMaterial.wndProcIgnoreError = false;
            this.lvwCurSetupMaterial.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwCurSetupMaterial_MESItemSelectionChanged);
            // 
            // tblModifyQty
            // 
            this.tblModifyQty.ColumnCount = 4;
            this.tblModifyQty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblModifyQty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblModifyQty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblModifyQty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblModifyQty.Controls.Add(this.btnDeleteCurMaterial, 3, 1);
            this.tblModifyQty.Controls.Add(this.label4, 0, 1);
            this.tblModifyQty.Controls.Add(this.txtModifyQty, 1, 1);
            this.tblModifyQty.Controls.Add(this.btnModifyCurQty, 2, 1);
            this.tblModifyQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblModifyQty.Location = new System.Drawing.Point(0, 76);
            this.tblModifyQty.Name = "tblModifyQty";
            this.tblModifyQty.RowCount = 3;
            this.tblModifyQty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblModifyQty.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblModifyQty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblModifyQty.Size = new System.Drawing.Size(425, 50);
            this.tblModifyQty.TabIndex = 7;
            // 
            // btnDeleteCurMaterial
            // 
            this.btnDeleteCurMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCurMaterial.Location = new System.Drawing.Point(240, 11);
            this.btnDeleteCurMaterial.Name = "btnDeleteCurMaterial";
            this.btnDeleteCurMaterial.Size = new System.Drawing.Size(68, 26);
            this.btnDeleteCurMaterial.TabIndex = 11;
            this.btnDeleteCurMaterial.TabStop = false;
            this.btnDeleteCurMaterial.Tag = "delete";
            this.btnDeleteCurMaterial.Text = "delete";
            this.btnDeleteCurMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteCurMaterial.Click += new System.EventHandler(this.btnDeleteCurMaterial_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Tag = "quantity";
            this.label4.Text = "quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModifyQty
            // 
            this.txtModifyQty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtModifyQty.Location = new System.Drawing.Point(81, 11);
            this.txtModifyQty.MaxLength = 6;
            this.txtModifyQty.Name = "txtModifyQty";
            this.txtModifyQty.Size = new System.Drawing.Size(79, 26);
            this.txtModifyQty.TabIndex = 98;
            this.txtModifyQty.TabStop = false;
            this.txtModifyQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            // 
            // btnModifyCurQty
            // 
            this.btnModifyCurQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyCurQty.Location = new System.Drawing.Point(166, 11);
            this.btnModifyCurQty.Name = "btnModifyCurQty";
            this.btnModifyCurQty.Size = new System.Drawing.Size(68, 26);
            this.btnModifyCurQty.TabIndex = 10;
            this.btnModifyCurQty.TabStop = false;
            this.btnModifyCurQty.Tag = "modify";
            this.btnModifyCurQty.Text = "modify";
            this.btnModifyCurQty.UseVisualStyleBackColor = true;
            this.btnModifyCurQty.Click += new System.EventHandler(this.btnModifyCurQty_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(425, 54);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCurRecipe, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 32);
            this.tableLayoutPanel2.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Tag = "recipe";
            this.label3.Text = "recipe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurRecipe
            // 
            this.txtCurRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurRecipe.Location = new System.Drawing.Point(65, 3);
            this.txtCurRecipe.Name = "txtCurRecipe";
            this.txtCurRecipe.ReadOnly = true;
            this.txtCurRecipe.Size = new System.Drawing.Size(240, 26);
            this.txtCurRecipe.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 22);
            this.label2.TabIndex = 5;
            this.label2.Tag = "currentSetupInfo";
            this.label2.Text = "currentSetupInfo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCurToolingInfo
            // 
            this.pnlCurToolingInfo.Controls.Add(this.lvwCurTooling);
            this.pnlCurToolingInfo.Controls.Add(this.label7);
            this.pnlCurToolingInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCurToolingInfo.Location = new System.Drawing.Point(0, 444);
            this.pnlCurToolingInfo.Name = "pnlCurToolingInfo";
            this.pnlCurToolingInfo.Size = new System.Drawing.Size(425, 204);
            this.pnlCurToolingInfo.TabIndex = 11;
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
            this.lvwCurTooling.showRowNum = false;
            this.lvwCurTooling.Size = new System.Drawing.Size(425, 182);
            this.lvwCurTooling.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwCurTooling.TabIndex = 11;
            this.lvwCurTooling.UseCompatibleStateImageBehavior = false;
            this.lvwCurTooling.View = System.Windows.Forms.View.Details;
            this.lvwCurTooling.wndProcIgnoreError = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 22);
            this.label7.TabIndex = 6;
            this.label7.Tag = "currentToolingInfo";
            this.label7.Text = "currentToolingInfo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSetupMaterial
            // 
            this.pnlSetupMaterial.Controls.Add(this.lvwSetupMaterial);
            this.pnlSetupMaterial.Controls.Add(this.pnlSetupMatButton);
            this.pnlSetupMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSetupMaterial.Location = new System.Drawing.Point(0, 126);
            this.pnlSetupMaterial.Name = "pnlSetupMaterial";
            this.pnlSetupMaterial.Size = new System.Drawing.Size(538, 318);
            this.pnlSetupMaterial.TabIndex = 17;
            // 
            // lvwSetupMaterial
            // 
            this.lvwSetupMaterial.allowUserFilter = false;
            this.lvwSetupMaterial.allowUserSorting = false;
            this.lvwSetupMaterial.autoSizeColumn = false;
            this.lvwSetupMaterial.careModifyDate = false;
            this.lvwSetupMaterial.columnHide = null;
            this.lvwSetupMaterial.columnNames = null;
            this.lvwSetupMaterial.columnTags = null;
            this.lvwSetupMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSetupMaterial.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSetupMaterial.FullRowSelect = true;
            this.lvwSetupMaterial.HideSelection = false;
            this.lvwSetupMaterial.imageKeyColumn = "";
            this.lvwSetupMaterial.keyPressSearch = false;
            this.lvwSetupMaterial.keyPressSearchColumn = "";
            this.lvwSetupMaterial.Location = new System.Drawing.Point(0, 0);
            this.lvwSetupMaterial.makesureNewItemVisible = true;
            this.lvwSetupMaterial.MultiSelect = false;
            this.lvwSetupMaterial.Name = "lvwSetupMaterial";
            this.lvwSetupMaterial.OwnerDraw = true;
            this.lvwSetupMaterial.ShowItemTipSecond = ((byte)(3));
            this.lvwSetupMaterial.showRowNum = false;
            this.lvwSetupMaterial.Size = new System.Drawing.Size(488, 318);
            this.lvwSetupMaterial.TabIndex = 15;
            this.lvwSetupMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwSetupMaterial.View = System.Windows.Forms.View.Details;
            this.lvwSetupMaterial.wndProcIgnoreError = false;
            // 
            // pnlSetupMatButton
            // 
            this.pnlSetupMatButton.Controls.Add(this.btnDelete);
            this.pnlSetupMatButton.Controls.Add(this.btnAdd);
            this.pnlSetupMatButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSetupMatButton.Location = new System.Drawing.Point(488, 0);
            this.pnlSetupMatButton.Name = "pnlSetupMatButton";
            this.pnlSetupMatButton.Size = new System.Drawing.Size(50, 318);
            this.pnlSetupMatButton.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(0, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Tag = "delete";
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Tag = "add";
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblMaterialInfo
            // 
            this.tblMaterialInfo.ColumnCount = 5;
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaterialInfo.Controls.Add(this.txtMaterialType, 1, 1);
            this.tblMaterialInfo.Controls.Add(this.cboPosition, 0, 1);
            this.tblMaterialInfo.Controls.Add(this.lblPosition, 0, 0);
            this.tblMaterialInfo.Controls.Add(this.txtMaterialQty, 4, 1);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialQty, 4, 0);
            this.tblMaterialInfo.Controls.Add(this.txtMaterialLotId, 3, 1);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialLotId, 3, 0);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialPartNo, 2, 0);
            this.tblMaterialInfo.Controls.Add(this.txtMaterialPartNo, 2, 1);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialType, 1, 0);
            this.tblMaterialInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMaterialInfo.Location = new System.Drawing.Point(0, 76);
            this.tblMaterialInfo.Name = "tblMaterialInfo";
            this.tblMaterialInfo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tblMaterialInfo.RowCount = 3;
            this.tblMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMaterialInfo.Size = new System.Drawing.Size(538, 50);
            this.tblMaterialInfo.TabIndex = 9;
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialType.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialType.Enabled = false;
            this.txtMaterialType.Location = new System.Drawing.Point(98, 19);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.Size = new System.Drawing.Size(115, 26);
            this.txtMaterialType.TabIndex = 11;
            // 
            // cboPosition
            // 
            this.cboPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPosition.BackColor = System.Drawing.SystemColors.Info;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboPosition.Location = new System.Drawing.Point(6, 20);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.cboPosition.MaxDropDownItems = 20;
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(86, 24);
            this.cboPosition.TabIndex = 2;
            this.cboPosition.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(6, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 16);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Tag = "position";
            this.lblPosition.Text = "position";
            // 
            // txtMaterialQty
            // 
            this.txtMaterialQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialQty.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaterialQty.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMaterialQty.Location = new System.Drawing.Point(461, 19);
            this.txtMaterialQty.MaxLength = 6;
            this.txtMaterialQty.Name = "txtMaterialQty";
            this.txtMaterialQty.Size = new System.Drawing.Size(74, 26);
            this.txtMaterialQty.TabIndex = 6;
            this.txtMaterialQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtMaterialQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaterialQty_KeyUp);
            // 
            // lblMaterialQty
            // 
            this.lblMaterialQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialQty.AutoSize = true;
            this.lblMaterialQty.Location = new System.Drawing.Point(461, 0);
            this.lblMaterialQty.Name = "lblMaterialQty";
            this.lblMaterialQty.Size = new System.Drawing.Size(72, 16);
            this.lblMaterialQty.TabIndex = 4;
            this.lblMaterialQty.Tag = "quantity";
            this.lblMaterialQty.Text = "quantity";
            // 
            // txtMaterialLotId
            // 
            this.txtMaterialLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialLotId.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaterialLotId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMaterialLotId.Location = new System.Drawing.Point(340, 19);
            this.txtMaterialLotId.MaxLength = 40;
            this.txtMaterialLotId.Name = "txtMaterialLotId";
            this.txtMaterialLotId.Size = new System.Drawing.Size(115, 26);
            this.txtMaterialLotId.TabIndex = 5;
            this.txtMaterialLotId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaterialLotId_KeyUp);
            // 
            // lblMaterialLotId
            // 
            this.lblMaterialLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialLotId.AutoSize = true;
            this.lblMaterialLotId.Location = new System.Drawing.Point(340, 0);
            this.lblMaterialLotId.Name = "lblMaterialLotId";
            this.lblMaterialLotId.Size = new System.Drawing.Size(72, 16);
            this.lblMaterialLotId.TabIndex = 2;
            this.lblMaterialLotId.Tag = "materialLotId";
            this.lblMaterialLotId.Text = "matLotId";
            // 
            // lblMaterialPartNo
            // 
            this.lblMaterialPartNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialPartNo.AutoSize = true;
            this.lblMaterialPartNo.Location = new System.Drawing.Point(219, 0);
            this.lblMaterialPartNo.Name = "lblMaterialPartNo";
            this.lblMaterialPartNo.Size = new System.Drawing.Size(80, 16);
            this.lblMaterialPartNo.TabIndex = 1;
            this.lblMaterialPartNo.Tag = "materialPartNo";
            this.lblMaterialPartNo.Text = "matPartNo";
            // 
            // txtMaterialPartNo
            // 
            this.txtMaterialPartNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialPartNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaterialPartNo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMaterialPartNo.Location = new System.Drawing.Point(219, 19);
            this.txtMaterialPartNo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtMaterialPartNo.MaxLength = 40;
            this.txtMaterialPartNo.Name = "txtMaterialPartNo";
            this.txtMaterialPartNo.Size = new System.Drawing.Size(118, 26);
            this.txtMaterialPartNo.TabIndex = 4;
            this.txtMaterialPartNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaterialPartNo_KeyUp);
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Location = new System.Drawing.Point(98, 0);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(104, 16);
            this.lblMaterialType.TabIndex = 0;
            this.lblMaterialType.Tag = "materialType";
            this.lblMaterialType.Text = "materialType";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(538, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblInputRecipe, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtInputRecipe, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(532, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblInputRecipe
            // 
            this.lblInputRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInputRecipe.AutoSize = true;
            this.lblInputRecipe.Location = new System.Drawing.Point(3, 8);
            this.lblInputRecipe.Name = "lblInputRecipe";
            this.lblInputRecipe.Size = new System.Drawing.Size(56, 16);
            this.lblInputRecipe.TabIndex = 0;
            this.lblInputRecipe.Tag = "recipe";
            this.lblInputRecipe.Text = "recipe";
            this.lblInputRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInputRecipe
            // 
            this.txtInputRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInputRecipe.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtInputRecipe.Location = new System.Drawing.Point(65, 3);
            this.txtInputRecipe.MaxLength = 40;
            this.txtInputRecipe.Name = "txtInputRecipe";
            this.txtInputRecipe.Size = new System.Drawing.Size(248, 26);
            this.txtInputRecipe.TabIndex = 1;
            this.txtInputRecipe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInputRecipe_KeyUp);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(538, 22);
            this.label5.TabIndex = 6;
            this.label5.Tag = "inputSetupInfo";
            this.label5.Text = "inputSetupInfo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSetupToolingInfo
            // 
            this.pnlSetupToolingInfo.Controls.Add(this.lvwSetupTooling);
            this.pnlSetupToolingInfo.Controls.Add(this.tblToolingInfo);
            this.pnlSetupToolingInfo.Controls.Add(this.label8);
            this.pnlSetupToolingInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSetupToolingInfo.Location = new System.Drawing.Point(0, 444);
            this.pnlSetupToolingInfo.Name = "pnlSetupToolingInfo";
            this.pnlSetupToolingInfo.Size = new System.Drawing.Size(538, 204);
            this.pnlSetupToolingInfo.TabIndex = 12;
            // 
            // lvwSetupTooling
            // 
            this.lvwSetupTooling.allowUserFilter = false;
            this.lvwSetupTooling.allowUserSorting = false;
            this.lvwSetupTooling.autoSizeColumn = false;
            this.lvwSetupTooling.careModifyDate = false;
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
            this.lvwSetupTooling.showRowNum = false;
            this.lvwSetupTooling.Size = new System.Drawing.Size(538, 132);
            this.lvwSetupTooling.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwSetupTooling.TabIndex = 12;
            this.lvwSetupTooling.UseCompatibleStateImageBehavior = false;
            this.lvwSetupTooling.View = System.Windows.Forms.View.Details;
            this.lvwSetupTooling.wndProcIgnoreError = false;
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
            this.tblToolingInfo.Size = new System.Drawing.Size(538, 50);
            this.tblToolingInfo.TabIndex = 13;
            // 
            // btnDelTooling
            // 
            this.btnDelTooling.Location = new System.Drawing.Point(485, 19);
            this.btnDelTooling.Name = "btnDelTooling";
            this.btnDelTooling.Size = new System.Drawing.Size(50, 30);
            this.btnDelTooling.TabIndex = 11;
            this.btnDelTooling.Tag = "delete";
            this.btnDelTooling.Text = "delete";
            this.btnDelTooling.UseVisualStyleBackColor = true;
            this.btnDelTooling.Click += new System.EventHandler(this.btnDelTooling_Click);
            // 
            // btnAddTooling
            // 
            this.btnAddTooling.Location = new System.Drawing.Point(429, 19);
            this.btnAddTooling.Name = "btnAddTooling";
            this.btnAddTooling.Size = new System.Drawing.Size(50, 30);
            this.btnAddTooling.TabIndex = 10;
            this.btnAddTooling.Tag = "add";
            this.btnAddTooling.Text = "add";
            this.btnAddTooling.UseVisualStyleBackColor = true;
            this.btnAddTooling.Click += new System.EventHandler(this.btnAddTooling_Click);
            // 
            // txtToolingPart
            // 
            this.txtToolingPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolingPart.BackColor = System.Drawing.SystemColors.Control;
            this.txtToolingPart.Enabled = false;
            this.txtToolingPart.Location = new System.Drawing.Point(209, 21);
            this.txtToolingPart.Name = "txtToolingPart";
            this.txtToolingPart.Size = new System.Drawing.Size(104, 26);
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
            this.txtToolingId.Size = new System.Drawing.Size(197, 26);
            this.txtToolingId.TabIndex = 9;
            this.txtToolingId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtToolingId_KeyUp);
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.Location = new System.Drawing.Point(319, 0);
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
            this.lblToolingPart.Location = new System.Drawing.Point(209, 0);
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
            this.txtToolingType.Location = new System.Drawing.Point(319, 21);
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
            this.label8.Size = new System.Drawing.Size(538, 22);
            this.label8.TabIndex = 6;
            this.label8.Tag = "setupToolingInfo";
            this.label8.Text = "setupToolingInfo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 730);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(813, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 98;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(890, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 99;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlTarget
            // 
            this.pnlTarget.AutoSize = true;
            this.pnlTarget.Controls.Add(this.tableLayoutPanel1);
            this.pnlTarget.Controls.Add(this.label6);
            this.pnlTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTarget.Location = new System.Drawing.Point(0, 0);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(967, 82);
            this.pnlTarget.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboStepId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStepId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderId, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboOrderId, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirmOrder, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClearOrder, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 60);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // cboStepId
            // 
            this.cboStepId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStepId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(65, 18);
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(206, 24);
            this.cboStepId.Sorted = true;
            this.cboStepId.TabIndex = 0;
            this.cboStepId.SelectedIndexChanged += new System.EventHandler(this.cboStepId_SelectedIndexChanged);
            // 
            // lblStepId
            // 
            this.lblStepId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStepId.AutoSize = true;
            this.lblStepId.Location = new System.Drawing.Point(3, 22);
            this.lblStepId.Name = "lblStepId";
            this.lblStepId.Size = new System.Drawing.Size(56, 16);
            this.lblStepId.TabIndex = 9;
            this.lblStepId.Tag = "stepId";
            this.lblStepId.Text = "stepId";
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(277, 22);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(64, 16);
            this.lblOrderId.TabIndex = 10;
            this.lblOrderId.Tag = "orderId";
            this.lblOrderId.Text = "orderId";
            // 
            // cboOrderId
            // 
            this.cboOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboOrderId.Location = new System.Drawing.Point(347, 18);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(206, 24);
            this.cboOrderId.Sorted = true;
            this.cboOrderId.TabIndex = 1;
            this.cboOrderId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboOrderId_KeyUp);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(625, 18);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(60, 24);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Tag = "buttonOK";
            this.btnConfirmOrder.Text = "OK";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearOrder.Enabled = false;
            this.btnClearOrder.Location = new System.Drawing.Point(559, 18);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(60, 24);
            this.btnClearOrder.TabIndex = 1;
            this.btnClearOrder.Tag = "buttonClear";
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(967, 22);
            this.label6.TabIndex = 6;
            this.label6.Tag = "target";
            this.label6.Text = "Target";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.AutoSize = false;
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 765);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(1184, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 790);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "EqSetup";
            this.Text = "EqSetup";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splSetupInfo.Panel1.ResumeLayout(false);
            this.splSetupInfo.Panel1.PerformLayout();
            this.splSetupInfo.Panel2.ResumeLayout(false);
            this.splSetupInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splSetupInfo)).EndInit();
            this.splSetupInfo.ResumeLayout(false);
            this.tblModifyQty.ResumeLayout(false);
            this.tblModifyQty.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlCurToolingInfo.ResumeLayout(false);
            this.pnlSetupMaterial.ResumeLayout(false);
            this.pnlSetupMatButton.ResumeLayout(false);
            this.tblMaterialInfo.ResumeLayout(false);
            this.tblMaterialInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnlSetupToolingInfo.ResumeLayout(false);
            this.tblToolingInfo.ResumeLayout(false);
            this.tblToolingInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlTarget.ResumeLayout(false);
            this.pnlTarget.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.SplitContainer splSetupInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurRecipe;
        private System.Windows.Forms.TableLayoutPanel tblModifyQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModifyQty;
        private System.Windows.Forms.Button btnModifyCurQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblInputRecipe;
        private System.Windows.Forms.TextBox txtInputRecipe;
        private System.Windows.Forms.TableLayoutPanel tblMaterialInfo;
        private System.Windows.Forms.Label lblMaterialQty;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblMaterialLotId;
        private System.Windows.Forms.Label lblMaterialPartNo;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMaterialQty;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TextBox txtMaterialLotId;
        private System.Windows.Forms.TextBox txtMaterialPartNo;
        protected internal idv.mesCore.Controls.MESListView lvwCurSetupMaterial;
        protected internal idv.mesCore.Controls.MESListView lvwSetupMaterial;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteCurMaterial;
        private mesRelease.Controls.EquipmentInformation equipmentInformation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblStepId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.TextBox txtMaterialType;
        private System.Windows.Forms.Panel pnlTarget;
        private System.Windows.Forms.Panel pnlCurToolingInfo;
        private System.Windows.Forms.Panel pnlSetupMaterial;
        private System.Windows.Forms.Panel pnlSetupMatButton;
        private System.Windows.Forms.Panel pnlSetupToolingInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        protected internal idv.mesCore.Controls.MESListView lvwCurTooling;
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

    }
}