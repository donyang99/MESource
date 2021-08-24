namespace mesRelease.Controls
{
    partial class frmSelectReason
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lvwReasonCode = new idv.mesCore.Controls.MESListView();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(554, 335);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Tag = "buttonCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(452, 335);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 41);
            this.btnOK.TabIndex = 5;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lvwReasonCode
            // 
            this.lvwReasonCode.allowUserFilter = false;
            this.lvwReasonCode.allowUserSorting = true;
            this.lvwReasonCode.autoSizeColumn = true;
            this.lvwReasonCode.careModifyDate = false;
            this.lvwReasonCode.columnHide = null;
            this.lvwReasonCode.columnNames = new string[] {
        "name",
        "description",
        "ownerDept"};
            this.lvwReasonCode.columnTags = new string[] {
        "ReasonCode",
        "description",
        "ownerDept"};
            this.lvwReasonCode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwReasonCode.FullRowSelect = true;
            this.lvwReasonCode.HideSelection = false;
            this.lvwReasonCode.imageKeyColumn = "";
            this.lvwReasonCode.keyPressSearch = false;
            this.lvwReasonCode.keyPressSearchColumn = "";
            this.lvwReasonCode.Location = new System.Drawing.Point(3, 9);
            this.lvwReasonCode.makesureNewItemVisible = true;
            this.lvwReasonCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwReasonCode.MultiSelect = false;
            this.lvwReasonCode.Name = "lvwReasonCode";
            this.lvwReasonCode.OwnerDraw = true;
            this.lvwReasonCode.ShowItemTipSecond = ((byte)(3));
            this.lvwReasonCode.Size = new System.Drawing.Size(650, 318);
            this.lvwReasonCode.TabIndex = 7;
            this.lvwReasonCode.UseCompatibleStateImageBehavior = false;
            this.lvwReasonCode.View = System.Windows.Forms.View.Details;
            this.lvwReasonCode.DoubleClick += new System.EventHandler(this.lvwReasonCode_DoubleClick);
            // 
            // frmSelectReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(657, 378);
            this.Controls.Add(this.lvwReasonCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSelectReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "selectReason";
            this.Text = "frmSelectReason";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private idv.mesCore.Controls.MESListView lvwReasonCode;
    }
}