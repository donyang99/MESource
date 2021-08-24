namespace ClientRule.FutureHoldSet
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
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.tclTargetKind = new System.Windows.Forms.TabControl();
            this.tabLot = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLotId = new System.Windows.Forms.Label();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.tabRoute = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTiming = new System.Windows.Forms.Label();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.cboTiming = new System.Windows.Forms.ComboBox();
            this.lblHoldReason = new System.Windows.Forms.Label();
            this.cboHoldReason = new System.Windows.Forms.ComboBox();
            this.lvwFutureHold = new idv.mesCore.Controls.MESListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tclTargetKind.SuspendLayout();
            this.tabLot.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabRoute.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 508);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(711, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(711, 25);
            this.actionToolbar1.TabIndex = 9;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // tclTargetKind
            // 
            this.tclTargetKind.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tclTargetKind.Controls.Add(this.tabLot);
            this.tclTargetKind.Controls.Add(this.tabOrder);
            this.tclTargetKind.Controls.Add(this.tabProduct);
            this.tclTargetKind.Controls.Add(this.tabRoute);
            this.tclTargetKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclTargetKind.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tclTargetKind.ItemSize = new System.Drawing.Size(195, 21);
            this.tclTargetKind.Location = new System.Drawing.Point(2, 19);
            this.tclTargetKind.Name = "tclTargetKind";
            this.tclTargetKind.SelectedIndex = 0;
            this.tclTargetKind.Size = new System.Drawing.Size(707, 69);
            this.tclTargetKind.TabIndex = 11;
            // 
            // tabLot
            // 
            this.tabLot.Controls.Add(this.tableLayoutPanel2);
            this.tabLot.Location = new System.Drawing.Point(4, 25);
            this.tabLot.Name = "tabLot";
            this.tabLot.Padding = new System.Windows.Forms.Padding(3);
            this.tabLot.Size = new System.Drawing.Size(699, 40);
            this.tabLot.TabIndex = 0;
            this.tabLot.Tag = "lotId";
            this.tabLot.Text = "Lot";
            this.tabLot.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblLotId, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLotId, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 34);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // lblLotId
            // 
            this.lblLotId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLotId.AutoSize = true;
            this.lblLotId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLotId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLotId.Location = new System.Drawing.Point(3, 8);
            this.lblLotId.Name = "lblLotId";
            this.lblLotId.Size = new System.Drawing.Size(50, 18);
            this.lblLotId.TabIndex = 0;
            this.lblLotId.Tag = "lotId";
            this.lblLotId.Text = "lotId";
            this.lblLotId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotId.BackColor = System.Drawing.SystemColors.Info;
            this.txtLotId.Location = new System.Drawing.Point(59, 4);
            this.txtLotId.MaxLength = 40;
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(220, 26);
            this.txtLotId.TabIndex = 0;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.tableLayoutPanel3);
            this.tabOrder.Location = new System.Drawing.Point(4, 25);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(699, 40);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Tag = "order";
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cboOrderId, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblOrderId, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(282, 34);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // cboOrderId
            // 
            this.cboOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboOrderId.BackColor = System.Drawing.SystemColors.Info;
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(75, 5);
            this.cboOrderId.MaxDropDownItems = 20;
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(204, 24);
            this.cboOrderId.Sorted = true;
            this.cboOrderId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrderId.Location = new System.Drawing.Point(3, 8);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(66, 18);
            this.lblOrderId.TabIndex = 6;
            this.lblOrderId.Tag = "orderId";
            this.lblOrderId.Text = "orderId";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.tableLayoutPanel4);
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(699, 40);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Tag = "product";
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cboProduct, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblProductId, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(282, 34);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboProduct.BackColor = System.Drawing.SystemColors.Info;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(91, 7);
            this.cboProduct.MaxDropDownItems = 20;
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(188, 24);
            this.cboProduct.Sorted = true;
            this.cboProduct.TabIndex = 2;
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProductId.AutoSize = true;
            this.lblProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductId.Location = new System.Drawing.Point(3, 8);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(82, 18);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Tag = "productId";
            this.lblProductId.Text = "productId";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabRoute
            // 
            this.tabRoute.Controls.Add(this.tableLayoutPanel1);
            this.tabRoute.Location = new System.Drawing.Point(4, 25);
            this.tabRoute.Name = "tabRoute";
            this.tabRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoute.Size = new System.Drawing.Size(699, 40);
            this.tabRoute.TabIndex = 3;
            this.tabRoute.Tag = "route";
            this.tabRoute.Text = "Route";
            this.tabRoute.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboRoute, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRouteId, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 34);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // cboRoute
            // 
            this.cboRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboRoute.BackColor = System.Drawing.SystemColors.Info;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(75, 7);
            this.cboRoute.MaxDropDownItems = 20;
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(204, 24);
            this.cboRoute.Sorted = true;
            this.cboRoute.TabIndex = 3;
            // 
            // lblRouteId
            // 
            this.lblRouteId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRouteId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRouteId.Location = new System.Drawing.Point(3, 8);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(66, 18);
            this.lblRouteId.TabIndex = 2;
            this.lblRouteId.Tag = "routeId";
            this.lblRouteId.Text = "routeId";
            this.lblRouteId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tclTargetKind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(711, 90);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "target";
            this.groupBox1.Text = "target";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(634, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(711, 88);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblTiming, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dtExpireDate, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtStartDate, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.cboStepId, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblStep, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cboTiming, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblHoldReason, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.cboHoldReason, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(700, 63);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // lblTiming
            // 
            this.lblTiming.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTiming.AutoSize = true;
            this.lblTiming.Location = new System.Drawing.Point(3, 37);
            this.lblTiming.Name = "lblTiming";
            this.lblTiming.Size = new System.Drawing.Size(56, 16);
            this.lblTiming.TabIndex = 18;
            this.lblTiming.Tag = "timing";
            this.lblTiming.Text = "timing";
            this.lblTiming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtExpireDate.CustomFormat = "yyyy/MM/dd";
            this.dtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpireDate.Location = new System.Drawing.Point(562, 3);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(135, 26);
            this.dtExpireDate.TabIndex = 17;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStartDate.CustomFormat = "yyyy/MM/dd";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(327, 3);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(135, 26);
            this.dtStartDate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 18;
            this.label5.Tag = "expireDate";
            this.label5.Text = "expireDate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 17;
            this.label1.Tag = "startDate";
            this.label1.Text = "startDate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStepId
            // 
            this.cboStepId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStepId.BackColor = System.Drawing.SystemColors.Info;
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(65, 3);
            this.cboStepId.MaxDropDownItems = 20;
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(162, 24);
            this.cboStepId.Sorted = true;
            this.cboStepId.TabIndex = 4;
            this.cboStepId.SelectedIndexChanged += new System.EventHandler(this.cboStepId_SelectedIndexChanged);
            // 
            // lblStep
            // 
            this.lblStep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStep.AutoSize = true;
            this.lblStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep.Location = new System.Drawing.Point(3, 7);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(42, 18);
            this.lblStep.TabIndex = 16;
            this.lblStep.Tag = "step";
            this.lblStep.Text = "step";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTiming
            // 
            this.cboTiming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTiming.BackColor = System.Drawing.SystemColors.Info;
            this.cboTiming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiming.FormattingEnabled = true;
            this.cboTiming.Location = new System.Drawing.Point(65, 35);
            this.cboTiming.MaxDropDownItems = 20;
            this.cboTiming.Name = "cboTiming";
            this.cboTiming.Size = new System.Drawing.Size(162, 24);
            this.cboTiming.TabIndex = 19;
            // 
            // lblHoldReason
            // 
            this.lblHoldReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHoldReason.AutoSize = true;
            this.lblHoldReason.Location = new System.Drawing.Point(233, 37);
            this.lblHoldReason.Name = "lblHoldReason";
            this.lblHoldReason.Size = new System.Drawing.Size(88, 16);
            this.lblHoldReason.TabIndex = 20;
            this.lblHoldReason.Tag = "holdReason";
            this.lblHoldReason.Text = "holdReason";
            this.lblHoldReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboHoldReason
            // 
            this.cboHoldReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHoldReason.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel5.SetColumnSpan(this.cboHoldReason, 3);
            this.cboHoldReason.FormattingEnabled = true;
            this.cboHoldReason.Location = new System.Drawing.Point(327, 35);
            this.cboHoldReason.MaxDropDownItems = 20;
            this.cboHoldReason.Name = "cboHoldReason";
            this.cboHoldReason.Size = new System.Drawing.Size(370, 24);
            this.cboHoldReason.Sorted = true;
            this.cboHoldReason.TabIndex = 21;
            // 
            // lvwFutureHold
            // 
            this.lvwFutureHold.allowUserFilter = false;
            this.lvwFutureHold.allowUserSorting = true;
            this.lvwFutureHold.autoSizeColumn = true;
            this.lvwFutureHold.careModifyDate = false;
            this.lvwFutureHold.columnHide = null;
            this.lvwFutureHold.columnNames = new string[] {
        "targetKind",
        "name",
        "stepId",
        "timing",
        "reasonCode",
        "startDate",
        "expireDate"};
            this.lvwFutureHold.columnTags = new string[] {
        "target",
        "name",
        "stepId",
        "timing",
        "holdReason",
        "startDate",
        "expireDate"};
            this.lvwFutureHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFutureHold.FullRowSelect = true;
            this.lvwFutureHold.HideSelection = false;
            this.lvwFutureHold.imageKeyColumn = "";
            this.lvwFutureHold.keyPressSearch = false;
            this.lvwFutureHold.keyPressSearchColumn = "";
            this.lvwFutureHold.Location = new System.Drawing.Point(0, 203);
            this.lvwFutureHold.makesureNewItemVisible = true;
            this.lvwFutureHold.MultiSelect = false;
            this.lvwFutureHold.Name = "lvwFutureHold";
            this.lvwFutureHold.OwnerDraw = true;
            this.lvwFutureHold.ShowItemTipSecond = ((byte)(3));
            this.lvwFutureHold.Size = new System.Drawing.Size(711, 270);
            this.lvwFutureHold.TabIndex = 16;
            this.lvwFutureHold.UseCompatibleStateImageBehavior = false;
            this.lvwFutureHold.View = System.Windows.Forms.View.Details;
            this.lvwFutureHold.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwFutureHold_MESItemSelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 35);
            this.panel1.TabIndex = 17;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(711, 533);
            this.ControlBox = false;
            this.Controls.Add(this.lvwFutureHold);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FutureHoldSet";
            this.Text = "FutureHoldSet";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tclTargetKind.ResumeLayout(false);
            this.tabLot.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabOrder.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabProduct.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabRoute.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.TabControl tclTargetKind;
        private System.Windows.Forms.TabPage tabLot;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.Label lblLotId;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabRoute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblTiming;
        private idv.mesCore.Controls.MESListView lvwFutureHold;
        private System.Windows.Forms.ComboBox cboTiming;
        private System.Windows.Forms.Label lblHoldReason;
        private System.Windows.Forms.ComboBox cboHoldReason;
        private System.Windows.Forms.Panel panel1;

    }
}