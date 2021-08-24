namespace mesBasicData
{
    partial class frmEqStateChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEqStateChange));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstToState = new System.Windows.Forms.ListBox();
            this.lstDivision = new System.Windows.Forms.ListBox();
            this.lblFromState = new System.Windows.Forms.Label();
            this.lstFromState = new System.Windows.Forms.ListBox();
            this.lblToState = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.lvwStateRule = new System.Windows.Forms.ListView();
            this.fromState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.division = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(855, 256);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editStatusChange";
            this.groupBox1.Text = "editStatusChange";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lstToState, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstDivision, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFromState, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstFromState, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblToState, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDivision, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 234);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lstToState
            // 
            this.lstToState.BackColor = System.Drawing.SystemColors.Info;
            this.lstToState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstToState.FormattingEnabled = true;
            this.lstToState.ItemHeight = 16;
            this.lstToState.Location = new System.Drawing.Point(302, 19);
            this.lstToState.Name = "lstToState";
            this.lstToState.Size = new System.Drawing.Size(243, 212);
            this.lstToState.Sorted = true;
            this.lstToState.TabIndex = 9;
            // 
            // lstDivision
            // 
            this.lstDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDivision.FormattingEnabled = true;
            this.lstDivision.ItemHeight = 16;
            this.lstDivision.Location = new System.Drawing.Point(601, 19);
            this.lstDivision.Name = "lstDivision";
            this.lstDivision.Size = new System.Drawing.Size(245, 212);
            this.lstDivision.Sorted = true;
            this.lstDivision.TabIndex = 9;
            // 
            // lblFromState
            // 
            this.lblFromState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFromState.AutoSize = true;
            this.lblFromState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFromState.Location = new System.Drawing.Point(3, 0);
            this.lblFromState.Name = "lblFromState";
            this.lblFromState.Size = new System.Drawing.Size(88, 16);
            this.lblFromState.TabIndex = 0;
            this.lblFromState.Tag = "from_state";
            this.lblFromState.Text = "from_state";
            // 
            // lstFromState
            // 
            this.lstFromState.BackColor = System.Drawing.SystemColors.Info;
            this.lstFromState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFromState.FormattingEnabled = true;
            this.lstFromState.ItemHeight = 16;
            this.lstFromState.Location = new System.Drawing.Point(3, 19);
            this.lstFromState.Name = "lstFromState";
            this.lstFromState.Size = new System.Drawing.Size(243, 212);
            this.lstFromState.Sorted = true;
            this.lstFromState.TabIndex = 8;
            // 
            // lblToState
            // 
            this.lblToState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToState.AutoSize = true;
            this.lblToState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToState.Location = new System.Drawing.Point(302, 0);
            this.lblToState.Name = "lblToState";
            this.lblToState.Size = new System.Drawing.Size(72, 16);
            this.lblToState.TabIndex = 7;
            this.lblToState.Tag = "to_state";
            this.lblToState.Text = "to_state";
            // 
            // lblDivision
            // 
            this.lblDivision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDivision.AutoSize = true;
            this.lblDivision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDivision.Location = new System.Drawing.Point(601, 0);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(72, 16);
            this.lblDivision.TabIndex = 6;
            this.lblDivision.Tag = "division";
            this.lblDivision.Text = "division";
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(855, 25);
            this.actionToolbar1.TabIndex = 4;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // lvwStateRule
            // 
            this.lvwStateRule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fromState,
            this.toState,
            this.division});
            this.lvwStateRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStateRule.FullRowSelect = true;
            this.lvwStateRule.GridLines = true;
            this.lvwStateRule.HideSelection = false;
            this.lvwStateRule.Location = new System.Drawing.Point(0, 281);
            this.lvwStateRule.MultiSelect = false;
            this.lvwStateRule.Name = "lvwStateRule";
            this.lvwStateRule.Size = new System.Drawing.Size(855, 377);
            this.lvwStateRule.TabIndex = 6;
            this.lvwStateRule.UseCompatibleStateImageBehavior = false;
            this.lvwStateRule.View = System.Windows.Forms.View.Details;
            this.lvwStateRule.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwStateRule_ItemSelectionChanged);
            // 
            // fromState
            // 
            this.fromState.Tag = "from_state";
            this.fromState.Text = "from_state";
            this.fromState.Width = 92;
            // 
            // toState
            // 
            this.toState.Tag = "to_state";
            this.toState.Text = "to_state";
            this.toState.Width = 98;
            // 
            // division
            // 
            this.division.Tag = "division";
            this.division.Text = "division";
            this.division.Width = 109;
            // 
            // frmEqStateChange
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(855, 658);
            this.Controls.Add(this.lvwStateRule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEqStateChange";
            this.Tag = "EqStateChange";
            this.Text = "frmEqStateChange";
            this.Activated += new System.EventHandler(this.frmEqStateChange_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.Label lblToState;
        private System.Windows.Forms.Label lblFromState;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.ListBox lstFromState;
        private System.Windows.Forms.ListBox lstToState;
        private System.Windows.Forms.ListBox lstDivision;
        private System.Windows.Forms.ListView lvwStateRule;
        private System.Windows.Forms.ColumnHeader fromState;
        private System.Windows.Forms.ColumnHeader toState;
        private System.Windows.Forms.ColumnHeader division;
    }
}