namespace mesRelease.Controls
{
    partial class routeCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(routeCombo));
            this.cboStepId = new System.Windows.Forms.ComboBox();
            this.tvwStep = new System.Windows.Forms.TreeView();
            this.imgStep = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboStepId
            // 
            this.cboStepId.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboStepId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStepId.FormattingEnabled = true;
            this.cboStepId.Location = new System.Drawing.Point(0, 0);
            this.cboStepId.Margin = new System.Windows.Forms.Padding(4);
            this.cboStepId.MaxDropDownItems = 20;
            this.cboStepId.Name = "cboStepId";
            this.cboStepId.Size = new System.Drawing.Size(301, 24);
            this.cboStepId.TabIndex = 0;
            this.cboStepId.DropDown += new System.EventHandler(this.cboStepId_DropDown);
            this.cboStepId.SelectedIndexChanged += new System.EventHandler(this.cboStepId_SelectedIndexChanged);
            // 
            // tvwStep
            // 
            this.tvwStep.HideSelection = false;
            this.tvwStep.ImageIndex = 0;
            this.tvwStep.ImageList = this.imgStep;
            this.tvwStep.Location = new System.Drawing.Point(32, 36);
            this.tvwStep.Margin = new System.Windows.Forms.Padding(4);
            this.tvwStep.Name = "tvwStep";
            this.tvwStep.SelectedImageIndex = 0;
            this.tvwStep.Size = new System.Drawing.Size(140, 107);
            this.tvwStep.TabIndex = 0;
            this.tvwStep.Visible = false;
            this.tvwStep.DoubleClick += new System.EventHandler(this.tvwStep_DoubleClick);
            // 
            // imgStep
            // 
            this.imgStep.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgStep.ImageStream")));
            this.imgStep.TransparentColor = System.Drawing.Color.Transparent;
            this.imgStep.Images.SetKeyName(0, "route");
            this.imgStep.Images.SetKeyName(1, "step");
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(236, -1);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Tag = "buttonCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.SystemColors.Window;
            this.btnOK.Location = new System.Drawing.Point(173, -1);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // routeCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tvwStep);
            this.Controls.Add(this.cboStepId);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "routeCombo";
            this.Size = new System.Drawing.Size(301, 209);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStepId;
        private System.Windows.Forms.TreeView tvwStep;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        protected internal System.Windows.Forms.ImageList imgStep;
    }
}
