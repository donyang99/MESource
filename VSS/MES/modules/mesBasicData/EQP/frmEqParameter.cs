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

namespace mesBasicData
{
    public partial class frmEqParameter : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmEqParameter()
        {
            InitializeComponent();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query  
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Export", "");
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
                case "Export":
                    executeExport();
                    break;
                case "Clear":
                    executeClear();
                    break;
                case "Query":
                    executeQuery();
                    break;
            }
        }

        private void frmEqParameter_Load(object sender, EventArgs e)
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
        }

        private void frmEqParameter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        idv.mesCore.DataType ControlDataType
        {
            get
            {
                if (rdoString.Checked)
                    return idv.mesCore.DataType.String;
                else if (rdoNumber.Checked)
                    return idv.mesCore.DataType.Numeric;
                else
                    return idv.mesCore.DataType.Options;
            }
            set
            {
                if (value == idv.mesCore.DataType.String)
                    rdoString.Checked = true;
                else if (value == idv.mesCore.DataType.Numeric)
                    rdoNumber.Checked = true;
                else
                    rdoOptions.Checked = true;
            }
        }

        void executeClear()
        {
            txtParameterName.Text = "";
            txtEqDataId.Text = "";
            txtDescription.Text = "";
            rdoString.Checked = true;
            txtLength.Text = "";
            txtOptions.Text = "";
        }

        void executeQuery()
        {
            mesListView1.ShowMESItems(EqParameter.GetEqParameters(txtParameterName.Text));
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtParameterName, lblParameterName, txtLength, lblLength)) return;
            if (ControlDataType == idv.mesCore.DataType.Options && txtOptions.Text.Trim().Equals(""))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", rdoOptions.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                EqParameter item = new EqParameter();
                item.name = txtParameterName.Text;
                item.eqDataId = txtEqDataId.Text;
                item.dataType = ControlDataType;
                item.length = Convert.ToInt32(txtLength.Text);
                item.optionList = txtOptions.Text;
                item.description = txtDescription.Text;

                item.modifyUser = mesRelease.USR.User.loginUser.name;
                item.modifyDate = idv.messageService.serviceHost.dateTime;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

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

        void executeModify()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(txtParameterName, lblParameterName, txtLength, lblLength))
                return;
            if (ControlDataType == idv.mesCore.DataType.Options && txtOptions.Text.Trim().Equals(""))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", rdoOptions.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            EqParameter item = mesListView1.selectedMESItem as EqParameter;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                item.name = txtParameterName.Text;
                item.eqDataId = txtEqDataId.Text;
                item.dataType = ControlDataType;
                item.length = Convert.ToInt32(txtLength.Text);
                item.optionList = txtOptions.Text;
                item.description = txtDescription.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
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
            EqParameter item = mesListView1.selectedMESItem as EqParameter;
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
                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                EqParameter p = item as EqParameter;
                if (p != null)
                {
                    txtParameterName.Text = p.name;
                    ControlDataType = p.dataType;
                    txtLength.Text = p.length.ToString();
                    txtOptions.Text = p.optionList;
                    txtEqDataId.Text = p.eqDataId;
                    txtDescription.Text = p.description;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(p);
                }
            }  
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            txtOptions.Enabled = rdoOptions.Checked;
            if (txtOptions.Enabled)
                txtOptions.BackColor = SystemColors.Info;
            else
                txtOptions.BackColor = SystemColors.Control;
        }
    }
}
