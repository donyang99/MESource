namespace toolingFunction
{
    partial class frmToolingPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolingPart));
            this.txtUseLimit = new System.Windows.Forms.TextBox();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.lblUseLimit = new System.Windows.Forms.Label();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtUseNotice = new System.Windows.Forms.TextBox();
            this.lblUseNotice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.ComboBox();
            this.lblTypeInfo = new System.Windows.Forms.Label();
            this.cboToolingType = new System.Windows.Forms.ComboBox();
            this.lblPartNo = new System.Windows.Forms.Label();
            this.lblToolingType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.tblDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUseLimit
            // 
            this.txtUseLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUseLimit.BackColor = System.Drawing.SystemColors.Info;
            this.txtUseLimit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUseLimit.Location = new System.Drawing.Point(750, 3);
            this.txtUseLimit.MaxLength = 6;
            this.txtUseLimit.Name = "txtUseLimit";
            this.txtUseLimit.Size = new System.Drawing.Size(65, 26);
            this.txtUseLimit.TabIndex = 2;
            this.txtUseLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
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
        "useLimit",
        "useNotice",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "ToolingPart",
        "ToolingType",
        "UseLimit",
        "UseNotice",
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
            this.mesListView1.Location = new System.Drawing.Point(0, 142);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(831, 418);
            this.mesListView1.TabIndex = 12;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // lblUseLimit
            // 
            this.lblUseLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUseLimit.AutoSize = true;
            this.lblUseLimit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUseLimit.Location = new System.Drawing.Point(672, 8);
            this.lblUseLimit.Name = "lblUseLimit";
            this.lblUseLimit.Size = new System.Drawing.Size(72, 16);
            this.lblUseLimit.TabIndex = 11;
            this.lblUseLimit.Tag = "UseLimit";
            this.lblUseLimit.Text = "UseLimit";
            this.lblUseLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tblDetail.Controls.Add(this.txtUseNotice, 6, 1);
            this.tblDetail.Controls.Add(this.lblUseNotice, 5, 1);
            this.tblDetail.Controls.Add(this.txtDescription, 1, 1);
            this.tblDetail.Controls.Add(this.label4, 0, 1);
            this.tblDetail.Controls.Add(this.txtPartNo, 1, 0);
            this.tblDetail.Controls.Add(this.lblTypeInfo, 4, 0);
            this.tblDetail.Controls.Add(this.lblUseLimit, 5, 0);
            this.tblDetail.Controls.Add(this.cboToolingType, 3, 0);
            this.tblDetail.Controls.Add(this.lblPartNo, 0, 0);
            this.tblDetail.Controls.Add(this.lblToolingType, 2, 0);
            this.tblDetail.Controls.Add(this.txtUseLimit, 6, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 22);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(825, 64);
            this.tblDetail.TabIndex = 0;
            // 
            // txtUseNotice
            // 
            this.txtUseNotice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUseNotice.BackColor = System.Drawing.SystemColors.Window;
            this.txtUseNotice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUseNotice.Location = new System.Drawing.Point(750, 35);
            this.txtUseNotice.MaxLength = 6;
            this.txtUseNotice.Name = "txtUseNotice";
            this.txtUseNotice.Size = new System.Drawing.Size(65, 26);
            this.txtUseNotice.TabIndex = 4;
            this.txtUseNotice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            // 
            // lblUseNotice
            // 
            this.lblUseNotice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUseNotice.AutoSize = true;
            this.lblUseNotice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUseNotice.Location = new System.Drawing.Point(664, 40);
            this.lblUseNotice.Name = "lblUseNotice";
            this.lblUseNotice.Size = new System.Drawing.Size(80, 16);
            this.lblUseNotice.TabIndex = 13;
            this.lblUseNotice.Tag = "UseNotice";
            this.lblUseNotice.Text = "UseNotice";
            this.lblUseNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 4);
            this.txtDescription.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDescription.Location = new System.Drawing.Point(107, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(551, 26);
            this.txtDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(5, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 13;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPartNo
            // 
            this.txtPartNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPartNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtPartNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtPartNo.FormattingEnabled = true;
            this.txtPartNo.Location = new System.Drawing.Point(107, 4);
            this.txtPartNo.MaxLength = 40;
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(194, 24);
            this.txtPartNo.TabIndex = 0;
            // 
            // lblTypeInfo
            // 
            this.lblTypeInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTypeInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTypeInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeInfo.Location = new System.Drawing.Point(535, 4);
            this.lblTypeInfo.Name = "lblTypeInfo";
            this.lblTypeInfo.Size = new System.Drawing.Size(123, 24);
            this.lblTypeInfo.TabIndex = 13;
            this.lblTypeInfo.Tag = "";
            this.lblTypeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboToolingType
            // 
            this.cboToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboToolingType.BackColor = System.Drawing.SystemColors.Info;
            this.cboToolingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToolingType.FormattingEnabled = true;
            this.cboToolingType.Location = new System.Drawing.Point(411, 4);
            this.cboToolingType.Name = "cboToolingType";
            this.cboToolingType.Size = new System.Drawing.Size(118, 24);
            this.cboToolingType.TabIndex = 1;
            this.cboToolingType.SelectedIndexChanged += new System.EventHandler(this.cboToolingType_SelectedIndexChanged);
            // 
            // lblPartNo
            // 
            this.lblPartNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPartNo.AutoSize = true;
            this.lblPartNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPartNo.Location = new System.Drawing.Point(3, 7);
            this.lblPartNo.Name = "lblPartNo";
            this.lblPartNo.Size = new System.Drawing.Size(98, 18);
            this.lblPartNo.TabIndex = 0;
            this.lblPartNo.Tag = "ToolingPart";
            this.lblPartNo.Text = "ToolingPart";
            this.lblPartNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToolingType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingType.Location = new System.Drawing.Point(307, 7);
            this.lblToolingType.Name = "lblToolingType";
            this.lblToolingType.Size = new System.Drawing.Size(98, 18);
            this.lblToolingType.TabIndex = 10;
            this.lblToolingType.Tag = "ToolingType";
            this.lblToolingType.Text = "ToolingType";
            this.lblToolingType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.groupBox1.Size = new System.Drawing.Size(831, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 86);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(825, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(831, 25);
            this.actionToolbar1.TabIndex = 10;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmToolingPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 560);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToolingPart";
            this.Tag = "ToolingPart";
            this.Text = "frmToolingPart";
            this.Activated += new System.EventHandler(this.frmToolingPart_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmToolingPart_FormClosed);
            this.Load += new System.EventHandler(this.frmToolingPart_Load);
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUseLimit;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.Label lblUseLimit;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.ComboBox cboToolingType;
        private System.Windows.Forms.Label lblPartNo;
        private System.Windows.Forms.Label lblToolingType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlExt;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.Label lblTypeInfo;
        private System.Windows.Forms.ComboBox txtPartNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUseNotice;
        private System.Windows.Forms.Label lblUseNotice;
    }
}