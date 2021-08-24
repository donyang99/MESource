namespace mesRelease.Controls
{
    partial class WIPComponentInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIPComponentInformation));
            this.tblCarrierInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtCarrierQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCarrierId = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDeleteComponent = new System.Windows.Forms.Button();
            this.tblEditComponent = new System.Windows.Forms.TableLayoutPanel();
            this.cboComponentId = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lvwComponentId = new System.Windows.Forms.ListView();
            this.colCarrierPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCarrierComponentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblCarrierInfo.SuspendLayout();
            this.tblEditComponent.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCarrierInfo
            // 
            this.tblCarrierInfo.ColumnCount = 4;
            this.tblCarrierInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tblCarrierInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCarrierInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblCarrierInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblCarrierInfo.Controls.Add(this.txtCarrierQty, 3, 0);
            this.tblCarrierInfo.Controls.Add(this.label10, 2, 0);
            this.tblCarrierInfo.Controls.Add(this.label9, 0, 0);
            this.tblCarrierInfo.Controls.Add(this.txtCarrierId, 1, 0);
            this.tblCarrierInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCarrierInfo.Location = new System.Drawing.Point(0, 0);
            this.tblCarrierInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblCarrierInfo.Name = "tblCarrierInfo";
            this.tblCarrierInfo.RowCount = 2;
            this.tblCarrierInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblCarrierInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tblCarrierInfo.Size = new System.Drawing.Size(444, 41);
            this.tblCarrierInfo.TabIndex = 26;
            // 
            // txtCarrierQty
            // 
            this.txtCarrierQty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCarrierQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtCarrierQty.Location = new System.Drawing.Point(357, 4);
            this.txtCarrierQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarrierQty.MaxLength = 4;
            this.txtCarrierQty.Name = "txtCarrierQty";
            this.txtCarrierQty.ReadOnly = true;
            this.txtCarrierQty.Size = new System.Drawing.Size(81, 26);
            this.txtCarrierQty.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 32);
            this.label10.TabIndex = 14;
            this.label10.Tag = "quantity";
            this.label10.Text = "quantity";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 13;
            this.label9.Tag = "carrierId";
            this.label9.Text = "carrierId";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCarrierId
            // 
            this.txtCarrierId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarrierId.BackColor = System.Drawing.SystemColors.Control;
            this.txtCarrierId.Location = new System.Drawing.Point(89, 4);
            this.txtCarrierId.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.txtCarrierId.MaxLength = 40;
            this.txtCarrierId.Name = "txtCarrierId";
            this.txtCarrierId.ReadOnly = true;
            this.txtCarrierId.Size = new System.Drawing.Size(200, 26);
            this.txtCarrierId.TabIndex = 19;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.Location = new System.Drawing.Point(357, 4);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(83, 27);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Tag = "autoGenerate";
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddComponent.Location = new System.Drawing.Point(293, 4);
            this.btnAddComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(56, 27);
            this.btnAddComponent.TabIndex = 1;
            this.btnAddComponent.Tag = "add";
            this.btnAddComponent.Text = "Add";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 20;
            this.label1.Tag = "componentId";
            this.label1.Text = "componentId";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDown.ImageKey = "down.ico";
            this.btnDown.ImageList = this.imageList1;
            this.btnDown.Location = new System.Drawing.Point(403, 59);
            this.btnDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(41, 45);
            this.btnDown.TabIndex = 30;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "down.ico");
            this.imageList1.Images.SetKeyName(1, "up.ico");
            this.imageList1.Images.SetKeyName(2, "delete.ico");
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUp.ImageKey = "up.ico";
            this.btnUp.ImageList = this.imageList1;
            this.btnUp.Location = new System.Drawing.Point(403, 4);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(41, 45);
            this.btnUp.TabIndex = 31;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDeleteComponent
            // 
            this.btnDeleteComponent.Font = new System.Drawing.Font("SimSun", 9F);
            this.btnDeleteComponent.ImageKey = "delete.ico";
            this.btnDeleteComponent.ImageList = this.imageList1;
            this.btnDeleteComponent.Location = new System.Drawing.Point(403, 126);
            this.btnDeleteComponent.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnDeleteComponent.Name = "btnDeleteComponent";
            this.btnDeleteComponent.Size = new System.Drawing.Size(41, 44);
            this.btnDeleteComponent.TabIndex = 32;
            this.btnDeleteComponent.UseVisualStyleBackColor = true;
            this.btnDeleteComponent.Click += new System.EventHandler(this.btnDeleteComponent_Click);
            // 
            // tblEditComponent
            // 
            this.tblEditComponent.ColumnCount = 4;
            this.tblEditComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tblEditComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEditComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblEditComponent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblEditComponent.Controls.Add(this.btnGenerate, 3, 0);
            this.tblEditComponent.Controls.Add(this.label1, 0, 0);
            this.tblEditComponent.Controls.Add(this.btnAddComponent, 2, 0);
            this.tblEditComponent.Controls.Add(this.cboComponentId, 1, 0);
            this.tblEditComponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblEditComponent.Location = new System.Drawing.Point(0, 41);
            this.tblEditComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblEditComponent.Name = "tblEditComponent";
            this.tblEditComponent.RowCount = 2;
            this.tblEditComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblEditComponent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tblEditComponent.Size = new System.Drawing.Size(444, 41);
            this.tblEditComponent.TabIndex = 33;
            // 
            // cboComponentId
            // 
            this.cboComponentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComponentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboComponentId.FormattingEnabled = true;
            this.cboComponentId.Location = new System.Drawing.Point(89, 5);
            this.cboComponentId.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.cboComponentId.Name = "cboComponentId";
            this.cboComponentId.Size = new System.Drawing.Size(200, 24);
            this.cboComponentId.Sorted = true;
            this.cboComponentId.TabIndex = 21;
            this.cboComponentId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboComponentId_KeyUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.Controls.Add(this.lvwComponentId, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUp, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDown, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteComponent, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 82);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(444, 301);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // lvwComponentId
            // 
            this.lvwComponentId.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCarrierPosition,
            this.colCarrierComponentId});
            this.lvwComponentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwComponentId.FullRowSelect = true;
            this.lvwComponentId.HideSelection = false;
            this.lvwComponentId.Location = new System.Drawing.Point(4, 4);
            this.lvwComponentId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwComponentId.Name = "lvwComponentId";
            this.tableLayoutPanel3.SetRowSpan(this.lvwComponentId, 4);
            this.lvwComponentId.Size = new System.Drawing.Size(395, 293);
            this.lvwComponentId.TabIndex = 33;
            this.lvwComponentId.UseCompatibleStateImageBehavior = false;
            this.lvwComponentId.View = System.Windows.Forms.View.Details;
            this.lvwComponentId.DoubleClick += new System.EventHandler(this.lvwComponentId_DoubleClick);
            this.lvwComponentId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvwComponentId_KeyUp);
            // 
            // colCarrierPosition
            // 
            this.colCarrierPosition.Tag = "position";
            this.colCarrierPosition.Text = "position";
            this.colCarrierPosition.Width = 66;
            // 
            // colCarrierComponentId
            // 
            this.colCarrierComponentId.Tag = "componentId";
            this.colCarrierComponentId.Text = "ComponentId";
            this.colCarrierComponentId.Width = 172;
            // 
            // WIPComponentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tblEditComponent);
            this.Controls.Add(this.tblCarrierInfo);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WIPComponentInformation";
            this.Size = new System.Drawing.Size(444, 383);
            this.tblCarrierInfo.ResumeLayout(false);
            this.tblCarrierInfo.PerformLayout();
            this.tblEditComponent.ResumeLayout(false);
            this.tblEditComponent.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCarrierInfo;
        private System.Windows.Forms.TextBox txtCarrierQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCarrierId;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDeleteComponent;
        private System.Windows.Forms.TableLayoutPanel tblEditComponent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListView lvwComponentId;
        private System.Windows.Forms.ColumnHeader colCarrierPosition;
        private System.Windows.Forms.ColumnHeader colCarrierComponentId;
        private System.Windows.Forms.ComboBox cboComponentId;
        private System.Windows.Forms.ImageList imageList1;
    }
}
