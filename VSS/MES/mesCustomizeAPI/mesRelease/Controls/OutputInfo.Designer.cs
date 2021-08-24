namespace mesRelease.Controls
{
    partial class OutputInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwOutputInfo = new System.Windows.Forms.ListView();
            this.colDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLotId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtLotCount = new System.Windows.Forms.TextBox();
            this.lblLotCount = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCurLot = new System.Windows.Forms.Label();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwOutputInfo
            // 
            this.lvwOutputInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDateTime,
            this.colLotId,
            this.colResult,
            this.colInfo});
            this.lvwOutputInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwOutputInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOutputInfo.FullRowSelect = true;
            this.lvwOutputInfo.Location = new System.Drawing.Point(0, 79);
            this.lvwOutputInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwOutputInfo.Name = "lvwOutputInfo";
            this.lvwOutputInfo.Size = new System.Drawing.Size(839, 173);
            this.lvwOutputInfo.TabIndex = 8;
            this.lvwOutputInfo.UseCompatibleStateImageBehavior = false;
            this.lvwOutputInfo.View = System.Windows.Forms.View.Details;
            this.lvwOutputInfo.Resize += new System.EventHandler(this.lvwOutputInfo_Resize);
            // 
            // colDateTime
            // 
            this.colDateTime.Tag = "processTime";
            this.colDateTime.Text = "作業時間";
            this.colDateTime.Width = 143;
            // 
            // colLotId
            // 
            this.colLotId.Tag = "lotId";
            this.colLotId.Text = "批號";
            this.colLotId.Width = 100;
            // 
            // colResult
            // 
            this.colResult.Tag = "alarmResult";
            this.colResult.Text = "結果";
            this.colResult.Width = 77;
            // 
            // colInfo
            // 
            this.colInfo.Tag = "information";
            this.colInfo.Text = "訊息";
            this.colInfo.Width = 63;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 56);
            this.panel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtTotalQuantity, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalQuantity, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLotCount, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLotCount, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInformation, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurLot, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLotId, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalQuantity.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQuantity.Location = new System.Drawing.Point(652, 13);
            this.txtTotalQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.ReadOnly = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(90, 26);
            this.txtTotalQuantity.TabIndex = 11;
            this.txtTotalQuantity.Visible = false;
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(603, 16);
            this.lblTotalQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(41, 19);
            this.lblTotalQuantity.TabIndex = 11;
            this.lblTotalQuantity.Tag = "quantity";
            this.lblTotalQuantity.Text = "數量";
            this.lblTotalQuantity.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReset.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(750, 6);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 39);
            this.btnReset.TabIndex = 10;
            this.btnReset.Tag = "reset";
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtLotCount
            // 
            this.txtLotCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLotCount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotCount.Location = new System.Drawing.Point(505, 13);
            this.txtLotCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLotCount.Name = "txtLotCount";
            this.txtLotCount.ReadOnly = true;
            this.txtLotCount.Size = new System.Drawing.Size(90, 26);
            this.txtLotCount.TabIndex = 10;
            // 
            // lblLotCount
            // 
            this.lblLotCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLotCount.AutoSize = true;
            this.lblLotCount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotCount.Location = new System.Drawing.Point(456, 16);
            this.lblLotCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLotCount.Name = "lblLotCount";
            this.lblLotCount.Size = new System.Drawing.Size(41, 19);
            this.lblLotCount.TabIndex = 10;
            this.lblLotCount.Tag = "lots";
            this.lblLotCount.Text = "批數";
            // 
            // txtInformation
            // 
            this.txtInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInformation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInformation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInformation.Location = new System.Drawing.Point(377, 13);
            this.txtInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            this.txtInformation.Size = new System.Drawing.Size(71, 26);
            this.txtInformation.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(332, 16);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(37, 19);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Tag = "";
            this.lblInfo.Text = "Info";
            // 
            // lblCurLot
            // 
            this.lblCurLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurLot.AutoSize = true;
            this.lblCurLot.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurLot.Location = new System.Drawing.Point(4, 16);
            this.lblCurLot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurLot.Name = "lblCurLot";
            this.lblCurLot.Size = new System.Drawing.Size(46, 19);
            this.lblCurLot.TabIndex = 0;
            this.lblCurLot.Tag = "lotId";
            this.lblCurLot.Text = "LotId";
            // 
            // txtLotId
            // 
            this.txtLotId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLotId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLotId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotId.Location = new System.Drawing.Point(58, 13);
            this.txtLotId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.ReadOnly = true;
            this.txtLotId.Size = new System.Drawing.Size(266, 26);
            this.txtLotId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(839, 23);
            this.label3.TabIndex = 7;
            this.label3.Tag = "";
            this.label3.Text = "生產信息";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwOutputInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OutputInfo";
            this.Size = new System.Drawing.Size(839, 252);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCurLot;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView lvwOutputInfo;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.ColumnHeader colDateTime;
        private System.Windows.Forms.ColumnHeader colLotId;
        private System.Windows.Forms.ColumnHeader colResult;
        private System.Windows.Forms.ColumnHeader colInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtLotCount;
        private System.Windows.Forms.Label lblLotCount;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label lblTotalQuantity;
    }
}
