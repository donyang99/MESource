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
using mesRelease.PARM;
using mesRelease.MAT;

namespace mesBasicData
{
    public partial class frmProductParameter : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        Step curStep = null;
        ProductSpec curItem = null;
        StepParameter curStepParmeter = null;        
        TextBox parText = new TextBox(); //for 參數ListView輸入使用
        TextBox recText = new TextBox(); //for 程式ListView輸入使用
        ComboBox matReqCombo = new ComboBox();//for 站點物料類別是否必要使用
        Color nonEditColor = Color.Gray;
        bool editable = false;
        bool numericOnly = false;
        bool isTrackEq = false;//可用料號是否設定在機台軌道。true:設在機台軌道，false:設在物料類型
        bool toolingEnable = false;

        public frmProductParameter()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        void parText_Leave(object sender, EventArgs e)
        {
            if (!parText.Visible) return;
            ListViewItem.ListViewSubItem subItem = parText.Tag as ListViewItem.ListViewSubItem;
            if (subItem != null)
            {
                subItem.Text = parText.Text;
                parText.Tag = null;
                parText.Hide();
            }
        }
        void parText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)9 || e.KeyChar == (char)13)
            {
                ListViewItem.ListViewSubItem curSubItem = parText.Tag as ListViewItem.ListViewSubItem;
                parText_Leave(null, null);
                e.Handled = true;
                bool find = false;
                foreach (ListViewItem item in lvwParameter.Items)
                {
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        ListViewItem.ListViewSubItem subItem = item.SubItems[i];
                        if (!find)
                        {
                            if (subItem == curSubItem)
                                find = true;
                        }
                        else
                        {
                            if (subItem.BackColor != nonEditColor)
                            {
                                item.Selected = true;
                                Parameter parm = item.Tag as Parameter;
                                numericOnly = (parm.parmType != idv.mesCore.PARM.ParameterType.String) && subItem != item.SubItems[4];//不是remark欄位

                                if (subItem == item.SubItems[4])//如果是remark，則「值」的欄位必須有值才取得focus
                                {
                                    if (!(item.SubItems[1].Text + item.SubItems[2].Text + item.SubItems[3].Text).Trim().Replace("-", "").Equals(""))
                                    {
                                        showListViewEditText(parText, subItem);
                                        return;
                                    }
                                }
                                else
                                {
                                    showListViewEditText(parText, subItem);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (numericOnly)
                    HandleKeyPressNumericOnly(parText, e);
            }
        }
        void HandleKeyPressNumericOnly(TextBox txt, KeyPressEventArgs e)
        {
            byte ascii = (byte)e.KeyChar;
            if (ascii == 8)
                return;
            else if (ascii > 47 && ascii < 58)
            {

            }
            else if (ascii == 45)
            {
                if (txt.Text.IndexOf('-') >= 0 || txt.SelectionStart > 0)
                    e.Handled = true;
            }
            else if (ascii == 46)
            {
                if (txt.Text.IndexOf('.') >= 0 || txt.Text.Length == 0)
                    e.Handled = true;
            }
            else
                e.Handled = true;
        }

        void recText_Leave(object sender, EventArgs e)
        {
            if (!recText.Visible) return;
            ListViewItem.ListViewSubItem subItem = recText.Tag as ListViewItem.ListViewSubItem;
            if (subItem != null)
            {
                subItem.Text = recText.Text;
                recText.Tag = null;
                recText.Hide();
            }
        }
        void recText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)9 || e.KeyChar == (char)13)
            {
                ListViewItem.ListViewSubItem curSubItem = recText.Tag as ListViewItem.ListViewSubItem;
                recText_Leave(null, null);
                e.Handled = true;
                bool find = false;
                foreach (ListViewItem item in lvwRecipe.Items)
                {
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        ListViewItem.ListViewSubItem subItem = item.SubItems[i];
                        if (!find)
                        {
                            if (subItem == curSubItem)
                                find = true;
                        }
                        else
                        {
                            item.Selected = true;
                            showListViewEditText(recText, subItem);
                            return;
                        }
                    }
                }
            }
        }

        void initData()
        {          
            //站點耗用物料
            if (!idv.mesCore.systemConfig.materialTracking)
            {
                pnlMaterialType.Visible = false;
                if (Height * 2 / 5 > pnlParameter.Height)
                    pnlParameter.Height = Height * 2 / 5;

                pnlEqTrackMaterial.Visible = false;
                pnlPartNo.Visible = false;
            }
            else
            {
                lvwMaterialType.prepareColumns();
                lvwMaterialType.Controls.Add(matReqCombo);
                matReqCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                matReqCombo.Visible = false;
                matReqCombo.Items.Add("");
                matReqCombo.Items.Add("True");
                matReqCombo.Items.Add("False");
                matReqCombo.Font = lvwMaterialType.Font.Clone() as Font;
                matReqCombo.SelectedValueChanged += new EventHandler(matReqCombo_SelectedValueChanged);
                matReqCombo.Leave += new EventHandler(matReqCombo_Leave);
            }
            pnlEqType.Visible = idv.mesCore.systemConfig.parmEqTypeFlag;
            if (!pnlEqType.Visible && !pnlMaterialType.Visible)
            {
                pnlEqTypeMaterTracking.Visible = false;
                pnlParameter.Dock = DockStyle.Fill;
            }
        }
        void matReqCombo_Leave(object sender, EventArgs e)
        {
            if (!matReqCombo.Visible) return;
            matReqCombo_SelectedValueChanged(matReqCombo, null);
            matReqCombo.Hide();
        }
        void matReqCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            ListViewItem.ListViewSubItem subItem = matReqCombo.Tag as ListViewItem.ListViewSubItem;
            if (subItem == null) return;
            subItem.Text = matReqCombo.Text;
        }

        List<Step> allSteps = new List<Step>();
        Step GetStepFromAllStep(string name)
        {
            foreach (Step s in allSteps)
            {
                if (s.name.Equals(name))
                    return s;
            }
            return null;
        }
        void initStep()
        {
            allSteps.Clear();
            SortedList<string, Step> srtStep = new SortedList<string, Step>();
            int i = 1;
            foreach (Step s in Step.GetActiveVersionSteps(""))
            {
                srtStep[s.seq + i.ToString("0000")] = s;
                i++;
            }
            allSteps.AddRange(srtStep.Values);

            //站點參數
            Dictionary<string, short> parmSteps = StepParameter.GetParameteredSteps();
            foreach (Step step in allSteps)
            {
                step.version = 0;//當成站點設定參數的數量
                if (parmSteps.ContainsKey(step.name))
                    step.version = parmSteps[step.name];
            }
            showStep();
        }

        void showStep()
        {
            Route route = cboRoute.SelectedItem as Route;
            if (route == null)
                lvwStep.ShowMESItems(allSteps.ToArray());
            else
            {
                route.retrieveNodes();
                List<Step> otherSteps = new List<Step>();
                Dictionary<string, Step> dicStep = new Dictionary<string, Step>();
                foreach (Step s in route.GetMainSteps(otherSteps))
                {
                    if (dicStep.ContainsKey(s.name)) continue;
                    dicStep[s.name] = s;
                }
                foreach (Step s in otherSteps)
                {
                    if (dicStep.ContainsKey(s.name)) continue;
                    dicStep[s.name] = s;
                }
                otherSteps.Clear();
                foreach (Step s in dicStep.Values)
                {
                    Step step = GetStepFromAllStep(s.name);
                    if (step != null)
                        otherSteps.Add(step);
                }
                lvwStep.ShowMESItems(otherSteps.ToArray());
            }
        }

        void initRoute()
        {
            cboRoute.Items.Clear();
            cboRoute.Items.Add("");
            if (mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToProduct)
            {
                Product prod = txtSpecName.SelectedItem as Product;
                if (prod != null)
                {
                    prod.retrieveRoutes();
                    cboRoute.Items.AddRange(prod.Items.ToArray());
                    if (cboRoute.Items.Count == 2)
                        cboRoute.SelectedIndex = 1;
                    else
                        showStep();
                }
            }
            else
                cboRoute.Items.AddRange(Route.GetActiveVersionRoutes(""));
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            showStep();
            if (curItem == null) return;
            ShowStepSelectionColor(curItem.Items.ToArray());
        }

        private void txtSpecName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToProduct)
                initRoute();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query   
            actionToolbar1.addButton("Copy", "ADD");
            actionToolbar1.addButton("IssueState", "ISSUE");
            actionToolbar1.addButton("Version", "");
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
        }

        private void frmProductParameter_Load(object sender, EventArgs e)
        {
            if (mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToProduct)
            {
                tGetProducts = new System.Threading.Thread(GetAllProductIds);
                tGetProducts.Start();
            }
            else
                txtSpecName.DropDownStyle = ComboBoxStyle.Simple;

            editable = mesRelease.USR.User.loginUser.CheckFunctionPrivilege("IDE:PARM:PRODUCTPARAMETER:ADD")
                    || mesRelease.USR.User.loginUser.CheckFunctionPrivilege("IDE:PARM:PRODUCTPARAMETER:MODIFY");
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
            lvwStep.prepareColumns();
            lvwParameter.prepareColumns();
            lvwParameter.HideSelection = true;
            lvwParameter.Controls.Add(parText);
            parText.MaxLength = 40;
            parText.Multiline = true;
            parText.AcceptsTab = true;
            parText.Visible = false;
            parText.BorderStyle = BorderStyle.None;
            parText.KeyPress += new KeyPressEventHandler(parText_KeyPress);
            parText.Leave += new EventHandler(parText_Leave);

            if (idv.mesCore.systemConfig.materialTracking)
                lvwEqTrackMaterial.prepareColumns();

            toolingEnable = idv.mesCore.systemConfig.validItem("toolingManagement");
            pnlTooling.Visible = false;
            if (toolingEnable)
                lvwEqTooling.prepareColumns();
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initData));
            //t.Start();
            initData();

            txtStdProcessTime.ReadOnly = !editable;
            btnAddPartNo.Enabled = editable;
            btnModifyPartNo.Enabled = editable;
            btnDeletePartNo.Enabled = editable;
            btnUp.Enabled = editable;
            btnDown.Enabled = editable;

            lvwRecipe.Controls.Add(recText);
            recText.MaxLength = 40;
            recText.Multiline = true;
            recText.AcceptsTab = true;
            recText.Visible = false;
            recText.BorderStyle = BorderStyle.None;
            recText.KeyPress += new KeyPressEventHandler(recText_KeyPress);
            recText.Leave += new EventHandler(recText_Leave);

            if (tGetProducts != null)
            {
                tGetProducts.Join();
                txtSpecName.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtSpecName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        System.Threading.Thread tGetProducts = null;
        void GetAllProductIds()
        {
            txtSpecName.Items.AddRange(Product.GetActiveProducts(""));
        }

        private void frmProductParameter_FormClosed(object sender, FormClosedEventArgs e)
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
                case "Import":
                    executeImport();
                    break;
            }
        }

        void executeImport()
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Excel(*.xls;*.xlsx)|*.xls;*.xlsx";
            ofg.ShowDialog();
            if (ofg.FileName == "") return;

            try
            {
                ProductSpec[] specs = ProductSpec.Import(ofg.FileName);
                foreach (ProductSpec spec in specs)
                {
                    ProductSpec[] old = ProductSpec.GetLastestVersionSpecs("name='" + spec.name + "'");

                    if (old.Length == 0)
                    {
                        spec.createUser = mesRelease.USR.User.loginUserId;
                        spec.New();
                        mesListView1.UpdateMESItem(spec);
                    }
                    else
                    {
                        ProductSpec theSpec = old[0];
                        theSpec.retrieveStepSpecs();
                        foreach (StepParameter oldStepParm in theSpec.Items)
                        {
                            oldStepParm.RetrieveSpecInformation();
                            if (spec.Item(oldStepParm.name) != null)
                                oldStepParm.deleteFlag = "1";
                        }

                        foreach (StepParameter newStepParm in spec.Items)
                            theSpec.Add(newStepParm);

                        theSpec.modifyUser = mesRelease.USR.User.loginUserId;
                        theSpec.Modify();
                        mesListView1.UpdateMESItem(theSpec);
                        idv.utilities.misc.SetValueChangeByItemName(Name);
                    }
                    //else if (old[0].issueState == idv.mesCore.IssueState.New)
                    //{
                    //    throw new Exception("新版本已存在");
                    //}
                    //else
                    //{
                    //    ProductSpec lastVersion = old[0];
                    //    lastVersion.Clear();
                    //    lastVersion.NewVersion();
                    //    foreach (StepParameter sp in spec.Items)
                    //        lastVersion.Add(sp);

                    //    lastVersion.modifyUser = mesRelease.USR.User.loginUserId;
                    //    lastVersion.Modify();

                    //    ProductSpec item = mesListView1.GetMESItemByName(lastVersion.name) as ProductSpec;
                    //    if (item != null)
                    //        mesListView1.RemoveMESItem(item);
                    //    mesListView1.UpdateMESItem(lastVersion);
                    //}
                }
                messageBox.showMessageById("msgExecuteSucceed");
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.Message);
            }
        }

        void executeClear()
        {
            txtSpecName.Text = "";
            txtSpecName.SelectedItem = null;
            txtDescription.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            string condition = "";
            if (txtSpecName.Text.Trim() != "")
                condition = "name like '%" + txtSpecName.Text.Trim() + "%'";
            mesListView1.ShowMESItems(ProductSpec.GetLastestVersionSpecs(condition));
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtSpecName, lblSpecName)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ProductSpec item = new ProductSpec();
                item.name = txtSpecName.Text;
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
                ProductSpec item = new ProductSpec(curItem.name, curItem.version);
                item.name = txtSpecName.Text;
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                item.modifyUser = item.createUser;
                item.modifyDate = item.createDate;
                item.version = 0;
                item.retrieveStepSpecs();

                foreach (StepParameter sp in item.Items)
                    sp.RetrieveSpecInformation();

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

        void executeModify()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!appInstance.CheckInputData(txtSpecName, lblSpecName)) return;

            if (curItem.name != txtSpecName.Text && (curItem.issueState != idv.mesCore.IssueState.New || curItem.version!=0))
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblSpecName.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                curItem.name = txtSpecName.Text;
                curItem.description = txtDescription.Text;
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;
                parText_Leave(null, null);
                recText_Leave(null, null);
                if (lvwMaterialType.SelectedItems.Count > 0)
                    lvwMaterialType.SelectedItems[0].Selected = false;
                if (lvwRecipe.SelectedItems.Count > 0)
                    lvwRecipe.SelectedItems[0].Selected = false;
                keepStepSpecInformation();
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
                ProductSpec[] lastItem = ProductSpec.GetLastestVersionSpecs("name='" + curItem.name + "'");
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
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("issue"))) return;
            try
            {
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;
                curItem.Issue();
                mesListView1.UpdateCurrentItem(curItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
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
                foreach (ProductSpec r in curItem.GetOtherVersions())
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

        void mnuItemVersion_Click(object sender, EventArgs e)
        {
            ProductSpec r = (sender as ToolStripMenuItem).Tag as ProductSpec;
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
                ProductSpec newItem = new ProductSpec(curItem.name, curItem.version);

                newItem.retrieveStepSpecs();

                foreach (StepParameter sp in newItem.Items)
                    sp.RetrieveSpecInformation();

                newItem.createUser = mesRelease.USR.User.loginUser.name;
                newItem.modifyDate = DateTime.Now;
                newItem.modifyUser = newItem.createUser;
                newItem.modifyDate = newItem.createDate;
                newItem.NewVersion();
                mesListView1.UpdateCurrentItem(newItem);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        System.Threading.Thread tRetrieveStepSpecInfo = null;
        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            lvwStep.SelectedItems.Clear();
            if (!selected)
            {
                executeClear();
                curItem = null;
                mnuVersion.Items.Clear();
                ClearStepSelectionColor(null);
            }
            else
            {
                curItem = item as ProductSpec;
                if (curItem != null)
                {
                    try
                    {
                        if (tRetrieveStepSpecInfo != null) tRetrieveStepSpecInfo.Join();
                    }
                    catch { }

                    txtSpecName.Text = curItem.name;
                    txtVersion.Text = curItem.version.ToString();
                    txtDescription.Text = curItem.description;
                    curItem.retrieveStepSpecs();

                    tRetrieveStepSpecInfo = new System.Threading.Thread(new System.Threading.ThreadStart(
                        retrieveCurrentItemStepSpecInformation));
                    tRetrieveStepSpecInfo.Start();

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(curItem);
                }                
            }
            
        }

        void retrieveCurrentItemStepSpecInformation()
        {
            if (curItem == null) return;
            foreach (StepParameter sp in curItem.Items)
                sp.RetrieveSpecInformation();
            ShowStepSelectionColor(curItem.Items.ToArray());
            tRetrieveStepSpecInfo = null;
        }

        void ClearStepSelectionColor(idv.messageService.itemBase item)
        {
            if (item == null)
            {
                foreach (ListViewItem listItem in lvwStep.Items)
                {
                    listItem.ForeColor = SystemColors.WindowText;
                    listItem.BackColor = SystemColors.Window;
                }
            }
            else
            {
                foreach (ListViewItem listItem in lvwStep.Items)
                {
                    if (listItem.Text == item.name)
                    {
                        listItem.ForeColor = SystemColors.WindowText;
                        listItem.BackColor = SystemColors.Window;
                        break;
                    }
                }
            }
        }

        void ShowStepSelectionColor(params idv.messageService.itemBase[] items)
        {
            foreach (ListViewItem listItem in lvwStep.Items)
            {
                foreach (idv.messageService.itemBase item in items)
                {
                    if (listItem.Text.Equals(item.name))
                    {
                        if (!(item as StepParameter).IsSettingEmpty())
                        {
                            //listItem.ForeColor = Color.White;
                            listItem.BackColor = Color.LightGreen;
                        }
                        break;
                    }
                }
            }
        }

        private void lvwStep_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                keepStepSpecInformation();
                lvwParameter.RemoveAllMESItems();
                lvwMaterialType.RemoveAllMESItems();
                if (lvwRecipe.SelectedItems.Count > 0)
                    lvwRecipe.SelectedItems[0].Selected = false;
                lvwRecipe.Items.Clear();
                txtStdProcessTime.Text = "";

                if (curStepParmeter != null)
                {
                    if (curStepParmeter.IsSettingEmpty())
                        ClearStepSelectionColor(curStepParmeter);
                    else
                        ShowStepSelectionColor(curStepParmeter);
                }

                curStepParmeter = null;
                curStep = null;
                matReqCombo.Hide();
                if (toolingEnable)
                    pnlTooling.Visible = false;
            }
            else
            {
                if (curItem == null) return;
                curStepParmeter = curItem.Item(item.name);
                curStep = item as Step;
                if (curStepParmeter == null)
                {
                    curStepParmeter = new StepParameter();
                    curStepParmeter.name = item.name;
                    curItem.Add(curStepParmeter);
                }
                txtStdProcessTime.Text = curStepParmeter.stdProcessTime.ToString();
                showStepSpecInformation();
            }
        }
        void keepStepSpecInformation()
        {
            if (curStepParmeter == null) return;
            //站點參數
            //為了要跟ListView上的順序一樣，把StepParameter裏的Parameter先取出放到暫時集合中
            StepParameter tmpStepParameter = new StepParameter();
            foreach (Parameter param in curStepParmeter.Items)
                tmpStepParameter.Add(param);
            curStepParmeter.Clear();

            foreach (ListViewItem item in lvwParameter.Items)
            {
                Parameter par = item.Tag as Parameter;
                if (par == null) continue;

                Parameter param = tmpStepParameter.Item(item.Text);
                if (param == null)
                {
                    param = new Parameter();
                    param.name = par.name;
                    param.description = par.description;
                    param.parmType = par.parmType;
                    param.parameterSysId = par.parameterSysId;
                }

                if (par.parmType == idv.mesCore.PARM.ParameterType.Range)
                {
                    double d = 0;

                    if (double.TryParse(item.SubItems[2].Text, out d))
                        param.max = d;
                    else
                        param.max = double.MaxValue;
                    if (double.TryParse(item.SubItems[3].Text, out d))
                        param.min = d;
                    else
                        param.min = double.MinValue;
                }
                else if (par.parmType == idv.mesCore.PARM.ParameterType.Numeric)
                {
                    double d = 0;
                    if (double.TryParse(item.SubItems[1].Text, out d))
                        param.value = d.ToString();
                    else
                        param.value = "";
                }
                else
                {
                    param.value = item.SubItems[1].Text;
                }
                param.remark = item.SubItems[4].Text;
                param.deleteFlag = "0";
                tmpStepParameter.Remove(param.name);
                curStepParmeter.Add(param);
            }
            foreach (Parameter par in tmpStepParameter.Items)//把原來在站點的，但當前不在的賦值deleteFlag=1(將會刪除)
            {
                par.deleteFlag = "1";
                curStepParmeter.Add(par);
            }

            double stdTime = 0;
            if (double.TryParse(txtStdProcessTime.Text, out stdTime))
                curStepParmeter.stdProcessTime = stdTime;
            else
                curStepParmeter.stdProcessTime = 0;

            //站點耗用物料 --> 在lvwMaterialType_MESItemSelectionChanged

            //機台程式
            foreach (ListViewItem item in lvwRecipe.Items)
            {
                EqRecipe er = curStepParmeter.GetEqRecipe(item.Text);
                if (er == null)
                {
                    er = new EqRecipe();
                    er.name = item.Text;
                    curStepParmeter.AddEqRecipe(er);
                }
                er.recipe = item.SubItems[1].Text;
            }
        }

        void showStepSpecInformation()
        {
            if (curStepParmeter == null) return;

            //機台程式
            for (int i = 0; i < curStepParmeter.EqRecipeCount; i++)
                curStepParmeter.GetEqRecipe(i).deleteFlag = "1"; //不在<當前站點可用的>機台型號裏的將刪除

            //機台軌道用料資訊
            foreach (string sType in curStepParmeter.GetEqTypes())
            {
                foreach (EqTrackMaterial trackMaterial in curStepParmeter.GetEqTrackMaterials(sType))
                    trackMaterial.deleteFlag = "1";//不在<當前站點可用的>機台型號裏的將刪除
            }

            isTrackEq = false;
            foreach (string sType in curStep.GetEqTypes())
            {
                EqRecipe er = curStepParmeter.GetEqRecipe(sType);
                if (er != null) er.deleteFlag = "0";

                ListViewItem vItem = new ListViewItem(sType);
                vItem.Name = sType;
                vItem.SubItems.Add(er == null ? "" : er.recipe);
                lvwRecipe.Items.Add(vItem);

                //將機台型號的所有軌道的設定回復deleteFlag="0"
                mesRelease.EQP.EqType type = mesRelease.EQP.EqType.GetEqType(sType);
                if (type != null && type.trackCount > 1)
                {
                    isTrackEq = true;
                    foreach (string track in type.tracks)
                    {
                        EqTrackMaterial trackMaterial = curStepParmeter.GetEqTrackMaterial(sType, track);
                        if (trackMaterial != null)
                            trackMaterial.deleteFlag = "0";
                    }
                }
            }
            Invoke(new MethodInvoker(definePartNoByMatTypeOrEqTrack));
            if (isTrackEq && lvwRecipe.Items.Count == 1)
                lvwRecipe.Items[0].Selected = true;

            //站點參數
            StepParameter s = getStepParameter(curStepParmeter.name);
            lvwParameter.ShowMESItems(s.Items.ToArray());

            foreach (Parameter param in curStepParmeter.Items)
                param.deleteFlag = "1";//不在<當前站點定義的>站點參數裏的將刪除

            foreach (ListViewItem item in lvwParameter.Items)
            {
                item.UseItemStyleForSubItems = false;
                Parameter par = item.Tag as Parameter;
                if (par == null) continue;

                Parameter param = curStepParmeter.Item(par.name);
                if (param != null) param.deleteFlag = "0";

                if (par.parmType == idv.mesCore.PARM.ParameterType.Range)
                {
                    item.SubItems[1].BackColor = nonEditColor;
                    item.SubItems[1].Text = "--";
                    item.SubItems[2].BackColor = SystemColors.Window;
                    item.SubItems[3].BackColor = SystemColors.Window;
                    if (param != null)
                    {
                        item.SubItems[2].Text = param.max == double.MaxValue ? "" : param.max.ToString();
                        item.SubItems[3].Text = param.min == double.MinValue ? "" : param.min.ToString();
                    }
                }
                else
                {
                    item.SubItems[1].BackColor = SystemColors.Window;
                    item.SubItems[2].BackColor = nonEditColor;
                    item.SubItems[2].Text = "--";
                    item.SubItems[3].BackColor = nonEditColor;
                    item.SubItems[3].Text = "--";
                    if (param != null)
                    {
                        item.SubItems[1].Text = param.value;
                    }
                }
                if (param != null)
                    item.SubItems[4].Text = param.remark;
            }

            //站點耗用物料
            for (int i = 0; i < curStepParmeter.MaterialTypeCount; i++)
                curStepParmeter.GetMaterialType(i).deleteFlag = "1";//不在<當前站點定義的>站點耗用物料裏的將刪除

            if (!isTrackEq)
            {
                List<SpecMaterial> specMatList = new List<SpecMaterial>();
                foreach (StepMaterialType stepMatType in curStep.GetMaterialTypes())
                {
                    SpecMaterial specMatType = curStepParmeter.GetMaterialType(stepMatType.name);
                    if (specMatType == null)
                    {
                        specMatType = new SpecMaterial();
                        specMatType.name = stepMatType.name;
                        specMatType.required = stepMatType.required;
                        curStepParmeter.AddMaterialType(specMatType);
                    }
                    specMatType.consumeRate = stepMatType.consumeRate;
                    specMatType.deleteFlag = "0";
                    specMatList.Add(specMatType);
                }
                lvwMaterialType.ShowMESItems(specMatList.ToArray());
                if (lvwMaterialType.Items.Count == 1)
                    lvwMaterialType.Items[0].Selected = true;
            }
        }
        void definePartNoByMatTypeOrEqTrack()
        {
            if (idv.mesCore.systemConfig.materialTracking)
            {
                pnlEqTrackMaterial.Visible = isTrackEq;
                pnlMaterialType.Visible = !isTrackEq;
            }
        }

        Dictionary<string, StepParameter> lstStepParameter = new Dictionary<string, StepParameter>();
        StepParameter getStepParameter(string name)
        {
            if (lstStepParameter.ContainsKey(name))
                return lstStepParameter[name];
            else
            {
                StepParameter s = new StepParameter(name);
                lstStepParameter.Add(name, s);
                return s;
            }
        }

        private void lvwParameter_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ListViewHitTestInfo testInfo = lvwParameter.HitTest(e.X, e.Y);
                if (testInfo.SubItem != null)
                {
                    parText.Hide();
                    ListViewItem.ListViewSubItem subItem = testInfo.SubItem;

                    if (subItem != testInfo.Item.SubItems[0])
                    {
                        Parameter parm = testInfo.Item.Tag as Parameter;
                        numericOnly = (parm.parmType != idv.mesCore.PARM.ParameterType.String) && subItem != testInfo.Item.SubItems[4];//不是remark欄位
                        if (subItem == testInfo.Item.SubItems[4])
                            parText.MaxLength = 255;
                        else
                            parText.MaxLength = 40;
                        if (subItem.BackColor != nonEditColor)
                            showListViewEditText(parText, subItem);
                    }
                }
            }
        }
        void showListViewEditText(Control ctl, ListViewItem.ListViewSubItem subItem)
        {
            if (!editable) return; 
            ctl.BackColor = subItem.BackColor;
            ctl.Tag = subItem;
            ctl.Text = subItem.Text;
            Rectangle r = subItem.Bounds;
            if (ctl is TextBox)
                ctl.Bounds = new Rectangle(r.X + 6, r.Y + 2, r.Width - 6, r.Height - 2);
            else//ComboBox
                ctl.Bounds = new Rectangle(r.X + 2, r.Y - 2, r.Width - 2, r.Height);
            ctl.Show();
            ctl.Focus();
        }

        private void txtStdProcessTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPressNumericOnly(txtStdProcessTime, e);
        }

        void keepMaterialParts(string materialType)
        {
            if (curStepParmeter == null) return;
            SpecMaterial specMaterial = curStepParmeter.GetMaterialType(materialType);
            if (specMaterial != null) specMaterial.Clear();
            if (lvwPartNo.Items.Count > 0)
            {
                if (specMaterial == null)
                {
                    specMaterial = new SpecMaterial();
                    specMaterial.name = materialType;
                    StepMaterialType smt = curStep.GetMaterialType(materialType);
                    if (smt != null)
                        specMaterial.required = smt.required;
                    curStepParmeter.AddMaterialType(specMaterial);
                }
                foreach (ListViewItem vItem in lvwPartNo.Items)
                {
                    double d = 0;
                    double.TryParse(vItem.SubItems[1].Text, out d);
                    specMaterial.Add(vItem.Text, d);
                }
            }
        }
        private void lvwMaterialType_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (curStepParmeter == null) return;
            SpecMaterial curMaterialType = item as SpecMaterial;

            if (!selected)
            {
                if (curMaterialType != null)
                {
                    bool required = curMaterialType.required;
                    bool.TryParse(listItem.SubItems[1].Text, out required);
                    curMaterialType.required = required;
                }

                keepMaterialParts(curMaterialType.name);
                cboPartNo.Items.Clear();
                lvwPartNo.Items.Clear();
                cboPartNo.Text = "";
                txtConsumeRate.Text = "";
            }
            else
            {
                foreach (string s in curMaterialType.partNOs)
                {
                    ListViewItem vItem = new ListViewItem(s);
                    vItem.Name = s;
                    vItem.SubItems.Add(curMaterialType.GetConsumeRate(s).ToString());
                    lvwPartNo.Items.Add(vItem);
                }

                txtConsumeRate.Text = curMaterialType.consumeRate.ToString();
                cboPartNo.Items.Clear();
                cboPartNo.Items.AddRange(mesRelease.MAT.MaterialPart.GetMaterialPartsByMaterialType(item.name));
            }
        }

        private void lvwRecipe_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (curStepParmeter == null) return;
            if (!e.IsSelected)
            {
                lvwEqTrackMaterial.RemoveAllMESItems();
                if (toolingEnable)
                    lvwEqTooling.RemoveAllMESItems();
            }
            else
            {
                mesRelease.EQP.EqType type = mesRelease.EQP.EqType.GetEqType(e.Item.Name);
                if (type == null) return;
                if (type.trackCount > 1)
                {
                    curStepParmeter.InitEqTrackMaterial(type.name);
                    short seq = 0;
                    List<EqTrackMaterial> list = new List<EqTrackMaterial>();
                    foreach (string track in type.tracks)
                    {
                        EqTrackMaterial trackMaterial = curStepParmeter.GetEqTrackMaterial(type.name, track);
                        if (trackMaterial != null && !trackMaterial.deleteFlag.Equals("1"))
                        {
                            trackMaterial.seq = seq++;
                            list.Add(trackMaterial);
                        }
                    }
                    lvwEqTrackMaterial.ShowMESItems(list.ToArray());
                }
                if (toolingEnable)
                {
                    curStepParmeter.InitEqTooling(type.name);
                    List<EqTooling> list = new List<EqTooling>();
                    foreach (string tolType in type.toolingTypes)
                    {
                        EqTooling eqTol = curStepParmeter.GetEqTooling(type.name, tolType);
                        if (eqTol != null && !eqTol.deleteFlag.Equals("1"))
                            list.Add(eqTol);
                    }
                    if (list.Count > 0)
                    {
                        pnlTooling.Visible = true;
                        lvwEqTooling.ShowMESItems(list.ToArray());
                    }
                    else
                        pnlTooling.Visible = false;
                }
            }
        }
        private void lvwEqTrackMaterial_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (curStepParmeter == null) return;
            EqTrackMaterial trackMat = item as EqTrackMaterial;
            if (!selected)
            {
                keepEqTrackMaterial(trackMat);
                lvwPartNo.Items.Clear();
                cboPartNo.Text = "";
                txtConsumeRate.Text = "";
            }
            else
            {
                foreach (string s in trackMat.partNOs)
                {
                    ListViewItem vItem = new ListViewItem(s);
                    vItem.Name = s;
                    vItem.SubItems.Add(trackMat.GetConsumeRate(s).ToString());
                    lvwPartNo.Items.Add(vItem);
                }
                txtConsumeRate.Text = "1";
            }
        }
        void keepEqTrackMaterial(EqTrackMaterial trackMat)
        {
            if (curStepParmeter == null) return;
            trackMat.Clear();
            foreach (ListViewItem vItem in lvwPartNo.Items)
            {
                double d = 0;
                double.TryParse(vItem.SubItems[1].Text, out d);
                trackMat.Add(vItem.Text, d);
            }
        }

        private void lvwEqTooling_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (curStepParmeter == null) return;
            EqTooling eqTool = item as EqTooling;
            if (!selected)
            {
                keepEqTooling(eqTool);
                lvwToolingPart.Items.Clear();
                cboToolingPart.Text = "";
            }
            else
            {
                foreach (string s in eqTool.partNOs)
                {
                    ListViewItem vItem = new ListViewItem(s);
                    vItem.Name = s;
                    lvwToolingPart.Items.Add(vItem);
                }
            }
        }
        void keepEqTooling(EqTooling eqTool)
        {
            if (curStepParmeter == null) return;
            eqTool.Clear();
            foreach (ListViewItem vItem in lvwToolingPart.Items)
                eqTool.Add(vItem.Text);
        }

        private void txtConsumeRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKeyPressNumericOnly(txtConsumeRate, e);
        }

        private void lvwPartNo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                cboPartNo.Text = "";
                txtConsumeRate.Text = "1";
            }
            else
            {
                cboPartNo.Text = e.Item.Text;
                txtConsumeRate.Text = e.Item.SubItems[1].Text;
            }
        }

        private void btnAddPartNo_Click(object sender, EventArgs e)
        {
            if (!isTrackEq && lvwMaterialType.SelectedItems.Count == 0) return;
            if (cboPartNo.Text.Trim() == "") return;
            if (lvwPartNo.Items[cboPartNo.Text] != null) return;
            double d = 0;
            double.TryParse(txtConsumeRate.Text, out d);

            if (d == 0)
            {
                if (isTrackEq)
                    d = 1;
                else
                {
                    SpecMaterial specMat = lvwMaterialType.selectedMESItem as SpecMaterial;
                    if (specMat != null)
                        d = specMat.consumeRate;
                }
            }

            if (mesRelease.MAT.MaterialPart.GetMaterialPart(cboPartNo.Text.Trim()) == null)
                return;

            ListViewItem item = new ListViewItem(cboPartNo.Text);
            item.Name = cboPartNo.Text;
            item.SubItems.Add(d.ToString());
            lvwPartNo.Items.Add(item);
            cboPartNo.Text = "";
        }

        private void btnModifyPartNo_Click(object sender, EventArgs e)
        {
            if (cboPartNo.Text.Trim() == "") return;
            if (lvwPartNo.SelectedItems.Count == 0) return;
            if (lvwPartNo.Items[cboPartNo.Text] != null && lvwPartNo.Items[cboPartNo.Text] != lvwPartNo.SelectedItems[0]) return;
            double d = 0;
            double.TryParse(txtConsumeRate.Text, out d);
            ListViewItem item = lvwPartNo.SelectedItems[0];
            item.Name = cboPartNo.Text;
            item.Text = cboPartNo.Text;
            item.SubItems[1].Text = d.ToString();
        }

        private void btnDeletePartNo_Click(object sender, EventArgs e)
        {
            if (lvwPartNo.SelectedItems.Count == 0) return;
            lvwPartNo.Items.Remove(lvwPartNo.SelectedItems[0]);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lvwPartNo.SelectedItems.Count == 0) return;
            ListViewItem item = lvwPartNo.SelectedItems[0];
            if (item.Index == 0) return;
            ListViewItem tmpItem = lvwPartNo.Items[item.Index - 1];
            string txt = tmpItem.Text;
            string txt2 = tmpItem.SubItems[1].Text;
            tmpItem.Name = item.Text;
            tmpItem.Text = item.Text;
            tmpItem.SubItems[1].Text = item.SubItems[1].Text;
            item.Name = txt;
            item.Text = txt;
            item.SubItems[1].Text = txt2;
            item.Selected = false;
            tmpItem.Selected = true;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lvwPartNo.SelectedItems.Count == 0) return;
            ListViewItem item = lvwPartNo.SelectedItems[0];
            if (item.Index == lvwPartNo.Items.Count - 1) return;
            ListViewItem tmpItem = lvwPartNo.Items[item.Index + 1];
            string txt = tmpItem.Text;
            string txt2 = tmpItem.SubItems[1].Text;
            tmpItem.Name = item.Text;
            tmpItem.Text = item.Text;
            tmpItem.SubItems[1].Text = item.SubItems[1].Text;
            item.Name = txt;
            item.Text = txt;
            item.SubItems[1].Text = txt2;
            item.Selected = false;
            tmpItem.Selected = true;
        }

        private void btnAddToolingPart_Click(object sender, EventArgs e)
        {
            if (cboToolingPart.Text.Trim() == "") return;
            if (lvwToolingPart.Items[cboToolingPart.Text] != null) return;

            if (idv.messageService.serviceHost.Client.getValueWithParameter("select part_no from mes_tol_part where part_no=?", cboToolingPart.Text).Equals(""))
                return;

            ListViewItem item = new ListViewItem(cboToolingPart.Text);
            item.Name = cboToolingPart.Text;
            lvwToolingPart.Items.Add(item);
            cboToolingPart.Text = "";
        }

        private void btnDeleteToolingPart_Click(object sender, EventArgs e)
        {
            if (lvwToolingPart.SelectedItems.Count == 0) return;
            lvwToolingPart.Items.Remove(lvwToolingPart.SelectedItems[0]);
        }

        private void btnUpToolingPart_Click(object sender, EventArgs e)
        {
            if (lvwToolingPart.SelectedItems.Count == 0) return;
            ListViewItem item = lvwToolingPart.SelectedItems[0];
            if (item.Index == 0) return;
            ListViewItem tmpItem = lvwToolingPart.Items[item.Index - 1];
            string txt = tmpItem.Text;
            tmpItem.Name = item.Text;
            tmpItem.Text = item.Text;
            item.Name = txt;
            item.Text = txt;
            item.Selected = false;
            tmpItem.Selected = true;
        }

        private void btnDownToolingPart_Click(object sender, EventArgs e)
        {
            if (lvwToolingPart.SelectedItems.Count == 0) return;
            ListViewItem item = lvwToolingPart.SelectedItems[0];
            if (item.Index == lvwToolingPart.Items.Count - 1) return;
            ListViewItem tmpItem = lvwToolingPart.Items[item.Index + 1];
            string txt = tmpItem.Text;
            tmpItem.Name = item.Text;
            tmpItem.Text = item.Text;
            item.Name = txt;
            item.Text = txt;
            item.Selected = false;
            tmpItem.Selected = true;
        }

        private void lvwRecipe_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ListViewHitTestInfo testInfo = lvwRecipe.HitTest(e.X, e.Y);
                if (testInfo.SubItem != null)
                {
                    recText.Hide();
                    ListViewItem.ListViewSubItem subItem = testInfo.SubItem;

                    if (subItem != testInfo.Item.SubItems[0])
                        showListViewEditText(recText, subItem);
                }
            }
        }

        private void lvwMaterialType_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ListViewHitTestInfo testInfo = lvwMaterialType.HitTest(e.X, e.Y);
                if (testInfo.SubItem != null)
                {
                    matReqCombo.Hide();
                    ListViewItem.ListViewSubItem subItem = testInfo.SubItem;

                    if (subItem == testInfo.Item.SubItems[1])
                    {
                        showListViewEditText(matReqCombo, subItem);
                        return;
                    }
                }
                if (lvwMaterialType.selectedMESItem != null)
                    cboPartNo.Focus();
            }
        }

        private void lvwEqTrackMaterial_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (lvwEqTrackMaterial.selectedMESItem != null)
                    cboPartNo.Focus();
            }
        }

        private void lvwEqTooling_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (lvwEqTooling.selectedMESItem != null)
                    cboToolingPart.Focus();
            }
        }

        private void frmProductParameter_Activated(object sender, EventArgs e)
        {
            bool changed = false;

            if (idv.utilities.misc.IsValueChanged("frmRoute", Name))
            {
                string selRoute = cboRoute.Text;
                initRoute();
                if (!selRoute.Equals(""))
                {
                    cboRoute.Text = selRoute;
                    if (cboRoute.Text.Equals(""))
                        cboRoute.Text = "";
                }
            }

            if (idv.utilities.misc.IsValueChanged("frmStep", Name) | idv.utilities.misc.IsValueChanged("frmStepParameter", Name))
            {
                initStep();
                lstStepParameter.Clear();
                changed = true;
            }

            if (changed && mesListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = mesListView1.SelectedItems[0];
                item.Selected = false;
                item.Selected = true;
            }

            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmProductParameter_Activated", null);
      
        }

        private void lvwEqTrackMaterial_Resize(object sender, EventArgs e)
        {
            if (lvwEqTrackMaterial.Columns.Count > 0)
                lvwEqTrackMaterial.Columns[0].Width = lvwEqTrackMaterial.Width - 10;
        }

        private void lvwEqTooling_Resize(object sender, EventArgs e)
        {
            if (lvwEqTooling.Columns.Count > 0)
                lvwEqTooling.Columns[0].Width = lvwEqTooling.Width - 10;
        }

        private void cboPartNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddPartNo.PerformClick();
        }

        private void cboToolingPart_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddToolingPart.PerformClick();
        }

    }
}
