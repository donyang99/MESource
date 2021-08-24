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
using mesRelease.CAR;

namespace mesBasicData
{
    public partial class frmCarrierType : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmCarrierType()
        {
            InitializeComponent();
        }

        private void frmCarrierType_Load(object sender, EventArgs e)
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
            executeQuery();
        }

        private void frmCarrierType_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
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

        void executeQuery()
        {
            string condition = "";
            if (txtCarrierType.Text.Trim() != "")
                condition = "carrier_type like '%" + txtCarrierType.Text.Trim() + "%'";
            if (txtComponentSize.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "component_size = " + txtComponentSize.Text;
            }
            if (txtCapacity.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "capacity = " + txtCapacity.Text;
            }
            CarrierType[] items = CarrierType.getCarrierTypes(condition);
            mesListView1.ShowMESItems(items);
        }

        void executeAdd()
        {
            bool check = appInstance.CheckInputData(txtCarrierType, lblCarrierType, txtComponentSize, lblComponentSize,
                                                    txtCapacity, lblCapacity);
            if (!check) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                CarrierType item = new CarrierType();
                item.name = txtCarrierType.Text;
                item.componentSize = Convert.ToInt32(txtComponentSize.Text);
                item.capacity = Convert.ToInt32(txtCapacity.Text);
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;

                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

                item.New();
                mesListView1.UpdateMESItem(item);
                idv.utilities.misc.SetValueChangeByItemName(Name);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
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
            else 
            {
                bool check = appInstance.CheckInputData(txtCarrierType, lblCarrierType, txtComponentSize, lblComponentSize,
                                                    txtCapacity, lblCapacity);
                if (!check) return;
            }
            CarrierType item = mesListView1.selectedMESItem as CarrierType;
            if (item.name != txtCarrierType.Text)
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblCarrierType.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;            
            try
            {
                item.name = txtCarrierType.Text;
                item.componentSize = Convert.ToInt32(txtComponentSize.Text);
                item.capacity = Convert.ToInt32(txtCapacity.Text);
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
            
            CarrierType item = mesListView1.selectedMESItem as CarrierType;
            if (isCarrierTypeUsed(item.name)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            
            try
            {
                item.Delete();
                mesListView1.RemoveMESItem(item);
                idv.utilities.misc.SetValueChangeByItemName(Name);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeClear()
        {
            txtCarrierType.Text = "";
            txtComponentSize.Text = "";
            txtCapacity.Text = "";
            txtDescription.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
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
            }
            else
            {
                CarrierType t = item as CarrierType;
                if (t != null)
                {
                    txtCarrierType.Text = t.name;
                    txtComponentSize.Text = t.componentSize.ToString();
                    txtCapacity.Text = t.capacity.ToString();
                    txtDescription.Text = t.description;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(t);
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

        bool isCarrierTypeUsed(string carrierType)
        {
            string sql = "select count(*) from mes_carrier_id where carrier_type =?";
            if (idv.messageService.serviceHost.Client.getValueWithParameter(sql, carrierType).Equals("0"))
                return false;
            else
            {
                messageBox.showMessageById("cantDelDefaults", messageStyle.confirmation);
                return true;
            }
        }
    }
}
