namespace mesBasicData
{
    partial class frmLanguageMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanguageMap));
            this.txtKey = new System.Windows.Forms.TextBox();
            this.tblLanguage = new System.Windows.Forms.TableLayoutPanel();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lvwLanguage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.tblLanguage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKey.BackColor = System.Drawing.SystemColors.Info;
            this.txtKey.Location = new System.Drawing.Point(70, 3);
            this.txtKey.MaxLength = 50;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(194, 30);
            this.txtKey.TabIndex = 1;
            // 
            // tblLanguage
            // 
            this.tblLanguage.AutoSize = true;
            this.tblLanguage.ColumnCount = 2;
            this.tblLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLanguage.Controls.Add(this.txtLanguage, 1, 1);
            this.tblLanguage.Controls.Add(this.lblLanguage, 0, 1);
            this.tblLanguage.Controls.Add(this.txtKey, 1, 0);
            this.tblLanguage.Controls.Add(this.lblKey, 0, 0);
            this.tblLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLanguage.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLanguage.Location = new System.Drawing.Point(5, 23);
            this.tblLanguage.Margin = new System.Windows.Forms.Padding(5);
            this.tblLanguage.Name = "tblLanguage";
            this.tblLanguage.RowCount = 2;
            this.tblLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLanguage.Size = new System.Drawing.Size(426, 72);
            this.tblLanguage.TabIndex = 1;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.txtLanguage.Location = new System.Drawing.Point(70, 39);
            this.txtLanguage.MaxLength = 255;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(353, 30);
            this.txtLanguage.TabIndex = 12;
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLanguage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLanguage.Location = new System.Drawing.Point(3, 43);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 22);
            this.lblLanguage.TabIndex = 12;
            this.lblLanguage.Tag = "";
            this.lblLanguage.Text = "en-US";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblKey
            // 
            this.lblKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKey.AutoSize = true;
            this.lblKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKey.Location = new System.Drawing.Point(3, 7);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(41, 22);
            this.lblKey.TabIndex = 0;
            this.lblKey.Tag = "";
            this.lblKey.Text = "Key";
            this.lblKey.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lvwLanguage
            // 
            this.lvwLanguage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwLanguage.FullRowSelect = true;
            this.lvwLanguage.GridLines = true;
            this.lvwLanguage.HideSelection = false;
            this.lvwLanguage.Location = new System.Drawing.Point(0, 125);
            this.lvwLanguage.Margin = new System.Windows.Forms.Padding(5);
            this.lvwLanguage.MultiSelect = false;
            this.lvwLanguage.Name = "lvwLanguage";
            this.lvwLanguage.Size = new System.Drawing.Size(436, 390);
            this.lvwLanguage.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwLanguage.TabIndex = 11;
            this.lvwLanguage.Tag = "";
            this.lvwLanguage.UseCompatibleStateImageBehavior = false;
            this.lvwLanguage.View = System.Windows.Forms.View.Details;
            this.lvwLanguage.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwLanguage_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "en-US";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tblLanguage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(436, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(436, 25);
            this.actionToolbar1.TabIndex = 9;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmLanguageMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 515);
            this.Controls.Add(this.lvwLanguage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLanguageMap";
            this.Tag = "LanguageMap";
            this.Text = "frmLanguageMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLanguageMap_Load);
            this.Resize += new System.EventHandler(this.frmLanguageMap_Resize);
            this.tblLanguage.ResumeLayout(false);
            this.tblLanguage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TableLayoutPanel tblLanguage;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ListView lvwLanguage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}