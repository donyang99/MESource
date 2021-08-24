namespace ClientRule.QTimeSet
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
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.cboQTimeType = new System.Windows.Forms.ComboBox();
            this.lblQTimeType = new System.Windows.Forms.Label();
            this.rcbFromStep = new mesRelease.Controls.routeCombo();
            this.rcbToStep = new mesRelease.Controls.routeCombo();
            this.lblToStep = new System.Windows.Forms.Label();
            this.lblFromStep = new System.Windows.Forms.Label();
            this.lblQTime = new System.Windows.Forms.Label();
            this.txtQTime = new System.Windows.Forms.TextBox();
            this.lvwQTime = new idv.mesCore.Controls.MESListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 443);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(834, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(834, 25);
            this.actionToolbar1.TabIndex = 9;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // cboProduct
            // 
            this.cboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboProduct.BackColor = System.Drawing.SystemColors.Info;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(91, 6);
            this.cboProduct.MaxDropDownItems = 20;
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(143, 24);
            this.cboProduct.Sorted = true;
            this.cboProduct.TabIndex = 0;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProductId.AutoSize = true;
            this.lblProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductId.Location = new System.Drawing.Point(3, 7);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(82, 18);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Tag = "productId";
            this.lblProductId.Text = "productId";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboRoute
            // 
            this.cboRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboRoute.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel5.SetColumnSpan(this.cboRoute, 2);
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(312, 6);
            this.cboRoute.MaxDropDownItems = 20;
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(208, 24);
            this.cboRoute.Sorted = true;
            this.cboRoute.TabIndex = 1;
            this.cboRoute.SelectedIndexChanged += new System.EventHandler(this.cboRoute_SelectedIndexChanged);
            // 
            // lblRouteId
            // 
            this.lblRouteId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRouteId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRouteId.Location = new System.Drawing.Point(240, 7);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(66, 18);
            this.lblRouteId.TabIndex = 2;
            this.lblRouteId.Tag = "routeId";
            this.lblRouteId.Text = "routeId";
            this.lblRouteId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(757, 0);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(834, 94);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 9;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel5.Controls.Add(this.cboAction, 6, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblAction, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.cboQTimeType, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblQTimeType, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.rcbFromStep, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.rcbToStep, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblToStep, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblFromStep, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblProductId, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cboProduct, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblRouteId, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.cboRoute, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblQTime, 7, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtQTime, 8, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(823, 69);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // cboAction
            // 
            this.cboAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAction.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel5.SetColumnSpan(this.cboAction, 3);
            this.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Location = new System.Drawing.Point(612, 38);
            this.cboAction.MaxDropDownItems = 20;
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(208, 24);
            this.cboAction.TabIndex = 21;
            // 
            // lblAction
            // 
            this.lblAction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(550, 40);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(56, 16);
            this.lblAction.TabIndex = 21;
            this.lblAction.Tag = "action";
            this.lblAction.Text = "Action";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboQTimeType
            // 
            this.cboQTimeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboQTimeType.BackColor = System.Drawing.SystemColors.Info;
            this.cboQTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQTimeType.FormattingEnabled = true;
            this.cboQTimeType.Location = new System.Drawing.Point(612, 4);
            this.cboQTimeType.MaxDropDownItems = 20;
            this.cboQTimeType.Name = "cboQTimeType";
            this.cboQTimeType.Size = new System.Drawing.Size(86, 24);
            this.cboQTimeType.TabIndex = 20;
            // 
            // lblQTimeType
            // 
            this.lblQTimeType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQTimeType.AutoSize = true;
            this.lblQTimeType.Location = new System.Drawing.Point(526, 8);
            this.lblQTimeType.Name = "lblQTimeType";
            this.lblQTimeType.Size = new System.Drawing.Size(80, 16);
            this.lblQTimeType.TabIndex = 20;
            this.lblQTimeType.Tag = "qTimeType";
            this.lblQTimeType.Text = "qTimeType";
            this.lblQTimeType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rcbFromStep
            // 
            this.rcbFromStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rcbFromStep.AutoSize = true;
            this.rcbFromStep.complexMode = false;
            this.rcbFromStep.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rcbFromStep.Location = new System.Drawing.Point(92, 36);
            this.rcbFromStep.Margin = new System.Windows.Forms.Padding(4);
            this.rcbFromStep.Name = "rcbFromStep";
            this.rcbFromStep.passPathOnly = false;
            this.rcbFromStep.required = true;
            this.rcbFromStep.selectedStep = null;
            this.rcbFromStep.showHandle = false;
            this.rcbFromStep.Size = new System.Drawing.Size(141, 24);
            this.rcbFromStep.TabIndex = 19;
            this.rcbFromStep.MESStepSelectionChanged += new mesRelease.Controls.routeCombo.MESStepSelectionChangedHandler(this.rcbFromStep_MESStepSelectionChanged);
            // 
            // rcbToStep
            // 
            this.rcbToStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rcbToStep.AutoSize = true;
            this.rcbToStep.complexMode = false;
            this.rcbToStep.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rcbToStep.Location = new System.Drawing.Point(313, 36);
            this.rcbToStep.Margin = new System.Windows.Forms.Padding(4);
            this.rcbToStep.Name = "rcbToStep";
            this.rcbToStep.passPathOnly = true;
            this.rcbToStep.required = true;
            this.rcbToStep.selectedStep = null;
            this.rcbToStep.showHandle = false;
            this.rcbToStep.Size = new System.Drawing.Size(141, 24);
            this.rcbToStep.TabIndex = 20;
            // 
            // lblToStep
            // 
            this.lblToStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToStep.AutoSize = true;
            this.lblToStep.Location = new System.Drawing.Point(250, 40);
            this.lblToStep.Name = "lblToStep";
            this.lblToStep.Size = new System.Drawing.Size(56, 16);
            this.lblToStep.TabIndex = 17;
            this.lblToStep.Tag = "toStep";
            this.lblToStep.Text = "toStep";
            this.lblToStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFromStep
            // 
            this.lblFromStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFromStep.AutoSize = true;
            this.lblFromStep.Location = new System.Drawing.Point(13, 40);
            this.lblFromStep.Name = "lblFromStep";
            this.lblFromStep.Size = new System.Drawing.Size(72, 16);
            this.lblFromStep.TabIndex = 16;
            this.lblFromStep.Tag = "fromStep";
            this.lblFromStep.Text = "fromStep";
            this.lblFromStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQTime
            // 
            this.lblQTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQTime.AutoSize = true;
            this.lblQTime.Location = new System.Drawing.Point(704, 8);
            this.lblQTime.Name = "lblQTime";
            this.lblQTime.Size = new System.Drawing.Size(48, 16);
            this.lblQTime.TabIndex = 18;
            this.lblQTime.Tag = "qTime";
            this.lblQTime.Text = "qTime";
            this.lblQTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQTime
            // 
            this.txtQTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQTime.BackColor = System.Drawing.SystemColors.Info;
            this.txtQTime.Location = new System.Drawing.Point(758, 3);
            this.txtQTime.MaxLength = 8;
            this.txtQTime.Name = "txtQTime";
            this.txtQTime.Size = new System.Drawing.Size(62, 26);
            this.txtQTime.TabIndex = 4;
            this.txtQTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQTime_KeyPress);
            // 
            // lvwQTime
            // 
            this.lvwQTime.allowUserFilter = false;
            this.lvwQTime.allowUserSorting = true;
            this.lvwQTime.autoSizeColumn = true;
            this.lvwQTime.careModifyDate = false;
            this.lvwQTime.columnHide = null;
            this.lvwQTime.columnNames = new string[] {
        "productId",
        "routeId",
        "fromStepId",
        "toStepId",
        "qTime",
        "type",
        "action"};
            this.lvwQTime.columnTags = new string[] {
        "productId",
        "routeId",
        "fromStep",
        "toStep",
        "qTime",
        "qTimeType",
        "action"};
            this.lvwQTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwQTime.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwQTime.FullRowSelect = true;
            this.lvwQTime.HideSelection = false;
            this.lvwQTime.imageKeyColumn = "";
            this.lvwQTime.keyPressSearch = false;
            this.lvwQTime.keyPressSearchColumn = "";
            this.lvwQTime.Location = new System.Drawing.Point(0, 119);
            this.lvwQTime.makesureNewItemVisible = true;
            this.lvwQTime.MultiSelect = false;
            this.lvwQTime.Name = "lvwQTime";
            this.lvwQTime.OwnerDraw = true;
            this.lvwQTime.ShowItemTipSecond = ((byte)(3));
            this.lvwQTime.Size = new System.Drawing.Size(834, 289);
            this.lvwQTime.TabIndex = 16;
            this.lvwQTime.UseCompatibleStateImageBehavior = false;
            this.lvwQTime.View = System.Windows.Forms.View.Details;
            this.lvwQTime.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwQTime_MESItemSelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 35);
            this.panel1.TabIndex = 20;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 468);
            this.ControlBox = false;
            this.Controls.Add(this.lvwQTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.actionToolbar1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "QTimeSet";
            this.Text = "QTimeSet";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblFromStep;
        private idv.mesCore.Controls.MESListView lvwQTime;
        private System.Windows.Forms.Label lblQTime;
        private System.Windows.Forms.Label lblToStep;
        private System.Windows.Forms.TextBox txtQTime;
        private mesRelease.Controls.routeCombo rcbFromStep;
        private mesRelease.Controls.routeCombo rcbToStep;
        private System.Windows.Forms.ComboBox cboQTimeType;
        private System.Windows.Forms.Label lblQTimeType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.Label lblAction;

    }
}