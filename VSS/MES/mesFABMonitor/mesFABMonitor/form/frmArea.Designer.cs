namespace mesFABMonitor
{
    partial class frmArea
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "test",
            "desc"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("aaa");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            this.lvwArea = new System.Windows.Forms.ListView();
            this.colArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgSmall = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvwArea
            // 
            this.lvwArea.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArea,
            this.colDescription});
            this.lvwArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwArea.FullRowSelect = true;
            this.lvwArea.GridLines = true;
            this.lvwArea.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvwArea.Location = new System.Drawing.Point(0, 0);
            this.lvwArea.Name = "lvwArea";
            this.lvwArea.ShowGroups = false;
            this.lvwArea.Size = new System.Drawing.Size(292, 273);
            this.lvwArea.SmallImageList = this.imgSmall;
            this.lvwArea.TabIndex = 0;
            this.lvwArea.UseCompatibleStateImageBehavior = false;
            this.lvwArea.View = System.Windows.Forms.View.Details;
            this.lvwArea.DoubleClick += new System.EventHandler(this.lvwArea_DoubleClick);
            this.lvwArea.Resize += new System.EventHandler(this.lvwArea_Resize);
            // 
            // colArea
            // 
            this.colArea.Tag = "fabArea";
            this.colArea.Text = "Area";
            this.colArea.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Tag = "description";
            this.colDescription.Text = "Description";
            this.colDescription.Width = 89;
            // 
            // imgSmall
            // 
            this.imgSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSmall.ImageStream")));
            this.imgSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSmall.Images.SetKeyName(0, "error");
            this.imgSmall.Images.SetKeyName(1, "warn");
            this.imgSmall.Images.SetKeyName(2, "info");
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lvwArea);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArea";
            this.Tag = "fabArea";
            this.Text = "frmArea";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwArea;
        private System.Windows.Forms.ColumnHeader colArea;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ImageList imgSmall;


    }
}