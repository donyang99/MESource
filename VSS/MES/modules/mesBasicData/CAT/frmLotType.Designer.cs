namespace mesBasicData
{
    partial class frmLotType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExt = new System.Windows.Forms.Panel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.chkTooling = new System.Windows.Forms.CheckBox();
            this.txtLotType = new System.Windows.Forms.TextBox();
            this.lblLotType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkFutureHold = new System.Windows.Forms.CheckBox();
            this.chkQTime = new System.Windows.Forms.CheckBox();
            this.chkDcSelf = new System.Windows.Forms.CheckBox();
            this.chkDcSpec = new System.Windows.Forms.CheckBox();
            this.chkRecipe = new System.Windows.Forms.CheckBox();
            this.chkMaterial = new System.Windows.Forms.CheckBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.lvwLotType = new idv.mesCore.Controls.MESListView();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(937, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "editLotType";
            this.groupBox1.Text = "editLotType";
            // 
            // pnlExt
            // 
            this.pnlExt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExt.Location = new System.Drawing.Point(4, 95);
            this.pnlExt.Name = "pnlExt";
            this.pnlExt.Size = new System.Drawing.Size(929, 28);
            this.pnlExt.TabIndex = 5;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 7;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.Controls.Add(this.chkTooling, 5, 1);
            this.tblDetail.Controls.Add(this.txtLotType, 1, 0);
            this.tblDetail.Controls.Add(this.lblLotType, 0, 0);
            this.tblDetail.Controls.Add(this.lblDescription, 0, 1);
            this.tblDetail.Controls.Add(this.txtDescription, 1, 1);
            this.tblDetail.Controls.Add(this.chkFutureHold, 2, 0);
            this.tblDetail.Controls.Add(this.chkQTime, 3, 0);
            this.tblDetail.Controls.Add(this.chkDcSelf, 4, 0);
            this.tblDetail.Controls.Add(this.chkDcSpec, 5, 0);
            this.tblDetail.Controls.Add(this.chkRecipe, 3, 1);
            this.tblDetail.Controls.Add(this.chkMaterial, 4, 1);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDetail.Location = new System.Drawing.Point(4, 23);
            this.tblDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(929, 72);
            this.tblDetail.TabIndex = 1;
            // 
            // chkTooling
            // 
            this.chkTooling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTooling.AutoSize = true;
            this.chkTooling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkTooling.Location = new System.Drawing.Point(674, 42);
            this.chkTooling.Name = "chkTooling";
            this.chkTooling.Size = new System.Drawing.Size(101, 24);
            this.chkTooling.TabIndex = 18;
            this.chkTooling.Tag = "Tooling";
            this.chkTooling.Text = "Tooling";
            this.chkTooling.UseVisualStyleBackColor = true;
            // 
            // txtLotType
            // 
            this.txtLotType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotType.BackColor = System.Drawing.SystemColors.Info;
            this.txtLotType.Location = new System.Drawing.Point(128, 3);
            this.txtLotType.MaxLength = 20;
            this.txtLotType.Name = "txtLotType";
            this.txtLotType.Size = new System.Drawing.Size(189, 30);
            this.txtLotType.TabIndex = 1;
            // 
            // lblLotType
            // 
            this.lblLotType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLotType.AutoSize = true;
            this.lblLotType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLotType.Location = new System.Drawing.Point(3, 8);
            this.lblLotType.Name = "lblLotType";
            this.lblLotType.Size = new System.Drawing.Size(79, 20);
            this.lblLotType.TabIndex = 0;
            this.lblLotType.Tag = "lotType";
            this.lblLotType.Text = "lotType";
            this.lblLotType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescription.Location = new System.Drawing.Point(3, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(119, 20);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Tag = "description";
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tblDetail.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Location = new System.Drawing.Point(128, 39);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(326, 30);
            this.txtDescription.TabIndex = 12;
            // 
            // chkFutureHold
            // 
            this.chkFutureHold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkFutureHold.AutoSize = true;
            this.chkFutureHold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFutureHold.Location = new System.Drawing.Point(323, 6);
            this.chkFutureHold.Name = "chkFutureHold";
            this.chkFutureHold.Size = new System.Drawing.Size(131, 24);
            this.chkFutureHold.TabIndex = 13;
            this.chkFutureHold.Tag = "futureHold";
            this.chkFutureHold.Text = "FutureHold";
            this.chkFutureHold.UseVisualStyleBackColor = true;
            // 
            // chkQTime
            // 
            this.chkQTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkQTime.AutoSize = true;
            this.chkQTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkQTime.Location = new System.Drawing.Point(460, 6);
            this.chkQTime.Name = "chkQTime";
            this.chkQTime.Size = new System.Drawing.Size(81, 24);
            this.chkQTime.TabIndex = 14;
            this.chkQTime.Tag = "qTime";
            this.chkQTime.Text = "QTime";
            this.chkQTime.UseVisualStyleBackColor = true;
            // 
            // chkDcSelf
            // 
            this.chkDcSelf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDcSelf.AutoSize = true;
            this.chkDcSelf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDcSelf.Location = new System.Drawing.Point(557, 6);
            this.chkDcSelf.Name = "chkDcSelf";
            this.chkDcSelf.Size = new System.Drawing.Size(91, 24);
            this.chkDcSelf.TabIndex = 15;
            this.chkDcSelf.Tag = "stepDC";
            this.chkDcSelf.Text = "DcSelf";
            this.chkDcSelf.UseVisualStyleBackColor = true;
            // 
            // chkDcSpec
            // 
            this.chkDcSpec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDcSpec.AutoSize = true;
            this.chkDcSpec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkDcSpec.Location = new System.Drawing.Point(674, 6);
            this.chkDcSpec.Name = "chkDcSpec";
            this.chkDcSpec.Size = new System.Drawing.Size(91, 24);
            this.chkDcSpec.TabIndex = 16;
            this.chkDcSpec.Tag = "productParameter";
            this.chkDcSpec.Text = "DcSpec";
            this.chkDcSpec.UseVisualStyleBackColor = true;
            // 
            // chkRecipe
            // 
            this.chkRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRecipe.AutoSize = true;
            this.chkRecipe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRecipe.Location = new System.Drawing.Point(460, 42);
            this.chkRecipe.Name = "chkRecipe";
            this.chkRecipe.Size = new System.Drawing.Size(91, 24);
            this.chkRecipe.TabIndex = 16;
            this.chkRecipe.Tag = "recipe";
            this.chkRecipe.Text = "Recipe";
            this.chkRecipe.UseVisualStyleBackColor = true;
            // 
            // chkMaterial
            // 
            this.chkMaterial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkMaterial.AutoSize = true;
            this.chkMaterial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMaterial.Location = new System.Drawing.Point(557, 42);
            this.chkMaterial.Name = "chkMaterial";
            this.chkMaterial.Size = new System.Drawing.Size(111, 24);
            this.chkMaterial.TabIndex = 17;
            this.chkMaterial.Tag = "EqMaterialInfo";
            this.chkMaterial.Text = "Material";
            this.chkMaterial.UseVisualStyleBackColor = true;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(937, 25);
            this.actionToolbar1.TabIndex = 0;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // lvwLotType
            // 
            this.lvwLotType.allowUserFilter = true;
            this.lvwLotType.allowUserSorting = true;
            this.lvwLotType.autoSizeColumn = true;
            this.lvwLotType.careModifyDate = false;
            this.lvwLotType.columnHide = null;
            this.lvwLotType.columnNames = new string[] {
        "name",
        "description",
        "checkFutureHold",
        "checkQTime",
        "checkDcSelf",
        "checkDcSpec",
        "checkRecipe",
        "checkMaterial"};
            this.lvwLotType.columnTags = new string[] {
        "lotType",
        "description",
        "futureHold",
        "qTime",
        "stepDC",
        "productParameter",
        "recipe",
        "EqMaterialInfo"};
            this.lvwLotType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLotType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLotType.FullRowSelect = true;
            this.lvwLotType.GridLines = true;
            this.lvwLotType.HideSelection = false;
            this.lvwLotType.imageKeyColumn = "";
            this.lvwLotType.keyPressSearch = false;
            this.lvwLotType.keyPressSearchColumn = "";
            this.lvwLotType.Location = new System.Drawing.Point(0, 152);
            this.lvwLotType.makesureNewItemVisible = true;
            this.lvwLotType.Margin = new System.Windows.Forms.Padding(4);
            this.lvwLotType.MultiSelect = false;
            this.lvwLotType.Name = "lvwLotType";
            this.lvwLotType.OwnerDraw = true;
            this.lvwLotType.ShowItemTipSecond = ((byte)(3));
            this.lvwLotType.Size = new System.Drawing.Size(937, 263);
            this.lvwLotType.TabIndex = 10;
            this.lvwLotType.UseCompatibleStateImageBehavior = false;
            this.lvwLotType.View = System.Windows.Forms.View.Details;
            this.lvwLotType.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwLotType_MESItemSelectionChanged);
            // 
            // frmLotType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 415);
            this.Controls.Add(this.lvwLotType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLotType";
            this.Tag = "lotType";
            this.Text = "lotType";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLotType_FormClosed);
            this.Load += new System.EventHandler(this.frmLotType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox txtLotType;
        private System.Windows.Forms.Label lblLotType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private idv.mesCore.Controls.MESListView lvwLotType;
        private System.Windows.Forms.CheckBox chkQTime;
        private System.Windows.Forms.CheckBox chkFutureHold;
        private System.Windows.Forms.CheckBox chkMaterial;
        private System.Windows.Forms.CheckBox chkRecipe;
        private System.Windows.Forms.CheckBox chkDcSelf;
        private System.Windows.Forms.CheckBox chkDcSpec;
        private System.Windows.Forms.Panel pnlExt;
        private System.Windows.Forms.CheckBox chkTooling;
    }
}