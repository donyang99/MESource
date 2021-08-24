namespace SampleAutoExe
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
            this.btnSampleAutoExe = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkTmr = new System.Windows.Forms.CheckBox();
            this.chkPing = new System.Windows.Forms.CheckBox();
            this.lblLastDate = new System.Windows.Forms.Label();
            this.lblLastSender = new System.Windows.Forms.Label();
            this.txtEqId = new System.Windows.Forms.TextBox();
            this.rdoIDLE = new System.Windows.Forms.RadioButton();
            this.rdoDOWN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSampleAutoExe
            // 
            this.btnSampleAutoExe.Location = new System.Drawing.Point(12, 59);
            this.btnSampleAutoExe.Name = "btnSampleAutoExe";
            this.btnSampleAutoExe.Size = new System.Drawing.Size(111, 40);
            this.btnSampleAutoExe.TabIndex = 0;
            this.btnSampleAutoExe.Text = "ChangeEqState";
            this.btnSampleAutoExe.UseVisualStyleBackColor = true;
            this.btnSampleAutoExe.Click += new System.EventHandler(this.btnSampleAutoExe_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(211, 10);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(511, 352);
            this.treeView1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(639, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 26);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkTmr
            // 
            this.chkTmr.AutoSize = true;
            this.chkTmr.Location = new System.Drawing.Point(14, 312);
            this.chkTmr.Margin = new System.Windows.Forms.Padding(2);
            this.chkTmr.Name = "chkTmr";
            this.chkTmr.Size = new System.Drawing.Size(42, 16);
            this.chkTmr.TabIndex = 3;
            this.chkTmr.Text = "Tmr";
            this.chkTmr.UseVisualStyleBackColor = true;
            this.chkTmr.Visible = false;
            this.chkTmr.CheckedChanged += new System.EventHandler(this.chkTmr_CheckedChanged);
            // 
            // chkPing
            // 
            this.chkPing.AutoSize = true;
            this.chkPing.Location = new System.Drawing.Point(7, 346);
            this.chkPing.Margin = new System.Windows.Forms.Padding(2);
            this.chkPing.Name = "chkPing";
            this.chkPing.Size = new System.Drawing.Size(48, 16);
            this.chkPing.TabIndex = 4;
            this.chkPing.Text = "ping";
            this.chkPing.UseVisualStyleBackColor = true;
            this.chkPing.Visible = false;
            this.chkPing.CheckedChanged += new System.EventHandler(this.chkPing_CheckedChanged);
            // 
            // lblLastDate
            // 
            this.lblLastDate.AutoSize = true;
            this.lblLastDate.Location = new System.Drawing.Point(87, 350);
            this.lblLastDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastDate.Name = "lblLastDate";
            this.lblLastDate.Size = new System.Drawing.Size(53, 12);
            this.lblLastDate.TabIndex = 5;
            this.lblLastDate.Text = "LastTime";
            this.lblLastDate.Visible = false;
            // 
            // lblLastSender
            // 
            this.lblLastSender.AutoSize = true;
            this.lblLastSender.Location = new System.Drawing.Point(87, 312);
            this.lblLastSender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastSender.Name = "lblLastSender";
            this.lblLastSender.Size = new System.Drawing.Size(65, 12);
            this.lblLastSender.TabIndex = 6;
            this.lblLastSender.Text = "LastSender";
            this.lblLastSender.Visible = false;
            // 
            // txtEqId
            // 
            this.txtEqId.Location = new System.Drawing.Point(20, 13);
            this.txtEqId.Name = "txtEqId";
            this.txtEqId.Size = new System.Drawing.Size(82, 21);
            this.txtEqId.TabIndex = 7;
            this.txtEqId.Text = "PKG_01";
            // 
            // rdoIDLE
            // 
            this.rdoIDLE.AutoSize = true;
            this.rdoIDLE.Location = new System.Drawing.Point(120, 15);
            this.rdoIDLE.Name = "rdoIDLE";
            this.rdoIDLE.Size = new System.Drawing.Size(47, 16);
            this.rdoIDLE.TabIndex = 8;
            this.rdoIDLE.Text = "IDLE";
            this.rdoIDLE.UseVisualStyleBackColor = true;
            // 
            // rdoDOWN
            // 
            this.rdoDOWN.AutoSize = true;
            this.rdoDOWN.Checked = true;
            this.rdoDOWN.Location = new System.Drawing.Point(120, 37);
            this.rdoDOWN.Name = "rdoDOWN";
            this.rdoDOWN.Size = new System.Drawing.Size(47, 16);
            this.rdoDOWN.TabIndex = 9;
            this.rdoDOWN.TabStop = true;
            this.rdoDOWN.Text = "DOWN";
            this.rdoDOWN.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 399);
            this.Controls.Add(this.rdoDOWN);
            this.Controls.Add(this.rdoIDLE);
            this.Controls.Add(this.txtEqId);
            this.Controls.Add(this.lblLastSender);
            this.Controls.Add(this.lblLastDate);
            this.Controls.Add(this.chkPing);
            this.Controls.Add(this.chkTmr);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSampleAutoExe);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "SampleAutoExe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSampleAutoExe;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkTmr;
        private System.Windows.Forms.CheckBox chkPing;
        private System.Windows.Forms.Label lblLastDate;
        private System.Windows.Forms.Label lblLastSender;
        private System.Windows.Forms.TextBox txtEqId;
        private System.Windows.Forms.RadioButton rdoIDLE;
        private System.Windows.Forms.RadioButton rdoDOWN;
    }
}