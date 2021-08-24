namespace mesRelease.Controls
{
    partial class TrackOutType
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboPath = new System.Windows.Forms.ComboBox();
            this.rdoNG = new System.Windows.Forms.RadioButton();
            this.rdoOK = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cboPath, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoNG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoOK, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cboPath
            // 
            this.cboPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPath.Enabled = false;
            this.cboPath.FormattingEnabled = true;
            this.cboPath.Location = new System.Drawing.Point(131, 3);
            this.cboPath.Name = "cboPath";
            this.cboPath.Size = new System.Drawing.Size(78, 24);
            this.cboPath.TabIndex = 3;
            // 
            // rdoNG
            // 
            this.rdoNG.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoNG.AutoSize = true;
            this.rdoNG.Location = new System.Drawing.Point(67, 5);
            this.rdoNG.Name = "rdoNG";
            this.rdoNG.Size = new System.Drawing.Size(58, 20);
            this.rdoNG.TabIndex = 2;
            this.rdoNG.Tag = "trackOutNG";
            this.rdoNG.Text = "重工";
            this.rdoNG.UseVisualStyleBackColor = true;
            this.rdoNG.CheckedChanged += new System.EventHandler(this.rdoOK_CheckedChanged);
            // 
            // rdoOK
            // 
            this.rdoOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoOK.AutoSize = true;
            this.rdoOK.Checked = true;
            this.rdoOK.Location = new System.Drawing.Point(3, 5);
            this.rdoOK.Name = "rdoOK";
            this.rdoOK.Size = new System.Drawing.Size(58, 20);
            this.rdoOK.TabIndex = 1;
            this.rdoOK.TabStop = true;
            this.rdoOK.Tag = "trackOutOK";
            this.rdoOK.Text = "良品";
            this.rdoOK.UseVisualStyleBackColor = true;
            this.rdoOK.CheckedChanged += new System.EventHandler(this.rdoOK_CheckedChanged);
            // 
            // TrackOutType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TrackOutType";
            this.Size = new System.Drawing.Size(212, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboPath;
        private System.Windows.Forms.RadioButton rdoNG;
        private System.Windows.Forms.RadioButton rdoOK;
    }
}
