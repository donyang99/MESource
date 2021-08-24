namespace mesBasicData
{
    partial class frmCarrierType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrierType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCarrierType = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtComponentSize = new System.Windows.Forms.TextBox();
            this.txtCarrierType = new System.Windows.Forms.TextBox();
            this.lblComponentSize = new System.Windows.Forms.Label();
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editCarrierType";
            this.groupBox1.Text = "editCarrierType";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(4, 51);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1071, 28);
            this.pnlExt.TabIndex = 5;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 8;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Controls.Add(this.txtDescription, 7, 0);
            this.tblDetail.Controls.Add(this.label4, 6, 0);
            this.tblDetail.Controls.Add(this.txtCapacity, 5, 0);
            this.tblDetail.Controls.Add(this.lblCarrierType, 0, 0);
            this.tblDetail.Controls.Add(this.lblCapacity, 4, 0);
            this.tblDetail.Controls.Add(this.txtComponentSize, 3, 0);
            this.tblDetail.Controls.Add(this.txtCarrierType, 1, 0);
            this.tblDetail.Controls.Add(this.lblComponentSize, 2, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(4, 19);
            this.tblDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Size = new System.Drawing.Size(1071, 32);
            this.tblDetail.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(673, 3);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(395, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(571, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 5;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCapacity.BackColor = System.Drawing.SystemColors.Info;
            this.txtCapacity.Location = new System.Drawing.Point(492, 3);
            this.txtCapacity.MaxLength = 5;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(73, 26);
            this.txtCapacity.TabIndex = 5;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtCapacity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblCarrierType
            // 
            this.lblCarrierType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCarrierType.AutoSize = true;
            this.lblCarrierType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarrierType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarrierType.Location = new System.Drawing.Point(3, 7);
            this.lblCarrierType.Name = "lblCarrierType";
            this.lblCarrierType.Size = new System.Drawing.Size(98, 18);
            this.lblCarrierType.TabIndex = 0;
            this.lblCarrierType.Tag = "carrierType";
            this.lblCarrierType.Text = "carrierType";
            this.lblCarrierType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCapacity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCapacity.Location = new System.Drawing.Point(356, 7);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(130, 18);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Tag = "carrierCapacity";
            this.lblCapacity.Text = "carrierCapacity";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComponentSize
            // 
            this.txtComponentSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtComponentSize.BackColor = System.Drawing.SystemColors.Info;
            this.txtComponentSize.Location = new System.Drawing.Point(297, 3);
            this.txtComponentSize.MaxLength = 3;
            this.txtComponentSize.Name = "txtComponentSize";
            this.txtComponentSize.Size = new System.Drawing.Size(53, 26);
            this.txtComponentSize.TabIndex = 1;
            this.txtComponentSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtComponentSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtCarrierType
            // 
            this.txtCarrierType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCarrierType.BackColor = System.Drawing.SystemColors.Info;
            this.txtCarrierType.Location = new System.Drawing.Point(107, 3);
            this.txtCarrierType.MaxLength = 20;
            this.txtCarrierType.Name = "txtCarrierType";
            this.txtCarrierType.Size = new System.Drawing.Size(136, 26);
            this.txtCarrierType.TabIndex = 0;
            this.txtCarrierType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblComponentSize
            // 
            this.lblComponentSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblComponentSize.AutoSize = true;
            this.lblComponentSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComponentSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComponentSize.Location = new System.Drawing.Point(249, 7);
            this.lblComponentSize.Name = "lblComponentSize";
            this.lblComponentSize.Size = new System.Drawing.Size(42, 18);
            this.lblComponentSize.TabIndex = 4;
            this.lblComponentSize.Tag = "componentSize";
            this.lblComponentSize.Text = "Size";
            this.lblComponentSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
        "componentSize",
        "capacity",
        "description",
        "createUser",
        "createDate",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "carrierType",
        "componentSize",
        "capacity",
        "description",
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
            this.mesListView1.Location = new System.Drawing.Point(0, 108);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.Margin = new System.Windows.Forms.Padding(4);
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(1079, 307);
            this.mesListView1.TabIndex = 5;
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
            this.actionToolbar1.Size = new System.Drawing.Size(1079, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmCarrierType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 415);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCarrierType";
            this.Tag = "CarrierType";
            this.Text = "frmCarrierType";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarrierType_FormClosed);
            this.Load += new System.EventHandler(this.frmCarrierType_Load);
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
        private System.Windows.Forms.Label lblCarrierType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtComponentSize;
        private System.Windows.Forms.TextBox txtCarrierType;
        private System.Windows.Forms.Label lblComponentSize;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Panel pnlExt;
    }
}