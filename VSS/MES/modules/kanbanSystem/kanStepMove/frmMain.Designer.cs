namespace kanStepMove
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
            this.tlbStep = new System.Windows.Forms.TableLayoutPanel();
            this.txtTarget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFab = new System.Windows.Forms.Label();
            this.txtStepId = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStepLotCount = new System.Windows.Forms.Label();
            this.tblEqp = new System.Windows.Forms.TableLayoutPanel();
            this.txtEqpId = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStepQuantity = new System.Windows.Forms.Label();
            this.tlbStep.SuspendLayout();
            this.tblEqp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlbStep
            // 
            this.tlbStep.AutoSize = true;
            this.tlbStep.ColumnCount = 12;
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlbStep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlbStep.Controls.Add(this.label5, 8, 0);
            this.tlbStep.Controls.Add(this.txtFab, 1, 0);
            this.tlbStep.Controls.Add(this.txtStepId, 5, 0);
            this.tlbStep.Controls.Add(this.label4, 10, 0);
            this.tlbStep.Controls.Add(this.txtShift, 3, 0);
            this.tlbStep.Controls.Add(this.label3, 2, 0);
            this.tlbStep.Controls.Add(this.label1, 4, 0);
            this.tlbStep.Controls.Add(this.lblFab, 0, 0);
            this.tlbStep.Controls.Add(this.label2, 6, 0);
            this.tlbStep.Controls.Add(this.txtTarget, 11, 0);
            this.tlbStep.Controls.Add(this.txtStepLotCount, 7, 0);
            this.tlbStep.Controls.Add(this.txtStepQuantity, 9, 0);
            this.tlbStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlbStep.Location = new System.Drawing.Point(0, 0);
            this.tlbStep.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tlbStep.Name = "tlbStep";
            this.tlbStep.RowCount = 1;
            this.tlbStep.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlbStep.Size = new System.Drawing.Size(1287, 41);
            this.tlbStep.TabIndex = 3;
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTarget.AutoSize = true;
            this.txtTarget.ForeColor = System.Drawing.Color.Blue;
            this.txtTarget.Location = new System.Drawing.Point(836, 6);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(0);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(31, 29);
            this.txtTarget.TabIndex = 8;
            this.txtTarget.Tag = "";
            this.txtTarget.Text = "--";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(735, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 35);
            this.label4.TabIndex = 8;
            this.label4.Tag = "";
            this.label4.Text = "Target";
            // 
            // txtFab
            // 
            this.txtFab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFab.AutoSize = true;
            this.txtFab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFab.Location = new System.Drawing.Point(63, 0);
            this.txtFab.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtFab.Name = "txtFab";
            this.txtFab.Padding = new System.Windows.Forms.Padding(5);
            this.txtFab.Size = new System.Drawing.Size(66, 41);
            this.txtFab.TabIndex = 6;
            this.txtFab.Tag = "";
            this.txtFab.Text = "Fab";
            // 
            // txtStepId
            // 
            this.txtStepId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStepId.AutoSize = true;
            this.txtStepId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStepId.Location = new System.Drawing.Point(372, 0);
            this.txtStepId.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtStepId.Name = "txtStepId";
            this.txtStepId.Padding = new System.Windows.Forms.Padding(5);
            this.txtStepId.Size = new System.Drawing.Size(97, 41);
            this.txtStepId.TabIndex = 6;
            this.txtStepId.Tag = "";
            this.txtStepId.Text = "StepId";
            // 
            // txtShift
            // 
            this.txtShift.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtShift.AutoSize = true;
            this.txtShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShift.Location = new System.Drawing.Point(202, 0);
            this.txtShift.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtShift.Name = "txtShift";
            this.txtShift.Padding = new System.Windows.Forms.Padding(5);
            this.txtShift.Size = new System.Drawing.Size(79, 41);
            this.txtShift.TabIndex = 5;
            this.txtShift.Tag = "";
            this.txtShift.Text = "Shift";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 4;
            this.label3.Tag = "shift";
            this.label3.Text = "Shift";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 3;
            this.label1.Tag = "stepId";
            this.label1.Text = "StepId";
            // 
            // lblFab
            // 
            this.lblFab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFab.AutoSize = true;
            this.lblFab.Location = new System.Drawing.Point(3, 6);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(54, 29);
            this.lblFab.TabIndex = 0;
            this.lblFab.Tag = "fab";
            this.lblFab.Text = "Fab";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "LotCount";
            // 
            // txtStepLotCount
            // 
            this.txtStepLotCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStepLotCount.AutoSize = true;
            this.txtStepLotCount.BackColor = System.Drawing.Color.Green;
            this.txtStepLotCount.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStepLotCount.ForeColor = System.Drawing.Color.White;
            this.txtStepLotCount.Location = new System.Drawing.Point(592, 2);
            this.txtStepLotCount.Margin = new System.Windows.Forms.Padding(0);
            this.txtStepLotCount.Name = "txtStepLotCount";
            this.txtStepLotCount.Size = new System.Drawing.Size(51, 37);
            this.txtStepLotCount.TabIndex = 7;
            this.txtStepLotCount.Tag = "";
            this.txtStepLotCount.Text = "33";
            // 
            // tblEqp
            // 
            this.tblEqp.AutoSize = true;
            this.tblEqp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblEqp.ColumnCount = 8;
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqp.Controls.Add(this.txtEqpId, 1, 0);
            this.tblEqp.Controls.Add(this.txtState, 3, 0);
            this.tblEqp.Controls.Add(this.label10, 2, 0);
            this.tblEqp.Controls.Add(this.label12, 0, 0);
            this.tblEqp.Controls.Add(this.label13, 4, 0);
            this.tblEqp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblEqp.Location = new System.Drawing.Point(0, 49);
            this.tblEqp.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tblEqp.Name = "tblEqp";
            this.tblEqp.RowCount = 1;
            this.tblEqp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEqp.Size = new System.Drawing.Size(1287, 41);
            this.tblEqp.TabIndex = 4;
            // 
            // txtEqpId
            // 
            this.txtEqpId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEqpId.AutoSize = true;
            this.txtEqpId.Location = new System.Drawing.Point(92, 1);
            this.txtEqpId.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtEqpId.Name = "txtEqpId";
            this.txtEqpId.Padding = new System.Windows.Forms.Padding(5);
            this.txtEqpId.Size = new System.Drawing.Size(77, 39);
            this.txtEqpId.TabIndex = 6;
            this.txtEqpId.Tag = "";
            this.txtEqpId.Text = "EqId";
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtState.AutoSize = true;
            this.txtState.Location = new System.Drawing.Point(245, 1);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.txtState.Name = "txtState";
            this.txtState.Padding = new System.Windows.Forms.Padding(5);
            this.txtState.Size = new System.Drawing.Size(74, 39);
            this.txtState.TabIndex = 5;
            this.txtState.Tag = "";
            this.txtState.Text = "state";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 29);
            this.label10.TabIndex = 4;
            this.label10.Tag = "state";
            this.label10.Text = "State";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 29);
            this.label12.TabIndex = 0;
            this.label12.Tag = "equipmentId";
            this.label12.Text = "EqpId";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(323, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 29);
            this.label13.TabIndex = 4;
            this.label13.Tag = "count";
            this.label13.Text = "Count";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(0, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1287, 8);
            this.label15.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 29);
            this.label5.TabIndex = 6;
            this.label5.Tag = "quantity";
            this.label5.Text = "Qty";
            // 
            // txtStepQuantity
            // 
            this.txtStepQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStepQuantity.AutoSize = true;
            this.txtStepQuantity.BackColor = System.Drawing.Color.Blue;
            this.txtStepQuantity.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStepQuantity.ForeColor = System.Drawing.Color.White;
            this.txtStepQuantity.Location = new System.Drawing.Point(701, 2);
            this.txtStepQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtStepQuantity.Name = "txtStepQuantity";
            this.txtStepQuantity.Size = new System.Drawing.Size(34, 37);
            this.txtStepQuantity.TabIndex = 8;
            this.txtStepQuantity.Tag = "";
            this.txtStepQuantity.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 478);
            this.Controls.Add(this.tblEqp);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tlbStep);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("PMingLiU", 21.75F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tlbStep.ResumeLayout(false);
            this.tlbStep.PerformLayout();
            this.tblEqp.ResumeLayout(false);
            this.tblEqp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlbStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtShift;
        private System.Windows.Forms.Label txtFab;
        private System.Windows.Forms.Label txtStepId;
        private System.Windows.Forms.Label txtStepLotCount;
        private System.Windows.Forms.Label txtTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tblEqp;
        private System.Windows.Forms.Label txtEqpId;
        private System.Windows.Forms.Label txtState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtStepQuantity;

    }
}