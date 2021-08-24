namespace mesBasicData
{
    partial class frmStep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStep));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtDisplaySeq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFAB = new System.Windows.Forms.Label();
            this.cboEqGroup = new System.Windows.Forms.ComboBox();
            this.cboFAB = new System.Windows.Forms.ComboBox();
            this.lblEqGroup = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblComponentType = new System.Windows.Forms.Label();
            this.cboComponentType = new System.Windows.Forms.ComboBox();
            this.lblStepCode = new System.Windows.Forms.Label();
            this.cboStepCode = new System.Windows.Forms.ComboBox();
            this.cboStage = new System.Windows.Forms.ComboBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDown = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwAvailable = new idv.mesCore.Controls.MESListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwSelected = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.mnuVersion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mesListView1 = new idv.mesCore.Controls.MESListView();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.lvwStation = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtStation = new System.Windows.Forms.TextBox();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.grpStation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpStation.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pnlExt);
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1055, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editStep";
            this.groupBox1.Text = "editStep";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(3, 83);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(1049, 28);
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
            this.tblDetail.Controls.Add(this.txtDisplaySeq, 1, 1);
            this.tblDetail.Controls.Add(this.label1, 0, 1);
            this.tblDetail.Controls.Add(this.lblFAB, 6, 0);
            this.tblDetail.Controls.Add(this.cboEqGroup, 5, 0);
            this.tblDetail.Controls.Add(this.cboFAB, 7, 0);
            this.tblDetail.Controls.Add(this.lblEqGroup, 4, 0);
            this.tblDetail.Controls.Add(this.lblStep, 0, 0);
            this.tblDetail.Controls.Add(this.txtStep, 1, 0);
            this.tblDetail.Controls.Add(this.lblVersion, 2, 0);
            this.tblDetail.Controls.Add(this.txtVersion, 3, 0);
            this.tblDetail.Controls.Add(this.lblComponentType, 8, 1);
            this.tblDetail.Controls.Add(this.cboComponentType, 9, 1);
            this.tblDetail.Controls.Add(this.lblStepCode, 8, 0);
            this.tblDetail.Controls.Add(this.cboStepCode, 9, 0);
            this.tblDetail.Controls.Add(this.cboStage, 7, 1);
            this.tblDetail.Controls.Add(this.lblStage, 6, 1);
            this.tblDetail.Controls.Add(this.txtDescription, 3, 1);
            this.tblDetail.Controls.Add(this.label4, 2, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tblDetail.Location = new System.Drawing.Point(3, 19);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(1049, 64);
            this.tblDetail.TabIndex = 0;
            // 
            // txtDisplaySeq
            // 
            this.txtDisplaySeq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDisplaySeq.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisplaySeq.Location = new System.Drawing.Point(97, 35);
            this.txtDisplaySeq.MaxLength = 4;
            this.txtDisplaySeq.Name = "txtDisplaySeq";
            this.txtDisplaySeq.Size = new System.Drawing.Size(74, 26);
            this.txtDisplaySeq.TabIndex = 4;
            this.txtDisplaySeq.TabStop = false;
            this.txtDisplaySeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Tag = "displaySeq";
            this.label1.Text = "displaySeq";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFAB
            // 
            this.lblFAB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFAB.AutoSize = true;
            this.lblFAB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFAB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFAB.Location = new System.Drawing.Point(661, 7);
            this.lblFAB.Name = "lblFAB";
            this.lblFAB.Size = new System.Drawing.Size(34, 18);
            this.lblFAB.TabIndex = 9;
            this.lblFAB.Tag = "fab";
            this.lblFAB.Text = "fab";
            this.lblFAB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEqGroup
            // 
            this.cboEqGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEqGroup.BackColor = System.Drawing.SystemColors.Info;
            this.cboEqGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEqGroup.FormattingEnabled = true;
            this.cboEqGroup.Location = new System.Drawing.Point(478, 6);
            this.cboEqGroup.MaxDropDownItems = 20;
            this.cboEqGroup.Name = "cboEqGroup";
            this.cboEqGroup.Size = new System.Drawing.Size(161, 24);
            this.cboEqGroup.Sorted = true;
            this.cboEqGroup.TabIndex = 1;
            this.cboEqGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // cboFAB
            // 
            this.cboFAB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboFAB.BackColor = System.Drawing.SystemColors.Info;
            this.cboFAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFAB.FormattingEnabled = true;
            this.cboFAB.Location = new System.Drawing.Point(701, 6);
            this.cboFAB.Name = "cboFAB";
            this.cboFAB.Size = new System.Drawing.Size(114, 24);
            this.cboFAB.Sorted = true;
            this.cboFAB.TabIndex = 2;
            this.cboFAB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblEqGroup
            // 
            this.lblEqGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEqGroup.AutoSize = true;
            this.lblEqGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEqGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEqGroup.Location = new System.Drawing.Point(406, 7);
            this.lblEqGroup.Name = "lblEqGroup";
            this.lblEqGroup.Size = new System.Drawing.Size(66, 18);
            this.lblEqGroup.TabIndex = 9;
            this.lblEqGroup.Tag = "EquipmentGroup";
            this.lblEqGroup.Text = "eqGroup";
            this.lblEqGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStep
            // 
            this.lblStep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStep.AutoSize = true;
            this.lblStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStep.Location = new System.Drawing.Point(49, 7);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(42, 18);
            this.lblStep.TabIndex = 0;
            this.lblStep.Tag = "Step";
            this.lblStep.Text = "Step";
            this.lblStep.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStep
            // 
            this.txtStep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStep.BackColor = System.Drawing.SystemColors.Info;
            this.txtStep.Location = new System.Drawing.Point(97, 3);
            this.txtStep.MaxLength = 40;
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(157, 26);
            this.txtStep.TabIndex = 0;
            this.txtStep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVersion.Location = new System.Drawing.Point(292, 8);
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
            this.txtVersion.Location = new System.Drawing.Point(362, 3);
            this.txtVersion.MaxLength = 40;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(38, 26);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.TabStop = false;
            // 
            // lblComponentType
            // 
            this.lblComponentType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblComponentType.AutoSize = true;
            this.lblComponentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComponentType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComponentType.Location = new System.Drawing.Point(821, 39);
            this.lblComponentType.Name = "lblComponentType";
            this.lblComponentType.Size = new System.Drawing.Size(82, 18);
            this.lblComponentType.TabIndex = 6;
            this.lblComponentType.Tag = "ComponentType";
            this.lblComponentType.Text = "Comp Type";
            this.lblComponentType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboComponentType
            // 
            this.cboComponentType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboComponentType.BackColor = System.Drawing.SystemColors.Window;
            this.cboComponentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComponentType.FormattingEnabled = true;
            this.cboComponentType.Location = new System.Drawing.Point(909, 38);
            this.cboComponentType.Name = "cboComponentType";
            this.cboComponentType.Size = new System.Drawing.Size(124, 24);
            this.cboComponentType.Sorted = true;
            this.cboComponentType.TabIndex = 7;
            this.cboComponentType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblStepCode
            // 
            this.lblStepCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStepCode.AutoSize = true;
            this.lblStepCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStepCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStepCode.Location = new System.Drawing.Point(829, 7);
            this.lblStepCode.Name = "lblStepCode";
            this.lblStepCode.Size = new System.Drawing.Size(74, 18);
            this.lblStepCode.TabIndex = 9;
            this.lblStepCode.Tag = "stepCode";
            this.lblStepCode.Text = "stepCode";
            this.lblStepCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStepCode
            // 
            this.cboStepCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStepCode.BackColor = System.Drawing.SystemColors.Window;
            this.cboStepCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStepCode.FormattingEnabled = true;
            this.cboStepCode.Location = new System.Drawing.Point(909, 6);
            this.cboStepCode.Name = "cboStepCode";
            this.cboStepCode.Size = new System.Drawing.Size(124, 24);
            this.cboStepCode.Sorted = true;
            this.cboStepCode.TabIndex = 3;
            this.cboStepCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // cboStage
            // 
            this.cboStage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStage.BackColor = System.Drawing.SystemColors.Info;
            this.cboStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStage.FormattingEnabled = true;
            this.cboStage.Location = new System.Drawing.Point(701, 38);
            this.cboStage.Name = "cboStage";
            this.cboStage.Size = new System.Drawing.Size(114, 24);
            this.cboStage.Sorted = true;
            this.cboStage.TabIndex = 6;
            this.cboStage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // lblStage
            // 
            this.lblStage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStage.AutoSize = true;
            this.lblStage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStage.Location = new System.Drawing.Point(645, 39);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(50, 18);
            this.lblStage.TabIndex = 6;
            this.lblStage.Tag = "stage";
            this.lblStage.Text = "stage";
            this.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Location = new System.Drawing.Point(362, 35);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 26);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandlerSendKeyTab);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(260, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 4;
            this.label4.Tag = "description";
            this.label4.Text = "description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 472);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1055, 7);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 479);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(824, 189);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnDown, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnUp, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(374, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(30, 189);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDown.ImageKey = "down.ico";
            this.btnDown.ImageList = this.imageList1;
            this.btnDown.Location = new System.Drawing.Point(3, 97);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 34);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
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
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUp.ImageKey = "up.ico";
            this.btnUp.ImageList = this.imageList1;
            this.btnUp.Location = new System.Drawing.Point(3, 57);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 34);
            this.btnUp.TabIndex = 4;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lvwAvailable);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(452, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Size = new System.Drawing.Size(369, 183);
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
        "dispatchFlag",
        "description"};
            this.lvwAvailable.columnTags = new string[] {
        "rule",
        "dispatchFlag",
        "description"};
            this.lvwAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAvailable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.lvwAvailable.showRowNum = false;
            this.lvwAvailable.Size = new System.Drawing.Size(363, 161);
            this.lvwAvailable.TabIndex = 9;
            this.lvwAvailable.UseCompatibleStateImageBehavior = false;
            this.lvwAvailable.View = System.Windows.Forms.View.Details;
            this.lvwAvailable.wndProcIgnoreError = false;
            this.lvwAvailable.DoubleClick += new System.EventHandler(this.lvwAvailable_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvwSelected);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 183);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "selectedList";
            this.groupBox2.Text = "selectedList";
            // 
            // lvwSelected
            // 
            this.lvwSelected.allowUserFilter = false;
            this.lvwSelected.allowUserSorting = false;
            this.lvwSelected.autoSizeColumn = true;
            this.lvwSelected.careModifyDate = false;
            this.lvwSelected.columnHide = null;
            this.lvwSelected.columnNames = new string[] {
        "name",
        "dispatchFlag",
        "description"};
            this.lvwSelected.columnTags = new string[] {
        "rule",
        "dispatchFlag",
        "description"};
            this.lvwSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSelected.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.lvwSelected.showRowNum = false;
            this.lvwSelected.Size = new System.Drawing.Size(362, 158);
            this.lvwSelected.TabIndex = 8;
            this.lvwSelected.UseCompatibleStateImageBehavior = false;
            this.lvwSelected.View = System.Windows.Forms.View.Details;
            this.lvwSelected.wndProcIgnoreError = false;
            this.lvwSelected.DoubleClick += new System.EventHandler(this.lvwSelected_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnUnSelect, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnSelect, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(407, 3);
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
            this.btnUnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUnSelect.ImageKey = "right.ico";
            this.btnUnSelect.ImageList = this.imageList1;
            this.btnUnSelect.Location = new System.Drawing.Point(3, 94);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnUnSelect.TabIndex = 3;
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSelect.ImageKey = "left.ico";
            this.btnSelect.ImageList = this.imageList1;
            this.btnSelect.Location = new System.Drawing.Point(3, 34);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 52);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // mnuVersion
            // 
            this.mnuVersion.Name = "mnuVersion";
            this.mnuVersion.Size = new System.Drawing.Size(61, 4);
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
        "version",
        "issueState",
        "equipmentGroup",
        "fab",
        "seq",
        "description",
        "stage",
        "componentType",
        "stepCode",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.columnTags = new string[] {
        "Step",
        "version",
        "issueState",
        "EquipmentGroup",
        "fab",
        "displaySeq",
        "description",
        "stage",
        "componentType",
        "stepCode",
        "modifyUser",
        "modifyDate"};
            this.mesListView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mesListView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.mesListView1.showRowNum = false;
            this.mesListView1.Size = new System.Drawing.Size(1055, 333);
            this.mesListView1.TabIndex = 7;
            this.mesListView1.UseCompatibleStateImageBehavior = false;
            this.mesListView1.View = System.Windows.Forms.View.Details;
            this.mesListView1.wndProcIgnoreError = false;
            this.mesListView1.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.mesListView1_MESItemSelectionChanged);
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(1055, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(824, 479);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(8, 189);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // lvwStation
            // 
            this.lvwStation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwStation.FullRowSelect = true;
            this.lvwStation.HideSelection = false;
            this.lvwStation.Location = new System.Drawing.Point(3, 54);
            this.lvwStation.MultiSelect = false;
            this.lvwStation.Name = "lvwStation";
            this.lvwStation.Size = new System.Drawing.Size(217, 132);
            this.lvwStation.TabIndex = 13;
            this.lvwStation.UseCompatibleStateImageBehavior = false;
            this.lvwStation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "station";
            this.columnHeader1.Text = "Station";
            this.columnHeader1.Width = 201;
            // 
            // txtStation
            // 
            this.txtStation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStation.Location = new System.Drawing.Point(3, 3);
            this.txtStation.MaxLength = 40;
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(111, 26);
            this.txtStation.TabIndex = 10;
            this.txtStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStation_KeyUp);
            // 
            // btnAddStation
            // 
            this.btnAddStation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAddStation.Location = new System.Drawing.Point(120, 3);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(44, 26);
            this.btnAddStation.TabIndex = 11;
            this.btnAddStation.Tag = "buttonAdd";
            this.btnAddStation.Text = "Add";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDeleteStation.Location = new System.Drawing.Point(170, 3);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(44, 26);
            this.btnDeleteStation.TabIndex = 12;
            this.btnDeleteStation.Tag = "buttonDelete";
            this.btnDeleteStation.Text = "Del";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // grpStation
            // 
            this.grpStation.Controls.Add(this.lvwStation);
            this.grpStation.Controls.Add(this.tableLayoutPanel5);
            this.grpStation.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpStation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpStation.ForeColor = System.Drawing.Color.Blue;
            this.grpStation.Location = new System.Drawing.Point(832, 479);
            this.grpStation.Name = "grpStation";
            this.grpStation.Size = new System.Drawing.Size(223, 189);
            this.grpStation.TabIndex = 12;
            this.grpStation.TabStop = false;
            this.grpStation.Tag = "station";
            this.grpStation.Text = "Station";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.txtStation, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnDeleteStation, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAddStation, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(217, 32);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // frmStep
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1055, 668);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.grpStation);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.mesListView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStep";
            this.Tag = "Step";
            this.Text = "frmStep";
            this.Activated += new System.EventHandler(this.frmStep_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStep_FormClosed);
            this.Load += new System.EventHandler(this.frmStep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grpStation.ResumeLayout(false);
            this.grpStation.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.ComboBox cboStage;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboComponentType;
        private System.Windows.Forms.Label lblComponentType;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtDescription;
        private idv.mesCore.Controls.MESListView mesListView1;
        private System.Windows.Forms.ComboBox cboEqGroup;
        private System.Windows.Forms.Label lblEqGroup;
        private System.Windows.Forms.ComboBox cboStepCode;
        private System.Windows.Forms.Label lblStepCode;
        private System.Windows.Forms.Label lblFAB;
        private System.Windows.Forms.ComboBox cboFAB;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private idv.mesCore.Controls.MESListView lvwAvailable;
        private System.Windows.Forms.GroupBox groupBox2;
        private idv.mesCore.Controls.MESListView lvwSelected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ContextMenuStrip mnuVersion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListView lvwStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.GroupBox grpStation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDisplaySeq;
    }
}