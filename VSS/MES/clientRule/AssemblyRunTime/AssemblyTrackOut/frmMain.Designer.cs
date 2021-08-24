namespace ClientRule.AssemblyTrackOut
{
    partial class frmMain
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
            this.btnTxnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblGetLot = new System.Windows.Forms.TableLayoutPanel();
            this.txtLotId = new idv.mesCore.Controls.BarcodeTextBox();
            this.trackOutType1 = new mesRelease.Controls.TrackOutType();
            this.lblTrackOutType = new System.Windows.Forms.Label();
            this.txtLotStatus = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtEquipmentId = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.btnGetLot = new System.Windows.Forms.Button();
            this.lblLotId = new System.Windows.Forms.Label();
            this.lvwSetupMaterial = new idv.mesCore.Controls.MESListView();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.outputInfo1 = new mesRelease.Controls.OutputInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlStepDC = new System.Windows.Forms.Panel();
            this.stepDC1 = new mesRelease.Controls.StepDC();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCurrWorkInfo = new System.Windows.Forms.Panel();
            this.taWorkInformation1 = new mesRelease.Controls.TaWorkInformation();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDisplayMessage = new System.Windows.Forms.Panel();
            this.pnlParameter = new System.Windows.Forms.Panel();
            this.lvwParameter = new idv.mesCore.Controls.MESListView();
            this.label7 = new System.Windows.Forms.Label();
            this.tblGetLot.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlStepDC.SuspendLayout();
            this.pnlCurrWorkInfo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTxnOK
            // 
            this.btnTxnOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTxnOK.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTxnOK.Location = new System.Drawing.Point(946, 3);
            this.btnTxnOK.Name = "btnTxnOK";
            this.btnTxnOK.Size = new System.Drawing.Size(62, 32);
            this.btnTxnOK.TabIndex = 3;
            this.btnTxnOK.Tag = "buttonOK";
            this.btnTxnOK.Text = "OK";
            this.btnTxnOK.UseVisualStyleBackColor = true;
            this.btnTxnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 7);
            this.label1.TabIndex = 15;
            this.label1.Tag = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblGetLot
            // 
            this.tblGetLot.ColumnCount = 11;
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGetLot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGetLot.Controls.Add(this.txtLotId, 4, 0);
            this.tblGetLot.Controls.Add(this.trackOutType1, 8, 0);
            this.tblGetLot.Controls.Add(this.lblTrackOutType, 7, 0);
            this.tblGetLot.Controls.Add(this.txtLotStatus, 6, 0);
            this.tblGetLot.Controls.Add(this.txtState, 2, 0);
            this.tblGetLot.Controls.Add(this.txtEquipmentId, 1, 0);
            this.tblGetLot.Controls.Add(this.lblEquipment, 0, 0);
            this.tblGetLot.Controls.Add(this.btnGetLot, 5, 0);
            this.tblGetLot.Controls.Add(this.lblLotId, 3, 0);
            this.tblGetLot.Controls.Add(this.btnTxnOK, 10, 0);
            this.tblGetLot.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblGetLot.Location = new System.Drawing.Point(0, 50);
            this.tblGetLot.Name = "tblGetLot";
            this.tblGetLot.RowCount = 1;
            this.tblGetLot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGetLot.Size = new System.Drawing.Size(1011, 38);
            this.tblGetLot.TabIndex = 8;
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotId.BackColor = System.Drawing.SystemColors.Info;
            this.txtLotId.CheckInputChar = false;
            this.txtLotId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLotId.Location = new System.Drawing.Point(354, 6);
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.ShowPopupMessage = false;
            this.txtLotId.Size = new System.Drawing.Size(159, 26);
            this.txtLotId.TabIndex = 0;
            this.txtLotId.TimeOutMilliseconds = ((long)(500));
            this.txtLotId.ToolTipFontSize = 11.25F;
            this.txtLotId.BarcodeInput += new idv.mesCore.Controls.BarcodeTextBox.BarcodeInputEventHandler(this.txtLotId_BarcodeInput);
            // 
            // trackOutType1
            // 
            this.trackOutType1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackOutType1.AutoSize = true;
            this.trackOutType1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackOutType1.Location = new System.Drawing.Point(705, 3);
            this.trackOutType1.Name = "trackOutType1";
            this.trackOutType1.Size = new System.Drawing.Size(243, 32);
            this.trackOutType1.TabIndex = 0;
            this.trackOutType1.TrackOutPath = "PASS";
            this.trackOutType1.Visible = false;
            // 
            // lblTrackOutType
            // 
            this.lblTrackOutType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTrackOutType.AutoSize = true;
            this.lblTrackOutType.Location = new System.Drawing.Point(627, 11);
            this.lblTrackOutType.Name = "lblTrackOutType";
            this.lblTrackOutType.Size = new System.Drawing.Size(72, 16);
            this.lblTrackOutType.TabIndex = 1;
            this.lblTrackOutType.Tag = "trackOutType";
            this.lblTrackOutType.Text = "出帳類型";
            this.lblTrackOutType.Visible = false;
            // 
            // txtLotStatus
            // 
            this.txtLotStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotStatus.Location = new System.Drawing.Point(576, 6);
            this.txtLotStatus.MaxLength = 40;
            this.txtLotStatus.Name = "txtLotStatus";
            this.txtLotStatus.ReadOnly = true;
            this.txtLotStatus.Size = new System.Drawing.Size(45, 26);
            this.txtLotStatus.TabIndex = 6;
            this.txtLotStatus.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtState.Location = new System.Drawing.Point(249, 6);
            this.txtState.MaxLength = 40;
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(45, 26);
            this.txtState.TabIndex = 5;
            this.txtState.TabStop = false;
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEquipmentId.Location = new System.Drawing.Point(105, 6);
            this.txtEquipmentId.MaxLength = 40;
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.ReadOnly = true;
            this.txtEquipmentId.Size = new System.Drawing.Size(138, 26);
            this.txtEquipmentId.TabIndex = 4;
            this.txtEquipmentId.TabStop = false;
            // 
            // lblEquipment
            // 
            this.lblEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(3, 11);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(96, 16);
            this.lblEquipment.TabIndex = 3;
            this.lblEquipment.Tag = "currentEqp";
            this.lblEquipment.Text = "EquipmentId";
            // 
            // btnGetLot
            // 
            this.btnGetLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetLot.Location = new System.Drawing.Point(519, 6);
            this.btnGetLot.Name = "btnGetLot";
            this.btnGetLot.Size = new System.Drawing.Size(51, 25);
            this.btnGetLot.TabIndex = 2;
            this.btnGetLot.TabStop = false;
            this.btnGetLot.Tag = "fetch";
            this.btnGetLot.Text = "Get";
            this.btnGetLot.UseVisualStyleBackColor = true;
            this.btnGetLot.Click += new System.EventHandler(this.btnGetLot_Click);
            // 
            // lblLotId
            // 
            this.lblLotId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLotId.AutoSize = true;
            this.lblLotId.Location = new System.Drawing.Point(300, 11);
            this.lblLotId.Name = "lblLotId";
            this.lblLotId.Size = new System.Drawing.Size(48, 16);
            this.lblLotId.TabIndex = 0;
            this.lblLotId.Tag = "lotId";
            this.lblLotId.Text = "LotId";
            // 
            // lvwSetupMaterial
            // 
            this.lvwSetupMaterial.allowUserFilter = false;
            this.lvwSetupMaterial.allowUserSorting = false;
            this.lvwSetupMaterial.autoSizeColumn = false;
            this.lvwSetupMaterial.careModifyDate = false;
            this.lvwSetupMaterial.columnHide = new string[0];
            this.lvwSetupMaterial.columnNames = new string[] {
        "name",
        "partNo",
        "materialLotId",
        "position",
        "quantity"};
            this.lvwSetupMaterial.columnTags = new string[] {
        "materialType",
        "materialPartNo",
        "materialLotId",
        "position",
        "quantity"};
            this.lvwSetupMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSetupMaterial.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSetupMaterial.FullRowSelect = true;
            this.lvwSetupMaterial.HideSelection = false;
            this.lvwSetupMaterial.imageKeyColumn = "";
            this.lvwSetupMaterial.keyPressSearch = false;
            this.lvwSetupMaterial.keyPressSearchColumn = "";
            this.lvwSetupMaterial.Location = new System.Drawing.Point(0, 18);
            this.lvwSetupMaterial.makesureNewItemVisible = true;
            this.lvwSetupMaterial.MultiSelect = false;
            this.lvwSetupMaterial.Name = "lvwSetupMaterial";
            this.lvwSetupMaterial.OwnerDraw = true;
            this.lvwSetupMaterial.ShowItemTipSecond = ((byte)(3));
            this.lvwSetupMaterial.Size = new System.Drawing.Size(265, 86);
            this.lvwSetupMaterial.TabIndex = 16;
            this.lvwSetupMaterial.TabStop = false;
            this.lvwSetupMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwSetupMaterial.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 18);
            this.label6.TabIndex = 18;
            this.label6.Tag = "currentSetupInfo";
            this.label6.Text = "機台上料信息";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 199);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1011, 3);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 202);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1011, 60);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRight.Location = new System.Drawing.Point(0, 425);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1011, 71);
            this.pnlRight.TabIndex = 1;
            // 
            // outputInfo1
            // 
            this.outputInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputInfo1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputInfo1.KeepCount = 500;
            this.outputInfo1.Location = new System.Drawing.Point(0, 0);
            this.outputInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.outputInfo1.Name = "outputInfo1";
            this.outputInfo1.showTotalQuantity = false;
            this.outputInfo1.Size = new System.Drawing.Size(1011, 163);
            this.outputInfo1.TabIndex = 21;
            this.outputInfo1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlParameter);
            this.panel1.Controls.Add(this.pnlStepDC);
            this.panel1.Controls.Add(this.pnlCurrWorkInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 104);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvwSetupMaterial);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 104);
            this.panel3.TabIndex = 1;
            // 
            // pnlStepDC
            // 
            this.pnlStepDC.Controls.Add(this.stepDC1);
            this.pnlStepDC.Controls.Add(this.label2);
            this.pnlStepDC.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStepDC.Location = new System.Drawing.Point(522, 0);
            this.pnlStepDC.Name = "pnlStepDC";
            this.pnlStepDC.Size = new System.Drawing.Size(237, 104);
            this.pnlStepDC.TabIndex = 0;
            // 
            // stepDC1
            // 
            this.stepDC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepDC1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepDC1.Location = new System.Drawing.Point(0, 18);
            this.stepDC1.Margin = new System.Windows.Forms.Padding(4);
            this.stepDC1.Name = "stepDC1";
            this.stepDC1.Size = new System.Drawing.Size(237, 86);
            this.stepDC1.TabIndex = 17;
            this.stepDC1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 18);
            this.label2.TabIndex = 19;
            this.label2.Tag = "stepDC";
            this.label2.Text = "站點資料收集";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCurrWorkInfo
            // 
            this.pnlCurrWorkInfo.Controls.Add(this.taWorkInformation1);
            this.pnlCurrWorkInfo.Controls.Add(this.label3);
            this.pnlCurrWorkInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCurrWorkInfo.Location = new System.Drawing.Point(759, 0);
            this.pnlCurrWorkInfo.Name = "pnlCurrWorkInfo";
            this.pnlCurrWorkInfo.Size = new System.Drawing.Size(252, 104);
            this.pnlCurrWorkInfo.TabIndex = 2;
            // 
            // taWorkInformation1
            // 
            this.taWorkInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taWorkInformation1.Location = new System.Drawing.Point(0, 18);
            this.taWorkInformation1.Name = "taWorkInformation1";
            this.taWorkInformation1.Size = new System.Drawing.Size(252, 86);
            this.taWorkInformation1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 18);
            this.label3.TabIndex = 20;
            this.label3.Tag = "currentTaWorkInfo";
            this.label3.Text = "當前作業人員";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.outputInfo1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 262);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1011, 163);
            this.pnlMain.TabIndex = 23;
            // 
            // pnlDisplayMessage
            // 
            this.pnlDisplayMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplayMessage.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplayMessage.Name = "pnlDisplayMessage";
            this.pnlDisplayMessage.Size = new System.Drawing.Size(1011, 50);
            this.pnlDisplayMessage.TabIndex = 24;
            // 
            // pnlParameter
            // 
            this.pnlParameter.Controls.Add(this.lvwParameter);
            this.pnlParameter.Controls.Add(this.label7);
            this.pnlParameter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlParameter.Location = new System.Drawing.Point(265, 0);
            this.pnlParameter.Name = "pnlParameter";
            this.pnlParameter.Size = new System.Drawing.Size(257, 104);
            this.pnlParameter.TabIndex = 26;
            // 
            // lvwParameter
            // 
            this.lvwParameter.allowUserFilter = false;
            this.lvwParameter.allowUserSorting = true;
            this.lvwParameter.autoSizeColumn = false;
            this.lvwParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvwParameter.careModifyDate = false;
            this.lvwParameter.columnHide = null;
            this.lvwParameter.columnNames = new string[] {
        "name",
        "displayValue",
        "remark"};
            this.lvwParameter.columnTags = new string[] {
        "parameter",
        "specRef",
        "remark"};
            this.lvwParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwParameter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwParameter.FullRowSelect = true;
            this.lvwParameter.HideSelection = false;
            this.lvwParameter.imageKeyColumn = "";
            this.lvwParameter.keyPressSearch = true;
            this.lvwParameter.keyPressSearchColumn = "";
            this.lvwParameter.Location = new System.Drawing.Point(0, 18);
            this.lvwParameter.makesureNewItemVisible = false;
            this.lvwParameter.MultiSelect = false;
            this.lvwParameter.Name = "lvwParameter";
            this.lvwParameter.OwnerDraw = true;
            this.lvwParameter.ShowItemTipSecond = ((byte)(3));
            this.lvwParameter.Size = new System.Drawing.Size(257, 86);
            this.lvwParameter.TabIndex = 10;
            this.lvwParameter.UseCompatibleStateImageBehavior = false;
            this.lvwParameter.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 18);
            this.label7.TabIndex = 9;
            this.label7.Tag = "parameter";
            this.label7.Text = "生產參數";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1011, 496);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblGetLot);
            this.Controls.Add(this.pnlDisplayMessage);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "AssemblyTrackOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tblGetLot.ResumeLayout(false);
            this.tblGetLot.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlStepDC.ResumeLayout(false);
            this.pnlCurrWorkInfo.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlParameter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTxnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblGetLot;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtEquipmentId;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Button btnGetLot;
        private System.Windows.Forms.Label lblLotId;
        private idv.mesCore.Controls.MESListView lvwSetupMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private mesRelease.Controls.OutputInfo outputInfo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlStepDC;
        private System.Windows.Forms.Label label2;
        private mesRelease.Controls.StepDC stepDC1;
        private System.Windows.Forms.TextBox txtLotStatus;
        private System.Windows.Forms.Panel pnlCurrWorkInfo;
        private mesRelease.Controls.TaWorkInformation taWorkInformation1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTrackOutType;
        private mesRelease.Controls.TrackOutType trackOutType1;
        private idv.mesCore.Controls.BarcodeTextBox txtLotId;
        private System.Windows.Forms.Panel pnlDisplayMessage;
        private System.Windows.Forms.Panel pnlParameter;
        private idv.mesCore.Controls.MESListView lvwParameter;
        private System.Windows.Forms.Label label7;

    }
}