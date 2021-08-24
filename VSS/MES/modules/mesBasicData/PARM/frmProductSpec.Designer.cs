namespace mesBasicData
{
    partial class frmProductSpec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSpec));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwSpec = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwAvailable = new idv.mesCore.Controls.MESListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwSelected = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwProduct = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwAvailableSpec = new idv.mesCore.Controls.MESListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwSelectedSpec = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelectSpec = new System.Windows.Forms.Button();
            this.btnSelectSpec = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageBySpec = new System.Windows.Forms.TabPage();
            this.pageByProd = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageBySpec.SuspendLayout();
            this.pageByProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwSpec);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(820, 521);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvwSpec
            // 
            this.lvwSpec.allowUserFilter = true;
            this.lvwSpec.allowUserSorting = true;
            this.lvwSpec.autoSizeColumn = true;
            this.lvwSpec.careModifyDate = false;
            this.lvwSpec.columnHide = null;
            this.lvwSpec.columnNames = new string[] {
        "name",
        "version",
        "description"};
            this.lvwSpec.columnTags = new string[] {
        "productParameter",
        "version",
        "description"};
            this.lvwSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSpec.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSpec.FullRowSelect = true;
            this.lvwSpec.GridLines = true;
            this.lvwSpec.HideSelection = false;
            this.lvwSpec.imageKeyColumn = "";
            this.lvwSpec.keyPressSearch = false;
            this.lvwSpec.keyPressSearchColumn = "";
            this.lvwSpec.Location = new System.Drawing.Point(0, 0);
            this.lvwSpec.makesureNewItemVisible = true;
            this.lvwSpec.MultiSelect = false;
            this.lvwSpec.Name = "lvwSpec";
            this.lvwSpec.OwnerDraw = true;
            this.lvwSpec.ShowItemTipSecond = ((byte)(3));
            this.lvwSpec.Size = new System.Drawing.Size(270, 521);
            this.lvwSpec.TabIndex = 9;
            this.lvwSpec.UseCompatibleStateImageBehavior = false;
            this.lvwSpec.View = System.Windows.Forms.View.Details;
            this.lvwSpec.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwSpec_MESItemSelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(546, 521);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvwAvailable);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(298, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(245, 515);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "availableList";
            this.groupBox3.Text = "availableList";
            // 
            // lvwAvailable
            // 
            this.lvwAvailable.allowUserFilter = true;
            this.lvwAvailable.allowUserSorting = true;
            this.lvwAvailable.autoSizeColumn = true;
            this.lvwAvailable.careModifyDate = false;
            this.lvwAvailable.columnHide = null;
            this.lvwAvailable.columnNames = new string[] {
        "name",
        "description"};
            this.lvwAvailable.columnTags = new string[] {
        "product",
        "description"};
            this.lvwAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailable.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAvailable.FullRowSelect = true;
            this.lvwAvailable.GridLines = true;
            this.lvwAvailable.HideSelection = false;
            this.lvwAvailable.imageKeyColumn = "";
            this.lvwAvailable.keyPressSearch = false;
            this.lvwAvailable.keyPressSearchColumn = "";
            this.lvwAvailable.Location = new System.Drawing.Point(3, 19);
            this.lvwAvailable.makesureNewItemVisible = false;
            this.lvwAvailable.MultiSelect = false;
            this.lvwAvailable.Name = "lvwAvailable";
            this.lvwAvailable.OwnerDraw = true;
            this.lvwAvailable.ShowItemTipSecond = ((byte)(3));
            this.lvwAvailable.Size = new System.Drawing.Size(239, 493);
            this.lvwAvailable.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwAvailable.TabIndex = 4;
            this.lvwAvailable.UseCompatibleStateImageBehavior = false;
            this.lvwAvailable.View = System.Windows.Forms.View.Details;
            this.lvwAvailable.DoubleClick += new System.EventHandler(this.lvwAvailable_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvwSelected);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 515);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "selectedList";
            this.groupBox2.Text = "selectedList";
            // 
            // lvwSelected
            // 
            this.lvwSelected.allowUserFilter = true;
            this.lvwSelected.allowUserSorting = true;
            this.lvwSelected.autoSizeColumn = true;
            this.lvwSelected.careModifyDate = false;
            this.lvwSelected.columnHide = null;
            this.lvwSelected.columnNames = new string[] {
        "name",
        "description"};
            this.lvwSelected.columnTags = new string[] {
        "product",
        "description"};
            this.lvwSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelected.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSelected.FullRowSelect = true;
            this.lvwSelected.GridLines = true;
            this.lvwSelected.HideSelection = false;
            this.lvwSelected.imageKeyColumn = "";
            this.lvwSelected.keyPressSearch = false;
            this.lvwSelected.keyPressSearchColumn = "";
            this.lvwSelected.Location = new System.Drawing.Point(3, 22);
            this.lvwSelected.makesureNewItemVisible = false;
            this.lvwSelected.MultiSelect = false;
            this.lvwSelected.Name = "lvwSelected";
            this.lvwSelected.OwnerDraw = true;
            this.lvwSelected.ShowItemTipSecond = ((byte)(3));
            this.lvwSelected.Size = new System.Drawing.Size(238, 490);
            this.lvwSelected.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwSelected.TabIndex = 0;
            this.lvwSelected.UseCompatibleStateImageBehavior = false;
            this.lvwSelected.View = System.Windows.Forms.View.Details;
            this.lvwSelected.DoubleClick += new System.EventHandler(this.lvwSelected_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnUnSelect, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSelect, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(253, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(39, 515);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Enabled = false;
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ImageKey = "right.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(3, 260);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelect.TabIndex = 3;
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "down.ico");
            this.imageList1.Images.SetKeyName(1, "left.ico");
            this.imageList1.Images.SetKeyName(2, "right.ico");
            this.imageList1.Images.SetKeyName(3, "up.ico");
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ImageKey = "left.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(3, 200);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwProduct);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(820, 521);
            this.splitContainer2.SplitterDistance = 269;
            this.splitContainer2.TabIndex = 1;
            // 
            // lvwProduct
            // 
            this.lvwProduct.allowUserFilter = true;
            this.lvwProduct.allowUserSorting = true;
            this.lvwProduct.autoSizeColumn = true;
            this.lvwProduct.careModifyDate = false;
            this.lvwProduct.columnHide = null;
            this.lvwProduct.columnNames = new string[] {
        "name",
        "description"};
            this.lvwProduct.columnTags = new string[] {
        "product",
        "description"};
            this.lvwProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwProduct.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwProduct.FullRowSelect = true;
            this.lvwProduct.GridLines = true;
            this.lvwProduct.HideSelection = false;
            this.lvwProduct.imageKeyColumn = "";
            this.lvwProduct.keyPressSearch = false;
            this.lvwProduct.keyPressSearchColumn = "";
            this.lvwProduct.Location = new System.Drawing.Point(0, 0);
            this.lvwProduct.makesureNewItemVisible = true;
            this.lvwProduct.MultiSelect = false;
            this.lvwProduct.Name = "lvwProduct";
            this.lvwProduct.OwnerDraw = true;
            this.lvwProduct.ShowItemTipSecond = ((byte)(3));
            this.lvwProduct.Size = new System.Drawing.Size(269, 521);
            this.lvwProduct.TabIndex = 9;
            this.lvwProduct.UseCompatibleStateImageBehavior = false;
            this.lvwProduct.View = System.Windows.Forms.View.Details;
            this.lvwProduct.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwProduct_MESItemSelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 521);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvwAvailableSpec);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(299, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(245, 515);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "availableList";
            this.groupBox1.Text = "availableList";
            // 
            // lvwAvailableSpec
            // 
            this.lvwAvailableSpec.allowUserFilter = true;
            this.lvwAvailableSpec.allowUserSorting = true;
            this.lvwAvailableSpec.autoSizeColumn = true;
            this.lvwAvailableSpec.careModifyDate = false;
            this.lvwAvailableSpec.columnHide = null;
            this.lvwAvailableSpec.columnNames = new string[] {
        "name",
        "version",
        "description"};
            this.lvwAvailableSpec.columnTags = new string[] {
        "productParameter",
        "version",
        "description"};
            this.lvwAvailableSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailableSpec.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAvailableSpec.FullRowSelect = true;
            this.lvwAvailableSpec.GridLines = true;
            this.lvwAvailableSpec.HideSelection = false;
            this.lvwAvailableSpec.imageKeyColumn = "";
            this.lvwAvailableSpec.keyPressSearch = false;
            this.lvwAvailableSpec.keyPressSearchColumn = "";
            this.lvwAvailableSpec.Location = new System.Drawing.Point(3, 19);
            this.lvwAvailableSpec.makesureNewItemVisible = false;
            this.lvwAvailableSpec.MultiSelect = false;
            this.lvwAvailableSpec.Name = "lvwAvailableSpec";
            this.lvwAvailableSpec.OwnerDraw = true;
            this.lvwAvailableSpec.ShowItemTipSecond = ((byte)(3));
            this.lvwAvailableSpec.Size = new System.Drawing.Size(239, 493);
            this.lvwAvailableSpec.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwAvailableSpec.TabIndex = 4;
            this.lvwAvailableSpec.UseCompatibleStateImageBehavior = false;
            this.lvwAvailableSpec.View = System.Windows.Forms.View.Details;
            this.lvwAvailableSpec.DoubleClick += new System.EventHandler(this.lvwAvailableSpec_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lvwSelectedSpec);
            this.groupBox4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 515);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "selectedList";
            this.groupBox4.Text = "selectedList";
            // 
            // lvwSelectedSpec
            // 
            this.lvwSelectedSpec.allowUserFilter = true;
            this.lvwSelectedSpec.allowUserSorting = true;
            this.lvwSelectedSpec.autoSizeColumn = true;
            this.lvwSelectedSpec.careModifyDate = false;
            this.lvwSelectedSpec.columnHide = null;
            this.lvwSelectedSpec.columnNames = new string[] {
        "name",
        "version",
        "description"};
            this.lvwSelectedSpec.columnTags = new string[] {
        "productParameter",
        "version",
        "description"};
            this.lvwSelectedSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelectedSpec.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSelectedSpec.FullRowSelect = true;
            this.lvwSelectedSpec.GridLines = true;
            this.lvwSelectedSpec.HideSelection = false;
            this.lvwSelectedSpec.imageKeyColumn = "";
            this.lvwSelectedSpec.keyPressSearch = false;
            this.lvwSelectedSpec.keyPressSearchColumn = "";
            this.lvwSelectedSpec.Location = new System.Drawing.Point(3, 22);
            this.lvwSelectedSpec.makesureNewItemVisible = false;
            this.lvwSelectedSpec.MultiSelect = false;
            this.lvwSelectedSpec.Name = "lvwSelectedSpec";
            this.lvwSelectedSpec.OwnerDraw = true;
            this.lvwSelectedSpec.ShowItemTipSecond = ((byte)(3));
            this.lvwSelectedSpec.Size = new System.Drawing.Size(239, 490);
            this.lvwSelectedSpec.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwSelectedSpec.TabIndex = 0;
            this.lvwSelectedSpec.UseCompatibleStateImageBehavior = false;
            this.lvwSelectedSpec.View = System.Windows.Forms.View.Details;
            this.lvwSelectedSpec.DoubleClick += new System.EventHandler(this.lvwSelectedSpec_DoubleClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnUnSelectSpec, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnSelectSpec, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(254, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(39, 515);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnUnSelectSpec
            // 
            this.btnUnSelectSpec.Enabled = false;
            this.btnUnSelectSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelectSpec.ImageKey = "right.ico";
            this.btnUnSelectSpec.ImageList = this.imageList1;
            this.btnUnSelectSpec.Location = new System.Drawing.Point(3, 260);
            this.btnUnSelectSpec.Name = "btnUnSelectSpec";
            this.btnUnSelectSpec.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelectSpec.TabIndex = 3;
            this.btnUnSelectSpec.UseVisualStyleBackColor = true;
            this.btnUnSelectSpec.Click += new System.EventHandler(this.btnUnSelectSpec_Click);
            // 
            // btnSelectSpec
            // 
            this.btnSelectSpec.Enabled = false;
            this.btnSelectSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelectSpec.ImageKey = "left.ico";
            this.btnSelectSpec.ImageList = this.imageList1;
            this.btnSelectSpec.Location = new System.Drawing.Point(3, 200);
            this.btnSelectSpec.Name = "btnSelectSpec";
            this.btnSelectSpec.Size = new System.Drawing.Size(33, 52);
            this.btnSelectSpec.TabIndex = 4;
            this.btnSelectSpec.UseVisualStyleBackColor = true;
            this.btnSelectSpec.Click += new System.EventHandler(this.btnSelectSpec_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageBySpec);
            this.tabControl1.Controls.Add(this.pageByProd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 557);
            this.tabControl1.TabIndex = 2;
            // 
            // pageBySpec
            // 
            this.pageBySpec.Controls.Add(this.splitContainer1);
            this.pageBySpec.Location = new System.Drawing.Point(4, 26);
            this.pageBySpec.Name = "pageBySpec";
            this.pageBySpec.Padding = new System.Windows.Forms.Padding(3);
            this.pageBySpec.Size = new System.Drawing.Size(826, 527);
            this.pageBySpec.TabIndex = 0;
            this.pageBySpec.Tag = "productSpec";
            this.pageBySpec.Text = "bySpec";
            this.pageBySpec.UseVisualStyleBackColor = true;
            // 
            // pageByProd
            // 
            this.pageByProd.Controls.Add(this.splitContainer2);
            this.pageByProd.Location = new System.Drawing.Point(4, 26);
            this.pageByProd.Name = "pageByProd";
            this.pageByProd.Padding = new System.Windows.Forms.Padding(3);
            this.pageByProd.Size = new System.Drawing.Size(826, 527);
            this.pageByProd.TabIndex = 1;
            this.pageByProd.Tag = "productSpec";
            this.pageByProd.Text = "byProduct";
            this.pageByProd.UseVisualStyleBackColor = true;
            // 
            // frmProductSpec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 557);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductSpec";
            this.Tag = "productSpec";
            this.Text = "frmProductSpec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmProductSpec_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pageBySpec.ResumeLayout(false);
            this.pageByProd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private idv.mesCore.Controls.MESListView lvwSpec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private idv.mesCore.Controls.MESListView lvwAvailable;
        private System.Windows.Forms.GroupBox groupBox2;
        private idv.mesCore.Controls.MESListView lvwSelected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private idv.mesCore.Controls.MESListView lvwProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private idv.mesCore.Controls.MESListView lvwAvailableSpec;
        private System.Windows.Forms.GroupBox groupBox4;
        private idv.mesCore.Controls.MESListView lvwSelectedSpec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnUnSelectSpec;
        private System.Windows.Forms.Button btnSelectSpec;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageBySpec;
        private System.Windows.Forms.TabPage pageByProd;
    }
}