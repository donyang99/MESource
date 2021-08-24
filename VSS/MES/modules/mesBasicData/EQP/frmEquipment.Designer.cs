namespace mesBasicData
{
    partial class frmEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipment));
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.cboFAB = new System.Windows.Forms.ComboBox();
            this.txtEqSeq = new System.Windows.Forms.TextBox();
            this.txtEqLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEqSeq = new System.Windows.Forms.Label();
            this.cboEqType = new System.Windows.Forms.ComboBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblEqType = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblEqLine = new System.Windows.Forms.Label();
            this.lblFAB = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpSubEq = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwAvailable = new idv.mesCore.Controls.MESListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwSelected = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.lblSpecRef = new System.Windows.Forms.Label();
            this.cboSpecRef = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.grpSubEq.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.actionToolbar1.Size = new System.Drawing.Size(1250, 25);
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
            this.groupBox1.Size = new System.Drawing.Size(1250, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editEquipment";
            this.groupBox1.Text = "editEquipment";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 95);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1244, 28);
            this.pnlExt.TabIndex = 6;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 10;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.Controls.Add(this.cboSpecRef, 7, 1);
            this.tblDetail.Controls.Add(this.lblSpecRef, 6, 1);
            this.tblDetail.Controls.Add(this.cboFAB, 5, 0);
            this.tblDetail.Controls.Add(this.txtEqSeq, 9, 0);
            this.tblDetail.Controls.Add(this.txtEqLine, 7, 0);
            this.tblDetail.Controls.Add(this.label4, 2, 1);
            this.tblDetail.Controls.Add(this.lblEqSeq, 8, 0);
            this.tblDetail.Controls.Add(this.cboEqType, 3, 0);
            this.tblDetail.Controls.Add(this.txtOwner, 1, 1);
            this.tblDetail.Controls.Add(this.lblEqType, 2, 0);
            this.tblDetail.Controls.Add(this.lblOwner, 0, 1);
            this.tblDetail.Controls.Add(this.lblEqLine, 6, 0);
            this.tblDetail.Controls.Add(this.lblFAB, 4, 0);
            this.tblDetail.Controls.Add(this.lblEquipment, 0, 0);
            this.tblDetail.Controls.Add(this.txtEquipment, 1, 0);
            this.tblDetail.Controls.Add(this.txtDescription, 3, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(3, 23);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(1244, 72);
            this.tblDetail.TabIndex = 0;
            // 
            // cboFAB
            // 
            this.cboFAB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFAB.BackColor = System.Drawing.SystemColors.Info;
            this.cboFAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFAB.FormattingEnabled = true;
            this.cboFAB.Location = new System.Drawing.Point(619, 6);
            this.cboFAB.Name = "cboFAB";
            this.cboFAB.Size = new System.Drawing.Size(108, 28);
            this.cboFAB.Sorted = true;
            this.cboFAB.TabIndex = 2;
            this.cboFAB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtEqSeq
            // 
            this.txtEqSeq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEqSeq.BackColor = System.Drawing.SystemColors.Window;
            this.txtEqSeq.Location = new System.Drawing.Point(973, 3);
            this.txtEqSeq.MaxLength = 2;
            this.txtEqSeq.Name = "txtEqSeq";
            this.txtEqSeq.Size = new System.Drawing.Size(45, 30);
            this.txtEqSeq.TabIndex = 4;
            this.txtEqSeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            this.txtEqSeq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtEqLine
            // 
            this.txtEqLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEqLine.BackColor = System.Drawing.SystemColors.Window;
            this.txtEqLine.Location = new System.Drawing.Point(818, 3);
            this.txtEqLine.MaxLength = 40;
            this.txtEqLine.Name = "txtEqLine";
            this.txtEqLine.Size = new System.Drawing.Size(84, 30);
            this.txtEqLine.TabIndex = 3;
            this.txtEqLine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(292, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 4;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEqSeq
            // 
            this.lblEqSeq.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEqSeq.AutoSize = true;
            this.lblEqSeq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqSeq.Location = new System.Drawing.Point(908, 8);
            this.lblEqSeq.Name = "lblEqSeq";
            this.lblEqSeq.Size = new System.Drawing.Size(59, 20);
            this.lblEqSeq.TabIndex = 9;
            this.lblEqSeq.Tag = "eqSeq";
            this.lblEqSeq.Text = "eqSeq";
            this.lblEqSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEqType
            // 
            this.cboEqType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEqType.BackColor = System.Drawing.SystemColors.Info;
            this.cboEqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEqType.FormattingEnabled = true;
            this.cboEqType.Location = new System.Drawing.Point(417, 6);
            this.cboEqType.Name = "cboEqType";
            this.cboEqType.Size = new System.Drawing.Size(149, 28);
            this.cboEqType.Sorted = true;
            this.cboEqType.TabIndex = 1;
            this.cboEqType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtOwner
            // 
            this.txtOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwner.BackColor = System.Drawing.SystemColors.Window;
            this.txtOwner.Location = new System.Drawing.Point(110, 39);
            this.txtOwner.MaxLength = 20;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(176, 30);
            this.txtOwner.TabIndex = 5;
            this.txtOwner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblEqType
            // 
            this.lblEqType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEqType.AutoSize = true;
            this.lblEqType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEqType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqType.Location = new System.Drawing.Point(320, 7);
            this.lblEqType.Name = "lblEqType";
            this.lblEqType.Size = new System.Drawing.Size(91, 22);
            this.lblEqType.TabIndex = 6;
            this.lblEqType.Tag = "EquipmentType";
            this.lblEqType.Text = "Eqp Type";
            this.lblEqType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOwner
            // 
            this.lblOwner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOwner.AutoSize = true;
            this.lblOwner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOwner.Location = new System.Drawing.Point(45, 44);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(59, 20);
            this.lblOwner.TabIndex = 6;
            this.lblOwner.Tag = "owner";
            this.lblOwner.Text = "owner";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEqLine
            // 
            this.lblEqLine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEqLine.AutoSize = true;
            this.lblEqLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqLine.Location = new System.Drawing.Point(743, 8);
            this.lblEqLine.Name = "lblEqLine";
            this.lblEqLine.Size = new System.Drawing.Size(69, 20);
            this.lblEqLine.TabIndex = 7;
            this.lblEqLine.Tag = "eqLine";
            this.lblEqLine.Text = "eqLine";
            this.lblEqLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFAB
            // 
            this.lblFAB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFAB.AutoSize = true;
            this.lblFAB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFAB.Location = new System.Drawing.Point(572, 7);
            this.lblFAB.Name = "lblFAB";
            this.lblFAB.Size = new System.Drawing.Size(41, 22);
            this.lblFAB.TabIndex = 6;
            this.lblFAB.Tag = "fab";
            this.lblFAB.Text = "fab";
            this.lblFAB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEquipment
            // 
            this.lblEquipment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEquipment.Location = new System.Drawing.Point(3, 7);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(101, 22);
            this.lblEquipment.TabIndex = 0;
            this.lblEquipment.Tag = "Equipment";
            this.lblEquipment.Text = "Equipment";
            this.lblEquipment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEquipment
            // 
            this.txtEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEquipment.BackColor = System.Drawing.SystemColors.Info;
            this.txtEquipment.Location = new System.Drawing.Point(110, 3);
            this.txtEquipment.MaxLength = 20;
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(176, 30);
            this.txtEquipment.TabIndex = 0;
            this.txtEquipment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Location = new System.Drawing.Point(417, 39);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(310, 30);
            this.txtDescription.TabIndex = 6;
            // 
            // grpSubEq
            // 
            this.grpSubEq.Controls.Add(this.tableLayoutPanel2);
            this.grpSubEq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpSubEq.ForeColor = System.Drawing.Color.Blue;
            this.grpSubEq.Location = new System.Drawing.Point(0, 417);
            this.grpSubEq.Name = "grpSubEq";
            this.grpSubEq.Size = new System.Drawing.Size(1250, 218);
            this.grpSubEq.TabIndex = 7;
            this.grpSubEq.TabStop = false;
            this.grpSubEq.Tag = "SubEq";
            this.grpSubEq.Text = "SubEq";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1244, 189);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvwAvailable);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(647, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(594, 183);
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
        "fab",
        "description"};
            this.lvwAvailable.columnTags = new string[] {
        "Equipment",
        "EquipmentType",
        "fab",
        "description"};
            this.lvwAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailable.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAvailable.FullRowSelect = true;
            this.lvwAvailable.GridLines = true;
            this.lvwAvailable.HideSelection = false;
            this.lvwAvailable.imageKeyColumn = "";
            this.lvwAvailable.keyPressSearch = false;
            this.lvwAvailable.keyPressSearchColumn = "";
            this.lvwAvailable.Location = new System.Drawing.Point(3, 23);
            this.lvwAvailable.makesureNewItemVisible = false;
            this.lvwAvailable.MultiSelect = false;
            this.lvwAvailable.Name = "lvwAvailable";
            this.lvwAvailable.OwnerDraw = true;
            this.lvwAvailable.ShowItemTipSecond = ((byte)(3));
            this.lvwAvailable.Size = new System.Drawing.Size(588, 157);
            this.lvwAvailable.TabIndex = 4;
            this.lvwAvailable.UseCompatibleStateImageBehavior = false;
            this.lvwAvailable.View = System.Windows.Forms.View.Details;
            this.lvwAvailable.DoubleClick += new System.EventHandler(this.lvwAvailable_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvwSelected);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 183);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "selectedList";
            this.groupBox2.Text = "selectedList";
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
        "fab",
        "description"};
            this.lvwSelected.columnTags = new string[] {
        "Equipment",
        "EquipmentType",
        "fab",
        "description"};
            this.lvwSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelected.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSelected.FullRowSelect = true;
            this.lvwSelected.GridLines = true;
            this.lvwSelected.HideSelection = false;
            this.lvwSelected.imageKeyColumn = "";
            this.lvwSelected.keyPressSearch = false;
            this.lvwSelected.keyPressSearchColumn = "";
            this.lvwSelected.Location = new System.Drawing.Point(3, 26);
            this.lvwSelected.makesureNewItemVisible = false;
            this.lvwSelected.MultiSelect = false;
            this.lvwSelected.Name = "lvwSelected";
            this.lvwSelected.OwnerDraw = true;
            this.lvwSelected.ShowItemTipSecond = ((byte)(3));
            this.lvwSelected.Size = new System.Drawing.Size(587, 154);
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
            this.tableLayoutPanel3.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(602, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(39, 183);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Enabled = false;
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnSelect.ImageKey = "right.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(3, 94);
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
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.ImageKey = "left.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(3, 34);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.ImageKey = "refresh.ico";
            this.btnRefresh.ImageList = this.imageList2;
            this.btnRefresh.Location = new System.Drawing.Point(12, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "refresh.ico");
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 410);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1250, 7);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
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
        "type",
        "issueState",
        "state",
        "owner",
        "description",
        "counter",
        "lotId",
        "recipe",
        "reservedBy",
        "fab",
        "line",
        "seq",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "Equipment",
        "EquipmentType",
        "issueState",
        "state",
        "owner",
        "description",
        "counterFlag",
        "lotId",
        "recipe",
        "specRef",
        "fab",
        "eqLine",
        "eqSeq",
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
            this.mesListView1.Location = new System.Drawing.Point(0, 151);
            this.mesListView1.makesureNewItemVisible = true;
            this.mesListView1.MultiSelect = false;
            this.mesListView1.Name = "mesListView1";
            this.mesListView1.OwnerDraw = true;
            this.mesListView1.ShowItemTipSecond = ((byte)(3));
            this.mesListView1.Size = new System.Drawing.Size(1250, 259);
            this.mesListView1.TabIndex = 10;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // lblSpecRef
            // 
            this.lblSpecRef.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSpecRef.AutoSize = true;
            this.lblSpecRef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpecRef.Location = new System.Drawing.Point(733, 44);
            this.lblSpecRef.Name = "lblSpecRef";
            this.lblSpecRef.Size = new System.Drawing.Size(79, 20);
            this.lblSpecRef.TabIndex = 11;
            this.lblSpecRef.Tag = "specRef";
            this.lblSpecRef.Text = "specRef";
            this.lblSpecRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSpecRef
            // 
            this.cboSpecRef.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboSpecRef.BackColor = System.Drawing.SystemColors.Info;
            this.tblDetail.SetColumnSpan(this.cboSpecRef, 3);
            this.cboSpecRef.FormattingEnabled = true;
            this.cboSpecRef.Location = new System.Drawing.Point(818, 40);
            this.cboSpecRef.Name = "cboSpecRef";
            this.cboSpecRef.Size = new System.Drawing.Size(280, 28);
            this.cboSpecRef.Sorted = true;
            this.cboSpecRef.TabIndex = 11;
            // 
            // frmEquipment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1250, 635);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grpSubEq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquipment";
            this.Tag = "Equipment";
            this.Text = "Equipment";
            this.Activated += new System.EventHandler(this.frmEquipment_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEquipment_FormClosed);
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.grpSubEq.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEqLine;
        private System.Windows.Forms.Label lblFAB;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.ComboBox cboEqType;
        private System.Windows.Forms.Label lblEqType;
        private System.Windows.Forms.TextBox txtEqLine;
        private System.Windows.Forms.TextBox txtEqSeq;
        private System.Windows.Forms.Label lblEqSeq;
        private System.Windows.Forms.ComboBox cboFAB;
        private System.Windows.Forms.GroupBox grpSubEq;
        private System.Windows.Forms.Splitter splitter1;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private idv.mesCore.Controls.MESListView lvwAvailable;
        private System.Windows.Forms.GroupBox groupBox2;
        private idv.mesCore.Controls.MESListView lvwSelected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.ComboBox cboSpecRef;
        private System.Windows.Forms.Label lblSpecRef;
    }
}