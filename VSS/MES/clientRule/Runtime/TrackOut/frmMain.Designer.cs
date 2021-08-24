namespace ClientRule.TrackOut
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lotInfomation1 = new mesRelease.Controls.LotInfomation();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlComments = new System.Windows.Forms.Panel();
            this.reasonCode1 = new mesRelease.Controls.ReasonCode();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlStepDC = new System.Windows.Forms.Panel();
            this.stepDC1 = new mesRelease.Controls.StepDC();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCustomize = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCurrWorkInfo = new System.Windows.Forms.Panel();
            this.taWorkInformation1 = new mesRelease.Controls.TaWorkInformation();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCarrier = new System.Windows.Forms.Panel();
            this.lvwCarrier = new idv.mesCore.Controls.MESListView();
            this.label4 = new System.Windows.Forms.Label();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.pnlParameter = new System.Windows.Forms.Panel();
            this.lvwParameter = new idv.mesCore.Controls.MESListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkConfirmParameter = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlComments.SuspendLayout();
            this.pnlStepDC.SuspendLayout();
            this.pnlCustomize.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlCurrWorkInfo.SuspendLayout();
            this.pnlCarrier.SuspendLayout();
            this.pnlParameter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(609, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(532, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 0;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lotInfomation1
            // 
            this.lotInfomation1.AutoScroll = true;
            this.lotInfomation1.AutoScrollMinSize = new System.Drawing.Size(100, 336);
            this.lotInfomation1.CheckInputChar = false;
            this.lotInfomation1.displayProperties = new string[] {
        "name",
        "status",
        "quantity",
        "unit",
        "lotType",
        "productId",
        "routeId",
        "stepId",
        "equipmentId",
        "orderId",
        "fab",
        "specId"};
            this.lotInfomation1.displayPropertyTags = new string[] {
        "lotId",
        "status",
        "quantity",
        "unit",
        "lotType",
        "productId",
        "routeId",
        "stepId",
        "equipmentId",
        "orderId",
        "fab",
        "specId"};
            this.lotInfomation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lotInfomation1.editable = false;
            this.lotInfomation1.EnableBarcodeControl = true;
            this.lotInfomation1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lotInfomation1.Location = new System.Drawing.Point(0, 18);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = false;
            this.lotInfomation1.showDueDate = false;
            this.lotInfomation1.ShowPopupMessage = false;
            this.lotInfomation1.Size = new System.Drawing.Size(195, 498);
            this.lotInfomation1.TabIndex = 4;
            this.lotInfomation1.TimeoutMilliseconds = ((long)(500));
            this.lotInfomation1.ToolTipFontSize = 11.25F;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lotInfomation1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlBottom);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.pnlCustomize);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTop);
            this.splitContainer1.Panel2.Controls.Add(this.pnlParameter);
            this.splitContainer1.Size = new System.Drawing.Size(885, 516);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lotInformation";
            this.label1.Text = "Lot Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlComments);
            this.pnlBottom.Controls.Add(this.pnlStepDC);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 310);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(686, 171);
            this.pnlBottom.TabIndex = 24;
            // 
            // pnlComments
            // 
            this.pnlComments.Controls.Add(this.reasonCode1);
            this.pnlComments.Controls.Add(this.label6);
            this.pnlComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComments.Location = new System.Drawing.Point(407, 0);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Size = new System.Drawing.Size(279, 171);
            this.pnlComments.TabIndex = 17;
            // 
            // reasonCode1
            // 
            this.reasonCode1.comments = "";
            this.reasonCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonCode1.Location = new System.Drawing.Point(0, 18);
            this.reasonCode1.maxDropDownItemCount = 20;
            this.reasonCode1.Name = "reasonCode1";
            this.reasonCode1.required = false;
            this.reasonCode1.showCommentOnly = true;
            this.reasonCode1.Size = new System.Drawing.Size(279, 153);
            this.reasonCode1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 18);
            this.label6.TabIndex = 14;
            this.label6.Tag = "comments";
            this.label6.Text = "Comments";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStepDC
            // 
            this.pnlStepDC.Controls.Add(this.stepDC1);
            this.pnlStepDC.Controls.Add(this.label2);
            this.pnlStepDC.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStepDC.Location = new System.Drawing.Point(0, 0);
            this.pnlStepDC.Name = "pnlStepDC";
            this.pnlStepDC.Size = new System.Drawing.Size(407, 171);
            this.pnlStepDC.TabIndex = 14;
            // 
            // stepDC1
            // 
            this.stepDC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepDC1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepDC1.Location = new System.Drawing.Point(0, 18);
            this.stepDC1.Margin = new System.Windows.Forms.Padding(4);
            this.stepDC1.Name = "stepDC1";
            this.stepDC1.Size = new System.Drawing.Size(407, 153);
            this.stepDC1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 18);
            this.label2.TabIndex = 12;
            this.label2.Tag = "stepDC";
            this.label2.Text = "stepDC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCustomize
            // 
            this.pnlCustomize.Controls.Add(this.pnlLeft);
            this.pnlCustomize.Controls.Add(this.pnlRight);
            this.pnlCustomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomize.Location = new System.Drawing.Point(0, 218);
            this.pnlCustomize.Name = "pnlCustomize";
            this.pnlCustomize.Size = new System.Drawing.Size(686, 92);
            this.pnlCustomize.TabIndex = 22;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(407, 92);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(407, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(279, 92);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlCurrWorkInfo);
            this.pnlTop.Controls.Add(this.pnlCarrier);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 105);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(686, 113);
            this.pnlTop.TabIndex = 23;
            // 
            // pnlCurrWorkInfo
            // 
            this.pnlCurrWorkInfo.Controls.Add(this.taWorkInformation1);
            this.pnlCurrWorkInfo.Controls.Add(this.label3);
            this.pnlCurrWorkInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrWorkInfo.Location = new System.Drawing.Point(407, 0);
            this.pnlCurrWorkInfo.Name = "pnlCurrWorkInfo";
            this.pnlCurrWorkInfo.Size = new System.Drawing.Size(279, 113);
            this.pnlCurrWorkInfo.TabIndex = 18;
            // 
            // taWorkInformation1
            // 
            this.taWorkInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taWorkInformation1.Location = new System.Drawing.Point(0, 18);
            this.taWorkInformation1.Name = "taWorkInformation1";
            this.taWorkInformation1.Size = new System.Drawing.Size(279, 95);
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
            this.label3.Size = new System.Drawing.Size(279, 18);
            this.label3.TabIndex = 20;
            this.label3.Tag = "currentTaWorkInfo";
            this.label3.Text = "當前作業人員";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCarrier
            // 
            this.pnlCarrier.Controls.Add(this.lvwCarrier);
            this.pnlCarrier.Controls.Add(this.label4);
            this.pnlCarrier.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCarrier.Location = new System.Drawing.Point(0, 0);
            this.pnlCarrier.Name = "pnlCarrier";
            this.pnlCarrier.Size = new System.Drawing.Size(407, 113);
            this.pnlCarrier.TabIndex = 13;
            // 
            // lvwCarrier
            // 
            this.lvwCarrier.allowUserFilter = false;
            this.lvwCarrier.allowUserSorting = true;
            this.lvwCarrier.autoSizeColumn = true;
            this.lvwCarrier.careModifyDate = false;
            this.lvwCarrier.columnHide = null;
            this.lvwCarrier.columnNames = new string[] {
        "name",
        "componentQty",
        "carrierType"};
            this.lvwCarrier.columnTags = new string[] {
        "carrierId",
        "quantity",
        "carrierType"};
            this.lvwCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCarrier.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwCarrier.FullRowSelect = true;
            this.lvwCarrier.HideSelection = false;
            this.lvwCarrier.imageKeyColumn = "";
            this.lvwCarrier.keyPressSearch = false;
            this.lvwCarrier.keyPressSearchColumn = "";
            this.lvwCarrier.Location = new System.Drawing.Point(0, 18);
            this.lvwCarrier.makesureNewItemVisible = false;
            this.lvwCarrier.MultiSelect = false;
            this.lvwCarrier.Name = "lvwCarrier";
            this.lvwCarrier.OwnerDraw = true;
            this.lvwCarrier.ShowItemTipSecond = ((byte)(3));
            this.lvwCarrier.Size = new System.Drawing.Size(407, 95);
            this.lvwCarrier.TabIndex = 12;
            this.lvwCarrier.UseCompatibleStateImageBehavior = false;
            this.lvwCarrier.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 18);
            this.label4.TabIndex = 11;
            this.label4.Tag = "carrier";
            this.label4.Text = "Carrier";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 516);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(885, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 6;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // pnlParameter
            // 
            this.pnlParameter.Controls.Add(this.lvwParameter);
            this.pnlParameter.Controls.Add(this.tableLayoutPanel1);
            this.pnlParameter.Controls.Add(this.label7);
            this.pnlParameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlParameter.Location = new System.Drawing.Point(0, 0);
            this.pnlParameter.Name = "pnlParameter";
            this.pnlParameter.Size = new System.Drawing.Size(686, 105);
            this.pnlParameter.TabIndex = 25;
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
            this.lvwParameter.Size = new System.Drawing.Size(557, 87);
            this.lvwParameter.TabIndex = 10;
            this.lvwParameter.UseCompatibleStateImageBehavior = false;
            this.lvwParameter.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chkConfirmParameter, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(557, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(129, 87);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // chkConfirmParameter
            // 
            this.chkConfirmParameter.AutoSize = true;
            this.chkConfirmParameter.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkConfirmParameter.ForeColor = System.Drawing.Color.Red;
            this.chkConfirmParameter.Location = new System.Drawing.Point(3, 3);
            this.chkConfirmParameter.Name = "chkConfirmParameter";
            this.chkConfirmParameter.Size = new System.Drawing.Size(123, 20);
            this.chkConfirmParameter.TabIndex = 11;
            this.chkConfirmParameter.Text = "確認生產參數";
            this.chkConfirmParameter.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkConfirmParameter.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(686, 18);
            this.label7.TabIndex = 9;
            this.label7.Tag = "parameter";
            this.label7.Text = "生產參數";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(885, 541);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "TrackOut";
            this.Text = "TrackOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlComments.ResumeLayout(false);
            this.pnlStepDC.ResumeLayout(false);
            this.pnlCustomize.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlCurrWorkInfo.ResumeLayout(false);
            this.pnlCarrier.ResumeLayout(false);
            this.pnlParameter.ResumeLayout(false);
            this.pnlParameter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private mesRelease.Controls.LotInfomation lotInfomation1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private idv.mesCore.Controls.MESListView lvwCarrier;
        private System.Windows.Forms.Label label4;
        private mesRelease.Controls.StepDC stepDC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCarrier;
        private System.Windows.Forms.Panel pnlStepDC;
        private System.Windows.Forms.Panel pnlComments;
        private mesRelease.Controls.ReasonCode reasonCode1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCurrWorkInfo;
        private mesRelease.Controls.TaWorkInformation taWorkInformation1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCustomize;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlParameter;
        private idv.mesCore.Controls.MESListView lvwParameter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkConfirmParameter;
        private System.Windows.Forms.Label label7;


    }
}