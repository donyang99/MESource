namespace mesBasicData
{
    partial class frmStepDC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStepDC));
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtOptions = new System.Windows.Forms.TextBox();
            this.txtAssemblyName = new System.Windows.Forms.TextBox();
            this.lblAssemblyName = new System.Windows.Forms.Label();
            this.txtTargetSql = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTargetSql = new System.Windows.Forms.Label();
            this.txtTargetDB = new System.Windows.Forms.TextBox();
            this.lblTargetDB = new System.Windows.Forms.Label();
            this.txtSourceSql = new System.Windows.Forms.TextBox();
            this.lblSourceSql = new System.Windows.Forms.Label();
            this.txtSourceDB = new System.Windows.Forms.TextBox();
            this.lblSourceDB = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoCustom = new System.Windows.Forms.RadioButton();
            this.rdoBySetting = new System.Windows.Forms.RadioButton();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCompareAttribute = new System.Windows.Forms.ComboBox();
            this.cboCompareTo = new System.Windows.Forms.ComboBox();
            this.cboAssignAttribute = new System.Windows.Forms.ComboBox();
            this.lblCompareAttribute = new System.Windows.Forms.Label();
            this.lblCompareTo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAssignFrom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboModifyTarget = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoOptions = new System.Windows.Forms.RadioButton();
            this.rdoNumber = new System.Windows.Forms.RadioButton();
            this.rdoString = new System.Windows.Forms.RadioButton();
            this.lblDCItem = new System.Windows.Forms.Label();
            this.txtDCItem = new System.Windows.Forms.TextBox();
            this.lblDataType = new System.Windows.Forms.Label();
            this.cboAttributeName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlUpDown = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlUpDown.SuspendLayout();
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
            this.actionToolbar1.Size = new System.Drawing.Size(1074, 25);
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
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1074, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editStepDCItem";
            this.groupBox1.Text = "editStepDCItem";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 271);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1068, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 9;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Controls.Add(this.txtOptions, 4, 1);
            this.tblDetail.Controls.Add(this.txtAssemblyName, 6, 4);
            this.tblDetail.Controls.Add(this.lblAssemblyName, 5, 4);
            this.tblDetail.Controls.Add(this.txtTargetSql, 4, 7);
            this.tblDetail.Controls.Add(this.label8, 3, 4);
            this.tblDetail.Controls.Add(this.lblTargetSql, 3, 7);
            this.tblDetail.Controls.Add(this.txtTargetDB, 1, 7);
            this.tblDetail.Controls.Add(this.lblTargetDB, 0, 7);
            this.tblDetail.Controls.Add(this.txtSourceSql, 4, 5);
            this.tblDetail.Controls.Add(this.lblSourceSql, 3, 5);
            this.tblDetail.Controls.Add(this.txtSourceDB, 1, 5);
            this.tblDetail.Controls.Add(this.lblSourceDB, 0, 5);
            this.tblDetail.Controls.Add(this.panel4, 1, 4);
            this.tblDetail.Controls.Add(this.label9, 0, 4);
            this.tblDetail.Controls.Add(this.cboCompareAttribute, 4, 6);
            this.tblDetail.Controls.Add(this.cboCompareTo, 1, 6);
            this.tblDetail.Controls.Add(this.cboAssignAttribute, 4, 3);
            this.tblDetail.Controls.Add(this.lblCompareAttribute, 3, 6);
            this.tblDetail.Controls.Add(this.lblCompareTo, 0, 6);
            this.tblDetail.Controls.Add(this.label5, 3, 3);
            this.tblDetail.Controls.Add(this.cboAssignFrom, 1, 3);
            this.tblDetail.Controls.Add(this.label4, 0, 3);
            this.tblDetail.Controls.Add(this.cboModifyTarget, 1, 2);
            this.tblDetail.Controls.Add(this.label3, 0, 2);
            this.tblDetail.Controls.Add(this.txtLength, 6, 0);
            this.tblDetail.Controls.Add(this.lblLength, 5, 0);
            this.tblDetail.Controls.Add(this.panel1, 4, 0);
            this.tblDetail.Controls.Add(this.lblDCItem, 0, 0);
            this.tblDetail.Controls.Add(this.txtDCItem, 1, 0);
            this.tblDetail.Controls.Add(this.lblDataType, 3, 0);
            this.tblDetail.Controls.Add(this.cboAttributeName, 4, 2);
            this.tblDetail.Controls.Add(this.label1, 3, 2);
            this.tblDetail.Controls.Add(this.label2, 5, 2);
            this.tblDetail.Controls.Add(this.txtColumnName, 6, 2);
            this.tblDetail.Controls.Add(this.panel2, 7, 0);
            this.tblDetail.Controls.Add(this.cboOperator, 4, 4);
            this.tblDetail.Controls.Add(this.lblDescription, 0, 1);
            this.tblDetail.Controls.Add(this.txtDescription, 1, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 9;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Size = new System.Drawing.Size(1068, 252);
            this.tblDetail.TabIndex = 0;
            // 
            // txtOptions
            // 
            this.txtOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOptions.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtOptions, 4);
            this.txtOptions.Enabled = false;
            this.txtOptions.Location = new System.Drawing.Point(477, 35);
            this.txtOptions.MaxLength = 255;
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.Size = new System.Drawing.Size(549, 26);
            this.txtOptions.TabIndex = 7;
            // 
            // txtAssemblyName
            // 
            this.txtAssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssemblyName.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtAssemblyName, 2);
            this.txtAssemblyName.Location = new System.Drawing.Point(817, 129);
            this.txtAssemblyName.MaxLength = 40;
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.Size = new System.Drawing.Size(209, 26);
            this.txtAssemblyName.TabIndex = 14;
            // 
            // lblAssemblyName
            // 
            this.lblAssemblyName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAssemblyName.AutoSize = true;
            this.lblAssemblyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAssemblyName.Location = new System.Drawing.Point(707, 134);
            this.lblAssemblyName.Name = "lblAssemblyName";
            this.lblAssemblyName.Size = new System.Drawing.Size(104, 16);
            this.lblAssemblyName.TabIndex = 7;
            this.lblAssemblyName.Tag = "assemblyName";
            this.lblAssemblyName.Text = "AssemblyName";
            this.lblAssemblyName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTargetSql
            // 
            this.txtTargetSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetSql.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtTargetSql, 4);
            this.txtTargetSql.Location = new System.Drawing.Point(477, 223);
            this.txtTargetSql.MaxLength = 500;
            this.txtTargetSql.Name = "txtTargetSql";
            this.txtTargetSql.Size = new System.Drawing.Size(549, 26);
            this.txtTargetSql.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(399, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 9;
            this.label8.Tag = "compareOperator";
            this.label8.Text = "Operator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTargetSql
            // 
            this.lblTargetSql.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTargetSql.AutoSize = true;
            this.lblTargetSql.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTargetSql.Location = new System.Drawing.Point(391, 228);
            this.lblTargetSql.Name = "lblTargetSql";
            this.lblTargetSql.Size = new System.Drawing.Size(80, 16);
            this.lblTargetSql.TabIndex = 12;
            this.lblTargetSql.Tag = "compareTargetSql";
            this.lblTargetSql.Text = "TargetSql";
            this.lblTargetSql.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTargetDB
            // 
            this.txtTargetDB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTargetDB.BackColor = System.Drawing.SystemColors.Window;
            this.txtTargetDB.Location = new System.Drawing.Point(113, 223);
            this.txtTargetDB.MaxLength = 40;
            this.txtTargetDB.Name = "txtTargetDB";
            this.txtTargetDB.Size = new System.Drawing.Size(216, 26);
            this.txtTargetDB.TabIndex = 19;
            // 
            // lblTargetDB
            // 
            this.lblTargetDB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTargetDB.AutoSize = true;
            this.lblTargetDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTargetDB.Location = new System.Drawing.Point(35, 228);
            this.lblTargetDB.Name = "lblTargetDB";
            this.lblTargetDB.Size = new System.Drawing.Size(72, 16);
            this.lblTargetDB.TabIndex = 11;
            this.lblTargetDB.Tag = "compareTargetDB";
            this.lblTargetDB.Text = "TargetDB";
            this.lblTargetDB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSourceSql
            // 
            this.txtSourceSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceSql.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtSourceSql, 4);
            this.txtSourceSql.Location = new System.Drawing.Point(477, 161);
            this.txtSourceSql.MaxLength = 500;
            this.txtSourceSql.Name = "txtSourceSql";
            this.txtSourceSql.Size = new System.Drawing.Size(549, 26);
            this.txtSourceSql.TabIndex = 16;
            // 
            // lblSourceSql
            // 
            this.lblSourceSql.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSourceSql.AutoSize = true;
            this.lblSourceSql.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSourceSql.Location = new System.Drawing.Point(391, 166);
            this.lblSourceSql.Name = "lblSourceSql";
            this.lblSourceSql.Size = new System.Drawing.Size(80, 16);
            this.lblSourceSql.TabIndex = 11;
            this.lblSourceSql.Tag = "compareSourceSql";
            this.lblSourceSql.Text = "SourceSql";
            this.lblSourceSql.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSourceDB
            // 
            this.txtSourceDB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSourceDB.BackColor = System.Drawing.SystemColors.Window;
            this.txtSourceDB.Location = new System.Drawing.Point(113, 161);
            this.txtSourceDB.MaxLength = 40;
            this.txtSourceDB.Name = "txtSourceDB";
            this.txtSourceDB.Size = new System.Drawing.Size(216, 26);
            this.txtSourceDB.TabIndex = 15;
            // 
            // lblSourceDB
            // 
            this.lblSourceDB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSourceDB.AutoSize = true;
            this.lblSourceDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSourceDB.Location = new System.Drawing.Point(35, 166);
            this.lblSourceDB.Name = "lblSourceDB";
            this.lblSourceDB.Size = new System.Drawing.Size(72, 16);
            this.lblSourceDB.TabIndex = 10;
            this.lblSourceDB.Tag = "compareSourceDB";
            this.lblSourceDB.Text = "SourceDB";
            this.lblSourceDB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.tblDetail.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.rdoCustom);
            this.panel4.Controls.Add(this.rdoBySetting);
            this.panel4.Controls.Add(this.rdoNone);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(110, 126);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 32);
            this.panel4.TabIndex = 12;
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoCustom.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoCustom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoCustom.Location = new System.Drawing.Point(127, 0);
            this.rdoCustom.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(67, 32);
            this.rdoCustom.TabIndex = 12;
            this.rdoCustom.Tag = "byCustom";
            this.rdoCustom.Text = "Custom";
            this.rdoCustom.UseVisualStyleBackColor = true;
            this.rdoCustom.CheckedChanged += new System.EventHandler(this.CompareTypeChange);
            // 
            // rdoBySetting
            // 
            this.rdoBySetting.AutoSize = true;
            this.rdoBySetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoBySetting.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoBySetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoBySetting.Location = new System.Drawing.Point(53, 0);
            this.rdoBySetting.Margin = new System.Windows.Forms.Padding(0);
            this.rdoBySetting.Name = "rdoBySetting";
            this.rdoBySetting.Size = new System.Drawing.Size(74, 32);
            this.rdoBySetting.TabIndex = 12;
            this.rdoBySetting.Tag = "bySetting";
            this.rdoBySetting.Text = "Setting";
            this.rdoBySetting.UseVisualStyleBackColor = true;
            this.rdoBySetting.CheckedChanged += new System.EventHandler(this.CompareTypeChange);
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Checked = true;
            this.rdoNone.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoNone.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoNone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoNone.Location = new System.Drawing.Point(0, 0);
            this.rdoNone.Margin = new System.Windows.Forms.Padding(0);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(53, 32);
            this.rdoNone.TabIndex = 12;
            this.rdoNone.TabStop = true;
            this.rdoNone.Tag = "noCompare";
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.CompareTypeChange);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(11, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 9;
            this.label9.Tag = "compareType";
            this.label9.Text = "CompareType";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboCompareAttribute
            // 
            this.cboCompareAttribute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCompareAttribute.FormattingEnabled = true;
            this.cboCompareAttribute.Location = new System.Drawing.Point(477, 193);
            this.cboCompareAttribute.MaxLength = 40;
            this.cboCompareAttribute.Name = "cboCompareAttribute";
            this.cboCompareAttribute.Size = new System.Drawing.Size(221, 24);
            this.cboCompareAttribute.Sorted = true;
            this.cboCompareAttribute.TabIndex = 18;
            // 
            // cboCompareTo
            // 
            this.cboCompareTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCompareTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompareTo.FormattingEnabled = true;
            this.cboCompareTo.Items.AddRange(new object[] {
            "",
            "Equipment",
            "Lot",
            "Step",
            "WorkOrder"});
            this.cboCompareTo.Location = new System.Drawing.Point(113, 193);
            this.cboCompareTo.Name = "cboCompareTo";
            this.cboCompareTo.Size = new System.Drawing.Size(216, 24);
            this.cboCompareTo.Sorted = true;
            this.cboCompareTo.TabIndex = 17;
            this.cboCompareTo.SelectedIndexChanged += new System.EventHandler(this.cboCompareTo_SelectedIndexChanged);
            // 
            // cboAssignAttribute
            // 
            this.cboAssignAttribute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboAssignAttribute.FormattingEnabled = true;
            this.cboAssignAttribute.Location = new System.Drawing.Point(477, 99);
            this.cboAssignAttribute.MaxLength = 40;
            this.cboAssignAttribute.Name = "cboAssignAttribute";
            this.cboAssignAttribute.Size = new System.Drawing.Size(221, 24);
            this.cboAssignAttribute.Sorted = true;
            this.cboAssignAttribute.TabIndex = 11;
            // 
            // lblCompareAttribute
            // 
            this.lblCompareAttribute.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCompareAttribute.AutoSize = true;
            this.lblCompareAttribute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompareAttribute.Location = new System.Drawing.Point(335, 197);
            this.lblCompareAttribute.Name = "lblCompareAttribute";
            this.lblCompareAttribute.Size = new System.Drawing.Size(136, 16);
            this.lblCompareAttribute.TabIndex = 9;
            this.lblCompareAttribute.Tag = "compareAttribute";
            this.lblCompareAttribute.Text = "CompareAttribute";
            this.lblCompareAttribute.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCompareTo
            // 
            this.lblCompareTo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCompareTo.AutoSize = true;
            this.lblCompareTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompareTo.Location = new System.Drawing.Point(27, 197);
            this.lblCompareTo.Name = "lblCompareTo";
            this.lblCompareTo.Size = new System.Drawing.Size(80, 16);
            this.lblCompareTo.TabIndex = 9;
            this.lblCompareTo.Tag = "compareTo";
            this.lblCompareTo.Text = "CompareTo";
            this.lblCompareTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(343, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 9;
            this.label5.Tag = "assignAttribute";
            this.label5.Text = "AssignAttribute";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboAssignFrom
            // 
            this.cboAssignFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboAssignFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignFrom.FormattingEnabled = true;
            this.cboAssignFrom.Items.AddRange(new object[] {
            "",
            "Equipment",
            "Lot",
            "Step",
            "WorkOrder"});
            this.cboAssignFrom.Location = new System.Drawing.Point(113, 99);
            this.cboAssignFrom.Name = "cboAssignFrom";
            this.cboAssignFrom.Size = new System.Drawing.Size(216, 24);
            this.cboAssignFrom.Sorted = true;
            this.cboAssignFrom.TabIndex = 10;
            this.cboAssignFrom.SelectedIndexChanged += new System.EventHandler(this.cboAssignFrom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 8;
            this.label4.Tag = "assignFrom";
            this.label4.Text = "AssignFrom";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboModifyTarget
            // 
            this.cboModifyTarget.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboModifyTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModifyTarget.FormattingEnabled = true;
            this.cboModifyTarget.Items.AddRange(new object[] {
            "",
            "Equipment",
            "Lot"});
            this.cboModifyTarget.Location = new System.Drawing.Point(113, 70);
            this.cboModifyTarget.Name = "cboModifyTarget";
            this.cboModifyTarget.Size = new System.Drawing.Size(216, 24);
            this.cboModifyTarget.Sorted = true;
            this.cboModifyTarget.TabIndex = 7;
            this.cboModifyTarget.SelectedIndexChanged += new System.EventHandler(this.cboModifyTarget_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 7;
            this.label3.Tag = "modifyTarget";
            this.label3.Text = "ModifyTarget";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLength
            // 
            this.txtLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLength.BackColor = System.Drawing.SystemColors.Info;
            this.txtLength.Location = new System.Drawing.Point(817, 3);
            this.txtLength.MaxLength = 3;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(48, 26);
            this.txtLength.TabIndex = 3;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtLength.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblLength
            // 
            this.lblLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLength.AutoSize = true;
            this.lblLength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLength.Location = new System.Drawing.Point(755, 8);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(56, 16);
            this.lblLength.TabIndex = 9;
            this.lblLength.Tag = "length";
            this.lblLength.Text = "length";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.rdoOptions);
            this.panel1.Controls.Add(this.rdoNumber);
            this.panel1.Controls.Add(this.rdoString);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(474, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 32);
            this.panel1.TabIndex = 1;
            // 
            // rdoOptions
            // 
            this.rdoOptions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoOptions.AutoSize = true;
            this.rdoOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoOptions.Location = new System.Drawing.Point(145, 6);
            this.rdoOptions.Name = "rdoOptions";
            this.rdoOptions.Size = new System.Drawing.Size(82, 20);
            this.rdoOptions.TabIndex = 22;
            this.rdoOptions.Tag = "options";
            this.rdoOptions.Text = "options";
            this.rdoOptions.UseVisualStyleBackColor = true;
            this.rdoOptions.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoNumber
            // 
            this.rdoNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoNumber.AutoSize = true;
            this.rdoNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoNumber.Location = new System.Drawing.Point(75, 6);
            this.rdoNumber.Name = "rdoNumber";
            this.rdoNumber.Size = new System.Drawing.Size(74, 20);
            this.rdoNumber.TabIndex = 2;
            this.rdoNumber.Tag = "number";
            this.rdoNumber.Text = "number";
            this.rdoNumber.UseVisualStyleBackColor = true;
            this.rdoNumber.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoString
            // 
            this.rdoString.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoString.AutoSize = true;
            this.rdoString.Checked = true;
            this.rdoString.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoString.Location = new System.Drawing.Point(2, 6);
            this.rdoString.Name = "rdoString";
            this.rdoString.Size = new System.Drawing.Size(74, 20);
            this.rdoString.TabIndex = 1;
            this.rdoString.TabStop = true;
            this.rdoString.Tag = "string";
            this.rdoString.Text = "string";
            this.rdoString.UseVisualStyleBackColor = true;
            this.rdoString.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // lblDCItem
            // 
            this.lblDCItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDCItem.AutoSize = true;
            this.lblDCItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDCItem.Location = new System.Drawing.Point(51, 8);
            this.lblDCItem.Name = "lblDCItem";
            this.lblDCItem.Size = new System.Drawing.Size(56, 16);
            this.lblDCItem.TabIndex = 0;
            this.lblDCItem.Tag = "stepDC";
            this.lblDCItem.Text = "stepDC";
            this.lblDCItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDCItem
            // 
            this.txtDCItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDCItem.BackColor = System.Drawing.SystemColors.Info;
            this.txtDCItem.Location = new System.Drawing.Point(113, 3);
            this.txtDCItem.MaxLength = 40;
            this.txtDCItem.Name = "txtDCItem";
            this.txtDCItem.Size = new System.Drawing.Size(216, 26);
            this.txtDCItem.TabIndex = 0;
            this.txtDCItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblDataType
            // 
            this.lblDataType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataType.AutoSize = true;
            this.lblDataType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataType.Location = new System.Drawing.Point(399, 8);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(72, 16);
            this.lblDataType.TabIndex = 2;
            this.lblDataType.Tag = "dataType";
            this.lblDataType.Text = "dataType";
            this.lblDataType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAttributeName
            // 
            this.cboAttributeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboAttributeName.FormattingEnabled = true;
            this.cboAttributeName.Location = new System.Drawing.Point(477, 70);
            this.cboAttributeName.MaxLength = 40;
            this.cboAttributeName.Name = "cboAttributeName";
            this.cboAttributeName.Size = new System.Drawing.Size(221, 24);
            this.cboAttributeName.Sorted = true;
            this.cboAttributeName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(359, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 6;
            this.label1.Tag = "modifyAttribute";
            this.label1.Text = "AttributeName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(723, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Tag = "columnName";
            this.label2.Text = "columnName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtColumnName
            // 
            this.txtColumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColumnName.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtColumnName, 2);
            this.txtColumnName.Location = new System.Drawing.Point(817, 67);
            this.txtColumnName.MaxLength = 40;
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(209, 26);
            this.txtColumnName.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.chkVisible);
            this.panel2.Controls.Add(this.chkEnabled);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(868, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 32);
            this.panel2.TabIndex = 5;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkVisible.Location = new System.Drawing.Point(75, 7);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(83, 20);
            this.chkVisible.TabIndex = 5;
            this.chkVisible.Tag = "visible";
            this.chkVisible.Text = "Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEnabled.Location = new System.Drawing.Point(6, 7);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(83, 20);
            this.chkEnabled.TabIndex = 4;
            this.chkEnabled.Tag = "enabled";
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // cboOperator
            // 
            this.cboOperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "",
            "<",
            "<=",
            "=",
            ">",
            ">="});
            this.cboOperator.Location = new System.Drawing.Point(477, 132);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(48, 24);
            this.cboOperator.Sorted = true;
            this.cboOperator.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(11, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 16);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Tag = "description";
            this.lblDescription.Text = "description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Location = new System.Drawing.Point(113, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(358, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // mesListView1
            // 
            this.mesListView1.allowUserFilter = false;
            this.mesListView1.allowUserSorting = false;
            this.mesListView1.autoSizeColumn = true;
            this.mesListView1.careModifyDate = false;
            this.mesListView1.columnHide = null;
            this.mesListView1.columnNames = new string[] {
        "name",
        "length",
        "dataType",
        "required",
        "timing",
        "checkFailPath",
        "checkSeq",
        "message",
        "modifyTarget",
        "attributeName",
        "columnName",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "stepDC",
        "length",
        "dataType",
        "requireInput",
        "timing",
        "pathName",
        "checkSeq",
        "message",
        "modifyTarget",
        "modifyAttribute",
        "columnName",
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
            this.mesListView1.Location = new System.Drawing.Point(0, 0);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(1042, 196);
            this.mesListView1.TabIndex = 21;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            this.mesListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mesListView1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "down.ico");
            this.imageList1.Images.SetKeyName(1, "left.ico");
            this.imageList1.Images.SetKeyName(2, "right.ico");
            this.imageList1.Images.SetKeyName(3, "up.ico");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mesListView1);
            this.panel3.Controls.Add(this.pnlUpDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1074, 196);
            this.panel3.TabIndex = 6;
            // 
            // pnlUpDown
            // 
            this.pnlUpDown.Controls.Add(this.btnDown);
            this.pnlUpDown.Controls.Add(this.btnUp);
            this.pnlUpDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpDown.Location = new System.Drawing.Point(1042, 0);
            this.pnlUpDown.Name = "pnlUpDown";
            this.pnlUpDown.Size = new System.Drawing.Size(32, 196);
            this.pnlUpDown.TabIndex = 6;
            this.pnlUpDown.Visible = false;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDown.ImageKey = "down.ico";
            this.btnDown.ImageList = this.imageList1;
            this.btnDown.Location = new System.Drawing.Point(4, 43);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 34);
            this.btnDown.TabIndex = 22;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUp.ImageKey = "up.ico";
            this.btnUp.ImageList = this.imageList1;
            this.btnUp.Location = new System.Drawing.Point(4, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 34);
            this.btnUp.TabIndex = 22;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // frmStepDC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1074, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStepDC";
            this.Tag = "stepDC";
            this.Text = "frmStepDC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStepDC_FormClosed);
            this.Load += new System.EventHandler(this.frmStepDC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlUpDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoNumber;
        private System.Windows.Forms.RadioButton rdoString;
        private System.Windows.Forms.Label lblDCItem;
        private System.Windows.Forms.TextBox txtDCItem;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.ComboBox cboAttributeName;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboModifyTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboCompareAttribute;
        private System.Windows.Forms.ComboBox cboCompareTo;
        private System.Windows.Forms.ComboBox cboAssignAttribute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCompareAttribute;
        private System.Windows.Forms.Label lblCompareTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAssignFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlUpDown;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdoCustom;
        private System.Windows.Forms.RadioButton rdoBySetting;
        private System.Windows.Forms.TextBox txtSourceDB;
        private System.Windows.Forms.Label lblSourceDB;
        private System.Windows.Forms.TextBox txtSourceSql;
        private System.Windows.Forms.Label lblSourceSql;
        private System.Windows.Forms.TextBox txtTargetSql;
        private System.Windows.Forms.Label lblTargetSql;
        private System.Windows.Forms.TextBox txtTargetDB;
        private System.Windows.Forms.Label lblTargetDB;
        private System.Windows.Forms.TextBox txtAssemblyName;
        private System.Windows.Forms.Label lblAssemblyName;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.RadioButton rdoOptions;
        private System.Windows.Forms.TextBox txtOptions;
    }
}