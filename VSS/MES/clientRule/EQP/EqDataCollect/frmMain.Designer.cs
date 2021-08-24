namespace ClientRule.EqDataCollect
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFAB = new System.Windows.Forms.ComboBox();
            this.cboEquipmentId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEquipmentType = new System.Windows.Forms.ComboBox();
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwEquipment = new idv.mesCore.Controls.MESListView();
            this.reasonCode1 = new mesRelease.Controls.ReasonCode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.spCnrMain = new System.Windows.Forms.SplitContainer();
            this.tblParmList = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipmentId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCnrMain)).BeginInit();
            this.spCnrMain.Panel1.SuspendLayout();
            this.spCnrMain.Panel2.SuspendLayout();
            this.spCnrMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(917, 544);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 99;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cboState, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboFAB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboEquipmentId, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboEquipmentType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboStepId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStep, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClearAll, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 192);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // cboState
            // 
            this.cboState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(121, 128);
            this.cboState.MaxDropDownItems = 20;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(145, 24);
            this.cboState.Sorted = true;
            this.cboState.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 12;
            this.label6.Tag = "fab";
            this.label6.Text = "fab";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboFAB
            // 
            this.cboFAB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFAB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboFAB.FormattingEnabled = true;
            this.cboFAB.Location = new System.Drawing.Point(121, 8);
            this.cboFAB.MaxDropDownItems = 20;
            this.cboFAB.Name = "cboFAB";
            this.cboFAB.Size = new System.Drawing.Size(145, 24);
            this.cboFAB.Sorted = true;
            this.cboFAB.TabIndex = 5;
            // 
            // cboEquipmentId
            // 
            this.cboEquipmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipmentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEquipmentId.FormattingEnabled = true;
            this.cboEquipmentId.Location = new System.Drawing.Point(121, 98);
            this.cboEquipmentId.MaxDropDownItems = 20;
            this.cboEquipmentId.Name = "cboEquipmentId";
            this.cboEquipmentId.Size = new System.Drawing.Size(145, 24);
            this.cboEquipmentId.Sorted = true;
            this.cboEquipmentId.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 6;
            this.label7.Tag = "equipmentId";
            this.label7.Text = "equipmentId";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 8;
            this.label8.Tag = "equipmentType";
            this.label8.Text = "equipmentType";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboEquipmentType
            // 
            this.cboEquipmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipmentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboEquipmentType.FormattingEnabled = true;
            this.cboEquipmentType.Location = new System.Drawing.Point(121, 68);
            this.cboEquipmentType.MaxDropDownItems = 20;
            this.cboEquipmentType.Name = "cboEquipmentType";
            this.cboEquipmentType.Size = new System.Drawing.Size(145, 24);
            this.cboEquipmentType.Sorted = true;
            this.cboEquipmentType.TabIndex = 7;
            this.cboEquipmentType.SelectedIndexChanged += new System.EventHandler(this.cboEquipmentType_SelectedIndexChanged);
            // 
            // cboStepId
            // 
            this.cboStepId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(121, 38);
            this.cboStepId.MaxDropDownItems = 20;
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(145, 24);
            this.cboStepId.Sorted = true;
            this.cboStepId.TabIndex = 6;
            // 
            // lblStep
            // 
            this.lblStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(75, 42);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(40, 16);
            this.lblStep.TabIndex = 4;
            this.lblStep.Tag = "step";
            this.lblStep.Text = "step";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Location = new System.Drawing.Point(47, 158);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(68, 31);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Tag = "clearAll";
            this.btnClearAll.Text = "clearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(198, 158);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(68, 31);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Tag = "buttonQuery";
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(67, 132);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 16);
            this.lblState.TabIndex = 14;
            this.lblState.Tag = "state";
            this.lblState.Text = "state";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 4;
            this.label1.Tag = "queryCondition";
            this.label1.Text = "queryCondition";
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
            this.splitContainer2.Panel1.Controls.Add(this.lvwEquipment);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.reasonCode1);
            this.splitContainer2.Size = new System.Drawing.Size(644, 544);
            this.splitContainer2.SplitterDistance = 373;
            this.splitContainer2.TabIndex = 99;
            // 
            // lvwEquipment
            // 
            this.lvwEquipment.allowUserFilter = true;
            this.lvwEquipment.allowUserSorting = true;
            this.lvwEquipment.autoSizeColumn = true;
            this.lvwEquipment.careModifyDate = false;
            this.lvwEquipment.columnHide = null;
            this.lvwEquipment.columnNames = null;
            this.lvwEquipment.columnTags = null;
            this.lvwEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEquipment.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwEquipment.FullRowSelect = true;
            this.lvwEquipment.HideSelection = false;
            this.lvwEquipment.imageKeyColumn = "imageKey";
            this.lvwEquipment.keyPressSearch = true;
            this.lvwEquipment.keyPressSearchColumn = "recipe";
            this.lvwEquipment.Location = new System.Drawing.Point(0, 54);
            this.lvwEquipment.makesureNewItemVisible = true;
            this.lvwEquipment.MultiSelect = false;
            this.lvwEquipment.Name = "lvwEquipment";
            this.lvwEquipment.OwnerDraw = true;
            this.lvwEquipment.ShowItemTipSecond = ((byte)(3));
            this.lvwEquipment.Size = new System.Drawing.Size(644, 319);
            this.lvwEquipment.TabIndex = 4;
            this.lvwEquipment.UseCompatibleStateImageBehavior = false;
            this.lvwEquipment.View = System.Windows.Forms.View.Details;
            this.lvwEquipment.MESItemSelectionChanging += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanging(this.lvwEquipment_MESItemSelectionChanging);
            this.lvwEquipment.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwEquipment_MESItemSelectionChanged);
            this.lvwEquipment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvwEquipment_MouseUp);
            // 
            // reasonCode1
            // 
            this.reasonCode1.comments = "";
            this.reasonCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonCode1.Location = new System.Drawing.Point(0, 0);
            this.reasonCode1.maxDropDownItemCount = 20;
            this.reasonCode1.Name = "reasonCode1";
            this.reasonCode1.required = false;
            this.reasonCode1.showCommentOnly = true;
            this.reasonCode1.Size = new System.Drawing.Size(644, 167);
            this.reasonCode1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(162, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(239, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 544);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(1237, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // spCnrMain
            // 
            this.spCnrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCnrMain.Location = new System.Drawing.Point(0, 0);
            this.spCnrMain.Name = "spCnrMain";
            // 
            // spCnrMain.Panel1
            // 
            this.spCnrMain.Panel1.Controls.Add(this.splitContainer1);
            // 
            // spCnrMain.Panel2
            // 
            this.spCnrMain.Panel2.Controls.Add(this.tblParmList);
            this.spCnrMain.Panel2.Controls.Add(this.panel1);
            this.spCnrMain.Size = new System.Drawing.Size(1237, 544);
            this.spCnrMain.SplitterDistance = 917;
            this.spCnrMain.TabIndex = 0;
            // 
            // tblParmList
            // 
            this.tblParmList.AutoScroll = true;
            this.tblParmList.ColumnCount = 2;
            this.tblParmList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblParmList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblParmList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblParmList.Location = new System.Drawing.Point(0, 0);
            this.tblParmList.Name = "tblParmList";
            this.tblParmList.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tblParmList.RowCount = 1;
            this.tblParmList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblParmList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblParmList.Size = new System.Drawing.Size(316, 509);
            this.tblParmList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 22);
            this.label2.TabIndex = 8;
            this.label2.Tag = "eqpInformation";
            this.label2.Text = "Equipment Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtEquipmentId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(644, 32);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 10;
            this.label3.Tag = "equipmentId";
            this.label3.Text = "equipmentId";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.Location = new System.Drawing.Point(105, 3);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.ReadOnly = true;
            this.txtEquipmentId.Size = new System.Drawing.Size(316, 26);
            this.txtEquipmentId.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1237, 569);
            this.ControlBox = false;
            this.Controls.Add(this.spCnrMain);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "EqDataCollect";
            this.Text = "EqDataCollect";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.spCnrMain.Panel1.ResumeLayout(false);
            this.spCnrMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCnrMain)).EndInit();
            this.spCnrMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.ComboBox cboEquipmentType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEquipmentId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFAB;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.SplitContainer splitContainer2;
        protected internal idv.mesCore.Controls.MESListView lvwEquipment;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblState;
        private mesRelease.Controls.ReasonCode reasonCode1;
        private System.Windows.Forms.SplitContainer spCnrMain;
        private System.Windows.Forms.TableLayoutPanel tblParmList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtEquipmentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}