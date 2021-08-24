namespace mesWinClient.Ext
{
    partial class frmWorkInstruction
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
            if(disposing && (components != null))
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
            this.workingInstruction1 = new mesRelease.Controls.WorkingInstruction();
            this.SuspendLayout();
            // 
            // workingInstruction1
            // 
            this.workingInstruction1.autoSize = false;
            this.workingInstruction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workingInstruction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workingInstruction1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.workingInstruction1.isNowMinimum = false;
            this.workingInstruction1.Location = new System.Drawing.Point(0, 0);
            this.workingInstruction1.Multiline = true;
            this.workingInstruction1.Name = "workingInstruction1";
            this.workingInstruction1.ReadOnly = true;
            this.workingInstruction1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.workingInstruction1.Size = new System.Drawing.Size(538, 112);
            this.workingInstruction1.TabIndex = 6;
            // 
            // frmWorkInstruction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(538, 112);
            this.CloseButton = false;
            this.Controls.Add(this.workingInstruction1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmWorkInstruction";
            this.Tag = "workingInstruction";
            this.Text = "frmWorkInstruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mesRelease.Controls.WorkingInstruction workingInstruction1;
    }
}