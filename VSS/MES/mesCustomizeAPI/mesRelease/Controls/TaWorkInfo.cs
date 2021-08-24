using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesRelease.Controls
{
    public partial class TaWorkInformation : UserControl
    {
        public TaWorkInformation()
        {
            InitializeComponent();
        }

        string _sysId = "";
        public string sysId
        {
            get { return _sysId; }
            internal set { _sysId = value; }
        }

        string _taWorkInfo = "";
        public string taWorkInfo
        {
            get { return _taWorkInfo; }
            internal set { _taWorkInfo = value; }
        }

        public string stepId
        {
            get { return txtStepId.Text; }
        }

        public string equipmentId
        {
            get { return txtEquipmentId.Text; }
        }

        string _shift = "";
        public string shift
        {
            get { return _shift; }
            internal set { _shift = value; }
        }

        int _taCount = 0;
        public int taCount
        {
            get { return _taCount; }
            internal set { _taCount = value; }
        }

        DateTime _modifyDate = DateTime.MinValue;
        public DateTime modifyDate
        {
            get { return _modifyDate; }
            internal set { _modifyDate = value; }
        }

        bool showStepEquipment
        {
            get { return tblStepEquipment.Visible; }
            set { tblStepEquipment.Visible = value; }
        }

        public string GetStation(int index)
        {
            try
            {
                return lvwStation.Items[index].Text;
            }
            catch { }
            return "";
        }

        public string GetUserId(int index)
        {
            try
            {
                return lvwStation.Items[index].SubItems[1].Text;
            }
            catch { }
            return "";
        }
        public string GetUserId(string station)
        {
            try
            {
                foreach (ListViewItem item in lvwStation.Items)
                {
                    if (item.Text.Equals(station))
                        return item.SubItems[1].Text;
                }
            }
            catch { }
            return "";
        }

        public string GetUserName(int index)
        {
            try
            {
                return lvwStation.Items[index].SubItems[2].Text;
            }
            catch { }
            return "";
        }
        public string GetUserName(string station)
        {
            foreach (ListViewItem item in lvwStation.Items)
            {
                if (item.Text.Equals(station))
                    return item.SubItems[2].Text;
            }
            return "";
        }

        public void Clear()
        {
            txtStepId.Text = "";
            txtEquipmentId.Text = "";
            _sysId = "";
            _taWorkInfo = "";
            _shift = "";
            _taCount = 0;
            _modifyDate = DateTime.MinValue;
            lvwStation.Items.Clear();
        }
        public void Init(string stepId, string equipmentId)
        {
            Clear();
            TestPrivilege();
            txtStepId.Text = stepId;
            txtEquipmentId.Text = equipmentId;
            string sql = "select a.*,b.*,c.user_name from mes_ta_work_info a " +
                         "left join mes_ta_work_info_detail b on a.ta_work_info=b.ta_work_info " +
                         "left join mes_user_profile c on b.user_id=c.user_id " +
                         "where a.step_id=? and a.equipment_id=? order by b.station";
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter(sql, stepId, equipmentId);
            if (ds.Tables[0].Rows.Count == 0) return;
            lvwStation.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                _sysId = row["sysid"].ToString();
                _taWorkInfo = row["ta_work_info"].ToString();
                _shift = row["shift"].ToString();
                if (!row["modify_date"].Equals(DBNull.Value))
                    _modifyDate = Convert.ToDateTime(row["modify_date"]);
                break;
            }            

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (!row["station"].ToString().Equals(""))
                {
                    _taCount++;
                    ListViewItem item = new ListViewItem(row["station"].ToString());
                    item.SubItems.Add(row["user_id"].ToString());
                    item.SubItems.Add(row["user_name"].ToString());
                    lvwStation.Items.Add(item);
                }
            }
        }

        public override void Refresh()
        {
            if (txtStepId.Text.Equals("") || txtEquipmentId.Text.Equals("")) return;
            Init(txtStepId.Text, txtEquipmentId.Text);
            base.Refresh();
        }

        public bool TestPrivilege()
        {
            bool result = false;

            if (USR.User.loginUser != null)
                result = USR.User.loginUser.CheckFunctionPrivilege("RUN:RUNTIME:EditTaWorkInfo");

            btnEdit.Enabled = result;
            return result;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!TestPrivilege())
            {
                idv.utilities.messageBox.showMessageById("noPrivilege");
                return;
            }
            frmEditWorkInfo frm = new frmEditWorkInfo();
            try
            {
                frm.Init(this);
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                idv.utilities.messageBox.showMessage(ex.Message);
            }
            frm.Close();
        }
    }
}
