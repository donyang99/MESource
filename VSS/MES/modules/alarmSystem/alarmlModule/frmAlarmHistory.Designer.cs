namespace alarmModule
{
    partial class frmAlarmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlarmHistory));
            this.cboObjectType = new System.Windows.Forms.ComboBox();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.txtObjectId = new System.Windows.Forms.TextBox();
            this.lvwAlarmMessage = new idv.mesCore.Controls.MESListView();
            this.cboAlarmType = new System.Windows.Forms.ComboBox();
            this.lblReasonCode = new System.Windows.Forms.Label();
            this.cboAlarmReason = new System.Windows.Forms.ComboBox();
            this.lblAlarmType = new System.Windows.Forms.Label();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblObjectId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.tblDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboObjectType
            // 
            this.cboObjectType.FormattingEnabled = true;
            this.cboObjectType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboObjectType.Items.AddRange(new object[] {
            "Equipment",
            "Lot"});
            this.cboObjectType.Location = new System.Drawing.Point(941, 3);
            this.cboObjectType.MaxLength = 40;
            this.cboObjectType.Name = "cboObjectType";
            this.cboObjectType.Size = new System.Drawing.Size(161, 28);
            this.cboObjectType.Sorted = true;
            this.cboObjectType.TabIndex = 3;
            // 
            // lblObjectType
            // 
            this.lblObjectType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObjectType.Location = new System.Drawing.Point(824, 7);
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
            this.txtObjectId.Location = new System.Drawing.Point(669, 3);
            this.txtObjectId.MaxLength = 50;
            this.txtObjectId.Name = "txtObjectId";
            this.txtObjectId.Size = new System.Drawing.Size(149, 30);
            this.txtObjectId.TabIndex = 2;
            // 
            // lvwAlarmMessage
            // 
            this.lvwAlarmMessage.allowUserFilter = true;
            this.lvwAlarmMessage.allowUserSorting = false;
            this.lvwAlarmMessage.autoSizeColumn = false;
            this.lvwAlarmMessage.careModifyDate = false;
            this.lvwAlarmMessage.columnHide = null;
            this.lvwAlarmMessage.columnNames = new string[] {
        "createDate",
        "alarmType",
        "objectId",
        "objectType",
        "reasonCode",
        "message",
        "comments",
        "modifyUser",
        "modifyDate",
        "actionComments",
        "clearUser",
        "clearDate",
        "clearReason",
        "clearComments"};
            this.lvwAlarmMessage.columnTags = new string[] {
        "createDate",
        "alarmType",
        "objectId",
        "objectType",
        "reasonCode",
        "message",
        "comments",
        "actionUser",
        "actionDate",
        "actionComment",
        "clearUser",
        "clearDate",
        "clearReason",
        "clearComment"};
            this.lvwAlarmMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAlarmMessage.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAlarmMessage.FullRowSelect = true;
            this.lvwAlarmMessage.HideSelection = false;
            this.lvwAlarmMessage.imageKeyColumn = "";
            this.lvwAlarmMessage.keyPressSearch = false;
            this.lvwAlarmMessage.keyPressSearchColumn = "";
            this.lvwAlarmMessage.Location = new System.Drawing.Point(0, 126);
            this.lvwAlarmMessage.makesureNewItemVisible = true;
            this.lvwAlarmMessage.Margin = new System.Windows.Forms.Padding(4);
            this.lvwAlarmMessage.MultiSelect = false;
            this.lvwAlarmMessage.Name = "lvwAlarmMessage";
            this.lvwAlarmMessage.OwnerDraw = true;
            this.lvwAlarmMessage.ShowItemTipSecond = ((byte)(3));
            this.lvwAlarmMessage.Size = new System.Drawing.Size(1113, 318);
            this.lvwAlarmMessage.TabIndex = 14;
            this.lvwAlarmMessage.UseCompatibleStateImageBehavior = false;
            this.lvwAlarmMessage.View = System.Windows.Forms.View.Details;
            // 
            // cboAlarmType
            // 
            this.cboAlarmType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlarmType.BackColor = System.Drawing.SystemColors.Info;
            this.cboAlarmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlarmType.FormattingEnabled = true;
            this.cboAlarmType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboAlarmType.Location = new System.Drawing.Point(100, 6);
            this.cboAlarmType.MaxLength = 40;
            this.cboAlarmType.Name = "cboAlarmType";
            this.cboAlarmType.Size = new System.Drawing.Size(149, 28);
            this.cboAlarmType.Sorted = true;
            this.cboAlarmType.TabIndex = 0;
            this.cboAlarmType.SelectedValueChanged += new System.EventHandler(this.cboAlarmType_SelectedValueChanged);
            // 
            // lblReasonCode
            // 
            this.lblReasonCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReasonCode.AutoSize = true;
            this.lblReasonCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReasonCode.Location = new System.Drawing.Point(255, 7);
            this.lblReasonCode.Name = "lblReasonCode";
            this.lblReasonCode.Size = new System.Drawing.Size(111, 22);
            this.lblReasonCode.TabIndex = 13;
            this.lblReasonCode.Tag = "reasonCode";
            this.lblReasonCode.Text = "reasonCode";
            // 
            // cboAlarmReason
            // 
            this.tblDetail.SetColumnSpan(this.cboAlarmReason, 2);
            this.cboAlarmReason.FormattingEnabled = true;
            this.cboAlarmReason.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboAlarmReason.Location = new System.Drawing.Point(372, 3);
            this.cboAlarmReason.MaxLength = 40;
            this.cboAlarmReason.Name = "cboAlarmReason";
            this.cboAlarmReason.Size = new System.Drawing.Size(161, 28);
            this.cboAlarmReason.Sorted = true;
            this.cboAlarmReason.TabIndex = 1;
            // 
            // lblAlarmType
            // 
            this.lblAlarmType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlarmType.AutoSize = true;
            this.lblAlarmType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlarmType.Location = new System.Drawing.Point(3, 7);
            this.lblAlarmType.Name = "lblAlarmType";
            this.lblAlarmType.Size = new System.Drawing.Size(91, 22);
            this.lblAlarmType.TabIndex = 2;
            this.lblAlarmType.Tag = "alarmType";
            this.lblAlarmType.Text = "報警類型";
            // 
            // tblDetail
            // 
            this.tblDetail.AutoSize = true;
            this.tblDetail.ColumnCount = 10;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDetail.Controls.Add(this.dtTo, 4, 1);
            this.tblDetail.Controls.Add(this.label4, 3, 1);
            this.tblDetail.Controls.Add(this.dtFrom, 1, 1);
            this.tblDetail.Controls.Add(this.cboAlarmType, 1, 0);
            this.tblDetail.Controls.Add(this.lblAlarmType, 0, 0);
            this.tblDetail.Controls.Add(this.lblReasonCode, 2, 0);
            this.tblDetail.Controls.Add(this.lblObjectId, 5, 0);
            this.tblDetail.Controls.Add(this.txtObjectId, 6, 0);
            this.tblDetail.Controls.Add(this.lblObjectType, 7, 0);
            this.tblDetail.Controls.Add(this.cboObjectType, 8, 0);
            this.tblDetail.Controls.Add(this.lblDate, 0, 1);
            this.tblDetail.Controls.Add(this.cboAlarmReason, 3, 0);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetail.Location = new System.Drawing.Point(3, 26);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 2;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.Size = new System.Drawing.Size(1107, 72);
            this.tblDetail.TabIndex = 0;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTo.Checked = false;
            this.tblDetail.SetColumnSpan(this.dtTo, 2);
            this.dtTo.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(397, 39);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.Size = new System.Drawing.Size(266, 30);
            this.dtTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(372, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtFrom.Checked = false;
            this.tblDetail.SetColumnSpan(this.dtFrom, 2);
            this.dtFrom.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(100, 39);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShowCheckBox = true;
            this.dtFrom.Size = new System.Drawing.Size(266, 30);
            this.dtFrom.TabIndex = 4;
            // 
            // lblObjectId
            // 
            this.lblObjectId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblObjectId.AutoSize = true;
            this.lblObjectId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObjectId.Location = new System.Drawing.Point(572, 7);
            this.lblObjectId.Name = "lblObjectId";
            this.lblObjectId.Size = new System.Drawing.Size(91, 22);
            this.lblObjectId.TabIndex = 3;
            this.lblObjectId.Tag = "objectId";
            this.lblObjectId.Text = "objectId";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(3, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 22);
            this.lblDate.TabIndex = 9;
            this.lblDate.Tag = "date";
            this.lblDate.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tblDetail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 101);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(1113, 25);
            this.actionToolbar1.TabIndex = 12;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // frmAlarmHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1113, 444);
            this.Controls.Add(this.lvwAlarmMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlarmHistory";
            this.Tag = "alarmHistory";
            this.Text = "frmAlarmHistory";
            this.Activated += new System.EventHandler(this.frmAlarmHistory_Activated);
            this.Load += new System.EventHandler(this.frmAlarmHistory_Load);
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboObjectType;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.TextBox txtObjectId;
        internal idv.mesCore.Controls.MESListView lvwAlarmMessage;
        private System.Windows.Forms.ComboBox cboAlarmType;
        private System.Windows.Forms.Label lblReasonCode;
        private System.Windows.Forms.ComboBox cboAlarmReason;
        private System.Windows.Forms.Label lblAlarmType;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Label lblObjectId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFrom;
    }
}