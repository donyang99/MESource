namespace mesBasicData
{
    partial class frmStepConsumeMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStepConsumeMaterial));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwStep = new idv.mesCore.Controls.MESListView();
            this.lvwMaterialType = new idv.mesCore.Controls.MESListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtConsumeRate = new System.Windows.Forms.TextBox();
            this.lblConsumeRate = new System.Windows.Forms.Label();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.cboMaterialType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwStep);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwMaterialType);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.actionToolbar1);
            this.splitContainer1.Size = new System.Drawing.Size(970, 571);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvwStep
            // 
            this.lvwStep.allowUserFilter = true;
            this.lvwStep.allowUserSorting = true;
            this.lvwStep.autoSizeColumn = true;
            this.lvwStep.careModifyDate = false;
            this.lvwStep.columnHide = null;
            this.lvwStep.columnNames = new string[] {
        "name",
        "version",
        "fab"};
            this.lvwStep.columnTags = new string[] {
        "Step",
        "version",
        "fab"};
            this.lvwStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStep.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwStep.FullRowSelect = true;
            this.lvwStep.GridLines = true;
            this.lvwStep.HideSelection = false;
            this.lvwStep.imageKeyColumn = "";
            this.lvwStep.keyPressSearch = false;
            this.lvwStep.keyPressSearchColumn = "";
            this.lvwStep.Location = new System.Drawing.Point(0, 0);
            this.lvwStep.makesureNewItemVisible = false;
            this.lvwStep.MultiSelect = false;
            this.lvwStep.Name = "lvwStep";
            this.lvwStep.OwnerDraw = true;
            this.lvwStep.ShowItemTipSecond = ((byte)(3));
            this.lvwStep.Size = new System.Drawing.Size(241, 571);
            this.lvwStep.TabIndex = 1;
            this.lvwStep.UseCompatibleStateImageBehavior = false;
            this.lvwStep.View = System.Windows.Forms.View.Details;
            this.lvwStep.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwStep_MESItemSelectionChanged);
            // 
            // lvwMaterialType
            // 
            this.lvwMaterialType.allowUserFilter = false;
            this.lvwMaterialType.allowUserSorting = true;
            this.lvwMaterialType.autoSizeColumn = true;
            this.lvwMaterialType.careModifyDate = false;
            this.lvwMaterialType.columnHide = null;
            this.lvwMaterialType.columnNames = new string[] {
        "name",
        "consumeRate",
        "required"};
            this.lvwMaterialType.columnTags = new string[] {
        "materialType",
        "consumeRate",
        "requireInput"};
            this.lvwMaterialType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMaterialType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwMaterialType.FullRowSelect = true;
            this.lvwMaterialType.GridLines = true;
            this.lvwMaterialType.HideSelection = false;
            this.lvwMaterialType.imageKeyColumn = "";
            this.lvwMaterialType.keyPressSearch = false;
            this.lvwMaterialType.keyPressSearchColumn = "";
            this.lvwMaterialType.Location = new System.Drawing.Point(0, 107);
            this.lvwMaterialType.makesureNewItemVisible = true;
            this.lvwMaterialType.MultiSelect = false;
            this.lvwMaterialType.Name = "lvwMaterialType";
            this.lvwMaterialType.OwnerDraw = true;
            this.lvwMaterialType.ShowItemTipSecond = ((byte)(3));
            this.lvwMaterialType.Size = new System.Drawing.Size(725, 464);
            this.lvwMaterialType.TabIndex = 5;
            this.lvwMaterialType.UseCompatibleStateImageBehavior = false;
            this.lvwMaterialType.View = System.Windows.Forms.View.Details;
            this.lvwMaterialType.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwMaterialType_MESItemSelectionChanged);
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
            this.groupBox1.Size = new System.Drawing.Size(725, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editStepMaterial";
            this.groupBox1.Text = "editStepMaterial";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 51);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(719, 28);
            this.pnlExt.TabIndex = 6;
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
            this.tblDetail.Controls.Add(this.txtConsumeRate, 3, 0);
            this.tblDetail.Controls.Add(this.lblConsumeRate, 2, 0);
            this.tblDetail.Controls.Add(this.lblMaterialType, 0, 0);
            this.tblDetail.Controls.Add(this.lblRequired, 4, 0);
            this.tblDetail.Controls.Add(this.cboMaterialType, 1, 0);
            this.tblDetail.Controls.Add(this.panel1, 5, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 1;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Size = new System.Drawing.Size(719, 32);
            this.tblDetail.TabIndex = 0;
            // 
            // txtConsumeRate
            // 
            this.txtConsumeRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConsumeRate.BackColor = System.Drawing.SystemColors.Info;
            this.txtConsumeRate.Location = new System.Drawing.Point(413, 3);
            this.txtConsumeRate.MaxLength = 8;
            this.txtConsumeRate.Name = "txtConsumeRate";
            this.txtConsumeRate.Size = new System.Drawing.Size(59, 26);
            this.txtConsumeRate.TabIndex = 1;
            this.txtConsumeRate.TabStop = false;
            this.txtConsumeRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtConsumeRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblConsumeRate
            // 
            this.lblConsumeRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConsumeRate.AutoSize = true;
            this.lblConsumeRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConsumeRate.Location = new System.Drawing.Point(311, 8);
            this.lblConsumeRate.Name = "lblConsumeRate";
            this.lblConsumeRate.Size = new System.Drawing.Size(96, 16);
            this.lblConsumeRate.TabIndex = 9;
            this.lblConsumeRate.Tag = "consumeRate";
            this.lblConsumeRate.Text = "consumeRate";
            this.lblConsumeRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaterialType.Location = new System.Drawing.Point(3, 8);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(104, 16);
            this.lblMaterialType.TabIndex = 0;
            this.lblMaterialType.Tag = "materialType";
            this.lblMaterialType.Text = "materialType";
            this.lblMaterialType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRequired
            // 
            this.lblRequired.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRequired.AutoSize = true;
            this.lblRequired.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRequired.Location = new System.Drawing.Point(478, 8);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(104, 16);
            this.lblRequired.TabIndex = 2;
            this.lblRequired.Tag = "requireInput";
            this.lblRequired.Text = "requireInput";
            this.lblRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMaterialType
            // 
            this.cboMaterialType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboMaterialType.BackColor = System.Drawing.SystemColors.Info;
            this.cboMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterialType.FormattingEnabled = true;
            this.cboMaterialType.Location = new System.Drawing.Point(113, 4);
            this.cboMaterialType.MaxDropDownItems = 15;
            this.cboMaterialType.Name = "cboMaterialType";
            this.cboMaterialType.Size = new System.Drawing.Size(192, 24);
            this.cboMaterialType.Sorted = true;
            this.cboMaterialType.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNo);
            this.panel1.Controls.Add(this.rdoYes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(585, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 32);
            this.panel1.TabIndex = 10;
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoNo.Location = new System.Drawing.Point(55, 6);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(42, 20);
            this.rdoNo.TabIndex = 3;
            this.rdoNo.Tag = "buttonNo";
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Checked = true;
            this.rdoYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoYes.Location = new System.Drawing.Point(2, 6);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(50, 20);
            this.rdoYes.TabIndex = 2;
            this.rdoYes.TabStop = true;
            this.rdoYes.Tag = "buttonYes";
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(725, 25);
            this.actionToolbar1.TabIndex = 1;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmStepConsumeMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(970, 571);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStepConsumeMaterial";
            this.Tag = "StepConsumeMaterial";
            this.Text = "StepConsumeMaterial";
            this.Activated += new System.EventHandler(this.frmStepConsumeMaterial_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStepConsumeMaterial_FormClosed);
            this.Load += new System.EventHandler(this.frmStepConsumeMaterial_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private idv.mesCore.Controls.MESListView lvwStep;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private idv.mesCore.Controls.MESListView lvwMaterialType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtConsumeRate;
        private System.Windows.Forms.Label lblConsumeRate;
        private System.Windows.Forms.ComboBox cboMaterialType;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.Panel pnlExt;
    }
}