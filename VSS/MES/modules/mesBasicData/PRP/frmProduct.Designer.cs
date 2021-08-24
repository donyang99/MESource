namespace mesBasicData
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtPackingQty = new System.Windows.Forms.TextBox();
            this.txtProductSize = new System.Windows.Forms.TextBox();
            this.txtLotSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFAB = new System.Windows.Forms.ComboBox();
            this.lblFab = new System.Windows.Forms.Label();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwAvailable = new idv.mesCore.Controls.MESListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwSelected = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.lvwDCItem = new idv.mesCore.Controls.MESListView();
            this.grpSkipDCItem = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpSkipDCItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pnlExt);
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1016, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editProduct";
            this.groupBox1.Text = "editProduct";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 83);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1010, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 8;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.Controls.Add(this.txtPackingQty, 3, 1);
            this.tblDetail.Controls.Add(this.txtProductSize, 1, 1);
            this.tblDetail.Controls.Add(this.txtLotSize, 7, 0);
            this.tblDetail.Controls.Add(this.label1, 6, 0);
            this.tblDetail.Controls.Add(this.label2, 2, 1);
            this.tblDetail.Controls.Add(this.cboFAB, 5, 0);
            this.tblDetail.Controls.Add(this.lblFab, 4, 0);
            this.tblDetail.Controls.Add(this.cboProductType, 3, 0);
            this.tblDetail.Controls.Add(this.lblProductType, 2, 0);
            this.tblDetail.Controls.Add(this.lblProduct, 0, 0);
            this.tblDetail.Controls.Add(this.txtProduct, 1, 0);
            this.tblDetail.Controls.Add(this.label4, 4, 1);
            this.tblDetail.Controls.Add(this.txtDescription, 5, 1);
            this.tblDetail.Controls.Add(this.label3, 0, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(1010, 64);
            this.tblDetail.TabIndex = 0;
            // 
            // txtPackingQty
            // 
            this.txtPackingQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackingQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtPackingQty.Location = new System.Drawing.Point(419, 35);
            this.txtPackingQty.MaxLength = 5;
            this.txtPackingQty.Name = "txtPackingQty";
            this.txtPackingQty.Size = new System.Drawing.Size(139, 26);
            this.txtPackingQty.TabIndex = 5;
            this.txtPackingQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtPackingQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtProductSize
            // 
            this.txtProductSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductSize.Location = new System.Drawing.Point(105, 35);
            this.txtProductSize.MaxLength = 40;
            this.txtProductSize.Name = "txtProductSize";
            this.txtProductSize.Size = new System.Drawing.Size(174, 26);
            this.txtProductSize.TabIndex = 4;
            this.txtProductSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtLotSize
            // 
            this.txtLotSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtLotSize.Location = new System.Drawing.Point(856, 3);
            this.txtLotSize.MaxLength = 5;
            this.txtLotSize.Name = "txtLotSize";
            this.txtLotSize.Size = new System.Drawing.Size(107, 26);
            this.txtLotSize.TabIndex = 3;
            this.txtLotSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtLotSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(786, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 11;
            this.label1.Tag = "lotSize";
            this.label1.Text = "lotSize";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(285, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 12;
            this.label2.Tag = "packingQuantity";
            this.label2.Text = "packingQuantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFAB
            // 
            this.cboFAB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFAB.BackColor = System.Drawing.SystemColors.Info;
            this.cboFAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFAB.FormattingEnabled = true;
            this.cboFAB.Location = new System.Drawing.Point(666, 4);
            this.cboFAB.Name = "cboFAB";
            this.cboFAB.Size = new System.Drawing.Size(114, 24);
            this.cboFAB.Sorted = true;
            this.cboFAB.TabIndex = 2;
            this.cboFAB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblFab
            // 
            this.lblFab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFab.AutoSize = true;
            this.lblFab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFab.Location = new System.Drawing.Point(626, 7);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(34, 18);
            this.lblFab.TabIndex = 12;
            this.lblFab.Tag = "fab";
            this.lblFab.Text = "fab";
            this.lblFab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboProductType
            // 
            this.cboProductType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboProductType.BackColor = System.Drawing.SystemColors.Info;
            this.cboProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Location = new System.Drawing.Point(419, 4);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(139, 24);
            this.cboProductType.Sorted = true;
            this.cboProductType.TabIndex = 1;
            this.cboProductType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblProductType
            // 
            this.lblProductType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProductType.AutoSize = true;
            this.lblProductType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductType.Location = new System.Drawing.Point(315, 7);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(98, 18);
            this.lblProductType.TabIndex = 11;
            this.lblProductType.Tag = "productType";
            this.lblProductType.Text = "productType";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProduct.AutoSize = true;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProduct.Location = new System.Drawing.Point(33, 7);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(66, 18);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Tag = "product";
            this.lblProduct.Text = "product";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProduct
            // 
            this.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProduct.BackColor = System.Drawing.SystemColors.Info;
            this.txtProduct.Location = new System.Drawing.Point(105, 3);
            this.txtProduct.MaxLength = 40;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(174, 26);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(564, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Location = new System.Drawing.Point(666, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(341, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 13;
            this.label3.Tag = "productSize";
            this.label3.Text = "productSize";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 139);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1016, 7);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 379);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1016, 251);
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
            this.groupBox3.Location = new System.Drawing.Point(533, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(480, 245);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "availableRoute";
            this.groupBox3.Text = "availableRoute";
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
        "version",
        "routeType",
        "description"};
            this.lvwAvailable.columnTags = new string[] {
        "route",
        "version",
        "routeType",
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
            this.lvwAvailable.Size = new System.Drawing.Size(474, 223);
            this.lvwAvailable.TabIndex = 11;
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
            this.groupBox2.Size = new System.Drawing.Size(479, 245);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "selectedRoute";
            this.groupBox2.Text = "selectedRoute";
            // 
            // lvwSelected
            // 
            this.lvwSelected.allowUserFilter = false;
            this.lvwSelected.allowUserSorting = true;
            this.lvwSelected.autoSizeColumn = true;
            this.lvwSelected.careModifyDate = false;
            this.lvwSelected.columnHide = null;
            this.lvwSelected.columnNames = new string[] {
        "name",
        "version",
        "routeType",
        "description"};
            this.lvwSelected.columnTags = new string[] {
        "route",
        "version",
        "routeType",
        "description"};
            this.lvwSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelected.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.lvwSelected.Size = new System.Drawing.Size(473, 220);
            this.lvwSelected.TabIndex = 10;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(488, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(39, 245);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ImageKey = "right.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(3, 125);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelect.TabIndex = 9;
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "left.ico");
            this.imageList1.Images.SetKeyName(1, "right.ico");
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ImageKey = "left.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(3, 65);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // mesListView1
            // 
            this.mesListView1.allowUserFilter = false;
            this.mesListView1.allowUserSorting = true;
            this.mesListView1.autoSizeColumn = true;
            this.mesListView1.careModifyDate = false;
            this.mesListView1.columnHide = null;
            this.mesListView1.columnNames = new string[] {
        "name",
        "productType",
        "fab",
        "composeSize",
        "productSize",
        "packingQuantity",
        "issueState",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "product",
        "productType",
        "fab",
        "lotSize",
        "productSize",
        "packingQuantity",
        "issueState",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesListView1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mesListView1.FullRowSelect = true;
            this.mesListView1.GridLines = true;
            this.mesListView1.HideSelection = false;
            this.mesListView1.imageKeyColumn = "";
            this.mesListView1.keyPressSearch = false;
            this.mesListView1.keyPressSearchColumn = "";
            this.mesListView1.Location = new System.Drawing.Point(0, 146);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(773, 233);
            this.mesListView1.TabIndex = 7;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(1016, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // lvwDCItem
            // 
            this.lvwDCItem.allowUserFilter = true;
            this.lvwDCItem.allowUserSorting = true;
            this.lvwDCItem.autoSizeColumn = true;
            this.lvwDCItem.careModifyDate = false;
            this.lvwDCItem.CheckBoxes = true;
            this.lvwDCItem.columnHide = null;
            this.lvwDCItem.columnNames = new string[] {
        "name",
        "dataType",
        "description"};
            this.lvwDCItem.columnTags = new string[] {
        "stepDC",
        "dataType",
        "description"};
            this.lvwDCItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDCItem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwDCItem.FullRowSelect = true;
            this.lvwDCItem.GridLines = true;
            this.lvwDCItem.HideSelection = false;
            this.lvwDCItem.imageKeyColumn = "";
            this.lvwDCItem.keyPressSearch = false;
            this.lvwDCItem.keyPressSearchColumn = "";
            this.lvwDCItem.Location = new System.Drawing.Point(3, 22);
            this.lvwDCItem.makesureNewItemVisible = false;
            this.lvwDCItem.MultiSelect = false;
            this.lvwDCItem.Name = "lvwDCItem";
            this.lvwDCItem.OwnerDraw = true;
            this.lvwDCItem.ShowItemTipSecond = ((byte)(3));
            this.lvwDCItem.Size = new System.Drawing.Size(237, 208);
            this.lvwDCItem.TabIndex = 12;
            this.lvwDCItem.UseCompatibleStateImageBehavior = false;
            this.lvwDCItem.View = System.Windows.Forms.View.Details;
            // 
            // grpSkipDCItem
            // 
            this.grpSkipDCItem.Controls.Add(this.lvwDCItem);
            this.grpSkipDCItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpSkipDCItem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpSkipDCItem.ForeColor = System.Drawing.Color.Blue;
            this.grpSkipDCItem.Location = new System.Drawing.Point(773, 146);
            this.grpSkipDCItem.Name = "grpSkipDCItem";
            this.grpSkipDCItem.Size = new System.Drawing.Size(243, 233);
            this.grpSkipDCItem.TabIndex = 13;
            this.grpSkipDCItem.TabStop = false;
            this.grpSkipDCItem.Tag = "skipDCItem";
            this.grpSkipDCItem.Text = "Skip DCItem";
            // 
            // frmProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1016, 630);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.grpSkipDCItem);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduct";
            this.Tag = "Product";
            this.Text = "frmProduct";
            this.Activated += new System.EventHandler(this.frmProduct_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProduct_FormClosed);
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grpSkipDCItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private idv.mesCore.Controls.MESListView lvwAvailable;
        private System.Windows.Forms.GroupBox groupBox2;
        private idv.mesCore.Controls.MESListView lvwSelected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.ComboBox cboFAB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLotSize;
        private System.Windows.Forms.TextBox txtPackingQty;
        private System.Windows.Forms.TextBox txtProductSize;
        private idv.mesCore.Controls.MESListView lvwDCItem;
        private System.Windows.Forms.GroupBox grpSkipDCItem;
        private System.Windows.Forms.Panel pnlExt;
    }
}