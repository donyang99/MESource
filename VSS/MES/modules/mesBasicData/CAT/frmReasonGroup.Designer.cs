namespace mesBasicData
{
    partial class frmReasonGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReasonGroup));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReasonGroup = new System.Windows.Forms.Label();
            this.txtReasonGroup = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwSelectedReason = new idv.mesCore.Controls.MESListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwAvailableReason = new idv.mesCore.Controls.MESListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilterReason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lvwReasonGroup = new idv.mesCore.Controls.MESListView();
            this.tblReasonGroup = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox2.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ReasonCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ownerDetp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.pnlExt);
            this.groupBox2.Controls.Add(this.tblDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.groupBox2.Size = new System.Drawing.Size(912, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "editReasonGroup";
            this.groupBox2.Text = "editReasonGroup";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(2, 51);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(908, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 4;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Controls.Add(this.txtDescription, 3, 0);
            this.tblDetail.Controls.Add(this.label4, 2, 0);
            this.tblDetail.Controls.Add(this.lblReasonGroup, 0, 0);
            this.tblDetail.Controls.Add(this.txtReasonGroup, 1, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(2, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(908, 32);
            this.tblDetail.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(477, 3);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 3, 70, 3);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(361, 26);
            this.txtDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(375, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 2;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReasonGroup
            // 
            this.lblReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReasonGroup.AutoSize = true;
            this.lblReasonGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonGroup.Location = new System.Drawing.Point(3, 7);
            this.lblReasonGroup.Name = "lblReasonGroup";
            this.lblReasonGroup.Size = new System.Drawing.Size(98, 18);
            this.lblReasonGroup.TabIndex = 0;
            this.lblReasonGroup.Tag = "ReasonGroup";
            this.lblReasonGroup.Text = "ReasonGroup";
            this.lblReasonGroup.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReasonGroup
            // 
            this.txtReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReasonGroup.BackColor = System.Drawing.SystemColors.Info;
            this.txtReasonGroup.Location = new System.Drawing.Point(107, 3);
            this.txtReasonGroup.MaxLength = 20;
            this.txtReasonGroup.Name = "txtReasonGroup";
            this.txtReasonGroup.Size = new System.Drawing.Size(262, 26);
            this.txtReasonGroup.TabIndex = 1;
            this.txtReasonGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtReasonGroup_KeyUp);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 350);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(912, 5);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 355);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(912, 268);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnUnSelect, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnSelect, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(436, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(39, 262);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Enabled = false;
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ImageKey = "right.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(3, 134);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelect.TabIndex = 0;
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "down.ico");
            this.imageList1.Images.SetKeyName(1, "left.ico");
            this.imageList1.Images.SetKeyName(2, "right.ico");
            this.imageList1.Images.SetKeyName(3, "up.ico");
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ImageKey = "left.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(3, 74);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvwSelectedReason);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 262);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "selectedList";
            this.groupBox1.Text = "selectedList";
            // 
            // lvwSelectedReason
            // 
            this.lvwSelectedReason.allowUserFilter = false;
            this.lvwSelectedReason.allowUserSorting = true;
            this.lvwSelectedReason.autoSizeColumn = true;
            this.lvwSelectedReason.careModifyDate = false;
            this.lvwSelectedReason.columnHide = null;
            this.lvwSelectedReason.columnNames = new string[] {
        "name",
        "ownerDept",
        "description"};
            this.lvwSelectedReason.columnTags = new string[] {
        "ReasonCode",
        "ownerDept",
        "description"};
            this.lvwSelectedReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelectedReason.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSelectedReason.FullRowSelect = true;
            this.lvwSelectedReason.GridLines = true;
            this.lvwSelectedReason.HideSelection = false;
            this.lvwSelectedReason.imageKeyColumn = "";
            this.lvwSelectedReason.keyPressSearch = false;
            this.lvwSelectedReason.keyPressSearchColumn = "";
            this.lvwSelectedReason.Location = new System.Drawing.Point(3, 22);
            this.lvwSelectedReason.makesureNewItemVisible = false;
            this.lvwSelectedReason.MultiSelect = false;
            this.lvwSelectedReason.Name = "lvwSelectedReason";
            this.lvwSelectedReason.OwnerDraw = true;
            this.lvwSelectedReason.ShowItemTipSecond = ((byte)(3));
            this.lvwSelectedReason.Size = new System.Drawing.Size(421, 237);
            this.lvwSelectedReason.TabIndex = 0;
            this.lvwSelectedReason.UseCompatibleStateImageBehavior = false;
            this.lvwSelectedReason.View = System.Windows.Forms.View.Details;
            this.lvwSelectedReason.DoubleClick += new System.EventHandler(this.lvwSelectedReason_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvwAvailableReason);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(481, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(428, 262);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "availableList";
            this.groupBox3.Text = "availableList";
            // 
            // lvwAvailableReason
            // 
            this.lvwAvailableReason.allowUserFilter = false;
            this.lvwAvailableReason.allowUserSorting = true;
            this.lvwAvailableReason.autoSizeColumn = true;
            this.lvwAvailableReason.careModifyDate = false;
            this.lvwAvailableReason.columnHide = null;
            this.lvwAvailableReason.columnNames = new string[] {
        "name",
        "ownerDept",
        "description"};
            this.lvwAvailableReason.columnTags = new string[] {
        "ReasonCode",
        "ownerDept",
        "description"};
            this.lvwAvailableReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailableReason.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAvailableReason.FullRowSelect = true;
            this.lvwAvailableReason.GridLines = true;
            this.lvwAvailableReason.HideSelection = false;
            this.lvwAvailableReason.imageKeyColumn = "";
            this.lvwAvailableReason.keyPressSearch = false;
            this.lvwAvailableReason.keyPressSearchColumn = "";
            this.lvwAvailableReason.Location = new System.Drawing.Point(3, 50);
            this.lvwAvailableReason.makesureNewItemVisible = false;
            this.lvwAvailableReason.MultiSelect = false;
            this.lvwAvailableReason.Name = "lvwAvailableReason";
            this.lvwAvailableReason.OwnerDraw = true;
            this.lvwAvailableReason.ShowItemTipSecond = ((byte)(3));
            this.lvwAvailableReason.Size = new System.Drawing.Size(422, 209);
            this.lvwAvailableReason.TabIndex = 4;
            this.lvwAvailableReason.UseCompatibleStateImageBehavior = false;
            this.lvwAvailableReason.View = System.Windows.Forms.View.Details;
            this.lvwAvailableReason.DoubleClick += new System.EventHandler(this.lvwAvailableReason_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.txtFilterReason);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 31);
            this.panel1.TabIndex = 3;
            // 
            // txtFilterReason
            // 
            this.txtFilterReason.Location = new System.Drawing.Point(97, 2);
            this.txtFilterReason.Name = "txtFilterReason";
            this.txtFilterReason.Size = new System.Drawing.Size(161, 26);
            this.txtFilterReason.TabIndex = 1;
            this.txtFilterReason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilterReason_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Tag = "ReasonCode";
            this.label1.Text = "ReasonCode";
            // 
            // btnFilter
            // 
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFilter.Location = new System.Drawing.Point(259, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(98, 26);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Tag = "addFilter";
            this.btnFilter.Text = "AddFilter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lvwReasonGroup
            // 
            this.lvwReasonGroup.allowUserFilter = false;
            this.lvwReasonGroup.allowUserSorting = true;
            this.lvwReasonGroup.autoSizeColumn = true;
            this.lvwReasonGroup.careModifyDate = false;
            this.lvwReasonGroup.columnHide = null;
            this.lvwReasonGroup.columnNames = new string[] {
        "name",
        "description",
        "createUser",
        "createDate",
        "modifyUser",
        "modifyDate"};
            this.lvwReasonGroup.columnTags = new string[] {
        "ReasonGroup",
        "description",
        "createUser",
        "createDate",
        "modifyUser",
        "modifyDate"};
            this.lvwReasonGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwReasonGroup.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwReasonGroup.FullRowSelect = true;
            this.lvwReasonGroup.GridLines = true;
            this.lvwReasonGroup.HideSelection = false;
            this.lvwReasonGroup.imageKeyColumn = "";
            this.lvwReasonGroup.keyPressSearch = false;
            this.lvwReasonGroup.keyPressSearchColumn = "";
            this.lvwReasonGroup.Location = new System.Drawing.Point(0, 109);
            this.lvwReasonGroup.makesureNewItemVisible = true;
            this.lvwReasonGroup.MultiSelect = false;
            this.lvwReasonGroup.Name = "lvwReasonGroup";
            this.lvwReasonGroup.OwnerDraw = true;
            this.lvwReasonGroup.ShowItemTipSecond = ((byte)(3));
            this.lvwReasonGroup.Size = new System.Drawing.Size(912, 241);
            this.lvwReasonGroup.TabIndex = 6;
            this.lvwReasonGroup.UseCompatibleStateImageBehavior = false;
            this.lvwReasonGroup.View = System.Windows.Forms.View.Details;
            this.lvwReasonGroup.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwReasonGroup_MESItemSelectionChanged);
            // 
            // tblReasonGroup
            // 
            this.tblReasonGroup.apPrivilegeString = "";
            this.tblReasonGroup.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblReasonGroup.functionPrivilegeString = "";
            this.tblReasonGroup.Location = new System.Drawing.Point(0, 0);
            this.tblReasonGroup.modulePrivilegeString = "";
            this.tblReasonGroup.Name = "tblReasonGroup";
            this.tblReasonGroup.Size = new System.Drawing.Size(912, 25);
            this.tblReasonGroup.TabIndex = 0;
            this.tblReasonGroup.Text = "actionToolbar1";
            this.tblReasonGroup.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.tblReasonGroup_ActionClicked);
            // 
            // frmReasonGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lvwReasonGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tblReasonGroup);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReasonGroup";
            this.Tag = "ReasonGroup";
            this.Text = "frmReasonGroup";
            this.Activated += new System.EventHandler(this.frmReasonGroup_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReasonGroup_FormClosed);
            this.Load += new System.EventHandler(this.frmReasonGroup_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar tblReasonGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Label lblReasonGroup;
        private System.Windows.Forms.TextBox txtReasonGroup;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private idv.mesCore.Controls.MESListView lvwSelectedReason;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterReason;
        private System.Windows.Forms.Label label1;
        private idv.mesCore.Controls.MESListView lvwAvailableReason;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUnSelect;
        internal idv.mesCore.Controls.MESListView lvwReasonGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlExt;
    }
}