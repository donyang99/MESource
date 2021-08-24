namespace mesBasicData
{
    partial class frmEquipmentGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentGroup));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEquipmentGroup = new System.Windows.Forms.Label();
            this.txtEquipmentGroup = new System.Windows.Forms.TextBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwAvailable = new idv.mesCore.Controls.MESListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwSelected = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lstGroups);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.actionToolbar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 566);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstGroups
            // 
            this.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.ItemHeight = 16;
            this.lstGroups.Location = new System.Drawing.Point(0, 57);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(301, 509);
            this.lstGroups.Sorted = true;
            this.lstGroups.TabIndex = 2;
            this.lstGroups.SelectedValueChanged += new System.EventHandler(this.lstGroups_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblEquipmentGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEquipmentGroup, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEquipmentGroup
            // 
            this.lblEquipmentGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEquipmentGroup.AutoSize = true;
            this.lblEquipmentGroup.Location = new System.Drawing.Point(3, 8);
            this.lblEquipmentGroup.Name = "lblEquipmentGroup";
            this.lblEquipmentGroup.Size = new System.Drawing.Size(120, 16);
            this.lblEquipmentGroup.TabIndex = 0;
            this.lblEquipmentGroup.Tag = "EquipmentGroup";
            this.lblEquipmentGroup.Text = "EquipmentGroup";
            // 
            // txtEquipmentGroup
            // 
            this.txtEquipmentGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipmentGroup.BackColor = System.Drawing.SystemColors.Info;
            this.txtEquipmentGroup.Location = new System.Drawing.Point(129, 3);
            this.txtEquipmentGroup.MaxLength = 40;
            this.txtEquipmentGroup.Name = "txtEquipmentGroup";
            this.txtEquipmentGroup.Size = new System.Drawing.Size(169, 26);
            this.txtEquipmentGroup.TabIndex = 1;
            this.txtEquipmentGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEquipmentGroup_KeyUp);
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(301, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 566);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvwAvailable);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(382, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(328, 560);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "availableList";
            this.groupBox3.Text = "availableList";
            // 
            // lvwAvailable
            // 
            this.lvwAvailable.allowUserFilter = true;
            this.lvwAvailable.allowUserSorting = true;
            this.lvwAvailable.autoSizeColumn = true;
            this.lvwAvailable.careModifyDate = false;
            this.lvwAvailable.columnHide = null;
            this.lvwAvailable.columnNames = new string[] {
        "name",
        "type",
        "issueState",
        "owner",
        "description",
        "fab",
        "line"};
            this.lvwAvailable.columnTags = new string[] {
        "Equipment",
        "EquipmentType",
        "issueState",
        "owner",
        "description",
        "fab",
        "eqLine"};
            this.lvwAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailable.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAvailable.FullRowSelect = true;
            this.lvwAvailable.GridLines = true;
            this.lvwAvailable.HideSelection = false;
            this.lvwAvailable.imageKeyColumn = "";
            this.lvwAvailable.keyPressSearch = false;
            this.lvwAvailable.keyPressSearchColumn = "";
            this.lvwAvailable.Location = new System.Drawing.Point(3, 19);
            this.lvwAvailable.makesureNewItemVisible = false;
            this.lvwAvailable.MultiSelect = false;
            this.lvwAvailable.Name = "lvwAvailable";
            this.lvwAvailable.OwnerDraw = true;
            this.lvwAvailable.ShowItemTipSecond = ((byte)(3));
            this.lvwAvailable.Size = new System.Drawing.Size(322, 538);
            this.lvwAvailable.TabIndex = 4;
            this.lvwAvailable.UseCompatibleStateImageBehavior = false;
            this.lvwAvailable.View = System.Windows.Forms.View.Details;
            this.lvwAvailable.DoubleClick += new System.EventHandler(this.lvwAvailable_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvwSelected);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 560);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "selectedList";
            this.groupBox1.Text = "selectedList";
            // 
            // lvwSelected
            // 
            this.lvwSelected.allowUserFilter = false;
            this.lvwSelected.allowUserSorting = true;
            this.lvwSelected.autoSizeColumn = true;
            this.lvwSelected.careModifyDate = false;
            this.lvwSelected.columnHide = null;
            this.lvwSelected.columnNames = new string[] {
        "name",
        "type",
        "issueState",
        "owner",
        "description",
        "fab",
        "line"};
            this.lvwSelected.columnTags = new string[] {
        "Equipment",
        "EquipmentType",
        "issueState",
        "owner",
        "description",
        "fab",
        "eqLine"};
            this.lvwSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelected.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSelected.FullRowSelect = true;
            this.lvwSelected.GridLines = true;
            this.lvwSelected.HideSelection = false;
            this.lvwSelected.imageKeyColumn = "";
            this.lvwSelected.keyPressSearch = false;
            this.lvwSelected.keyPressSearchColumn = "";
            this.lvwSelected.Location = new System.Drawing.Point(3, 22);
            this.lvwSelected.makesureNewItemVisible = false;
            this.lvwSelected.MultiSelect = false;
            this.lvwSelected.Name = "lvwSelected";
            this.lvwSelected.OwnerDraw = true;
            this.lvwSelected.ShowItemTipSecond = ((byte)(3));
            this.lvwSelected.Size = new System.Drawing.Size(322, 535);
            this.lvwSelected.TabIndex = 0;
            this.lvwSelected.UseCompatibleStateImageBehavior = false;
            this.lvwSelected.View = System.Windows.Forms.View.Details;
            this.lvwSelected.DoubleClick += new System.EventHandler(this.lvwSelected_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnUnSelect, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSelect, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(337, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(39, 560);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Enabled = false;
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ImageKey = "right.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(3, 283);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelect.TabIndex = 3;
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
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
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ImageKey = "left.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(3, 223);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmEquipmentGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1018, 566);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquipmentGroup";
            this.Tag = "EquipmentGroup";
            this.Text = "EquipmentGroup";
            this.Activated += new System.EventHandler(this.frmEquipmentGroup_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEquipmentGroup;
        private System.Windows.Forms.TextBox txtEquipmentGroup;
        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private idv.mesCore.Controls.MESListView lvwSelected;
        private System.Windows.Forms.GroupBox groupBox3;
        private idv.mesCore.Controls.MESListView lvwAvailable;
        private System.Windows.Forms.ImageList imageList1;
    }
}