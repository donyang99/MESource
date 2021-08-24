namespace ClientRule.SpecifyCarrier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lotInfomation1 = new mesRelease.Controls.LotInfomation();
            this.label1 = new System.Windows.Forms.Label();
            this.tblInputData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.carAfterCarrier = new mesRelease.Controls.CarrierInformation();
            this.compAfterComponent = new mesRelease.Controls.WIPComponentInformation();
            this.tblAfterCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.lblAfterCarrier = new System.Windows.Forms.Label();
            this.cboAfterCarrier = new System.Windows.Forms.ComboBox();
            this.btnAddCarrier = new System.Windows.Forms.Button();
            this.lblChild = new System.Windows.Forms.Label();
            this.tblMove = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.carBeforeCarrier = new mesRelease.Controls.CarrierInformation();
            this.compBeforeComponent = new mesRelease.Controls.WIPComponentInformation();
            this.tblBeforeCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.lblBeforeCarrier = new System.Windows.Forms.Label();
            this.cboBeforeCarrier = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblInputData.SuspendLayout();
            this.pnlChild.SuspendLayout();
            this.tblAfterCarrier.SuspendLayout();
            this.tblMove.SuspendLayout();
            this.pnlParent.SuspendLayout();
            this.tblBeforeCarrier.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lotInfomation1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tblInputData);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(934, 521);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 5;
            // 
            // lotInfomation1
            // 
            this.lotInfomation1.AutoScroll = true;
            this.lotInfomation1.AutoScrollMinSize = new System.Drawing.Size(100, 336);
            this.lotInfomation1.displayProperties = new string[] {
        "name",
        "status",
        "quantity",
        "unit",
        "lotType",
        "productId",
        "routeId",
        "stepId",
        "equipmentId",
        "orderId",
        "fab",
        "specId"};
            this.lotInfomation1.displayPropertyTags = new string[] {
        "lotId",
        "status",
        "quantity",
        "unit",
        "lotType",
        "productId",
        "routeId",
        "stepId",
        "equipmentId",
        "orderId",
        "fab",
        "specId"};
            this.lotInfomation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lotInfomation1.editable = false;
            this.lotInfomation1.Location = new System.Drawing.Point(0, 22);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = false;
            this.lotInfomation1.showDueDate = false;
            this.lotInfomation1.Size = new System.Drawing.Size(222, 499);
            this.lotInfomation1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lotInformation";
            this.label1.Text = "Lot Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblInputData
            // 
            this.tblInputData.ColumnCount = 3;
            this.tblInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInputData.Controls.Add(this.pnlChild, 2, 0);
            this.tblInputData.Controls.Add(this.tblMove, 1, 0);
            this.tblInputData.Controls.Add(this.pnlParent, 0, 0);
            this.tblInputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInputData.Location = new System.Drawing.Point(0, 0);
            this.tblInputData.Name = "tblInputData";
            this.tblInputData.RowCount = 1;
            this.tblInputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInputData.Size = new System.Drawing.Size(708, 486);
            this.tblInputData.TabIndex = 7;
            // 
            // pnlChild
            // 
            this.pnlChild.Controls.Add(this.carAfterCarrier);
            this.pnlChild.Controls.Add(this.compAfterComponent);
            this.pnlChild.Controls.Add(this.tblAfterCarrier);
            this.pnlChild.Controls.Add(this.lblChild);
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(374, 0);
            this.pnlChild.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(334, 486);
            this.pnlChild.TabIndex = 4;
            // 
            // carAfterCarrier
            // 
            this.carAfterCarrier.allowAdd = true;
            this.carAfterCarrier.allowChangeCarrier = false;
            this.carAfterCarrier.allowDelete = true;
            this.carAfterCarrier.allowEdit = true;
            this.carAfterCarrier.allowGenerateId = true;
            this.carAfterCarrier.carrierList = null;
            this.carAfterCarrier.componentInfo = null;
            this.carAfterCarrier.Location = new System.Drawing.Point(14, 285);
            this.carAfterCarrier.lotId = "";
            this.carAfterCarrier.Name = "carAfterCarrier";
            this.carAfterCarrier.showCarrierType = false;
            this.carAfterCarrier.Size = new System.Drawing.Size(259, 169);
            this.carAfterCarrier.TabIndex = 9;
            this.carAfterCarrier.CarrierAdded += new mesRelease.Controls.CarrierAddedEventHandler(this.carAfterCarrier_CarrierAdded);
            this.carAfterCarrier.CarrierRemoved += new mesRelease.Controls.CarrierRemovedEventHandler(this.carAfterCarrier_CarrierRemoved);
            // 
            // compAfterComponent
            // 
            this.compAfterComponent.allowEdit = false;
            this.compAfterComponent.allowGenerateId = false;
            this.compAfterComponent.allowMoveLocation = true;
            this.compAfterComponent.carrier = null;
            this.compAfterComponent.componentInfo = null;
            this.compAfterComponent.expectedQuantity = 0;
            this.compAfterComponent.Location = new System.Drawing.Point(14, 75);
            this.compAfterComponent.lotId = "";
            this.compAfterComponent.Margin = new System.Windows.Forms.Padding(4);
            this.compAfterComponent.Name = "compAfterComponent";
            this.compAfterComponent.showCarrierInfo = false;
            this.compAfterComponent.Size = new System.Drawing.Size(259, 153);
            this.compAfterComponent.TabIndex = 8;
            this.compAfterComponent.DoubleClick += new System.EventHandler(this.compAfterComponent_DoubleClick);
            // 
            // tblAfterCarrier
            // 
            this.tblAfterCarrier.ColumnCount = 4;
            this.tblAfterCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAfterCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAfterCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAfterCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblAfterCarrier.Controls.Add(this.lblAfterCarrier, 0, 0);
            this.tblAfterCarrier.Controls.Add(this.cboAfterCarrier, 1, 0);
            this.tblAfterCarrier.Controls.Add(this.btnAddCarrier, 2, 0);
            this.tblAfterCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblAfterCarrier.Location = new System.Drawing.Point(0, 20);
            this.tblAfterCarrier.Name = "tblAfterCarrier";
            this.tblAfterCarrier.RowCount = 1;
            this.tblAfterCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblAfterCarrier.Size = new System.Drawing.Size(334, 30);
            this.tblAfterCarrier.TabIndex = 7;
            // 
            // lblAfterCarrier
            // 
            this.lblAfterCarrier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAfterCarrier.AutoSize = true;
            this.lblAfterCarrier.Location = new System.Drawing.Point(3, 7);
            this.lblAfterCarrier.Name = "lblAfterCarrier";
            this.lblAfterCarrier.Size = new System.Drawing.Size(80, 16);
            this.lblAfterCarrier.TabIndex = 0;
            this.lblAfterCarrier.Tag = "carrier";
            this.lblAfterCarrier.Text = "carrierId";
            // 
            // cboAfterCarrier
            // 
            this.cboAfterCarrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAfterCarrier.FormattingEnabled = true;
            this.cboAfterCarrier.Location = new System.Drawing.Point(89, 3);
            this.cboAfterCarrier.Name = "cboAfterCarrier";
            this.cboAfterCarrier.Size = new System.Drawing.Size(138, 24);
            this.cboAfterCarrier.Sorted = true;
            this.cboAfterCarrier.TabIndex = 5;
            this.cboAfterCarrier.SelectedIndexChanged += new System.EventHandler(this.cboAfterCarrier_SelectedIndexChanged);
            this.cboAfterCarrier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboAfterCarrier_KeyUp);
            // 
            // btnAddCarrier
            // 
            this.btnAddCarrier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCarrier.Location = new System.Drawing.Point(233, 3);
            this.btnAddCarrier.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddCarrier.Name = "btnAddCarrier";
            this.btnAddCarrier.Size = new System.Drawing.Size(98, 24);
            this.btnAddCarrier.TabIndex = 6;
            this.btnAddCarrier.Tag = "addCarrier";
            this.btnAddCarrier.Text = "addCarrier";
            this.btnAddCarrier.UseVisualStyleBackColor = true;
            this.btnAddCarrier.Click += new System.EventHandler(this.btnAddCarrier_Click);
            // 
            // lblChild
            // 
            this.lblChild.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChild.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChild.Location = new System.Drawing.Point(0, 0);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(334, 20);
            this.lblChild.TabIndex = 1;
            this.lblChild.Tag = "afterModify";
            this.lblChild.Text = "afterModify";
            this.lblChild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblMove
            // 
            this.tblMove.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMove.ColumnCount = 1;
            this.tblMove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMove.Controls.Add(this.btnSelect, 0, 2);
            this.tblMove.Controls.Add(this.btnUnSelect, 0, 1);
            this.tblMove.Controls.Add(this.btnSelectAll, 0, 3);
            this.tblMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMove.Location = new System.Drawing.Point(336, 3);
            this.tblMove.Name = "tblMove";
            this.tblMove.RowCount = 4;
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMove.Size = new System.Drawing.Size(35, 480);
            this.tblMove.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ImageKey = "right.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(4, 243);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(27, 52);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "left.ico");
            this.imageList1.Images.SetKeyName(1, "right.ico");
            this.imageList1.Images.SetKeyName(2, "rightAll.ico");
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ImageKey = "left.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(4, 182);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(27, 52);
            this.btnUnSelect.TabIndex = 4;
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelectAll.ImageKey = "rightAll.ico";
            this.btnSelectAll.ImageList = this.imageList1;
            this.btnSelectAll.Location = new System.Drawing.Point(4, 304);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(27, 58);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // pnlParent
            // 
            this.pnlParent.Controls.Add(this.carBeforeCarrier);
            this.pnlParent.Controls.Add(this.compBeforeComponent);
            this.pnlParent.Controls.Add(this.tblBeforeCarrier);
            this.pnlParent.Controls.Add(this.label9);
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.Location = new System.Drawing.Point(0, 0);
            this.pnlParent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(333, 486);
            this.pnlParent.TabIndex = 3;
            // 
            // carBeforeCarrier
            // 
            this.carBeforeCarrier.allowAdd = false;
            this.carBeforeCarrier.allowChangeCarrier = false;
            this.carBeforeCarrier.allowDelete = true;
            this.carBeforeCarrier.allowEdit = false;
            this.carBeforeCarrier.allowGenerateId = true;
            this.carBeforeCarrier.carrierList = null;
            this.carBeforeCarrier.componentInfo = null;
            this.carBeforeCarrier.Location = new System.Drawing.Point(26, 275);
            this.carBeforeCarrier.lotId = "";
            this.carBeforeCarrier.Name = "carBeforeCarrier";
            this.carBeforeCarrier.showCarrierType = false;
            this.carBeforeCarrier.Size = new System.Drawing.Size(277, 179);
            this.carBeforeCarrier.TabIndex = 8;
            // 
            // compBeforeComponent
            // 
            this.compBeforeComponent.allowEdit = false;
            this.compBeforeComponent.allowGenerateId = false;
            this.compBeforeComponent.allowMoveLocation = false;
            this.compBeforeComponent.carrier = null;
            this.compBeforeComponent.componentInfo = null;
            this.compBeforeComponent.expectedQuantity = 0;
            this.compBeforeComponent.Location = new System.Drawing.Point(36, 75);
            this.compBeforeComponent.lotId = "";
            this.compBeforeComponent.Margin = new System.Windows.Forms.Padding(4);
            this.compBeforeComponent.Name = "compBeforeComponent";
            this.compBeforeComponent.showCarrierInfo = false;
            this.compBeforeComponent.Size = new System.Drawing.Size(223, 153);
            this.compBeforeComponent.TabIndex = 7;
            this.compBeforeComponent.DoubleClick += new System.EventHandler(this.compBeforeComponent_DoubleClick);
            // 
            // tblBeforeCarrier
            // 
            this.tblBeforeCarrier.ColumnCount = 4;
            this.tblBeforeCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBeforeCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBeforeCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblBeforeCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblBeforeCarrier.Controls.Add(this.lblBeforeCarrier, 0, 0);
            this.tblBeforeCarrier.Controls.Add(this.cboBeforeCarrier, 1, 0);
            this.tblBeforeCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBeforeCarrier.Location = new System.Drawing.Point(0, 20);
            this.tblBeforeCarrier.Name = "tblBeforeCarrier";
            this.tblBeforeCarrier.RowCount = 1;
            this.tblBeforeCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblBeforeCarrier.Size = new System.Drawing.Size(333, 30);
            this.tblBeforeCarrier.TabIndex = 5;
            // 
            // lblBeforeCarrier
            // 
            this.lblBeforeCarrier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBeforeCarrier.AutoSize = true;
            this.lblBeforeCarrier.Location = new System.Drawing.Point(3, 7);
            this.lblBeforeCarrier.Name = "lblBeforeCarrier";
            this.lblBeforeCarrier.Size = new System.Drawing.Size(80, 16);
            this.lblBeforeCarrier.TabIndex = 0;
            this.lblBeforeCarrier.Tag = "carrier";
            this.lblBeforeCarrier.Text = "carrierId";
            // 
            // cboBeforeCarrier
            // 
            this.cboBeforeCarrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBeforeCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeforeCarrier.FormattingEnabled = true;
            this.cboBeforeCarrier.Location = new System.Drawing.Point(89, 3);
            this.cboBeforeCarrier.Name = "cboBeforeCarrier";
            this.cboBeforeCarrier.Size = new System.Drawing.Size(138, 24);
            this.cboBeforeCarrier.Sorted = true;
            this.cboBeforeCarrier.TabIndex = 5;
            this.cboBeforeCarrier.SelectedIndexChanged += new System.EventHandler(this.cboBeforeCarrier_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 20);
            this.label9.TabIndex = 0;
            this.label9.Tag = "";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(631, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(554, 0);
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
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 521);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(934, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 546);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "SpecifyCarrier";
            this.Text = "SpecifyCarrier";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tblInputData.ResumeLayout(false);
            this.pnlChild.ResumeLayout(false);
            this.tblAfterCarrier.ResumeLayout(false);
            this.tblAfterCarrier.PerformLayout();
            this.tblMove.ResumeLayout(false);
            this.pnlParent.ResumeLayout(false);
            this.tblBeforeCarrier.ResumeLayout(false);
            this.tblBeforeCarrier.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tblInputData;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.TableLayoutPanel tblMove;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Panel pnlParent;
        private mesRelease.Controls.CarrierInformation carBeforeCarrier;
        private mesRelease.Controls.WIPComponentInformation compBeforeComponent;
        private System.Windows.Forms.TableLayoutPanel tblBeforeCarrier;
        private System.Windows.Forms.Label label9;
        private mesRelease.Controls.CarrierInformation carAfterCarrier;
        private mesRelease.Controls.WIPComponentInformation compAfterComponent;
        private System.Windows.Forms.TableLayoutPanel tblAfterCarrier;
        private System.Windows.Forms.ComboBox cboAfterCarrier;
        private System.Windows.Forms.Button btnAddCarrier;
        private System.Windows.Forms.Label lblAfterCarrier;
        private System.Windows.Forms.Label lblBeforeCarrier;
        private System.Windows.Forms.ComboBox cboBeforeCarrier;
        private mesRelease.Controls.LotInfomation lotInfomation1;
        private System.Windows.Forms.ImageList imageList1;

    }
}