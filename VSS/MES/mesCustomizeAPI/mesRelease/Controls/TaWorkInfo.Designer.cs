namespace mesRelease.Controls
{
    partial class TaWorkInformation
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tblStepEquipment = new System.Windows.Forms.TableLayoutPanel();
            this.txtEquipmentId = new System.Windows.Forms.TextBox();
            this.txtStepId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwStation = new System.Windows.Forms.ListView();
            this.colStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblStepEquipment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblStepEquipment
            // 
            this.tblStepEquipment.ColumnCount = 5;
            this.tblStepEquipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblStepEquipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblStepEquipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblStepEquipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblStepEquipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblStepEquipment.Controls.Add(this.txtEquipmentId, 3, 0);
            this.tblStepEquipment.Controls.Add(this.txtStepId, 1, 0);
            this.tblStepEquipment.Controls.Add(this.label2, 2, 0);
            this.tblStepEquipment.Controls.Add(this.label1, 0, 0);
            this.tblStepEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblStepEquipment.Location = new System.Drawing.Point(0, 0);
            this.tblStepEquipment.Name = "tblStepEquipment";
            this.tblStepEquipment.RowCount = 1;
            this.tblStepEquipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStepEquipment.Size = new System.Drawing.Size(283, 30);
            this.tblStepEquipment.TabIndex = 0;
            this.tblStepEquipment.Visible = false;
            // 
            // txtEquipmentId
            // 
            this.txtEquipmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquipmentId.Location = new System.Drawing.Point(185, 4);
            this.txtEquipmentId.Name = "txtEquipmentId";
            this.txtEquipmentId.ReadOnly = true;
            this.txtEquipmentId.Size = new System.Drawing.Size(94, 21);
            this.txtEquipmentId.TabIndex = 2;
            // 
            // txtStepId
            // 
            this.txtStepId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStepId.Location = new System.Drawing.Point(38, 4);
            this.txtStepId.Name = "txtStepId";
            this.txtStepId.ReadOnly = true;
            this.txtStepId.Size = new System.Drawing.Size(76, 21);
            this.txtStepId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Tag = "equipmentId";
            this.label2.Text = "Equipment";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Tag = "step";
            this.label1.Text = "Step";
            // 
            // lvwStation
            // 
            this.lvwStation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStation,
            this.colUserId,
            this.colUserName});
            this.lvwStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwStation.FullRowSelect = true;
            this.lvwStation.Location = new System.Drawing.Point(0, 0);
            this.lvwStation.MultiSelect = false;
            this.lvwStation.Name = "lvwStation";
            this.lvwStation.Size = new System.Drawing.Size(283, 106);
            this.lvwStation.TabIndex = 1;
            this.lvwStation.UseCompatibleStateImageBehavior = false;
            this.lvwStation.View = System.Windows.Forms.View.Details;
            // 
            // colStation
            // 
            this.colStation.Tag = "station";
            this.colStation.Text = "Station";
            this.colStation.Width = 80;
            // 
            // colUserId
            // 
            this.colUserId.Tag = "userId";
            this.colUserId.Text = "UserId";
            this.colUserId.Width = 71;
            // 
            // colUserName
            // 
            this.colUserName.Tag = "userName";
            this.colUserName.Text = "UserName";
            this.colUserName.Width = 120;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(263, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 20);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "…";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lvwStation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 106);
            this.panel1.TabIndex = 4;
            // 
            // TaWorkInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblStepEquipment);
            this.Name = "TaWorkInformation";
            this.Size = new System.Drawing.Size(283, 136);
            this.tblStepEquipment.ResumeLayout(false);
            this.tblStepEquipment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblStepEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEquipmentId;
        private System.Windows.Forms.TextBox txtStepId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwStation;
        private System.Windows.Forms.ColumnHeader colStation;
        private System.Windows.Forms.ColumnHeader colUserId;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
    }
}
