namespace ClientRule.Pallet
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
            this.btnGetCarton = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboEquipmentId = new System.Windows.Forms.ComboBox();
            this.txtCartonId = new idv.mesCore.Controls.BarcodeTextBox();
            this.txtCartonStatus = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblCartonId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lvwCartonInfo = new idv.mesCore.Controls.MESListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwLotInfo = new idv.mesCore.Controls.MESListView();
            this.pnlDisplayMessage = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvwPalletInfo = new idv.mesCore.Controls.MESListView();
            this.tblCarton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddPallet = new System.Windows.Forms.Button();
            this.txtPalletId = new idv.mesCore.Controls.BarcodeTextBox();
            this.lblPalletId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPallet = new System.Windows.Forms.Panel();
            this.pnlCartonDetail = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tblGetLot.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tblCarton.SuspendLayout();
            this.pnlPallet.SuspendLayout();
            this.pnlCartonDetail.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1130, 7);
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
            this.tblGetLot.Controls.Add(this.btnGetCarton, 5, 0);
            this.tblGetLot.Controls.Add(this.btnExit, 9, 0);
            this.tblGetLot.Controls.Add(this.cboEquipmentId, 1, 0);
            this.tblGetLot.Controls.Add(this.txtCartonId, 4, 0);
            this.tblGetLot.Controls.Add(this.txtCartonStatus, 7, 0);
            this.tblGetLot.Controls.Add(this.txtState, 2, 0);
            this.tblGetLot.Controls.Add(this.lblEquipment, 0, 0);
            this.tblGetLot.Controls.Add(this.lblCartonId, 3, 0);
            this.tblGetLot.Controls.Add(this.btnClear, 6, 0);
            this.tblGetLot.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblGetLot.Location = new System.Drawing.Point(0, 50);
            this.tblGetLot.Name = "tblGetLot";
            this.tblGetLot.RowCount = 1;
            this.tblGetLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGetLot.Size = new System.Drawing.Size(1130, 38);
            this.tblGetLot.TabIndex = 8;
            // 
            // btnGetCarton
            // 
            this.btnGetCarton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetCarton.Location = new System.Drawing.Point(758, 6);
            this.btnGetCarton.Name = "btnGetCarton";
            this.btnGetCarton.Size = new System.Drawing.Size(58, 25);
            this.btnGetCarton.TabIndex = 2;
            this.btnGetCarton.TabStop = false;
            this.btnGetCarton.Tag = "fetch";
            this.btnGetCarton.Text = "Get";
            this.btnGetCarton.UseVisualStyleBackColor = true;
            this.btnGetCarton.Click += new System.EventHandler(this.btnGetCarton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExit.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(1065, 3);
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
            this.cboEquipmentId.Size = new System.Drawing.Size(201, 24);
            this.cboEquipmentId.TabIndex = 19;
            this.cboEquipmentId.SelectedIndexChanged += new System.EventHandler(this.cboEquipmentId_SelectedIndexChanged);
            // 
            // txtCartonId
            // 
            this.txtCartonId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCartonId.BackColor = System.Drawing.SystemColors.Info;
            this.txtCartonId.CheckInputChar = false;
            this.txtCartonId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCartonId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtCartonId.Location = new System.Drawing.Point(461, 6);
            this.txtCartonId.MaxLength = 40;
            this.txtCartonId.Name = "txtCartonId";
            this.txtCartonId.ShowPopupMessage = false;
            this.txtCartonId.Size = new System.Drawing.Size(291, 26);
            this.txtCartonId.TabIndex = 0;
            this.txtCartonId.TimeOutMilliseconds = ((long)(500));
            this.txtCartonId.ToolTipFontSize = 11.25F;
            this.txtCartonId.BarcodeInput += new idv.mesCore.Controls.BarcodeTextBox.BarcodeInputEventHandler(this.txtCartonId_BarcodeInput);
            // 
            // txtCartonStatus
            // 
            this.txtCartonStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCartonStatus.Location = new System.Drawing.Point(886, 6);
            this.txtCartonStatus.MaxLength = 40;
            this.txtCartonStatus.Name = "txtCartonStatus";
            this.txtCartonStatus.ReadOnly = true;
            this.txtCartonStatus.Size = new System.Drawing.Size(60, 26);
            this.txtCartonStatus.TabIndex = 6;
            this.txtCartonStatus.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtState.Location = new System.Drawing.Point(312, 6);
            this.txtState.MaxLength = 40;
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(65, 26);
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
            // lblCartonId
            // 
            this.lblCartonId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCartonId.AutoSize = true;
            this.lblCartonId.Location = new System.Drawing.Point(383, 11);
            this.lblCartonId.Name = "lblCartonId";
            this.lblCartonId.Size = new System.Drawing.Size(72, 16);
            this.lblCartonId.TabIndex = 0;
            this.lblCartonId.Tag = "CartonId";
            this.lblCartonId.Text = "CartonId";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClear.Location = new System.Drawing.Point(822, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.TabStop = false;
            this.btnClear.Tag = "buttonClear";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 95);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1130, 3);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lvwCartonInfo);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 291);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(732, 242);
            this.pnlMain.TabIndex = 23;
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
        "status"};
            this.lvwCartonInfo.columnTags = new string[] {
        "cartonId",
        "productId",
        "orderId",
        "status"};
            this.lvwCartonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCartonInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwCartonInfo.FullRowSelect = true;
            this.lvwCartonInfo.HideSelection = false;
            this.lvwCartonInfo.imageKeyColumn = "";
            this.lvwCartonInfo.keyPressSearch = false;
            this.lvwCartonInfo.keyPressSearchColumn = "";
            this.lvwCartonInfo.Location = new System.Drawing.Point(0, 18);
            this.lvwCartonInfo.makesureNewItemVisible = true;
            this.lvwCartonInfo.MultiSelect = false;
            this.lvwCartonInfo.Name = "lvwCartonInfo";
            this.lvwCartonInfo.OwnerDraw = true;
            this.lvwCartonInfo.ShowItemTipSecond = ((byte)(3));
            this.lvwCartonInfo.Size = new System.Drawing.Size(732, 224);
            this.lvwCartonInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwCartonInfo.TabIndex = 19;
            this.lvwCartonInfo.UseCompatibleStateImageBehavior = false;
            this.lvwCartonInfo.View = System.Windows.Forms.View.Details;
            this.lvwCartonInfo.DoubleClick += new System.EventHandler(this.lvwCartonInfo_DoubleClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(732, 18);
            this.label4.TabIndex = 19;
            this.label4.Tag = "CartonId";
            this.label4.Text = "CartonId";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        "stepId",
        "status"};
            this.lvwLotInfo.columnTags = new string[] {
        "lotId",
        "productId",
        "orderId",
        "stepId",
        "status"};
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
            this.lvwLotInfo.Size = new System.Drawing.Size(393, 417);
            this.lvwLotInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwLotInfo.TabIndex = 20;
            this.lvwLotInfo.UseCompatibleStateImageBehavior = false;
            this.lvwLotInfo.View = System.Windows.Forms.View.Details;
            // 
            // pnlDisplayMessage
            // 
            this.pnlDisplayMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplayMessage.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplayMessage.Name = "pnlDisplayMessage";
            this.pnlDisplayMessage.Size = new System.Drawing.Size(1130, 50);
            this.pnlDisplayMessage.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvwPalletInfo);
            this.panel3.Controls.Add(this.tblCarton);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 193);
            this.panel3.TabIndex = 1;
            // 
            // lvwPalletInfo
            // 
            this.lvwPalletInfo.allowUserFilter = false;
            this.lvwPalletInfo.allowUserSorting = false;
            this.lvwPalletInfo.autoSizeColumn = true;
            this.lvwPalletInfo.careModifyDate = false;
            this.lvwPalletInfo.columnHide = null;
            this.lvwPalletInfo.columnNames = new string[] {
        "name",
        "productId",
        "orderId",
        "status"};
            this.lvwPalletInfo.columnTags = new string[] {
        "palletId",
        "productId",
        "orderId",
        "status"};
            this.lvwPalletInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwPalletInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwPalletInfo.FullRowSelect = true;
            this.lvwPalletInfo.HideSelection = false;
            this.lvwPalletInfo.imageKeyColumn = "";
            this.lvwPalletInfo.keyPressSearch = false;
            this.lvwPalletInfo.keyPressSearchColumn = "";
            this.lvwPalletInfo.Location = new System.Drawing.Point(0, 52);
            this.lvwPalletInfo.makesureNewItemVisible = true;
            this.lvwPalletInfo.MultiSelect = false;
            this.lvwPalletInfo.Name = "lvwPalletInfo";
            this.lvwPalletInfo.OwnerDraw = true;
            this.lvwPalletInfo.ShowItemTipSecond = ((byte)(3));
            this.lvwPalletInfo.Size = new System.Drawing.Size(732, 141);
            this.lvwPalletInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwPalletInfo.TabIndex = 20;
            this.lvwPalletInfo.UseCompatibleStateImageBehavior = false;
            this.lvwPalletInfo.View = System.Windows.Forms.View.Details;
            this.lvwPalletInfo.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwPalletInfo_MESItemSelectionChanged);
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
            this.tblCarton.Controls.Add(this.btnOK, 4, 0);
            this.tblCarton.Controls.Add(this.btnRemove, 3, 0);
            this.tblCarton.Controls.Add(this.btnAddPallet, 2, 0);
            this.tblCarton.Controls.Add(this.txtPalletId, 1, 0);
            this.tblCarton.Controls.Add(this.lblPalletId, 0, 0);
            this.tblCarton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCarton.Location = new System.Drawing.Point(0, 18);
            this.tblCarton.Name = "tblCarton";
            this.tblCarton.RowCount = 1;
            this.tblCarton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCarton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCarton.Size = new System.Drawing.Size(732, 34);
            this.tblCarton.TabIndex = 19;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOK.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Location = new System.Drawing.Point(514, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(440, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 28);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Tag = "buttonDelete";
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddPallet
            // 
            this.btnAddPallet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddPallet.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddPallet.Location = new System.Drawing.Point(366, 3);
            this.btnAddPallet.Name = "btnAddPallet";
            this.btnAddPallet.Size = new System.Drawing.Size(68, 28);
            this.btnAddPallet.TabIndex = 4;
            this.btnAddPallet.Tag = "buttonAdd";
            this.btnAddPallet.Text = "Add";
            this.btnAddPallet.UseVisualStyleBackColor = true;
            this.btnAddPallet.Click += new System.EventHandler(this.btnAddPallet_Click);
            // 
            // txtPalletId
            // 
            this.txtPalletId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPalletId.BackColor = System.Drawing.SystemColors.Info;
            this.txtPalletId.CheckInputChar = false;
            this.txtPalletId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPalletId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPalletId.Location = new System.Drawing.Point(81, 4);
            this.txtPalletId.MaxLength = 40;
            this.txtPalletId.Name = "txtPalletId";
            this.txtPalletId.ShowPopupMessage = false;
            this.txtPalletId.Size = new System.Drawing.Size(279, 26);
            this.txtPalletId.TabIndex = 1;
            this.txtPalletId.TimeOutMilliseconds = ((long)(500));
            this.txtPalletId.ToolTipFontSize = 11.25F;
            this.txtPalletId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPalletId_KeyUp);
            // 
            // lblPalletId
            // 
            this.lblPalletId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPalletId.AutoSize = true;
            this.lblPalletId.Location = new System.Drawing.Point(3, 9);
            this.lblPalletId.Name = "lblPalletId";
            this.lblPalletId.Size = new System.Drawing.Size(72, 16);
            this.lblPalletId.TabIndex = 20;
            this.lblPalletId.Tag = "palletId";
            this.lblPalletId.Text = "PalletId";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(732, 18);
            this.label6.TabIndex = 18;
            this.label6.Tag = "palletId";
            this.label6.Text = "棧板號";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPallet
            // 
            this.pnlPallet.Controls.Add(this.panel3);
            this.pnlPallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPallet.Location = new System.Drawing.Point(0, 98);
            this.pnlPallet.Name = "pnlPallet";
            this.pnlPallet.Size = new System.Drawing.Size(732, 193);
            this.pnlPallet.TabIndex = 22;
            // 
            // pnlCartonDetail
            // 
            this.pnlCartonDetail.Controls.Add(this.lvwLotInfo);
            this.pnlCartonDetail.Controls.Add(this.label2);
            this.pnlCartonDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCartonDetail.Location = new System.Drawing.Point(737, 98);
            this.pnlCartonDetail.Name = "pnlCartonDetail";
            this.pnlCartonDetail.Size = new System.Drawing.Size(393, 435);
            this.pnlCartonDetail.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 18);
            this.label2.TabIndex = 20;
            this.label2.Tag = "lotInformation";
            this.label2.Text = "批號信息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(732, 98);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 435);
            this.splitter2.TabIndex = 26;
            this.splitter2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1130, 533);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlPallet);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlCartonDetail);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblGetLot);
            this.Controls.Add(this.pnlDisplayMessage);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Pallet";
            this.Text = "Pallet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tblGetLot.ResumeLayout(false);
            this.tblGetLot.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tblCarton.ResumeLayout(false);
            this.tblCarton.PerformLayout();
            this.pnlPallet.ResumeLayout(false);
            this.pnlCartonDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblGetLot;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Button btnGetCarton;
        private System.Windows.Forms.Label lblCartonId;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtCartonStatus;
        private System.Windows.Forms.Panel pnlMain;
        private idv.mesCore.Controls.BarcodeTextBox txtCartonId;
        private System.Windows.Forms.Panel pnlDisplayMessage;
        private System.Windows.Forms.ComboBox cboEquipmentId;
        private System.Windows.Forms.Label label4;
        private idv.mesCore.Controls.MESListView lvwLotInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private idv.mesCore.Controls.MESListView lvwCartonInfo;
        private System.Windows.Forms.TableLayoutPanel tblCarton;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddPallet;
        private idv.mesCore.Controls.BarcodeTextBox txtPalletId;
        private System.Windows.Forms.Label lblPalletId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlPallet;
        private System.Windows.Forms.Panel pnlCartonDetail;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label2;
        private idv.mesCore.Controls.MESListView lvwPalletInfo;

    }
}