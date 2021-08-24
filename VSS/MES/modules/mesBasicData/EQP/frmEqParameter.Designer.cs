namespace mesBasicData
{
    partial class frmEqParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEqParameter));
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtParameterName = new System.Windows.Forms.TextBox();
            this.rdoString = new System.Windows.Forms.RadioButton();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.lblParameterName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtEqDataId = new System.Windows.Forms.TextBox();
            this.lblEqDataId = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtOptions = new System.Windows.Forms.TextBox();
            this.rdoOptions = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.panel1.SuspendLayout();
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
        "dataType",
        "length",
        "eqDataId",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "name",
        "dataType",
        "length",
        "eqDataId",
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
            this.mesListView1.Location = new System.Drawing.Point(0, 139);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(1016, 261);
            this.mesListView1.TabIndex = 7;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDescription.Location = new System.Drawing.Point(105, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(310, 26);
            this.txtDescription.TabIndex = 4;
            // 
            // txtParameterName
            // 
            this.txtParameterName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtParameterName.BackColor = System.Drawing.SystemColors.Info;
            this.txtParameterName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtParameterName.Location = new System.Drawing.Point(105, 3);
            this.txtParameterName.MaxLength = 20;
            this.txtParameterName.Name = "txtParameterName";
            this.txtParameterName.Size = new System.Drawing.Size(213, 26);
            this.txtParameterName.TabIndex = 0;
            // 
            // rdoString
            // 
            this.rdoString.AutoSize = true;
            this.rdoString.Checked = true;
            this.rdoString.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoString.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoString.Location = new System.Drawing.Point(74, 0);
            this.rdoString.Name = "rdoString";
            this.rdoString.Size = new System.Drawing.Size(74, 20);
            this.rdoString.TabIndex = 2;
            this.rdoString.TabStop = true;
            this.rdoString.Tag = "string";
            this.rdoString.Text = "String";
            this.rdoString.UseVisualStyleBackColor = true;
            this.rdoString.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoNumber
            // 
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoNumber.Location = new System.Drawing.Point(0, 0);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(74, 20);
            this.rdoNumber.TabIndex = 1;
            this.rdoNumber.TabStop = true;
            this.rdoNumber.Tag = "number";
            this.rdoNumber.Text = "Number";
            this.rdoNumber.UseVisualStyleBackColor = true;
            this.rdoNumber.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // lblParameterName
            // 
            this.lblParameterName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblParameterName.AutoSize = true;
            this.lblParameterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParameterName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParameterName.Location = new System.Drawing.Point(57, 7);
            this.lblParameterName.Name = "lblParameterName";
            this.lblParameterName.Size = new System.Drawing.Size(42, 18);
            this.lblParameterName.TabIndex = 0;
            this.lblParameterName.Tag = "name";
            this.lblParameterName.Text = "name";
            this.lblParameterName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.pnlExt);
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1016, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 83);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1010, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDetail.ColumnCount = 8;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Controls.Add(this.lblParameterName, 0, 0);
            this.tblDetail.Controls.Add(this.txtParameterName, 1, 0);
            this.tblDetail.Controls.Add(this.lblDataType, 2, 0);
            this.tblDetail.Controls.Add(this.panel1, 3, 0);
            this.tblDetail.Controls.Add(this.label4, 0, 1);
            this.tblDetail.Controls.Add(this.txtDescription, 1, 1);
            this.tblDetail.Controls.Add(this.lblEqDataId, 6, 0);
            this.tblDetail.Controls.Add(this.txtEqDataId, 7, 0);
            this.tblDetail.Controls.Add(this.lblLength, 4, 0);
            this.tblDetail.Controls.Add(this.txtLength, 5, 0);
            this.tblDetail.Controls.Add(this.txtOptions, 3, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(1010, 64);
            this.tblDetail.TabIndex = 0;
            // 
            // txtEqDataId
            // 
            this.txtEqDataId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEqDataId.BackColor = System.Drawing.SystemColors.Window;
            this.txtEqDataId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtEqDataId.Location = new System.Drawing.Point(845, 3);
            this.txtEqDataId.MaxLength = 40;
            this.txtEqDataId.Name = "txtEqDataId";
            this.txtEqDataId.Size = new System.Drawing.Size(162, 26);
            this.txtEqDataId.TabIndex = 3;
            // 
            // lblEqDataId
            // 
            this.lblEqDataId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEqDataId.AutoSize = true;
            this.lblEqDataId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqDataId.Location = new System.Drawing.Point(767, 8);
            this.lblEqDataId.Name = "lblEqDataId";
            this.lblEqDataId.Size = new System.Drawing.Size(72, 16);
            this.lblEqDataId.TabIndex = 8;
            this.lblEqDataId.Tag = "eqDataId";
            this.lblEqDataId.Text = "EqDataId";
            this.lblEqDataId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataType
            // 
            this.lblDataType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataType.AutoSize = true;
            this.lblDataType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataType.Location = new System.Drawing.Point(346, 8);
            this.lblDataType.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(72, 16);
            this.lblDataType.TabIndex = 2;
            this.lblDataType.Tag = "dataType";
            this.lblDataType.Text = "DataType";
            this.lblDataType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.rdoOptions);
            this.panel1.Controls.Add(this.rdoString);
            this.panel1.Controls.Add(this.rdoNumber);
            this.panel1.Location = new System.Drawing.Point(418, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 20);
            this.panel1.TabIndex = 1;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(1016, 25);
            this.actionToolbar1.TabIndex = 5;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // lblLength
            // 
            this.lblLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLength.AutoSize = true;
            this.lblLength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLength.Location = new System.Drawing.Point(651, 8);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(56, 16);
            this.lblLength.TabIndex = 10;
            this.lblLength.Tag = "length";
            this.lblLength.Text = "length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLength
            // 
            this.txtLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLength.BackColor = System.Drawing.SystemColors.Info;
            this.txtLength.Location = new System.Drawing.Point(713, 3);
            this.txtLength.MaxLength = 3;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(48, 26);
            this.txtLength.TabIndex = 2;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            // 
            // txtOptions
            // 
            this.txtOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptions.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtOptions, 5);
            this.txtOptions.Enabled = false;
            this.txtOptions.Location = new System.Drawing.Point(421, 35);
            this.txtOptions.MaxLength = 255;
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.Size = new System.Drawing.Size(586, 26);
            this.txtOptions.TabIndex = 5;
            // 
            // rdoOptions
            // 
            this.rdoOptions.AutoSize = true;
            this.rdoOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoOptions.Location = new System.Drawing.Point(148, 0);
            this.rdoOptions.Name = "rdoOptions";
            this.rdoOptions.Size = new System.Drawing.Size(82, 20);
            this.rdoOptions.TabIndex = 3;
            this.rdoOptions.TabStop = true;
            this.rdoOptions.Tag = "options";
            this.rdoOptions.Text = "options";
            this.rdoOptions.UseVisualStyleBackColor = true;
            this.rdoOptions.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // frmEqParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 400);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEqParameter";
            this.Tag = "eqParameter";
            this.Text = "EqParameter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEqParameter_FormClosed);
            this.Load += new System.EventHandler(this.frmEqParameter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtParameterName;
        private System.Windows.Forms.RadioButton rdoString;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.Label lblParameterName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Panel panel1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.TextBox txtEqDataId;
        private System.Windows.Forms.Label lblEqDataId;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtOptions;
        private System.Windows.Forms.RadioButton rdoOptions;
    }
}