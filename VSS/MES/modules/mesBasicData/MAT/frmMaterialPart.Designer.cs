namespace mesBasicData
{
    partial class frmMaterialPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialPart));
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.cboMaterialType = new System.Windows.Forms.ComboBox();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblMaterialPart = new System.Windows.Forms.Label();
            this.txtMaterialPart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
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
        "name",
        "materialType",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "materialPart",
        "materialType",
        "description",
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
            this.mesListView1.Size = new System.Drawing.Size(1000, 276);
            this.mesListView1.TabIndex = 8;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(1000, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editMaterialPart";
            this.groupBox1.Text = "editMaterialPart";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 51);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(994, 28);
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
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblDetail.Controls.Add(this.cboMaterialType, 3, 0);
            this.tblDetail.Controls.Add(this.lblMaterialType, 2, 0);
            this.tblDetail.Controls.Add(this.lblMaterialPart, 0, 0);
            this.tblDetail.Controls.Add(this.txtMaterialPart, 1, 0);
            this.tblDetail.Controls.Add(this.label4, 4, 0);
            this.tblDetail.Controls.Add(this.txtDescription, 5, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(994, 32);
            this.tblDetail.TabIndex = 0;
            // 
            // cboMaterialType
            // 
            this.cboMaterialType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboMaterialType.BackColor = System.Drawing.SystemColors.Info;
            this.cboMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterialType.FormattingEnabled = true;
            this.cboMaterialType.Location = new System.Drawing.Point(431, 4);
            this.cboMaterialType.Name = "cboMaterialType";
            this.cboMaterialType.Size = new System.Drawing.Size(176, 24);
            this.cboMaterialType.Sorted = true;
            this.cboMaterialType.TabIndex = 1;
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaterialType.Location = new System.Drawing.Point(319, 7);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(106, 18);
            this.lblMaterialType.TabIndex = 11;
            this.lblMaterialType.Tag = "materialType";
            this.lblMaterialType.Text = "materialType";
            this.lblMaterialType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMaterialPart
            // 
            this.lblMaterialPart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaterialPart.AutoSize = true;
            this.lblMaterialPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialPart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaterialPart.Location = new System.Drawing.Point(3, 7);
            this.lblMaterialPart.Name = "lblMaterialPart";
            this.lblMaterialPart.Size = new System.Drawing.Size(106, 18);
            this.lblMaterialPart.TabIndex = 0;
            this.lblMaterialPart.Tag = "materialPart";
            this.lblMaterialPart.Text = "materialPart";
            this.lblMaterialPart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaterialPart
            // 
            this.txtMaterialPart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaterialPart.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaterialPart.Location = new System.Drawing.Point(115, 3);
            this.txtMaterialPart.MaxLength = 40;
            this.txtMaterialPart.Name = "txtMaterialPart";
            this.txtMaterialPart.Size = new System.Drawing.Size(198, 26);
            this.txtMaterialPart.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(613, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(715, 3);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 26);
            this.txtDescription.TabIndex = 2;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(1000, 25);
            this.actionToolbar1.TabIndex = 6;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmMaterialPart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 383);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaterialPart";
            this.Tag = "materialPart";
            this.Text = "frmMaterialPart";
            this.Activated += new System.EventHandler(this.frmMaterialPart_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMaterialPart_FormClosed);
            this.Load += new System.EventHandler(this.frmMaterialPart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.ComboBox cboMaterialType;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Label lblMaterialPart;
        private System.Windows.Forms.TextBox txtMaterialPart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.Panel pnlExt;
    }
}