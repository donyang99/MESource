namespace mesBasicData
{
    partial class frmUserGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserGroup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserGroup = new System.Windows.Forms.Label();
            this.txtUserGroup = new System.Windows.Forms.TextBox();
            this.lvwGroups = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwSteps = new idv.mesCore.Controls.MESListView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lvwAvailableUser = new idv.mesCore.Controls.MESListView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lvwSelectedUser = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelectUser = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwAvailablePrivilege = new idv.mesCore.Controls.MESListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvwSelectedPrivilege = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelectPrivilege = new System.Windows.Forms.Button();
            this.btnSelectPrivilege = new System.Windows.Forms.Button();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(968, 54);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editUserGroup";
            this.groupBox1.Text = "editUserGroup";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblUserGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserGroup, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUserGroup
            // 
            this.lblUserGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserGroup.AutoSize = true;
            this.lblUserGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserGroup.Location = new System.Drawing.Point(3, 8);
            this.lblUserGroup.Name = "lblUserGroup";
            this.lblUserGroup.Size = new System.Drawing.Size(80, 16);
            this.lblUserGroup.TabIndex = 0;
            this.lblUserGroup.Tag = "userGroup";
            this.lblUserGroup.Text = "userGroup";
            this.lblUserGroup.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUserGroup
            // 
            this.txtUserGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUserGroup.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserGroup.Location = new System.Drawing.Point(89, 3);
            this.txtUserGroup.MaxLength = 20;
            this.txtUserGroup.Name = "txtUserGroup";
            this.txtUserGroup.Size = new System.Drawing.Size(197, 26);
            this.txtUserGroup.TabIndex = 0;
            // 
            // lvwGroups
            // 
            this.lvwGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvwGroups.FullRowSelect = true;
            this.lvwGroups.GridLines = true;
            this.lvwGroups.HideSelection = false;
            this.lvwGroups.Location = new System.Drawing.Point(0, 79);
            this.lvwGroups.MultiSelect = false;
            this.lvwGroups.Name = "lvwGroups";
            this.lvwGroups.Size = new System.Drawing.Size(151, 532);
            this.lvwGroups.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwGroups.TabIndex = 9;
            this.lvwGroups.UseCompatibleStateImageBehavior = false;
            this.lvwGroups.View = System.Windows.Forms.View.Details;
            this.lvwGroups.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwGroups_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "userGroup";
            this.columnHeader1.Text = "userGroup";
            this.columnHeader1.Width = 143;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(151, 79);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 532);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwSteps);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(773, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 532);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "step";
            this.groupBox2.Text = "step";
            // 
            // lvwSteps
            // 
            this.lvwSteps.allowUserFilter = false;
            this.lvwSteps.allowUserSorting = true;
            this.lvwSteps.autoSizeColumn = true;
            this.lvwSteps.careModifyDate = false;
            this.lvwSteps.CheckBoxes = true;
            this.lvwSteps.columnHide = null;
            this.lvwSteps.columnNames = new string[] {
        "name",
        "fab",
        "description"};
            this.lvwSteps.columnTags = new string[] {
        "Step",
        "fab",
        "description"};
            this.lvwSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSteps.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSteps.FullRowSelect = true;
            this.lvwSteps.GridLines = true;
            this.lvwSteps.HideSelection = false;
            this.lvwSteps.imageKeyColumn = "";
            this.lvwSteps.keyPressSearch = false;
            this.lvwSteps.keyPressSearchColumn = "";
            this.lvwSteps.Location = new System.Drawing.Point(3, 22);
            this.lvwSteps.makesureNewItemVisible = true;
            this.lvwSteps.MultiSelect = false;
            this.lvwSteps.Name = "lvwSteps";
            this.lvwSteps.OwnerDraw = true;
            this.lvwSteps.ShowItemTipSecond = ((byte)(3));
            this.lvwSteps.Size = new System.Drawing.Size(189, 507);
            this.lvwSteps.TabIndex = 0;
            this.lvwSteps.UseCompatibleStateImageBehavior = false;
            this.lvwSteps.View = System.Windows.Forms.View.Details;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(770, 79);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 532);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(154, 79);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(616, 532);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel4);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(616, 247);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Tag = "userInfo";
            this.groupBox6.Text = "userInfo";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox7, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(610, 222);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lvwAvailableUser);
            this.groupBox7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.ForeColor = System.Drawing.Color.Blue;
            this.groupBox7.Location = new System.Drawing.Point(330, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox7.Size = new System.Drawing.Size(277, 216);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Tag = "availableList";
            this.groupBox7.Text = "availableList";
            // 
            // lvwAvailableUser
            // 
            this.lvwAvailableUser.allowUserFilter = true;
            this.lvwAvailableUser.allowUserSorting = true;
            this.lvwAvailableUser.autoSizeColumn = true;
            this.lvwAvailableUser.careModifyDate = false;
            this.lvwAvailableUser.columnHide = null;
            this.lvwAvailableUser.columnNames = new string[] {
        "name",
        "nickName",
        "fab",
        "division"};
            this.lvwAvailableUser.columnTags = new string[] {
        "userId",
        "userName",
        "fab",
        "division"};
            this.lvwAvailableUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailableUser.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAvailableUser.FullRowSelect = true;
            this.lvwAvailableUser.GridLines = true;
            this.lvwAvailableUser.HideSelection = false;
            this.lvwAvailableUser.imageKeyColumn = "";
            this.lvwAvailableUser.keyPressSearch = false;
            this.lvwAvailableUser.keyPressSearchColumn = "";
            this.lvwAvailableUser.Location = new System.Drawing.Point(3, 19);
            this.lvwAvailableUser.makesureNewItemVisible = false;
            this.lvwAvailableUser.MultiSelect = false;
            this.lvwAvailableUser.Name = "lvwAvailableUser";
            this.lvwAvailableUser.OwnerDraw = true;
            this.lvwAvailableUser.ShowItemTipSecond = ((byte)(3));
            this.lvwAvailableUser.Size = new System.Drawing.Size(271, 194);
            this.lvwAvailableUser.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwAvailableUser.TabIndex = 10;
            this.lvwAvailableUser.UseCompatibleStateImageBehavior = false;
            this.lvwAvailableUser.View = System.Windows.Forms.View.Details;
            this.lvwAvailableUser.DoubleClick += new System.EventHandler(this.lvwAvailableUser_DoubleClick);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.lvwSelectedUser);
            this.groupBox8.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.ForeColor = System.Drawing.Color.Blue;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(276, 216);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Tag = "selectedList";
            this.groupBox8.Text = "selectedList";
            // 
            // lvwSelectedUser
            // 
            this.lvwSelectedUser.allowUserFilter = false;
            this.lvwSelectedUser.allowUserSorting = true;
            this.lvwSelectedUser.autoSizeColumn = true;
            this.lvwSelectedUser.careModifyDate = false;
            this.lvwSelectedUser.columnHide = null;
            this.lvwSelectedUser.columnNames = new string[] {
        "name",
        "nickName",
        "fab",
        "division"};
            this.lvwSelectedUser.columnTags = new string[] {
        "userId",
        "userName",
        "fab",
        "division"};
            this.lvwSelectedUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelectedUser.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSelectedUser.FullRowSelect = true;
            this.lvwSelectedUser.GridLines = true;
            this.lvwSelectedUser.HideSelection = false;
            this.lvwSelectedUser.imageKeyColumn = "";
            this.lvwSelectedUser.keyPressSearch = false;
            this.lvwSelectedUser.keyPressSearchColumn = "";
            this.lvwSelectedUser.Location = new System.Drawing.Point(3, 22);
            this.lvwSelectedUser.makesureNewItemVisible = false;
            this.lvwSelectedUser.MultiSelect = false;
            this.lvwSelectedUser.Name = "lvwSelectedUser";
            this.lvwSelectedUser.OwnerDraw = true;
            this.lvwSelectedUser.ShowItemTipSecond = ((byte)(3));
            this.lvwSelectedUser.Size = new System.Drawing.Size(270, 191);
            this.lvwSelectedUser.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwSelectedUser.TabIndex = 9;
            this.lvwSelectedUser.UseCompatibleStateImageBehavior = false;
            this.lvwSelectedUser.View = System.Windows.Forms.View.Details;
            this.lvwSelectedUser.DoubleClick += new System.EventHandler(this.lvwSelectedUser_DoubleClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnUnSelectUser, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnSelectUser, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(285, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(39, 216);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnUnSelectUser
            // 
            this.btnUnSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelectUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnSelectUser.ImageKey = "right.ico";
            this.btnUnSelectUser.ImageList = this.imageList1;
            this.btnUnSelectUser.Location = new System.Drawing.Point(3, 111);
            this.btnUnSelectUser.Name = "btnUnSelectUser";
            this.btnUnSelectUser.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelectUser.TabIndex = 3;
            this.btnUnSelectUser.UseVisualStyleBackColor = true;
            this.btnUnSelectUser.Click += new System.EventHandler(this.btnUnSelectUser_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "left.ico");
            this.imageList1.Images.SetKeyName(1, "right.ico");
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelectUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectUser.ImageKey = "left.ico";
            this.btnSelectUser.ImageList = this.imageList1;
            this.btnSelectUser.Location = new System.Drawing.Point(3, 51);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(33, 52);
            this.btnSelectUser.TabIndex = 4;
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 281);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "AccessString";
            this.groupBox3.Text = "AccessString";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(610, 256);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lvwAvailablePrivilege);
            this.groupBox4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(330, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(277, 250);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "availableList";
            this.groupBox4.Text = "availableList";
            // 
            // lvwAvailablePrivilege
            // 
            this.lvwAvailablePrivilege.allowUserFilter = true;
            this.lvwAvailablePrivilege.allowUserSorting = true;
            this.lvwAvailablePrivilege.autoSizeColumn = true;
            this.lvwAvailablePrivilege.careModifyDate = false;
            this.lvwAvailablePrivilege.columnHide = null;
            this.lvwAvailablePrivilege.columnNames = new string[] {
        "name",
        "description"};
            this.lvwAvailablePrivilege.columnTags = new string[] {
        "accessString",
        "description"};
            this.lvwAvailablePrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailablePrivilege.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAvailablePrivilege.FullRowSelect = true;
            this.lvwAvailablePrivilege.GridLines = true;
            this.lvwAvailablePrivilege.HideSelection = false;
            this.lvwAvailablePrivilege.imageKeyColumn = "";
            this.lvwAvailablePrivilege.keyPressSearch = false;
            this.lvwAvailablePrivilege.keyPressSearchColumn = "";
            this.lvwAvailablePrivilege.Location = new System.Drawing.Point(3, 19);
            this.lvwAvailablePrivilege.makesureNewItemVisible = false;
            this.lvwAvailablePrivilege.MultiSelect = false;
            this.lvwAvailablePrivilege.Name = "lvwAvailablePrivilege";
            this.lvwAvailablePrivilege.OwnerDraw = true;
            this.lvwAvailablePrivilege.ShowItemTipSecond = ((byte)(3));
            this.lvwAvailablePrivilege.Size = new System.Drawing.Size(271, 228);
            this.lvwAvailablePrivilege.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwAvailablePrivilege.TabIndex = 4;
            this.lvwAvailablePrivilege.UseCompatibleStateImageBehavior = false;
            this.lvwAvailablePrivilege.View = System.Windows.Forms.View.Details;
            this.lvwAvailablePrivilege.DoubleClick += new System.EventHandler(this.lvwAvailablePrivilege_DoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lvwSelectedPrivilege);
            this.groupBox5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 250);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Tag = "selectedList";
            this.groupBox5.Text = "selectedList";
            // 
            // lvwSelectedPrivilege
            // 
            this.lvwSelectedPrivilege.allowUserFilter = false;
            this.lvwSelectedPrivilege.allowUserSorting = true;
            this.lvwSelectedPrivilege.autoSizeColumn = true;
            this.lvwSelectedPrivilege.careModifyDate = false;
            this.lvwSelectedPrivilege.columnHide = null;
            this.lvwSelectedPrivilege.columnNames = new string[] {
        "name",
        "description"};
            this.lvwSelectedPrivilege.columnTags = new string[] {
        "accessString",
        "description"};
            this.lvwSelectedPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelectedPrivilege.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSelectedPrivilege.FullRowSelect = true;
            this.lvwSelectedPrivilege.GridLines = true;
            this.lvwSelectedPrivilege.HideSelection = false;
            this.lvwSelectedPrivilege.imageKeyColumn = "";
            this.lvwSelectedPrivilege.keyPressSearch = false;
            this.lvwSelectedPrivilege.keyPressSearchColumn = "";
            this.lvwSelectedPrivilege.Location = new System.Drawing.Point(3, 22);
            this.lvwSelectedPrivilege.makesureNewItemVisible = false;
            this.lvwSelectedPrivilege.MultiSelect = false;
            this.lvwSelectedPrivilege.Name = "lvwSelectedPrivilege";
            this.lvwSelectedPrivilege.OwnerDraw = true;
            this.lvwSelectedPrivilege.ShowItemTipSecond = ((byte)(3));
            this.lvwSelectedPrivilege.Size = new System.Drawing.Size(270, 225);
            this.lvwSelectedPrivilege.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwSelectedPrivilege.TabIndex = 0;
            this.lvwSelectedPrivilege.UseCompatibleStateImageBehavior = false;
            this.lvwSelectedPrivilege.View = System.Windows.Forms.View.Details;
            this.lvwSelectedPrivilege.DoubleClick += new System.EventHandler(this.lvwSelectedPrivilege_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnUnSelectPrivilege, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectPrivilege, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(285, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(39, 250);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnUnSelectPrivilege
            // 
            this.btnUnSelectPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelectPrivilege.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnSelectPrivilege.ImageKey = "right.ico";
            this.btnUnSelectPrivilege.ImageList = this.imageList1;
            this.btnUnSelectPrivilege.Location = new System.Drawing.Point(3, 128);
            this.btnUnSelectPrivilege.Name = "btnUnSelectPrivilege";
            this.btnUnSelectPrivilege.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelectPrivilege.TabIndex = 3;
            this.btnUnSelectPrivilege.UseVisualStyleBackColor = true;
            this.btnUnSelectPrivilege.Click += new System.EventHandler(this.btnUnSelectPrivilege_Click);
            // 
            // btnSelectPrivilege
            // 
            this.btnSelectPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelectPrivilege.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectPrivilege.ImageKey = "left.ico";
            this.btnSelectPrivilege.ImageList = this.imageList1;
            this.btnSelectPrivilege.Location = new System.Drawing.Point(3, 68);
            this.btnSelectPrivilege.Name = "btnSelectPrivilege";
            this.btnSelectPrivilege.Size = new System.Drawing.Size(33, 52);
            this.btnSelectPrivilege.TabIndex = 4;
            this.btnSelectPrivilege.UseVisualStyleBackColor = true;
            this.btnSelectPrivilege.Click += new System.EventHandler(this.btnSelectPrivilege_Click);
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(968, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmUserGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(968, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lvwGroups);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserGroup";
            this.Tag = "UserGroup";
            this.Text = "UserGroup";
            this.Activated += new System.EventHandler(this.frmUserGroup_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUserGroup;
        private System.Windows.Forms.TextBox txtUserGroup;
        private System.Windows.Forms.ListView lvwGroups;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private idv.mesCore.Controls.MESListView lvwSteps;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private idv.mesCore.Controls.MESListView lvwAvailablePrivilege;
        private System.Windows.Forms.GroupBox groupBox5;
        private idv.mesCore.Controls.MESListView lvwSelectedPrivilege;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUnSelectPrivilege;
        private System.Windows.Forms.Button btnSelectPrivilege;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnUnSelectUser;
        private System.Windows.Forms.Button btnSelectUser;
        private idv.mesCore.Controls.MESListView lvwAvailableUser;
        private idv.mesCore.Controls.MESListView lvwSelectedUser;
        private System.Windows.Forms.ImageList imageList1;
    }
}