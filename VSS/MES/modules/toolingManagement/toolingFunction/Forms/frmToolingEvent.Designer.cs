namespace toolingFunction
{
    partial class frmToolingEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolingEvent));
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.lblLastStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.chkIdeFlag = new System.Windows.Forms.CheckBox();
            this.txtEvent = new System.Windows.Forms.ComboBox();
            this.lblToolingEvent = new System.Windows.Forms.Label();
            this.lblToolingType = new System.Windows.Forms.Label();
            this.cboToolingType = new System.Windows.Forms.ComboBox();
            this.cboLastStatus = new System.Windows.Forms.ComboBox();
            this.lblNextStatus = new System.Windows.Forms.Label();
            this.cboNextStatus = new System.Windows.Forms.ComboBox();
            this.lblReasonGroup = new System.Windows.Forms.Label();
            this.cboReasonGroup = new System.Windows.Forms.ComboBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwLocation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mesListView1
            // 
            this.mesListView1.allowUserFilter = false;
            this.mesListView1.allowUserSorting = true;
            this.mesListView1.autoSizeColumn = true;
            this.mesListView1.careModifyDate = false;
            this.mesListView1.columnHide = null;
            this.mesListView1.columnNames = new string[] {
        "toolingType",
        "name",
        "lastStatus",
        "nextStatus",
        "reasonGroup",
        "locations",
        "ideFlag",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "ToolingType",
        "ToolingEvent",
        "previousState",
        "to_state",
        "ReasonGroup",
        "location",
        "ideFlag",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesListView1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mesListView1.FullRowSelect = true;
            this.mesListView1.GridLines = true;
            this.mesListView1.HideSelection = false;
            this.mesListView1.imageKeyColumn = "";
            this.mesListView1.keyPressSearch = false;
            this.mesListView1.keyPressSearchColumn = "";
            this.mesListView1.Location = new System.Drawing.Point(0, 138);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(698, 481);
            this.mesListView1.TabIndex = 15;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 82);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(928, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // lblLastStatus
            // 
            this.lblLastStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLastStatus.AutoSize = true;
            this.lblLastStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastStatus.Location = new System.Drawing.Point(13, 37);
            this.lblLastStatus.Name = "lblLastStatus";
            this.lblLastStatus.Size = new System.Drawing.Size(88, 16);
            this.lblLastStatus.TabIndex = 13;
            this.lblLastStatus.Tag = "previousState";
            this.lblLastStatus.Text = "lastStatus";
            this.lblLastStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pnlExt);
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 113);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 6;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Controls.Add(this.chkIdeFlag, 5, 0);
            this.tblDetail.Controls.Add(this.txtEvent, 3, 0);
            this.tblDetail.Controls.Add(this.lblToolingEvent, 2, 0);
            this.tblDetail.Controls.Add(this.lblToolingType, 0, 0);
            this.tblDetail.Controls.Add(this.cboToolingType, 1, 0);
            this.tblDetail.Controls.Add(this.lblLastStatus, 0, 1);
            this.tblDetail.Controls.Add(this.cboLastStatus, 1, 1);
            this.tblDetail.Controls.Add(this.lblNextStatus, 2, 1);
            this.tblDetail.Controls.Add(this.cboNextStatus, 3, 1);
            this.tblDetail.Controls.Add(this.lblReasonGroup, 4, 1);
            this.tblDetail.Controls.Add(this.cboReasonGroup, 5, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 22);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(928, 60);
            this.tblDetail.TabIndex = 0;
            // 
            // chkIdeFlag
            // 
            this.chkIdeFlag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkIdeFlag.AutoSize = true;
            this.chkIdeFlag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIdeFlag.Location = new System.Drawing.Point(567, 5);
            this.chkIdeFlag.Name = "chkIdeFlag";
            this.chkIdeFlag.Size = new System.Drawing.Size(91, 20);
            this.chkIdeFlag.TabIndex = 17;
            this.chkIdeFlag.Tag = "ideFlag";
            this.chkIdeFlag.Text = "IDE Flag";
            this.chkIdeFlag.UseVisualStyleBackColor = true;
            // 
            // txtEvent
            // 
            this.txtEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvent.BackColor = System.Drawing.SystemColors.Info;
            this.tblDetail.SetColumnSpan(this.txtEvent, 2);
            this.txtEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtEvent.FormattingEnabled = true;
            this.txtEvent.Location = new System.Drawing.Point(341, 3);
            this.txtEvent.MaxLength = 40;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(220, 24);
            this.txtEvent.TabIndex = 1;
            // 
            // lblToolingEvent
            // 
            this.lblToolingEvent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToolingEvent.AutoSize = true;
            this.lblToolingEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingEvent.Location = new System.Drawing.Point(231, 7);
            this.lblToolingEvent.Name = "lblToolingEvent";
            this.lblToolingEvent.Size = new System.Drawing.Size(104, 16);
            this.lblToolingEvent.TabIndex = 17;
            this.lblToolingEvent.Tag = "ToolingEvent";
            this.lblToolingEvent.Text = "ToolingEvent";
            this.lblToolingEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToolingType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingType.Location = new System.Drawing.Point(3, 6);
            this.lblToolingType.Name = "lblToolingType";
            this.lblToolingType.Size = new System.Drawing.Size(98, 18);
            this.lblToolingType.TabIndex = 10;
            this.lblToolingType.Tag = "ToolingType";
            this.lblToolingType.Text = "ToolingType";
            this.lblToolingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboToolingType
            // 
            this.cboToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboToolingType.BackColor = System.Drawing.SystemColors.Info;
            this.cboToolingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToolingType.FormattingEnabled = true;
            this.cboToolingType.Location = new System.Drawing.Point(107, 5);
            this.cboToolingType.Name = "cboToolingType";
            this.cboToolingType.Size = new System.Drawing.Size(118, 24);
            this.cboToolingType.Sorted = true;
            this.cboToolingType.TabIndex = 0;
            // 
            // cboLastStatus
            // 
            this.cboLastStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLastStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cboLastStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLastStatus.FormattingEnabled = true;
            this.cboLastStatus.Location = new System.Drawing.Point(107, 33);
            this.cboLastStatus.Name = "cboLastStatus";
            this.cboLastStatus.Size = new System.Drawing.Size(118, 24);
            this.cboLastStatus.Sorted = true;
            this.cboLastStatus.TabIndex = 2;
            // 
            // lblNextStatus
            // 
            this.lblNextStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNextStatus.AutoSize = true;
            this.lblNextStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNextStatus.Location = new System.Drawing.Point(247, 37);
            this.lblNextStatus.Name = "lblNextStatus";
            this.lblNextStatus.Size = new System.Drawing.Size(88, 16);
            this.lblNextStatus.TabIndex = 16;
            this.lblNextStatus.Tag = "to_state";
            this.lblNextStatus.Text = "nextStatus";
            this.lblNextStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNextStatus
            // 
            this.cboNextStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboNextStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cboNextStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNextStatus.FormattingEnabled = true;
            this.cboNextStatus.Location = new System.Drawing.Point(341, 33);
            this.cboNextStatus.Name = "cboNextStatus";
            this.cboNextStatus.Size = new System.Drawing.Size(118, 24);
            this.cboNextStatus.Sorted = true;
            this.cboNextStatus.TabIndex = 3;
            // 
            // lblReasonGroup
            // 
            this.lblReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReasonGroup.AutoSize = true;
            this.lblReasonGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonGroup.Location = new System.Drawing.Point(465, 37);
            this.lblReasonGroup.Name = "lblReasonGroup";
            this.lblReasonGroup.Size = new System.Drawing.Size(96, 16);
            this.lblReasonGroup.TabIndex = 17;
            this.lblReasonGroup.Tag = "ReasonGroup";
            this.lblReasonGroup.Text = "ReasonGroup";
            this.lblReasonGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboReasonGroup
            // 
            this.cboReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboReasonGroup.BackColor = System.Drawing.SystemColors.Window;
            this.cboReasonGroup.FormattingEnabled = true;
            this.cboReasonGroup.Location = new System.Drawing.Point(567, 33);
            this.cboReasonGroup.Name = "cboReasonGroup";
            this.cboReasonGroup.Size = new System.Drawing.Size(192, 24);
            this.cboReasonGroup.TabIndex = 4;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(934, 25);
            this.actionToolbar1.TabIndex = 13;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwLocation);
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(698, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 481);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "location";
            this.groupBox2.Text = "location";
            // 
            // lvwLocation
            // 
            this.lvwLocation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwLocation.FullRowSelect = true;
            this.lvwLocation.Location = new System.Drawing.Point(3, 54);
            this.lvwLocation.MultiSelect = false;
            this.lvwLocation.Name = "lvwLocation";
            this.lvwLocation.Size = new System.Drawing.Size(230, 424);
            this.lvwLocation.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwLocation.TabIndex = 15;
            this.lvwLocation.UseCompatibleStateImageBehavior = false;
            this.lvwLocation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "location";
            this.columnHeader1.Text = "location";
            this.columnHeader1.Width = 201;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.btnDeleteLocation, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAddLocation, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtLocation, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(230, 32);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLocation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDeleteLocation.Location = new System.Drawing.Point(185, 3);
            this.btnDeleteLocation.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(44, 26);
            this.btnDeleteLocation.TabIndex = 7;
            this.btnDeleteLocation.Tag = "buttonDelete";
            this.btnDeleteLocation.Text = "Del";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAddLocation.Location = new System.Drawing.Point(139, 3);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(44, 26);
            this.btnAddLocation.TabIndex = 6;
            this.btnAddLocation.Tag = "buttonAdd";
            this.btnAddLocation.Text = "Add";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocation.Location = new System.Drawing.Point(0, 3);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtLocation.MaxLength = 40;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(135, 26);
            this.txtLocation.TabIndex = 5;
            this.txtLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLocation_KeyUp);
            // 
            // frmToolingEvent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 619);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmToolingEvent";
            this.Tag = "ToolingEvent";
            this.Text = "frmToolingEvent";
            this.Activated += new System.EventHandler(this.frmToolingEvent_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmToolingEvent_FormClosed);
            this.Load += new System.EventHandler(this.frmToolingEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Label lblLastStatus;
        private System.Windows.Forms.ComboBox cboToolingType;
        private System.Windows.Forms.Label lblToolingType;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.GroupBox groupBox1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.Label lblNextStatus;
        private System.Windows.Forms.ComboBox cboReasonGroup;
        private System.Windows.Forms.ComboBox cboNextStatus;
        private System.Windows.Forms.ComboBox cboLastStatus;
        private System.Windows.Forms.Label lblReasonGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwLocation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label lblToolingEvent;
        private System.Windows.Forms.ComboBox txtEvent;
        private System.Windows.Forms.CheckBox chkIdeFlag;
    }
}