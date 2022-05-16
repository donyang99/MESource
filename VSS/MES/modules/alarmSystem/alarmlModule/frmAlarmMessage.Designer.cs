namespace alarmModule
{
    partial class frmAlarmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlarmMessage));
            this.cboAlarmStatus = new System.Windows.Forms.ComboBox();
            this.lblAlarmStatus = new System.Windows.Forms.Label();
            this.lblAlarmType = new System.Windows.Forms.Label();
            this.lblObjectId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.cboObjectType = new System.Windows.Forms.ComboBox();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.txtObjectId = new System.Windows.Forms.TextBox();
            this.cboAlarmType = new System.Windows.Forms.ComboBox();
            this.lblReasonCode = new System.Windows.Forms.Label();
            this.cboAlarmReason = new System.Windows.Forms.ComboBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.lvwAlarmMessage = new idv.mesCore.Controls.MESListView();
            this.groupBox1.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAlarmStatus
            // 
            this.cboAlarmStatus.FormattingEnabled = true;
            this.cboAlarmStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboAlarmStatus.Location = new System.Drawing.Point(666, 3);
            this.cboAlarmStatus.MaxLength = 40;
            this.cboAlarmStatus.Name = "cboAlarmStatus";
            this.cboAlarmStatus.Size = new System.Drawing.Size(136, 28);
            this.cboAlarmStatus.TabIndex = 1;
            // 
            // lblAlarmStatus
            // 
            this.lblAlarmStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlarmStatus.AutoSize = true;
            this.lblAlarmStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlarmStatus.Location = new System.Drawing.Point(539, 6);
            this.lblAlarmStatus.Name = "lblAlarmStatus";
            this.lblAlarmStatus.Size = new System.Drawing.Size(121, 22);
            this.lblAlarmStatus.TabIndex = 9;
            this.lblAlarmStatus.Tag = "status";
            this.lblAlarmStatus.Text = "AlarmStatus";
            // 
            // lblAlarmType
            // 
            this.lblAlarmType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlarmType.AutoSize = true;
            this.lblAlarmType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlarmType.Location = new System.Drawing.Point(3, 6);
            this.lblAlarmType.Name = "lblAlarmType";
            this.lblAlarmType.Size = new System.Drawing.Size(91, 22);
            this.lblAlarmType.TabIndex = 2;
            this.lblAlarmType.Tag = "alarmType";
            this.lblAlarmType.Text = "報警類型";
            // 
            // lblObjectId
            // 
            this.lblObjectId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObjectId.AutoSize = true;
            this.lblObjectId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObjectId.Location = new System.Drawing.Point(3, 41);
            this.lblObjectId.Name = "lblObjectId";
            this.lblObjectId.Size = new System.Drawing.Size(91, 22);
            this.lblObjectId.TabIndex = 3;
            this.lblObjectId.Tag = "objectId";
            this.lblObjectId.Text = "objectId";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 99);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 7;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Controls.Add(this.cboObjectType, 3, 1);
            this.tblDetail.Controls.Add(this.lblObjectType, 2, 1);
            this.tblDetail.Controls.Add(this.txtObjectId, 1, 1);
            this.tblDetail.Controls.Add(this.cboAlarmType, 1, 0);
            this.tblDetail.Controls.Add(this.lblAlarmType, 0, 0);
            this.tblDetail.Controls.Add(this.lblObjectId, 0, 1);
            this.tblDetail.Controls.Add(this.lblReasonCode, 2, 0);
            this.tblDetail.Controls.Add(this.cboAlarmReason, 3, 0);
            this.tblDetail.Controls.Add(this.lblAlarmStatus, 4, 0);
            this.tblDetail.Controls.Add(this.cboAlarmStatus, 5, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Location = new System.Drawing.Point(3, 26);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(811, 70);
            this.tblDetail.TabIndex = 0;
            // 
            // cboObjectType
            // 
            this.cboObjectType.FormattingEnabled = true;
            this.cboObjectType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboObjectType.Items.AddRange(new object[] {
            "Equipment",
            "Lot"});
            this.cboObjectType.Location = new System.Drawing.Point(372, 37);
            this.cboObjectType.MaxLength = 40;
            this.cboObjectType.Name = "cboObjectType";
            this.cboObjectType.Size = new System.Drawing.Size(161, 28);
            this.cboObjectType.Sorted = true;
            this.cboObjectType.TabIndex = 4;
            // 
            // lblObjectType
            // 
            this.lblObjectType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObjectType.Location = new System.Drawing.Point(255, 41);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(111, 22);
            this.lblObjectType.TabIndex = 12;
            this.lblObjectType.Tag = "objectType";
            this.lblObjectType.Text = "objectType";
            // 
            // txtObjectId
            // 
            this.txtObjectId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtObjectId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtObjectId.Location = new System.Drawing.Point(100, 37);
            this.txtObjectId.MaxLength = 50;
            this.txtObjectId.Name = "txtObjectId";
            this.txtObjectId.Size = new System.Drawing.Size(149, 30);
            this.txtObjectId.TabIndex = 3;
            // 
            // cboAlarmType
            // 
            this.cboAlarmType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlarmType.BackColor = System.Drawing.SystemColors.Info;
            this.cboAlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlarmType.FormattingEnabled = true;
            this.cboAlarmType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboAlarmType.Location = new System.Drawing.Point(100, 3);
            this.cboAlarmType.MaxLength = 40;
            this.cboAlarmType.Name = "cboAlarmType";
            this.cboAlarmType.Size = new System.Drawing.Size(149, 28);
            this.cboAlarmType.Sorted = true;
            this.cboAlarmType.TabIndex = 0;
            this.cboAlarmType.SelectedValueChanged += new System.EventHandler(this.cboAlarmType_SelectedValueChanged);
            // 
            // lblReasonCode
            // 
            this.lblReasonCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReasonCode.AutoSize = true;
            this.lblReasonCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonCode.Location = new System.Drawing.Point(255, 6);
            this.lblReasonCode.Name = "lblReasonCode";
            this.lblReasonCode.Size = new System.Drawing.Size(111, 22);
            this.lblReasonCode.TabIndex = 13;
            this.lblReasonCode.Tag = "reasonCode";
            this.lblReasonCode.Text = "reasonCode";
            // 
            // cboAlarmReason
            // 
            this.cboAlarmReason.FormattingEnabled = true;
            this.cboAlarmReason.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboAlarmReason.Location = new System.Drawing.Point(372, 3);
            this.cboAlarmReason.MaxLength = 40;
            this.cboAlarmReason.Name = "cboAlarmReason";
            this.cboAlarmReason.Size = new System.Drawing.Size(161, 28);
            this.cboAlarmReason.Sorted = true;
            this.cboAlarmReason.TabIndex = 2;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(817, 25);
            this.actionToolbar1.TabIndex = 9;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // lvwAlarmMessage
            // 
            this.lvwAlarmMessage.allowUserFilter = true;
            this.lvwAlarmMessage.allowUserSorting = true;
            this.lvwAlarmMessage.autoSizeColumn = false;
            this.lvwAlarmMessage.careModifyDate = false;
            this.lvwAlarmMessage.columnHide = null;
            this.lvwAlarmMessage.columnNames = new string[] {
        "createDate",
        "alarmType",
        "objectId",
        "objectType",
        "reasonCode",
        "status",
        "message",
        "comments",
        "actionComments"};
            this.lvwAlarmMessage.columnTags = new string[] {
        "createDate",
        "alarmType",
        "objectId",
        "objectType",
        "reasonCode",
        "status",
        "message",
        "comments",
        "actionComment"};
            this.lvwAlarmMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAlarmMessage.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAlarmMessage.FullRowSelect = true;
            this.lvwAlarmMessage.HideSelection = false;
            this.lvwAlarmMessage.imageKeyColumn = "";
            this.lvwAlarmMessage.keyPressSearch = false;
            this.lvwAlarmMessage.keyPressSearchColumn = "";
            this.lvwAlarmMessage.Location = new System.Drawing.Point(0, 124);
            this.lvwAlarmMessage.makesureNewItemVisible = true;
            this.lvwAlarmMessage.Margin = new System.Windows.Forms.Padding(4);
            this.lvwAlarmMessage.MultiSelect = false;
            this.lvwAlarmMessage.Name = "lvwAlarmMessage";
            this.lvwAlarmMessage.OwnerDraw = true;
            this.lvwAlarmMessage.ShowItemTipSecond = ((byte)(3));
            this.lvwAlarmMessage.Size = new System.Drawing.Size(817, 237);
            this.lvwAlarmMessage.TabIndex = 11;
            this.lvwAlarmMessage.UseCompatibleStateImageBehavior = false;
            this.lvwAlarmMessage.View = System.Windows.Forms.View.Details;
            this.lvwAlarmMessage.MESItemSelectionChanged += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanged(this.lvwAlarmMessage_MESItemSelectionChanged);
            // 
            // frmAlarmMessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(817, 361);
            this.Controls.Add(this.lvwAlarmMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlarmMessage";
            this.Tag = "alarmMessage";
            this.Text = "frmAlarmMessage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmAlarmMessage_Activated);
            this.Load += new System.EventHandler(this.frmAlarmMessage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAlarmStatus;
        private System.Windows.Forms.Label lblAlarmStatus;
        private System.Windows.Forms.Label lblAlarmType;
        private System.Windows.Forms.Label lblObjectId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        internal idv.mesCore.Controls.MESListView lvwAlarmMessage;
        private System.Windows.Forms.ComboBox cboAlarmType;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.TextBox txtObjectId;
        private System.Windows.Forms.ComboBox cboObjectType;
        private System.Windows.Forms.ComboBox cboAlarmReason;
        private System.Windows.Forms.Label lblReasonCode;
    }
}