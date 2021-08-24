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
using idv.mesCore.CAR;
using mesRelease.CAR;
using mesRelease.CAR.Txn;

namespace mesBasicData
{
    public partial class frmCarrier : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmCarrier()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Clean", "CLEAN");
            actionToolbar1.addButton("CleanOK", "CLEAN");
        }

        private void frmCarrier_Load(object sender, EventArgs e)
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

        private void frmCarrier_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
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
                case "Import":
                    executeImport();
                    break;
                case "Export":
                    executeExport();
                    break;
                case "Clean":
                    executeClean();
                    break;
                case "CleanOK":
                    executeCleanOK();
                    break;

            }
        }

        void getCarrierTypes()
        {
            string orgValue = cboCarrierType.Text;
            cboCarrierType.Items.Clear();

            cboCarrierType.Items.Add("");
            foreach (CarrierType t in CarrierType.getCarrierTypes(""))
                cboCarrierType.Items.Add(t.name);
            
            if (cboCarrierType.Items.Count == 2)
            {
                cboCarrierType.SelectedIndex = 1;
                cboCarrierType.Enabled = false;
            }
            if (!orgValue.Equals(""))
                cboCarrierType.Text = orgValue;
        }

        void executeQuery()
        {
            Carrier[] items = new Carrier[0];
            if (txtCarrierId.Text.Trim() != "")
            {
                Carrier item = new Carrier(txtCarrierId.Text);
                if (item.sysid != "")
                {
                    items = new Carrier[1];
                    items[0] = item;
                }
            }
            else if (txtRFID.Text.Trim() != "")
            {
                Carrier item = new Carrier(txtRFID.Text, true);
                if (item.sysid != "")
                {
                    items = new Carrier[1];
                    items[0] = item;
                }
            }
            else if (cboCarrierType.Text != "")
            {
                items = Carrier.getCarriers(cboCarrierType.Text, 0, 0, "", "", "", 0, 0);
            }
            else
                items = Carrier.getCarriers();

            mesListView1.ShowMESItems(items);
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtCarrierId,lblCarrierId,cboCarrierType,lblCarrierType)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                Carrier item = new Carrier();
                item.name = txtCarrierId.Text;
                item.carrierType = cboCarrierType.Text;
                item.rfId = txtRFID.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;

                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

                item.New();
                item = new Carrier(item.name);
                mesListView1.UpdateMESItem(item);
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
            else if (!appInstance.CheckInputData(txtCarrierId, lblCarrierId, cboCarrierType, lblCarrierType))
                return;

            Carrier item = mesListView1.selectedMESItem as Carrier;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                item.name = txtCarrierId.Text;
                item.carrierType = cboCarrierType.Text;
                item.rfId = txtRFID.Text;
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
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            Carrier item = mesListView1.selectedMESItem as Carrier;
            try
            {
                item.Delete();
                mesListView1.RemoveMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeClear()
        {
            txtCarrierId.Text = "";
            txtRFID.Text = "";
            if (cboCarrierType.Enabled)
                cboCarrierType.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }
        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("CarrierId,CarrierType,RFID".Split(','));
            foreach (DataColumn col in table.Columns)
                columns.Remove(col.ColumnName);
            if (columns.Count > 0)
            {
                appInstance.showInformationById("invalidFormat", informationType.warn);
                return;
            }
            foreach (DataRow row in table.Rows)
            {
                try
                {
                    Carrier item = new Carrier();
                    item.name = row["CarrierId"].ToString();
                    item.carrierType = row["CarrierType"].ToString();
                    item.rfId = row["RFID"].ToString();
                    item.createUser = mesRelease.USR.User.loginUser.name;
                    item.createDate = DateTime.Now;
                    item.New();
                    item = new Carrier(item.name);
                    mesListView1.UpdateMESItem(item);
                }
                catch (Exception ex)
                {
                    allSucceed = false;
                    messageBox.showMessage(ex.Message, messageStyle.error);
                    break;
                }
            }
            if (allSucceed)
                messageBox.showMessageById("msgExecuteSucceed");
        }
        void executeImport2()
        {
            bool succeed = false;
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "excel(*.xls)|*.xls";
            ofg.ShowDialog();
            if (ofg.FileName == "") return;
            using (System.IO.TextReader reader = new System.IO.StreamReader(ofg.FileName, Encoding.Default))
            {
                bool check = false;
                mesListView1.RemoveAllMESItems();
                do
                {
                    string s = reader.ReadLine();
                    if (s == null) break;
                    if (!check)
                    {
                        if (!s.ToUpper().StartsWith("CarrierId\tCarrierType\tRFID".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {                        
                        string[] car = s.Split('\t');
                        try
                        {
                            Carrier item = new Carrier();
                            item.name = car[0];
                            item.carrierType = car[1];
                            item.rfId = car[2];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;
                            item.New();
                            item = new Carrier(item.name);
                            mesListView1.UpdateMESItem(item);
                        }
                        catch (Exception ex)
                        {
                            succeed = false;
                            appInstance.showInformation(ex.Message, informationType.error);
                            break;
                        }
                    }
                } while (true);
            }
            if (succeed) 
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(mesListView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void executeClean()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }            
            Carrier item = mesListView1.selectedMESItem as Carrier;
            if (item.status != CarrierStatus.IDLE.ToString())
            {
                appInstance.showInformation(cultureLanguage.getValue("notInStatus", CarrierStatus.IDLE.ToString()), informationType.warn);                
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonClean"))) return;
            try
            {
                CleanCarrier cleanTxn = new CleanCarrier();
                cleanTxn.Add(item);
                cleanTxn.txnUser = mesRelease.USR.User.loginUser.name;                
                cleanTxn.doTxn();

                item = new Carrier(item.name);
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeCleanOK()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            Carrier item = mesListView1.selectedMESItem as Carrier;
            if (item.status != CarrierStatus.CLEAN.ToString())
            {
                appInstance.showInformation(cultureLanguage.getValue("notInStatus", CarrierStatus.CLEAN.ToString()), informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonCleanOK"))) return;
            try
            {
                CleanOK cleanTxn = new CleanOK();
                cleanTxn.Add(item);
                cleanTxn.txnUser = mesRelease.USR.User.loginUser.name;
                cleanTxn.doTxn();

                item = new Carrier(item.name);
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
            }
            else
            {
                Carrier c = item as Carrier;
                if (c != null)
                {
                    txtCarrierId.Text = c.name;
                    cboCarrierType.Text = c.carrierType;
                    txtRFID.Text = c.rfId;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(c);
                }
            }  
        }

        private void frmCarrier_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmCarrierType", Name))
            {
                getCarrierTypes();
            }
            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmCarrier_Activated", null);
        }
    }
}
