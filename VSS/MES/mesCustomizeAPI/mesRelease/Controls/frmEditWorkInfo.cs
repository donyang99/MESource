using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesRelease.Controls
{
    public partial class frmEditWorkInfo : Form
    {
        TaWorkInformation _taWorkInfo = null;
        List<string> stationList = new List<string>();
        public frmEditWorkInfo()
        {
            InitializeComponent();
        }

        public bool ShowShift
        {
            get { return pnlShift.Visible; }
            set { pnlShift.Visible = value; }
        }

        ComboBox firstCombo = null;
        public void Init(TaWorkInformation taWorkInfo)
        {
            _taWorkInfo = taWorkInfo;
            PRP.Step step = new PRP.Step(taWorkInfo.stepId);
            if (step.sysid.Equals("")) return;
            stationList.AddRange(step.stations);
            if (stationList.Count == 0) stationList.Add("");

            tablePanel.Controls.Clear();
            tablePanel.RowStyles.Clear();
            tablePanel.RowCount = stationList.Count / 2 + 1;

            int i = 0;
            foreach (string station in stationList)
            {
                if ((i % 2) == 0)
                    tablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                Label lbl = new Label();
                lbl.Name = "lbl_" + station;
                lbl.Text = station;
                lbl.Tag = station;
                lbl.Anchor = AnchorStyles.Left;
                lbl.AutoSize = true;
                tablePanel.Controls.Add(lbl, 0 + 3 * (i % 2), i / 2);

                TextBox txt = new TextBox();
                txt.Name = "txt_" + station;
                txt.ReadOnly = true;
                txt.TabIndex = 100 + i;
                tablePanel.Controls.Add(txt, 2 + 3 * (i % 2), i / 2);
                txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                txt.Text = taWorkInfo.GetUserName(station);
                txt.TabStop = false;

                ComboBox cbo = new ComboBox();
                cbo.Name = "cbo_" + station;
                cbo.DropDownStyle = ComboBoxStyle.Simple;
                cbo.MaxLength = 40;
                cbo.TabIndex = i;
                tablePanel.Controls.Add(cbo, 1 + 3 * (i % 2), i / 2);
                cbo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                cbo.Height = txt.Height - 2;
                cbo.Text = taWorkInfo.GetUserId(station);
                cbo.KeyUp += new KeyEventHandler(cbo_KeyUp);
                cbo.Enter += new EventHandler(cbo_Enter);
                cbo.Leave += new EventHandler(cbo_Leave);

                if (firstCombo == null)
                    firstCombo = cbo;

                i++;
            }
            btnOK.TabIndex = i + 1;
            btnCancel.TabIndex = i + 2;
            //Height = tablePanel.PreferredSize.Height + 80;
            idv.utilities.cultureLanguage.switchLanguageSync(this);
        }

        void cbo_Leave(object sender, EventArgs e)
        {
            (sender as ComboBox).BackColor = SystemColors.Window;
        }

        void cbo_Enter(object sender, EventArgs e)
        {
            (sender as ComboBox).BackColor = SystemColors.Info;
        }

        void cbo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboBox cbo = sender as ComboBox;
                //if (cbo.Text.Equals("")) return;
                TextBox txt = tablePanel.Controls[cbo.Name.Replace("cbo_", "txt_")] as TextBox;
                if (cbo.Text.Equals(""))
                    txt.Text = "";
                else
                    txt.Text = mesRelease.USR.User.GetUserName(cbo.Text);
                SendKeys.SendWait("{TAB}");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (!CheckData()) return;

            idv.messageService.sql.sqlTable table = null;
            List<idv.messageService.sql.sqlTable> sqlList = new List<idv.messageService.sql.sqlTable>();
            string sysid = "";
            if (_taWorkInfo.sysId.Equals(""))
            {
                sysid = System.Guid.NewGuid().ToString();
                table = new idv.messageService.sql.sqlTable("mes_ta_work_info", idv.messageService.sql.eDMLtype.Insert);
                table.Add("sysid", sysid);
                table.Add("step_id", _taWorkInfo.stepId);
                table.Add("equipment_id", _taWorkInfo.equipmentId);
            }
            else
            {
                table = new idv.messageService.sql.sqlTable("mes_ta_work_info_detail", idv.messageService.sql.eDMLtype.Delete);
                table.WhereClause.Add("ta_work_info", _taWorkInfo.taWorkInfo);
                sqlList.Add(table);

                table = new idv.messageService.sql.sqlTable("mes_ta_work_info", idv.messageService.sql.eDMLtype.Update);
                table.WhereClause.Add("sysid", _taWorkInfo.sysId);
            }
            _taWorkInfo.taWorkInfo = System.Guid.NewGuid().ToString();
            _taWorkInfo.shift = cboShift.Text;
            _taWorkInfo.taCount = 0;
            _taWorkInfo.modifyDate = idv.messageService.serviceHost.dateTime;

            bool isEmpty = true;
            foreach (string station in stationList)
            {
                string userId = tablePanel.Controls["cbo_" + station].Text.Trim();
                if (userId.Equals("")) continue;
                isEmpty = false;
                _taWorkInfo.taCount++;

                idv.messageService.sql.sqlTable detailTable = new idv.messageService.sql.sqlTable("mes_ta_work_info_detail", idv.messageService.sql.eDMLtype.Insert);
                detailTable.Add("ta_work_info", _taWorkInfo.taWorkInfo);
                detailTable.Add("station", station);
                detailTable.Add("user_id", userId);
                sqlList.Add(detailTable);

                //his
                detailTable = new idv.messageService.sql.sqlTable("mes_ta_work_info_detail_his", idv.messageService.sql.eDMLtype.Insert);
                detailTable.Add("ta_work_info", _taWorkInfo.taWorkInfo);
                detailTable.Add("station", station);
                detailTable.Add("user_id", userId);
                sqlList.Add(detailTable);
            }

            if (isEmpty)
                _taWorkInfo.taWorkInfo = "";

            table.Add("ta_work_info", _taWorkInfo.taWorkInfo);
            table.Add("shift", _taWorkInfo.shift);
            table.Add("ta_count", _taWorkInfo.taCount);
            table.Add("modify_date", _taWorkInfo.modifyDate);
            sqlList.Add(table);

            //his
            if (!isEmpty)
            {
                table = new idv.messageService.sql.sqlTable("mes_ta_work_info_history", idv.messageService.sql.eDMLtype.Insert);
                table.Add("ta_work_info", _taWorkInfo.taWorkInfo);
                table.Add("shift", _taWorkInfo.shift);
                table.Add("ta_count", _taWorkInfo.taCount);
                table.Add("modify_date", _taWorkInfo.modifyDate);
                sqlList.Add(table);
            }

            try
            {
                idv.messageService.serviceHost.Client.beginTxn();
                idv.messageService.sql.sqlExecuter.executeSqlTables(sqlList, idv.messageService.serviceHost.Client);
                idv.messageService.serviceHost.Client.commitTxn();

                _taWorkInfo.Refresh();
                Close();
            }
            catch (Exception ex)
            {
                idv.messageService.serviceHost.Client.rollbackTxn();
                MessageBox.Show(ex.Message);
            }
        }

        bool CheckData()
        {
            foreach (string station in stationList)
            {
                string userId = tablePanel.Controls["cbo_" + station].Text.Trim();
                if (userId.Equals(""))
                {
                    idv.utilities.messageBox.showMessageById("requireField");
                    return false;
                }
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (string station in stationList)
                tablePanel.Controls["cbo_" + station].Text = "";
        }

        bool firstActive = true;
        private void frmEditWorkInfo_Activated(object sender, EventArgs e)
        {
            if (!firstActive) return;
            firstActive = false;
            if (firstCombo != null)
                firstCombo.Focus();
        }
    }
}
