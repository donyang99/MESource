namespace mesFABMonitor
{
    partial class frmNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotice));
            this.actionToolbar1 = new idv.mesCore.Controls.ActionToolbar();
            this.lvwAlarm = new idv.mesCore.Controls.MESListView();
            this.SuspendLayout();
            // 
            // actionToolbar1
            // 
            this.actionToolbar1.apPrivilegeString = "";
            this.actionToolbar1.functionPrivilegeString = "";
            this.actionToolbar1.Location = new System.Drawing.Point(0, 0);
            this.actionToolbar1.modulePrivilegeString = "";
            this.actionToolbar1.Name = "actionToolbar1";
            this.actionToolbar1.Size = new System.Drawing.Size(960, 25);
            this.actionToolbar1.TabIndex = 1;
            this.actionToolbar1.Text = "actionToolbar1";
            this.actionToolbar1.ActionClicked += new idv.mesCore.Controls.ActionToolbar.delActionClick(this.actionToolbar1_ActionClicked);
            // 
            // lvwAlarm
            // 
            this.lvwAlarm.allowUserFilter = true;
            this.lvwAlarm.allowUserSorting = true;
            this.lvwAlarm.autoSizeColumn = true;
            this.lvwAlarm.careModifyDate = false;
            this.lvwAlarm.columnHide = null;
            this.lvwAlarm.columnNames = new string[] {
        "createDate",
        "alarmType",
        "objectId",
        "reasonCode",
        "status",
        "message",
        "comments"};
            this.lvwAlarm.columnTags = new string[] {
        "createDate",
        "alarmType",
        "equipmentId",
        "reasonCode",
        "status",
        "message",
        "comments"};
            this.lvwAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwAlarm.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvwAlarm.FullRowSelect = true;
            this.lvwAlarm.HideSelection = false;
            this.lvwAlarm.imageKeyColumn = "";
            this.lvwAlarm.keyPressSearch = false;
            this.lvwAlarm.keyPressSearchColumn = "";
            this.lvwAlarm.Location = new System.Drawing.Point(0, 25);
            this.lvwAlarm.makesureNewItemVisible = true;
            this.lvwAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.lvwAlarm.MultiSelect = false;
            this.lvwAlarm.Name = "lvwAlarm";
            this.lvwAlarm.OwnerDraw = true;
            this.lvwAlarm.ShowItemTipSecond = ((byte)(3));
            this.lvwAlarm.Size = new System.Drawing.Size(960, 196);
            this.lvwAlarm.TabIndex = 2;
            this.lvwAlarm.UseCompatibleStateImageBehavior = false;
            this.lvwAlarm.View = System.Windows.Forms.View.Details;
            this.lvwAlarm.MESItemSelectionChanging += new idv.mesCore.Controls.MESListView.delMESItemSelectionChanging(this.lvwAlarm_MESItemSelectionChanging);
            // 
            // frmNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 221);
            this.Controls.Add(this.lvwAlarm);
            this.Controls.Add(this.actionToolbar1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNotice";
            this.Tag = "noticePanel";
            this.Text = "frmNotice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private idv.mesCore.Controls.ActionToolbar actionToolbar1;
        internal idv.mesCore.Controls.MESListView lvwAlarm;



    }
}