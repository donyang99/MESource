using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.PRP;
using mesRelease.PARM;
using idv.utilities;
using idv.mesCore.Controls;

namespace mesBasicData
{
    public partial class frmStepParameter : Form
    {
        StepParameter curItem = null;
        public frmStepParameter()
        {
            InitializeComponent();
            initToolbar();
            lvwStep.prepareColumns();
            lvwSelected.prepareColumns();
            lvwAvailable.prepareColumns();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Add"].Visible = false;
            actionToolbar1.Items["Delete"].Visible = false;
            actionToolbar1.Items["Query"].Visible = false;
        }

        private void lvwStep_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            lvwAvailable.UpdateMESItem(lvwSelected.GetAllMESItem());
            lvwSelected.RemoveAllMESItems();
            if (!selected)
            {
                curItem = null;
                btnSelect.Enabled = false;
                btnUnSelect.Enabled = false;
            }
            else
            {
                curItem = new StepParameter(item.name);                
                lvwSelected.UpdateMESItem(curItem.Items.ToArray());
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                btnSelect.Enabled = true;
                btnUnSelect.Enabled = true;
            }
        }       

        private void actionToolbar1_ActionClicked(string actionName)
        {
            appInstance.showInformation("");
            switch (actionName)
            {
                case "Modify":
                    executeModify();
                    break;
            }
        }

        void executeModify()
        {
            appInstance.showInformation("");
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;

            try
            {
                curItem.Clear();
                foreach (ListViewItem item in lvwSelected.Items)
                    curItem.Add(item.Tag as Parameter);
                curItem.Modify();                
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lvwSelected.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwSelected.SelectedItems[0];
            i = item.Index - 1;
            if (i < 0) return;
            lvwSelected.Items.Remove(item);
            lvwSelected.Items.Insert(i, item);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lvwSelected.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = lvwSelected.SelectedItems[0];
            i = item.Index + 1;
            if (i >= lvwSelected.Items.Count) return;
            lvwSelected.Items.Remove(item);
            lvwSelected.Items.Insert(i, item);  
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvwAvailable.selectedMESItem == null) return;
            lvwSelected.UpdateMESItem(lvwAvailable.selectedMESItem);
            lvwAvailable.RemoveMESItem(null);
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            lvwAvailable.UpdateMESItem(lvwSelected.selectedMESItem);
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

        private void frmStepParameter_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmStep", Name))
            {
                string orgSelect = "";
                if (lvwStep.selectedMESItem != null)
                    orgSelect = lvwStep.selectedMESItem.name;

                lvwStep.ShowMESItems(Step.GetActiveVersionSteps(""));

                if (!orgSelect.Equals(""))
                    lvwStep.SelectMESItem(orgSelect);
            }

            if (idv.utilities.misc.IsValueChanged("frmParameter", Name))
            {
                lvwAvailable.ShowMESItems(Parameter.GetParameters());
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
            }
        }
    }
}
