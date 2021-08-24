namespace mesBasicData
{
    partial class frmReasonCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReasonCategory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.cboReasonCategory = new System.Windows.Forms.ComboBox();
            this.cboReasonGroup = new System.Windows.Forms.ComboBox();
            this.lblReasonCategory = new System.Windows.Forms.Label();
            this.lblReasonGroup = new System.Windows.Forms.Label();
            this.txtReasonClass = new System.Windows.Forms.TextBox();
            this.lblReasonClass = new System.Windows.Forms.Label();
            this.btnReasonGroup = new System.Windows.Forms.Button();
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
            this.groupBox1.Size = new System.Drawing.Size(967, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editReasonCategory";
            this.groupBox1.Text = "editReasonCategory";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 51);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(961, 28);
            this.pnlExt.TabIndex = 6;
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
            this.tblDetail.Controls.Add(this.cboReasonCategory, 1, 0);
            this.tblDetail.Controls.Add(this.cboReasonGroup, 5, 0);
            this.tblDetail.Controls.Add(this.lblReasonCategory, 0, 0);
            this.tblDetail.Controls.Add(this.lblReasonGroup, 4, 0);
            this.tblDetail.Controls.Add(this.txtReasonClass, 3, 0);
            this.tblDetail.Controls.Add(this.lblReasonClass, 2, 0);
            this.tblDetail.Controls.Add(this.btnReasonGroup, 6, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(961, 32);
            this.tblDetail.TabIndex = 0;
            // 
            // cboReasonCategory
            // 
            this.cboReasonCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboReasonCategory.BackColor = System.Drawing.SystemColors.Info;
            this.cboReasonCategory.FormattingEnabled = true;
            this.cboReasonCategory.IntegralHeight = false;
            this.cboReasonCategory.Items.AddRange(new object[] {
            "CleanCarrier",
            "Common",
            "EqChangeState",
            "Hold",
            "Release",
            "Scrap",
            "TerminateLot"});
            this.cboReasonCategory.Location = new System.Drawing.Point(131, 4);
            this.cboReasonCategory.MaxDropDownItems = 20;
            this.cboReasonCategory.MaxLength = 20;
            this.cboReasonCategory.Name = "cboReasonCategory";
            this.cboReasonCategory.Size = new System.Drawing.Size(190, 24);
            this.cboReasonCategory.Sorted = true;
            this.cboReasonCategory.TabIndex = 5;
            // 
            // cboReasonGroup
            // 
            this.cboReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboReasonGroup.BackColor = System.Drawing.SystemColors.Info;
            this.cboReasonGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReasonGroup.FormattingEnabled = true;
            this.cboReasonGroup.IntegralHeight = false;
            this.cboReasonGroup.Location = new System.Drawing.Point(673, 4);
            this.cboReasonGroup.MaxDropDownItems = 20;
            this.cboReasonGroup.Name = "cboReasonGroup";
            this.cboReasonGroup.Size = new System.Drawing.Size(233, 24);
            this.cboReasonGroup.Sorted = true;
            this.cboReasonGroup.TabIndex = 2;
            // 
            // lblReasonCategory
            // 
            this.lblReasonCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReasonCategory.AutoSize = true;
            this.lblReasonCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonCategory.Location = new System.Drawing.Point(3, 7);
            this.lblReasonCategory.Name = "lblReasonCategory";
            this.lblReasonCategory.Size = new System.Drawing.Size(122, 18);
            this.lblReasonCategory.TabIndex = 0;
            this.lblReasonCategory.Tag = "ReasonCategory";
            this.lblReasonCategory.Text = "ReasonCategory";
            this.lblReasonCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReasonGroup
            // 
            this.lblReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReasonGroup.AutoSize = true;
            this.lblReasonGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonGroup.Location = new System.Drawing.Point(569, 7);
            this.lblReasonGroup.Name = "lblReasonGroup";
            this.lblReasonGroup.Size = new System.Drawing.Size(98, 18);
            this.lblReasonGroup.TabIndex = 2;
            this.lblReasonGroup.Tag = "ReasonGroup";
            this.lblReasonGroup.Text = "ReasonGroup";
            this.lblReasonGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReasonClass
            // 
            this.txtReasonClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReasonClass.BackColor = System.Drawing.SystemColors.Window;
            this.txtReasonClass.Location = new System.Drawing.Point(431, 3);
            this.txtReasonClass.MaxLength = 20;
            this.txtReasonClass.Name = "txtReasonClass";
            this.txtReasonClass.Size = new System.Drawing.Size(132, 26);
            this.txtReasonClass.TabIndex = 1;
            this.txtReasonClass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtReasonCategory_KeyUp);
            // 
            // lblReasonClass
            // 
            this.lblReasonClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReasonClass.AutoSize = true;
            this.lblReasonClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonClass.Location = new System.Drawing.Point(327, 7);
            this.lblReasonClass.Name = "lblReasonClass";
            this.lblReasonClass.Size = new System.Drawing.Size(98, 18);
            this.lblReasonClass.TabIndex = 4;
            this.lblReasonClass.Tag = "ReasonClass";
            this.lblReasonClass.Text = "ReasonClass";
            this.lblReasonClass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReasonGroup
            // 
            this.btnReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReasonGroup.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReasonGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReasonGroup.Location = new System.Drawing.Point(912, 6);
            this.btnReasonGroup.Name = "btnReasonGroup";
            this.btnReasonGroup.Size = new System.Drawing.Size(32, 20);
            this.btnReasonGroup.TabIndex = 5;
            this.btnReasonGroup.Text = "...";
            this.btnReasonGroup.UseVisualStyleBackColor = true;
            this.btnReasonGroup.Click += new System.EventHandler(this.btnReasonGroup_Click);
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
        "reasonClass",
        "reasonGroup",
        "createUser",
        "createDate",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "ReasonCategory",
        "ReasonClass",
        "ReasonGroup",
        "createUser",
        "createDate",
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
            this.mesListView1.Location = new System.Drawing.Point(0, 107);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(967, 423);
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
            this.actionToolbar1.Size = new System.Drawing.Size(967, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmReasonCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 530);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReasonCategory";
            this.Tag = "ReasonCategory";
            this.Text = "frmReasonCategory";
            this.Activated += new System.EventHandler(this.frmReasonCategory_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReasonCategory_FormClosed);
            this.Load += new System.EventHandler(this.frmReasonCategory_Load);
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
        private System.Windows.Forms.ComboBox cboReasonGroup;
        private System.Windows.Forms.Label lblReasonGroup;
        private System.Windows.Forms.Label lblReasonCategory;
        private System.Windows.Forms.TextBox txtReasonClass;
        private System.Windows.Forms.Label lblReasonClass;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Button btnReasonGroup;
        private System.Windows.Forms.ComboBox cboReasonCategory;
        private System.Windows.Forms.Panel pnlExt;
    }
}