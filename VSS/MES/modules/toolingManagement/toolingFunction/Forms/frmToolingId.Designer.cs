namespace toolingFunction
{
    partial class frmToolingId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolingId));
            this.cboPartNo = new System.Windows.Forms.ComboBox();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.mnuTxn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlExt = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtToolingId = new System.Windows.Forms.ComboBox();
            this.lblTypeInfo = new System.Windows.Forms.Label();
            this.cboToolingType = new System.Windows.Forms.ComboBox();
            this.lblToolingType = new System.Windows.Forms.Label();
            this.lblToolingId = new System.Windows.Forms.Label();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.chkReachNotice = new System.Windows.Forms.CheckBox();
            this.lblReachUseNotice = new System.Windows.Forms.Label();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.mnuFunctions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPartNo
            // 
            this.cboPartNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPartNo.BackColor = System.Drawing.SystemColors.Info;
            this.cboPartNo.FormattingEnabled = true;
            this.cboPartNo.Location = new System.Drawing.Point(762, 3);
            this.cboPartNo.MaxLength = 40;
            this.cboPartNo.Name = "cboPartNo";
            this.cboPartNo.Size = new System.Drawing.Size(159, 24);
            this.cboPartNo.Sorted = true;
            this.cboPartNo.TabIndex = 2;
            // 
            // mesListView1
            // 
            this.mesListView1.allowUserFilter = false;
            this.mesListView1.allowUserSorting = true;
            this.mesListView1.autoSizeColumn = true;
            this.mesListView1.careModifyDate = false;
            this.mesListView1.columnHide = null;
            this.mesListView1.columnNames = new string[] {
        "name",
        "toolingType",
        "partNo",
        "partDescription",
        "useLimit",
        "useNotice",
        "location",
        "status",
        "lastStatus",
        "currentCount",
        "useCount",
        "totalCount",
        "cleanCount",
        "pmCount",
        "repairCount",
        "setupDate"};
            this.mesListView1.columnTags = new string[] {
        "ToolingId",
        "ToolingType",
        "ToolingPart",
        "description",
        "UseLimit",
        "UseNotice",
        "location",
        "status",
        "previousState",
        "CurrentCount",
        "usedCount",
        "TotalCount",
        "cleanCount",
        "pmCount",
        "RepairCount",
        "SetupTime"};
            this.mesListView1.ContextMenuStrip = this.mnuTxn;
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
            this.mesListView1.Size = new System.Drawing.Size(932, 553);
            this.mesListView1.TabIndex = 15;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            this.mesListView1.DoubleClick += new System.EventHandler(this.mesListView1_DoubleClick);
            // 
            // mnuTxn
            // 
            this.mnuTxn.Font = new System.Drawing.Font("SimSun", 12F);
            this.mnuTxn.Name = "mnuTxn";
            this.mnuTxn.Size = new System.Drawing.Size(61, 4);
            this.mnuTxn.Opening += new System.ComponentModel.CancelEventHandler(this.mnuTxn_Opening);
            this.mnuTxn.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuTxn_ItemClicked);
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 82);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(926, 28);
            this.pnlExt.TabIndex = 6;
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
            this.groupBox1.Size = new System.Drawing.Size(932, 113);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 7;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.Controls.Add(this.cboLocation, 1, 1);
            this.tblDetail.Controls.Add(this.lblLocation, 0, 1);
            this.tblDetail.Controls.Add(this.txtToolingId, 1, 0);
            this.tblDetail.Controls.Add(this.lblTypeInfo, 4, 0);
            this.tblDetail.Controls.Add(this.cboToolingType, 3, 0);
            this.tblDetail.Controls.Add(this.lblToolingType, 2, 0);
            this.tblDetail.Controls.Add(this.lblToolingId, 0, 0);
            this.tblDetail.Controls.Add(this.cboPartNo, 6, 0);
            this.tblDetail.Controls.Add(this.lblPartNo, 5, 0);
            this.tblDetail.Controls.Add(this.lblStatus, 2, 1);
            this.tblDetail.Controls.Add(this.cboStatus, 3, 1);
            this.tblDetail.Controls.Add(this.chkReachNotice, 4, 1);
            this.tblDetail.Controls.Add(this.lblReachUseNotice, 5, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 22);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(926, 60);
            this.tblDetail.TabIndex = 0;
            // 
            // cboLocation
            // 
            this.cboLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(91, 33);
            this.cboLocation.MaxLength = 40;
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(180, 24);
            this.cboLocation.Sorted = true;
            this.cboLocation.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLocation.AutoSize = true;
            this.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLocation.Location = new System.Drawing.Point(11, 36);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(74, 18);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Tag = "location";
            this.lblLocation.Text = "location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtToolingId
            // 
            this.txtToolingId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtToolingId.BackColor = System.Drawing.SystemColors.Info;
            this.txtToolingId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtToolingId.FormattingEnabled = true;
            this.txtToolingId.Location = new System.Drawing.Point(91, 3);
            this.txtToolingId.MaxLength = 40;
            this.txtToolingId.Name = "txtToolingId";
            this.txtToolingId.Size = new System.Drawing.Size(180, 24);
            this.txtToolingId.TabIndex = 0;
            // 
            // lblTypeInfo
            // 
            this.lblTypeInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTypeInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTypeInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeInfo.Location = new System.Drawing.Point(505, 3);
            this.lblTypeInfo.Name = "lblTypeInfo";
            this.lblTypeInfo.Size = new System.Drawing.Size(123, 24);
            this.lblTypeInfo.TabIndex = 99;
            this.lblTypeInfo.Tag = "";
            this.lblTypeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboToolingType
            // 
            this.cboToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboToolingType.BackColor = System.Drawing.SystemColors.Info;
            this.cboToolingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToolingType.FormattingEnabled = true;
            this.cboToolingType.Location = new System.Drawing.Point(381, 5);
            this.cboToolingType.Name = "cboToolingType";
            this.cboToolingType.Size = new System.Drawing.Size(118, 24);
            this.cboToolingType.Sorted = true;
            this.cboToolingType.TabIndex = 1;
            this.cboToolingType.SelectedIndexChanged += new System.EventHandler(this.cboToolingType_SelectedIndexChanged);
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToolingType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingType.Location = new System.Drawing.Point(277, 6);
            this.lblToolingType.Name = "lblToolingType";
            this.lblToolingType.Size = new System.Drawing.Size(98, 18);
            this.lblToolingType.TabIndex = 10;
            this.lblToolingType.Tag = "ToolingType";
            this.lblToolingType.Text = "ToolingType";
            this.lblToolingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToolingId
            // 
            this.lblToolingId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToolingId.AutoSize = true;
            this.lblToolingId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToolingId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingId.Location = new System.Drawing.Point(3, 6);
            this.lblToolingId.Name = "lblToolingId";
            this.lblToolingId.Size = new System.Drawing.Size(82, 18);
            this.lblToolingId.TabIndex = 11;
            this.lblToolingId.Tag = "ToolingId";
            this.lblToolingId.Text = "ToolingId";
            this.lblToolingId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartNo
            // 
            this.lblPartNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPartNo.Location = new System.Drawing.Point(634, 6);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(98, 18);
            this.lblPartNo.TabIndex = 0;
            this.lblPartNo.Tag = "ToolingPart";
            this.lblPartNo.Text = "ToolingPart";
            this.lblPartNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(317, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 18);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Tag = "status";
            this.lblStatus.Text = "status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(381, 33);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(118, 24);
            this.cboStatus.Sorted = true;
            this.cboStatus.TabIndex = 4;
            // 
            // chkReachNotice
            // 
            this.chkReachNotice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkReachNotice.AutoSize = true;
            this.chkReachNotice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkReachNotice.Location = new System.Drawing.Point(613, 38);
            this.chkReachNotice.Name = "chkReachNotice";
            this.chkReachNotice.Size = new System.Drawing.Size(15, 14);
            this.chkReachNotice.TabIndex = 16;
            this.chkReachNotice.Tag = "";
            this.chkReachNotice.UseVisualStyleBackColor = true;
            // 
            // lblReachUseNotice
            // 
            this.lblReachUseNotice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReachUseNotice.AutoSize = true;
            this.lblReachUseNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReachUseNotice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReachUseNotice.Location = new System.Drawing.Point(634, 36);
            this.lblReachUseNotice.Name = "lblReachUseNotice";
            this.lblReachUseNotice.Size = new System.Drawing.Size(122, 18);
            this.lblReachUseNotice.TabIndex = 16;
            this.lblReachUseNotice.Tag = "reachUseNotice";
            this.lblReachUseNotice.Text = "ReachUseNotice";
            this.lblReachUseNotice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblReachUseNotice.Click += new System.EventHandler(this.lblReachUseNotice_Click);
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(932, 25);
            this.actionToolbar1.TabIndex = 13;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // mnuFunctions
            // 
            this.mnuFunctions.Font = new System.Drawing.Font("SimSun", 12F);
            this.mnuFunctions.Name = "mnuTxn";
            this.mnuFunctions.Size = new System.Drawing.Size(61, 4);
            this.mnuFunctions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuFunctions_ItemClicked);
            // 
            // frmToolingId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 691);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToolingId";
            this.Tag = "ToolingId";
            this.Text = "frmToolingId";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmToolingId_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmToolingId_FormClosed);
            this.Load += new System.EventHandler(this.frmToolingId_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.ComboBox cboPartNo;
        private System.Windows.Forms.Label lblTypeInfo;
        private System.Windows.Forms.Label lblToolingId;
        private System.Windows.Forms.ComboBox cboToolingType;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.Label lblToolingType;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.GroupBox groupBox1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.ComboBox txtToolingId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.CheckBox chkReachNotice;
        private System.Windows.Forms.Label lblReachUseNotice;
        private System.Windows.Forms.ContextMenuStrip mnuTxn;
        private System.Windows.Forms.ContextMenuStrip mnuFunctions;
    }
}