namespace mesBasicData
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.functionTree1 = new idv.mesCore.Controls.FunctionTree();
            this.standardStatusbar1 = new idv.mesCore.Controls.StandardStatusbar();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(252, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 568);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AccessString2.png");
            this.imageList1.Images.SetKeyName(1, "Division2.png");
            this.imageList1.Images.SetKeyName(2, "Fab2222.png");
            this.imageList1.Images.SetKeyName(3, "backImage.jpg");
            this.imageList1.Images.SetKeyName(4, "carrier.png");
            this.imageList1.Images.SetKeyName(5, "carrierType.png");
            this.imageList1.Images.SetKeyName(6, "division.png");
            this.imageList1.Images.SetKeyName(7, "fab21.png");
            this.imageList1.Images.SetKeyName(8, "reasonCategory.png");
            this.imageList1.Images.SetKeyName(9, "reasonCode2.png");
            this.imageList1.Images.SetKeyName(10, "reasonCode.png");
            this.imageList1.Images.SetKeyName(11, "reasonGroup.png");
            this.imageList1.Images.SetKeyName(12, "user.png");
            this.imageList1.Images.SetKeyName(13, "userGroup.png");
            this.imageList1.Images.SetKeyName(14, "changeState.png");
            this.imageList1.Images.SetKeyName(15, "equipmentGroup.png");
            this.imageList1.Images.SetKeyName(16, "equipment.png");
            this.imageList1.Images.SetKeyName(17, "equipmentState.png");
            this.imageList1.Images.SetKeyName(18, "equipmentType.png");
            this.imageList1.Images.SetKeyName(19, "product.png");
            this.imageList1.Images.SetKeyName(20, "stepDC.png");
            this.imageList1.Images.SetKeyName(21, "step.png");
            this.imageList1.Images.SetKeyName(22, "stepGroup.png");
            this.imageList1.Images.SetKeyName(23, "stage.png");
            this.imageList1.Images.SetKeyName(24, "rule.png");
            this.imageList1.Images.SetKeyName(25, "fab.png");
            this.imageList1.Images.SetKeyName(26, "title.png");
            this.imageList1.Images.SetKeyName(27, "accessString.png");
            this.imageList1.Images.SetKeyName(28, "route.png");
            this.imageList1.Images.SetKeyName(29, "catComponentType.png");
            this.imageList1.Images.SetKeyName(30, "catStepCode.png");
            this.imageList1.Images.SetKeyName(31, "routeType");
            this.imageList1.Images.SetKeyName(32, "lottype.png");
            this.imageList1.Images.SetKeyName(33, "materialType");
            this.imageList1.Images.SetKeyName(34, "stepMaterial");
            this.imageList1.Images.SetKeyName(35, "parameter");
            this.imageList1.Images.SetKeyName(36, "productParameter");
            this.imageList1.Images.SetKeyName(37, "stepParameter");
            this.imageList1.Images.SetKeyName(38, "productSpec");
            this.imageList1.Images.SetKeyName(39, "productType");
            this.imageList1.Images.SetKeyName(40, "part");
            this.imageList1.Images.SetKeyName(41, "reasonType");
            this.imageList1.Images.SetKeyName(42, "language.png");
            this.imageList1.Images.SetKeyName(43, "eqParam");
            this.imageList1.Images.SetKeyName(44, "grantAccessString");
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
            this.functionTree1.ItemHeight = 20;
            this.functionTree1.Location = new System.Drawing.Point(0, 0);
            this.functionTree1.Name = "functionTree1";
            this.functionTree1.privilegeStringPrefix = "";
            this.functionTree1.SelectedImageIndex = 0;
            this.functionTree1.ShowLines = false;
            this.functionTree1.ShowPlusMinus = false;
            this.functionTree1.ShowRootLines = false;
            this.functionTree1.Size = new System.Drawing.Size(252, 568);
            this.functionTree1.TabIndex = 3;
            this.functionTree1.TriggerBySingleClick = false;
            // 
            // standardStatusbar1
            // 
            this.standardStatusbar1.errorBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.errorForeColor = System.Drawing.Color.Black;
            this.standardStatusbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardStatusbar1.Location = new System.Drawing.Point(0, 568);
            this.standardStatusbar1.Name = "standardStatusbar1";
            this.standardStatusbar1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.standardStatusbar1.Size = new System.Drawing.Size(1079, 25);
            this.standardStatusbar1.TabIndex = 2;
            this.standardStatusbar1.Text = "standardStatusbar1";
            this.standardStatusbar1.warnBackColor = System.Drawing.SystemColors.Control;
            this.standardStatusbar1.warnForeColor = System.Drawing.Color.Black;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 593);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.functionTree1);
            this.Controls.Add(this.standardStatusbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Tag = "mesBasicData";
            this.Text = "IDE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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