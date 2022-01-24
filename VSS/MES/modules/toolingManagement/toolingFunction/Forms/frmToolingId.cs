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
using idv.messageService;
using mesRelease.TOL.Txn;

namespace toolingFunction
{
    public partial class frmToolingId : Form, idv.messageService.appModuleFunctionForm
    {   //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        List<string> noImageEvent = new List<string>();

        ToolingId curItem = null;
        public frmToolingId()
        {
            InitializeComponent();
            try
            {
                idv.utilities.misc.SetValueChangeByUseItem(Name);
            }
            catch { }
        }

        private void frmToolingId_Activated(object sender, EventArgs e)
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
                frmExt.EventNotice("frmToolingId_Activated", null);
        }
        void getLocations()
        {
            cboLocation.Items.Clear();
            foreach (DataRow row in serviceHost.Client.getDataSet("select distinct location from mes_tol_tooling_id where status !='SCRAP'").Tables[0].Rows)
                cboLocation.Items.Add(row[0].ToString());

            foreach (DataRow row in serviceHost.Client.getDataSet("select distinct location_list from mes_tol_event where next_status='IDLE'").Tables[0].Rows)
            {
                foreach (string loc in row[0].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (!cboLocation.Items.Contains(loc))
                        cboLocation.Items.Add(loc);
                }
            }
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Property", "");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Txn", "");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Function", "");
            actionToolbar1.Items["Function"].Tag = "ClientMenu";
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");           
        }

        private void frmToolingId_Load(object sender, EventArgs e)
        {
            new System.Threading.Thread(getLocations).Start();
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

            foreach (string s in Enum.GetNames(typeof(idv.mesCore.TOL.toolingStatus)))
                cboStatus.Items.Add(s);

            mnuTxn.ImageList = new ImageList();
            mnuTxn.ImageList.ImageSize = new Size(24, 24);
            mnuTxn.ImageList.ColorDepth = ColorDepth.Depth32Bit;

            mnuFunctions.ImageList = new ImageList();
            mnuFunctions.ImageList.ImageSize = new Size(24, 24);
            mnuFunctions.ImageList.ColorDepth = ColorDepth.Depth32Bit;
            idv.mesCore.USR.userBase logInUser = null;
            Type tt = Type.GetType("mesRelease.USR.User, mesRelease");
            object returnValue = tt.BaseType.InvokeMember("loginUser", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                   System.Reflection.BindingFlags.GetProperty, null, null, null);
            if (returnValue != null)
            {
                logInUser = returnValue as idv.mesCore.USR.userBase;
                foreach (mesRelease.TOL.Functions.funInfo info in mesRelease.TOL.Functions.FunctionManager.GetFunctionInfoList())
                {
                    ToolStripMenuItem mItem = new ToolStripMenuItem();
                    mnuFunctions.Items.Add(mItem);
                    mItem.Name = info.name;
                    mItem.Tag = info.tag;
                    if (info.tag != null && !info.tag.Equals(""))
                    {
                        string caption = cultureLanguage.getValue(info.tag);
                        if (caption.Equals(""))
                            mItem.Text = mItem.Name;
                        else
                            mItem.Text = caption;
                    }
                    if (info.privilege != null && !info.privilege.Equals(""))
                        mItem.Enabled = logInUser.CheckFunctionPrivilege("IDE:TOL:TOOLINGID:FUNCTION:" + info.privilege);
                    if (info.icon != null && !info.icon.Equals(""))
                    {
                        object img = idv.utilities.misc.GetImageFromFile(info.icon);
                        if (img != null)
                        {
                            if (!mnuFunctions.ImageList.Images.ContainsKey(info.icon))
                            {
                                if (img is Image)
                                    mnuFunctions.ImageList.Images.Add(info.icon, img as Image);
                                else
                                    mnuFunctions.ImageList.Images.Add(info.icon, img as Icon);
                            }
                            mItem.ImageKey = info.icon;
                        }
                    }
                }
            }
            if (mnuFunctions.Items.Count == 0)
                actionToolbar1.Items["Function"].Visible = false;
        }

        private void frmToolingId_FormClosed(object sender, FormClosedEventArgs e)
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
                    chkReachNotice.Checked = false;
                    executeShowData(null);
                    break;
                case "Property":
                    executeProperty();
                    break;
                case "Txn":
                    executeTxn();
                    break;
                case "Function":
                    executeFunction();
                    break;
                case "Import":
                    executeImport();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }
        void executeShowData(ToolingId item)
        {
            showPartCombo = false;
            if (item == null)
            {
                txtToolingId.Text = "";
                cboToolingType.SelectedIndex = -1;
                lblTypeInfo.Text = "";
                cboPartNo.Text = "";
                cboLocation.Text = "";
                cboStatus.SelectedIndex = -1;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                txtToolingId.Text = item.name;
                cboToolingType.Text = item.toolingType;
                cboPartNo.Text = item.partNo;
                cboLocation.Text = item.location;
                cboStatus.Text = item.status;

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(item);
            }
            showPartCombo = true;
        }

        void executeQuery()
        {
            if (!txtToolingId.Text.Trim().Equals(""))
                mesListView1.ShowMESItems(new ToolingId[] { ToolingId.GetTooling(txtToolingId.Text) });
            else
                mesListView1.ShowMESItems(ToolingId.GetToolings(cboToolingType.Text, cboPartNo.Text, cboLocation.Text, cboStatus.Text, chkReachNotice.Checked));
        }

        void assignValues(ToolingId item)
        {      
            ToolingType toolingType = cboToolingType.SelectedItem as ToolingType;
            item.toolingType = toolingType.name;
            item.typeDescription = toolingType.description;
            item.controlType = toolingType.controlType;
            item.consumeType = toolingType.consumeType;
            item.verifyFlag = toolingType.verifyFlag;
            item.ownerDept = toolingType.ownerDept;

            ToolingPart toolingPart = null;
            foreach (ToolingPart tmpPart in cboPartNo.Items)
            {
                if (tmpPart.name.Equals(cboPartNo.Text))
                {
                    toolingPart = tmpPart;
                    break;
                }
            }
            if (toolingPart == null && item.sysid.Equals(""))//新增時一定要有料號
            {
                toolingPart = ToolingPart.GetToolingPart(cboPartNo.Text);
                if (toolingPart == null || !toolingPart.toolingType.Equals(toolingType.name))
                    throw new Exception("Wrong ToolingPart");
                else
                    cboPartNo.Items.Add(toolingPart);
            }
            if (toolingPart != null)
            {
                item.partNo = toolingPart.name;
                item.partDescription = toolingPart.description;
                item.useLimit = toolingPart.useLimit;
                item.useNotice = toolingPart.useNotice;
            }
            item.location = cboLocation.Text;            
            item.modifyUser = idv.mesCore.USR.userBase.loginUserId;

            if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
        }
        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtToolingId, lblToolingId, cboPartNo, lblPartNo, cboToolingType, lblToolingType, cboLocation, lblLocation)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ToolingId item = new ToolingId();
                item.name = txtToolingId.Text;
                assignValues(item);
                item.locationType = idv.mesCore.TOL.LocationType.Storage;
                item.createUser = idv.mesCore.USR.userBase.loginUserId;
                item.createDate = idv.messageService.serviceHost.dateTime;

                if (item.verifyFlag)
                    item.status = idv.mesCore.TOL.toolingStatus.VERIFY.ToString();
                else
                    item.status = idv.mesCore.TOL.toolingStatus.IDLE.ToString();

                item.New();
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
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!appInstance.CheckInputData(txtToolingId, lblToolingId, cboPartNo, lblPartNo, cboToolingType, lblToolingType, cboLocation, lblLocation, cboStatus, lblStatus)) return;
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                assignValues(curItem);
                curItem.status = cboStatus.Text;
                curItem.Modify();
                curItem = ToolingId.GetTooling(curItem.name);
                mesListView1.UpdateMESItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("UnExpected Affected Row"))
                    appInstance.showInformation(cultureLanguage.getValue("errGen0001"), informationType.error);
                else
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
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void prepareTxnMenu()
        {
            mnuTxn.Items.Clear();
            if (curItem == null) return;
            idv.mesCore.USR.userBase logInUser = null;
            Type tt = Type.GetType("mesRelease.USR.User, mesRelease");
            object returnValue = tt.BaseType.InvokeMember("loginUser", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                   System.Reflection.BindingFlags.GetProperty, null, null, null);
            if (returnValue != null)
                logInUser = returnValue as idv.mesCore.USR.userBase;
            else
                return;
            
            SortedList<string, ToolStripMenuItem> srtList = new SortedList<string, ToolStripMenuItem>();
            foreach (ToolingEvent tolEvent in ToolingEvent.GetToolingEvents(curItem.toolingType, curItem.status))
            {
                if (!tolEvent.ideFlag) continue;
                if (!logInUser.CheckFunctionPrivilege("IDE:TOL:TOOLINGID:TXN:" + tolEvent.name)) continue;
                ToolStripMenuItem mItem = new ToolStripMenuItem();
                mItem.Name = tolEvent.name;
                string caption = cultureLanguage.getValue("toolingEvent" + tolEvent.name);
                if (caption.Equals(""))
                    mItem.Text = tolEvent.name;
                else
                    mItem.Text = caption;
                mItem.Tag = tolEvent;

                string imgFileName = "toolingEvent" + tolEvent.name;
                if (mnuTxn.ImageList.Images.Keys.Contains(imgFileName))
                    mItem.ImageKey = imgFileName;
                else if (!noImageEvent.Contains(imgFileName))
                {
                    object img = idv.utilities.misc.GetImageFromFile(imgFileName + ".ico");
                    if (img != null)
                    {
                        if (img is Image)
                            mnuTxn.ImageList.Images.Add(imgFileName, img as Image);
                        else
                            mnuTxn.ImageList.Images.Add(imgFileName, img as Icon);

                        mItem.ImageKey = imgFileName;
                    }
                    else
                        noImageEvent.Add(imgFileName);
                }

                srtList[mItem.Text] = mItem;
            }            
            foreach (ToolStripMenuItem mItem in srtList.Values)
                mnuTxn.Items.Add(mItem);

        }
        void executeTxn()
        {
            if (curItem == null) return;

            prepareTxnMenu();
            if (mnuTxn.Items.Count == 0) return;
            
            Rectangle rect = actionToolbar1.Items["Txn"].Bounds;
            mnuTxn.Show(actionToolbar1, rect.X, rect.Y + rect.Height);
        }
        private void mnuTxn_Opening(object sender, CancelEventArgs e)
        {
            if (curItem == null)
            {
                e.Cancel = true;
                return;
            }
            prepareTxnMenu();
            if (mnuTxn.Items.Count == 0)            
                e.Cancel = true;
        }

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("ToolingId,ToolingType,PartNo,Location".Split(','));
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
                    ToolingId item = new ToolingId();
                    item.name = row["ToolingId"].ToString();
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
                        throw new Exception("Wrong ToolingType - [" + item.toolingType + "] (ToolingId:" + item.name + ")");

                    item.typeDescription = toolingType.description;
                    item.controlType = toolingType.controlType;
                    item.consumeType = toolingType.consumeType;
                    item.verifyFlag = toolingType.verifyFlag;
                    item.ownerDept = toolingType.ownerDept;

                    item.partNo = row["PartNo"].ToString();
                    ToolingPart toolingPart = null;
                    foreach (ToolingPart tmpPart in cboPartNo.Items)
                    {
                        if (tmpPart.name.Equals(item.partNo))
                        {
                            toolingPart = tmpPart;
                            break;
                        }
                    }
                    if (toolingPart == null)
                        toolingPart = ToolingPart.GetToolingPart(item.partNo);

                    if (toolingPart == null || !toolingPart.toolingType.Equals(item.toolingType))
                        throw new Exception("Wrong ToolingPart - [" + item.partNo + "] (ToolingId:" + item.name + ")");

                    item.partDescription = toolingPart.description;
                    item.useLimit = toolingPart.useLimit;
                    item.useNotice = toolingPart.useNotice;

                    item.location = row["Location"].ToString();
                    item.locationType = idv.mesCore.TOL.LocationType.Storage;
                    if (item.verifyFlag)
                        item.status = idv.mesCore.TOL.toolingStatus.VERIFY.ToString();
                    else
                        item.status = idv.mesCore.TOL.toolingStatus.IDLE.ToString();
                    item.createUser = idv.mesCore.USR.userBase.loginUserId;
                    item.createDate = idv.messageService.serviceHost.dateTime;
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
                        if (!s.ToUpper().StartsWith("ToolingId\tToolingType\tPartNo\tLocation".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] tooling = s.Split('\t');
                        try
                        {
                            ToolingId item = new ToolingId();
                            item.name = tooling[0];
                            item.toolingType = tooling[1];

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
                                throw new Exception("Wrong ToolingType - [" + item.toolingType + "] (ToolingId:" + item.name + ")");

                            item.typeDescription = toolingType.description;
                            item.controlType = toolingType.controlType;
                            item.consumeType = toolingType.consumeType;
                            item.verifyFlag = toolingType.verifyFlag;
                            item.ownerDept = toolingType.ownerDept;

                            item.partNo = tooling[2];
                            ToolingPart toolingPart = null;
                            foreach (ToolingPart tmpPart in cboPartNo.Items)
                            {
                                if (tmpPart.name.Equals(item.partNo))
                                {
                                    toolingPart = tmpPart;
                                    break;
                                }
                            }
                            if (toolingPart == null)
                                toolingPart = ToolingPart.GetToolingPart(item.partNo);

                            if (toolingPart == null || !toolingPart.toolingType.Equals(item.toolingType))
                                throw new Exception("Wrong ToolingPart - [" + item.partNo + "] (ToolingId:" + item.name + ")");

                            item.partDescription = toolingPart.description;
                            item.useLimit = toolingPart.useLimit;
                            item.useNotice = toolingPart.useNotice;

                            item.location = tooling[3];
                            item.locationType = idv.mesCore.TOL.LocationType.Storage;
                            if (item.verifyFlag)
                                item.status = idv.mesCore.TOL.toolingStatus.VERIFY.ToString();
                            else
                                item.status = idv.mesCore.TOL.toolingStatus.IDLE.ToString();
                            item.createUser = idv.mesCore.USR.userBase.loginUserId;
                            item.createDate = idv.messageService.serviceHost.dateTime;
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

        void executeProperty()
        {
            frmProperty frm = new frmProperty();
            try
            {
                frm.ShowToolingId(curItem);
                cultureLanguage.switchLanguageSync(frm);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.ToString(), messageStyle.error);
            }
            finally
            {
                if (frm != null && !frm.IsDisposed)
                    frm.Close();
            }
        }

        void executeFunction()
        {
            Rectangle rect = actionToolbar1.Items["Function"].Bounds;
            mnuFunctions.Show(actionToolbar1, rect.X, rect.Y + rect.Height);
        }

        private void mesListView1_DoubleClick(object sender, EventArgs e)
        {
            executeProperty();
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
                curItem = item as ToolingId;
                executeShowData(curItem);
            }
        }

        bool showPartCombo = true;
        private void cboToolingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolingType toolingType = cboToolingType.SelectedItem as ToolingType;
            if (toolingType == null)
            {
                lblTypeInfo.Text = "";
                return;
            }
            if (showPartCombo)
                new System.Threading.Thread(showPartNo).Start();
            if (toolingType.controlType == idv.mesCore.TOL.ControlType.None)
                lblTypeInfo.Text = "None";
            else if (toolingType.controlType == idv.mesCore.TOL.ControlType.Time)
                lblTypeInfo.Text = toolingType.controlType.ToString() + "(Hour)";
            else
                lblTypeInfo.Text = toolingType.controlType.ToString() + "," + toolingType.consumeType.ToString();
        }
        void showPartNo()
        {
            cboPartNo.Items.Clear();
            cboPartNo.Items.AddRange(ToolingPart.GetToolingParts("", cboToolingType.Text));
            if (cboPartNo.Text.Equals("")) return;
            bool find = false;
            foreach (ToolingPart part in cboPartNo.Items)
            {
                if (cboPartNo.Text.Equals(part.name))
                {
                    find = true;
                    break;
                }
            }
            if (!find)
                cboPartNo.Text = "";
        }

        private void lblReachUseNotice_Click(object sender, EventArgs e)
        {
            chkReachNotice.Checked = !chkReachNotice.Checked;
        }

        private void mnuTxn_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //mesListView1.UpdateMESItem(TxnEvent.ExecuteToolingEvent(e.ClickedItem.Name, curItem.name));
            //mesListView1.UpdateMESItem(TxnEvent.ExecuteToolingEvent(e.ClickedItem.Tag as ToolingEvent, curItem));
            mesListView1.UpdateMESItem(appInstance.ExecuteToolingEvent(e.ClickedItem.Tag as ToolingEvent, curItem));
        }

        private void mnuFunctions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            mesRelease.TOL.Functions.FunctionManager.ExecuteFunction(e.ClickedItem.Name, curItem);
        }     
    }
}
