namespace toolingFunction
{
    partial class frmToolingType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolingType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.chkRunTimeFlag = new System.Windows.Forms.CheckBox();
            this.txtOwnDept = new System.Windows.Forms.TextBox();
            this.lblOwnerDept = new System.Windows.Forms.Label();
            this.cboCounterType = new System.Windows.Forms.ComboBox();
            this.lblCounterType = new System.Windows.Forms.Label();
            this.cboControlType = new System.Windows.Forms.ComboBox();
            this.lblToolingType = new System.Windows.Forms.Label();
            this.txtToolingType = new System.Windows.Forms.TextBox();
            this.lblControlType = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkVerify = new System.Windows.Forms.CheckBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.grpEqType = new System.Windows.Forms.GroupBox();
            this.lvwEqType = new idv.mesCore.Controls.MESListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.grpEqType.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(932, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 86);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(926, 28);
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
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.Controls.Add(this.chkRunTimeFlag, 6, 0);
            this.tblDetail.Controls.Add(this.txtOwnDept, 1, 1);
            this.tblDetail.Controls.Add(this.lblOwnerDept, 0, 1);
            this.tblDetail.Controls.Add(this.cboCounterType, 5, 0);
            this.tblDetail.Controls.Add(this.lblCounterType, 4, 0);
            this.tblDetail.Controls.Add(this.cboControlType, 3, 0);
            this.tblDetail.Controls.Add(this.lblToolingType, 0, 0);
            this.tblDetail.Controls.Add(this.txtToolingType, 1, 0);
            this.tblDetail.Controls.Add(this.lblControlType, 2, 0);
            this.tblDetail.Controls.Add(this.txtDescription, 3, 1);
            this.tblDetail.Controls.Add(this.label4, 2, 1);
            this.tblDetail.Controls.Add(this.chkVerify, 6, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 22);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(926, 64);
            this.tblDetail.TabIndex = 0;
            // 
            // chkRunTimeFlag
            // 
            this.chkRunTimeFlag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRunTimeFlag.AutoSize = true;
            this.chkRunTimeFlag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRunTimeFlag.Location = new System.Drawing.Point(763, 6);
            this.chkRunTimeFlag.Name = "chkRunTimeFlag";
            this.chkRunTimeFlag.Size = new System.Drawing.Size(115, 20);
            this.chkRunTimeFlag.TabIndex = 10;
            this.chkRunTimeFlag.Tag = "RunTimeFlag";
            this.chkRunTimeFlag.Text = "RunTimeFlag";
            this.chkRunTimeFlag.UseVisualStyleBackColor = true;
            // 
            // txtOwnDept
            // 
            this.txtOwnDept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOwnDept.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtOwnDept.Location = new System.Drawing.Point(105, 35);
            this.txtOwnDept.MaxLength = 20;
            this.txtOwnDept.Name = "txtOwnDept";
            this.txtOwnDept.Size = new System.Drawing.Size(190, 26);
            this.txtOwnDept.TabIndex = 4;
            // 
            // lblOwnerDept
            // 
            this.lblOwnerDept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOwnerDept.AutoSize = true;
            this.lblOwnerDept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOwnerDept.Location = new System.Drawing.Point(19, 40);
            this.lblOwnerDept.Name = "lblOwnerDept";
            this.lblOwnerDept.Size = new System.Drawing.Size(80, 16);
            this.lblOwnerDept.TabIndex = 10;
            this.lblOwnerDept.Tag = "ownerDept";
            this.lblOwnerDept.Text = "ownerDept";
            this.lblOwnerDept.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboCounterType
            // 
            this.cboCounterType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCounterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounterType.FormattingEnabled = true;
            this.cboCounterType.Location = new System.Drawing.Point(634, 4);
            this.cboCounterType.Name = "cboCounterType";
            this.cboCounterType.Size = new System.Drawing.Size(123, 24);
            this.cboCounterType.TabIndex = 2;
            // 
            // lblCounterType
            // 
            this.lblCounterType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCounterType.AutoSize = true;
            this.lblCounterType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCounterType.Location = new System.Drawing.Point(532, 8);
            this.lblCounterType.Name = "lblCounterType";
            this.lblCounterType.Size = new System.Drawing.Size(96, 16);
            this.lblCounterType.TabIndex = 11;
            this.lblCounterType.Tag = "CounterType";
            this.lblCounterType.Text = "CounterType";
            this.lblCounterType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboControlType
            // 
            this.cboControlType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboControlType.BackColor = System.Drawing.SystemColors.Info;
            this.cboControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboControlType.FormattingEnabled = true;
            this.cboControlType.Location = new System.Drawing.Point(403, 4);
            this.cboControlType.Name = "cboControlType";
            this.cboControlType.Size = new System.Drawing.Size(123, 24);
            this.cboControlType.TabIndex = 1;
            this.cboControlType.SelectedIndexChanged += new System.EventHandler(this.cboControlType_SelectedIndexChanged);
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingType.Location = new System.Drawing.Point(3, 8);
            this.lblToolingType.Name = "lblToolingType";
            this.lblToolingType.Size = new System.Drawing.Size(96, 16);
            this.lblToolingType.TabIndex = 0;
            this.lblToolingType.Tag = "ToolingType";
            this.lblToolingType.Text = "ToolingType";
            this.lblToolingType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtToolingType
            // 
            this.txtToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtToolingType.BackColor = System.Drawing.SystemColors.Info;
            this.txtToolingType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtToolingType.Location = new System.Drawing.Point(105, 3);
            this.txtToolingType.MaxLength = 40;
            this.txtToolingType.Name = "txtToolingType";
            this.txtToolingType.Size = new System.Drawing.Size(190, 26);
            this.txtToolingType.TabIndex = 0;
            // 
            // lblControlType
            // 
            this.lblControlType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblControlType.AutoSize = true;
            this.lblControlType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblControlType.Location = new System.Drawing.Point(301, 8);
            this.lblControlType.Name = "lblControlType";
            this.lblControlType.Size = new System.Drawing.Size(96, 16);
            this.lblControlType.TabIndex = 10;
            this.lblControlType.Tag = "UseControlType";
            this.lblControlType.Text = "ControlType";
            this.lblControlType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDescription.Location = new System.Drawing.Point(403, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(354, 26);
            this.txtDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(301, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkVerify
            // 
            this.chkVerify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkVerify.AutoSize = true;
            this.chkVerify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkVerify.Location = new System.Drawing.Point(763, 38);
            this.chkVerify.Name = "chkVerify";
            this.chkVerify.Size = new System.Drawing.Size(75, 20);
            this.chkVerify.TabIndex = 3;
            this.chkVerify.Tag = "NeedVerify";
            this.chkVerify.Text = "Verify";
            this.chkVerify.UseVisualStyleBackColor = true;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(932, 25);
            this.actionToolbar1.TabIndex = 7;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
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
        "controlType",
        "consumeType",
        "runTimeFlag",
        "verifyFlag",
        "ownerDept",
        "description",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "ToolingType",
        "UseControlType",
        "CounterType",
        "RunTimeFlag",
        "NeedVerify",
        "ownerDept",
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
            this.mesListView1.Size = new System.Drawing.Size(668, 412);
            this.mesListView1.TabIndex = 9;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // grpEqType
            // 
            this.grpEqType.Controls.Add(this.lvwEqType);
            this.grpEqType.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpEqType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEqType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpEqType.Location = new System.Drawing.Point(668, 142);
            this.grpEqType.Name = "grpEqType";
            this.grpEqType.Size = new System.Drawing.Size(264, 412);
            this.grpEqType.TabIndex = 10;
            this.grpEqType.TabStop = false;
            this.grpEqType.Tag = "EquipmentType";
            this.grpEqType.Text = "EquipmentType";
            // 
            // lvwEqType
            // 
            this.lvwEqType.allowUserFilter = false;
            this.lvwEqType.allowUserSorting = true;
            this.lvwEqType.autoSizeColumn = true;
            this.lvwEqType.careModifyDate = false;
            this.lvwEqType.CheckBoxes = true;
            this.lvwEqType.columnHide = null;
            this.lvwEqType.columnNames = new string[] {
        "name",
        "description"};
            this.lvwEqType.columnTags = new string[] {
        "EquipmentType",
        "description"};
            this.lvwEqType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEqType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwEqType.FullRowSelect = true;
            this.lvwEqType.GridLines = true;
            this.lvwEqType.HideSelection = false;
            this.lvwEqType.imageKeyColumn = "";
            this.lvwEqType.keyPressSearch = false;
            this.lvwEqType.keyPressSearchColumn = "";
            this.lvwEqType.Location = new System.Drawing.Point(3, 22);
            this.lvwEqType.makesureNewItemVisible = true;
            this.lvwEqType.MultiSelect = false;
            this.lvwEqType.Name = "lvwEqType";
            this.lvwEqType.OwnerDraw = true;
            this.lvwEqType.ShowItemTipSecond = ((byte)(3));
            this.lvwEqType.Size = new System.Drawing.Size(258, 387);
            this.lvwEqType.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwEqType.TabIndex = 6;
            this.lvwEqType.UseCompatibleStateImageBehavior = false;
            this.lvwEqType.View = System.Windows.Forms.View.Details;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(665, 142);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 412);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // frmToolingType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 554);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.grpEqType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToolingType";
            this.Tag = "ToolingType";
            this.Text = "frmToolingType";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmToolingType_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmToolingType_FormClosed);
            this.Load += new System.EventHandler(this.frmToolingType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.grpEqType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Label lblToolingType;
        private System.Windows.Forms.TextBox txtToolingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.ComboBox cboControlType;
        private System.Windows.Forms.Label lblControlType;
        private System.Windows.Forms.ComboBox cboCounterType;
        private System.Windows.Forms.Label lblCounterType;
        private System.Windows.Forms.CheckBox chkVerify;
        private System.Windows.Forms.TextBox txtOwnDept;
        private System.Windows.Forms.Label lblOwnerDept;
        private System.Windows.Forms.CheckBox chkRunTimeFlag;
        private System.Windows.Forms.GroupBox grpEqType;
        private idv.mesCore.Controls.MESListView lvwEqType;
        private System.Windows.Forms.Splitter splitter1;
    }
}