namespace ClientRule.CreateOrder
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
            this.tblOrderDetail = new System.Windows.Forms.TableLayoutPanel();
            this.dtpPlanStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStartStep = new System.Windows.Forms.ComboBox();
            this.cboSpecId = new System.Windows.Forms.ComboBox();
            this.lblSpecId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpCustomerDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCustomerId = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.cboOrderType = new System.Windows.Forms.ComboBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblFab = new System.Windows.Forms.Label();
            this.cboFab = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboOwner = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwOrder = new idv.mesCore.Controls.MESListView();
            this.label3 = new System.Windows.Forms.Label();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.tblOrderDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.AutoSize = false;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 590);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(1119, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // tblOrderDetail
            // 
            this.tblOrderDetail.AutoSize = true;
            this.tblOrderDetail.ColumnCount = 11;
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tblOrderDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblOrderDetail.Controls.Add(this.dtpPlanStartDate, 1, 2);
            this.tblOrderDetail.Controls.Add(this.label2, 0, 2);
            this.tblOrderDetail.Controls.Add(this.cboStartStep, 5, 1);
            this.tblOrderDetail.Controls.Add(this.label12, 4, 3);
            this.tblOrderDetail.Controls.Add(this.dtpDueDate, 1, 3);
            this.tblOrderDetail.Controls.Add(this.label10, 0, 3);
            this.tblOrderDetail.Controls.Add(this.cboRoute, 3, 1);
            this.tblOrderDetail.Controls.Add(this.lblRouteId, 2, 1);
            this.tblOrderDetail.Controls.Add(this.lblOrderType, 2, 0);
            this.tblOrderDetail.Controls.Add(this.lblOrderId, 0, 0);
            this.tblOrderDetail.Controls.Add(this.txtOrderId, 1, 0);
            this.tblOrderDetail.Controls.Add(this.cboOrderType, 3, 0);
            this.tblOrderDetail.Controls.Add(this.lblProductId, 0, 1);
            this.tblOrderDetail.Controls.Add(this.cboProduct, 1, 1);
            this.tblOrderDetail.Controls.Add(this.lblFab, 4, 0);
            this.tblOrderDetail.Controls.Add(this.cboFab, 5, 0);
            this.tblOrderDetail.Controls.Add(this.txtRemark, 5, 3);
            this.tblOrderDetail.Controls.Add(this.label1, 4, 1);
            this.tblOrderDetail.Controls.Add(this.lblSpecId, 2, 2);
            this.tblOrderDetail.Controls.Add(this.cboSpecId, 3, 2);
            this.tblOrderDetail.Controls.Add(this.label11, 0, 4);
            this.tblOrderDetail.Controls.Add(this.dtpCustomerDueDate, 1, 4);
            this.tblOrderDetail.Controls.Add(this.label9, 2, 3);
            this.tblOrderDetail.Controls.Add(this.cboCustomerId, 3, 3);
            this.tblOrderDetail.Controls.Add(this.lblStatus, 6, 2);
            this.tblOrderDetail.Controls.Add(this.cboStatus, 7, 2);
            this.tblOrderDetail.Controls.Add(this.label8, 2, 4);
            this.tblOrderDetail.Controls.Add(this.cboOwner, 3, 4);
            this.tblOrderDetail.Controls.Add(this.lblQuantity, 6, 0);
            this.tblOrderDetail.Controls.Add(this.txtQuantity, 7, 0);
            this.tblOrderDetail.Controls.Add(this.label5, 6, 1);
            this.tblOrderDetail.Controls.Add(this.cboPriority, 7, 1);
            this.tblOrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblOrderDetail.Location = new System.Drawing.Point(0, 25);
            this.tblOrderDetail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.tblOrderDetail.Name = "tblOrderDetail";
            this.tblOrderDetail.RowCount = 5;
            this.tblOrderDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrderDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrderDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrderDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrderDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrderDetail.Size = new System.Drawing.Size(1119, 154);
            this.tblOrderDetail.TabIndex = 7;
            // 
            // dtpPlanStartDate
            // 
            this.dtpPlanStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPlanStartDate.Checked = false;
            this.dtpPlanStartDate.Location = new System.Drawing.Point(137, 61);
            this.dtpPlanStartDate.Name = "dtpPlanStartDate";
            this.dtpPlanStartDate.ShowCheckBox = true;
            this.dtpPlanStartDate.Size = new System.Drawing.Size(140, 26);
            this.dtpPlanStartDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 15;
            this.label2.Tag = "planStartDate";
            this.label2.Text = "planStartDate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStartStep
            // 
            this.cboStartStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStartStep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStartStep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStartStep.FormattingEnabled = true;
            this.cboStartStep.Location = new System.Drawing.Point(644, 35);
            this.cboStartStep.Name = "cboStartStep";
            this.cboStartStep.Size = new System.Drawing.Size(131, 24);
            this.cboStartStep.TabIndex = 6;
            // 
            // cboSpecId
            // 
            this.cboSpecId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSpecId.BackColor = System.Drawing.SystemColors.Info;
            this.cboSpecId.FormattingEnabled = true;
            this.cboSpecId.Location = new System.Drawing.Point(379, 61);
            this.cboSpecId.Name = "cboSpecId";
            this.cboSpecId.Size = new System.Drawing.Size(173, 24);
            this.cboSpecId.Sorted = true;
            this.cboSpecId.TabIndex = 9;
            // 
            // lblSpecId
            // 
            this.lblSpecId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSpecId.AutoSize = true;
            this.lblSpecId.Location = new System.Drawing.Point(317, 66);
            this.lblSpecId.Name = "lblSpecId";
            this.lblSpecId.Size = new System.Drawing.Size(56, 16);
            this.lblSpecId.TabIndex = 10;
            this.lblSpecId.Tag = "specId";
            this.lblSpecId.Text = "specId";
            this.lblSpecId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(582, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 10;
            this.label12.Tag = "remark";
            this.label12.Text = "remark";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCustomerDueDate
            // 
            this.dtpCustomerDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCustomerDueDate.Checked = false;
            this.dtpCustomerDueDate.Location = new System.Drawing.Point(137, 125);
            this.dtpCustomerDueDate.Name = "dtpCustomerDueDate";
            this.dtpCustomerDueDate.ShowCheckBox = true;
            this.dtpCustomerDueDate.Size = new System.Drawing.Size(140, 26);
            this.dtpCustomerDueDate.TabIndex = 13;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDueDate.Checked = false;
            this.dtpDueDate.Location = new System.Drawing.Point(137, 93);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShowCheckBox = true;
            this.dtpDueDate.Size = new System.Drawing.Size(140, 26);
            this.dtpDueDate.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 10;
            this.label11.Tag = "customerDueDate";
            this.label11.Text = "customerDueDate";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 9;
            this.label10.Tag = "dueDate";
            this.label10.Text = "dueDate";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCustomerId
            // 
            this.cboCustomerId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCustomerId.FormattingEnabled = true;
            this.cboCustomerId.Location = new System.Drawing.Point(379, 93);
            this.cboCustomerId.Name = "cboCustomerId";
            this.cboCustomerId.Size = new System.Drawing.Size(173, 24);
            this.cboCustomerId.Sorted = true;
            this.cboCustomerId.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(283, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 9;
            this.label9.Tag = "customerId";
            this.label9.Text = "customerId";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.txtQuantity.Location = new System.Drawing.Point(859, 3);
            this.txtQuantity.MaxLength = 8;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(81, 26);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(781, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 16);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Tag = "quantity";
            this.lblQuantity.Text = "quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoute
            // 
            this.cboRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoute.BackColor = System.Drawing.SystemColors.Info;
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(379, 35);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(173, 24);
            this.cboRoute.Sorted = true;
            this.cboRoute.TabIndex = 5;
            this.cboRoute.SelectedIndexChanged += new System.EventHandler(this.cboRoute_SelectedIndexChanged);
            // 
            // lblRouteId
            // 
            this.lblRouteId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.Location = new System.Drawing.Point(309, 37);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(64, 16);
            this.lblRouteId.TabIndex = 8;
            this.lblRouteId.Tag = "routeId";
            this.lblRouteId.Text = "routeId";
            this.lblRouteId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderType
            // 
            this.lblOrderType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderType.Location = new System.Drawing.Point(291, 7);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(82, 18);
            this.lblOrderType.TabIndex = 2;
            this.lblOrderType.Tag = "orderType";
            this.lblOrderType.Text = "orderType";
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderId.Location = new System.Drawing.Point(65, 7);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(66, 18);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Tag = "orderId";
            this.lblOrderId.Text = "orderId";
            this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderId.BackColor = System.Drawing.SystemColors.Info;
            this.txtOrderId.Location = new System.Drawing.Point(137, 3);
            this.txtOrderId.MaxLength = 40;
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(140, 26);
            this.txtOrderId.TabIndex = 0;
            // 
            // cboOrderType
            // 
            this.cboOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderType.BackColor = System.Drawing.SystemColors.Info;
            this.cboOrderType.FormattingEnabled = true;
            this.cboOrderType.Location = new System.Drawing.Point(379, 3);
            this.cboOrderType.Name = "cboOrderType";
            this.cboOrderType.Size = new System.Drawing.Size(173, 24);
            this.cboOrderType.Sorted = true;
            this.cboOrderType.TabIndex = 1;
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProductId.AutoSize = true;
            this.lblProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductId.Location = new System.Drawing.Point(49, 36);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(82, 18);
            this.lblProductId.TabIndex = 4;
            this.lblProductId.Tag = "productId";
            this.lblProductId.Text = "productId";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProduct.BackColor = System.Drawing.SystemColors.Info;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(137, 35);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(140, 24);
            this.cboProduct.Sorted = true;
            this.cboProduct.TabIndex = 4;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // lblFab
            // 
            this.lblFab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFab.AutoSize = true;
            this.lblFab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFab.Location = new System.Drawing.Point(604, 7);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(34, 18);
            this.lblFab.TabIndex = 6;
            this.lblFab.Tag = "fab";
            this.lblFab.Text = "fab";
            this.lblFab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboFab
            // 
            this.cboFab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFab.BackColor = System.Drawing.SystemColors.Info;
            this.cboFab.FormattingEnabled = true;
            this.cboFab.Location = new System.Drawing.Point(644, 3);
            this.cboFab.Name = "cboFab";
            this.cboFab.Size = new System.Drawing.Size(131, 24);
            this.cboFab.Sorted = true;
            this.cboFab.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(781, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Tag = "priority";
            this.label5.Text = "priority";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPriority
            // 
            this.cboPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(859, 35);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(81, 24);
            this.cboPriority.TabIndex = 7;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tblOrderDetail.SetColumnSpan(this.txtRemark, 3);
            this.txtRemark.Location = new System.Drawing.Point(644, 93);
            this.txtRemark.MaxLength = 255;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.tblOrderDetail.SetRowSpan(this.txtRemark, 2);
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(296, 58);
            this.txtRemark.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 13;
            this.label1.Tag = "fromStep";
            this.label1.Text = "startStep";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 8;
            this.label8.Tag = "owner";
            this.label8.Text = "owner";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOwner
            // 
            this.cboOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOwner.FormattingEnabled = true;
            this.cboOwner.Location = new System.Drawing.Point(379, 125);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Size = new System.Drawing.Size(173, 24);
            this.cboOwner.Sorted = true;
            this.cboOwner.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwOrder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 411);
            this.panel1.TabIndex = 9;
            // 
            // lvwOrder
            // 
            this.lvwOrder.allowUserFilter = true;
            this.lvwOrder.allowUserSorting = true;
            this.lvwOrder.autoSizeColumn = true;
            this.lvwOrder.careModifyDate = false;
            this.lvwOrder.columnHide = null;
            this.lvwOrder.columnNames = new string[] {
        "name",
        "orderType",
        "fab",
        "priority",
        "routeId",
        "specId",
        "quantity",
        "startQuantity",
        "lotCount",
        "owner",
        "customerId",
        "status",
        "planStartDate",
        "dueDate",
        "customerDueDate",
        "remark"};
            this.lvwOrder.columnTags = new string[] {
        "orderId",
        "orderType",
        "fab",
        "priority",
        "routeId",
        "specId",
        "quantity",
        "quantityStarted",
        "lotCount",
        "owner",
        "customerId",
        "status",
        "planStartDate",
        "dueDate",
        "customerDueDate",
        "remark"};
            this.lvwOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwOrder.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwOrder.FullRowSelect = true;
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.imageKeyColumn = "";
            this.lvwOrder.keyPressSearch = true;
            this.lvwOrder.keyPressSearchColumn = "";
            this.lvwOrder.Location = new System.Drawing.Point(0, 22);
            this.lvwOrder.makesureNewItemVisible = true;
            this.lvwOrder.MultiSelect = false;
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.OwnerDraw = true;
            this.lvwOrder.ShowItemTipSecond = ((byte)(3));
            this.lvwOrder.Size = new System.Drawing.Size(1119, 389);
            this.lvwOrder.TabIndex = 18;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            this.lvwOrder.View = System.Windows.Forms.View.Details;
            this.lvwOrder.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwOrder_MESItemSelectionChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1119, 22);
            this.label3.TabIndex = 17;
            this.label3.Tag = "orderInformation";
            this.label3.Text = "Order Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(1119, 25);
            this.actionToolbar1.TabIndex = 10;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(795, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 18);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Tag = "status";
            this.lblStatus.Text = "status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(859, 61);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(81, 24);
            this.cboStatus.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1119, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblOrderDetail);
            this.Controls.Add(this.standardStatusbar1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "CreateOrder";
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tblOrderDetail.ResumeLayout(false);
            this.tblOrderDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.TableLayoutPanel tblOrderDetail;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.ComboBox cboOrderType;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.ComboBox cboFab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboOwner;
        private System.Windows.Forms.DateTimePicker dtpCustomerDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCustomerId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cboSpecId;
        private System.Windows.Forms.Label lblSpecId;
        private System.Windows.Forms.ComboBox cboStartStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPlanStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private idv.mesCore.Controls.MESListView lvwOrder;
        private System.Windows.Forms.Label label3;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;


    }
}