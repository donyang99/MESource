using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.Controls;
using idv.utilities;
using mesRelease.EQP;
using idv.mesCore.EQP;

namespace mesBasicData
{
    public partial class frmEquipmentType : Form, idv.messageService.appModuleFunctionForm
    {
        Dictionary<string, EqParameter> dicEqParms = new Dictionary<string, EqParameter>();
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmEquipmentType()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Export", "");
        }

        private void frmEquipmentType_Activated(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.validItem("eqParameter") && idv.utilities.misc.IsValueChanged("frmEqParameter", Name))
            {
                dicEqParms.Clear();
                foreach (EqParameter parm in EqParameter.GetEqParameters())
                    dicEqParms[parm.name] = parm;
                lvwAvailable.ShowMESItems(dicEqParms.Values.ToArray());
                EqType t = mesListView1.selectedMESItem as EqType;
                if (t != null)
                {
                    lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                }
            }
        }

        private void frmEquipmentType_Load(object sender, EventArgs e)
        {
            initToolbar();
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(mesListView1.columnNames);
            lstTags.AddRange(mesListView1.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            mesListView1.columnNames = lstNames.ToArray();
            mesListView1.columnTags = lstTags.ToArray();
            mesListView1.prepareColumns();
            pnlExt.AutoSize = true;
            listToolType();
            grpTrack.Visible = idv.mesCore.systemConfig.materialTracking;
            grpEqParameter.Visible = idv.mesCore.systemConfig.validItem("eqParameter");
            if (grpEqParameter.Visible)
            {
                grpEqParameter.Height = (int)((double)Height * 0.4);
                lvwAvailable.prepareColumns();
                lvwSelected.prepareColumns();
            }
        }

        private void frmEquipmentType_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void listToolType()
        {
            cboToolType.Items.Add("");
            if (idv.mesCore.systemConfig.singleEqType)
            {
                cboToolType.Items.Add(idv.mesCore.EQP.EqToolType.Process);
                cboToolType.Items.Add(idv.mesCore.EQP.EqToolType.Measure);
            }
            else
            {
                int i = 0;                
                do
                {
                    EqToolType t = (EqToolType)i;
                    if (i.ToString() == t.ToString())
                        break;

                    cboToolType.Items.Add(t);
                    i++;
                } while (true);
            }
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            appInstance.showInformation("");
            switch (actionName)
            {
                case "Add":
                    executeAdd();
                    break;
                case "Modify":
                    executeModify();
                    break;
                case "Delete":
                    executeDelete();
                    break;
                case "Query":
                    executeQuery();
                    break;
                case "Clear":
                    executeClear();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeClear()
        {
            txtEqType.Text = "";
            txtCapacity.Text = "";
            txtTrackCount.Text = "";
            txtOwner.Text = "";
            txtDescription.Text = "";
            cboToolType.Text = "";
            lvwTrack.Items.Clear();
            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            string condition = "";
            if (txtEqType.Text.Trim() != "")
                condition = "eq_type like '%" + txtEqType.Text.Trim() + "%'";
            if (cboToolType.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "tool_type = " + ((int)(EqToolType)cboToolType.SelectedItem).ToString();
            }
            EqType[] items = EqType.GetEqTypes(condition);
            mesListView1.ShowMESItems(items);
        }

        void executeAdd()
        {
            bool check = appInstance.CheckInputData(txtEqType, lblEqType, txtCapacity, lblCapacity, cboToolType, lblToolType);
            if (!check) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                EqType item = new EqType();
                item.name = txtEqType.Text;
                item.toolType = (EqToolType)cboToolType.SelectedItem;
                item.capacity = Convert.ToInt32(txtCapacity.Text);
                item.consumeType = rdoByLot.Checked ? EqConsumeType.ByLot : EqConsumeType.ByComponentQty;
                item.counterFlag = rdoYes.Checked;
                item.owner = txtOwner.Text;
                item.description = txtDescription.Text;
                item.trackCount = (short)lvwTrack.Items.Count;
                foreach (ListViewItem vItem in lvwTrack.Items)
                    item.AddTrack(vItem.Text);
                if (idv.mesCore.systemConfig.validItem("eqParameter"))
                    item.parameterCount = (short)lvwSelected.Items.Count; 
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

                if (idv.mesCore.systemConfig.validItem("eqParameter"))
                    item.New(getSelectedTypeParms(item.name, item.createUser, item.createDate));
                else
                    item.New();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }
        EqTypeParameter[] getSelectedTypeParms(string eqType, string userId, DateTime date)
        {
            List<EqTypeParameter> list = new List<EqTypeParameter>();
            int i = 0;
            foreach (ListViewItem item in lvwSelected.Items)
            {
                EqTypeParameter typeParm = item.Tag as EqTypeParameter;
                if (typeParm == null) continue;
                typeParm.eqType = eqType;
                typeParm.seq = i;
                typeParm.modifyUser = userId;
                typeParm.modifyDate = date;
                i++;
                list.Add(typeParm);
            }
            return list.ToArray();
        }

        void executeModify()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else
            {
                bool check = appInstance.CheckInputData(txtEqType, lblEqType, txtCapacity, lblCapacity, cboToolType, lblToolType);
                if (!check) return;
            }            
            EqType item = mesListView1.selectedMESItem as EqType;
            if (item.name != txtEqType.Text)
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblEqType.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                item.toolType = (EqToolType)cboToolType.SelectedItem;
                item.capacity = Convert.ToInt32(txtCapacity.Text);
                item.consumeType = rdoByLot.Checked ? EqConsumeType.ByLot : EqConsumeType.ByComponentQty;
                item.counterFlag = rdoYes.Checked;
                item.owner = txtOwner.Text;
                item.description = txtDescription.Text;
                item.ClearTracks();
                item.trackCount = (short)lvwTrack.Items.Count;
                foreach (ListViewItem vItem in lvwTrack.Items)
                    item.AddTrack(vItem.Text);
                if (idv.mesCore.systemConfig.validItem("eqParameter"))
                    item.parameterCount = (short)lvwSelected.Items.Count;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                if (idv.mesCore.systemConfig.validItem("eqParameter"))
                    item.Modify(getSelectedTypeParms(item.name, item.createUser, item.createDate));
                else
                    item.Modify();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            EqType item = mesListView1.selectedMESItem as EqType;
            if (item.createUser == "System")
            {
                appInstance.showInformationById("cantDelDefaults", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                item.Delete();
                mesListView1.RemoveMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(mesListView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
                if (idv.mesCore.systemConfig.validItem("eqParameter"))
                {
                    lvwAvailable.ShowMESItems(dicEqParms.Values.ToArray());
                    lvwSelected.RemoveAllMESItems();
                }
            }
            else
            {
                EqType t = item as EqType;
                if (t != null)
                {
                    txtEqType.Text = t.name;
                    cboToolType.SelectedItem = t.toolType;
                    txtCapacity.Text = t.capacity.ToString();
                    txtTrackCount.Text = t.trackCount == 0 ? "" : t.trackCount.ToString();
                    if (t.consumeType == EqConsumeType.ByLot)
                        rdoByLot.Checked = true;
                    else
                        rdoByComponent.Checked = true;
                    txtOwner.Text = t.owner;
                    txtDescription.Text = t.description;
                    if (t.counterFlag)
                        rdoYes.Checked = true;
                    else
                        rdoNo.Checked = true;

                    lvwTrack.Items.Clear();
                    foreach (string track in t.tracks)
                        lvwTrack.Items.Add(track);

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(t);

                    if (idv.mesCore.systemConfig.validItem("eqParameter"))
                    {
                        lvwSelected.ShowMESItems(t.GetEqParameters());
                        lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                    }
                }
            }  
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void lvwTrack_Resize(object sender, EventArgs e)
        {
            lvwTrack.Columns[0].Width = lvwTrack.Width - 20;
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            string track = txtTrack.Text.Trim();
            if (track.Equals("")) return;
            foreach (ListViewItem item in lvwTrack.Items)
            {
                if (item.Text.Equals(track))
                    return;
            }
            lvwTrack.Items.Add(track);
            txtTrack.Text = "";
        }

        private void btnDeleteTrack_Click(object sender, EventArgs e)
        {
            if (lvwTrack.SelectedItems.Count == 0) return;
            lvwTrack.SelectedItems[0].Remove();
        }

        private void txtTrack_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddTrack.PerformClick();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lvwTrack.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwTrack.SelectedItems[0];
            i = item.Index - 1;
            if (i < 0) return;
            lvwTrack.Items.Remove(item);
            lvwTrack.Items.Insert(i, item);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lvwTrack.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwTrack.SelectedItems[0];
            i = item.Index + 1;
            if (i >= lvwTrack.Items.Count) return;
            lvwTrack.Items.Remove(item);
            lvwTrack.Items.Insert(i, item); 
        }

        private void btnParmUp_Click(object sender, EventArgs e)
        {
            if (lvwSelected.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwSelected.SelectedItems[0];
            i = item.Index - 1;
            if (i < 0) return;
            lvwSelected.Items.Remove(item);
            lvwSelected.Items.Insert(i, item);
        }

        private void btnParmDown_Click(object sender, EventArgs e)
        {
            if (lvwSelected.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwSelected.SelectedItems[0];
            i = item.Index + 1;
            if (i >= lvwSelected.Items.Count) return;
            lvwSelected.Items.Remove(item);
            lvwSelected.Items.Insert(i, item); 
        }

        private void lvwSelected_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                txtTableName.Text = "";
                txtColumnName.Text = "";
                txtEqDataId.Text = "";
                chkRequired.Checked = true;
            }
            else
            {
                EqTypeParameter parm = item as EqTypeParameter;
                if (parm != null)
                {
                    txtTableName.Text = parm.tableName;
                    txtColumnName.Text = parm.columnName;
                    txtEqDataId.Text = parm.eqDataId;
                    chkRequired.Checked = parm.required;
                }
            }
        }
        private void lvwSelected_Enter(object sender, EventArgs e)
        {
            EqTypeParameter parm = lvwSelected.selectedMESItem as EqTypeParameter;
            if (parm == null)
            {
                txtTableName.Text = "";
                txtColumnName.Text = "";
                txtEqDataId.Text = "";
                chkRequired.Checked = true;
            }
            else
            {
                txtTableName.Text = parm.tableName;
                txtColumnName.Text = parm.columnName;
                txtEqDataId.Text = parm.eqDataId;
                chkRequired.Checked = parm.required;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvwAvailable.selectedMESItem == null) return;
            if (!txtColumnName.Text.Trim().Equals("") && txtColumnName.Text.IndexOf(' ') >= 0) return;
            EqParameter eqParm = lvwAvailable.selectedMESItem as EqParameter;
            EqTypeParameter typeParm = new EqTypeParameter();
            typeParm.sysid = eqParm.sysid;
            typeParm.name = eqParm.name;
            typeParm.eqDataId = eqParm.eqDataId;
            typeParm.dataType = eqParm.dataType;
            typeParm.description = eqParm.description;
            typeParm.tableName = txtTableName.Text;
            typeParm.columnName = txtColumnName.Text;
            typeParm.eqDataId = txtEqDataId.Text;
            typeParm.required = chkRequired.Checked;
            lvwSelected.UpdateMESItem(typeParm);
            lvwAvailable.RemoveMESItem(null);
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            EqTypeParameter typeParm = lvwSelected.selectedMESItem as EqTypeParameter;
            EqParameter eqParm = null;
            if (dicEqParms.ContainsKey(typeParm.name))
                eqParm = dicEqParms[typeParm.name];
            lvwAvailable.UpdateMESItem(eqParm);
            lvwSelected.RemoveMESItem(null);
        }

        private void lvwSelected_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void lvwAvailable_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void lvwAvailable_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text.Trim().Equals(""))
                txtTableName.Focus();
            else
                txtColumnName.Focus();
        }

        private void btnConfirmParm_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            EqTypeParameter typeParm = lvwSelected.selectedMESItem as EqTypeParameter;
            typeParm.tableName = txtTableName.Text;
            typeParm.columnName = txtColumnName.Text;
            typeParm.eqDataId = txtEqDataId.Text;
            typeParm.required = chkRequired.Checked;
            lvwSelected.UpdateMESItem(typeParm);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTableName.Text = "";
            txtColumnName.Text = "";
            txtEqDataId.Text = "";
        }


    }
}
