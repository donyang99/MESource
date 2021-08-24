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
    public partial class frmEquipmentGroup : Form
    {
        string selectedItem = "";
        List<string> eqGroups = new List<string>();
        public frmEquipmentGroup()
        {
            InitializeComponent();
            initToolbar();
            initData();
            lvwAvailable.prepareColumns();
            lvwAvailable.MultiSelect = true;
            lvwSelected.prepareColumns();
            lvwSelected.MultiSelect = true;
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query  
            actionToolbar1.addButton("Rollout", "ROLLOUT");          
            actionToolbar1.Items["Query"].Visible = false;
        }

        void initData()
        {
            eqGroups.AddRange(EqGroup.GetGroup());
            lstGroups.Items.AddRange(eqGroups.ToArray());            
        }

        DateTime lastEnter = DateTime.Now;
        private void txtEquipmentGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                lstGroups.SelectedItem = null;
                lstGroups.Items.Clear();
                foreach (string s in eqGroups)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(s, txtEquipmentGroup.Text.Replace('*', '+')))
                        lstGroups.Items.Add(s);
                }
                txtEquipmentGroup.Text = "";
            }
            else if (e.KeyValue == 13)
            {
                if ((DateTime.Now - lastEnter).TotalSeconds < 0.5 && txtEquipmentGroup.Text.Trim().Length > 0)
                    executeAdd();
                else
                    lastEnter = DateTime.Now;
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
                case "Rollout":
                    executeRollout();
                    break;
            }
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtEquipmentGroup, lblEquipmentGroup))
                return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                EqGroup.AddGroup(txtEquipmentGroup.Text, mesRelease.USR.User.loginUser.name);
                lstGroups.SelectedIndex = lstGroups.Items.Add(txtEquipmentGroup.Text);
                eqGroups.Add(txtEquipmentGroup.Text);
                txtEquipmentGroup.Text = "";
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify() 
        {
            if (lstGroups.SelectedItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                var equipments = EqGroup.GetEquipments(lstGroups.Text, false);
                var newequipments = lvwSelected.GetAllMESItem().OfType<Equipment>().ToList();
                newequipments.Except(equipments, new IEquipmentCompare()).ToList().ForEach(item => EqGroup.AddEquipment(lstGroups.Text, item));
                equipments.Except(newequipments, new IEquipmentCompare()).ToList().ForEach(item => EqGroup.DeleteEquipment(lstGroups.Text, item));
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {            
            if (lstGroups.SelectedItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                EqGroup.DeleteGroup(lstGroups.Text);
                if (eqGroups.Remove(lstGroups.Text))
                    lstGroups.Items.Remove(lstGroups.Text);                
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeRollout()
        {
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonRollout"))) return;           
            try
            {
                idv.messageService.serverCommand cmd = new idv.messageService.serverCommand();
                cmd.name = "refreshEquipmentList";
                cmd.requestReply = false;
                cmd.To = "Client:";

                cmd.send();
            }
            catch { }
        }

        void showSelectedItems()
        {
            lvwAvailable.UpdateMESItem(lvwSelected.GetAllMESItem());
            lvwSelected.RemoveAllMESItems();
            if (selectedItem == "")
            {
                btnSelect.Enabled = false;
                btnUnSelect.Enabled = false;
            }
            else
            {
                lvwSelected.UpdateMESItem(EqGroup.GetEquipments(lstGroups.Text, false));
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                btnSelect.Enabled = true;
                btnUnSelect.Enabled = true;
            }
        }

        private void lstGroups_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstGroups.Text == selectedItem) return;
            selectedItem = lstGroups.Text;
            showSelectedItems();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (idv.messageService.itemBase item in lvwAvailable.selectedMESItems)
            {
                try
                {
                    //EqGroup.AddEquipment(lstGroups.Text, item as Equipment);
                    lvwAvailable.RemoveMESItem(item);
                    lvwSelected.UpdateMESItem(item);
                }
                catch { }
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            foreach (idv.messageService.itemBase item in lvwSelected.selectedMESItems)
            {
                try
                {
                    //EqGroup.DeleteEquipment(lstGroups.Text, item as Equipment);
                    lvwSelected.RemoveMESItem(item);
                    lvwAvailable.UpdateMESItem(item);
                }
                catch { }
            }
        }

        private void lvwAvailable_DoubleClick(object sender, EventArgs e)
        {
            if (lvwAvailable.selectedMESItem != null)
                btnSelect.PerformClick();
        }

        private void lvwSelected_DoubleClick(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem != null)
                btnUnSelect.PerformClick();
        }

        private void frmEquipmentGroup_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmEquipment", Name))
            {
                lvwAvailable.ShowMESItems(Equipment.GetEquipments(true, false));
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
            }
        }
    }

    public class IEquipmentCompare : IEqualityComparer<Equipment>
    {
        public bool Equals(Equipment x, Equipment y)
        {
            return x.name == y.name;
        }

        public int GetHashCode(Equipment obj)
        {
            return obj.name.GetHashCode();
        }
    }
}
