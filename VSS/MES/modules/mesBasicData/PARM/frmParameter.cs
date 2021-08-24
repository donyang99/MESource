using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mesRelease.PARM;
using idv.utilities;
using idv.mesCore.Controls;
using idv.messageService;

namespace mesBasicData
{
    public partial class frmParameter : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmParameter()
        {
            InitializeComponent();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Export", "");
        }

        private void frmParameter_Load(object sender, EventArgs e)
        {
            initToolbar();
            cboStepDC.Items.Add(new mesRelease.PRP.DCItem());
            cboStepDC.Items.AddRange(mesRelease.PRP.DCItem.getDCItems());
            if (idv.mesCore.systemConfig.validItem("eqParameter"))
            {
                cboEqParameter.Items.Add(new mesRelease.EQP.EqParameter());
                cboEqParameter.Items.AddRange(mesRelease.EQP.EqParameter.GetEqParameters());
            }
            else
            {
                lblEqParameter.Visible = false;
                cboEqParameter.Visible = false;
                mesListView1.columnHide = "eqParmSysId".Split(',');
            }
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

            executeQuery();
        }

        private void frmParameter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void actionToolbar1_ActionClicked(string actionName)
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
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeQuery()
        {
            mesListView1.ShowMESItems(Parameter.GetParameters());
            foreach(ListViewItem item in mesListView1.Items)
                ShowListDCItemName(item.Tag as itemBase);
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtParameter, lblParameter)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                Parameter item = new Parameter();
                item.name = txtParameter.Text;
                if (rdoString.Checked)
                    item.parmType = idv.mesCore.PARM.ParameterType.String;
                else if (rdoNumber.Checked)
                    item.parmType = idv.mesCore.PARM.ParameterType.Numeric;
                else
                    item.parmType = idv.mesCore.PARM.ParameterType.Range;
                item.dcItemSysid = SelectedDCItemSysId;
                item.eqParmSysId = SelectedEqParamSysId;
                item.description = txtDescription.Text;

                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                mesListView1.UpdateMESItem(item);
                ShowListDCItemName(item);
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
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(txtParameter, lblParameter))
                return;

            Parameter item = mesListView1.selectedMESItem as Parameter;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            
            try
            {
                item.name = txtParameter.Text;
                if (rdoString.Checked)
                    item.parmType = idv.mesCore.PARM.ParameterType.String;
                else if (rdoNumber.Checked)
                    item.parmType = idv.mesCore.PARM.ParameterType.Numeric;
                else
                    item.parmType = idv.mesCore.PARM.ParameterType.Range;
                item.dcItemSysid = SelectedDCItemSysId;
                item.eqParmSysId = SelectedEqParamSysId;
                item.description = txtDescription.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();

                mesListView1.UpdateCurrentItem(item);
                ShowListDCItemName(item);
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
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            Parameter item = mesListView1.selectedMESItem as Parameter;
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

        string SelectedDCItemSysId
        {
            get
            {
                mesRelease.PRP.DCItem dcItem = cboStepDC.SelectedItem as mesRelease.PRP.DCItem;
                if(dcItem == null) return "";
                return dcItem.sysid;
            }
            set
            {
                cboStepDC.SelectedIndex = -1;
                foreach(mesRelease.PRP.DCItem dcItem in cboStepDC.Items)
                {
                    if(dcItem.sysid.Equals(value))
                    {
                        cboStepDC.SelectedItem = dcItem;
                        break;
                    }
                }
            }
        }

        string SelectedEqParamSysId
        {
            get
            {
                mesRelease.EQP.EqParameter eqParm = cboEqParameter.SelectedItem as mesRelease.EQP.EqParameter;
                if (eqParm == null) return "";
                return eqParm.sysid;
            }
            set
            {
                cboEqParameter.SelectedIndex = -1;
                foreach (mesRelease.EQP.EqParameter eqParm in cboEqParameter.Items)
                {
                    if (eqParm.sysid.Equals(value))
                    {
                        cboEqParameter.SelectedItem = eqParm;
                        break;
                    }
                }
            }
        }

        void ShowListDCItemName(itemBase item)
        {
            foreach(ListViewItem vItem in mesListView1.Items)
            {
                if(!item.Equals(vItem.Tag)) continue;
                Parameter par = item as Parameter;
                foreach(mesRelease.PRP.DCItem dcItem in cboStepDC.Items)
                {
                    if(dcItem.sysid.Equals(par.dcItemSysid))
                    {
                        vItem.SubItems[2].Text = dcItem.name;
                        break;
                    }
                }
                if (idv.mesCore.systemConfig.validItem("eqParameter"))
                {
                    foreach (mesRelease.EQP.EqParameter eqParm in cboEqParameter.Items)
                    {
                        if (eqParm.sysid.Equals(par.eqParmSysId))
                        {
                            vItem.SubItems[3].Text = eqParm.name;
                            break;
                        }
                    }
                }
                break;
            }            
        }

        private void mesListView1_MESItemSelectionChanged(itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                txtParameter.Text = "";
                txtDescription.Text = "";
                cboStepDC.SelectedIndex = -1;
                cboEqParameter.SelectedIndex = -1;
                rdoString.Checked = true;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                Parameter p = item as Parameter;
                if (p != null)
                {
                    txtParameter.Text = p.name;
                    if (p.parmType == idv.mesCore.PARM.ParameterType.String)
                        rdoString.Checked = true;
                    else if (p.parmType == idv.mesCore.PARM.ParameterType.Numeric)
                        rdoNumber.Checked = true;
                    else if (p.parmType == idv.mesCore.PARM.ParameterType.Range)
                        rdoRange.Checked = true;
                    SelectedDCItemSysId = p.dcItemSysid;
                    SelectedEqParamSysId = p.eqParmSysId;
                    txtDescription.Text = p.description;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(p);
                }
            }   
        }
    }
}
