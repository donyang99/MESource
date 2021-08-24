using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.EqProperty
{
    public partial class frmMain : Form
    {
        Equipment currentEqp = null;
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            currentEqp = RuleInstance.GetItem(0);

            showActivity();
            dtFrom.Value = DateTime.Now.AddMonths(-1).Date;
            dtEqParmDateFrom.Value = dtFrom.Value;
            dtTo.Value = DateTime.Now.Date;
            dtEqParmDateTo.Value = dtTo.Value;

            equipmentInformation1.EquipmentChanged += new mesRelease.Controls.EquipmentChangeEventHandler(equipmentInformation1_EquipmentChanged);

            equipmentInformation1.Init(currentEqp);

            if (!idv.mesCore.systemConfig.materialTracking && !idv.mesCore.systemConfig.validItem("toolingManagement"))
                tabControl1.TabPages.Remove(tblSetupInfo);
            else if (!idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                pnlCurToolingInfo.Visible = false;
                pnlCurMaterial.Dock = DockStyle.Fill;                
            }
            else if(!idv.mesCore.systemConfig.materialTracking)
            {
                pnlCurMaterial.Visible = false;               
            }
            if (idv.mesCore.systemConfig.materialTracking)
            {
                lvwCurSetupMaterial.prepareColumns();
                lvwCurSetupMaterial.Columns[0].Width = 70;
                lvwCurSetupMaterial.Columns[1].Width = 110;
                lvwCurSetupMaterial.Columns[2].Width = 85;
                lvwCurSetupMaterial.Columns[3].Width = 87;
                lvwCurSetupMaterial.Columns[4].Width = 60;
            }
            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                lvwCurTooling.prepareColumns();
                lvwCurTooling.Columns[0].Width = 100;
                lvwCurTooling.Columns[1].Width = 100;
                lvwCurTooling.Columns[2].Width = 150;
            }
            if (!idv.mesCore.systemConfig.validItem("eqParameter"))
                tabControl1.TabPages.Remove(tblEqParameter);

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        void equipmentInformation1_EquipmentChanged(Equipment equipment, ref bool accept)
        {
            if(equipment == null)
            {
                messageBox.showMessageById("msgCannotFindData");
                accept = false;
                return;
            }
            currentEqp = equipment;
            lvwHistory.Items.Clear();
            lvwCurTooling.RemoveAllMESItems();
            lvwCurSetupMaterial.RemoveAllMESItems();
            initSetupInfo = false;
            initEqParameter = false;
            tabControl1.SelectedIndex = 0;
        }

        void showActivity()
        {
            if(cboActivity.Items.Count > 0) return;
            cboActivity.Items.Add("");
            cboActivity.Items.Add("ChangeState");
            cboActivity.Items.Add("ChangeCapacity");
            cboActivity.Items.Add("Reset");
            cboActivity.Items.Add("Setup");
            cboActivity.Items.Add("EqLogHistory");
            cboActivity.Items.Add("EqReserve");
            cboActivity.Items.Add("AddTooling");
            cboActivity.Items.Add("SetupClear");
            cboActivity.Items.Add("SetupTooling");
            cboActivity.Items.Add("UnloadTooling");
        }

        bool initSetupInfo = false;
        void showSetupInfo()
        {
            if (currentEqp == null) return;
            if (initSetupInfo) return;
            initSetupInfo = true;

            if (idv.mesCore.systemConfig.materialTracking && currentEqp.SetupInfo != null)
                lvwCurSetupMaterial.ShowMESItems(currentEqp.SetupInfo.ToSortedList());

            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                lvwCurTooling.RemoveAllMESItems();
                Type tToolingId = Type.GetType("mesRelease.TOL.ToolingId, toolingRelease");
                object returnValue = tToolingId.BaseType.InvokeMember("GetToolings", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                        System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { "", "", currentEqp.name, "", false });

                idv.messageService.itemBase[] toolingIds = returnValue as idv.messageService.itemBase[];
                if (toolingIds.Length > 0)
                    lvwCurTooling.ShowMESItems(toolingIds);
            }
        }

        bool initEqParameter = false;
        void showEqParameter()
        {
            if (currentEqp == null) return;
            if (initEqParameter) return;
            initEqParameter = true;

            bool addHisColumn = lvwEqParmHistory.Columns.Count == 0;

            tblCurParameter.Controls.Clear();
            tblCurParameter.RowStyles.Clear();
            tblCurParameter.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblCurParameter.RowCount = 1;
            EqTypeParameter[] parms = currentEqp.GetEqParameterData();
            int curRow = 0;
            bool col2 = false;
            tblCurParameter.Visible = false;
            for (int i = 0; i < parms.Length; i++)
            {
                EqTypeParameter parm = parms[i];
                if (i % 2 == 0)
                {
                    tblCurParameter.RowCount++;
                    tblCurParameter.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    curRow++;
                    col2 = false;
                }
                else
                    col2 = true;
                Label lbl = new Label();
                string caption = cultureLanguage.getValue(parm.name);
                if (caption.Equals(""))
                    lbl.Text = parm.name;
                else
                    lbl.Text = caption;
                lbl.AutoSize = true;
                tblCurParameter.Controls.Add(lbl, 0 + (col2 ? 2 : 0), curRow);
                lbl.Anchor = AnchorStyles.Right;

                TextBox txt = new TextBox();
                txt.TabIndex = 1;
                txt.ReadOnly = true;
                txt.ImeMode = System.Windows.Forms.ImeMode.Off;
                txt.Text = parm.value;
                tblCurParameter.Controls.Add(txt, 1 + (col2 ? 2 : 0), curRow);
                txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                if (addHisColumn)
                    lvwEqParmHistory.Columns.Add(lbl.Text);
            }
            tblCurParameter.Visible = true;

            if (addHisColumn)
            {
                foreach (ColumnHeader col in lvwEqParmHistory.Columns)
                    col.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void btnRefreshEqParm_Click(object sender, EventArgs e)
        {
            initEqParameter = false;
            showEqParameter();
        }
        private void btnQueryEqParm_Click(object sender, EventArgs e)
        {
            if (currentEqp == null) return;
            lvwEqParmHistory.Items.Clear();
            List<EqTypeParameter[]> lstHis = currentEqp.GetEqParameterDataHis(dtEqParmDateFrom.Value, dtEqParmDateTo.Value);
            foreach (EqTypeParameter[] parms in lstHis)
            {
                ListViewItem item = new ListViewItem(parms[0].value);
                for (int i = 1; i < parms.Length; i++)
                    item.SubItems.Add(parms[i].value);
                item.Tag = parms;
                lvwEqParmHistory.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            Close();
        }

        private void btnQueryHistory_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try { executeQueryHistory(dtFrom.Value, dtTo.Value); }
            catch { }
            Cursor = Cursors.Default;
        }

        void executeQueryHistory(DateTime from, DateTime to)
        {
            if (currentEqp == null) return;
            lvwHistory.Items.Clear();
            string sql = "select a.txn_sysid,a.equipment_id,a.activity,a.state,a.counter,a.lot_id,a.recipe,a.setup_info,a.modify_user," +
                            "a.modify_date,a.setup_info,b.state prevState,b.modify_date prevDate,c.user_name from mes_eqp_history a " +
                            "left join mes_eqp_history b on a.last_change_state=b.txn_sysid " +
                            "left join mes_user_profile c on a.modify_user=c.user_id "+
                            "where a.equipment_id=? and a.modify_date between ? and ?";
            if (cboActivity.Text != "")
                sql += " and a.activity=?";
            sql += " order by a.modify_date desc";
            DataSet ds;
            if (cboActivity.Text != "")
                ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentEqp.name, from, to.Date.AddDays(1), cboActivity.Text);
            else
                ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, currentEqp.name, from, to.Date.AddDays(1));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(dr["activity"].ToString());
                item.SubItems.Add(dr["state"].ToString());
                item.SubItems.Add(dr["prevState"].ToString());
                item.SubItems.Add(dr["recipe"].ToString());
                item.SubItems.Add(dr["lot_id"].ToString());
                item.SubItems.Add(dr["counter"].ToString());
                item.SubItems.Add(dr["user_name"].ToString());
                item.SubItems.Add(dr["modify_date"].ToString());
                item.Tag = dr;
                lvwHistory.Items.Add(item);
            }
        }

        private void btnHistoryDetail_Click(object sender, EventArgs e)
        {
            if (lvwHistory.SelectedItems.Count == 0) return;
            frmHistoryDetail detail = new frmHistoryDetail();
            try
            {
                detail.Init(lvwHistory.SelectedItems[0].Tag as DataRow);
                idv.utilities.cultureLanguage.switchLanguage(detail);
                detail.ShowDialog();
            }
            finally
            {
                detail.Close();
            }
        }

        private void lvwHistory_DoubleClick(object sender, EventArgs e)
        {
            btnHistoryDetail.PerformClick();
        }

        private void btnExportHistory_Click(object sender, EventArgs e)
        {
            if (lvwHistory.Items.Count > 0)
                mesRelease.utilities.ExcelAgent.WriteToFile(lvwHistory);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                new System.Threading.Thread(showSetupInfo).Start();
            if (tabControl1.SelectedIndex == 2)
                showEqParameter();
        }

    }
}
