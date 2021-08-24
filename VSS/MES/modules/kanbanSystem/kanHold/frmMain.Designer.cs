namespace kanHold
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
            this.lblFab = new System.Windows.Forms.Label();
            this.txtFab = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHoldCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colLotId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStepId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReasonCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoldUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoldDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimeLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFab
            // 
            this.lblFab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFab.AutoSize = true;
            this.lblFab.Location = new System.Drawing.Point(7, 11);
            this.lblFab.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(54, 29);
            this.lblFab.TabIndex = 0;
            this.lblFab.Tag = "fab";
            this.lblFab.Text = "Fab";
            // 
            // txtFab
            // 
            this.txtFab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFab.Location = new System.Drawing.Point(73, 5);
            this.txtFab.Margin = new System.Windows.Forms.Padding(5);
            this.txtFab.Name = "txtFab";
            this.txtFab.ReadOnly = true;
            this.txtFab.Size = new System.Drawing.Size(331, 42);
            this.txtFab.TabIndex = 1;
            this.txtFab.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtHoldCount, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFab, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFab, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 52);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtHoldCount
            // 
            this.txtHoldCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHoldCount.Location = new System.Drawing.Point(571, 5);
            this.txtHoldCount.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoldCount.Name = "txtHoldCount";
            this.txtHoldCount.ReadOnly = true;
            this.txtHoldCount.Size = new System.Drawing.Size(130, 42);
            this.txtHoldCount.TabIndex = 3;
            this.txtHoldCount.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 4;
            this.label2.Tag = "count";
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 3;
            this.label1.Tag = "hold";
            this.label1.Text = "Hold";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLotId,
            this.colStepId,
            this.colReasonCode,
            this.colComments,
            this.colHoldUser,
            this.colHoldDate,
            this.colTimeLast});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 52);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1220, 528);
            this.listView1.TabIndex = 3;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colLotId
            // 
            this.colLotId.Tag = "lotId";
            this.colLotId.Text = "LotId";
            this.colLotId.Width = 200;
            // 
            // colStepId
            // 
            this.colStepId.Tag = "stepId";
            this.colStepId.Text = "StepId";
            this.colStepId.Width = 150;
            // 
            // colReasonCode
            // 
            this.colReasonCode.Tag = "reasonCode";
            this.colReasonCode.Text = "ReasonCode";
            this.colReasonCode.Width = 120;
            // 
            // colComments
            // 
            this.colComments.Tag = "comments";
            this.colComments.Text = "Comments";
            // 
            // colHoldUser
            // 
            this.colHoldUser.Tag = "holdUser";
            this.colHoldUser.Text = "HoldUser";
            this.colHoldUser.Width = 100;
            // 
            // colHoldDate
            // 
            this.colHoldDate.Tag = "holdDate";
            this.colHoldDate.Text = "HoldDate";
            this.colHoldDate.Width = 190;
            // 
            // colTimeLast
            // 
            this.colTimeLast.Tag = "timeLast";
            this.colTimeLast.Text = "HoldTime";
            this.colTimeLast.Width = 90;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 580);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.TextBox txtFab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtHoldCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colLotId;
        private System.Windows.Forms.ColumnHeader colStepId;
        private System.Windows.Forms.ColumnHeader colReasonCode;
        private System.Windows.Forms.ColumnHeader colHoldUser;
        private System.Windows.Forms.ColumnHeader colHoldDate;
        private System.Windows.Forms.ColumnHeader colTimeLast;
        private System.Windows.Forms.ColumnHeader colComments;
    }
}