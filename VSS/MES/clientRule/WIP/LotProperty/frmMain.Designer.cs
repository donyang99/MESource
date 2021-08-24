namespace ClientRule.LotProperty
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
            this.lotInfomation1 = new mesRelease.Controls.LotInfomation();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnExportHistory = new System.Windows.Forms.Button();
            this.btnHistoryDetail = new System.Windows.Forms.Button();
            this.lvwLotHistory = new System.Windows.Forms.ListView();
            this.activity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.step_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modify_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modify_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQueryHistory = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.tblMembers = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lvwComponents = new System.Windows.Forms.ListView();
            this.colComponentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComCarrierId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIntegrity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwCarrier = new System.Windows.Forms.ListView();
            this.colCarrierId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCarrierQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabFutureAction = new System.Windows.Forms.TabPage();
            this.lvwQTime = new System.Windows.Forms.ListView();
            this.colFromStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFromHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colToStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colToHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartMonTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemainTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.lvwFutureHold = new System.Windows.Forms.ListView();
            this.colFutureHoldReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFutureHoldStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.lvwWI = new System.Windows.Forms.ListView();
            this.colWorkingInstruction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWIStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWIModifyUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.tabParentChild = new System.Windows.Forms.TabPage();
            this.lvwChildLot = new System.Windows.Forms.ListView();
            this.colChildLotId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChildLotQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChildLotStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChildLotStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMergeParent = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSplitParent = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTopParent = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSourceParent = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabStepDC = new System.Windows.Forms.TabPage();
            this.btnExportStepDC = new System.Windows.Forms.Button();
            this.lvwStepDC = new System.Windows.Forms.ListView();
            this.colStepDCStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStepDC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStepDCDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStepDCValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStepDCModifyDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboStep = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabStep = new System.Windows.Forms.TabPage();
            this.lvwStepMap = new System.Windows.Forms.ListView();
            this.colStepHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFinishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStepMap = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEquipmentGroup = new System.Windows.Forms.TextBox();
            this.txtAvailablePath = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtStepStatus = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.txtStepDescription = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtStepId = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCurrentRule = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRuleIndex = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMoveOutDate = new System.Windows.Forms.TextBox();
            this.txtMoveInDate = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabMaterialTracking = new System.Windows.Forms.TabPage();
            this.btnExportMaterialTracking = new System.Windows.Forms.Button();
            this.lvwMaterialTracking = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboMaterialTrackingStep = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.tabTooling = new System.Windows.Forms.TabPage();
            this.btnExportTooling = new System.Windows.Forms.Button();
            this.lvwTooling = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboToolingStep = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.colStepDCActivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMembers.SuspendLayout();
            this.tblMembers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabFutureAction.SuspendLayout();
            this.tabParentChild.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabStepDC.SuspendLayout();
            this.tabStep.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabMaterialTracking.SuspendLayout();
            this.tabTooling.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(889, 625);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 5;
            // 
            // lotInfomation1
            // 
            this.lotInfomation1.AutoScroll = true;
            this.lotInfomation1.AutoScrollMinSize = new System.Drawing.Size(100, 336);
            this.lotInfomation1.CheckInputChar = false;
            this.lotInfomation1.displayProperties = new string[0];
            this.lotInfomation1.displayPropertyTags = new string[0];
            this.lotInfomation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lotInfomation1.editable = false;
            this.lotInfomation1.EnableBarcodeControl = true;
            this.lotInfomation1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lotInfomation1.Location = new System.Drawing.Point(0, 22);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = true;
            this.lotInfomation1.showDueDate = true;
            this.lotInfomation1.ShowPopupMessage = false;
            this.lotInfomation1.Size = new System.Drawing.Size(212, 603);
            this.lotInfomation1.TabIndex = 4;
            this.lotInfomation1.TimeoutMilliseconds = ((long)(500));
            this.lotInfomation1.ToolTipFontSize = 11.25F;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lotInformation";
            this.label1.Text = "Lot Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabFutureAction);
            this.tabControl1.Controls.Add(this.tabParentChild);
            this.tabControl1.Controls.Add(this.tabStepDC);
            this.tabControl1.Controls.Add(this.tabStep);
            this.tabControl1.Controls.Add(this.tabMaterialTracking);
            this.tabControl1.Controls.Add(this.tabTooling);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(54, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 580);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.btnExportHistory);
            this.tabHistory.Controls.Add(this.btnHistoryDetail);
            this.tabHistory.Controls.Add(this.lvwLotHistory);
            this.tabHistory.Controls.Add(this.label5);
            this.tabHistory.Controls.Add(this.label2);
            this.tabHistory.Controls.Add(this.groupBox1);
            this.tabHistory.Location = new System.Drawing.Point(4, 26);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(665, 550);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Tag = "history";
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // btnExportHistory
            // 
            this.btnExportHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportHistory.Location = new System.Drawing.Point(571, 517);
            this.btnExportHistory.Name = "btnExportHistory";
            this.btnExportHistory.Size = new System.Drawing.Size(79, 31);
            this.btnExportHistory.TabIndex = 9;
            this.btnExportHistory.Tag = "buttonExport";
            this.btnExportHistory.Text = "Export";
            this.btnExportHistory.UseVisualStyleBackColor = true;
            this.btnExportHistory.Click += new System.EventHandler(this.btnExportHistory_Click);
            // 
            // btnHistoryDetail
            // 
            this.btnHistoryDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistoryDetail.Location = new System.Drawing.Point(490, 517);
            this.btnHistoryDetail.Name = "btnHistoryDetail";
            this.btnHistoryDetail.Size = new System.Drawing.Size(79, 31);
            this.btnHistoryDetail.TabIndex = 8;
            this.btnHistoryDetail.Tag = "detail";
            this.btnHistoryDetail.Text = "Detail";
            this.btnHistoryDetail.UseVisualStyleBackColor = true;
            this.btnHistoryDetail.Click += new System.EventHandler(this.btnHistoryDetail_Click);
            // 
            // lvwLotHistory
            // 
            this.lvwLotHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLotHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.activity,
            this.step_id,
            this.quantity,
            this.modify_user,
            this.modify_date});
            this.lvwLotHistory.FullRowSelect = true;
            this.lvwLotHistory.HideSelection = false;
            this.lvwLotHistory.Location = new System.Drawing.Point(12, 153);
            this.lvwLotHistory.Name = "lvwLotHistory";
            this.lvwLotHistory.Size = new System.Drawing.Size(638, 362);
            this.lvwLotHistory.TabIndex = 7;
            this.lvwLotHistory.UseCompatibleStateImageBehavior = false;
            this.lvwLotHistory.View = System.Windows.Forms.View.Details;
            this.lvwLotHistory.DoubleClick += new System.EventHandler(this.lvwLotHistory_DoubleClick);
            // 
            // activity
            // 
            this.activity.Name = "activity";
            this.activity.Tag = "activity";
            this.activity.Text = "Activity";
            this.activity.Width = 122;
            // 
            // step_id
            // 
            this.step_id.Name = "step_id";
            this.step_id.Tag = "step";
            this.step_id.Text = "StepId";
            this.step_id.Width = 108;
            // 
            // quantity
            // 
            this.quantity.Name = "quantity";
            this.quantity.Tag = "quantity";
            this.quantity.Text = "Quantity";
            this.quantity.Width = 73;
            // 
            // modify_user
            // 
            this.modify_user.Name = "modify_user";
            this.modify_user.Tag = "modifyUser";
            this.modify_user.Text = "ModifyUser";
            this.modify_user.Width = 117;
            // 
            // modify_date
            // 
            this.modify_date.Name = "modify_date";
            this.modify_date.Tag = "modifyDate";
            this.modify_date.Text = "ModifyDate";
            this.modify_date.Width = 176;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(11, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 22);
            this.label5.TabIndex = 6;
            this.label5.Tag = "lotHistory";
            this.label5.Text = "Lot History";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 4;
            this.label2.Tag = "queryCondition";
            this.label2.Text = "Query Condition";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnQueryHistory);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnQueryHistory
            // 
            this.btnQueryHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryHistory.Location = new System.Drawing.Point(572, 52);
            this.btnQueryHistory.Name = "btnQueryHistory";
            this.btnQueryHistory.Size = new System.Drawing.Size(68, 33);
            this.btnQueryHistory.TabIndex = 2;
            this.btnQueryHistory.Tag = "buttonQuery";
            this.btnQueryHistory.Text = "Query";
            this.btnQueryHistory.UseVisualStyleBackColor = true;
            this.btnQueryHistory.Click += new System.EventHandler(this.btnQueryHistory_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 434F));
            this.tableLayoutPanel1.Controls.Add(this.dtTo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dtTo.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(267, 3);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(190, 26);
            this.dtTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 32);
            this.label3.TabIndex = 0;
            this.label3.Tag = "date";
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dtFrom.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(49, 3);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(190, 26);
            this.dtFrom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(245, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.tblMembers);
            this.tabMembers.Controls.Add(this.tableLayoutPanel2);
            this.tabMembers.Controls.Add(this.label6);
            this.tabMembers.Location = new System.Drawing.Point(4, 26);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(665, 550);
            this.tabMembers.TabIndex = 1;
            this.tabMembers.Tag = "members";
            this.tabMembers.Text = "members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // tblMembers
            // 
            this.tblMembers.ColumnCount = 2;
            this.tblMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.33884F));
            this.tblMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.66116F));
            this.tblMembers.Controls.Add(this.label10, 0, 0);
            this.tblMembers.Controls.Add(this.lvwComponents, 1, 1);
            this.tblMembers.Controls.Add(this.lvwCarrier, 0, 1);
            this.tblMembers.Controls.Add(this.label11, 1, 0);
            this.tblMembers.Location = new System.Drawing.Point(11, 106);
            this.tblMembers.Name = "tblMembers";
            this.tblMembers.RowCount = 2;
            this.tblMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.855856F));
            this.tblMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.14414F));
            this.tblMembers.Size = new System.Drawing.Size(630, 422);
            this.tblMembers.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 22);
            this.label10.TabIndex = 7;
            this.label10.Tag = "carrier";
            this.label10.Text = "carrier";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwComponents
            // 
            this.lvwComponents.BackColor = System.Drawing.SystemColors.Control;
            this.lvwComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colComponentId,
            this.colComCarrierId,
            this.colPosition,
            this.colIntegrity});
            this.lvwComponents.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvwComponents.FullRowSelect = true;
            this.lvwComponents.Location = new System.Drawing.Point(247, 27);
            this.lvwComponents.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lvwComponents.Name = "lvwComponents";
            this.lvwComponents.Size = new System.Drawing.Size(380, 392);
            this.lvwComponents.TabIndex = 21;
            this.lvwComponents.UseCompatibleStateImageBehavior = false;
            this.lvwComponents.View = System.Windows.Forms.View.Details;
            // 
            // colComponentId
            // 
            this.colComponentId.Tag = "componentId";
            this.colComponentId.Text = "componentId";
            this.colComponentId.Width = 134;
            // 
            // colComCarrierId
            // 
            this.colComCarrierId.Tag = "carrierId";
            this.colComCarrierId.Text = "CarrierId";
            // 
            // colPosition
            // 
            this.colPosition.Tag = "position";
            this.colPosition.Text = "position";
            this.colPosition.Width = 98;
            // 
            // colIntegrity
            // 
            this.colIntegrity.Tag = "integrity";
            this.colIntegrity.Text = "integrity";
            // 
            // lvwCarrier
            // 
            this.lvwCarrier.BackColor = System.Drawing.SystemColors.Control;
            this.lvwCarrier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCarrierId,
            this.colCarrierQty});
            this.lvwCarrier.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvwCarrier.FullRowSelect = true;
            this.lvwCarrier.Location = new System.Drawing.Point(0, 27);
            this.lvwCarrier.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lvwCarrier.Name = "lvwCarrier";
            this.lvwCarrier.Size = new System.Drawing.Size(244, 392);
            this.lvwCarrier.TabIndex = 19;
            this.lvwCarrier.UseCompatibleStateImageBehavior = false;
            this.lvwCarrier.View = System.Windows.Forms.View.Details;
            this.lvwCarrier.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvwCarrier_MouseUp);
            // 
            // colCarrierId
            // 
            this.colCarrierId.Tag = "carrierId";
            this.colCarrierId.Text = "CarrierId";
            this.colCarrierId.Width = 120;
            // 
            // colCarrierQty
            // 
            this.colCarrierQty.Tag = "quantity";
            this.colCarrierQty.Text = "CarrierQty";
            this.colCarrierQty.Width = 94;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(247, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 22);
            this.label11.TabIndex = 20;
            this.label11.Tag = "components";
            this.label11.Text = "components";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtUnit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStartQty, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCurrentQty, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 64);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnit.Location = new System.Drawing.Point(261, 3);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(71, 26);
            this.txtUnit.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 12;
            this.label9.Tag = "unit";
            this.label9.Text = "unit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartQty
            // 
            this.txtStartQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartQty.Location = new System.Drawing.Point(121, 35);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.ReadOnly = true;
            this.txtStartQty.Size = new System.Drawing.Size(88, 26);
            this.txtStartQty.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 10;
            this.label8.Tag = "startQuantity";
            this.label8.Text = "startQuantity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentQty.Location = new System.Drawing.Point(121, 3);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(88, 26);
            this.txtCurrentQty.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 7;
            this.label7.Tag = "quantity";
            this.label7.Text = "currentQty";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(11, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 22);
            this.label6.TabIndex = 5;
            this.label6.Tag = "quantity";
            this.label6.Text = "Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabFutureAction
            // 
            this.tabFutureAction.Controls.Add(this.lvwQTime);
            this.tabFutureAction.Controls.Add(this.label14);
            this.tabFutureAction.Controls.Add(this.lvwFutureHold);
            this.tabFutureAction.Controls.Add(this.label13);
            this.tabFutureAction.Controls.Add(this.lvwWI);
            this.tabFutureAction.Controls.Add(this.label12);
            this.tabFutureAction.Location = new System.Drawing.Point(4, 26);
            this.tabFutureAction.Name = "tabFutureAction";
            this.tabFutureAction.Padding = new System.Windows.Forms.Padding(3);
            this.tabFutureAction.Size = new System.Drawing.Size(665, 550);
            this.tabFutureAction.TabIndex = 2;
            this.tabFutureAction.Tag = "futureAction";
            this.tabFutureAction.Text = "FutureAction";
            this.tabFutureAction.UseVisualStyleBackColor = true;
            // 
            // lvwQTime
            // 
            this.lvwQTime.BackColor = System.Drawing.SystemColors.Control;
            this.lvwQTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFromStep,
            this.colFromHandle,
            this.colToStep,
            this.colToHandle,
            this.colStartMonTime,
            this.colQTime,
            this.colRemainTime});
            this.lvwQTime.FullRowSelect = true;
            this.lvwQTime.Location = new System.Drawing.Point(11, 356);
            this.lvwQTime.Name = "lvwQTime";
            this.lvwQTime.Size = new System.Drawing.Size(646, 121);
            this.lvwQTime.TabIndex = 24;
            this.lvwQTime.UseCompatibleStateImageBehavior = false;
            this.lvwQTime.View = System.Windows.Forms.View.Details;
            // 
            // colFromStep
            // 
            this.colFromStep.Tag = "fromStep";
            this.colFromStep.Text = "FromStep";
            this.colFromStep.Width = 82;
            // 
            // colFromHandle
            // 
            this.colFromHandle.Tag = "stepHandle";
            this.colFromHandle.Text = "fromHandle";
            this.colFromHandle.Width = 84;
            // 
            // colToStep
            // 
            this.colToStep.Tag = "toStep";
            this.colToStep.Text = "ToStep";
            this.colToStep.Width = 87;
            // 
            // colToHandle
            // 
            this.colToHandle.Tag = "stepHandle";
            this.colToHandle.Text = "toHandle";
            this.colToHandle.Width = 68;
            // 
            // colStartMonTime
            // 
            this.colStartMonTime.Tag = "startMonitorTime";
            this.colStartMonTime.Text = "StartMonitorTime";
            this.colStartMonTime.Width = 129;
            // 
            // colQTime
            // 
            this.colQTime.Tag = "qTime";
            this.colQTime.Text = "QTime";
            this.colQTime.Width = 80;
            // 
            // colRemainTime
            // 
            this.colRemainTime.Tag = "remainTime";
            this.colRemainTime.Text = "Remain Time";
            this.colRemainTime.Width = 87;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(11, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 22);
            this.label14.TabIndex = 23;
            this.label14.Tag = "qTime";
            this.label14.Text = "qTime";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwFutureHold
            // 
            this.lvwFutureHold.BackColor = System.Drawing.SystemColors.Control;
            this.lvwFutureHold.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFutureHoldReason,
            this.colFutureHoldStep,
            this.columnHeader9,
            this.columnHeader3});
            this.lvwFutureHold.FullRowSelect = true;
            this.lvwFutureHold.Location = new System.Drawing.Point(11, 194);
            this.lvwFutureHold.Name = "lvwFutureHold";
            this.lvwFutureHold.Size = new System.Drawing.Size(646, 121);
            this.lvwFutureHold.TabIndex = 22;
            this.lvwFutureHold.UseCompatibleStateImageBehavior = false;
            this.lvwFutureHold.View = System.Windows.Forms.View.Details;
            // 
            // colFutureHoldReason
            // 
            this.colFutureHoldReason.Tag = "ReasonCode";
            this.colFutureHoldReason.Text = "ReasonCode";
            this.colFutureHoldReason.Width = 200;
            // 
            // colFutureHoldStep
            // 
            this.colFutureHoldStep.Tag = "step";
            this.colFutureHoldStep.Text = "step";
            this.colFutureHoldStep.Width = 106;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Tag = "timing";
            this.columnHeader9.Text = "timing";
            this.columnHeader9.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "modifyUser";
            this.columnHeader3.Text = "MoidyfUser";
            this.columnHeader3.Width = 76;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(11, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 22);
            this.label13.TabIndex = 21;
            this.label13.Tag = "futureHold";
            this.label13.Text = "Future Hold";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwWI
            // 
            this.lvwWI.BackColor = System.Drawing.SystemColors.Control;
            this.lvwWI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colWorkingInstruction,
            this.colWIStep,
            this.colWIModifyUser});
            this.lvwWI.FullRowSelect = true;
            this.lvwWI.Location = new System.Drawing.Point(11, 31);
            this.lvwWI.Name = "lvwWI";
            this.lvwWI.Size = new System.Drawing.Size(646, 121);
            this.lvwWI.TabIndex = 20;
            this.lvwWI.UseCompatibleStateImageBehavior = false;
            this.lvwWI.View = System.Windows.Forms.View.Details;
            // 
            // colWorkingInstruction
            // 
            this.colWorkingInstruction.Tag = "workingInstruction";
            this.colWorkingInstruction.Text = "workingInstruction";
            this.colWorkingInstruction.Width = 491;
            // 
            // colWIStep
            // 
            this.colWIStep.Tag = "step";
            this.colWIStep.Text = "step";
            this.colWIStep.Width = 72;
            // 
            // colWIModifyUser
            // 
            this.colWIModifyUser.Tag = "modifyUser";
            this.colWIModifyUser.Text = "MoidyfUser";
            this.colWIModifyUser.Width = 76;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(11, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 22);
            this.label12.TabIndex = 6;
            this.label12.Tag = "workingInstruction";
            this.label12.Text = "workingInstruction";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabParentChild
            // 
            this.tabParentChild.Controls.Add(this.lvwChildLot);
            this.tabParentChild.Controls.Add(this.label20);
            this.tabParentChild.Controls.Add(this.tableLayoutPanel3);
            this.tabParentChild.Controls.Add(this.label15);
            this.tabParentChild.Location = new System.Drawing.Point(4, 26);
            this.tabParentChild.Name = "tabParentChild";
            this.tabParentChild.Padding = new System.Windows.Forms.Padding(3);
            this.tabParentChild.Size = new System.Drawing.Size(665, 550);
            this.tabParentChild.TabIndex = 3;
            this.tabParentChild.Tag = "parentChild";
            this.tabParentChild.Text = "parentChild";
            this.tabParentChild.UseVisualStyleBackColor = true;
            // 
            // lvwChildLot
            // 
            this.lvwChildLot.BackColor = System.Drawing.SystemColors.Control;
            this.lvwChildLot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colChildLotId,
            this.colChildLotQty,
            this.colChildLotStatus,
            this.colChildLotStep});
            this.lvwChildLot.FullRowSelect = true;
            this.lvwChildLot.Location = new System.Drawing.Point(9, 137);
            this.lvwChildLot.Name = "lvwChildLot";
            this.lvwChildLot.Size = new System.Drawing.Size(646, 359);
            this.lvwChildLot.TabIndex = 21;
            this.lvwChildLot.UseCompatibleStateImageBehavior = false;
            this.lvwChildLot.View = System.Windows.Forms.View.Details;
            // 
            // colChildLotId
            // 
            this.colChildLotId.Tag = "lotId";
            this.colChildLotId.Text = "ChildLotId";
            this.colChildLotId.Width = 150;
            // 
            // colChildLotQty
            // 
            this.colChildLotQty.Tag = "quantity";
            this.colChildLotQty.Text = "Quantity";
            this.colChildLotQty.Width = 72;
            // 
            // colChildLotStatus
            // 
            this.colChildLotStatus.Tag = "status";
            this.colChildLotStatus.Text = "Status";
            this.colChildLotStatus.Width = 90;
            // 
            // colChildLotStep
            // 
            this.colChildLotStep.Tag = "step";
            this.colChildLotStep.Text = "Step";
            this.colChildLotStep.Width = 150;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(11, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(212, 22);
            this.label20.TabIndex = 9;
            this.label20.Tag = "child";
            this.label20.Text = "Child";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtMergeParent, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label19, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSplitParent, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTopParent, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label17, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSourceParent, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 39);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(510, 64);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // txtMergeParent
            // 
            this.txtMergeParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMergeParent.Location = new System.Drawing.Point(356, 35);
            this.txtMergeParent.Name = "txtMergeParent";
            this.txtMergeParent.ReadOnly = true;
            this.txtMergeParent.Size = new System.Drawing.Size(151, 26);
            this.txtMergeParent.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(254, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 16);
            this.label19.TabIndex = 14;
            this.label19.Tag = "mergeParent";
            this.label19.Text = "mergeParent";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSplitParent
            // 
            this.txtSplitParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplitParent.Location = new System.Drawing.Point(113, 35);
            this.txtSplitParent.Name = "txtSplitParent";
            this.txtSplitParent.ReadOnly = true;
            this.txtSplitParent.Size = new System.Drawing.Size(135, 26);
            this.txtSplitParent.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 16);
            this.label18.TabIndex = 12;
            this.label18.Tag = "parentLotId";
            this.label18.Text = "parentLotId";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTopParent
            // 
            this.txtTopParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTopParent.Location = new System.Drawing.Point(356, 3);
            this.txtTopParent.Name = "txtTopParent";
            this.txtTopParent.ReadOnly = true;
            this.txtTopParent.Size = new System.Drawing.Size(151, 26);
            this.txtTopParent.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(270, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 10;
            this.label17.Tag = "topParent";
            this.label17.Text = "topParent";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSourceParent
            // 
            this.txtSourceParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceParent.Location = new System.Drawing.Point(113, 3);
            this.txtSourceParent.Name = "txtSourceParent";
            this.txtSourceParent.ReadOnly = true;
            this.txtSourceParent.Size = new System.Drawing.Size(135, 26);
            this.txtSourceParent.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 16);
            this.label16.TabIndex = 8;
            this.label16.Tag = "sourceParent";
            this.label16.Text = "sourceParent";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(11, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 22);
            this.label15.TabIndex = 7;
            this.label15.Tag = "parent";
            this.label15.Text = "Parent";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabStepDC
            // 
            this.tabStepDC.Controls.Add(this.btnExportStepDC);
            this.tabStepDC.Controls.Add(this.lvwStepDC);
            this.tabStepDC.Controls.Add(this.cboStep);
            this.tabStepDC.Controls.Add(this.label21);
            this.tabStepDC.Location = new System.Drawing.Point(4, 26);
            this.tabStepDC.Name = "tabStepDC";
            this.tabStepDC.Padding = new System.Windows.Forms.Padding(3);
            this.tabStepDC.Size = new System.Drawing.Size(665, 550);
            this.tabStepDC.TabIndex = 4;
            this.tabStepDC.Tag = "stepDC";
            this.tabStepDC.Text = "stepDC";
            this.tabStepDC.UseVisualStyleBackColor = true;
            // 
            // btnExportStepDC
            // 
            this.btnExportStepDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportStepDC.Location = new System.Drawing.Point(563, 476);
            this.btnExportStepDC.Name = "btnExportStepDC";
            this.btnExportStepDC.Size = new System.Drawing.Size(79, 31);
            this.btnExportStepDC.TabIndex = 23;
            this.btnExportStepDC.Tag = "buttonExport";
            this.btnExportStepDC.Text = "Export";
            this.btnExportStepDC.UseVisualStyleBackColor = true;
            this.btnExportStepDC.Click += new System.EventHandler(this.btnExportStepDC_Click);
            // 
            // lvwStepDC
            // 
            this.lvwStepDC.BackColor = System.Drawing.SystemColors.Control;
            this.lvwStepDC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStepDCStep,
            this.colStepDC,
            this.colStepDCDescription,
            this.colStepDCValue,
            this.colStepDCModifyDate,
            this.colStepDCActivity});
            this.lvwStepDC.FullRowSelect = true;
            this.lvwStepDC.Location = new System.Drawing.Point(22, 50);
            this.lvwStepDC.Name = "lvwStepDC";
            this.lvwStepDC.Size = new System.Drawing.Size(620, 406);
            this.lvwStepDC.TabIndex = 22;
            this.lvwStepDC.UseCompatibleStateImageBehavior = false;
            this.lvwStepDC.View = System.Windows.Forms.View.Details;
            // 
            // colStepDCStep
            // 
            this.colStepDCStep.Tag = "step";
            this.colStepDCStep.Text = "Step";
            this.colStepDCStep.Width = 100;
            // 
            // colStepDC
            // 
            this.colStepDC.DisplayIndex = 2;
            this.colStepDC.Tag = "stepDC";
            this.colStepDC.Text = "StepDC";
            this.colStepDC.Width = 77;
            // 
            // colStepDCDescription
            // 
            this.colStepDCDescription.DisplayIndex = 3;
            this.colStepDCDescription.Tag = "description";
            this.colStepDCDescription.Text = "Description";
            this.colStepDCDescription.Width = 131;
            // 
            // colStepDCValue
            // 
            this.colStepDCValue.DisplayIndex = 4;
            this.colStepDCValue.Tag = "value";
            this.colStepDCValue.Text = "Value";
            this.colStepDCValue.Width = 85;
            // 
            // colStepDCModifyDate
            // 
            this.colStepDCModifyDate.DisplayIndex = 5;
            this.colStepDCModifyDate.Tag = "modifyDate";
            this.colStepDCModifyDate.Text = "ModifyDate";
            this.colStepDCModifyDate.Width = 140;
            // 
            // cboStep
            // 
            this.cboStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStep.FormattingEnabled = true;
            this.cboStep.ItemHeight = 16;
            this.cboStep.Location = new System.Drawing.Point(80, 12);
            this.cboStep.MaxDropDownItems = 20;
            this.cboStep.Name = "cboStep";
            this.cboStep.Size = new System.Drawing.Size(276, 24);
            this.cboStep.TabIndex = 1;
            this.cboStep.SelectedIndexChanged += new System.EventHandler(this.cboStep_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 16);
            this.label21.TabIndex = 0;
            this.label21.Tag = "step";
            this.label21.Text = "step";
            // 
            // tabStep
            // 
            this.tabStep.Controls.Add(this.lvwStepMap);
            this.tabStep.Controls.Add(this.lblStepMap);
            this.tabStep.Controls.Add(this.tableLayoutPanel5);
            this.tabStep.Controls.Add(this.tableLayoutPanel4);
            this.tabStep.Controls.Add(this.label22);
            this.tabStep.Location = new System.Drawing.Point(4, 26);
            this.tabStep.Name = "tabStep";
            this.tabStep.Padding = new System.Windows.Forms.Padding(3);
            this.tabStep.Size = new System.Drawing.Size(665, 550);
            this.tabStep.TabIndex = 5;
            this.tabStep.Tag = "step";
            this.tabStep.Text = "Step";
            this.tabStep.UseVisualStyleBackColor = true;
            // 
            // lvwStepMap
            // 
            this.lvwStepMap.BackColor = System.Drawing.SystemColors.Control;
            this.lvwStepMap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStepHandle,
            this.colStep,
            this.colFinishDate});
            this.lvwStepMap.FullRowSelect = true;
            this.lvwStepMap.Location = new System.Drawing.Point(11, 309);
            this.lvwStepMap.Name = "lvwStepMap";
            this.lvwStepMap.Size = new System.Drawing.Size(378, 238);
            this.lvwStepMap.TabIndex = 22;
            this.lvwStepMap.UseCompatibleStateImageBehavior = false;
            this.lvwStepMap.View = System.Windows.Forms.View.Details;
            // 
            // colStepHandle
            // 
            this.colStepHandle.Tag = "stepHandle";
            this.colStepHandle.Text = "StepHandle";
            this.colStepHandle.Width = 0;
            // 
            // colStep
            // 
            this.colStep.Tag = "step";
            this.colStep.Text = "Step";
            this.colStep.Width = 126;
            // 
            // colFinishDate
            // 
            this.colFinishDate.Tag = "finishDate";
            this.colFinishDate.Text = "FinishDate";
            this.colFinishDate.Width = 171;
            // 
            // lblStepMap
            // 
            this.lblStepMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStepMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStepMap.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStepMap.Location = new System.Drawing.Point(11, 284);
            this.lblStepMap.Name = "lblStepMap";
            this.lblStepMap.Size = new System.Drawing.Size(212, 22);
            this.lblStepMap.TabIndex = 11;
            this.lblStepMap.Tag = "stepMap";
            this.lblStepMap.Text = "stepMap";
            this.lblStepMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtEquipmentGroup, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.txtAvailablePath, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label30, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtStepStatus, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label35, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.txtStage, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.label36, 0, 7);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(332, 41);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(290, 228);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // txtEquipmentGroup
            // 
            this.txtEquipmentGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipmentGroup.Location = new System.Drawing.Point(129, 199);
            this.txtEquipmentGroup.Name = "txtEquipmentGroup";
            this.txtEquipmentGroup.ReadOnly = true;
            this.txtEquipmentGroup.Size = new System.Drawing.Size(158, 26);
            this.txtEquipmentGroup.TabIndex = 22;
            // 
            // txtAvailablePath
            // 
            this.txtAvailablePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAvailablePath.Location = new System.Drawing.Point(129, 31);
            this.txtAvailablePath.Multiline = true;
            this.txtAvailablePath.Name = "txtAvailablePath";
            this.txtAvailablePath.ReadOnly = true;
            this.tableLayoutPanel5.SetRowSpan(this.txtAvailablePath, 5);
            this.txtAvailablePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAvailablePath.Size = new System.Drawing.Size(158, 134);
            this.txtAvailablePath.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 34);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(112, 16);
            this.label30.TabIndex = 11;
            this.label30.Tag = "availablePath";
            this.label30.Text = "availablePath";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStepStatus
            // 
            this.txtStepStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStepStatus.Location = new System.Drawing.Point(129, 3);
            this.txtStepStatus.Name = "txtStepStatus";
            this.txtStepStatus.ReadOnly = true;
            this.txtStepStatus.Size = new System.Drawing.Size(158, 26);
            this.txtStepStatus.TabIndex = 10;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(35, 6);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 16);
            this.label31.TabIndex = 0;
            this.label31.Tag = "stepStatus";
            this.label31.Text = "stepStatus";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(75, 174);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 16);
            this.label35.TabIndex = 18;
            this.label35.Tag = "stage";
            this.label35.Text = "stage";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStage
            // 
            this.txtStage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStage.Location = new System.Drawing.Point(129, 171);
            this.txtStage.Name = "txtStage";
            this.txtStage.ReadOnly = true;
            this.txtStage.Size = new System.Drawing.Size(158, 26);
            this.txtStage.TabIndex = 20;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 204);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(120, 16);
            this.label36.TabIndex = 21;
            this.label36.Tag = "equipmentGroup";
            this.label36.Text = "equipmentGroup";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtWaitTime, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.txtStepDescription, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label24, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtStepId, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label25, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtCurrentRule, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label26, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtRuleIndex, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label27, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label28, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtMoveOutDate, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtMoveInDate, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.label29, 0, 7);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(11, 41);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 228);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWaitTime.Location = new System.Drawing.Point(105, 199);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.ReadOnly = true;
            this.txtWaitTime.Size = new System.Drawing.Size(176, 26);
            this.txtWaitTime.TabIndex = 22;
            // 
            // txtStepDescription
            // 
            this.txtStepDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStepDescription.Location = new System.Drawing.Point(105, 31);
            this.txtStepDescription.Multiline = true;
            this.txtStepDescription.Name = "txtStepDescription";
            this.txtStepDescription.ReadOnly = true;
            this.tableLayoutPanel4.SetRowSpan(this.txtStepDescription, 2);
            this.txtStepDescription.Size = new System.Drawing.Size(176, 50);
            this.txtStepDescription.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 16);
            this.label24.TabIndex = 11;
            this.label24.Tag = "description";
            this.label24.Text = "Description";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStepId
            // 
            this.txtStepId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStepId.Location = new System.Drawing.Point(105, 3);
            this.txtStepId.Name = "txtStepId";
            this.txtStepId.ReadOnly = true;
            this.txtStepId.Size = new System.Drawing.Size(176, 26);
            this.txtStepId.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(43, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 16);
            this.label23.TabIndex = 0;
            this.label23.Tag = "stepId";
            this.label23.Text = "StepId";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 16);
            this.label25.TabIndex = 13;
            this.label25.Tag = "currentRule";
            this.label25.Text = "CurrentRule";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentRule
            // 
            this.txtCurrentRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentRule.Location = new System.Drawing.Point(105, 87);
            this.txtCurrentRule.Name = "txtCurrentRule";
            this.txtCurrentRule.ReadOnly = true;
            this.txtCurrentRule.Size = new System.Drawing.Size(176, 26);
            this.txtCurrentRule.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 118);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 16);
            this.label26.TabIndex = 15;
            this.label26.Tag = "ruleIndex";
            this.label26.Text = "RuleIndex";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRuleIndex
            // 
            this.txtRuleIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuleIndex.Location = new System.Drawing.Point(105, 115);
            this.txtRuleIndex.Name = "txtRuleIndex";
            this.txtRuleIndex.ReadOnly = true;
            this.txtRuleIndex.Size = new System.Drawing.Size(176, 26);
            this.txtRuleIndex.TabIndex = 16;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 146);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 16);
            this.label27.TabIndex = 17;
            this.label27.Tag = "moveOutDate";
            this.label27.Text = "moveOutDate";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 174);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 16);
            this.label28.TabIndex = 18;
            this.label28.Tag = "moveInDate";
            this.label28.Text = "moveInDate";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMoveOutDate
            // 
            this.txtMoveOutDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoveOutDate.Location = new System.Drawing.Point(105, 143);
            this.txtMoveOutDate.Name = "txtMoveOutDate";
            this.txtMoveOutDate.ReadOnly = true;
            this.txtMoveOutDate.Size = new System.Drawing.Size(176, 26);
            this.txtMoveOutDate.TabIndex = 19;
            // 
            // txtMoveInDate
            // 
            this.txtMoveInDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoveInDate.Location = new System.Drawing.Point(105, 171);
            this.txtMoveInDate.Name = "txtMoveInDate";
            this.txtMoveInDate.ReadOnly = true;
            this.txtMoveInDate.Size = new System.Drawing.Size(176, 26);
            this.txtMoveInDate.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(27, 204);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 16);
            this.label29.TabIndex = 21;
            this.label29.Tag = "waitTime";
            this.label29.Text = "waitTime";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.ForeColor = System.Drawing.SystemColors.Window;
            this.label22.Location = new System.Drawing.Point(11, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(212, 22);
            this.label22.TabIndex = 8;
            this.label22.Tag = "step";
            this.label22.Text = "Step";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMaterialTracking
            // 
            this.tabMaterialTracking.Controls.Add(this.btnExportMaterialTracking);
            this.tabMaterialTracking.Controls.Add(this.lvwMaterialTracking);
            this.tabMaterialTracking.Controls.Add(this.cboMaterialTrackingStep);
            this.tabMaterialTracking.Controls.Add(this.label33);
            this.tabMaterialTracking.Location = new System.Drawing.Point(4, 26);
            this.tabMaterialTracking.Name = "tabMaterialTracking";
            this.tabMaterialTracking.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterialTracking.Size = new System.Drawing.Size(665, 550);
            this.tabMaterialTracking.TabIndex = 6;
            this.tabMaterialTracking.Tag = "materialTracking";
            this.tabMaterialTracking.Text = "materialTracking";
            this.tabMaterialTracking.UseVisualStyleBackColor = true;
            // 
            // btnExportMaterialTracking
            // 
            this.btnExportMaterialTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportMaterialTracking.Location = new System.Drawing.Point(550, 404);
            this.btnExportMaterialTracking.Name = "btnExportMaterialTracking";
            this.btnExportMaterialTracking.Size = new System.Drawing.Size(79, 31);
            this.btnExportMaterialTracking.TabIndex = 27;
            this.btnExportMaterialTracking.Tag = "buttonExport";
            this.btnExportMaterialTracking.Text = "Export";
            this.btnExportMaterialTracking.UseVisualStyleBackColor = true;
            this.btnExportMaterialTracking.Click += new System.EventHandler(this.btnExportMaterialTracking_Click);
            // 
            // lvwMaterialTracking
            // 
            this.lvwMaterialTracking.BackColor = System.Drawing.SystemColors.Control;
            this.lvwMaterialTracking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader8});
            this.lvwMaterialTracking.FullRowSelect = true;
            this.lvwMaterialTracking.Location = new System.Drawing.Point(19, 39);
            this.lvwMaterialTracking.Name = "lvwMaterialTracking";
            this.lvwMaterialTracking.Size = new System.Drawing.Size(610, 359);
            this.lvwMaterialTracking.TabIndex = 26;
            this.lvwMaterialTracking.UseCompatibleStateImageBehavior = false;
            this.lvwMaterialTracking.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "step";
            this.columnHeader1.Text = "Step";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "materialType";
            this.columnHeader2.Text = "materialType";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "materialPartNo";
            this.columnHeader4.Text = "materialPartNo";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "materialLotId";
            this.columnHeader5.Text = "materialLotId";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Tag = "position";
            this.columnHeader7.Text = "position";
            this.columnHeader7.Width = 53;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "setupUser";
            this.columnHeader6.Text = "seupUser";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Tag = "trackInDate";
            this.columnHeader8.Text = "trackInDate";
            this.columnHeader8.Width = 120;
            // 
            // cboMaterialTrackingStep
            // 
            this.cboMaterialTrackingStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterialTrackingStep.FormattingEnabled = true;
            this.cboMaterialTrackingStep.ItemHeight = 16;
            this.cboMaterialTrackingStep.Location = new System.Drawing.Point(80, 12);
            this.cboMaterialTrackingStep.MaxDropDownItems = 20;
            this.cboMaterialTrackingStep.Name = "cboMaterialTrackingStep";
            this.cboMaterialTrackingStep.Size = new System.Drawing.Size(276, 24);
            this.cboMaterialTrackingStep.TabIndex = 25;
            this.cboMaterialTrackingStep.SelectedIndexChanged += new System.EventHandler(this.cboMaterialTrackingStep_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(19, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 16);
            this.label33.TabIndex = 24;
            this.label33.Tag = "step";
            this.label33.Text = "step";
            // 
            // tabTooling
            // 
            this.tabTooling.Controls.Add(this.btnExportTooling);
            this.tabTooling.Controls.Add(this.lvwTooling);
            this.tabTooling.Controls.Add(this.cboToolingStep);
            this.tabTooling.Controls.Add(this.label32);
            this.tabTooling.Location = new System.Drawing.Point(4, 26);
            this.tabTooling.Name = "tabTooling";
            this.tabTooling.Size = new System.Drawing.Size(665, 550);
            this.tabTooling.TabIndex = 7;
            this.tabTooling.Tag = "Tooling";
            this.tabTooling.Text = "Tooling";
            this.tabTooling.UseVisualStyleBackColor = true;
            // 
            // btnExportTooling
            // 
            this.btnExportTooling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportTooling.Location = new System.Drawing.Point(550, 404);
            this.btnExportTooling.Name = "btnExportTooling";
            this.btnExportTooling.Size = new System.Drawing.Size(79, 31);
            this.btnExportTooling.TabIndex = 31;
            this.btnExportTooling.Tag = "buttonExport";
            this.btnExportTooling.Text = "Export";
            this.btnExportTooling.UseVisualStyleBackColor = true;
            this.btnExportTooling.Click += new System.EventHandler(this.btnExportTooling_Click);
            // 
            // lvwTooling
            // 
            this.lvwTooling.BackColor = System.Drawing.SystemColors.Control;
            this.lvwTooling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lvwTooling.FullRowSelect = true;
            this.lvwTooling.Location = new System.Drawing.Point(19, 39);
            this.lvwTooling.Name = "lvwTooling";
            this.lvwTooling.Size = new System.Drawing.Size(610, 359);
            this.lvwTooling.TabIndex = 30;
            this.lvwTooling.UseCompatibleStateImageBehavior = false;
            this.lvwTooling.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Tag = "step";
            this.columnHeader10.Text = "Step";
            this.columnHeader10.Width = 86;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Tag = "ToolingId";
            this.columnHeader11.Text = "ToolingId";
            this.columnHeader11.Width = 77;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Tag = "ToolingPart";
            this.columnHeader12.Text = "ToolingPart";
            this.columnHeader12.Width = 96;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Tag = "CurrentCount";
            this.columnHeader13.Text = "CurrentCount";
            this.columnHeader13.Width = 85;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Tag = "UsedCount";
            this.columnHeader14.Text = "UsedCount";
            this.columnHeader14.Width = 53;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Tag = "setupUser";
            this.columnHeader15.Text = "seupUser";
            this.columnHeader15.Width = 74;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Tag = "trackInDate";
            this.columnHeader16.Text = "trackInDate";
            this.columnHeader16.Width = 120;
            // 
            // cboToolingStep
            // 
            this.cboToolingStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToolingStep.FormattingEnabled = true;
            this.cboToolingStep.ItemHeight = 16;
            this.cboToolingStep.Location = new System.Drawing.Point(80, 12);
            this.cboToolingStep.MaxDropDownItems = 20;
            this.cboToolingStep.Name = "cboToolingStep";
            this.cboToolingStep.Size = new System.Drawing.Size(276, 24);
            this.cboToolingStep.TabIndex = 29;
            this.cboToolingStep.SelectedIndexChanged += new System.EventHandler(this.cboToolingStep_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(19, 15);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 16);
            this.label32.TabIndex = 28;
            this.label32.Tag = "step";
            this.label32.Text = "step";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(596, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 625);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(889, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // colStepDCActivity
            // 
            this.colStepDCActivity.DisplayIndex = 1;
            this.colStepDCActivity.Tag = "activity";
            this.colStepDCActivity.Text = "Activity";
            this.colStepDCActivity.Width = 80;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(889, 650);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "LotProperty";
            this.Text = "LotProperty";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabMembers.ResumeLayout(false);
            this.tabMembers.PerformLayout();
            this.tblMembers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabFutureAction.ResumeLayout(false);
            this.tabParentChild.ResumeLayout(false);
            this.tabParentChild.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabStepDC.ResumeLayout(false);
            this.tabStepDC.PerformLayout();
            this.tabStep.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabMaterialTracking.ResumeLayout(false);
            this.tabMaterialTracking.PerformLayout();
            this.tabTooling.ResumeLayout(false);
            this.tabTooling.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private mesRelease.Controls.LotInfomation lotInfomation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnQueryHistory;
        private System.Windows.Forms.ListView lvwLotHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader activity;
        private System.Windows.Forms.ColumnHeader step_id;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader modify_user;
        private System.Windows.Forms.ColumnHeader modify_date;
        private System.Windows.Forms.Button btnHistoryDetail;
        private System.Windows.Forms.Button btnExportHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrentQty;
        private System.Windows.Forms.TextBox txtStartQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvwCarrier;
        private System.Windows.Forms.ColumnHeader colCarrierId;
        private System.Windows.Forms.ColumnHeader colCarrierQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvwComponents;
        private System.Windows.Forms.ColumnHeader colComponentId;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colIntegrity;
        private System.Windows.Forms.ColumnHeader colComCarrierId;
        private System.Windows.Forms.TabPage tabFutureAction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lvwWI;
        private System.Windows.Forms.ColumnHeader colWorkingInstruction;
        private System.Windows.Forms.ColumnHeader colWIStep;
        private System.Windows.Forms.ColumnHeader colWIModifyUser;
        private System.Windows.Forms.ListView lvwFutureHold;
        private System.Windows.Forms.ColumnHeader colFutureHoldReason;
        private System.Windows.Forms.ColumnHeader colFutureHoldStep;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lvwQTime;
        private System.Windows.Forms.ColumnHeader colFromStep;
        private System.Windows.Forms.ColumnHeader colFromHandle;
        private System.Windows.Forms.ColumnHeader colToStep;
        private System.Windows.Forms.ColumnHeader colToHandle;
        private System.Windows.Forms.ColumnHeader colStartMonTime;
        private System.Windows.Forms.ColumnHeader colQTime;
        private System.Windows.Forms.ColumnHeader colRemainTime;
        private System.Windows.Forms.TabPage tabParentChild;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtMergeParent;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSplitParent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTopParent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSourceParent;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListView lvwChildLot;
        private System.Windows.Forms.ColumnHeader colChildLotId;
        private System.Windows.Forms.ColumnHeader colChildLotQty;
        private System.Windows.Forms.ColumnHeader colChildLotStatus;
        private System.Windows.Forms.ColumnHeader colChildLotStep;
        private System.Windows.Forms.TabPage tabStepDC;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboStep;
        private System.Windows.Forms.ListView lvwStepDC;
        private System.Windows.Forms.ColumnHeader colStepDCStep;
        private System.Windows.Forms.ColumnHeader colStepDC;
        private System.Windows.Forms.ColumnHeader colStepDCDescription;
        private System.Windows.Forms.ColumnHeader colStepDCValue;
        private System.Windows.Forms.ColumnHeader colStepDCModifyDate;
        private System.Windows.Forms.TabPage tabStep;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtStepDescription;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtStepId;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCurrentRule;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtRuleIndex;
        private System.Windows.Forms.TextBox txtWaitTime;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMoveOutDate;
        private System.Windows.Forms.TextBox txtMoveInDate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtEquipmentGroup;
        private System.Windows.Forms.TextBox txtAvailablePath;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtStepStatus;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblStepMap;
        private System.Windows.Forms.ListView lvwStepMap;
        private System.Windows.Forms.ColumnHeader colStepHandle;
        private System.Windows.Forms.ColumnHeader colStep;
        private System.Windows.Forms.ColumnHeader colFinishDate;
        private System.Windows.Forms.TabPage tabMaterialTracking;
        private System.Windows.Forms.Button btnExportStepDC;
        private System.Windows.Forms.Button btnExportMaterialTracking;
        private System.Windows.Forms.ListView lvwMaterialTracking;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cboMaterialTrackingStep;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TableLayoutPanel tblMembers;
        private System.Windows.Forms.TabPage tabTooling;
        private System.Windows.Forms.Button btnExportTooling;
        private System.Windows.Forms.ListView lvwTooling;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ComboBox cboToolingStep;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ColumnHeader colStepDCActivity;

    }
}