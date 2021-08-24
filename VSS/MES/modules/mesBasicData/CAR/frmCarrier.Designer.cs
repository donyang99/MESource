namespace mesBasicData
{
    partial class frmCarrier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarrier));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRFID = new System.Windows.Forms.Label();
            this.cboCarrierType = new System.Windows.Forms.ComboBox();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.lblCarrierType = new System.Windows.Forms.Label();
            this.lblCarrierId = new System.Windows.Forms.Label();
            this.txtCarrierId = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Size = new System.Drawing.Size(853, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editCarrier";
            this.groupBox1.Text = "editCarrier";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(4, 51);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(845, 28);
            this.pnlExt.TabIndex = 4;
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
            this.tblDetail.Controls.Add(this.lblRFID, 4, 0);
            this.tblDetail.Controls.Add(this.cboCarrierType, 3, 0);
            this.tblDetail.Controls.Add(this.txtRFID, 5, 0);
            this.tblDetail.Controls.Add(this.lblCarrierType, 2, 0);
            this.tblDetail.Controls.Add(this.lblCarrierId, 0, 0);
            this.tblDetail.Controls.Add(this.txtCarrierId, 1, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(4, 19);
            this.tblDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Size = new System.Drawing.Size(845, 32);
            this.tblDetail.TabIndex = 0;
            // 
            // lblRFID
            // 
            this.lblRFID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRFID.AutoSize = true;
            this.lblRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRFID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRFID.Location = new System.Drawing.Point(569, 7);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(42, 18);
            this.lblRFID.TabIndex = 7;
            this.lblRFID.Tag = "rfid";
            this.lblRFID.Text = "RFID";
            this.lblRFID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCarrierType
            // 
            this.cboCarrierType.BackColor = System.Drawing.SystemColors.Info;
            this.cboCarrierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrierType.FormattingEnabled = true;
            this.cboCarrierType.Location = new System.Drawing.Point(382, 3);
            this.cboCarrierType.Name = "cboCarrierType";
            this.cboCarrierType.Size = new System.Drawing.Size(181, 24);
            this.cboCarrierType.TabIndex = 8;
            // 
            // txtRFID
            // 
            this.txtRFID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRFID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRFID.Location = new System.Drawing.Point(617, 3);
            this.txtRFID.MaxLength = 20;
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(181, 26);
            this.txtRFID.TabIndex = 6;
            // 
            // lblCarrierType
            // 
            this.lblCarrierType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCarrierType.AutoSize = true;
            this.lblCarrierType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarrierType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarrierType.Location = new System.Drawing.Point(278, 7);
            this.lblCarrierType.Name = "lblCarrierType";
            this.lblCarrierType.Size = new System.Drawing.Size(98, 18);
            this.lblCarrierType.TabIndex = 9;
            this.lblCarrierType.Tag = "carrierType";
            this.lblCarrierType.Text = "carrierType";
            this.lblCarrierType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCarrierId
            // 
            this.lblCarrierId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCarrierId.AutoSize = true;
            this.lblCarrierId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarrierId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarrierId.Location = new System.Drawing.Point(3, 7);
            this.lblCarrierId.Name = "lblCarrierId";
            this.lblCarrierId.Size = new System.Drawing.Size(82, 18);
            this.lblCarrierId.TabIndex = 0;
            this.lblCarrierId.Tag = "CarrierId";
            this.lblCarrierId.Text = "CarrierId";
            this.lblCarrierId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCarrierId
            // 
            this.txtCarrierId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCarrierId.BackColor = System.Drawing.SystemColors.Info;
            this.txtCarrierId.Location = new System.Drawing.Point(91, 3);
            this.txtCarrierId.MaxLength = 20;
            this.txtCarrierId.Name = "txtCarrierId";
            this.txtCarrierId.Size = new System.Drawing.Size(181, 26);
            this.txtCarrierId.TabIndex = 0;
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
        "rfId",
        "carrierType",
        "componentSize",
        "capacity",
        "status",
        "lotId",
        "componentQty",
        "location",
        "usedCount",
        "cleanCount",
        "lastCleanUser",
        "lastCleanDate"};
            this.mesListView1.columnTags = new string[] {
        "CarrierId",
        "rfId",
        "carrierType",
        "componentSize",
        "capacity",
        "status",
        "lotId",
        "quantity",
        "location",
        "usedCount",
        "cleanCount",
        "lastCleanUser",
        "lastCleanDate"};
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
            this.mesListView1.Size = new System.Drawing.Size(853, 312);
            this.mesListView1.TabIndex = 6;
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
            this.actionToolbar1.Size = new System.Drawing.Size(853, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmCarrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 420);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCarrier";
            this.Tag = "Carrier";
            this.Text = "frmCarrier";
            this.Activated += new System.EventHandler(this.frmCarrier_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarrier_FormClosed);
            this.Load += new System.EventHandler(this.frmCarrier_Load);
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
        private System.Windows.Forms.Label lblCarrierId;
        private System.Windows.Forms.TextBox txtCarrierId;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label lblCarrierType;
        private System.Windows.Forms.ComboBox cboCarrierType;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Panel pnlExt;
    }
}