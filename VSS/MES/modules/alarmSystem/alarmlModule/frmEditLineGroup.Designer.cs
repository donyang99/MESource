namespace alarmModule
{
    partial class frmEditLineGroup
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
            this.lblLineToken = new System.Windows.Forms.Label();
            this.lblLineId = new System.Windows.Forms.Label();
            this.lvwLine = new idv.mesCore.Controls.MESListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colToken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLineId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtLineToken = new System.Windows.Forms.TextBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLineToken
            // 
            this.lblLineToken.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLineToken.AutoSize = true;
            this.lblLineToken.Location = new System.Drawing.Point(227, 8);
            this.lblLineToken.Name = "lblLineToken";
            this.lblLineToken.Size = new System.Drawing.Size(99, 20);
            this.lblLineToken.TabIndex = 9;
            this.lblLineToken.Tag = "token";
            this.lblLineToken.Text = "LineToken";
            // 
            // lblLineId
            // 
            this.lblLineId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLineId.AutoSize = true;
            this.lblLineId.Location = new System.Drawing.Point(3, 8);
            this.lblLineId.Name = "lblLineId";
            this.lblLineId.Size = new System.Drawing.Size(49, 20);
            this.lblLineId.TabIndex = 2;
            this.lblLineId.Tag = "name";
            this.lblLineId.Text = "Name";
            // 
            // lvwLine
            // 
            this.lvwLine.allowUserFilter = true;
            this.lvwLine.allowUserSorting = true;
            this.lvwLine.autoSizeColumn = true;
            this.lvwLine.careModifyDate = false;
            this.lvwLine.columnHide = null;
            this.lvwLine.columnNames = new string[] {
        "name",
        "reasonGroup",
        "description",
        "modifyUser",
        "modifyDate"};
            this.lvwLine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colToken});
            this.lvwLine.columnTags = new string[] {
        "alarmType",
        "reasonGroup",
        "description",
        "modifyUser",
        "modifyDate"};
            this.lvwLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLine.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwLine.FullRowSelect = true;
            this.lvwLine.GridLines = true;
            this.lvwLine.HideSelection = false;
            this.lvwLine.imageKeyColumn = "";
            this.lvwLine.keyPressSearch = false;
            this.lvwLine.keyPressSearchColumn = "";
            this.lvwLine.Location = new System.Drawing.Point(0, 90);
            this.lvwLine.makesureNewItemVisible = true;
            this.lvwLine.MultiSelect = false;
            this.lvwLine.Name = "lvwLine";
            this.lvwLine.OwnerDraw = true;
            this.lvwLine.ShowItemTipSecond = ((byte)(3));
            this.lvwLine.Size = new System.Drawing.Size(859, 305);
            this.lvwLine.TabIndex = 8;
            this.lvwLine.UseCompatibleStateImageBehavior = false;
            this.lvwLine.View = System.Windows.Forms.View.Details;
            this.lvwLine.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwLine_ItemSelectionChanged);
            // 
            // colName
            // 
            this.colName.Tag = "name";
            this.colName.Text = "Name";
            this.colName.Width = 180;
            // 
            // colToken
            // 
            this.colToken.Tag = "token";
            this.colToken.Text = "Token";
            this.colToken.Width = 500;
            // 
            // txtLineId
            // 
            this.txtLineId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLineId.BackColor = System.Drawing.SystemColors.Info;
            this.txtLineId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLineId.Location = new System.Drawing.Point(58, 3);
            this.txtLineId.MaxLength = 40;
            this.txtLineId.Name = "txtLineId";
            this.txtLineId.Size = new System.Drawing.Size(163, 30);
            this.txtLineId.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 5;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Controls.Add(this.lblLineToken, 2, 0);
            this.tblDetail.Controls.Add(this.txtLineId, 1, 0);
            this.tblDetail.Controls.Add(this.lblLineId, 0, 0);
            this.tblDetail.Controls.Add(this.txtLineToken, 3, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Location = new System.Drawing.Point(3, 26);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(853, 36);
            this.tblDetail.TabIndex = 0;
            // 
            // txtLineToken
            // 
            this.txtLineToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLineToken.BackColor = System.Drawing.SystemColors.Info;
            this.txtLineToken.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLineToken.Location = new System.Drawing.Point(332, 3);
            this.txtLineToken.MaxLength = 255;
            this.txtLineToken.Name = "txtLineToken";
            this.txtLineToken.Size = new System.Drawing.Size(498, 30);
            this.txtLineToken.TabIndex = 2;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(859, 25);
            this.actionToolbar1.TabIndex = 9;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmEditLineGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(859, 395);
            this.Controls.Add(this.lvwLine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditLineGroup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEditLineGroup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLineToken;
        private System.Windows.Forms.Label lblLineId;
        private idv.mesCore.Controls.MESListView lvwLine;
        private System.Windows.Forms.TextBox txtLineId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtLineToken;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colToken;

    }
}