namespace ClientRule.CartonPacking
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblGetLot = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetLot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboEquipmentId = new System.Windows.Forms.ComboBox();
            this.txtLotId = new idv.mesCore.Controls.BarcodeTextBox();
            this.txtLotStatus = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblLotId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvwCartonInfo = new idv.mesCore.Controls.MESListView();
            this.tblCarton = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshOrder = new System.Windows.Forms.Button();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.btnForcePack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddCarton = new System.Windows.Forms.Button();
            this.txtCartonId = new idv.mesCore.Controls.BarcodeTextBox();
            this.lblCartonId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.pnlStepDC = new System.Windows.Forms.Panel();
            this.stepDC1 = new mesRelease.Controls.StepDC();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCurrWorkInfo = new System.Windows.Forms.Panel();
            this.taWorkInformation1 = new mesRelease.Controls.TaWorkInformation();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lvwLotInfo = new idv.mesCore.Controls.MESListView();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDisplayMessage = new System.Windows.Forms.Panel();
            this.tblGetLot.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tblCarton.SuspendLayout();
            this.pnlStepDC.SuspendLayout();
            this.pnlCurrWorkInfo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1113, 7);
            this.label1.TabIndex = 15;
            this.label1.Tag = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblGetLot
            // 
            this.tblGetLot.ColumnCount = 10;
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.Controls.Add(this.btnGetLot, 5, 0);
            this.tblGetLot.Controls.Add(this.btnExit, 9, 0);
            this.tblGetLot.Controls.Add(this.cboEquipmentId, 1, 0);
            this.tblGetLot.Controls.Add(this.txtLotId, 4, 0);
            this.tblGetLot.Controls.Add(this.txtLotStatus, 7, 0);
            this.tblGetLot.Controls.Add(this.txtState, 2, 0);
            this.tblGetLot.Controls.Add(this.lblEquipment, 0, 0);
            this.tblGetLot.Controls.Add(this.lblLotId, 3, 0);
            this.tblGetLot.Controls.Add(this.btnClear, 6, 0);
            this.tblGetLot.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblGetLot.Location = new System.Drawing.Point(0, 50);
            this.tblGetLot.Name = "tblGetLot";
            this.tblGetLot.RowCount = 1;
            this.tblGetLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGetLot.Size = new System.Drawing.Size(1113, 38);
            this.tblGetLot.TabIndex = 8;
            // 
            // btnGetLot
            // 
            this.btnGetLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetLot.Location = new System.Drawing.Point(651, 6);
            this.btnGetLot.Name = "btnGetLot";
            this.btnGetLot.Size = new System.Drawing.Size(58, 25);
            this.btnGetLot.TabIndex = 2;
            this.btnGetLot.TabStop = false;
            this.btnGetLot.Tag = "fetch";
            this.btnGetLot.Text = "Get";
            this.btnGetLot.UseVisualStyleBackColor = true;
            this.btnGetLot.Click += new System.EventHandler(this.btnGetLot_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExit.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(1048, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Tag = "buttonExit";
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboEquipmentId
            // 
            this.cboEquipmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipmentId.FormattingEnabled = true;
            this.cboEquipmentId.Location = new System.Drawing.Point(105, 7);
            this.cboEquipmentId.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.cboEquipmentId.Name = "cboEquipmentId";
            this.cboEquipmentId.Size = new System.Drawing.Size(215, 24);
            this.cboEquipmentId.TabIndex = 19;
            this.cboEquipmentId.SelectedIndexChanged += new System.EventHandler(this.cboEquipmentId_SelectedIndexChanged);
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotId.BackColor = System.Drawing.SystemColors.Info;
            this.txtLotId.CheckInputChar = false;
            this.txtLotId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLotId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLotId.Location = new System.Drawing.Point(431, 6);
            this.txtLotId.MaxLength = 40;
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.ShowPopupMessage = false;
            this.txtLotId.Size = new System.Drawing.Size(214, 26);
            this.txtLotId.TabIndex = 0;
            this.txtLotId.TimeOutMilliseconds = ((long)(500));
            this.txtLotId.ToolTipFontSize = 11.25F;
            this.txtLotId.BarcodeInput += new idv.mesCore.Controls.BarcodeTextBox.BarcodeInputEventHandler(this.txtLotId_BarcodeInput);
            // 
            // txtLotStatus
            // 
            this.txtLotStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotStatus.Location = new System.Drawing.Point(779, 6);
            this.txtLotStatus.MaxLength = 40;
            this.txtLotStatus.Name = "txtLotStatus";
            this.txtLotStatus.ReadOnly = true;
            this.txtLotStatus.Size = new System.Drawing.Size(45, 26);
            this.txtLotStatus.TabIndex = 6;
            this.txtLotStatus.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtState.Location = new System.Drawing.Point(326, 6);
            this.txtState.MaxLength = 40;
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(45, 26);
            this.txtState.TabIndex = 5;
            this.txtState.TabStop = false;
            // 
            // lblEquipment
            // 
            this.lblEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(3, 11);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(96, 16);
            this.lblEquipment.TabIndex = 3;
            this.lblEquipment.Tag = "currentEqp";
            this.lblEquipment.Text = "EquipmentId";
            // 
            // lblLotId
            // 
            this.lblLotId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLotId.AutoSize = true;
            this.lblLotId.Location = new System.Drawing.Point(377, 11);
            this.lblLotId.Name = "lblLotId";
            this.lblLotId.Size = new System.Drawing.Size(48, 16);
            this.lblLotId.TabIndex = 0;
            this.lblLotId.Tag = "lotId";
            this.lblLotId.Text = "LotId";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClear.Location = new System.Drawing.Point(715, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.TabStop = false;
            this.btnClear.Tag = "buttonClear";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(645, 18);
            this.label6.TabIndex = 18;
            this.label6.Tag = "CartonId";
            this.label6.Text = "箱號";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 304);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1113, 3);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 307);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1113, 60);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRight.Location = new System.Drawing.Point(0, 535);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1113, 71);
            this.pnlRight.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlStepDC);
            this.panel1.Controls.Add(this.pnlCurrWorkInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 209);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvwCartonInfo);
            this.panel3.Controls.Add(this.tblCarton);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 209);
            this.panel3.TabIndex = 1;
            // 
            // lvwCartonInfo
            // 
            this.lvwCartonInfo.allowUserFilter = false;
            this.lvwCartonInfo.allowUserSorting = false;
            this.lvwCartonInfo.autoSizeColumn = true;
            this.lvwCartonInfo.careModifyDate = false;
            this.lvwCartonInfo.columnHide = null;
            this.lvwCartonInfo.columnNames = new string[] {
        "name",
        "productId",
        "orderId",
        "Count",
        "location",
        "status"};
            this.lvwCartonInfo.columnTags = new string[] {
        "cartonId",
        "productId",
        "orderId",
        "quantity",
        "location",
        "status"};
            this.lvwCartonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCartonInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwCartonInfo.FullRowSelect = true;
            this.lvwCartonInfo.HideSelection = false;
            this.lvwCartonInfo.imageKeyColumn = "";
            this.lvwCartonInfo.keyPressSearch = false;
            this.lvwCartonInfo.keyPressSearchColumn = "";
            this.lvwCartonInfo.Location = new System.Drawing.Point(0, 84);
            this.lvwCartonInfo.makesureNewItemVisible = true;
            this.lvwCartonInfo.MultiSelect = false;
            this.lvwCartonInfo.Name = "lvwCartonInfo";
            this.lvwCartonInfo.OwnerDraw = true;
            this.lvwCartonInfo.ShowItemTipSecond = ((byte)(3));
            this.lvwCartonInfo.Size = new System.Drawing.Size(645, 125);
            this.lvwCartonInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwCartonInfo.TabIndex = 19;
            this.lvwCartonInfo.UseCompatibleStateImageBehavior = false;
            this.lvwCartonInfo.View = System.Windows.Forms.View.Details;
            this.lvwCartonInfo.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwCartonInfo_MESItemSelectionChanged);
            // 
            // tblCarton
            // 
            this.tblCarton.AutoSize = true;
            this.tblCarton.ColumnCount = 7;
            this.tblCarton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCarton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCarton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCarton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCarton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCarton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCarton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCarton.Controls.Add(this.btnRefreshOrder, 6, 0);
            this.tblCarton.Controls.Add(this.lblOrderId, 2, 0);
            this.tblCarton.Controls.Add(this.cboOrderId, 3, 0);
            this.tblCarton.Controls.Add(this.btnForcePack, 4, 1);
            this.tblCarton.Controls.Add(this.btnRemove, 3, 1);
            this.tblCarton.Controls.Add(this.btnAddCarton, 2, 1);
            this.tblCarton.Controls.Add(this.txtCartonId, 1, 1);
            this.tblCarton.Controls.Add(this.lblCartonId, 0, 1);
            this.tblCarton.Controls.Add(this.txtProductId, 1, 0);
            this.tblCarton.Controls.Add(this.lblProductId, 0, 0);
            this.tblCarton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCarton.Location = new System.Drawing.Point(0, 18);
            this.tblCarton.Name = "tblCarton";
            this.tblCarton.RowCount = 2;
            this.tblCarton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCarton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCarton.Size = new System.Drawing.Size(645, 66);
            this.tblCarton.TabIndex = 19;
            // 
            // btnRefreshOrder
            // 
            this.btnRefreshOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefreshOrder.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefreshOrder.Location = new System.Drawing.Point(591, 4);
            this.btnRefreshOrder.Name = "btnRefreshOrder";
            this.btnRefreshOrder.Size = new System.Drawing.Size(25, 23);
            this.btnRefreshOrder.TabIndex = 14;
            this.btnRefreshOrder.Text = "7";
            this.btnRefreshOrder.UseVisualStyleBackColor = true;
            this.btnRefreshOrder.Click += new System.EventHandler(this.btnRefreshOrder_Click);
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(326, 8);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(64, 16);
            this.lblOrderId.TabIndex = 22;
            this.lblOrderId.Tag = "orderId";
            this.lblOrderId.Text = "orderId";
            // 
            // cboOrderId
            // 
            this.cboOrderId.BackColor = System.Drawing.SystemColors.Info;
            this.tblCarton.SetColumnSpan(this.cboOrderId, 2);
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboOrderId.Location = new System.Drawing.Point(400, 4);
            this.cboOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(185, 24);
            this.cboOrderId.TabIndex = 20;
            this.cboOrderId.SelectedIndexChanged += new System.EventHandler(this.cboOrderId_SelectedIndexChanged);
            // 
            // btnForcePack
            // 
            this.btnForcePack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnForcePack.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForcePack.Location = new System.Drawing.Point(474, 35);
            this.btnForcePack.Name = "btnForcePack";
            this.btnForcePack.Size = new System.Drawing.Size(80, 28);
            this.btnForcePack.TabIndex = 6;
            this.btnForcePack.Tag = "buttonForcePack";
            this.btnForcePack.Text = "Pack";
            this.btnForcePack.UseVisualStyleBackColor = true;
            this.btnForcePack.Click += new System.EventHandler(this.btnForcePack_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(400, 35);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 28);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Tag = "buttonDelete";
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddCarton
            // 
            this.btnAddCarton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCarton.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCarton.Location = new System.Drawing.Point(326, 35);
            this.btnAddCarton.Name = "btnAddCarton";
            this.btnAddCarton.Size = new System.Drawing.Size(68, 28);
            this.btnAddCarton.TabIndex = 4;
            this.btnAddCarton.Tag = "buttonAdd";
            this.btnAddCarton.Text = "Add";
            this.btnAddCarton.UseVisualStyleBackColor = true;
            this.btnAddCarton.Click += new System.EventHandler(this.btnAddCarton_Click);
            // 
            // txtCartonId
            // 
            this.txtCartonId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCartonId.BackColor = System.Drawing.SystemColors.Info;
            this.txtCartonId.CheckInputChar = false;
            this.txtCartonId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCartonId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCartonId.Location = new System.Drawing.Point(89, 36);
            this.txtCartonId.MaxLength = 40;
            this.txtCartonId.Name = "txtCartonId";
            this.txtCartonId.ShowPopupMessage = false;
            this.txtCartonId.Size = new System.Drawing.Size(231, 26);
            this.txtCartonId.TabIndex = 1;
            this.txtCartonId.TimeOutMilliseconds = ((long)(500));
            this.txtCartonId.ToolTipFontSize = 11.25F;
            // 
            // lblCartonId
            // 
            this.lblCartonId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCartonId.AutoSize = true;
            this.lblCartonId.Location = new System.Drawing.Point(3, 41);
            this.lblCartonId.Name = "lblCartonId";
            this.lblCartonId.Size = new System.Drawing.Size(72, 16);
            this.lblCartonId.TabIndex = 20;
            this.lblCartonId.Tag = "cartonId";
            this.lblCartonId.Text = "CartonId";
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductId.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtProductId.Location = new System.Drawing.Point(89, 3);
            this.txtProductId.MaxLength = 40;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(231, 26);
            this.txtProductId.TabIndex = 0;
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(3, 8);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(80, 16);
            this.lblProductId.TabIndex = 21;
            this.lblProductId.Tag = "productId";
            this.lblProductId.Text = "ProductId";
            // 
            // pnlStepDC
            // 
            this.pnlStepDC.Controls.Add(this.stepDC1);
            this.pnlStepDC.Controls.Add(this.label2);
            this.pnlStepDC.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStepDC.Location = new System.Drawing.Point(645, 0);
            this.pnlStepDC.Name = "pnlStepDC";
            this.pnlStepDC.Size = new System.Drawing.Size(189, 209);
            this.pnlStepDC.TabIndex = 0;
            // 
            // stepDC1
            // 
            this.stepDC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepDC1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepDC1.Location = new System.Drawing.Point(0, 18);
            this.stepDC1.Margin = new System.Windows.Forms.Padding(4);
            this.stepDC1.Name = "stepDC1";
            this.stepDC1.Size = new System.Drawing.Size(189, 191);
            this.stepDC1.TabIndex = 17;
            this.stepDC1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 19;
            this.label2.Tag = "stepDC";
            this.label2.Text = "站點資料收集";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCurrWorkInfo
            // 
            this.pnlCurrWorkInfo.Controls.Add(this.taWorkInformation1);
            this.pnlCurrWorkInfo.Controls.Add(this.label3);
            this.pnlCurrWorkInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCurrWorkInfo.Location = new System.Drawing.Point(834, 0);
            this.pnlCurrWorkInfo.Name = "pnlCurrWorkInfo";
            this.pnlCurrWorkInfo.Size = new System.Drawing.Size(279, 209);
            this.pnlCurrWorkInfo.TabIndex = 2;
            // 
            // taWorkInformation1
            // 
            this.taWorkInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taWorkInformation1.Location = new System.Drawing.Point(0, 18);
            this.taWorkInformation1.Name = "taWorkInformation1";
            this.taWorkInformation1.Size = new System.Drawing.Size(279, 191);
            this.taWorkInformation1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 18);
            this.label3.TabIndex = 20;
            this.label3.Tag = "currentTaWorkInfo";
            this.label3.Text = "當前作業人員";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwLotInfo);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 367);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1113, 168);
            this.pnlMain.TabIndex = 23;
            // 
            // lvwLotInfo
            // 
            this.lvwLotInfo.allowUserFilter = false;
            this.lvwLotInfo.allowUserSorting = false;
            this.lvwLotInfo.autoSizeColumn = true;
            this.lvwLotInfo.careModifyDate = false;
            this.lvwLotInfo.columnHide = null;
            this.lvwLotInfo.columnNames = new string[] {
        "name",
        "productId",
        "orderId",
        "lotType",
        "stepId",
        "status",
        "quantity"};
            this.lvwLotInfo.columnTags = new string[] {
        "lotId",
        "productId",
        "orderId",
        "lotType",
        "stepId",
        "status",
        "quantity"};
            this.lvwLotInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLotInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwLotInfo.FullRowSelect = true;
            this.lvwLotInfo.HideSelection = false;
            this.lvwLotInfo.imageKeyColumn = "";
            this.lvwLotInfo.keyPressSearch = false;
            this.lvwLotInfo.keyPressSearchColumn = "";
            this.lvwLotInfo.Location = new System.Drawing.Point(0, 18);
            this.lvwLotInfo.makesureNewItemVisible = true;
            this.lvwLotInfo.MultiSelect = false;
            this.lvwLotInfo.Name = "lvwLotInfo";
            this.lvwLotInfo.OwnerDraw = true;
            this.lvwLotInfo.ShowItemTipSecond = ((byte)(3));
            this.lvwLotInfo.Size = new System.Drawing.Size(1113, 150);
            this.lvwLotInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwLotInfo.TabIndex = 20;
            this.lvwLotInfo.UseCompatibleStateImageBehavior = false;
            this.lvwLotInfo.View = System.Windows.Forms.View.Details;
            this.lvwLotInfo.DoubleClick += new System.EventHandler(this.lvwLotInfo_DoubleClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1113, 18);
            this.label4.TabIndex = 19;
            this.label4.Tag = "lotInformation";
            this.label4.Text = "批號信息";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDisplayMessage
            // 
            this.pnlDisplayMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplayMessage.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplayMessage.Name = "pnlDisplayMessage";
            this.pnlDisplayMessage.Size = new System.Drawing.Size(1113, 50);
            this.pnlDisplayMessage.TabIndex = 24;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1113, 606);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblGetLot);
            this.Controls.Add(this.pnlDisplayMessage);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "CartonPacking";
            this.Text = "CartonPacking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tblGetLot.ResumeLayout(false);
            this.tblGetLot.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tblCarton.ResumeLayout(false);
            this.tblCarton.PerformLayout();
            this.pnlStepDC.ResumeLayout(false);
            this.pnlCurrWorkInfo.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblGetLot;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Button btnGetLot;
        private System.Windows.Forms.Label lblLotId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlStepDC;
        private System.Windows.Forms.Label label2;
        private mesRelease.Controls.StepDC stepDC1;
        private System.Windows.Forms.TextBox txtLotStatus;
        private System.Windows.Forms.Panel pnlCurrWorkInfo;
        private mesRelease.Controls.TaWorkInformation taWorkInformation1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMain;
        private idv.mesCore.Controls.BarcodeTextBox txtLotId;
        private System.Windows.Forms.Panel pnlDisplayMessage;
        private System.Windows.Forms.ComboBox cboEquipmentId;
        private System.Windows.Forms.Label label4;
        private idv.mesCore.Controls.MESListView lvwLotInfo;
        private idv.mesCore.Controls.MESListView lvwCartonInfo;
        private System.Windows.Forms.TableLayoutPanel tblCarton;
        private System.Windows.Forms.Button btnExit;
        private idv.mesCore.Controls.BarcodeTextBox txtCartonId;
        private System.Windows.Forms.Label lblCartonId;
        private System.Windows.Forms.Button btnAddCarton;
        private System.Windows.Forms.Button btnForcePack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnRefreshOrder;
        private System.Windows.Forms.Button btnClear;

    }
}