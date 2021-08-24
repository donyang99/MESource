namespace mesRelease.Controls
{
    partial class CarrierInformation
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
            this.tblInputCarrier = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCarrierId = new System.Windows.Forms.TextBox();
            this.txtCarrierQty = new System.Windows.Forms.TextBox();
            this.pnlEditCarrier = new System.Windows.Forms.Panel();
            this.btnIdentifyComponent = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDeleteCarrier = new System.Windows.Forms.Button();
            this.btnAddCarrier = new System.Windows.Forms.Button();
            this.lvwCarrier = new idv.mesCore.Controls.MESListView();
            this.tblInputCarrier.SuspendLayout();
            this.pnlEditCarrier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblInputCarrier
            // 
            this.tblInputCarrier.ColumnCount = 4;
            this.tblInputCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblInputCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInputCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblInputCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblInputCarrier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblInputCarrier.Controls.Add(this.label9, 0, 0);
            this.tblInputCarrier.Controls.Add(this.label10, 2, 0);
            this.tblInputCarrier.Controls.Add(this.txtCarrierId, 1, 0);
            this.tblInputCarrier.Controls.Add(this.txtCarrierQty, 3, 0);
            this.tblInputCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblInputCarrier.Location = new System.Drawing.Point(0, 0);
            this.tblInputCarrier.Name = "tblInputCarrier";
            this.tblInputCarrier.RowCount = 2;
            this.tblInputCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblInputCarrier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInputCarrier.Size = new System.Drawing.Size(257, 32);
            this.tblInputCarrier.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 12;
            this.label9.Tag = "carrierId";
            this.label9.Text = "carrierId";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 12);
            this.label10.TabIndex = 13;
            this.label10.Tag = "quantity";
            this.label10.Text = "quantity";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCarrierId
            // 
            this.txtCarrierId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarrierId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCarrierId.Location = new System.Drawing.Point(63, 3);
            this.txtCarrierId.MaxLength = 40;
            this.txtCarrierId.Name = "txtCarrierId";
            this.txtCarrierId.Size = new System.Drawing.Size(85, 22);
            this.txtCarrierId.TabIndex = 18;
            this.txtCarrierId.Enter += new System.EventHandler(this.txt_Enter_For_SelectAll);
            this.txtCarrierId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCarrierId_KeyUp);
            // 
            // txtCarrierQty
            // 
            this.txtCarrierQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarrierQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtCarrierQty.Location = new System.Drawing.Point(204, 3);
            this.txtCarrierQty.MaxLength = 4;
            this.txtCarrierQty.Name = "txtCarrierQty";
            this.txtCarrierQty.Size = new System.Drawing.Size(50, 22);
            this.txtCarrierQty.TabIndex = 19;
            this.txtCarrierQty.Enter += new System.EventHandler(this.txt_Enter_For_SelectAll);
            this.txtCarrierQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrierQty_KeyPress);
            this.txtCarrierQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCarrierQty_KeyUp);
            // 
            // pnlEditCarrier
            // 
            this.pnlEditCarrier.Controls.Add(this.btnIdentifyComponent);
            this.pnlEditCarrier.Controls.Add(this.btnModify);
            this.pnlEditCarrier.Controls.Add(this.btnDeleteCarrier);
            this.pnlEditCarrier.Controls.Add(this.btnAddCarrier);
            this.pnlEditCarrier.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEditCarrier.Location = new System.Drawing.Point(207, 32);
            this.pnlEditCarrier.Name = "pnlEditCarrier";
            this.pnlEditCarrier.Size = new System.Drawing.Size(50, 208);
            this.pnlEditCarrier.TabIndex = 18;
            // 
            // btnIdentifyComponent
            // 
            this.btnIdentifyComponent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIdentifyComponent.Location = new System.Drawing.Point(0, 84);
            this.btnIdentifyComponent.Name = "btnIdentifyComponent";
            this.btnIdentifyComponent.Size = new System.Drawing.Size(50, 28);
            this.btnIdentifyComponent.TabIndex = 3;
            this.btnIdentifyComponent.Tag = "members";
            this.btnIdentifyComponent.Text = "members";
            this.btnIdentifyComponent.UseVisualStyleBackColor = true;
            this.btnIdentifyComponent.Click += new System.EventHandler(this.btnIdentifyComponent_Click);
            // 
            // btnModify
            // 
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModify.Location = new System.Drawing.Point(0, 56);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(50, 28);
            this.btnModify.TabIndex = 2;
            this.btnModify.Tag = "modify";
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDeleteCarrier
            // 
            this.btnDeleteCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteCarrier.Location = new System.Drawing.Point(0, 28);
            this.btnDeleteCarrier.Name = "btnDeleteCarrier";
            this.btnDeleteCarrier.Size = new System.Drawing.Size(50, 28);
            this.btnDeleteCarrier.TabIndex = 1;
            this.btnDeleteCarrier.Tag = "delete";
            this.btnDeleteCarrier.Text = "Delete";
            this.btnDeleteCarrier.UseVisualStyleBackColor = true;
            this.btnDeleteCarrier.Click += new System.EventHandler(this.btnDeleteCarrier_Click);
            // 
            // btnAddCarrier
            // 
            this.btnAddCarrier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCarrier.Location = new System.Drawing.Point(0, 0);
            this.btnAddCarrier.Name = "btnAddCarrier";
            this.btnAddCarrier.Size = new System.Drawing.Size(50, 28);
            this.btnAddCarrier.TabIndex = 0;
            this.btnAddCarrier.Tag = "add";
            this.btnAddCarrier.Text = "Add";
            this.btnAddCarrier.UseVisualStyleBackColor = true;
            this.btnAddCarrier.Click += new System.EventHandler(this.btnAddCarrier_Click);
            // 
            // lvwCarrier
            // 
            this.lvwCarrier.allowUserFilter = false;
            this.lvwCarrier.allowUserSorting = true;
            this.lvwCarrier.careModifyDate = false;
            this.lvwCarrier.columnHide = null;
            this.lvwCarrier.columnNames = new string[] {
        "name",
        "componentQty",
        "capacity",
        "carrierType"};
            this.lvwCarrier.columnTags = new string[] {
        "carrierId",
        "quantity",
        "capacity",
        "carrierType"};
            this.lvwCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwCarrier.FullRowSelect = true;
            this.lvwCarrier.HideSelection = false;
            this.lvwCarrier.imageKeyColumn = "";
            this.lvwCarrier.keyPressSearch = false;
            this.lvwCarrier.keyPressSearchColumn = "";
            this.lvwCarrier.Location = new System.Drawing.Point(0, 32);
            this.lvwCarrier.makesureNewItemVisible = true;
            this.lvwCarrier.MultiSelect = false;
            this.lvwCarrier.Name = "lvwCarrier";
            this.lvwCarrier.Size = new System.Drawing.Size(207, 208);
            this.lvwCarrier.TabIndex = 19;
            this.lvwCarrier.UseCompatibleStateImageBehavior = false;
            this.lvwCarrier.View = System.Windows.Forms.View.Details;
            this.lvwCarrier.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwCarrier_MESItemSelectionChanged);
            this.lvwCarrier.DoubleClick += new System.EventHandler(this.lvwCarrier_DoubleClick);
            this.lvwCarrier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvwCarrier_KeyUp);
            // 
            // CarrierInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwCarrier);
            this.Controls.Add(this.pnlEditCarrier);
            this.Controls.Add(this.tblInputCarrier);
            this.Name = "CarrierInformation";
            this.Size = new System.Drawing.Size(257, 240);
            this.tblInputCarrier.ResumeLayout(false);
            this.tblInputCarrier.PerformLayout();
            this.pnlEditCarrier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblInputCarrier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCarrierId;
        private System.Windows.Forms.TextBox txtCarrierQty;
        private System.Windows.Forms.Panel pnlEditCarrier;
        private System.Windows.Forms.Button btnIdentifyComponent;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDeleteCarrier;
        private System.Windows.Forms.Button btnAddCarrier;
        private idv.mesCore.Controls.MESListView lvwCarrier;
    }
}
