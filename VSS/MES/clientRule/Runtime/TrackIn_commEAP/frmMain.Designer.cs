namespace ClientRule.TrackIn
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lvwCarrier = new idv.mesCore.Controls.MESListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwEquipment = new idv.mesCore.Controls.MESListView();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lvwParameter = new idv.mesCore.Controls.MESListView();
            this.label5 = new System.Windows.Forms.Label();
            this.reasonCode1 = new mesRelease.Controls.ReasonCode();
            this.label6 = new System.Windows.Forms.Label();
            this.workingInstruction1 = new mesRelease.Controls.WorkingInstruction();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
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
            this.lotInfomation1.Location = new System.Drawing.Point(0, 22);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = false;
            this.lotInfomation1.showDueDate = false;
            this.lotInfomation1.Size = new System.Drawing.Size(212, 462);
            this.lotInfomation1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lotInformation";
            this.label1.Text = "Lot Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 95);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(673, 354);
            this.splitContainer2.SplitterDistance = 416;
            this.splitContainer2.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lvwCarrier);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1MinSize = 111;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lvwEquipment);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(416, 354);
            this.splitContainer3.SplitterDistance = 131;
            this.splitContainer3.TabIndex = 0;
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
            this.lvwCarrier.FullRowSelect = true;
            this.lvwCarrier.HideSelection = false;
            this.lvwCarrier.imageKeyColumn = "";
            this.lvwCarrier.keyPressSearch = false;
            this.lvwCarrier.keyPressSearchColumn = "";
            this.lvwCarrier.Location = new System.Drawing.Point(0, 22);
            this.lvwCarrier.makesureNewItemVisible = false;
            this.lvwCarrier.MultiSelect = false;
            this.lvwCarrier.Name = "lvwCarrier";
            this.lvwCarrier.OwnerDraw = true;
            this.lvwCarrier.ShowItemTipSecond = ((byte)(3));
            this.lvwCarrier.Size = new System.Drawing.Size(416, 109);
            this.lvwCarrier.TabIndex = 10;
            this.lvwCarrier.UseCompatibleStateImageBehavior = false;
            this.lvwCarrier.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 22);
            this.label4.TabIndex = 9;
            this.label4.Tag = "carrierList";
            this.label4.Text = "Carrier List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lvwEquipment.FullRowSelect = true;
            this.lvwEquipment.HideSelection = false;
            this.lvwEquipment.imageKeyColumn = "imageKey";
            this.lvwEquipment.keyPressSearch = true;
            this.lvwEquipment.keyPressSearchColumn = "";
            this.lvwEquipment.Location = new System.Drawing.Point(0, 22);
            this.lvwEquipment.makesureNewItemVisible = false;
            this.lvwEquipment.MultiSelect = false;
            this.lvwEquipment.Name = "lvwEquipment";
            this.lvwEquipment.OwnerDraw = true;
            this.lvwEquipment.ShowItemTipSecond = ((byte)(3));
            this.lvwEquipment.Size = new System.Drawing.Size(416, 197);
            this.lvwEquipment.TabIndex = 9;
            this.lvwEquipment.UseCompatibleStateImageBehavior = false;
            this.lvwEquipment.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 22);
            this.label3.TabIndex = 8;
            this.label3.Tag = "eqpEquipmentList";
            this.label3.Text = "Equipment List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lvwParameter);
            this.splitContainer4.Panel1.Controls.Add(this.label5);
            this.splitContainer4.Panel1MinSize = 111;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.reasonCode1);
            this.splitContainer4.Panel2.Controls.Add(this.label6);
            this.splitContainer4.Size = new System.Drawing.Size(253, 354);
            this.splitContainer4.SplitterDistance = 131;
            this.splitContainer4.TabIndex = 0;
            // 
            // lvwParameter
            // 
            this.lvwParameter.allowUserFilter = false;
            this.lvwParameter.allowUserSorting = true;
            this.lvwParameter.autoSizeColumn = true;
            this.lvwParameter.careModifyDate = false;
            this.lvwParameter.columnHide = null;
            this.lvwParameter.columnNames = new string[] {
        "name",
        "displayValue"};
            this.lvwParameter.columnTags = new string[] {
        "parameterName",
        "value"};
            this.lvwParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwParameter.FullRowSelect = true;
            this.lvwParameter.HideSelection = false;
            this.lvwParameter.imageKeyColumn = "";
            this.lvwParameter.keyPressSearch = false;
            this.lvwParameter.keyPressSearchColumn = "";
            this.lvwParameter.Location = new System.Drawing.Point(0, 22);
            this.lvwParameter.makesureNewItemVisible = false;
            this.lvwParameter.MultiSelect = false;
            this.lvwParameter.Name = "lvwParameter";
            this.lvwParameter.OwnerDraw = true;
            this.lvwParameter.ShowItemTipSecond = ((byte)(3));
            this.lvwParameter.Size = new System.Drawing.Size(253, 109);
            this.lvwParameter.TabIndex = 11;
            this.lvwParameter.UseCompatibleStateImageBehavior = false;
            this.lvwParameter.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 22);
            this.label5.TabIndex = 10;
            this.label5.Tag = "parameterList";
            this.label5.Text = "Parameter List";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reasonCode1
            // 
            this.reasonCode1.comments = "";
            this.reasonCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonCode1.Location = new System.Drawing.Point(0, 22);
            this.reasonCode1.maxDropDownItemCount = 20;
            this.reasonCode1.Name = "reasonCode1";
            this.reasonCode1.required = false;
            this.reasonCode1.showCommentOnly = true;
            this.reasonCode1.Size = new System.Drawing.Size(253, 197);
            this.reasonCode1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 22);
            this.label6.TabIndex = 14;
            this.label6.Tag = "comments";
            this.label6.Text = "Comments";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workingInstruction1
            // 
            this.workingInstruction1.autoSize = true;
            this.workingInstruction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workingInstruction1.Dock = System.Windows.Forms.DockStyle.Top;
            this.workingInstruction1.isNowMinimum = false;
            this.workingInstruction1.Location = new System.Drawing.Point(0, 22);
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
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(673, 22);
            this.label2.TabIndex = 4;
            this.label2.Tag = "workingInstruction";
            this.label2.Text = "Working Instruction";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 35);
            this.panel1.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInfo.Location = new System.Drawing.Point(16, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(70, 21);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "            ";
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
            this.Tag = "TrackIn";
            this.Text = "TrackIn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private idv.mesCore.Controls.MESListView lvwEquipment;
        private System.Windows.Forms.Label label3;
        private idv.mesCore.Controls.MESListView lvwCarrier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label5;
        private idv.mesCore.Controls.MESListView lvwParameter;
        private mesRelease.Controls.ReasonCode reasonCode1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInfo;

    }
}