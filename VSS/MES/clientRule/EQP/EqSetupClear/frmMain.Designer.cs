namespace ClientRule.EqSetupClear
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
            this.equipmentInformation1 = new mesRelease.Controls.EquipmentInformation();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwCurSetupMaterial = new idv.mesCore.Controls.MESListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.equipmentInformation1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwCurSetupMaterial);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(677, 473);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 5;
            // 
            // equipmentInformation1
            // 
            this.equipmentInformation1.AutoScroll = true;
            this.equipmentInformation1.AutoScrollMinSize = new System.Drawing.Size(100, 196);
            this.equipmentInformation1.displayProperties = new string[] {
        "name",
        "state",
        "type",
        "recipe",
        "owner",
        "counter",
        "fab"};
            this.equipmentInformation1.displayPropertyTags = new string[] {
        "equipmentId",
        "state",
        "equipmentType",
        "recipe",
        "owner",
        "counter",
        "fab"};
            this.equipmentInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentInformation1.editable = true;
            this.equipmentInformation1.Location = new System.Drawing.Point(0, 22);
            this.equipmentInformation1.Name = "equipmentInformation1";
            this.equipmentInformation1.Size = new System.Drawing.Size(213, 451);
            this.equipmentInformation1.TabIndex = 8;
            this.equipmentInformation1.EquipmentChanged += new mesRelease.Controls.EquipmentChangeEventHandler(this.equipmentInformation1_EquipmentChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 7;
            this.label1.Tag = "eqpInformation";
            this.label1.Text = "Equipment Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwCurSetupMaterial
            // 
            this.lvwCurSetupMaterial.allowUserFilter = false;
            this.lvwCurSetupMaterial.allowUserSorting = false;
            this.lvwCurSetupMaterial.autoSizeColumn = true;
            this.lvwCurSetupMaterial.careModifyDate = false;
            this.lvwCurSetupMaterial.columnHide = null;
            this.lvwCurSetupMaterial.columnNames = null;
            this.lvwCurSetupMaterial.columnTags = null;
            this.lvwCurSetupMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCurSetupMaterial.FullRowSelect = true;
            this.lvwCurSetupMaterial.HideSelection = false;
            this.lvwCurSetupMaterial.imageKeyColumn = "";
            this.lvwCurSetupMaterial.keyPressSearch = false;
            this.lvwCurSetupMaterial.keyPressSearchColumn = "";
            this.lvwCurSetupMaterial.Location = new System.Drawing.Point(0, 22);
            this.lvwCurSetupMaterial.makesureNewItemVisible = true;
            this.lvwCurSetupMaterial.MultiSelect = false;
            this.lvwCurSetupMaterial.Name = "lvwCurSetupMaterial";
            this.lvwCurSetupMaterial.OwnerDraw = true;
            this.lvwCurSetupMaterial.ShowItemTipSecond = ((byte)(3));
            this.lvwCurSetupMaterial.Size = new System.Drawing.Size(460, 416);
            this.lvwCurSetupMaterial.TabIndex = 10;
            this.lvwCurSetupMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwCurSetupMaterial.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(383, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(306, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 22);
            this.label2.TabIndex = 5;
            this.label2.Tag = "currentSetupInfo";
            this.label2.Text = "currentSetupInfo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 473);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(677, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(677, 498);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "EqSetupClear";
            this.Text = "EqSetupClear";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.Label label2;
        protected internal idv.mesCore.Controls.MESListView lvwCurSetupMaterial;
        private mesRelease.Controls.EquipmentInformation equipmentInformation1;
        private System.Windows.Forms.Label label1;

    }
}