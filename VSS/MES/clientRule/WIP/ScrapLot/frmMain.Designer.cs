namespace ClientRule.ScrapLot
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tblInputData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.compChildComponent = new mesRelease.Controls.WIPComponentInformation();
            this.tblChildCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.lblChild = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtScrapQuantity = new System.Windows.Forms.TextBox();
            this.tblMove = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.carParentCarrier = new mesRelease.Controls.CarrierInformation();
            this.compParentComponent = new mesRelease.Controls.WIPComponentInformation();
            this.tblParentCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.lblParentCarrier = new System.Windows.Forms.Label();
            this.cboParentCarrier = new System.Windows.Forms.ComboBox();
            this.btnMoveCarrier = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblContents = new System.Windows.Forms.Label();
            this.reasonCode1 = new mesRelease.Controls.ReasonCode();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tblInputData.SuspendLayout();
            this.pnlChild.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblMove.SuspendLayout();
            this.pnlParent.SuspendLayout();
            this.tblParentCarrier.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(941, 539);
            this.splitContainer1.SplitterDistance = 224;
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
            this.lotInfomation1.editable = true;
            this.lotInfomation1.Location = new System.Drawing.Point(0, 22);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = false;
            this.lotInfomation1.showDueDate = false;
            this.lotInfomation1.Size = new System.Drawing.Size(224, 517);
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
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lotInformation";
            this.label1.Text = "Lot Info";
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
            this.splitContainer2.Panel1.Controls.Add(this.tblInputData);
            this.splitContainer2.Panel1.Controls.Add(this.lblContents);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.reasonCode1);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Size = new System.Drawing.Size(713, 504);
            this.splitContainer2.SplitterDistance = 330;
            this.splitContainer2.TabIndex = 6;
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
            this.tblInputData.Location = new System.Drawing.Point(0, 22);
            this.tblInputData.Name = "tblInputData";
            this.tblInputData.RowCount = 1;
            this.tblInputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInputData.Size = new System.Drawing.Size(713, 308);
            this.tblInputData.TabIndex = 7;
            // 
            // pnlChild
            // 
            this.pnlChild.Controls.Add(this.compChildComponent);
            this.pnlChild.Controls.Add(this.tblChildCarrier);
            this.pnlChild.Controls.Add(this.lblChild);
            this.pnlChild.Controls.Add(this.tableLayoutPanel2);
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(377, 0);
            this.pnlChild.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(336, 308);
            this.pnlChild.TabIndex = 4;
            // 
            // compChildComponent
            // 
            this.compChildComponent.allowEdit = false;
            this.compChildComponent.allowGenerateId = false;
            this.compChildComponent.allowMoveLocation = true;
            this.compChildComponent.carrier = null;
            this.compChildComponent.componentInfo = null;
            this.compChildComponent.expectedQuantity = 0;
            this.compChildComponent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.compChildComponent.Location = new System.Drawing.Point(14, 87);
            this.compChildComponent.lotId = "";
            this.compChildComponent.Margin = new System.Windows.Forms.Padding(4);
            this.compChildComponent.Name = "compChildComponent";
            this.compChildComponent.showCarrierInfo = false;
            this.compChildComponent.Size = new System.Drawing.Size(259, 124);
            this.compChildComponent.TabIndex = 8;
            this.compChildComponent.DoubleClick += new System.EventHandler(this.compChildComponent_DoubleClick);
            // 
            // tblChildCarrier
            // 
            this.tblChildCarrier.ColumnCount = 1;
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 336F));
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChildCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChildCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblChildCarrier.Location = new System.Drawing.Point(0, 47);
            this.tblChildCarrier.Name = "tblChildCarrier";
            this.tblChildCarrier.RowCount = 1;
            this.tblChildCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblChildCarrier.Size = new System.Drawing.Size(336, 30);
            this.tblChildCarrier.TabIndex = 7;
            // 
            // lblChild
            // 
            this.lblChild.BackColor = System.Drawing.Color.Navy;
            this.lblChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChild.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChild.Location = new System.Drawing.Point(0, 30);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(336, 17);
            this.lblChild.TabIndex = 1;
            this.lblChild.Tag = "scrapInfo";
            this.lblChild.Text = "ScrapInfo";
            this.lblChild.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblQuantity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtScrapQuantity, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 30);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Tag = "scrapNotice";
            this.label2.Text = "scrapNotice";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 7);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 16);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Tag = "quantity";
            this.lblQuantity.Text = "quantity";
            // 
            // txtScrapQuantity
            // 
            this.txtScrapQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScrapQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtScrapQuantity.Location = new System.Drawing.Point(81, 1);
            this.txtScrapQuantity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.txtScrapQuantity.MaxLength = 6;
            this.txtScrapQuantity.Name = "txtScrapQuantity";
            this.txtScrapQuantity.ReadOnly = true;
            this.txtScrapQuantity.Size = new System.Drawing.Size(71, 26);
            this.txtScrapQuantity.TabIndex = 16;
            this.txtScrapQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChildLotQuantity_KeyPress);
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
            this.tblMove.Location = new System.Drawing.Point(339, 3);
            this.tblMove.Name = "tblMove";
            this.tblMove.RowCount = 4;
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblMove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMove.Size = new System.Drawing.Size(35, 302);
            this.tblMove.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ImageKey = "right.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(4, 154);
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
            this.btnUnSelect.Location = new System.Drawing.Point(4, 93);
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
            this.btnSelectAll.Location = new System.Drawing.Point(4, 215);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(27, 52);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // pnlParent
            // 
            this.pnlParent.Controls.Add(this.carParentCarrier);
            this.pnlParent.Controls.Add(this.compParentComponent);
            this.pnlParent.Controls.Add(this.tblParentCarrier);
            this.pnlParent.Controls.Add(this.label9);
            this.pnlParent.Controls.Add(this.tableLayoutPanel1);
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.Location = new System.Drawing.Point(0, 0);
            this.pnlParent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(336, 308);
            this.pnlParent.TabIndex = 3;
            // 
            // carParentCarrier
            // 
            this.carParentCarrier.allowAdd = false;
            this.carParentCarrier.allowChangeCarrier = false;
            this.carParentCarrier.allowDelete = false;
            this.carParentCarrier.allowEdit = true;
            this.carParentCarrier.allowGenerateId = true;
            this.carParentCarrier.carrierList = null;
            this.carParentCarrier.componentInfo = null;
            this.carParentCarrier.Location = new System.Drawing.Point(24, 220);
            this.carParentCarrier.lotId = "";
            this.carParentCarrier.Name = "carParentCarrier";
            this.carParentCarrier.showCarrierType = false;
            this.carParentCarrier.Size = new System.Drawing.Size(277, 70);
            this.carParentCarrier.TabIndex = 8;
            this.carParentCarrier.AfterEdit += new System.EventHandler(this.carParentCarrier_AfterEdit);
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
            this.compParentComponent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.compParentComponent.Location = new System.Drawing.Point(36, 75);
            this.compParentComponent.lotId = "";
            this.compParentComponent.Margin = new System.Windows.Forms.Padding(4);
            this.compParentComponent.Name = "compParentComponent";
            this.compParentComponent.showCarrierInfo = false;
            this.compParentComponent.Size = new System.Drawing.Size(223, 122);
            this.compParentComponent.TabIndex = 7;
            this.compParentComponent.DoubleClick += new System.EventHandler(this.compParentComponent_DoubleClick);
            // 
            // tblParentCarrier
            // 
            this.tblParentCarrier.ColumnCount = 4;
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblParentCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblParentCarrier.Controls.Add(this.lblParentCarrier, 0, 0);
            this.tblParentCarrier.Controls.Add(this.cboParentCarrier, 1, 0);
            this.tblParentCarrier.Controls.Add(this.btnMoveCarrier, 2, 0);
            this.tblParentCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblParentCarrier.Location = new System.Drawing.Point(0, 47);
            this.tblParentCarrier.Name = "tblParentCarrier";
            this.tblParentCarrier.RowCount = 1;
            this.tblParentCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblParentCarrier.Size = new System.Drawing.Size(336, 30);
            this.tblParentCarrier.TabIndex = 5;
            // 
            // lblParentCarrier
            // 
            this.lblParentCarrier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblParentCarrier.AutoSize = true;
            this.lblParentCarrier.Location = new System.Drawing.Point(8, 0);
            this.lblParentCarrier.Name = "lblParentCarrier";
            this.lblParentCarrier.Size = new System.Drawing.Size(40, 30);
            this.lblParentCarrier.TabIndex = 0;
            this.lblParentCarrier.Tag = "carrier";
            this.lblParentCarrier.Text = "carrierId";
            // 
            // cboParentCarrier
            // 
            this.cboParentCarrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboParentCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParentCarrier.FormattingEnabled = true;
            this.cboParentCarrier.Location = new System.Drawing.Point(54, 3);
            this.cboParentCarrier.Name = "cboParentCarrier";
            this.cboParentCarrier.Size = new System.Drawing.Size(138, 24);
            this.cboParentCarrier.Sorted = true;
            this.cboParentCarrier.TabIndex = 5;
            this.cboParentCarrier.SelectedIndexChanged += new System.EventHandler(this.cboParentCarrier_SelectedIndexChanged);
            // 
            // btnMoveCarrier
            // 
            this.btnMoveCarrier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMoveCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMoveCarrier.ImageKey = "right.ico";
            this.btnMoveCarrier.ImageList = this.imageList1;
            this.btnMoveCarrier.Location = new System.Drawing.Point(198, 3);
            this.btnMoveCarrier.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnMoveCarrier.Name = "btnMoveCarrier";
            this.btnMoveCarrier.Size = new System.Drawing.Size(34, 24);
            this.btnMoveCarrier.TabIndex = 7;
            this.btnMoveCarrier.Tag = "";
            this.btnMoveCarrier.UseVisualStyleBackColor = true;
            this.btnMoveCarrier.Click += new System.EventHandler(this.btnMoveCarrier_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(0, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 17);
            this.label9.TabIndex = 0;
            this.label9.Tag = "";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblContents
            // 
            this.lblContents.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContents.ForeColor = System.Drawing.SystemColors.Window;
            this.lblContents.Location = new System.Drawing.Point(0, 0);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(713, 22);
            this.lblContents.TabIndex = 6;
            this.lblContents.Tag = "inputData";
            this.lblContents.Text = "inputData";
            this.lblContents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.reasonCode1.Size = new System.Drawing.Size(713, 148);
            this.reasonCode1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(713, 22);
            this.label6.TabIndex = 14;
            this.label6.Tag = "comments";
            this.label6.Text = "Comments";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(636, 0);
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
            this.btnOK.Location = new System.Drawing.Point(559, 0);
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
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 539);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(941, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(941, 564);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "ScrapLot";
            this.Text = "ScrapLot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tblInputData.ResumeLayout(false);
            this.pnlChild.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblMove.ResumeLayout(false);
            this.pnlParent.ResumeLayout(false);
            this.tblParentCarrier.ResumeLayout(false);
            this.tblParentCarrier.PerformLayout();
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
        private mesRelease.Controls.ReasonCode reasonCode1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tblInputData;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.TableLayoutPanel tblMove;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Panel pnlParent;
        private mesRelease.Controls.CarrierInformation carParentCarrier;
        private mesRelease.Controls.WIPComponentInformation compParentComponent;
        private System.Windows.Forms.TableLayoutPanel tblParentCarrier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblContents;
        private mesRelease.Controls.WIPComponentInformation compChildComponent;
        private System.Windows.Forms.TableLayoutPanel tblChildCarrier;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtScrapQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblParentCarrier;
        private System.Windows.Forms.ComboBox cboParentCarrier;
        private System.Windows.Forms.Button btnMoveCarrier;
        private mesRelease.Controls.LotInfomation lotInfomation1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;

    }
}