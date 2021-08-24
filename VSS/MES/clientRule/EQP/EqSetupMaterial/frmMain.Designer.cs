namespace ClientRule.EqSetupMaterial
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tblTarget = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblStepId = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lvwSetupMaterial = new idv.mesCore.Controls.MESListView();
            this.pnlSetupMaterial = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblMaterialInfo = new System.Windows.Forms.TableLayoutPanel();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblMaterialPartNo = new System.Windows.Forms.Label();
            this.lblMaterialLotId = new System.Windows.Forms.Label();
            this.txtMaterialType = new System.Windows.Forms.TextBox();
            this.txtMaterialPartNo = new System.Windows.Forms.TextBox();
            this.txtMaterialLotId = new System.Windows.Forms.TextBox();
            this.lblMaterialQty = new System.Windows.Forms.Label();
            this.txtMaterialQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tblTarget.SuspendLayout();
            this.pnlSetupMaterial.SuspendLayout();
            this.tblMaterialInfo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(878, 473);
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
            this.equipmentInformation1.Name = "equipmentInformation1";
            this.equipmentInformation1.ShowPopupMessage = false;
            this.equipmentInformation1.Size = new System.Drawing.Size(213, 451);
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tblTarget);
            this.splitContainer2.Panel1.Controls.Add(this.lblTarget);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvwSetupMaterial);
            this.splitContainer2.Panel2.Controls.Add(this.pnlSetupMaterial);
            this.splitContainer2.Panel2.Controls.Add(this.tblMaterialInfo);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Size = new System.Drawing.Size(661, 438);
            this.splitContainer2.SplitterDistance = 95;
            this.splitContainer2.TabIndex = 6;
            // 
            // tblTarget
            // 
            this.tblTarget.ColumnCount = 5;
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTarget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTarget.Controls.Add(this.btnClearOrder, 3, 2);
            this.tblTarget.Controls.Add(this.btnConfirmOrder, 2, 2);
            this.tblTarget.Controls.Add(this.cboOrderId, 1, 2);
            this.tblTarget.Controls.Add(this.cboStepId, 1, 1);
            this.tblTarget.Controls.Add(this.lblOrderId, 0, 2);
            this.tblTarget.Controls.Add(this.lblStepId, 0, 1);
            this.tblTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTarget.Location = new System.Drawing.Point(0, 22);
            this.tblTarget.Name = "tblTarget";
            this.tblTarget.RowCount = 4;
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTarget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTarget.Size = new System.Drawing.Size(661, 73);
            this.tblTarget.TabIndex = 7;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearOrder.Enabled = false;
            this.btnClearOrder.Location = new System.Drawing.Point(350, 37);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(59, 24);
            this.btnClearOrder.TabIndex = 1;
            this.btnClearOrder.Tag = "buttonClear";
            this.btnClearOrder.Text = "Clear";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(285, 37);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(59, 24);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Tag = "buttonOK";
            this.btnConfirmOrder.Text = "OK";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // cboOrderId
            // 
            this.cboOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(73, 37);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(206, 24);
            this.cboOrderId.Sorted = true;
            this.cboOrderId.TabIndex = 1;
            this.cboOrderId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboOrderId_KeyUp);
            // 
            // cboStepId
            // 
            this.cboStepId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStepId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(73, 11);
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(206, 24);
            this.cboStepId.Sorted = true;
            this.cboStepId.TabIndex = 0;
            this.cboStepId.SelectedIndexChanged += new System.EventHandler(this.cboStepId_SelectedIndexChanged);
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(3, 41);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(64, 16);
            this.lblOrderId.TabIndex = 10;
            this.lblOrderId.Tag = "orderId";
            this.lblOrderId.Text = "orderId";
            // 
            // lblStepId
            // 
            this.lblStepId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStepId.AutoSize = true;
            this.lblStepId.Location = new System.Drawing.Point(3, 13);
            this.lblStepId.Name = "lblStepId";
            this.lblStepId.Size = new System.Drawing.Size(56, 16);
            this.lblStepId.TabIndex = 9;
            this.lblStepId.Tag = "stepId";
            this.lblStepId.Text = "stepId";
            // 
            // lblTarget
            // 
            this.lblTarget.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarget.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTarget.Location = new System.Drawing.Point(0, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(661, 22);
            this.lblTarget.TabIndex = 6;
            this.lblTarget.Tag = "target";
            this.lblTarget.Text = "Target";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwSetupMaterial
            // 
            this.lvwSetupMaterial.allowUserFilter = false;
            this.lvwSetupMaterial.allowUserSorting = false;
            this.lvwSetupMaterial.autoSizeColumn = true;
            this.lvwSetupMaterial.careModifyDate = false;
            this.lvwSetupMaterial.CheckBoxes = true;
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
            this.lvwSetupMaterial.Location = new System.Drawing.Point(0, 70);
            this.lvwSetupMaterial.makesureNewItemVisible = true;
            this.lvwSetupMaterial.MultiSelect = false;
            this.lvwSetupMaterial.Name = "lvwSetupMaterial";
            this.lvwSetupMaterial.OwnerDraw = true;
            this.lvwSetupMaterial.ShowItemTipSecond = ((byte)(3));
            this.lvwSetupMaterial.showRowNum = false;
            this.lvwSetupMaterial.Size = new System.Drawing.Size(606, 269);
            this.lvwSetupMaterial.TabIndex = 15;
            this.lvwSetupMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwSetupMaterial.View = System.Windows.Forms.View.Details;
            this.lvwSetupMaterial.wndProcIgnoreError = false;
            this.lvwSetupMaterial.MESItemCheckChanged += new idv.mesCore.Controls.MESListView.delMESItemCheckChanged(this.lvwSetupMaterial_MESItemCheckChanged);
            // 
            // pnlSetupMaterial
            // 
            this.pnlSetupMaterial.Controls.Add(this.btnDelete);
            this.pnlSetupMaterial.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSetupMaterial.Location = new System.Drawing.Point(606, 70);
            this.pnlSetupMaterial.Name = "pnlSetupMaterial";
            this.pnlSetupMaterial.Size = new System.Drawing.Size(55, 269);
            this.pnlSetupMaterial.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 24);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Tag = "EqSetupClear";
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tblMaterialInfo
            // 
            this.tblMaterialInfo.AutoSize = true;
            this.tblMaterialInfo.ColumnCount = 6;
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMaterialInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMaterialInfo.Controls.Add(this.cboPosition, 0, 1);
            this.tblMaterialInfo.Controls.Add(this.lblPosition, 0, 0);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialType, 1, 0);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialPartNo, 2, 0);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialLotId, 3, 0);
            this.tblMaterialInfo.Controls.Add(this.txtMaterialType, 1, 1);
            this.tblMaterialInfo.Controls.Add(this.txtMaterialPartNo, 2, 1);
            this.tblMaterialInfo.Controls.Add(this.txtMaterialLotId, 3, 1);
            this.tblMaterialInfo.Controls.Add(this.lblMaterialQty, 4, 0);
            this.tblMaterialInfo.Controls.Add(this.txtMaterialQty, 4, 1);
            this.tblMaterialInfo.Controls.Add(this.btnAdd, 5, 1);
            this.tblMaterialInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMaterialInfo.Location = new System.Drawing.Point(0, 22);
            this.tblMaterialInfo.Name = "tblMaterialInfo";
            this.tblMaterialInfo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tblMaterialInfo.RowCount = 2;
            this.tblMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterialInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMaterialInfo.Size = new System.Drawing.Size(661, 48);
            this.tblMaterialInfo.TabIndex = 9;
            // 
            // cboPosition
            // 
            this.cboPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPosition.BackColor = System.Drawing.SystemColors.Info;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(6, 19);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cboPosition.MaxDropDownItems = 20;
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(106, 24);
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
            // lblMaterialType
            // 
            this.lblMaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Location = new System.Drawing.Point(115, 0);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(104, 16);
            this.lblMaterialType.TabIndex = 0;
            this.lblMaterialType.Tag = "materialType";
            this.lblMaterialType.Text = "materialType";
            // 
            // lblMaterialPartNo
            // 
            this.lblMaterialPartNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialPartNo.AutoSize = true;
            this.lblMaterialPartNo.Location = new System.Drawing.Point(254, 0);
            this.lblMaterialPartNo.Name = "lblMaterialPartNo";
            this.lblMaterialPartNo.Size = new System.Drawing.Size(120, 16);
            this.lblMaterialPartNo.TabIndex = 1;
            this.lblMaterialPartNo.Tag = "materialPartNo";
            this.lblMaterialPartNo.Text = "materialPartNo";
            // 
            // lblMaterialLotId
            // 
            this.lblMaterialLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialLotId.AutoSize = true;
            this.lblMaterialLotId.Location = new System.Drawing.Point(393, 0);
            this.lblMaterialLotId.Name = "lblMaterialLotId";
            this.lblMaterialLotId.Size = new System.Drawing.Size(112, 16);
            this.lblMaterialLotId.TabIndex = 2;
            this.lblMaterialLotId.Tag = "materialLotId";
            this.lblMaterialLotId.Text = "materialLotId";
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialType.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialType.Enabled = false;
            this.txtMaterialType.Location = new System.Drawing.Point(115, 19);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.Size = new System.Drawing.Size(133, 26);
            this.txtMaterialType.TabIndex = 11;
            // 
            // txtMaterialPartNo
            // 
            this.txtMaterialPartNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialPartNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaterialPartNo.Location = new System.Drawing.Point(254, 19);
            this.txtMaterialPartNo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtMaterialPartNo.MaxLength = 40;
            this.txtMaterialPartNo.Name = "txtMaterialPartNo";
            this.txtMaterialPartNo.Size = new System.Drawing.Size(136, 26);
            this.txtMaterialPartNo.TabIndex = 4;
            this.txtMaterialPartNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaterialPartNo_KeyUp);
            // 
            // txtMaterialLotId
            // 
            this.txtMaterialLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialLotId.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaterialLotId.Location = new System.Drawing.Point(393, 19);
            this.txtMaterialLotId.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtMaterialLotId.MaxLength = 40;
            this.txtMaterialLotId.Name = "txtMaterialLotId";
            this.txtMaterialLotId.Size = new System.Drawing.Size(136, 26);
            this.txtMaterialLotId.TabIndex = 5;
            this.txtMaterialLotId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaterialLotId_KeyUp);
            // 
            // lblMaterialQty
            // 
            this.lblMaterialQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaterialQty.AutoSize = true;
            this.lblMaterialQty.Location = new System.Drawing.Point(532, 0);
            this.lblMaterialQty.Name = "lblMaterialQty";
            this.lblMaterialQty.Size = new System.Drawing.Size(72, 16);
            this.lblMaterialQty.TabIndex = 4;
            this.lblMaterialQty.Tag = "quantity";
            this.lblMaterialQty.Text = "quantity";
            // 
            // txtMaterialQty
            // 
            this.txtMaterialQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialQty.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaterialQty.Location = new System.Drawing.Point(532, 19);
            this.txtMaterialQty.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtMaterialQty.MaxLength = 6;
            this.txtMaterialQty.Name = "txtMaterialQty";
            this.txtMaterialQty.Size = new System.Drawing.Size(75, 26);
            this.txtMaterialQty.TabIndex = 6;
            this.txtMaterialQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtMaterialQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaterialQty_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(610, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 26);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Tag = "add";
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(661, 22);
            this.label5.TabIndex = 6;
            this.label5.Tag = "EqMaterialInfo";
            this.label5.Text = "EqMaterialInfo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(584, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.AutoSize = false;
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 473);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(878, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 498);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "EqSetupMaterial";
            this.Text = "EqSetupMaterial";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tblTarget.ResumeLayout(false);
            this.tblTarget.PerformLayout();
            this.pnlSetupMaterial.ResumeLayout(false);
            this.tblMaterialInfo.ResumeLayout(false);
            this.tblMaterialInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tblMaterialInfo;
        private System.Windows.Forms.Label lblMaterialQty;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblMaterialPartNo;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.TextBox txtMaterialQty;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TextBox txtMaterialPartNo;
        private System.Windows.Forms.Panel pnlSetupMaterial;
        protected internal idv.mesCore.Controls.MESListView lvwSetupMaterial;
        private System.Windows.Forms.Button btnDelete;
        private mesRelease.Controls.EquipmentInformation equipmentInformation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblTarget;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblStepId;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.TextBox txtMaterialType;
        private System.Windows.Forms.Label lblMaterialLotId;
        private System.Windows.Forms.TextBox txtMaterialLotId;
        private System.Windows.Forms.Button btnAdd;

    }
}