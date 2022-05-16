namespace alarmModule
{
    partial class frmAlarmType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlarmType));
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.cboReasonGroup = new System.Windows.Forms.ComboBox();
            this.lblReasonGroup = new System.Windows.Forms.Label();
            this.txtAlarmType = new System.Windows.Forms.TextBox();
            this.lblAlarmType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lvwAlarmType = new idv.mesCore.Controls.MESListView();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(785, 25);
            this.actionToolbar1.TabIndex = 6;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pnlExt);
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 5;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Controls.Add(this.cboReasonGroup, 3, 0);
            this.tblDetail.Controls.Add(this.lblReasonGroup, 2, 0);
            this.tblDetail.Controls.Add(this.txtAlarmType, 1, 0);
            this.tblDetail.Controls.Add(this.lblAlarmType, 0, 0);
            this.tblDetail.Controls.Add(this.lblDescription, 0, 1);
            this.tblDetail.Controls.Add(this.txtDescription, 1, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Location = new System.Drawing.Point(3, 26);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(779, 72);
            this.tblDetail.TabIndex = 0;
            // 
            // cboReasonGroup
            // 
            this.cboReasonGroup.FormattingEnabled = true;
            this.cboReasonGroup.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboReasonGroup.Location = new System.Drawing.Point(460, 3);
            this.cboReasonGroup.MaxLength = 40;
            this.cboReasonGroup.Name = "cboReasonGroup";
            this.cboReasonGroup.Size = new System.Drawing.Size(230, 28);
            this.cboReasonGroup.Sorted = true;
            this.cboReasonGroup.TabIndex = 1;
            // 
            // lblReasonGroup
            // 
            this.lblReasonGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReasonGroup.AutoSize = true;
            this.lblReasonGroup.Location = new System.Drawing.Point(335, 8);
            this.lblReasonGroup.Name = "lblReasonGroup";
            this.lblReasonGroup.Size = new System.Drawing.Size(119, 20);
            this.lblReasonGroup.TabIndex = 9;
            this.lblReasonGroup.Tag = "reasonGroup";
            this.lblReasonGroup.Text = "ReasonGroup";
            // 
            // txtAlarmType
            // 
            this.txtAlarmType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlarmType.BackColor = System.Drawing.SystemColors.Info;
            this.txtAlarmType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtAlarmType.Location = new System.Drawing.Point(128, 3);
            this.txtAlarmType.MaxLength = 40;
            this.txtAlarmType.Name = "txtAlarmType";
            this.txtAlarmType.Size = new System.Drawing.Size(201, 30);
            this.txtAlarmType.TabIndex = 0;
            // 
            // lblAlarmType
            // 
            this.lblAlarmType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlarmType.AutoSize = true;
            this.lblAlarmType.Location = new System.Drawing.Point(3, 8);
            this.lblAlarmType.Name = "lblAlarmType";
            this.lblAlarmType.Size = new System.Drawing.Size(89, 20);
            this.lblAlarmType.TabIndex = 2;
            this.lblAlarmType.Tag = "alarmType";
            this.lblAlarmType.Text = "報警類型";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(119, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Tag = "description";
            this.lblDescription.Text = "description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDetail.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDescription.Location = new System.Drawing.Point(128, 39);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(562, 30);
            this.txtDescription.TabIndex = 2;
            // 
            // lvwAlarmType
            // 
            this.lvwAlarmType.allowUserFilter = true;
            this.lvwAlarmType.allowUserSorting = true;
            this.lvwAlarmType.autoSizeColumn = true;
            this.lvwAlarmType.careModifyDate = false;
            this.lvwAlarmType.columnHide = null;
            this.lvwAlarmType.columnNames = new string[] {
        "name",
        "reasonGroup",
        "description",
        "modifyUser",
        "modifyDate"};
            this.lvwAlarmType.columnTags = new string[] {
        "alarmType",
        "reasonGroup",
        "description",
        "modifyUser",
        "modifyDate"};
            this.lvwAlarmType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAlarmType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAlarmType.FullRowSelect = true;
            this.lvwAlarmType.GridLines = true;
            this.lvwAlarmType.HideSelection = false;
            this.lvwAlarmType.imageKeyColumn = "";
            this.lvwAlarmType.keyPressSearch = false;
            this.lvwAlarmType.keyPressSearchColumn = "";
            this.lvwAlarmType.Location = new System.Drawing.Point(0, 154);
            this.lvwAlarmType.makesureNewItemVisible = true;
            this.lvwAlarmType.MultiSelect = false;
            this.lvwAlarmType.Name = "lvwAlarmType";
            this.lvwAlarmType.OwnerDraw = true;
            this.lvwAlarmType.ShowItemTipSecond = ((byte)(3));
            this.lvwAlarmType.Size = new System.Drawing.Size(785, 277);
            this.lvwAlarmType.TabIndex = 3;
            this.lvwAlarmType.UseCompatibleStateImageBehavior = false;
            this.lvwAlarmType.View = System.Windows.Forms.View.Details;
            this.lvwAlarmType.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwAlarmType_MESItemSelectionChanged);
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 98);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(779, 28);
            this.pnlExt.TabIndex = 7;
            // 
            // frmAlarmType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(785, 431);
            this.Controls.Add(this.lvwAlarmType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlarmType";
            this.Tag = "alarmType";
            this.Text = "frmAlarmType";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAlarmType_FormClosed);
            this.Load += new System.EventHandler(this.frmAlarmType_Load);
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
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtAlarmType;
        private System.Windows.Forms.Label lblAlarmType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private idv.mesCore.Controls.MESListView lvwAlarmType;
        private System.Windows.Forms.ComboBox cboReasonGroup;
        private System.Windows.Forms.Label lblReasonGroup;
        private System.Windows.Forms.Panel pnlExt;
    }
}