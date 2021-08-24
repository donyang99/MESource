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
using mesRelease.BAS;

namespace mesBasicData
{
    public partial class frmReasonCode : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        Dictionary<string, TextBox> dicLangauge = new Dictionary<string, TextBox>();
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmReasonCode()
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
        }

        private void frmReasonCode_Load(object sender, EventArgs e)
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

            foreach (string s in cultureLanguage.availableLanguage)
            {
                TextBox txt = null;
                if (s.Equals("en-US"))
                    txt = txtLanguage;
                else
                {
                    txt = new TextBox();
                    txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    tblDetail.RowCount++;
                    tblDetail.Controls.Add(txt, 1, tblDetail.RowCount - 1);

                    Label lbl = new Label();
                    tblDetail.Controls.Add(lbl, 2, tblDetail.RowCount - 1);
                    lbl.AutoSize = true;
                    lbl.Tag = s;
                    lbl.Text = cultureLanguage.getValue(s);
                    lbl.Font = label1.Font;
                    lbl.ForeColor = label1.ForeColor;
                    lbl.Anchor = AnchorStyles.Left;                    
                }
                dicLangauge[s] = txt;
            }

            pnlExt.AutoSize = true;
        }

        private void frmReasonCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void actionToolbar1_ActionClicked(string actionName)
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
            }
        }

        void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
            }
            else
            {
                ReasonCode r = item as ReasonCode;
                if (r != null)
                {
                    txtReasonCode.Text = r.name;
                    cboDept.Text = r.ownerDept;
                    cboReasonType.Text = r.reasonType;

                    foreach (KeyValuePair<string, TextBox> kv in dicLangauge)
                        kv.Value.Text = cultureLanguage.getValue(r.name, new System.Globalization.CultureInfo(kv.Key));

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(r);
                }
            }           
        }

        void executeClear()
        {
            txtReasonCode.Text = "";
            cboDept.Text = "";
            cboReasonType.Text = "";

            foreach (TextBox txt in dicLangauge.Values)
                txt.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            string condition = "";
            if (txtReasonCode.Text.Trim() != "")
                condition = "reason_code like '%" + txtReasonCode.Text.Trim() + "%'";
            if (cboDept.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "owner_dept='" + cboDept.Text + "'";
            }
            ReasonCode[] items = ReasonCode.getReasonCodes(condition);
            mesListView1.ShowMESItems(items);            
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtReasonCode, lblReasonCode)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ReasonCode item = new ReasonCode();
                item.name = txtReasonCode.Text;
                item.ownerDept = cboDept.Text;
                item.reasonType = cboReasonType.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New(GetLanguageMap());
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }
        KeyValuePair<string, string>[] GetLanguageMap()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            foreach (KeyValuePair<string, TextBox> kv in dicLangauge)
            {
                KeyValuePair<string, string> keyValue = new KeyValuePair<string, string>(kv.Key, kv.Value.Text);
                list.Add(keyValue);
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
            else if (!appInstance.CheckInputData(txtReasonCode, lblReasonCode))
                return;
            ReasonCode item = mesListView1.selectedMESItem as ReasonCode;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            
            try
            {
                item.name = txtReasonCode.Text;
                item.ownerDept = cboDept.Text;
                item.reasonType = cboReasonType.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify(GetLanguageMap());
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
            ReasonCode item = mesListView1.selectedMESItem as ReasonCode;
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

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("ReasonCode,OwnerDept,ReasonType".Split(','));
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
                    ReasonCode item = new ReasonCode();
                    item.name = row["ReasonCode"].ToString();
                    item.ownerDept = row["OwnerDept"].ToString();
                    item.reasonType = row["ReasonType"].ToString();
                    item.createUser = mesRelease.USR.User.loginUser.name;
                    item.createDate = DateTime.Now;
                    item.New();
                    mesListView1.UpdateMESItem(item);
                }
                catch (Exception ex)
                {
                    allSucceed = false;
                    messageBox.showMessage(ex.Message, messageStyle.error);
                    break;
                }
            }
            misc.SetValueChangeByItemName(Name);
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
                        if (!s.ToUpper().StartsWith("ReasonCode\tOwnerDept\tReasonType".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] rea = s.Split('\t');
                        try
                        {
                            ReasonCode item = new ReasonCode();
                            item.name = rea[0];
                            item.ownerDept = rea[1];
                            if (rea.Length > 2)
                                item.reasonType = rea[2];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;
                            item.New();
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
            idv.utilities.misc.SetValueChangeByItemName(Name);
            if (succeed)
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(mesListView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void txtReasonCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }               
        }

        private void frmReasonCode_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmDivision", Name))
            {
                string orgValue = cboDept.Text;
                cboDept.Items.Clear();
                cboDept.Items.Add("");
                cboDept.Items.AddRange(idv.mesCore.misc.DivisionGet());
                if (!orgValue.Equals(""))
                    cboDept.Text = orgValue;
            }

            if (idv.utilities.misc.IsValueChanged("frmReasonType", Name))
            {
                string orgValue = cboReasonType.Text;
                cboReasonType.Items.Clear();
                cboReasonType.Items.Add("");
                cboReasonType.Items.AddRange(ReasonCode.ReasonTypeGet());
                if (!orgValue.Equals(""))
                    cboReasonType.Text = orgValue;
            }

            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmReasonCode_Activated", null);
        }
    }
}
