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
using mesRelease.PRP;
using idv.mesCore.PRP;

namespace mesBasicData
{
    public partial class frmRoute : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        Route curItem = null;
        public frmRoute()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query   
            actionToolbar1.addButton("Copy", "ADD");
            actionToolbar1.addButton("IssueState", "ISSUE");
            actionToolbar1.addButton("Version", "");
            actionToolbar1.addButton("DrawRoute", "MODIFY");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");           
        }

        private void frmRoute_Load(object sender, EventArgs e)
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
            initData();
        }

        private void frmRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void initData()
        {
            if (!idv.mesCore.systemConfig.routeType)
            {
                lblRouteType.Visible = false;
                cboRouteType.Visible = false;
                tblDetail.Controls.Remove(lblRouteType);
                tblDetail.Controls.Remove(cboRouteType);
                tblDetail.SetColumn(lblDescription, 4);
                tblDetail.SetColumn(txtDescription, 5);
                tblDetail.SetColumnSpan(txtDescription, 3);
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
                case "Query":
                    executeQuery();
                    break;
                case "Copy":
                    executeCopy();
                    break;
                case "IssueState":
                    executeIssue();
                    break;
                case "Version":
                    executeVersion();
                    break;
                case "Clear":
                    executeClear();
                    break;
                case "DrawRoute":
                    executeDrawRoute();
                    break;
                case "Import":
                    executeImport();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeClear()
        {
            txtRoute.Text = "";
            txtDescription.Text = "";
            cboRouteType.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            string condition = "";
            if (txtRoute.Text.Trim() != "")
                condition = "route_id like '%" + txtRoute.Text.Trim() + "%'";
            if (cboRouteType.Text != "")
            {
                if (condition != "") condition += " and ";
                condition += "route_type = '" + cboRouteType.Text + "'";
            }
            mesListView1.ShowMESItems(Route.GetLastestVersionRoutes(condition));
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtRoute, lblRoute)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                Route item = new Route();
                item.name = txtRoute.Text;
                item.routeType = cboRouteType.Text;
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能

                item.New();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeCopy()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonCopy"))) return;
            try
            {
                Route item = new Route(curItem.name, curItem.version);
                item.name = txtRoute.Text;
                item.routeType = cboRouteType.Text;
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                item.modifyUser = item.createUser;
                item.modifyDate = item.createDate;
                item.version = 0;
                item.retrieveNodes();
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                item.SaveNodes();
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
            if (!appInstance.CheckInputData(txtRoute, lblRoute)) return;

            if (curItem.name != txtRoute.Text && (curItem.issueState != idv.mesCore.IssueState.New || curItem.version!=0))
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblRoute.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                curItem.name = txtRoute.Text;
                curItem.routeType = cboRouteType.Text;
                curItem.description = txtDescription.Text;
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(curItem);//維護畫面延伸功能
                
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
            if (curItem.issueState != idv.mesCore.IssueState.New)
            {
                appInstance.showInformationById("msgCanOnlyDeleteNewState", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                curItem.Delete();
                Route[] lastItem = Route.GetLastestVersionRoutes("route_id='" + curItem.name + "'");
                if (lastItem.Length == 0)
                    mesListView1.RemoveMESItem(curItem);
                else
                    mesListView1.UpdateCurrentItem(lastItem[0]);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeIssue()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (curItem.issueState == idv.mesCore.IssueState.Active && idv.mesCore.systemConfig.useStepIdAsHandle)
                return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("issue"))) return;
            try
            {
                //bool updateWip = curItem.issueState == idv.mesCore.IssueState.New && curItem.version != 0 && !idv.mesCore.systemConfig.useStepIdAsHandle;
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;
                curItem.Issue();
                mesListView1.UpdateCurrentItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
                //if (updateWip && messageBox.showMessage("是否將使用此途程[" + curItem.name + "]的Lot全部更新為新版途程？", messageStyle.askYesNo))
                //{
                //    List<string> status = new List<string>();
                //    foreach (string s in Enum.GetNames(idv.mesCore.WIP.LotStatus.WAIT.GetType()))
                //    {
                //        if (mesRelease.WIP.Lot.IsWIPStatus(s))
                //            status.Add(s);
                //    }
                //    string sql = "update MES_WIP_LOT set route_version=? where route_id=? and status in ('" + string.Join("','", status.ToArray()) + "')";
                //    idv.messageService.serviceHost.Client.executeSQLWithParameter(sql, curItem.version, curItem.name);
                //}
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeVersion()
        {
            if (curItem == null) return;

            if (mnuVersion.Items.Count == 0)
            {
                string caption = cultureLanguage.getValue("version");
                bool haveNewVersion = false;
                ToolStripMenuItem mnuItem = null;
                foreach (Route r in curItem.GetOtherVersions())
                {
                    mnuItem = new ToolStripMenuItem();
                    mnuItem.Text = caption + " " + r.version.ToString() + " (" + r.issueState.ToString() + ")"; ;
                    mnuItem.Tag = r;
                    if (r.version == curItem.version)
                        mnuItem.Checked = true;
                    mnuItem.Click += new EventHandler(mnuItemVersion_Click);
                    mnuVersion.Items.Add(mnuItem);
                    if (r.issueState == idv.mesCore.IssueState.New) haveNewVersion = true;
                }
                if (!haveNewVersion)
                {
                    if (actionToolbar1.Items["Add"].Enabled)
                    {
                        mnuVersion.Items.Add(new ToolStripSeparator());
                        mnuItem = new ToolStripMenuItem();
                        mnuItem.Text = cultureLanguage.getValue("buttonNewVersion");
                        mnuItem.Click += new EventHandler(mnuItemNewVersion_Click);
                        mnuVersion.Items.Add(mnuItem);
                    }
                }
            }
            ToolStripItem tsi = actionToolbar1.Items["Version"] as ToolStripItem;
            mnuVersion.Show(actionToolbar1, tsi.Bounds.Location.X, tsi.Bounds.Location.Y + tsi.Bounds.Height);
        }

        void executeDrawRoute()
        {
            if (curItem == null) return;
            frmDrawRoute frm = null;
            try
            {
                frm = new frmDrawRoute();
                curItem.retrieveNodes();
                frm.Init(curItem, curItem.name);
                frm.ShowDialog();
            }
            finally
            {
                frm.Close();
            }
        }

        void mnuItemVersion_Click(object sender, EventArgs e)
        {
            Route r = (sender as ToolStripMenuItem).Tag as Route;
            if (r.version == curItem.version) return;
            mesListView1.UpdateCurrentItem(r);
        }

        void mnuItemNewVersion_Click(object sender, EventArgs e)
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonNewVersion"))) return;
            try
            {
                Route newItem = new Route(curItem.name, curItem.version);
                newItem.createUser = mesRelease.USR.User.loginUser.name;
                newItem.modifyDate = DateTime.Now;
                newItem.modifyUser = newItem.createUser;
                newItem.modifyDate = newItem.createDate;
                newItem.NewVersion();
                newItem.SaveNodes();
                mesListView1.UpdateCurrentItem(newItem);
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
                curItem = null;
                mnuVersion.Items.Clear();
            }
            else
            {
                curItem = item as Route;
                if (curItem != null)
                {
                    txtRoute.Text = curItem.name;
                    txtVersion.Text = curItem.version.ToString();
                    cboRouteType.Text = curItem.routeType;
                    txtDescription.Text = curItem.description;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(curItem);
                }
            }
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(mesListView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("RouteId,RouteType,Description".Split(','));
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
                    Route item = new Route();
                    item.name = row["RouteId"].ToString();
                    item.routeType = row["RouteType"].ToString();
                    item.description = row["Description"].ToString();
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
                        if (!s.ToUpper().StartsWith("RouteId\tRouteType\tDescription".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] route = s.Split('\t');
                        try
                        {
                            Route item = new Route();
                            item.name = route[0];
                            item.routeType = route[1];
                            item.description = route[2];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;
                            item.New();
                            mesListView1.UpdateMESItem(item);
                            appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
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

        private void frmRoute_Activated(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.routeType && idv.utilities.misc.IsValueChanged("frmRouteType", Name))
            {
                string orgValue = cboRouteType.Text;
                cboRouteType.Items.Clear();
                cboRouteType.Items.Add("");
                cboRouteType.Items.AddRange(idv.mesCore.misc.RouteTypeGet());

                if (!orgValue.Equals(""))
                    cboRouteType.Text = orgValue;
            }

            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmRoute_Activated", null);
        }




        private void TestRouteStep(Route route)
        {
            processedNode = new List<string>();
            Step s = route.FirstStep();
            showRouteStep(route, s);
        }

        List<string> processedNode = new List<string>();
        void showRouteStep(Route route, Step step)
        {
            if (processedNode.Contains(step.stepHandle)) return;
            processedNode.Add(step.stepHandle);
            string[] paths = step.availablePaths;
            System.Diagnostics.Debug.WriteLine("--------------------------------------------------------------------------------------------");
            System.Diagnostics.Debug.WriteLine(step.routeId + "." + step.name + "[" + step.stepHandle + "] PathCount=" + paths.Length.ToString());
            List<Step> nextStep = new List<Step>();
            Step passStep = null;
            foreach (string path in paths)
            {
                Step s = route.NextStep(step.stepHandle, path);
                if (s == null)
                    MessageBox.Show(s.name);
                nextStep.Add(s);
                showDebug(step, path, s);
                if (path.Equals("PASS"))
                    passStep = s;
            }
            if (passStep != null)
                showRouteStep(route, passStep);
            foreach (Step st in nextStep)
            {
                if (st == passStep) continue;
                showRouteStep(route, st);
            }
        }

        void showDebug(Step from, string path, Step to)
        {
            System.Diagnostics.Debug.WriteLine(from.routeId + "." + from.name + "[" + from.stepHandle + "]" + "--[" + path + "]--> " + to.routeId + "." + to.name + "[" + to.stepHandle + "]");
        }
    }
}
