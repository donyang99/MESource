namespace toolingFunction
{
    partial class frmProperty
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
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.tblBasicInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtOwnDept = new System.Windows.Forms.TextBox();
            this.lblOwnDept = new System.Windows.Forms.Label();
            this.lblToolingId = new System.Windows.Forms.Label();
            this.txtToolingId = new System.Windows.Forms.TextBox();
            this.lblToolingType = new System.Windows.Forms.Label();
            this.txtToolingType = new System.Windows.Forms.TextBox();
            this.lblToolingPart = new System.Windows.Forms.Label();
            this.txtToolingPart = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblPartDesc = new System.Windows.Forms.Label();
            this.txtPartDesc = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQueryHistory = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lvwHistory = new System.Windows.Forms.ListView();
            this.event_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lot_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.current_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.use_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reason_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modify_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modify_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExportHistory = new System.Windows.Forms.Button();
            this.grpBasicInfo.SuspendLayout();
            this.tblBasicInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.AutoSize = true;
            this.grpBasicInfo.Controls.Add(this.tblBasicInfo);
            this.grpBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBasicInfo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBasicInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpBasicInfo.Location = new System.Drawing.Point(0, 0);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.grpBasicInfo.Size = new System.Drawing.Size(761, 124);
            this.grpBasicInfo.TabIndex = 1;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Tag = "basicInfo";
            this.grpBasicInfo.Text = "basicInfo";
            // 
            // tblBasicInfo
            // 
            this.tblBasicInfo.AutoSize = true;
            this.tblBasicInfo.ColumnCount = 6;
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblBasicInfo.Controls.Add(this.txtOwnDept, 3, 1);
            this.tblBasicInfo.Controls.Add(this.lblOwnDept, 2, 1);
            this.tblBasicInfo.Controls.Add(this.lblToolingId, 0, 0);
            this.tblBasicInfo.Controls.Add(this.txtToolingId, 1, 0);
            this.tblBasicInfo.Controls.Add(this.lblToolingType, 2, 0);
            this.tblBasicInfo.Controls.Add(this.txtToolingType, 3, 0);
            this.tblBasicInfo.Controls.Add(this.lblToolingPart, 0, 1);
            this.tblBasicInfo.Controls.Add(this.txtToolingPart, 1, 1);
            this.tblBasicInfo.Controls.Add(this.lblStatus, 4, 0);
            this.tblBasicInfo.Controls.Add(this.txtStatus, 5, 0);
            this.tblBasicInfo.Controls.Add(this.lblPartDesc, 0, 2);
            this.tblBasicInfo.Controls.Add(this.txtPartDesc, 1, 2);
            this.tblBasicInfo.Controls.Add(this.lblLocation, 4, 1);
            this.tblBasicInfo.Controls.Add(this.txtLocation, 5, 1);
            this.tblBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblBasicInfo.Location = new System.Drawing.Point(3, 22);
            this.tblBasicInfo.Name = "tblBasicInfo";
            this.tblBasicInfo.RowCount = 3;
            this.tblBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBasicInfo.Size = new System.Drawing.Size(755, 96);
            this.tblBasicInfo.TabIndex = 0;
            // 
            // txtOwnDept
            // 
            this.txtOwnDept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOwnDept.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOwnDept.Location = new System.Drawing.Point(377, 35);
            this.txtOwnDept.Name = "txtOwnDept";
            this.txtOwnDept.ReadOnly = true;
            this.txtOwnDept.Size = new System.Drawing.Size(142, 26);
            this.txtOwnDept.TabIndex = 2;
            this.txtOwnDept.TabStop = false;
            // 
            // lblOwnDept
            // 
            this.lblOwnDept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOwnDept.AutoSize = true;
            this.lblOwnDept.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOwnDept.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOwnDept.Location = new System.Drawing.Point(278, 40);
            this.lblOwnDept.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblOwnDept.Name = "lblOwnDept";
            this.lblOwnDept.Size = new System.Drawing.Size(80, 16);
            this.lblOwnDept.TabIndex = 2;
            this.lblOwnDept.Tag = "ownerDept";
            this.lblOwnDept.Text = "ownerDept";
            // 
            // lblToolingId
            // 
            this.lblToolingId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToolingId.AutoSize = true;
            this.lblToolingId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToolingId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingId.Location = new System.Drawing.Point(3, 8);
            this.lblToolingId.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblToolingId.Name = "lblToolingId";
            this.lblToolingId.Size = new System.Drawing.Size(80, 16);
            this.lblToolingId.TabIndex = 2;
            this.lblToolingId.Tag = "ToolingId";
            this.lblToolingId.Text = "ToolingId";
            // 
            // txtToolingId
            // 
            this.txtToolingId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtToolingId.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtToolingId.Location = new System.Drawing.Point(102, 3);
            this.txtToolingId.Name = "txtToolingId";
            this.txtToolingId.ReadOnly = true;
            this.txtToolingId.Size = new System.Drawing.Size(170, 26);
            this.txtToolingId.TabIndex = 2;
            this.txtToolingId.TabStop = false;
            // 
            // lblToolingType
            // 
            this.lblToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToolingType.AutoSize = true;
            this.lblToolingType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToolingType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingType.Location = new System.Drawing.Point(278, 8);
            this.lblToolingType.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblToolingType.Name = "lblToolingType";
            this.lblToolingType.Size = new System.Drawing.Size(96, 16);
            this.lblToolingType.TabIndex = 1;
            this.lblToolingType.Tag = "ToolingType";
            this.lblToolingType.Text = "ToolingType";
            // 
            // txtToolingType
            // 
            this.txtToolingType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtToolingType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtToolingType.Location = new System.Drawing.Point(377, 3);
            this.txtToolingType.Name = "txtToolingType";
            this.txtToolingType.ReadOnly = true;
            this.txtToolingType.Size = new System.Drawing.Size(142, 26);
            this.txtToolingType.TabIndex = 1;
            this.txtToolingType.TabStop = false;
            // 
            // lblToolingPart
            // 
            this.lblToolingPart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblToolingPart.AutoSize = true;
            this.lblToolingPart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblToolingPart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolingPart.Location = new System.Drawing.Point(3, 40);
            this.lblToolingPart.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblToolingPart.Name = "lblToolingPart";
            this.lblToolingPart.Size = new System.Drawing.Size(96, 16);
            this.lblToolingPart.TabIndex = 2;
            this.lblToolingPart.Tag = "ToolingPart";
            this.lblToolingPart.Text = "ToolingPart";
            // 
            // txtToolingPart
            // 
            this.txtToolingPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolingPart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtToolingPart.Location = new System.Drawing.Point(102, 35);
            this.txtToolingPart.Name = "txtToolingPart";
            this.txtToolingPart.ReadOnly = true;
            this.txtToolingPart.Size = new System.Drawing.Size(170, 26);
            this.txtToolingPart.TabIndex = 2;
            this.txtToolingPart.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(525, 8);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Tag = "status";
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStatus.Location = new System.Drawing.Point(600, 3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(152, 26);
            this.txtStatus.TabIndex = 3;
            this.txtStatus.TabStop = false;
            // 
            // lblPartDesc
            // 
            this.lblPartDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPartDesc.AutoSize = true;
            this.lblPartDesc.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPartDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPartDesc.Location = new System.Drawing.Point(3, 72);
            this.lblPartDesc.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPartDesc.Name = "lblPartDesc";
            this.lblPartDesc.Size = new System.Drawing.Size(72, 16);
            this.lblPartDesc.TabIndex = 3;
            this.lblPartDesc.Tag = "description";
            this.lblPartDesc.Text = "PartDesc";
            // 
            // txtPartDesc
            // 
            this.txtPartDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblBasicInfo.SetColumnSpan(this.txtPartDesc, 3);
            this.txtPartDesc.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPartDesc.Location = new System.Drawing.Point(102, 67);
            this.txtPartDesc.Name = "txtPartDesc";
            this.txtPartDesc.ReadOnly = true;
            this.txtPartDesc.Size = new System.Drawing.Size(417, 26);
            this.txtPartDesc.TabIndex = 3;
            this.txtPartDesc.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLocation.Location = new System.Drawing.Point(525, 40);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(72, 16);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Tag = "location";
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocation.Location = new System.Drawing.Point(600, 35);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(152, 26);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 5;
            this.label2.Tag = "queryCondition";
            this.label2.Text = "Query Condition";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 23);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.Controls.Add(this.btnQueryHistory, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtTo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnQueryHistory
            // 
            this.btnQueryHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQueryHistory.Location = new System.Drawing.Point(476, 3);
            this.btnQueryHistory.Name = "btnQueryHistory";
            this.btnQueryHistory.Size = new System.Drawing.Size(68, 33);
            this.btnQueryHistory.TabIndex = 3;
            this.btnQueryHistory.Tag = "buttonQuery";
            this.btnQueryHistory.Text = "Query";
            this.btnQueryHistory.UseVisualStyleBackColor = true;
            this.btnQueryHistory.Click += new System.EventHandler(this.btnQueryHistory_Click);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTo.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(267, 6);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(190, 26);
            this.dtTo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 39);
            this.label3.TabIndex = 0;
            this.label3.Tag = "date";
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtFrom.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(49, 6);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(190, 26);
            this.dtFrom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(245, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 23);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 9;
            this.label5.Tag = "History";
            this.label5.Text = "History";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwHistory
            // 
            this.lvwHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.event_name,
            this.location,
            this.lot_id,
            this.status,
            this.current_count,
            this.use_count,
            this.reason_code,
            this.comments,
            this.modify_user,
            this.modify_date});
            this.lvwHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwHistory.FullRowSelect = true;
            this.lvwHistory.HideSelection = false;
            this.lvwHistory.Location = new System.Drawing.Point(0, 232);
            this.lvwHistory.Name = "lvwHistory";
            this.lvwHistory.Size = new System.Drawing.Size(761, 380);
            this.lvwHistory.TabIndex = 9;
            this.lvwHistory.UseCompatibleStateImageBehavior = false;
            this.lvwHistory.View = System.Windows.Forms.View.Details;
            // 
            // event_name
            // 
            this.event_name.Name = "event_name";
            this.event_name.Tag = "activity";
            this.event_name.Text = "EventName";
            this.event_name.Width = 125;
            // 
            // location
            // 
            this.location.Name = "location";
            this.location.Tag = "location";
            this.location.Text = "location";
            this.location.Width = 111;
            // 
            // lot_id
            // 
            this.lot_id.Name = "lot_id";
            this.lot_id.Tag = "lotId";
            this.lot_id.Text = "LotId";
            this.lot_id.Width = 121;
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Tag = "status";
            this.status.Text = "status";
            this.status.Width = 70;
            // 
            // current_count
            // 
            this.current_count.Name = "current_count";
            this.current_count.Tag = "CurrentCount";
            this.current_count.Text = "current_count";
            this.current_count.Width = 90;
            // 
            // use_count
            // 
            this.use_count.Name = "use_count";
            this.use_count.Tag = "usedCount";
            this.use_count.Text = "use_count";
            this.use_count.Width = 86;
            // 
            // reason_code
            // 
            this.reason_code.Name = "reason_code";
            this.reason_code.Tag = "reasonCode";
            this.reason_code.Text = "reason_code";
            this.reason_code.Width = 99;
            // 
            // comments
            // 
            this.comments.Name = "comments";
            this.comments.Tag = "comments";
            this.comments.Text = "comments";
            this.comments.Width = 99;
            // 
            // modify_user
            // 
            this.modify_user.Name = "modify_user";
            this.modify_user.Tag = "modifyUser";
            this.modify_user.Text = "ModifyUser";
            this.modify_user.Width = 117;
            // 
            // modify_date
            // 
            this.modify_date.Name = "modify_date";
            this.modify_date.Tag = "modifyDate";
            this.modify_date.Text = "ModifyDate";
            this.modify_date.Width = 176;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 35);
            this.panel3.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(684, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "buttonExit";
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExportHistory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 612);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel4.Size = new System.Drawing.Size(761, 35);
            this.panel4.TabIndex = 11;
            // 
            // btnExportHistory
            // 
            this.btnExportHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportHistory.Location = new System.Drawing.Point(692, 0);
            this.btnExportHistory.Name = "btnExportHistory";
            this.btnExportHistory.Size = new System.Drawing.Size(69, 30);
            this.btnExportHistory.TabIndex = 11;
            this.btnExportHistory.Tag = "buttonExport";
            this.btnExportHistory.Text = "Export";
            this.btnExportHistory.UseVisualStyleBackColor = true;
            this.btnExportHistory.Click += new System.EventHandler(this.btnExportHistory_Click);
            // 
            // frmProperty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(761, 682);
            this.Controls.Add(this.lvwHistory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBasicInfo);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "buttonProperty";
            this.Text = "frmProperty";
            this.Load += new System.EventHandler(this.frmProperty_Load);
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.tblBasicInfo.ResumeLayout(false);
            this.tblBasicInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.TableLayoutPanel tblBasicInfo;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPartDesc;
        private System.Windows.Forms.Label lblPartDesc;
        private System.Windows.Forms.TextBox txtToolingId;
        private System.Windows.Forms.Label lblToolingId;
        private System.Windows.Forms.TextBox txtToolingPart;
        private System.Windows.Forms.Label lblToolingPart;
        private System.Windows.Forms.TextBox txtToolingType;
        private System.Windows.Forms.Label lblToolingType;
        private System.Windows.Forms.Label lblOwnDept;
        private System.Windows.Forms.TextBox txtOwnDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQueryHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvwHistory;
        private System.Windows.Forms.ColumnHeader event_name;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader lot_id;
        private System.Windows.Forms.ColumnHeader modify_user;
        private System.Windows.Forms.ColumnHeader modify_date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExportHistory;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader current_count;
        private System.Windows.Forms.ColumnHeader use_count;
        private System.Windows.Forms.ColumnHeader reason_code;
        private System.Windows.Forms.ColumnHeader comments;
    }
}