using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.PRP;
using idv.utilities;
using idv.mesCore.Controls;

namespace mesBasicData
{
    public partial class frmStepConsumeMaterial : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        Step curItem = null;
        public frmStepConsumeMaterial()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Query"].Visible = false;
        }

        private void frmStepConsumeMaterial_Load(object sender, EventArgs e)
        {
            initToolbar();
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(lvwMaterialType.columnNames);
            lstTags.AddRange(lvwMaterialType.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            lvwMaterialType.columnNames = lstNames.ToArray();
            lvwMaterialType.columnTags = lstTags.ToArray();
            lvwMaterialType.prepareColumns();
            lvwStep.prepareColumns();
            pnlExt.AutoSize = true;
        }

        private void frmStepConsumeMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (e.KeyChar == '.')
            {
                TextBox txt = sender as TextBox;
                if (txt.Text.IndexOf('.') != -1 || txt.SelectionStart == 0)
                    e.Handled = true;
            }
            else if (!char.IsNumber(e.KeyChar))
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

        private void lvwStep_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                curItem = null;
                lvwMaterialType.RemoveAllMESItems();
            }
            else
            {
                curItem = item as Step;
                lvwMaterialType.ShowMESItems(curItem.GetMaterialTypes());
            }
        }

        private void lvwMaterialType_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                cboMaterialType.SelectedItem = null;
                txtConsumeRate.Text = "";
                rdoYes.Checked = true;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                mesRelease.MAT.StepMaterialType mt = item as mesRelease.MAT.StepMaterialType;
                cboMaterialType.Text = mt.name;
                txtConsumeRate.Text = mt.consumeRate.ToString();
                if (mt.required)
                    rdoYes.Checked = true;
                else
                    rdoNo.Checked = true;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(mt);
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
            }
        }

        void executeAdd()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!appInstance.CheckInputData(cboMaterialType, lblMaterialType, txtConsumeRate, lblConsumeRate)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;

            try
            {
                mesRelease.MAT.StepMaterialType item = new mesRelease.MAT.StepMaterialType();
                item.name = cboMaterialType.Text;
                item.stepId = curItem.name;
                item.consumeRate = Convert.ToDouble(txtConsumeRate.Text);
                item.required = rdoYes.Checked;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                lvwMaterialType.UpdateMESItem(item);
                curItem.addMaterialType(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            if (lvwMaterialType.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(cboMaterialType, lblMaterialType, txtConsumeRate, lblConsumeRate))
                return;

            mesRelease.MAT.StepMaterialType item = lvwMaterialType.selectedMESItem as mesRelease.MAT.StepMaterialType;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;

            try
            {
                item.name = cboMaterialType.Text;
                item.stepId = curItem.name;
                item.consumeRate = Convert.ToDouble(txtConsumeRate.Text);
                item.required = rdoYes.Checked;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                lvwMaterialType.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
                item.Refresh();
            }
        }

        void executeDelete()
        {
            if (lvwMaterialType.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;

            try
            {
                mesRelease.MAT.StepMaterialType item = lvwMaterialType.selectedMESItem as mesRelease.MAT.StepMaterialType;
                item.Delete();
                lvwMaterialType.RemoveMESItem(item);
                curItem.removeMaterialType(item.name);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        private void frmStepConsumeMaterial_Activated(object sender, EventArgs e)
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

            if (idv.utilities.misc.IsValueChanged("frmMaterialType", Name))
            {
                string orgType = cboMaterialType.Text;
                cboMaterialType.Items.Clear();
                cboMaterialType.Items.AddRange(idv.mesCore.misc.MaterialTypeGet());
                if (!orgType.Equals(""))
                    cboMaterialType.Text = orgType;
            }

            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmStepConsumeMaterial_Activated", null);
      
        }
    }
}
