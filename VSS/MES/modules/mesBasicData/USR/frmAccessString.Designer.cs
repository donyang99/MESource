namespace mesBasicData
{
    partial class frmAccessString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccessString));
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblAccessString = new System.Windows.Forms.Label();
            this.txtAccessString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
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
            this.actionToolbar1.Size = new System.Drawing.Size(761, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
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
            this.groupBox1.Size = new System.Drawing.Size(761, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editAccessString";
            this.groupBox1.Text = "editAccessString";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 54);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(755, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 4;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.Controls.Add(this.lblAccessString, 0, 0);
            this.tblDetail.Controls.Add(this.txtAccessString, 1, 0);
            this.tblDetail.Controls.Add(this.label4, 2, 0);
            this.tblDetail.Controls.Add(this.txtDescription, 3, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 22);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(755, 32);
            this.tblDetail.TabIndex = 0;
            // 
            // lblAccessString
            // 
            this.lblAccessString.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAccessString.AutoSize = true;
            this.lblAccessString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccessString.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccessString.Location = new System.Drawing.Point(3, 7);
            this.lblAccessString.Name = "lblAccessString";
            this.lblAccessString.Size = new System.Drawing.Size(106, 18);
            this.lblAccessString.TabIndex = 0;
            this.lblAccessString.Tag = "accessString";
            this.lblAccessString.Text = "AccessString";
            this.lblAccessString.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAccessString
            // 
            this.txtAccessString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccessString.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccessString.Location = new System.Drawing.Point(115, 3);
            this.txtAccessString.MaxLength = 255;
            this.txtAccessString.Name = "txtAccessString";
            this.txtAccessString.Size = new System.Drawing.Size(286, 26);
            this.txtAccessString.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(407, 8);
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
            this.txtDescription.Location = new System.Drawing.Point(509, 3);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(243, 26);
            this.txtDescription.TabIndex = 1;
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
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "accessString",
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
            this.mesListView1.Location = new System.Drawing.Point(0, 110);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(761, 438);
            this.mesListView1.TabIndex = 6;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // frmAccessString
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(761, 548);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccessString";
            this.Tag = "AccessString";
            this.Text = "frmAccessString";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccessString_FormClosed);
            this.Load += new System.EventHandler(this.frmAccessString_Load);
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
        private System.Windows.Forms.Label lblAccessString;
        private System.Windows.Forms.TextBox txtAccessString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Panel pnlExt;
    }
}