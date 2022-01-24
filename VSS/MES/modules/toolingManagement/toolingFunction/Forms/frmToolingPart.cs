using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.utilities;
using idv.mesCore.Controls;
using mesRelease.TOL;

namespace toolingFunction
{
    public partial class frmToolingPart : Form, idv.messageService.appModuleFunctionForm
    {   //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }

        ToolingPart curItem = null;
        public frmToolingPart()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }
        private void frmToolingPart_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmToolingType", Name))
            {
                string selType = cboToolingType.Text;
                cboToolingType.Items.Clear();
                cboToolingType.Items.AddRange(ToolingType.GetToolingTypes());
                if (!selType.Equals(""))
                    cboToolingType.Text = selType;
            }
            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmToolingPart_Activated", null);
        }
        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("Clear", "");
            //actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");
        }
        private void frmToolingPart_Load(object sender, EventArgs e)
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

        private void frmToolingPart_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
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
                    executeShowData(null);
                    break;
                case "Import":
                    executeImport();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeShowData(ToolingPart item)
        {
            liveLimitFocusFlag = false;
            if (item == null)
            {
                txtPartNo.Text = "";
                cboToolingType.SelectedIndex = -1;
                lblTypeInfo.Text = "";
                txtUseLimit.Text = "";
                txtUseNotice.Text = "";
                txtDescription.Text = "";

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                txtPartNo.Text = item.name;
                txtUseLimit.Text = item.useLimit == 0 ? "" : item.useLimit.ToString();
                txtUseNotice.Text = item.useNotice == 0 ? "" : item.useNotice.ToString();
                cboToolingType.Text = item.toolingType;
                txtDescription.Text = item.description;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(item);
            }
            liveLimitFocusFlag = true;
        }

        void executeQuery()
        {
            mesListView1.ShowMESItems(ToolingPart.GetToolingParts(txtPartNo.Text.Trim(), cboToolingType.Text));
        }

        void assignValues(ToolingPart item)
        {
            ToolingType toolingType = cboToolingType.SelectedItem as ToolingType;
            item.toolingType = toolingType.name;
            item.typeSysId = toolingType.sysid;
            int limit = 0;
            int.TryParse(txtUseLimit.Text, out limit);
            item.useLimit = limit;
            limit = 0;
            int.TryParse(txtUseNotice.Text, out limit);
            item.useNotice = limit;
            item.description = txtDescription.Text;
            item.modifyUser = idv.mesCore.USR.userBase.loginUserId;

            if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
        }
        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtPartNo, lblPartNo, cboToolingType, lblToolingType, txtUseLimit, lblUseLimit)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ToolingPart item = new ToolingPart();
                item.name = txtPartNo.Text;
                assignValues(item);
                item.createUser = idv.mesCore.USR.userBase.loginUserId;
                item.createDate = idv.messageService.serviceHost.dateTime;

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
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!appInstance.CheckInputData(txtPartNo, lblPartNo, cboToolingType, lblToolingType, txtUseLimit, lblUseLimit)) return;
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                assignValues(curItem);
                curItem.Modify();
                mesListView1.UpdateMESItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                curItem.modifyUser = idv.mesCore.USR.userBase.loginUserId;
                curItem.Delete();
                mesListView1.RemoveMESItem(curItem);

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("PartNo,ToolingType,UseLimit,UseNotice,Description".Split(','));
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
                    ToolingPart item = new ToolingPart();
                    item.name = row["PartNo"].ToString();
                    item.toolingType = row["ToolingType"].ToString();
                    ToolingType toolingType = null;
                    foreach (ToolingType t in cboToolingType.Items)
                    {
                        if (t.name.Equals(item.toolingType))
                        {
                            toolingType = t;
                            break;
                        }
                    }
                    if (toolingType == null)
                        throw new Exception("Wrong ToolingType - [" + item.toolingType + "] (PartNo:" + item.name + ")");
                    item.typeSysId = toolingType.sysid;

                    if (toolingType.controlType != idv.mesCore.TOL.ControlType.None)
                    {
                        int limit = 0;
                        int.TryParse(row["UseLimit"].ToString(), out limit);
                        if (limit == 0)
                            throw new Exception("Wrong UseLimit (PartNo:" + item.name + ")");
                        item.useLimit = limit;

                        limit = 0;
                        int.TryParse(row["UseNotice"].ToString(), out limit);
                        item.useNotice = limit;
                    }
                    item.description = row["Description"].ToString();
                    item.createUser = idv.mesCore.USR.userBase.loginUserId;
                    item.createDate = idv.messageService.serviceHost.dateTime;
                    item.New();
                    item = new ToolingPart(item.name);
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
                        if (!s.ToUpper().StartsWith("PartNo\tToolingType\tUseLimit\tUseNotice\tDescription".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] part = s.Split('\t');
                        try
                        {
                            ToolingPart item = new ToolingPart();
                            item.name = part[0];
                            item.toolingType = part[1];
                            ToolingType toolingType = null;
                            foreach (ToolingType t in cboToolingType.Items)
                            {
                                if (t.name.Equals(item.toolingType))
                                {
                                    toolingType = t;
                                    break;
                                }
                            }
                            if (toolingType == null)
                                throw new Exception("Wrong ToolingType - [" + item.toolingType + "] (PartNo:" + item.name + ")");
                            item.typeSysId = toolingType.sysid;

                            if (toolingType.controlType != idv.mesCore.TOL.ControlType.None)
                            {
                                int limit = 0;
                                int.TryParse(part[2], out limit);
                                if (limit == 0)
                                    throw new Exception("Wrong UseLimit (PartNo:" + item.name + ")");
                                item.useLimit = limit;

                                limit = 0;
                                int.TryParse(part[3], out limit);
                                item.useNotice = limit;
                            }
                            item.description = part[4];
                            item.createUser = idv.mesCore.USR.userBase.loginUserId;
                            item.createDate = idv.messageService.serviceHost.dateTime;
                            item.New();
                            item = new ToolingPart(item.name);
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
            if (mesListView1.Items.Count == 0) return;
            appInstance.showInformation("");
            Type tt = Type.GetType("mesRelease.utilities.ExcelAgent, mesRelease");
            object returnValue = tt.InvokeMember("WriteToFile", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                   System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { mesListView1 });
            if (Convert.ToBoolean(returnValue))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                curItem = null;
                executeShowData(null);
            }
            else
            {
                curItem = item as ToolingPart;
                executeShowData(curItem);
            }
        }

        bool liveLimitFocusFlag = true;
        private void cboToolingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolingType toolingType = cboToolingType.SelectedItem as ToolingType;
            if (toolingType == null)
            {
                lblTypeInfo.Text = "";
                return;
            }
            if (toolingType.controlType == idv.mesCore.TOL.ControlType.None)
                lblTypeInfo.Text = "None";
            else if (toolingType.controlType == idv.mesCore.TOL.ControlType.Time)
                lblTypeInfo.Text = toolingType.controlType.ToString() + "(Hour)";
            else
                lblTypeInfo.Text = toolingType.controlType.ToString() + "," + toolingType.consumeType.ToString();
            if (toolingType.controlType == idv.mesCore.TOL.ControlType.None)
            {
                txtUseLimit.Enabled = false;
                txtUseLimit.Text = "";
                txtUseNotice.Enabled = false;
                txtUseNotice.Text = "";
            }
            else
            {
                txtUseLimit.Enabled = true;
                txtUseNotice.Enabled = true;
                if (curItem != null)
                {
                    txtUseLimit.Text = curItem.useLimit == 0 ? "" : curItem.useLimit.ToString();
                    txtUseNotice.Text = curItem.useNotice == 0 ? "" : curItem.useNotice.ToString();
                }
            }
            if (liveLimitFocusFlag && txtUseLimit.Enabled)
            {
                txtUseLimit.Focus();
                txtUseLimit.SelectAll();
            }
        }
    }
}
