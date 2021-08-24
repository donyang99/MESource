namespace mesFABMonitor
{
    partial class frmEqMonitor
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
            this.pnlFAB = new System.Windows.Forms.Panel();
            this.mnuPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuHideBGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFAB
            // 
            this.pnlFAB.AutoSize = true;
            this.pnlFAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFAB.ContextMenuStrip = this.mnuPanel;
            this.pnlFAB.Location = new System.Drawing.Point(28, 12);
            this.pnlFAB.Name = "pnlFAB";
            this.pnlFAB.Size = new System.Drawing.Size(262, 155);
            this.pnlFAB.TabIndex = 0;
            // 
            // mnuPanel
            // 
            this.mnuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHideBGToolStripMenuItem});
            this.mnuPanel.Name = "mnuPanel";
            this.mnuPanel.Size = new System.Drawing.Size(146, 26);
            // 
            // mnuHideBGToolStripMenuItem
            // 
            this.mnuHideBGToolStripMenuItem.Name = "mnuHideBGToolStripMenuItem";
            this.mnuHideBGToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.mnuHideBGToolStripMenuItem.Tag = "mnuHideBackgroundPicture";
            this.mnuHideBGToolStripMenuItem.Text = "mnuHideBG";
            this.mnuHideBGToolStripMenuItem.Click += new System.EventHandler(this.mnuHideBGToolStripMenuItem_Click);
            // 
            // frmEqMonitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(412, 179);
            this.Controls.Add(this.pnlFAB);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmEqMonitor";
            this.Text = "frmEqMonitor";
            this.mnuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pnlFAB;
        private System.Windows.Forms.ContextMenuStrip mnuPanel;
        private System.Windows.Forms.ToolStripMenuItem mnuHideBGToolStripMenuItem;


    }
}