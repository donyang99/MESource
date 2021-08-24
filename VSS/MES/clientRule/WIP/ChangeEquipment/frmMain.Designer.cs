namespace ClientRule.ChangeEquipment
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lotInfomation1 = new mesRelease.Controls.LotInfomation();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEqAndDC = new System.Windows.Forms.Panel();
            this.pnlEqList = new System.Windows.Forms.Panel();
            this.lvwEquipment = new idv.mesCore.Controls.MESListView();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlStepDC = new System.Windows.Forms.Panel();
            this.stepDC1 = new mesRelease.Controls.StepDC();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSetupInfoAndComment = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvwSetupMaterial = new idv.mesCore.Controls.MESListView();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlComments = new System.Windows.Forms.Panel();
            this.reasonCode1 = new mesRelease.Controls.ReasonCode();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCustomize = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.workingInstruction1 = new mesRelease.Controls.WorkingInstruction();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlEqAndDC.SuspendLayout();
            this.pnlEqList.SuspendLayout();
            this.pnlStepDC.SuspendLayout();
            this.pnlSetupInfoAndComment.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlComments.SuspendLayout();
            this.pnlCustomize.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lotInfomation1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlEqAndDC);
            this.splitContainer1.Panel2.Controls.Add(this.pnlSetupInfoAndComment);
            this.splitContainer1.Panel2.Controls.Add(this.pnlCustomize);
            this.splitContainer1.Panel2.Controls.Add(this.workingInstruction1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(889, 484);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 5;
            // 
            // lotInfomation1
            // 
            this.lotInfomation1.AutoScroll = true;
            this.lotInfomation1.AutoScrollMinSize = new System.Drawing.Size(100, 336);
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
            this.lotInfomation1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lotInfomation1.Location = new System.Drawing.Point(0, 18);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = false;
            this.lotInfomation1.showDueDate = false;
            this.lotInfomation1.Size = new System.Drawing.Size(212, 466);
            this.lotInfomation1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lotInformation";
            this.label1.Text = "Lot Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEqAndDC
            // 
            this.pnlEqAndDC.Controls.Add(this.pnlEqList);
            this.pnlEqAndDC.Controls.Add(this.pnlStepDC);
            this.pnlEqAndDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEqAndDC.Location = new System.Drawing.Point(0, 183);
            this.pnlEqAndDC.Name = "pnlEqAndDC";
            this.pnlEqAndDC.Size = new System.Drawing.Size(673, 142);
            this.pnlEqAndDC.TabIndex = 22;
            // 
            // pnlEqList
            // 
            this.pnlEqList.Controls.Add(this.lvwEquipment);
            this.pnlEqList.Controls.Add(this.label3);
            this.pnlEqList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEqList.Location = new System.Drawing.Point(0, 0);
            this.pnlEqList.Name = "pnlEqList";
            this.pnlEqList.Size = new System.Drawing.Size(394, 142);
            this.pnlEqList.TabIndex = 10;
            // 
            // lvwEquipment
            // 
            this.lvwEquipment.allowUserFilter = false;
            this.lvwEquipment.allowUserSorting = true;
            this.lvwEquipment.autoSizeColumn = true;
            this.lvwEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvwEquipment.careModifyDate = false;
            this.lvwEquipment.columnHide = null;
            this.lvwEquipment.columnNames = new string[] {
        "name",
        "state",
        "type",
        "capacityUsed",
        "capacity",
        "lotId",
        "recipe"};
            this.lvwEquipment.columnTags = new string[] {
        "Equipment",
        "state",
        "EquipmentType",
        "capacityUsed",
        "capacity",
        "lotId",
        "recipe"};
            this.lvwEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEquipment.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwEquipment.FullRowSelect = true;
            this.lvwEquipment.HideSelection = false;
            this.lvwEquipment.imageKeyColumn = "imageKey";
            this.lvwEquipment.keyPressSearch = true;
            this.lvwEquipment.keyPressSearchColumn = "";
            this.lvwEquipment.Location = new System.Drawing.Point(0, 18);
            this.lvwEquipment.makesureNewItemVisible = false;
            this.lvwEquipment.MultiSelect = false;
            this.lvwEquipment.Name = "lvwEquipment";
            this.lvwEquipment.OwnerDraw = true;
            this.lvwEquipment.ShowItemTipSecond = ((byte)(3));
            this.lvwEquipment.Size = new System.Drawing.Size(394, 124);
            this.lvwEquipment.TabIndex = 9;
            this.lvwEquipment.UseCompatibleStateImageBehavior = false;
            this.lvwEquipment.View = System.Windows.Forms.View.Details;
            this.lvwEquipment.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwEquipment_MESItemSelectionChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 18);
            this.label3.TabIndex = 8;
            this.label3.Tag = "eqpEquipmentList";
            this.label3.Text = "Equipment List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStepDC
            // 
            this.pnlStepDC.Controls.Add(this.stepDC1);
            this.pnlStepDC.Controls.Add(this.label4);
            this.pnlStepDC.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStepDC.Location = new System.Drawing.Point(394, 0);
            this.pnlStepDC.Name = "pnlStepDC";
            this.pnlStepDC.Size = new System.Drawing.Size(279, 142);
            this.pnlStepDC.TabIndex = 1;
            // 
            // stepDC1
            // 
            this.stepDC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepDC1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stepDC1.Location = new System.Drawing.Point(0, 18);
            this.stepDC1.Margin = new System.Windows.Forms.Padding(4);
            this.stepDC1.Name = "stepDC1";
            this.stepDC1.Size = new System.Drawing.Size(279, 124);
            this.stepDC1.TabIndex = 17;
            this.stepDC1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 18);
            this.label4.TabIndex = 19;
            this.label4.Tag = "stepDC";
            this.label4.Text = "站點資料收集";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSetupInfoAndComment
            // 
            this.pnlSetupInfoAndComment.Controls.Add(this.panel3);
            this.pnlSetupInfoAndComment.Controls.Add(this.pnlComments);
            this.pnlSetupInfoAndComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSetupInfoAndComment.Location = new System.Drawing.Point(0, 325);
            this.pnlSetupInfoAndComment.Name = "pnlSetupInfoAndComment";
            this.pnlSetupInfoAndComment.Size = new System.Drawing.Size(673, 124);
            this.pnlSetupInfoAndComment.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvwSetupMaterial);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 124);
            this.panel3.TabIndex = 17;
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
            this.lvwSetupMaterial.Size = new System.Drawing.Size(394, 106);
            this.lvwSetupMaterial.TabIndex = 16;
            this.lvwSetupMaterial.TabStop = false;
            this.lvwSetupMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwSetupMaterial.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 18);
            this.label5.TabIndex = 18;
            this.label5.Tag = "currentSetupInfo";
            this.label5.Text = "機台上料信息";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlComments
            // 
            this.pnlComments.Controls.Add(this.reasonCode1);
            this.pnlComments.Controls.Add(this.label6);
            this.pnlComments.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlComments.Location = new System.Drawing.Point(394, 0);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Size = new System.Drawing.Size(279, 124);
            this.pnlComments.TabIndex = 16;
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
            this.reasonCode1.Size = new System.Drawing.Size(279, 106);
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
            // pnlCustomize
            // 
            this.pnlCustomize.Controls.Add(this.pnlLeft);
            this.pnlCustomize.Controls.Add(this.pnlRight);
            this.pnlCustomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomize.Location = new System.Drawing.Point(0, 91);
            this.pnlCustomize.Name = "pnlCustomize";
            this.pnlCustomize.Size = new System.Drawing.Size(673, 92);
            this.pnlCustomize.TabIndex = 21;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(394, 92);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(394, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(279, 92);
            this.pnlRight.TabIndex = 1;
            // 
            // workingInstruction1
            // 
            this.workingInstruction1.autoSize = true;
            this.workingInstruction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workingInstruction1.Dock = System.Windows.Forms.DockStyle.Top;
            this.workingInstruction1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.workingInstruction1.isNowMinimum = false;
            this.workingInstruction1.Location = new System.Drawing.Point(0, 18);
            this.workingInstruction1.Multiline = true;
            this.workingInstruction1.Name = "workingInstruction1";
            this.workingInstruction1.ReadOnly = true;
            this.workingInstruction1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.workingInstruction1.Size = new System.Drawing.Size(673, 73);
            this.workingInstruction1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(673, 18);
            this.label2.TabIndex = 4;
            this.label2.Tag = "workingInstruction";
            this.label2.Text = "Working Instruction";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(519, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 0;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(596, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 484);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(889, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(889, 509);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "ChangeEquipment";
            this.Text = "ChangeEquipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlEqAndDC.ResumeLayout(false);
            this.pnlEqList.ResumeLayout(false);
            this.pnlStepDC.ResumeLayout(false);
            this.pnlSetupInfoAndComment.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlComments.ResumeLayout(false);
            this.pnlCustomize.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private mesRelease.Controls.LotInfomation lotInfomation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.Label label2;
        private mesRelease.Controls.WorkingInstruction workingInstruction1;
        private idv.mesCore.Controls.MESListView lvwEquipment;
        private System.Windows.Forms.Label label3;
        private mesRelease.Controls.ReasonCode reasonCode1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlEqList;
        private System.Windows.Forms.Panel pnlComments;
        private System.Windows.Forms.Panel pnlCustomize;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlEqAndDC;
        private System.Windows.Forms.Panel pnlStepDC;
        private mesRelease.Controls.StepDC stepDC1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSetupInfoAndComment;
        private System.Windows.Forms.Panel panel3;
        private idv.mesCore.Controls.MESListView lvwSetupMaterial;
        private System.Windows.Forms.Label label5;

    }
}