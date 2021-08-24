namespace mesBasicData
{
    partial class frmParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParameter));
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.cboStepDC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.lblParameter = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoRange = new System.Windows.Forms.RadioButton();
            this.rdoString = new System.Windows.Forms.RadioButton();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.lblEqParameter = new System.Windows.Forms.Label();
            this.cboEqParameter = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.actionToolbar1.Size = new System.Drawing.Size(1008, 25);
            this.actionToolbar1.TabIndex = 1;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
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
            this.groupBox1.Size = new System.Drawing.Size(1008, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "parameter";
            this.groupBox1.Text = "Parameter";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 83);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1002, 28);
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
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Controls.Add(this.cboEqParameter, 5, 0);
            this.tblDetail.Controls.Add(this.lblEqParameter, 4, 0);
            this.tblDetail.Controls.Add(this.cboStepDC, 3, 0);
            this.tblDetail.Controls.Add(this.label2, 2, 0);
            this.tblDetail.Controls.Add(this.txtParameter, 1, 0);
            this.tblDetail.Controls.Add(this.lblParameter, 0, 0);
            this.tblDetail.Controls.Add(this.txtDescription, 3, 1);
            this.tblDetail.Controls.Add(this.label1, 2, 1);
            this.tblDetail.Controls.Add(this.label4, 0, 1);
            this.tblDetail.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(1002, 64);
            this.tblDetail.TabIndex = 2;
            // 
            // cboStepDC
            // 
            this.cboStepDC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStepDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStepDC.FormattingEnabled = true;
            this.cboStepDC.Location = new System.Drawing.Point(433, 4);
            this.cboStepDC.Name = "cboStepDC";
            this.cboStepDC.Size = new System.Drawing.Size(213, 24);
            this.cboStepDC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(371, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Tag = "stepDC";
            this.label2.Text = "stepDC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Tag = "dataType";
            this.label4.Text = "dataType";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtParameter
            // 
            this.txtParameter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtParameter.BackColor = System.Drawing.SystemColors.Info;
            this.txtParameter.Location = new System.Drawing.Point(89, 3);
            this.txtParameter.MaxLength = 40;
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(236, 26);
            this.txtParameter.TabIndex = 1;
            // 
            // lblParameter
            // 
            this.lblParameter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblParameter.AutoSize = true;
            this.lblParameter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParameter.Location = new System.Drawing.Point(3, 8);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(80, 16);
            this.lblParameter.TabIndex = 0;
            this.lblParameter.Tag = "parameter";
            this.lblParameter.Text = "Parameter";
            this.lblParameter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Location = new System.Drawing.Point(433, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(534, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(331, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 7;
            this.label1.Tag = "description";
            this.label1.Text = "description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.rdoRange, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdoString, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdoNumber, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 35);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(232, 26);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // rdoRange
            // 
            this.rdoRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoRange.AutoSize = true;
            this.rdoRange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoRange.Location = new System.Drawing.Point(163, 3);
            this.rdoRange.Name = "rdoRange";
            this.rdoRange.Size = new System.Drawing.Size(66, 20);
            this.rdoRange.TabIndex = 3;
            this.rdoRange.Tag = "range";
            this.rdoRange.Text = "Range";
            this.rdoRange.UseVisualStyleBackColor = true;
            // 
            // rdoString
            // 
            this.rdoString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoString.AutoSize = true;
            this.rdoString.Checked = true;
            this.rdoString.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoString.Location = new System.Drawing.Point(3, 3);
            this.rdoString.Name = "rdoString";
            this.rdoString.Size = new System.Drawing.Size(74, 20);
            this.rdoString.TabIndex = 1;
            this.rdoString.TabStop = true;
            this.rdoString.Tag = "string";
            this.rdoString.Text = "string";
            this.rdoString.UseVisualStyleBackColor = true;
            // 
            // rdoNumber
            // 
            this.rdoNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoNumber.Location = new System.Drawing.Point(83, 3);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(74, 20);
            this.rdoNumber.TabIndex = 2;
            this.rdoNumber.Tag = "number";
            this.rdoNumber.Text = "number";
            this.rdoNumber.UseVisualStyleBackColor = true;
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
        "parmType",
        "dcItemSysId",
        "eqParmSysId",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "parameter",
        "dataType",
        "stepDC",
        "eqParameter",
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
            this.mesListView1.Size = new System.Drawing.Size(1008, 247);
            this.mesListView1.TabIndex = 5;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // lblEqParameter
            // 
            this.lblEqParameter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEqParameter.AutoSize = true;
            this.lblEqParameter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqParameter.Location = new System.Drawing.Point(652, 8);
            this.lblEqParameter.Name = "lblEqParameter";
            this.lblEqParameter.Size = new System.Drawing.Size(96, 16);
            this.lblEqParameter.TabIndex = 9;
            this.lblEqParameter.Tag = "eqParameter";
            this.lblEqParameter.Text = "eqParameter";
            this.lblEqParameter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboEqParameter
            // 
            this.cboEqParameter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEqParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEqParameter.FormattingEnabled = true;
            this.cboEqParameter.Location = new System.Drawing.Point(754, 4);
            this.cboEqParameter.Name = "cboEqParameter";
            this.cboEqParameter.Size = new System.Drawing.Size(213, 24);
            this.cboEqParameter.TabIndex = 7;
            // 
            // frmParameter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 386);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParameter";
            this.Tag = "parameter";
            this.Text = "frmParameter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmParameter_FormClosed);
            this.Load += new System.EventHandler(this.frmParameter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.RadioButton rdoString;
        private System.Windows.Forms.RadioButton rdoRange;
        private System.Windows.Forms.ComboBox cboStepDC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.ComboBox cboEqParameter;
        private System.Windows.Forms.Label lblEqParameter;
    }
}