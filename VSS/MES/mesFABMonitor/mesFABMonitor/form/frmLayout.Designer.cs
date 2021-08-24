namespace mesFABMonitor
{
    partial class frmLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLayout));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFAB = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwArea = new System.Windows.Forms.ListView();
            this.colArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colbgMap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCurrentArea = new System.Windows.Forms.TextBox();
            this.lvwEquipment = new idv.mesCore.Controls.MESListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.mnuFormat = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuSameHeight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSameWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSameAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAlignTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConcatH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConcatV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuModify,
            this.mnuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 70);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(105, 22);
            this.mnuAdd.Tag = "Add";
            this.mnuAdd.Text = "Add";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuModify
            // 
            this.mnuModify.Name = "mnuModify";
            this.mnuModify.Size = new System.Drawing.Size(105, 22);
            this.mnuModify.Tag = "modify";
            this.mnuModify.Text = "Modify";
            this.mnuModify.Click += new System.EventHandler(this.mnuModify_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(105, 22);
            this.mnuDelete.Tag = "Delete";
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // pnlFAB
            // 
            this.pnlFAB.AllowDrop = true;
            this.pnlFAB.AutoSize = true;
            this.pnlFAB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFAB.Location = new System.Drawing.Point(0, 0);
            this.pnlFAB.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFAB.Name = "pnlFAB";
            this.pnlFAB.Size = new System.Drawing.Size(510, 313);
            this.pnlFAB.TabIndex = 1;
            this.pnlFAB.Click += new System.EventHandler(this.pnlFAB_Click);
            this.pnlFAB.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlFAB_DragDrop);
            this.pnlFAB.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlFAB_DragEnter);
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
            this.splitContainer2.Panel1.Controls.Add(this.lvwArea);
            this.splitContainer2.Panel1.Controls.Add(this.txtCurrentArea);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvwEquipment);
            this.splitContainer2.Size = new System.Drawing.Size(206, 417);
            this.splitContainer2.SplitterDistance = 133;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvwArea
            // 
            this.lvwArea.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArea,
            this.colDescription,
            this.colbgMap});
            this.lvwArea.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwArea.FullRowSelect = true;
            this.lvwArea.GridLines = true;
            this.lvwArea.HideSelection = false;
            this.lvwArea.Location = new System.Drawing.Point(0, 22);
            this.lvwArea.Name = "lvwArea";
            this.lvwArea.ShowGroups = false;
            this.lvwArea.Size = new System.Drawing.Size(206, 111);
            this.lvwArea.TabIndex = 1;
            this.lvwArea.UseCompatibleStateImageBehavior = false;
            this.lvwArea.View = System.Windows.Forms.View.Details;
            this.lvwArea.DoubleClick += new System.EventHandler(this.lvwArea_DoubleClick);
            // 
            // colArea
            // 
            this.colArea.Tag = "fabArea";
            this.colArea.Text = "Area";
            this.colArea.Width = 77;
            // 
            // colDescription
            // 
            this.colDescription.Tag = "description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 89;
            // 
            // colbgMap
            // 
            this.colbgMap.Tag = "backgroundMap";
            this.colbgMap.Text = "BackgroundMap";
            // 
            // txtCurrentArea
            // 
            this.txtCurrentArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCurrentArea.Location = new System.Drawing.Point(0, 0);
            this.txtCurrentArea.Name = "txtCurrentArea";
            this.txtCurrentArea.ReadOnly = true;
            this.txtCurrentArea.Size = new System.Drawing.Size(206, 22);
            this.txtCurrentArea.TabIndex = 0;
            // 
            // lvwEquipment
            // 
            this.lvwEquipment.allowUserFilter = true;
            this.lvwEquipment.allowUserSorting = true;
            this.lvwEquipment.careModifyDate = false;
            this.lvwEquipment.columnHide = null;
            this.lvwEquipment.columnNames = new string[] {
        "name",
        "fab",
        "description"};
            this.lvwEquipment.columnTags = new string[] {
        "equipmentId",
        "fab",
        "description"};
            this.lvwEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEquipment.FullRowSelect = true;
            this.lvwEquipment.HideSelection = false;
            this.lvwEquipment.imageKeyColumn = "";
            this.lvwEquipment.keyPressSearch = false;
            this.lvwEquipment.keyPressSearchColumn = "";
            this.lvwEquipment.Location = new System.Drawing.Point(0, 0);
            this.lvwEquipment.makesureNewItemVisible = true;
            this.lvwEquipment.MultiSelect = false;
            this.lvwEquipment.Name = "lvwEquipment";
            this.lvwEquipment.Size = new System.Drawing.Size(206, 280);
            this.lvwEquipment.TabIndex = 0;
            this.lvwEquipment.UseCompatibleStateImageBehavior = false;
            this.lvwEquipment.View = System.Windows.Forms.View.Details;
            this.lvwEquipment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvwEquipment_MouseMove);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Size = new System.Drawing.Size(773, 417);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer3.Panel1MinSize = 15;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.pnlFAB);
            this.splitContainer3.Size = new System.Drawing.Size(563, 417);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete,
            this.mnuFormat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 22);
            this.btnSave.Tag = "save";
            this.btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 22);
            this.btnDelete.Tag = "delete";
            this.btnDelete.Text = "Delete";
            // 
            // mnuFormat
            // 
            this.mnuFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSameHeight,
            this.mnuSameWidth,
            this.mnuSameAll,
            this.toolStripSeparator2,
            this.mnuAlignTop,
            this.mnuAlignBottom,
            this.mnuAlignLeft,
            this.mnuAlignRight,
            this.toolStripSeparator3,
            this.mnuConcatH,
            this.mnuConcatV,
            this.mnuUndo});
            this.mnuFormat.Image = ((System.Drawing.Image)(resources.GetObject("mnuFormat.Image")));
            this.mnuFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(51, 22);
            this.mnuFormat.Tag = "format";
            this.mnuFormat.Text = "Format";
            // 
            // mnuSameHeight
            // 
            this.mnuSameHeight.Name = "mnuSameHeight";
            this.mnuSameHeight.Size = new System.Drawing.Size(149, 22);
            this.mnuSameHeight.Tag = "sameHeight";
            this.mnuSameHeight.Text = "SameHeight";
            this.mnuSameHeight.Click += new System.EventHandler(this.mnuSameHeight_Click);
            // 
            // mnuSameWidth
            // 
            this.mnuSameWidth.Name = "mnuSameWidth";
            this.mnuSameWidth.Size = new System.Drawing.Size(149, 22);
            this.mnuSameWidth.Tag = "sameWidth";
            this.mnuSameWidth.Text = "SameWidth";
            this.mnuSameWidth.Click += new System.EventHandler(this.mnuSameWidth_Click);
            // 
            // mnuSameAll
            // 
            this.mnuSameAll.Name = "mnuSameAll";
            this.mnuSameAll.Size = new System.Drawing.Size(149, 22);
            this.mnuSameAll.Tag = "sameAll";
            this.mnuSameAll.Text = "Same All";
            this.mnuSameAll.Click += new System.EventHandler(this.mnuSameAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // mnuAlignTop
            // 
            this.mnuAlignTop.Name = "mnuAlignTop";
            this.mnuAlignTop.Size = new System.Drawing.Size(149, 22);
            this.mnuAlignTop.Tag = "alignTop";
            this.mnuAlignTop.Text = "AlignTop";
            this.mnuAlignTop.Click += new System.EventHandler(this.mnuAlignTop_Click);
            // 
            // mnuAlignBottom
            // 
            this.mnuAlignBottom.Name = "mnuAlignBottom";
            this.mnuAlignBottom.Size = new System.Drawing.Size(149, 22);
            this.mnuAlignBottom.Tag = "alignBottom";
            this.mnuAlignBottom.Text = "AlignBottom";
            this.mnuAlignBottom.Click += new System.EventHandler(this.mnuAlignBottom_Click);
            // 
            // mnuAlignLeft
            // 
            this.mnuAlignLeft.Name = "mnuAlignLeft";
            this.mnuAlignLeft.Size = new System.Drawing.Size(149, 22);
            this.mnuAlignLeft.Tag = "alignLeft";
            this.mnuAlignLeft.Text = "AlignLeft";
            this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
            // 
            // mnuAlignRight
            // 
            this.mnuAlignRight.Name = "mnuAlignRight";
            this.mnuAlignRight.Size = new System.Drawing.Size(149, 22);
            this.mnuAlignRight.Tag = "alignRight";
            this.mnuAlignRight.Text = "AlignRight";
            this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
            // 
            // mnuConcatH
            // 
            this.mnuConcatH.Name = "mnuConcatH";
            this.mnuConcatH.Size = new System.Drawing.Size(149, 22);
            this.mnuConcatH.Tag = "concatHorizontal";
            this.mnuConcatH.Text = "concatHorizontal";
            this.mnuConcatH.Click += new System.EventHandler(this.mnuConcatH_Click);
            // 
            // mnuConcatV
            // 
            this.mnuConcatV.Name = "mnuConcatV";
            this.mnuConcatV.Size = new System.Drawing.Size(149, 22);
            this.mnuConcatV.Tag = "concatVertical";
            this.mnuConcatV.Text = "concatVertical";
            this.mnuConcatV.Click += new System.EventHandler(this.mnuConcatV_Click);
            // 
            // mnuUndo
            // 
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.Size = new System.Drawing.Size(149, 22);
            this.mnuUndo.Tag = "undo";
            this.mnuUndo.Text = "undo";
            this.mnuUndo.Click += new System.EventHandler(this.mnuUndo_Click);
            // 
            // frmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 417);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmLayout";
            this.Text = "frmLayout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLayout_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        internal System.Windows.Forms.Panel pnlFAB;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvwArea;
        private System.Windows.Forms.ColumnHeader colArea;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colbgMap;
        private idv.mesCore.Controls.MESListView lvwEquipment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuModify;
        private System.Windows.Forms.TextBox txtCurrentArea;
        private System.Windows.Forms.ToolStripDropDownButton mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuSameHeight;
        private System.Windows.Forms.ToolStripMenuItem mnuSameWidth;
        private System.Windows.Forms.ToolStripMenuItem mnuSameAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignTop;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignBottom;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuConcatH;
        private System.Windows.Forms.ToolStripMenuItem mnuConcatV;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.SplitContainer splitContainer3;

    }
}