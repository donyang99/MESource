namespace ClientRule.LotProperty
{
    partial class frmHistoryDetail
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
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.rule_result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTxnQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtParentLotId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.modify_date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.step_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.equipment_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lot_id = new System.Windows.Forms.TextBox();
            this.lvwChildLot = new System.Windows.Forms.ListView();
            this.colChildLotId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabDetail = new System.Windows.Forms.TabControl();
            this.pagDetail = new System.Windows.Forms.TabPage();
            this.grpReason = new System.Windows.Forms.GroupBox();
            this.tblReason = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReasonCode = new System.Windows.Forms.TextBox();
            this.pagMembers = new System.Windows.Forms.TabPage();
            this.lvwComponents = new System.Windows.Forms.ListView();
            this.colComponentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComCarrierId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIntegrity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblEqParameter = new System.Windows.Forms.TableLayoutPanel();
            this.grpEqParameter = new System.Windows.Forms.GroupBox();
            this.tblDetail.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.pagDetail.SuspendLayout();
            this.grpReason.SuspendLayout();
            this.tblReason.SuspendLayout();
            this.pagMembers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpEqParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 4;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDetail.Controls.Add(this.rule_result, 3, 5);
            this.tblDetail.Controls.Add(this.label5, 2, 5);
            this.tblDetail.Controls.Add(this.label11, 2, 2);
            this.tblDetail.Controls.Add(this.txtTxnQty, 3, 1);
            this.tblDetail.Controls.Add(this.label10, 2, 1);
            this.tblDetail.Controls.Add(this.txtParentLotId, 3, 0);
            this.tblDetail.Controls.Add(this.label9, 2, 0);
            this.tblDetail.Controls.Add(this.modify_date, 1, 6);
            this.tblDetail.Controls.Add(this.label8, 0, 6);
            this.tblDetail.Controls.Add(this.quantity, 1, 5);
            this.tblDetail.Controls.Add(this.label7, 0, 5);
            this.tblDetail.Controls.Add(this.txtUserName, 1, 4);
            this.tblDetail.Controls.Add(this.label6, 0, 4);
            this.tblDetail.Controls.Add(this.step_id, 1, 3);
            this.tblDetail.Controls.Add(this.label4, 0, 3);
            this.tblDetail.Controls.Add(this.equipment_id, 1, 2);
            this.tblDetail.Controls.Add(this.label3, 0, 2);
            this.tblDetail.Controls.Add(this.activity, 1, 1);
            this.tblDetail.Controls.Add(this.label2, 0, 1);
            this.tblDetail.Controls.Add(this.label1, 0, 0);
            this.tblDetail.Controls.Add(this.lot_id, 1, 0);
            this.tblDetail.Controls.Add(this.lvwChildLot, 3, 2);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Location = new System.Drawing.Point(3, 3);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 7;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(597, 236);
            this.tblDetail.TabIndex = 8;
            // 
            // rule_result
            // 
            this.rule_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rule_result.Location = new System.Drawing.Point(391, 175);
            this.rule_result.Name = "rule_result";
            this.rule_result.ReadOnly = true;
            this.rule_result.Size = new System.Drawing.Size(203, 26);
            this.rule_result.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 14;
            this.label5.Tag = "ruleResult";
            this.label5.Text = "Result";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 11;
            this.label11.Tag = "childLotId";
            this.label11.Text = "ChildLotId";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTxnQty
            // 
            this.txtTxnQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTxnQty.Location = new System.Drawing.Point(391, 35);
            this.txtTxnQty.Name = "txtTxnQty";
            this.txtTxnQty.ReadOnly = true;
            this.txtTxnQty.Size = new System.Drawing.Size(203, 26);
            this.txtTxnQty.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 11;
            this.label10.Tag = "quantity";
            this.label10.Text = "quantity";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtParentLotId
            // 
            this.txtParentLotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentLotId.Location = new System.Drawing.Point(391, 3);
            this.txtParentLotId.Name = "txtParentLotId";
            this.txtParentLotId.ReadOnly = true;
            this.txtParentLotId.Size = new System.Drawing.Size(203, 26);
            this.txtParentLotId.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 10;
            this.label9.Tag = "parentLotId";
            this.label9.Text = "ParentLotId";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modify_date
            // 
            this.modify_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_date.Location = new System.Drawing.Point(81, 207);
            this.modify_date.Name = "modify_date";
            this.modify_date.ReadOnly = true;
            this.modify_date.Size = new System.Drawing.Size(202, 26);
            this.modify_date.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 14;
            this.label8.Tag = "date";
            this.label8.Text = "Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.Location = new System.Drawing.Point(81, 175);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(202, 26);
            this.quantity.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 13;
            this.label7.Tag = "quantity";
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(81, 137);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(202, 26);
            this.txtUserName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 12;
            this.label6.Tag = "user";
            this.label6.Text = "User";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // step_id
            // 
            this.step_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.step_id.Location = new System.Drawing.Point(81, 99);
            this.step_id.Name = "step_id";
            this.step_id.ReadOnly = true;
            this.step_id.Size = new System.Drawing.Size(202, 26);
            this.step_id.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Tag = "step";
            this.label4.Text = "Step";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equipment_id
            // 
            this.equipment_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.equipment_id.Location = new System.Drawing.Point(81, 67);
            this.equipment_id.Name = "equipment_id";
            this.equipment_id.ReadOnly = true;
            this.equipment_id.Size = new System.Drawing.Size(202, 26);
            this.equipment_id.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Tag = "location";
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // activity
            // 
            this.activity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.activity.Location = new System.Drawing.Point(81, 35);
            this.activity.Name = "activity";
            this.activity.ReadOnly = true;
            this.activity.Size = new System.Drawing.Size(202, 26);
            this.activity.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Tag = "activity";
            this.label2.Text = "Activity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Tag = "lotId";
            this.label1.Text = "LotId";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lot_id
            // 
            this.lot_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lot_id.Location = new System.Drawing.Point(81, 3);
            this.lot_id.Name = "lot_id";
            this.lot_id.ReadOnly = true;
            this.lot_id.Size = new System.Drawing.Size(202, 26);
            this.lot_id.TabIndex = 1;
            // 
            // lvwChildLot
            // 
            this.lvwChildLot.BackColor = System.Drawing.SystemColors.Control;
            this.lvwChildLot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colChildLotId,
            this.colQuantity});
            this.lvwChildLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwChildLot.FullRowSelect = true;
            this.lvwChildLot.Location = new System.Drawing.Point(391, 67);
            this.lvwChildLot.Name = "lvwChildLot";
            this.tblDetail.SetRowSpan(this.lvwChildLot, 3);
            this.lvwChildLot.Size = new System.Drawing.Size(203, 102);
            this.lvwChildLot.TabIndex = 18;
            this.lvwChildLot.UseCompatibleStateImageBehavior = false;
            this.lvwChildLot.View = System.Windows.Forms.View.Details;
            // 
            // colChildLotId
            // 
            this.colChildLotId.Tag = "childLotId";
            this.colChildLotId.Text = "ChildLotId";
            this.colChildLotId.Width = 121;
            // 
            // colQuantity
            // 
            this.colQuantity.Tag = "quantity";
            this.colQuantity.Text = "Quantity";
            this.colQuantity.Width = 54;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(531, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.pagDetail);
            this.tabDetail.Controls.Add(this.pagMembers);
            this.tabDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDetail.Location = new System.Drawing.Point(6, 6);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedIndex = 0;
            this.tabDetail.Size = new System.Drawing.Size(611, 387);
            this.tabDetail.TabIndex = 11;
            this.tabDetail.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabDetail_Selected);
            // 
            // pagDetail
            // 
            this.pagDetail.Controls.Add(this.grpReason);
            this.pagDetail.Controls.Add(this.tblDetail);
            this.pagDetail.Location = new System.Drawing.Point(4, 26);
            this.pagDetail.Name = "pagDetail";
            this.pagDetail.Padding = new System.Windows.Forms.Padding(3);
            this.pagDetail.Size = new System.Drawing.Size(603, 357);
            this.pagDetail.TabIndex = 0;
            this.pagDetail.Tag = "detail";
            this.pagDetail.Text = "Detail";
            this.pagDetail.UseVisualStyleBackColor = true;
            // 
            // grpReason
            // 
            this.grpReason.AutoSize = true;
            this.grpReason.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpReason.Controls.Add(this.tblReason);
            this.grpReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpReason.Location = new System.Drawing.Point(3, 239);
            this.grpReason.Name = "grpReason";
            this.grpReason.Size = new System.Drawing.Size(597, 113);
            this.grpReason.TabIndex = 11;
            this.grpReason.TabStop = false;
            this.grpReason.Tag = "";
            // 
            // tblReason
            // 
            this.tblReason.AutoSize = true;
            this.tblReason.ColumnCount = 2;
            this.tblReason.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblReason.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblReason.Controls.Add(this.label12, 0, 0);
            this.tblReason.Controls.Add(this.txtComments, 1, 1);
            this.tblReason.Controls.Add(this.label13, 0, 1);
            this.tblReason.Controls.Add(this.txtReasonCode, 1, 0);
            this.tblReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblReason.Location = new System.Drawing.Point(3, 22);
            this.tblReason.Name = "tblReason";
            this.tblReason.RowCount = 2;
            this.tblReason.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblReason.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblReason.Size = new System.Drawing.Size(591, 88);
            this.tblReason.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 0;
            this.label12.Tag = "ReasonCode";
            this.label12.Text = "ReasonCode";
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComments.Location = new System.Drawing.Point(97, 35);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(491, 50);
            this.txtComments.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 3;
            this.label13.Tag = "comments";
            this.label13.Text = "Comments";
            // 
            // txtReasonCode
            // 
            this.txtReasonCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReasonCode.Location = new System.Drawing.Point(97, 3);
            this.txtReasonCode.Name = "txtReasonCode";
            this.txtReasonCode.ReadOnly = true;
            this.txtReasonCode.Size = new System.Drawing.Size(491, 26);
            this.txtReasonCode.TabIndex = 2;
            // 
            // pagMembers
            // 
            this.pagMembers.Controls.Add(this.lvwComponents);
            this.pagMembers.Location = new System.Drawing.Point(4, 22);
            this.pagMembers.Name = "pagMembers";
            this.pagMembers.Padding = new System.Windows.Forms.Padding(3);
            this.pagMembers.Size = new System.Drawing.Size(603, 394);
            this.pagMembers.TabIndex = 1;
            this.pagMembers.Tag = "members";
            this.pagMembers.Text = "members";
            this.pagMembers.UseVisualStyleBackColor = true;
            // 
            // lvwComponents
            // 
            this.lvwComponents.BackColor = System.Drawing.SystemColors.Control;
            this.lvwComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colComponentId,
            this.colComCarrierId,
            this.colPosition,
            this.colIntegrity});
            this.lvwComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwComponents.FullRowSelect = true;
            this.lvwComponents.Location = new System.Drawing.Point(3, 3);
            this.lvwComponents.Name = "lvwComponents";
            this.lvwComponents.Size = new System.Drawing.Size(597, 388);
            this.lvwComponents.TabIndex = 22;
            this.lvwComponents.UseCompatibleStateImageBehavior = false;
            this.lvwComponents.View = System.Windows.Forms.View.Details;
            // 
            // colComponentId
            // 
            this.colComponentId.Tag = "componentId";
            this.colComponentId.Text = "componentId";
            this.colComponentId.Width = 134;
            // 
            // colComCarrierId
            // 
            this.colComCarrierId.Tag = "carrierId";
            this.colComCarrierId.Text = "CarrierId";
            this.colComCarrierId.Width = 100;
            // 
            // colPosition
            // 
            this.colPosition.Tag = "position";
            this.colPosition.Text = "position";
            this.colPosition.Width = 98;
            // 
            // colIntegrity
            // 
            this.colIntegrity.Tag = "integrity";
            this.colIntegrity.Text = "integrity";
            this.colIntegrity.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 53);
            this.panel1.TabIndex = 12;
            // 
            // tblEqParameter
            // 
            this.tblEqParameter.AutoSize = true;
            this.tblEqParameter.ColumnCount = 4;
            this.tblEqParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblEqParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEqParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblEqParameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblEqParameter.Location = new System.Drawing.Point(3, 22);
            this.tblEqParameter.Name = "tblEqParameter";
            this.tblEqParameter.RowCount = 1;
            this.tblEqParameter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEqParameter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEqParameter.Size = new System.Drawing.Size(605, 0);
            this.tblEqParameter.TabIndex = 13;
            // 
            // grpEqParameter
            // 
            this.grpEqParameter.AutoSize = true;
            this.grpEqParameter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpEqParameter.Controls.Add(this.tblEqParameter);
            this.grpEqParameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEqParameter.ForeColor = System.Drawing.Color.Blue;
            this.grpEqParameter.Location = new System.Drawing.Point(6, 393);
            this.grpEqParameter.Name = "grpEqParameter";
            this.grpEqParameter.Size = new System.Drawing.Size(611, 25);
            this.grpEqParameter.TabIndex = 14;
            this.grpEqParameter.TabStop = false;
            this.grpEqParameter.Tag = "eqParameter";
            this.grpEqParameter.Text = "EqParameter";
            // 
            // frmHistoryDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(623, 514);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpEqParameter);
            this.Controls.Add(this.tabDetail);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(625, 0);
            this.Name = "frmHistoryDetail";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.tabDetail.ResumeLayout(false);
            this.pagDetail.ResumeLayout(false);
            this.pagDetail.PerformLayout();
            this.grpReason.ResumeLayout(false);
            this.grpReason.PerformLayout();
            this.tblReason.ResumeLayout(false);
            this.tblReason.PerformLayout();
            this.pagMembers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpEqParameter.ResumeLayout(false);
            this.grpEqParameter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.TextBox equipment_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox activity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lot_id;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox step_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modify_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTxnQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtParentLotId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvwChildLot;
        private System.Windows.Forms.ColumnHeader colChildLotId;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.TabControl tabDetail;
        private System.Windows.Forms.TabPage pagDetail;
        private System.Windows.Forms.TabPage pagMembers;
        private System.Windows.Forms.GroupBox grpReason;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReasonCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lvwComponents;
        private System.Windows.Forms.ColumnHeader colComponentId;
        private System.Windows.Forms.ColumnHeader colComCarrierId;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colIntegrity;
        private System.Windows.Forms.TextBox rule_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblEqParameter;
        private System.Windows.Forms.GroupBox grpEqParameter;
        private System.Windows.Forms.TableLayoutPanel tblReason;
    }
}