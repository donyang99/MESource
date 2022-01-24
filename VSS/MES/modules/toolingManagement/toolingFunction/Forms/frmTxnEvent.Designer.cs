namespace toolingFunction
{
    partial class frmTxnEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTxnEvent));
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.tblBasicInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPartDesc = new System.Windows.Forms.TextBox();
            this.lblPartDesc = new System.Windows.Forms.Label();
            this.txtToolingId = new System.Windows.Forms.TextBox();
            this.lblToolingId = new System.Windows.Forms.Label();
            this.txtToolingPart = new System.Windows.Forms.TextBox();
            this.lblToolingPart = new System.Windows.Forms.Label();
            this.txtToolingType = new System.Windows.Forms.TextBox();
            this.lblToolingType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpLastEvent = new System.Windows.Forms.GroupBox();
            this.tblLastEvent = new System.Windows.Forms.TableLayoutPanel();
            this.txtLastEventComments = new System.Windows.Forms.TextBox();
            this.lblLastEventComments = new System.Windows.Forms.Label();
            this.txtLastEventReason = new System.Windows.Forms.TextBox();
            this.lblLastEventReason = new System.Windows.Forms.Label();
            this.txtLastEventUser = new System.Windows.Forms.TextBox();
            this.lblLastEventUser = new System.Windows.Forms.Label();
            this.txtLastEventDate = new System.Windows.Forms.TextBox();
            this.lblLastEventDate = new System.Windows.Forms.Label();
            this.txtLastEventName = new System.Windows.Forms.TextBox();
            this.lblLastEventName = new System.Windows.Forms.Label();
            this.grpEventInfo = new System.Windows.Forms.GroupBox();
            this.tblEventInfo = new System.Windows.Forms.TableLayoutPanel();
            this.cboReasonCode = new System.Windows.Forms.ComboBox();
            this.cboTarLocation = new System.Windows.Forms.ComboBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblTarLocation = new System.Windows.Forms.Label();
            this.lblReasonCode = new System.Windows.Forms.Label();
            this.grpBasicInfo.SuspendLayout();
            this.tblBasicInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpLastEvent.SuspendLayout();
            this.tblLastEvent.SuspendLayout();
            this.grpEventInfo.SuspendLayout();
            this.tblEventInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.AutoSize = true;
            this.grpBasicInfo.Controls.Add(this.tblBasicInfo);
            this.grpBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBasicInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBasicInfo.ForeColor = System.Drawing.Color.SlateGray;
            this.grpBasicInfo.Location = new System.Drawing.Point(3, 3);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.grpBasicInfo.Size = new System.Drawing.Size(649, 124);
            this.grpBasicInfo.TabIndex = 0;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Tag = "basicInfo";
            this.grpBasicInfo.Text = "basicInfo";
            // 
            // tblBasicInfo
            // 
            this.tblBasicInfo.AutoSize = true;
            this.tblBasicInfo.ColumnCount = 4;
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBasicInfo.Controls.Add(this.txtLocation, 3, 2);
            this.tblBasicInfo.Controls.Add(this.lblLocation, 2, 2);
            this.tblBasicInfo.Controls.Add(this.txtStatus, 1, 2);
            this.tblBasicInfo.Controls.Add(this.lblStatus, 0, 2);
            this.tblBasicInfo.Controls.Add(this.txtPartDesc, 3, 1);
            this.tblBasicInfo.Controls.Add(this.lblPartDesc, 2, 1);
            this.tblBasicInfo.Controls.Add(this.txtToolingId, 1, 1);
            this.tblBasicInfo.Controls.Add(this.lblToolingId, 0, 1);
            this.tblBasicInfo.Controls.Add(this.txtToolingPart, 3, 0);
            this.tblBasicInfo.Controls.Add(this.lblToolingPart, 2, 0);
            this.tblBasicInfo.Controls.Add(this.txtToolingType, 1, 0);
            this.tblBasicInfo.Controls.Add(this.lblToolingType, 0, 0);
            this.tblBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBasicInfo.Location = new System.Drawing.Point(3, 22);
            this.tblBasicInfo.Name = "tblBasicInfo";
            this.tblBasicInfo.RowCount = 3;
            this.tblBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBasicInfo.Size = new System.Drawing.Size(643, 96);
            this.tblBasicInfo.TabIndex = 0;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocation.Location = new System.Drawing.Point(395, 67);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(245, 26);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLocation.Location = new System.Drawing.Point(295, 72);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(72, 16);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Tag = "location";
            this.lblLocation.Text = "Location";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStatus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStatus.Location = new System.Drawing.Point(103, 67);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(186, 26);
            this.txtStatus.TabIndex = 3;
            this.txtStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(3, 72);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Tag = "status";
            this.lblStatus.Text = "Status";
            // 
            // txtPartDesc
            // 
            this.txtPartDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartDesc.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPartDesc.Location = new System.Drawing.Point(395, 35);
            this.txtPartDesc.Name = "txtPartDesc";
            this.txtPartDesc.ReadOnly = true;
            this.txtPartDesc.Size = new System.Drawing.Size(245, 26);
            this.txtPartDesc.TabIndex = 3;
            this.txtPartDesc.TabStop = false;
            // 
            // lblPartDesc
            // 
            this.lblPartDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPartDesc.AutoSize = true;
            this.lblPartDesc.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPartDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPartDesc.Location = new System.Drawing.Point(295, 40);
            this.lblPartDesc.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPartDesc.Name = "lblPartDesc";
            this.lblPartDesc.Size = new System.Drawing.Size(72, 16);
            this.lblPartDesc.TabIndex = 3;
            this.lblPartDesc.Tag = "description";
            this.lblPartDesc.Text = "PartDesc";
            // 
            // txtToolingId
            // 
            this.txtToolingId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtToolingId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtToolingId.Location = new System.Drawing.Point(103, 35);
            this.txtToolingId.Name = "txtToolingId";
            this.txtToolingId.ReadOnly = true;
            this.txtToolingId.Size = new System.Drawing.Size(186, 26);
            this.txtToolingId.TabIndex = 2;
            this.txtToolingId.TabStop = false;
            // 
            // lblToolingId
            // 
            this.lblToolingId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToolingId.AutoSize = true;
            this.lblToolingId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToolingId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingId.Location = new System.Drawing.Point(3, 40);
            this.lblToolingId.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblToolingId.Name = "lblToolingId";
            this.lblToolingId.Size = new System.Drawing.Size(80, 16);
            this.lblToolingId.TabIndex = 2;
            this.lblToolingId.Tag = "ToolingId";
            this.lblToolingId.Text = "ToolingId";
            // 
            // txtToolingPart
            // 
            this.txtToolingPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolingPart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtToolingPart.Location = new System.Drawing.Point(395, 3);
            this.txtToolingPart.Name = "txtToolingPart";
            this.txtToolingPart.ReadOnly = true;
            this.txtToolingPart.Size = new System.Drawing.Size(245, 26);
            this.txtToolingPart.TabIndex = 2;
            this.txtToolingPart.TabStop = false;
            // 
            // lblToolingPart
            // 
            this.lblToolingPart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToolingPart.AutoSize = true;
            this.lblToolingPart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToolingPart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingPart.Location = new System.Drawing.Point(295, 8);
            this.lblToolingPart.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblToolingPart.Name = "lblToolingPart";
            this.lblToolingPart.Size = new System.Drawing.Size(96, 16);
            this.lblToolingPart.TabIndex = 2;
            this.lblToolingPart.Tag = "ToolingPart";
            this.lblToolingPart.Text = "ToolingPart";
            // 
            // txtToolingType
            // 
            this.txtToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtToolingType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtToolingType.Location = new System.Drawing.Point(103, 3);
            this.txtToolingType.Name = "txtToolingType";
            this.txtToolingType.ReadOnly = true;
            this.txtToolingType.Size = new System.Drawing.Size(186, 26);
            this.txtToolingType.TabIndex = 1;
            this.txtToolingType.TabStop = false;
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToolingType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingType.Location = new System.Drawing.Point(3, 8);
            this.lblToolingType.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblToolingType.Name = "lblToolingType";
            this.lblToolingType.Size = new System.Drawing.Size(96, 16);
            this.lblToolingType.TabIndex = 1;
            this.lblToolingType.Tag = "ToolingType";
            this.lblToolingType.Text = "ToolingType";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 38);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(495, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 38);
            this.btnOK.TabIndex = 21;
            this.btnOK.Tag = "buttonOK";
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(572, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 38);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Tag = "buttonCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpLastEvent
            // 
            this.grpLastEvent.AutoSize = true;
            this.grpLastEvent.Controls.Add(this.tblLastEvent);
            this.grpLastEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLastEvent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpLastEvent.ForeColor = System.Drawing.Color.SlateGray;
            this.grpLastEvent.Location = new System.Drawing.Point(3, 127);
            this.grpLastEvent.Name = "grpLastEvent";
            this.grpLastEvent.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.grpLastEvent.Size = new System.Drawing.Size(649, 124);
            this.grpLastEvent.TabIndex = 2;
            this.grpLastEvent.TabStop = false;
            this.grpLastEvent.Tag = "lastEvent";
            this.grpLastEvent.Text = "lastEvent";
            // 
            // tblLastEvent
            // 
            this.tblLastEvent.AutoSize = true;
            this.tblLastEvent.ColumnCount = 4;
            this.tblLastEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLastEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLastEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLastEvent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLastEvent.Controls.Add(this.txtLastEventComments, 1, 2);
            this.tblLastEvent.Controls.Add(this.lblLastEventComments, 0, 2);
            this.tblLastEvent.Controls.Add(this.txtLastEventReason, 3, 1);
            this.tblLastEvent.Controls.Add(this.lblLastEventReason, 2, 1);
            this.tblLastEvent.Controls.Add(this.txtLastEventUser, 1, 1);
            this.tblLastEvent.Controls.Add(this.lblLastEventUser, 0, 1);
            this.tblLastEvent.Controls.Add(this.txtLastEventDate, 3, 0);
            this.tblLastEvent.Controls.Add(this.lblLastEventDate, 2, 0);
            this.tblLastEvent.Controls.Add(this.txtLastEventName, 1, 0);
            this.tblLastEvent.Controls.Add(this.lblLastEventName, 0, 0);
            this.tblLastEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLastEvent.Location = new System.Drawing.Point(3, 22);
            this.tblLastEvent.Name = "tblLastEvent";
            this.tblLastEvent.RowCount = 3;
            this.tblLastEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLastEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLastEvent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLastEvent.Size = new System.Drawing.Size(643, 96);
            this.tblLastEvent.TabIndex = 0;
            // 
            // txtLastEventComments
            // 
            this.txtLastEventComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLastEvent.SetColumnSpan(this.txtLastEventComments, 3);
            this.txtLastEventComments.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLastEventComments.Location = new System.Drawing.Point(103, 67);
            this.txtLastEventComments.Name = "txtLastEventComments";
            this.txtLastEventComments.ReadOnly = true;
            this.txtLastEventComments.Size = new System.Drawing.Size(537, 26);
            this.txtLastEventComments.TabIndex = 3;
            this.txtLastEventComments.TabStop = false;
            // 
            // lblLastEventComments
            // 
            this.lblLastEventComments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastEventComments.AutoSize = true;
            this.lblLastEventComments.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastEventComments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastEventComments.Location = new System.Drawing.Point(3, 72);
            this.lblLastEventComments.Name = "lblLastEventComments";
            this.lblLastEventComments.Size = new System.Drawing.Size(72, 16);
            this.lblLastEventComments.TabIndex = 3;
            this.lblLastEventComments.Tag = "comments";
            this.lblLastEventComments.Text = "comments";
            // 
            // txtLastEventReason
            // 
            this.txtLastEventReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastEventReason.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLastEventReason.Location = new System.Drawing.Point(395, 35);
            this.txtLastEventReason.Name = "txtLastEventReason";
            this.txtLastEventReason.ReadOnly = true;
            this.txtLastEventReason.Size = new System.Drawing.Size(245, 26);
            this.txtLastEventReason.TabIndex = 3;
            this.txtLastEventReason.TabStop = false;
            // 
            // lblLastEventReason
            // 
            this.lblLastEventReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastEventReason.AutoSize = true;
            this.lblLastEventReason.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastEventReason.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastEventReason.Location = new System.Drawing.Point(295, 40);
            this.lblLastEventReason.Name = "lblLastEventReason";
            this.lblLastEventReason.Size = new System.Drawing.Size(88, 16);
            this.lblLastEventReason.TabIndex = 3;
            this.lblLastEventReason.Tag = "reasonCode";
            this.lblLastEventReason.Text = "ReasonCode";
            // 
            // txtLastEventUser
            // 
            this.txtLastEventUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLastEventUser.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLastEventUser.Location = new System.Drawing.Point(103, 35);
            this.txtLastEventUser.Name = "txtLastEventUser";
            this.txtLastEventUser.ReadOnly = true;
            this.txtLastEventUser.Size = new System.Drawing.Size(186, 26);
            this.txtLastEventUser.TabIndex = 2;
            this.txtLastEventUser.TabStop = false;
            // 
            // lblLastEventUser
            // 
            this.lblLastEventUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastEventUser.AutoSize = true;
            this.lblLastEventUser.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastEventUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastEventUser.Location = new System.Drawing.Point(3, 40);
            this.lblLastEventUser.Name = "lblLastEventUser";
            this.lblLastEventUser.Size = new System.Drawing.Size(72, 16);
            this.lblLastEventUser.TabIndex = 2;
            this.lblLastEventUser.Tag = "userName";
            this.lblLastEventUser.Text = "UserName";
            // 
            // txtLastEventDate
            // 
            this.txtLastEventDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastEventDate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLastEventDate.Location = new System.Drawing.Point(395, 3);
            this.txtLastEventDate.Name = "txtLastEventDate";
            this.txtLastEventDate.ReadOnly = true;
            this.txtLastEventDate.Size = new System.Drawing.Size(245, 26);
            this.txtLastEventDate.TabIndex = 2;
            this.txtLastEventDate.TabStop = false;
            // 
            // lblLastEventDate
            // 
            this.lblLastEventDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastEventDate.AutoSize = true;
            this.lblLastEventDate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastEventDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastEventDate.Location = new System.Drawing.Point(295, 8);
            this.lblLastEventDate.Name = "lblLastEventDate";
            this.lblLastEventDate.Size = new System.Drawing.Size(72, 16);
            this.lblLastEventDate.TabIndex = 2;
            this.lblLastEventDate.Tag = "date";
            this.lblLastEventDate.Text = "DateTime";
            // 
            // txtLastEventName
            // 
            this.txtLastEventName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLastEventName.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLastEventName.Location = new System.Drawing.Point(103, 3);
            this.txtLastEventName.Name = "txtLastEventName";
            this.txtLastEventName.ReadOnly = true;
            this.txtLastEventName.Size = new System.Drawing.Size(186, 26);
            this.txtLastEventName.TabIndex = 1;
            this.txtLastEventName.TabStop = false;
            // 
            // lblLastEventName
            // 
            this.lblLastEventName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastEventName.AutoSize = true;
            this.lblLastEventName.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLastEventName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastEventName.Location = new System.Drawing.Point(3, 8);
            this.lblLastEventName.Name = "lblLastEventName";
            this.lblLastEventName.Size = new System.Drawing.Size(40, 16);
            this.lblLastEventName.TabIndex = 1;
            this.lblLastEventName.Tag = "name";
            this.lblLastEventName.Text = "Name";
            // 
            // grpEventInfo
            // 
            this.grpEventInfo.AutoSize = true;
            this.grpEventInfo.Controls.Add(this.tblEventInfo);
            this.grpEventInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEventInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpEventInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpEventInfo.Location = new System.Drawing.Point(3, 251);
            this.grpEventInfo.Name = "grpEventInfo";
            this.grpEventInfo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.grpEventInfo.Size = new System.Drawing.Size(649, 180);
            this.grpEventInfo.TabIndex = 3;
            this.grpEventInfo.TabStop = false;
            this.grpEventInfo.Tag = "eventInfo";
            this.grpEventInfo.Text = "EventInfo";
            // 
            // tblEventInfo
            // 
            this.tblEventInfo.AutoSize = true;
            this.tblEventInfo.ColumnCount = 4;
            this.tblEventInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblEventInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEventInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblEventInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEventInfo.Controls.Add(this.cboReasonCode, 1, 2);
            this.tblEventInfo.Controls.Add(this.cboTarLocation, 1, 1);
            this.tblEventInfo.Controls.Add(this.txtComments, 1, 3);
            this.tblEventInfo.Controls.Add(this.lblComments, 0, 3);
            this.tblEventInfo.Controls.Add(this.txtEvent, 1, 0);
            this.tblEventInfo.Controls.Add(this.lblEvent, 0, 0);
            this.tblEventInfo.Controls.Add(this.lblUserId, 2, 0);
            this.tblEventInfo.Controls.Add(this.txtUserId, 3, 0);
            this.tblEventInfo.Controls.Add(this.lblTarLocation, 0, 1);
            this.tblEventInfo.Controls.Add(this.lblReasonCode, 0, 2);
            this.tblEventInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblEventInfo.Location = new System.Drawing.Point(3, 22);
            this.tblEventInfo.Name = "tblEventInfo";
            this.tblEventInfo.RowCount = 4;
            this.tblEventInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEventInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEventInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEventInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblEventInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEventInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEventInfo.Size = new System.Drawing.Size(643, 152);
            this.tblEventInfo.TabIndex = 0;
            // 
            // cboReasonCode
            // 
            this.cboReasonCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReasonCode.BackColor = System.Drawing.SystemColors.Info;
            this.tblEventInfo.SetColumnSpan(this.cboReasonCode, 3);
            this.cboReasonCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReasonCode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboReasonCode.FormattingEnabled = true;
            this.cboReasonCode.Location = new System.Drawing.Point(103, 65);
            this.cboReasonCode.Name = "cboReasonCode";
            this.cboReasonCode.Size = new System.Drawing.Size(537, 24);
            this.cboReasonCode.TabIndex = 5;
            // 
            // cboTarLocation
            // 
            this.cboTarLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTarLocation.BackColor = System.Drawing.SystemColors.Info;
            this.cboTarLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTarLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboTarLocation.FormattingEnabled = true;
            this.cboTarLocation.Location = new System.Drawing.Point(103, 35);
            this.cboTarLocation.Name = "cboTarLocation";
            this.cboTarLocation.Size = new System.Drawing.Size(186, 24);
            this.cboTarLocation.TabIndex = 4;
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEventInfo.SetColumnSpan(this.txtComments, 3);
            this.txtComments.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtComments.Location = new System.Drawing.Point(103, 95);
            this.txtComments.MaxLength = 255;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(537, 54);
            this.txtComments.TabIndex = 20;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComments.Location = new System.Drawing.Point(3, 95);
            this.lblComments.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(72, 16);
            this.lblComments.TabIndex = 3;
            this.lblComments.Tag = "comments";
            this.lblComments.Text = "comments";
            // 
            // txtEvent
            // 
            this.txtEvent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEvent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEvent.Location = new System.Drawing.Point(103, 3);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.ReadOnly = true;
            this.txtEvent.Size = new System.Drawing.Size(186, 26);
            this.txtEvent.TabIndex = 1;
            this.txtEvent.TabStop = false;
            // 
            // lblEvent
            // 
            this.lblEvent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEvent.Location = new System.Drawing.Point(3, 8);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(40, 16);
            this.lblEvent.TabIndex = 1;
            this.lblEvent.Tag = "name";
            this.lblEvent.Text = "Name";
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserId.Location = new System.Drawing.Point(295, 8);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 16);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Tag = "userName";
            this.lblUserId.Text = "UserName";
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserId.Location = new System.Drawing.Point(395, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(245, 26);
            this.txtUserId.TabIndex = 2;
            this.txtUserId.TabStop = false;
            // 
            // lblTarLocation
            // 
            this.lblTarLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTarLocation.AutoSize = true;
            this.lblTarLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTarLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTarLocation.Location = new System.Drawing.Point(3, 39);
            this.lblTarLocation.Name = "lblTarLocation";
            this.lblTarLocation.Size = new System.Drawing.Size(72, 16);
            this.lblTarLocation.TabIndex = 4;
            this.lblTarLocation.Tag = "location";
            this.lblTarLocation.Text = "location";
            // 
            // lblReasonCode
            // 
            this.lblReasonCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReasonCode.AutoSize = true;
            this.lblReasonCode.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReasonCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReasonCode.Location = new System.Drawing.Point(3, 69);
            this.lblReasonCode.Name = "lblReasonCode";
            this.lblReasonCode.Size = new System.Drawing.Size(88, 16);
            this.lblReasonCode.TabIndex = 3;
            this.lblReasonCode.Tag = "reasonCode";
            this.lblReasonCode.Text = "ReasonCode";
            // 
            // frmTxnEvent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(655, 507);
            this.Controls.Add(this.grpEventInfo);
            this.Controls.Add(this.grpLastEvent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBasicInfo);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 500);
            this.Name = "frmTxnEvent";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTxnEvent";
            this.Activated += new System.EventHandler(this.frmTxnEvent_Activated);
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.tblBasicInfo.ResumeLayout(false);
            this.tblBasicInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpLastEvent.ResumeLayout(false);
            this.grpLastEvent.PerformLayout();
            this.tblLastEvent.ResumeLayout(false);
            this.tblLastEvent.PerformLayout();
            this.grpEventInfo.ResumeLayout(false);
            this.grpEventInfo.PerformLayout();
            this.tblEventInfo.ResumeLayout(false);
            this.tblEventInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.TableLayoutPanel tblBasicInfo;
        private System.Windows.Forms.TextBox txtPartDesc;
        private System.Windows.Forms.Label lblPartDesc;
        private System.Windows.Forms.TextBox txtToolingId;
        private System.Windows.Forms.Label lblToolingId;
        private System.Windows.Forms.TextBox txtToolingPart;
        private System.Windows.Forms.Label lblToolingPart;
        private System.Windows.Forms.TextBox txtToolingType;
        private System.Windows.Forms.Label lblToolingType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpLastEvent;
        private System.Windows.Forms.TableLayoutPanel tblLastEvent;
        private System.Windows.Forms.TextBox txtLastEventComments;
        private System.Windows.Forms.Label lblLastEventComments;
        private System.Windows.Forms.TextBox txtLastEventReason;
        private System.Windows.Forms.Label lblLastEventReason;
        private System.Windows.Forms.TextBox txtLastEventUser;
        private System.Windows.Forms.Label lblLastEventUser;
        private System.Windows.Forms.TextBox txtLastEventDate;
        private System.Windows.Forms.Label lblLastEventDate;
        private System.Windows.Forms.TextBox txtLastEventName;
        private System.Windows.Forms.Label lblLastEventName;
        private System.Windows.Forms.GroupBox grpEventInfo;
        private System.Windows.Forms.TableLayoutPanel tblEventInfo;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblReasonCode;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cboReasonCode;
        private System.Windows.Forms.ComboBox cboTarLocation;
        private System.Windows.Forms.Label lblTarLocation;
    }
}