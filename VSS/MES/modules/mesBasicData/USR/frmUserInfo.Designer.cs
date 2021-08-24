namespace mesBasicData
{
    partial class frmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblWindowsAccount = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtWindowsAccount = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cboDivision = new System.Windows.Forms.ComboBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblFab = new System.Windows.Forms.Label();
            this.cboFab = new System.Windows.Forms.ComboBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwUsers = new idv.mesCore.Controls.MESListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwAvailable = new idv.mesCore.Controls.MESListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvwSelected = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvwUserGroup = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwSteps = new idv.mesCore.Controls.MESListView();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1031, 114);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editUserInfo";
            this.groupBox1.Text = "editUserInfo";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 83);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1025, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 11;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblDetail.Controls.Add(this.lblWindowsAccount, 0, 1);
            this.tblDetail.Controls.Add(this.txtPassword, 5, 0);
            this.tblDetail.Controls.Add(this.txtWindowsAccount, 1, 1);
            this.tblDetail.Controls.Add(this.lblPassword, 4, 0);
            this.tblDetail.Controls.Add(this.txtUserName, 3, 0);
            this.tblDetail.Controls.Add(this.lblUserId, 0, 0);
            this.tblDetail.Controls.Add(this.txtUserId, 1, 0);
            this.tblDetail.Controls.Add(this.lblUserName, 2, 0);
            this.tblDetail.Controls.Add(this.cboDivision, 9, 0);
            this.tblDetail.Controls.Add(this.lblDivision, 8, 0);
            this.tblDetail.Controls.Add(this.lblFab, 6, 0);
            this.tblDetail.Controls.Add(this.cboFab, 7, 0);
            this.tblDetail.Controls.Add(this.cboLanguage, 9, 1);
            this.tblDetail.Controls.Add(this.lblLanguage, 8, 1);
            this.tblDetail.Controls.Add(this.txtEmail, 5, 1);
            this.tblDetail.Controls.Add(this.lblEmail, 4, 1);
            this.tblDetail.Controls.Add(this.txtMobile, 3, 1);
            this.tblDetail.Controls.Add(this.lblMobile, 2, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(1025, 64);
            this.tblDetail.TabIndex = 0;
            // 
            // lblWindowsAccount
            // 
            this.lblWindowsAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWindowsAccount.AutoSize = true;
            this.lblWindowsAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWindowsAccount.Location = new System.Drawing.Point(3, 40);
            this.lblWindowsAccount.Name = "lblWindowsAccount";
            this.lblWindowsAccount.Size = new System.Drawing.Size(120, 16);
            this.lblWindowsAccount.TabIndex = 11;
            this.lblWindowsAccount.Tag = "windowsAccount";
            this.lblWindowsAccount.Text = "windowsAccount";
            this.lblWindowsAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.Location = new System.Drawing.Point(593, 3);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtWindowsAccount
            // 
            this.txtWindowsAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWindowsAccount.BackColor = System.Drawing.SystemColors.Window;
            this.txtWindowsAccount.Location = new System.Drawing.Point(129, 35);
            this.txtWindowsAccount.MaxLength = 30;
            this.txtWindowsAccount.Name = "txtWindowsAccount";
            this.txtWindowsAccount.Size = new System.Drawing.Size(166, 26);
            this.txtWindowsAccount.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(515, 8);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Tag = "password";
            this.lblPassword.Text = "password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.Location = new System.Drawing.Point(379, 3);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(130, 26);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserId.AutoSize = true;
            this.lblUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserId.Location = new System.Drawing.Point(65, 7);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(58, 18);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Tag = "userId";
            this.lblUserId.Text = "userId";
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserId.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserId.Location = new System.Drawing.Point(129, 3);
            this.txtUserId.MaxLength = 10;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(166, 26);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserName.Location = new System.Drawing.Point(301, 8);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 16);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Tag = "userName";
            this.lblUserName.Text = "userName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDivision
            // 
            this.cboDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDivision.BackColor = System.Drawing.SystemColors.Info;
            this.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.Location = new System.Drawing.Point(955, 6);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.Size = new System.Drawing.Size(74, 24);
            this.cboDivision.Sorted = true;
            this.cboDivision.TabIndex = 3;
            this.cboDivision.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblDivision
            // 
            this.lblDivision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDivision.AutoSize = true;
            this.lblDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDivision.Location = new System.Drawing.Point(875, 7);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(74, 18);
            this.lblDivision.TabIndex = 9;
            this.lblDivision.Tag = "division";
            this.lblDivision.Text = "division";
            this.lblDivision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFab
            // 
            this.lblFab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFab.AutoSize = true;
            this.lblFab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFab.Location = new System.Drawing.Point(742, 7);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(34, 18);
            this.lblFab.TabIndex = 12;
            this.lblFab.Tag = "fab";
            this.lblFab.Text = "fab";
            this.lblFab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFab
            // 
            this.cboFab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFab.BackColor = System.Drawing.SystemColors.Window;
            this.cboFab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFab.DropDownWidth = 77;
            this.cboFab.FormattingEnabled = true;
            this.cboFab.Location = new System.Drawing.Point(782, 4);
            this.cboFab.Name = "cboFab";
            this.cboFab.Size = new System.Drawing.Size(87, 24);
            this.cboFab.Sorted = true;
            this.cboFab.TabIndex = 13;
            // 
            // cboLanguage
            // 
            this.cboLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(955, 38);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(74, 24);
            this.cboLanguage.Sorted = true;
            this.cboLanguage.TabIndex = 6;
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLanguage.Location = new System.Drawing.Point(877, 40);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(72, 16);
            this.lblLanguage.TabIndex = 9;
            this.lblLanguage.Tag = "language";
            this.lblLanguage.Text = "language";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtEmail, 3);
            this.txtEmail.Location = new System.Drawing.Point(593, 35);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(539, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Tag = "email";
            this.lblEmail.Text = "email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.BackColor = System.Drawing.SystemColors.Window;
            this.txtMobile.Location = new System.Drawing.Point(379, 35);
            this.txtMobile.MaxLength = 15;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(130, 26);
            this.txtMobile.TabIndex = 4;
            this.txtMobile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMobile.AutoSize = true;
            this.lblMobile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMobile.Location = new System.Drawing.Point(317, 40);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(56, 16);
            this.lblMobile.TabIndex = 9;
            this.lblMobile.Tag = "mobile";
            this.lblMobile.Text = "mobile";
            this.lblMobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 139);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 322);
            this.splitContainer1.SplitterDistance = 710;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwUsers);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(710, 322);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 9;
            // 
            // lvwUsers
            // 
            this.lvwUsers.allowUserFilter = false;
            this.lvwUsers.allowUserSorting = true;
            this.lvwUsers.autoSizeColumn = true;
            this.lvwUsers.careModifyDate = false;
            this.lvwUsers.columnHide = null;
            this.lvwUsers.columnNames = new string[] {
        "name",
        "windowsAccount",
        "nickName",
        "fab",
        "division",
        "mobile",
        "language",
        "email"};
            this.lvwUsers.columnTags = new string[] {
        "userId",
        "windowsAccount",
        "userName",
        "fab",
        "division",
        "mobile",
        "language",
        "email"};
            this.lvwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwUsers.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwUsers.FullRowSelect = true;
            this.lvwUsers.GridLines = true;
            this.lvwUsers.HideSelection = false;
            this.lvwUsers.imageKeyColumn = "";
            this.lvwUsers.keyPressSearch = false;
            this.lvwUsers.keyPressSearchColumn = "";
            this.lvwUsers.Location = new System.Drawing.Point(0, 0);
            this.lvwUsers.makesureNewItemVisible = true;
            this.lvwUsers.MultiSelect = false;
            this.lvwUsers.Name = "lvwUsers";
            this.lvwUsers.OwnerDraw = true;
            this.lvwUsers.ShowItemTipSecond = ((byte)(3));
            this.lvwUsers.Size = new System.Drawing.Size(710, 170);
            this.lvwUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwUsers.TabIndex = 8;
            this.lvwUsers.UseCompatibleStateImageBehavior = false;
            this.lvwUsers.View = System.Windows.Forms.View.Details;
            this.lvwUsers.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwUsers_MESItemSelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(710, 148);
            this.groupBox3.TabIndex = 1;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(704, 123);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lvwAvailable);
            this.groupBox4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(377, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(324, 117);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "availableList";
            this.groupBox4.Text = "availableList";
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
        "description"};
            this.lvwAvailable.columnTags = new string[] {
        "accessString",
        "description"};
            this.lvwAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailable.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.lvwAvailable.Size = new System.Drawing.Size(318, 95);
            this.lvwAvailable.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwAvailable.TabIndex = 4;
            this.lvwAvailable.UseCompatibleStateImageBehavior = false;
            this.lvwAvailable.View = System.Windows.Forms.View.Details;
            this.lvwAvailable.DoubleClick += new System.EventHandler(this.lvwAvailable_DoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lvwSelected);
            this.groupBox5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 117);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Tag = "selectedList";
            this.groupBox5.Text = "selectedList";
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
        "description"};
            this.lvwSelected.columnTags = new string[] {
        "accessString",
        "description"};
            this.lvwSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelected.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.lvwSelected.Size = new System.Drawing.Size(317, 92);
            this.lvwSelected.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(332, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(39, 117);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnSelect.ImageKey = "right.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(3, 62);
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
            this.imageList1.Images.SetKeyName(0, "left.ico");
            this.imageList1.Images.SetKeyName(1, "right.ico");
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.ImageKey = "left.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(317, 322);
            this.splitContainer3.SplitterDistance = 163;
            this.splitContainer3.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lvwUserGroup);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.Blue;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 322);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Tag = "UserGroup";
            this.groupBox6.Text = "UserGroup";
            // 
            // lvwUserGroup
            // 
            this.lvwUserGroup.CheckBoxes = true;
            this.lvwUserGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwUserGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwUserGroup.FullRowSelect = true;
            this.lvwUserGroup.GridLines = true;
            this.lvwUserGroup.Location = new System.Drawing.Point(3, 22);
            this.lvwUserGroup.MultiSelect = false;
            this.lvwUserGroup.Name = "lvwUserGroup";
            this.lvwUserGroup.Size = new System.Drawing.Size(157, 297);
            this.lvwUserGroup.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwUserGroup.TabIndex = 0;
            this.lvwUserGroup.UseCompatibleStateImageBehavior = false;
            this.lvwUserGroup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "UserGroup";
            this.columnHeader1.Text = "UserGroup";
            this.columnHeader1.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwSteps);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 322);
            this.groupBox2.TabIndex = 0;
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
            this.lvwSteps.Size = new System.Drawing.Size(144, 297);
            this.lvwSteps.TabIndex = 0;
            this.lvwSteps.UseCompatibleStateImageBehavior = false;
            this.lvwSteps.View = System.Windows.Forms.View.Details;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(1031, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmUserInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1031, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserInfo";
            this.Tag = "UserInfo";
            this.Text = "UserInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmUserInfo_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUserInfo_FormClosed);
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.ComboBox cboDivision;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private idv.mesCore.Controls.MESListView lvwUsers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private idv.mesCore.Controls.MESListView lvwSteps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private idv.mesCore.Controls.MESListView lvwAvailable;
        private System.Windows.Forms.GroupBox groupBox5;
        private idv.mesCore.Controls.MESListView lvwSelected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.ComboBox cboFab;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView lvwUserGroup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblWindowsAccount;
        private System.Windows.Forms.TextBox txtWindowsAccount;
        private System.Windows.Forms.Panel pnlExt;
    }
}