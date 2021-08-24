namespace mesBasicData
{
    partial class frmFAB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFAB));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtOrgId = new System.Windows.Forms.TextBox();
            this.txtFabCode = new System.Windows.Forms.TextBox();
            this.lblOrgId = new System.Windows.Forms.Label();
            this.lblFabCode = new System.Windows.Forms.Label();
            this.txtFAB = new System.Windows.Forms.TextBox();
            this.lblFAB = new System.Windows.Forms.Label();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(617, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editFab";
            this.groupBox1.Text = "editFAB";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(4, 51);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(609, 28);
            this.pnlExt.TabIndex = 3;
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
            this.tblDetail.Controls.Add(this.txtOrgId, 5, 0);
            this.tblDetail.Controls.Add(this.txtFabCode, 3, 0);
            this.tblDetail.Controls.Add(this.lblOrgId, 4, 0);
            this.tblDetail.Controls.Add(this.lblFabCode, 2, 0);
            this.tblDetail.Controls.Add(this.txtFAB, 1, 0);
            this.tblDetail.Controls.Add(this.lblFAB, 0, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(4, 19);
            this.tblDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Size = new System.Drawing.Size(609, 32);
            this.tblDetail.TabIndex = 2;
            // 
            // txtOrgId
            // 
            this.txtOrgId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOrgId.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrgId.Location = new System.Drawing.Point(418, 3);
            this.txtOrgId.MaxLength = 20;
            this.txtOrgId.Name = "txtOrgId";
            this.txtOrgId.Size = new System.Drawing.Size(92, 26);
            this.txtOrgId.TabIndex = 2;
            // 
            // txtFabCode
            // 
            this.txtFabCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFabCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtFabCode.Location = new System.Drawing.Point(266, 3);
            this.txtFabCode.MaxLength = 20;
            this.txtFabCode.Name = "txtFabCode";
            this.txtFabCode.Size = new System.Drawing.Size(92, 26);
            this.txtFabCode.TabIndex = 1;
            this.txtFabCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblOrgId
            // 
            this.lblOrgId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOrgId.AutoSize = true;
            this.lblOrgId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrgId.Location = new System.Drawing.Point(364, 8);
            this.lblOrgId.Name = "lblOrgId";
            this.lblOrgId.Size = new System.Drawing.Size(48, 16);
            this.lblOrgId.TabIndex = 6;
            this.lblOrgId.Tag = "orgId";
            this.lblOrgId.Text = "OrgId";
            this.lblOrgId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFabCode
            // 
            this.lblFabCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFabCode.AutoSize = true;
            this.lblFabCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFabCode.Location = new System.Drawing.Point(196, 8);
            this.lblFabCode.Name = "lblFabCode";
            this.lblFabCode.Size = new System.Drawing.Size(64, 16);
            this.lblFabCode.TabIndex = 6;
            this.lblFabCode.Tag = "fabCode";
            this.lblFabCode.Text = "FabCode";
            this.lblFabCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFAB
            // 
            this.txtFAB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFAB.BackColor = System.Drawing.SystemColors.Info;
            this.txtFAB.Location = new System.Drawing.Point(41, 3);
            this.txtFAB.MaxLength = 20;
            this.txtFAB.Name = "txtFAB";
            this.txtFAB.Size = new System.Drawing.Size(149, 26);
            this.txtFAB.TabIndex = 0;
            this.txtFAB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblFAB
            // 
            this.lblFAB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFAB.AutoSize = true;
            this.lblFAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFAB.Location = new System.Drawing.Point(3, 8);
            this.lblFAB.Name = "lblFAB";
            this.lblFAB.Size = new System.Drawing.Size(32, 16);
            this.lblFAB.TabIndex = 0;
            this.lblFAB.Tag = "FAB";
            this.lblFAB.Text = "FAB";
            this.lblFAB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(617, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
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
        "fabCode",
        "orgId"};
            this.mesListView1.columnTags = new string[] {
        "fab",
        "fabCode",
        "orgId"};
            this.mesListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesListView1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesListView1.FullRowSelect = true;
            this.mesListView1.GridLines = true;
            this.mesListView1.HideSelection = false;
            this.mesListView1.imageKeyColumn = "";
            this.mesListView1.keyPressSearch = false;
            this.mesListView1.keyPressSearchColumn = "";
            this.mesListView1.Location = new System.Drawing.Point(0, 108);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(617, 163);
            this.mesListView1.TabIndex = 5;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            // 
            // frmFAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 271);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFAB";
            this.Tag = "FAB";
            this.Text = "frmFAB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFAB_FormClosed);
            this.Load += new System.EventHandler(this.frmFAB_Load);
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
        private System.Windows.Forms.Label lblFAB;
        private System.Windows.Forms.TextBox txtFAB;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.TextBox txtOrgId;
        private System.Windows.Forms.TextBox txtFabCode;
        private System.Windows.Forms.Label lblOrgId;
        private System.Windows.Forms.Label lblFabCode;
        private System.Windows.Forms.Panel pnlExt;
    }
}