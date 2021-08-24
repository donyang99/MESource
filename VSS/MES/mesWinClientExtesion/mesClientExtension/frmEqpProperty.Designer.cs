namespace mesWinClient.Ext
{
    partial class frmEqpProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEqpProperty));
            this.equipmentInformation1 = new mesRelease.Controls.EquipmentInformation();
            this.SuspendLayout();
            // 
            // equipmentInformation1
            // 
            this.equipmentInformation1.displayProperties = null;
            this.equipmentInformation1.displayPropertyTags = null;
            this.equipmentInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentInformation1.editable = false;
            this.equipmentInformation1.Location = new System.Drawing.Point(0, 0);
            this.equipmentInformation1.Name = "equipmentInformation1";
            this.equipmentInformation1.Size = new System.Drawing.Size(292, 273);
            this.equipmentInformation1.TabIndex = 0;
            // 
            // frmEqpProperty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.equipmentInformation1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEqpProperty";
            this.Tag = "EqProperty";
            this.Text = "frmEqpProperty";
            this.ResumeLayout(false);

        }

        #endregion

        private mesRelease.Controls.EquipmentInformation equipmentInformation1;
    }
}