namespace mesBasicData
{
    partial class frmViewStep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewStep));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtComponentType = new System.Windows.Forms.TextBox();
            this.txtStepCode = new System.Windows.Forms.TextBox();
            this.txtStage = new System.Windows.Forms.TextBox();
            this.txtFAB = new System.Windows.Forms.TextBox();
            this.txtEqGroup = new System.Windows.Forms.TextBox();
            this.lblFAB = new System.Windows.Forms.Label();
            this.lblEqGroup = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblComponentType = new System.Windows.Forms.Label();
            this.lblStepCode = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.lvwRules = new idv.mesCore.Controls.MESListView();
            this.lvwStepDC = new idv.mesCore.Controls.MESListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(945, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Step";
            this.groupBox1.Text = "Step";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtComponentType, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStepCode, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStage, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFAB, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEqGroup, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFAB, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEqGroup, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStep, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStep, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVersion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblComponentType, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStepCode, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStage, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtComponentType
            // 
            this.txtComponentType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtComponentType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtComponentType.Location = new System.Drawing.Point(814, 35);
            this.txtComponentType.MaxLength = 40;
            this.txtComponentType.Name = "txtComponentType";
            this.txtComponentType.ReadOnly = true;
            this.txtComponentType.Size = new System.Drawing.Size(122, 26);
            this.txtComponentType.TabIndex = 8;
            this.txtComponentType.TabStop = false;
            // 
            // txtStepCode
            // 
            this.txtStepCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStepCode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStepCode.Location = new System.Drawing.Point(814, 3);
            this.txtStepCode.MaxLength = 40;
            this.txtStepCode.Name = "txtStepCode";
            this.txtStepCode.ReadOnly = true;
            this.txtStepCode.Size = new System.Drawing.Size(122, 26);
            this.txtStepCode.TabIndex = 8;
            this.txtStepCode.TabStop = false;
            // 
            // txtStage
            // 
            this.txtStage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStage.Location = new System.Drawing.Point(608, 35);
            this.txtStage.MaxLength = 40;
            this.txtStage.Name = "txtStage";
            this.txtStage.ReadOnly = true;
            this.txtStage.Size = new System.Drawing.Size(114, 26);
            this.txtStage.TabIndex = 8;
            this.txtStage.TabStop = false;
            // 
            // txtFAB
            // 
            this.txtFAB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFAB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFAB.Location = new System.Drawing.Point(608, 3);
            this.txtFAB.MaxLength = 40;
            this.txtFAB.Name = "txtFAB";
            this.txtFAB.ReadOnly = true;
            this.txtFAB.Size = new System.Drawing.Size(114, 26);
            this.txtFAB.TabIndex = 8;
            this.txtFAB.TabStop = false;
            // 
            // txtEqGroup
            // 
            this.txtEqGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEqGroup.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEqGroup.Location = new System.Drawing.Point(429, 3);
            this.txtEqGroup.MaxLength = 40;
            this.txtEqGroup.Name = "txtEqGroup";
            this.txtEqGroup.ReadOnly = true;
            this.txtEqGroup.Size = new System.Drawing.Size(119, 26);
            this.txtEqGroup.TabIndex = 8;
            this.txtEqGroup.TabStop = false;
            // 
            // lblFAB
            // 
            this.lblFAB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFAB.AutoSize = true;
            this.lblFAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFAB.Location = new System.Drawing.Point(570, 8);
            this.lblFAB.Name = "lblFAB";
            this.lblFAB.Size = new System.Drawing.Size(32, 16);
            this.lblFAB.TabIndex = 9;
            this.lblFAB.Tag = "fab";
            this.lblFAB.Text = "fab";
            this.lblFAB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEqGroup
            // 
            this.lblEqGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEqGroup.AutoSize = true;
            this.lblEqGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqGroup.Location = new System.Drawing.Point(359, 8);
            this.lblEqGroup.Name = "lblEqGroup";
            this.lblEqGroup.Size = new System.Drawing.Size(64, 16);
            this.lblEqGroup.TabIndex = 9;
            this.lblEqGroup.Tag = "EquipmentGroup";
            this.lblEqGroup.Text = "eqGroup";
            this.lblEqGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStep
            // 
            this.lblStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStep.AutoSize = true;
            this.lblStep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStep.Location = new System.Drawing.Point(59, 8);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(40, 16);
            this.lblStep.TabIndex = 0;
            this.lblStep.Tag = "Step";
            this.lblStep.Text = "Step";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStep
            // 
            this.txtStep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStep.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStep.Location = new System.Drawing.Point(105, 3);
            this.txtStep.MaxLength = 40;
            this.txtStep.Name = "txtStep";
            this.txtStep.ReadOnly = true;
            this.txtStep.Size = new System.Drawing.Size(134, 26);
            this.txtStep.TabIndex = 0;
            this.txtStep.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVersion.Location = new System.Drawing.Point(245, 8);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(64, 16);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Tag = "version";
            this.lblVersion.Text = "version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVersion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtVersion.Location = new System.Drawing.Point(315, 3);
            this.txtVersion.MaxLength = 40;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(38, 26);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.TabStop = false;
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
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 4);
            this.txtDescription.Location = new System.Drawing.Point(105, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(318, 26);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TabStop = false;
            // 
            // lblComponentType
            // 
            this.lblComponentType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblComponentType.AutoSize = true;
            this.lblComponentType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComponentType.Location = new System.Drawing.Point(728, 40);
            this.lblComponentType.Name = "lblComponentType";
            this.lblComponentType.Size = new System.Drawing.Size(80, 16);
            this.lblComponentType.TabIndex = 6;
            this.lblComponentType.Tag = "ComponentType";
            this.lblComponentType.Text = "Comp Type";
            this.lblComponentType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStepCode
            // 
            this.lblStepCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStepCode.AutoSize = true;
            this.lblStepCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStepCode.Location = new System.Drawing.Point(736, 8);
            this.lblStepCode.Name = "lblStepCode";
            this.lblStepCode.Size = new System.Drawing.Size(72, 16);
            this.lblStepCode.TabIndex = 9;
            this.lblStepCode.Tag = "stepCode";
            this.lblStepCode.Text = "stepCode";
            this.lblStepCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStage
            // 
            this.lblStage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStage.AutoSize = true;
            this.lblStage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStage.Location = new System.Drawing.Point(554, 40);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(48, 16);
            this.lblStage.TabIndex = 6;
            this.lblStage.Tag = "stage";
            this.lblStage.Text = "stage";
            this.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwRules
            // 
            this.lvwRules.allowUserFilter = false;
            this.lvwRules.allowUserSorting = false;
            this.lvwRules.autoSizeColumn = true;
            this.lvwRules.careModifyDate = false;
            this.lvwRules.columnHide = null;
            this.lvwRules.columnNames = new string[] {
        "name",
        "dispatchFlag",
        "description"};
            this.lvwRules.columnTags = new string[] {
        "rule",
        "dispatchFlag",
        "description"};
            this.lvwRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRules.FullRowSelect = true;
            this.lvwRules.GridLines = true;
            this.lvwRules.HideSelection = false;
            this.lvwRules.imageKeyColumn = "";
            this.lvwRules.keyPressSearch = false;
            this.lvwRules.keyPressSearchColumn = "";
            this.lvwRules.Location = new System.Drawing.Point(3, 22);
            this.lvwRules.makesureNewItemVisible = false;
            this.lvwRules.MultiSelect = false;
            this.lvwRules.Name = "lvwRules";
            this.lvwRules.OwnerDraw = true;
            this.lvwRules.ShowItemTipSecond = ((byte)(3));
            this.lvwRules.Size = new System.Drawing.Size(298, 292);
            this.lvwRules.TabIndex = 8;
            this.lvwRules.UseCompatibleStateImageBehavior = false;
            this.lvwRules.View = System.Windows.Forms.View.Details;
            // 
            // lvwStepDC
            // 
            this.lvwStepDC.allowUserFilter = false;
            this.lvwStepDC.allowUserSorting = true;
            this.lvwStepDC.autoSizeColumn = true;
            this.lvwStepDC.careModifyDate = false;
            this.lvwStepDC.columnHide = null;
            this.lvwStepDC.columnNames = new string[] {
        "name",
        "length",
        "dataType",
        "description",
        "modifyUser",
        "modifyDate"};
            this.lvwStepDC.columnTags = new string[] {
        "stepDC",
        "length",
        "dataType",
        "description",
        "modifyUser",
        "modifyDate"};
            this.lvwStepDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStepDC.FullRowSelect = true;
            this.lvwStepDC.GridLines = true;
            this.lvwStepDC.HideSelection = false;
            this.lvwStepDC.imageKeyColumn = "";
            this.lvwStepDC.keyPressSearch = false;
            this.lvwStepDC.keyPressSearchColumn = "";
            this.lvwStepDC.Location = new System.Drawing.Point(3, 22);
            this.lvwStepDC.makesureNewItemVisible = true;
            this.lvwStepDC.MultiSelect = false;
            this.lvwStepDC.Name = "lvwStepDC";
            this.lvwStepDC.OwnerDraw = true;
            this.lvwStepDC.ShowItemTipSecond = ((byte)(3));
            this.lvwStepDC.Size = new System.Drawing.Size(635, 292);
            this.lvwStepDC.TabIndex = 9;
            this.lvwStepDC.UseCompatibleStateImageBehavior = false;
            this.lvwStepDC.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwRules);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(0, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 317);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "rule";
            this.groupBox2.Text = "rule";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwStepDC);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(304, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 317);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "stepDC";
            this.groupBox3.Text = "stepDC";
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(839, 383);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 20);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "cancel";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // frmViewStep
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(945, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Step";
            this.Text = "frmViewStep";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFAB;
        private System.Windows.Forms.Label lblEqGroup;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblComponentType;
        private System.Windows.Forms.Label lblStepCode;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.TextBox txtComponentType;
        private System.Windows.Forms.TextBox txtStepCode;
        private System.Windows.Forms.TextBox txtStage;
        private System.Windows.Forms.TextBox txtFAB;
        private System.Windows.Forms.TextBox txtEqGroup;
        private idv.mesCore.Controls.MESListView lvwRules;
        private idv.mesCore.Controls.MESListView lvwStepDC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonExit;
    }
}