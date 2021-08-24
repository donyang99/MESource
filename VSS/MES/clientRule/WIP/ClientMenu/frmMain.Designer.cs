namespace ClientRule.ClientMenu
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
            this.tvwFunction = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLotProperty = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel2.Controls.Add(this.tvwFunction);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(702, 644);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 5;
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
            this.lotInfomation1.editable = true;
            this.lotInfomation1.EnableBarcodeControl = true;
            this.lotInfomation1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lotInfomation1.Location = new System.Drawing.Point(0, 22);
            this.lotInfomation1.Margin = new System.Windows.Forms.Padding(4);
            this.lotInfomation1.Name = "lotInfomation1";
            this.lotInfomation1.showCustomerId = false;
            this.lotInfomation1.showDueDate = false;
            this.lotInfomation1.ShowPopupMessage = false;
            this.lotInfomation1.Size = new System.Drawing.Size(254, 622);
            this.lotInfomation1.TabIndex = 4;
            this.lotInfomation1.TimeoutMilliseconds = ((long)(500));
            this.lotInfomation1.ToolTipFontSize = 11.25F;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 22);
            this.label1.TabIndex = 3;
            this.label1.Tag = "lotInformation";
            this.label1.Text = "Lot Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvwFunction
            // 
            this.tvwFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwFunction.Location = new System.Drawing.Point(0, 22);
            this.tvwFunction.Name = "tvwFunction";
            this.tvwFunction.Size = new System.Drawing.Size(444, 622);
            this.tvwFunction.TabIndex = 17;
            this.tvwFunction.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwFunction_NodeMouseDoubleClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 22);
            this.label6.TabIndex = 16;
            this.label6.Tag = "ClientMenu";
            this.label6.Text = "ClientMenu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLotProperty);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 644);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnLotProperty
            // 
            this.btnLotProperty.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLotProperty.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLotProperty.Location = new System.Drawing.Point(92, 0);
            this.btnLotProperty.Name = "btnLotProperty";
            this.btnLotProperty.Size = new System.Drawing.Size(92, 35);
            this.btnLotProperty.TabIndex = 3;
            this.btnLotProperty.Tag = "lotProperty";
            this.btnLotProperty.Text = "Property";
            this.btnLotProperty.UseVisualStyleBackColor = true;
            this.btnLotProperty.Click += new System.EventHandler(this.btnLotProperty_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 35);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Tag = "refresh";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(610, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 679);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Size = new System.Drawing.Size(702, 25);
            this.standardStatusbar1.SizingGrip = false;
            this.standardStatusbar1.TabIndex = 4;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(702, 704);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "ClientMenu";
            this.Text = "ClientMenu";
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
        private mesRelease.Controls.LotInfomation lotInfomation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        internal idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLotProperty;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TreeView tvwFunction;

    }
}