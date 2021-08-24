namespace mesBasicData
{
    partial class frmProductSpecQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductSpecQuery));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwProduct = new idv.mesCore.Controls.MESListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lvwRoute = new idv.mesCore.Controls.MESListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwStep = new idv.mesCore.Controls.MESListView();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlProductSpec = new System.Windows.Forms.Panel();
            this.lvwSpec = new idv.mesCore.Controls.MESListView();
            this.tblOrderId = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetOrderSpec = new System.Windows.Forms.Button();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvwSpecDetail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExport = new System.Windows.Forms.Button();
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
            this.pnlProductSpec.SuspendLayout();
            this.tblOrderId.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lvwProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 697);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvwProduct
            // 
            this.lvwProduct.allowUserFilter = true;
            this.lvwProduct.allowUserSorting = true;
            this.lvwProduct.autoSizeColumn = true;
            this.lvwProduct.careModifyDate = false;
            this.lvwProduct.columnHide = null;
            this.lvwProduct.columnNames = new string[] {
        "name",
        "description"};
            this.lvwProduct.columnTags = new string[] {
        "product",
        "description"};
            this.lvwProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwProduct.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwProduct.FullRowSelect = true;
            this.lvwProduct.GridLines = true;
            this.lvwProduct.HideSelection = false;
            this.lvwProduct.imageKeyColumn = "";
            this.lvwProduct.keyPressSearch = false;
            this.lvwProduct.keyPressSearchColumn = "";
            this.lvwProduct.Location = new System.Drawing.Point(0, 0);
            this.lvwProduct.makesureNewItemVisible = false;
            this.lvwProduct.MultiSelect = false;
            this.lvwProduct.Name = "lvwProduct";
            this.lvwProduct.OwnerDraw = true;
            this.lvwProduct.ShowItemTipSecond = ((byte)(3));
            this.lvwProduct.Size = new System.Drawing.Size(192, 697);
            this.lvwProduct.TabIndex = 5;
            this.lvwProduct.UseCompatibleStateImageBehavior = false;
            this.lvwProduct.View = System.Windows.Forms.View.Details;
            this.lvwProduct.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwProduct_MESItemSelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.splitter1);
            this.splitContainer2.Panel1.Controls.Add(this.pnlProductSpec);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnExport);
            this.splitContainer2.Panel2.Controls.Add(this.lvwSpecDetail);
            this.splitContainer2.Size = new System.Drawing.Size(828, 697);
            this.splitContainer2.SplitterDistance = 275;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 162);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lvwRoute);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lvwStep);
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Size = new System.Drawing.Size(275, 535);
            this.splitContainer3.SplitterDistance = 166;
            this.splitContainer3.TabIndex = 2;
            // 
            // lvwRoute
            // 
            this.lvwRoute.allowUserFilter = false;
            this.lvwRoute.allowUserSorting = true;
            this.lvwRoute.autoSizeColumn = true;
            this.lvwRoute.careModifyDate = false;
            this.lvwRoute.columnHide = null;
            this.lvwRoute.columnNames = new string[] {
        "name",
        "routeType",
        "description"};
            this.lvwRoute.columnTags = new string[] {
        "route",
        "routeType",
        "description"};
            this.lvwRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwRoute.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwRoute.FullRowSelect = true;
            this.lvwRoute.GridLines = true;
            this.lvwRoute.HideSelection = false;
            this.lvwRoute.imageKeyColumn = "";
            this.lvwRoute.keyPressSearch = false;
            this.lvwRoute.keyPressSearchColumn = "";
            this.lvwRoute.Location = new System.Drawing.Point(0, 19);
            this.lvwRoute.makesureNewItemVisible = true;
            this.lvwRoute.MultiSelect = false;
            this.lvwRoute.Name = "lvwRoute";
            this.lvwRoute.OwnerDraw = true;
            this.lvwRoute.ShowItemTipSecond = ((byte)(3));
            this.lvwRoute.Size = new System.Drawing.Size(275, 147);
            this.lvwRoute.TabIndex = 5;
            this.lvwRoute.UseCompatibleStateImageBehavior = false;
            this.lvwRoute.View = System.Windows.Forms.View.Details;
            this.lvwRoute.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwRoute_MESItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 19);
            this.label1.TabIndex = 1;
            this.label1.Tag = "route";
            this.label1.Text = "Route";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwStep
            // 
            this.lvwStep.allowUserFilter = true;
            this.lvwStep.allowUserSorting = false;
            this.lvwStep.autoSizeColumn = true;
            this.lvwStep.careModifyDate = false;
            this.lvwStep.columnHide = null;
            this.lvwStep.columnNames = new string[] {
        "name",
        "version",
        "fab"};
            this.lvwStep.columnTags = new string[] {
        "Step",
        "parameter",
        "stdProcessTime"};
            this.lvwStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStep.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwStep.FullRowSelect = true;
            this.lvwStep.GridLines = true;
            this.lvwStep.HideSelection = false;
            this.lvwStep.imageKeyColumn = "";
            this.lvwStep.keyPressSearch = false;
            this.lvwStep.keyPressSearchColumn = "";
            this.lvwStep.Location = new System.Drawing.Point(0, 19);
            this.lvwStep.makesureNewItemVisible = false;
            this.lvwStep.MultiSelect = false;
            this.lvwStep.Name = "lvwStep";
            this.lvwStep.OwnerDraw = true;
            this.lvwStep.ShowItemTipSecond = ((byte)(3));
            this.lvwStep.Size = new System.Drawing.Size(275, 346);
            this.lvwStep.TabIndex = 3;
            this.lvwStep.UseCompatibleStateImageBehavior = false;
            this.lvwStep.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 1;
            this.label2.Tag = "step";
            this.label2.Text = "step";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 157);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(275, 5);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // pnlProductSpec
            // 
            this.pnlProductSpec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProductSpec.Controls.Add(this.lvwSpec);
            this.pnlProductSpec.Controls.Add(this.tblOrderId);
            this.pnlProductSpec.Controls.Add(this.label3);
            this.pnlProductSpec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductSpec.Location = new System.Drawing.Point(0, 0);
            this.pnlProductSpec.Name = "pnlProductSpec";
            this.pnlProductSpec.Size = new System.Drawing.Size(275, 157);
            this.pnlProductSpec.TabIndex = 3;
            // 
            // lvwSpec
            // 
            this.lvwSpec.allowUserFilter = true;
            this.lvwSpec.allowUserSorting = true;
            this.lvwSpec.autoSizeColumn = true;
            this.lvwSpec.careModifyDate = false;
            this.lvwSpec.columnHide = null;
            this.lvwSpec.columnNames = new string[] {
        "name",
        "version",
        "description"};
            this.lvwSpec.columnTags = new string[] {
        "productParameter",
        "version",
        "description"};
            this.lvwSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSpec.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwSpec.FullRowSelect = true;
            this.lvwSpec.GridLines = true;
            this.lvwSpec.HideSelection = false;
            this.lvwSpec.imageKeyColumn = "";
            this.lvwSpec.keyPressSearch = false;
            this.lvwSpec.keyPressSearchColumn = "";
            this.lvwSpec.Location = new System.Drawing.Point(0, 49);
            this.lvwSpec.makesureNewItemVisible = true;
            this.lvwSpec.MultiSelect = false;
            this.lvwSpec.Name = "lvwSpec";
            this.lvwSpec.OwnerDraw = true;
            this.lvwSpec.ShowItemTipSecond = ((byte)(3));
            this.lvwSpec.Size = new System.Drawing.Size(275, 108);
            this.lvwSpec.TabIndex = 10;
            this.lvwSpec.UseCompatibleStateImageBehavior = false;
            this.lvwSpec.View = System.Windows.Forms.View.Details;
            this.lvwSpec.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwSpec_MESItemSelectionChanged);
            // 
            // tblOrderId
            // 
            this.tblOrderId.AutoSize = true;
            this.tblOrderId.ColumnCount = 3;
            this.tblOrderId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOrderId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblOrderId.Controls.Add(this.btnGetOrderSpec, 2, 0);
            this.tblOrderId.Controls.Add(this.cboOrderId, 1, 0);
            this.tblOrderId.Controls.Add(this.label4, 0, 0);
            this.tblOrderId.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblOrderId.Location = new System.Drawing.Point(0, 19);
            this.tblOrderId.Name = "tblOrderId";
            this.tblOrderId.RowCount = 1;
            this.tblOrderId.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblOrderId.Size = new System.Drawing.Size(275, 30);
            this.tblOrderId.TabIndex = 3;
            // 
            // btnGetOrderSpec
            // 
            this.btnGetOrderSpec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetOrderSpec.Location = new System.Drawing.Point(222, 3);
            this.btnGetOrderSpec.Name = "btnGetOrderSpec";
            this.btnGetOrderSpec.Size = new System.Drawing.Size(50, 24);
            this.btnGetOrderSpec.TabIndex = 11;
            this.btnGetOrderSpec.Tag = "buttonOK";
            this.btnGetOrderSpec.Text = "確定";
            this.btnGetOrderSpec.UseVisualStyleBackColor = true;
            this.btnGetOrderSpec.Click += new System.EventHandler(this.btnGetOrderSpec_Click);
            // 
            // cboOrderId
            // 
            this.cboOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(73, 5);
            this.cboOrderId.MaxLength = 40;
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(143, 24);
            this.cboOrderId.TabIndex = 11;
            this.cboOrderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOrderId_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 0;
            this.label4.Tag = "orderId";
            this.label4.Text = "OrderId";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 19);
            this.label3.TabIndex = 2;
            this.label3.Tag = "productSpec";
            this.label3.Text = "ProductSpec";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwSpecDetail
            // 
            this.lvwSpecDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwSpecDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSpecDetail.FullRowSelect = true;
            this.lvwSpecDetail.GridLines = true;
            this.lvwSpecDetail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwSpecDetail.Location = new System.Drawing.Point(0, 0);
            this.lvwSpecDetail.Name = "lvwSpecDetail";
            this.lvwSpecDetail.Size = new System.Drawing.Size(549, 697);
            this.lvwSpecDetail.TabIndex = 0;
            this.lvwSpecDetail.UseCompatibleStateImageBehavior = false;
            this.lvwSpecDetail.View = System.Windows.Forms.View.Details;
            this.lvwSpecDetail.Resize += new System.EventHandler(this.lvwSpecDetail_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(67, 25);
            this.btnExport.TabIndex = 1;
            this.btnExport.Tag = "buttonExport";
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmProductSpecQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 697);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductSpecQuery";
            this.Tag = "productSpecQuery";
            this.Text = "frmProductSpecQuery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmProductSpecQuery_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
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
            this.pnlProductSpec.ResumeLayout(false);
            this.pnlProductSpec.PerformLayout();
            this.tblOrderId.ResumeLayout(false);
            this.tblOrderId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private idv.mesCore.Controls.MESListView lvwProduct;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private idv.mesCore.Controls.MESListView lvwSpec;
        private idv.mesCore.Controls.MESListView lvwRoute;
        private idv.mesCore.Controls.MESListView lvwStep;
        private System.Windows.Forms.ListView lvwSpecDetail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pnlProductSpec;
        private System.Windows.Forms.TableLayoutPanel tblOrderId;
        private System.Windows.Forms.Button btnGetOrderSpec;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnExport;
    }
}