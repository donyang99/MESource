namespace mesBasicData
{
    partial class frmEditNode
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoExit = new System.Windows.Forms.RadioButton();
            this.rdoInterior = new System.Windows.Forms.RadioButton();
            this.rdoEntry = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIterate = new System.Windows.Forms.Label();
            this.txtIterate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancel.Location = new System.Drawing.Point(251, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Tag = "buttonCancel";
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOK.Location = new System.Drawing.Point(163, 0);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 33);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Tag = "buttonOK";
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Tag = "name";
            this.lblName.Text = "name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(73, 3);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(263, 26);
            this.txtName.TabIndex = 7;
            this.txtName.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoExit);
            this.groupBox1.Controls.Add(this.rdoInterior);
            this.groupBox1.Controls.Add(this.rdoEntry);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "nodeKind";
            this.groupBox1.Text = "NodeKind";
            // 
            // rdoExit
            // 
            this.rdoExit.AutoSize = true;
            this.rdoExit.Location = new System.Drawing.Point(182, 27);
            this.rdoExit.Name = "rdoExit";
            this.rdoExit.Size = new System.Drawing.Size(58, 20);
            this.rdoExit.TabIndex = 2;
            this.rdoExit.TabStop = true;
            this.rdoExit.Tag = "exitNode";
            this.rdoExit.Text = "Exit";
            this.rdoExit.UseVisualStyleBackColor = true;
            // 
            // rdoInterior
            // 
            this.rdoInterior.AutoSize = true;
            this.rdoInterior.Location = new System.Drawing.Point(96, 27);
            this.rdoInterior.Name = "rdoInterior";
            this.rdoInterior.Size = new System.Drawing.Size(90, 20);
            this.rdoInterior.TabIndex = 1;
            this.rdoInterior.TabStop = true;
            this.rdoInterior.Tag = "interiorNode";
            this.rdoInterior.Text = "Interior";
            this.rdoInterior.UseVisualStyleBackColor = true;
            // 
            // rdoEntry
            // 
            this.rdoEntry.AutoSize = true;
            this.rdoEntry.Location = new System.Drawing.Point(19, 27);
            this.rdoEntry.Name = "rdoEntry";
            this.rdoEntry.Size = new System.Drawing.Size(66, 20);
            this.rdoEntry.TabIndex = 0;
            this.rdoEntry.TabStop = true;
            this.rdoEntry.Tag = "entryNode";
            this.rdoEntry.Text = "Entry";
            this.rdoEntry.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 33);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtIterate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIterate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 64);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lblIterate
            // 
            this.lblIterate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIterate.AutoSize = true;
            this.lblIterate.Location = new System.Drawing.Point(3, 40);
            this.lblIterate.Name = "lblIterate";
            this.lblIterate.Size = new System.Drawing.Size(64, 16);
            this.lblIterate.TabIndex = 7;
            this.lblIterate.Tag = "iterate";
            this.lblIterate.Text = "iterate";
            // 
            // txtIterate
            // 
            this.txtIterate.Location = new System.Drawing.Point(73, 35);
            this.txtIterate.MaxLength = 2;
            this.txtIterate.Name = "txtIterate";
            this.txtIterate.Size = new System.Drawing.Size(60, 26);
            this.txtIterate.TabIndex = 6;
            this.txtIterate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HanlderNumericOnly);
            // 
            // frmEditNode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(339, 176);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditNode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "editNode";
            this.Text = "frmEditNode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoExit;
        private System.Windows.Forms.RadioButton rdoInterior;
        private System.Windows.Forms.RadioButton rdoEntry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtIterate;
        private System.Windows.Forms.Label lblIterate;
    }
}