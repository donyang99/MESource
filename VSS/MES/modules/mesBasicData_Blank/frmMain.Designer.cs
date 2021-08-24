namespace mesBasicDataBlank
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.functionTree1 = new idv.mesCore.Controls.FunctionTree();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 524);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.standardStatusbar1.Size = new System.Drawing.Size(817, 25);
            this.standardStatusbar1.TabIndex = 2;
            this.standardStatusbar1.Text = "standardStatusbar1";
            // 
            // functionTree1
            // 
            this.functionTree1.ColorForNonPermited = System.Drawing.Color.Gray;
            this.functionTree1.ColorForPermited = System.Drawing.Color.Black;
            this.functionTree1.Dock = System.Windows.Forms.DockStyle.Left;
            this.functionTree1.FunctionGroupColor = System.Drawing.Color.DarkBlue;
            this.functionTree1.hideNoPrivilegeItem = true;
            this.functionTree1.HideSelection = false;
            this.functionTree1.ImageIndex = 0;
            this.functionTree1.ImageList = this.imageList1;
            this.functionTree1.Location = new System.Drawing.Point(0, 0);
            this.functionTree1.Name = "functionTree1";
            this.functionTree1.privilegeStringPrefix = "";
            this.functionTree1.Scrollable = false;
            this.functionTree1.SelectedImageIndex = 0;
            this.functionTree1.ShowLines = false;
            this.functionTree1.ShowPlusMinus = false;
            this.functionTree1.ShowRootLines = false;
            this.functionTree1.Size = new System.Drawing.Size(252, 524);
            this.functionTree1.TabIndex = 3;
            this.functionTree1.TriggerBySingleClick = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon1.ico");
            this.imageList1.Images.SetKeyName(1, "Icon2.ico");
            this.imageList1.Images.SetKeyName(2, "car");
            this.imageList1.Images.SetKeyName(3, "carrier");
            this.imageList1.Images.SetKeyName(4, "cartype");
            this.imageList1.Images.SetKeyName(5, "area");
            this.imageList1.Images.SetKeyName(6, "Icon7.ico");
            this.imageList1.Images.SetKeyName(7, "fms");
            this.imageList1.Images.SetKeyName(8, "My Computer.Ico");
            this.imageList1.Images.SetKeyName(9, "Txt2.Ico");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(252, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 524);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 549);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.functionTree1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Tag = "mesBasicDataBlank";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.StandardStatusbar standardStatusbar1;
        private idv.mesCore.Controls.FunctionTree functionTree1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;

    }
}