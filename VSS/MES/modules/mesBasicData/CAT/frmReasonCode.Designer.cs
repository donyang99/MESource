namespace mesBasicData
{
    partial class frmReasonCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReasonCode));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboReasonType = new System.Windows.Forms.ComboBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.lblReasonCode = new System.Windows.Forms.Label();
            this.txtReasonCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReasonType = new System.Windows.Forms.Label();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pnlExt);
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(877, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editReasonCode";
            this.groupBox1.Text = "editReasonCode";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 83);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(871, 28);
            this.pnlExt.TabIndex = 6;
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
            this.tblDetail.Controls.Add(this.label1, 2, 1);
            this.tblDetail.Controls.Add(this.txtLanguage, 1, 1);
            this.tblDetail.Controls.Add(this.lblDescription, 0, 1);
            this.tblDetail.Controls.Add(this.cboReasonType, 5, 0);
            this.tblDetail.Controls.Add(this.cboDept, 3, 0);
            this.tblDetail.Controls.Add(this.lblReasonCode, 0, 0);
            this.tblDetail.Controls.Add(this.txtReasonCode, 1, 0);
            this.tblDetail.Controls.Add(this.label2, 2, 0);
            this.tblDetail.Controls.Add(this.lblReasonType, 4, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(871, 64);
            this.tblDetail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(396, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Tag = "en-US";
            this.label1.Text = "en-US";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLanguage.Location = new System.Drawing.Point(105, 35);
            this.txtLanguage.MaxLength = 50;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(285, 26);
            this.txtLanguage.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(3, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Tag = "description";
            this.lblDescription.Text = "Description";
            // 
            // cboReasonType
            // 
            this.cboReasonType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboReasonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReasonType.FormattingEnabled = true;
            this.cboReasonType.Location = new System.Drawing.Point(740, 6);
            this.cboReasonType.Name = "cboReasonType";
            this.cboReasonType.Size = new System.Drawing.Size(128, 24);
            this.cboReasonType.Sorted = true;
            this.cboReasonType.TabIndex = 2;
            // 
            // cboDept
            // 
            this.cboDept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(484, 6);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(156, 24);
            this.cboDept.Sorted = true;
            this.cboDept.TabIndex = 1;
            // 
            // lblReasonCode
            // 
            this.lblReasonCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReasonCode.AutoSize = true;
            this.lblReasonCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonCode.Location = new System.Drawing.Point(9, 7);
            this.lblReasonCode.Name = "lblReasonCode";
            this.lblReasonCode.Size = new System.Drawing.Size(90, 18);
            this.lblReasonCode.TabIndex = 0;
            this.lblReasonCode.Tag = "ReasonCode";
            this.lblReasonCode.Text = "ReasonCode";
            this.lblReasonCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReasonCode
            // 
            this.txtReasonCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReasonCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtReasonCode.Location = new System.Drawing.Point(105, 3);
            this.txtReasonCode.MaxLength = 20;
            this.txtReasonCode.Name = "txtReasonCode";
            this.txtReasonCode.Size = new System.Drawing.Size(285, 26);
            this.txtReasonCode.TabIndex = 0;
            this.txtReasonCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtReasonCode_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(396, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Tag = "ownerDept";
            this.label2.Text = "ownerDept";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReasonType
            // 
            this.lblReasonType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReasonType.AutoSize = true;
            this.lblReasonType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonType.Location = new System.Drawing.Point(646, 8);
            this.lblReasonType.Name = "lblReasonType";
            this.lblReasonType.Size = new System.Drawing.Size(88, 16);
            this.lblReasonType.TabIndex = 4;
            this.lblReasonType.Tag = "reasonType";
            this.lblReasonType.Text = "reasonType";
            // 
            // mesListView1
            // 
            this.mesListView1.allowUserFilter = true;
            this.mesListView1.allowUserSorting = true;
            this.mesListView1.autoSizeColumn = true;
            this.mesListView1.careModifyDate = false;
            this.mesListView1.columnHide = null;
            this.mesListView1.columnNames = new string[] {
        "name",
        "ownerDept",
        "reasonType",
        "description",
        "createUser",
        "createDate",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "ReasonCode",
        "ownerDept",
        "reasonType",
        "description",
        "createUser",
        "createDate",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesListView1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesListView1.FullRowSelect = true;
            this.mesListView1.GridLines = true;
            this.mesListView1.HideSelection = false;
            this.mesListView1.imageKeyColumn = "";
            this.mesListView1.keyPressSearch = false;
            this.mesListView1.keyPressSearchColumn = "";
            this.mesListView1.Location = new System.Drawing.Point(0, 139);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(877, 353);
            this.mesListView1.TabIndex = 4;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(877, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmReasonCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(877, 492);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReasonCode";
            this.Tag = "ReasonCode";
            this.Text = "frmReasonCode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmReasonCode_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReasonCode_FormClosed);
            this.Load += new System.EventHandler(this.frmReasonCode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReasonCode;
        private System.Windows.Forms.Label lblReasonCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDept;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.ComboBox cboReasonType;
        private System.Windows.Forms.Label lblReasonType;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
    }
}