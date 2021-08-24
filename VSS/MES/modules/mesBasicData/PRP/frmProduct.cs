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
    public partial class frmProduct : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        Product curItem = null;
        public frmProduct()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("IssueState", "ISSUE");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("|", "");
            actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            actionToolbar1.addButton("Export", "");
            actionToolbar1.addButton("|", "");
        }

        private void frmProduct_Load(object sender, EventArgs e)
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
            lvwAvailable.prepareColumns();
            lvwSelected.prepareColumns();
            lvwDCItem.prepareColumns();
        }

        private void frmProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        private void initRoute()
        {
            lvwAvailable.ShowMESItems(Route.GetActiveVersionRoutes(""));
            lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
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
                case "IssueState":
                    executeIssue();
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
        void executeClear()
        {
            txtProduct.Text = "";
            cboProductType.Text = "";
            cboFAB.Text = "";
            txtLotSize.Text = "";
            txtProductSize.Text = "";
            txtPackingQty.Text = "";
            txtDescription.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }
        void executeQuery()
        {
            string condition = "";
            if(!txtProduct.Text.Trim().Equals(""))
                condition = "product_id like '%" + txtProduct.Text.Trim() + "%'";

            if(!cboProductType.Text.Trim().Equals(""))
            {
                if(!condition.Equals(""))
                    condition += " and ";
                condition += "product_type = '" + cboProductType.Text + "'";
            }

            if (!cboFAB.Text.Trim().Equals(""))
            {
                if (!condition.Equals(""))
                    condition += " and ";
                condition += "fab = '" + cboFAB.Text + "'";
            }

            mesListView1.ShowMESItems(Product.GetProducts(condition));
        }
        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtProduct, lblProduct, cboProductType, lblProductType, cboFAB, lblFab)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                Product item = new Product();
                item.name = txtProduct.Text;
                item.productType = cboProductType.Text;
                item.fab = cboFAB.Text;
                item.composeSize = getNumericValue(txtLotSize.Text);
                item.productSize = txtProductSize.Text;
                item.packingQuantity = getNumericValue(txtPackingQty.Text);
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;

                item.Clear();
                foreach (ListViewItem routeItem in lvwSelected.Items)
                    item.Add(routeItem.Tag as mesRelease.PRP.Route);

                List<string> lstSkipDcSysId = new List<string>();
                foreach (DCItem dcItem in lvwDCItem.selectedMESItems)
                    lstSkipDcSysId.Add(dcItem.sysid);
                item.SetSkipDCItemSysIds(lstSkipDcSysId.ToArray());
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
            if (!appInstance.CheckInputData(txtProduct, lblProduct, cboProductType, lblProductType, cboFAB, lblFab)) return;

            if (curItem.name != txtProduct.Text && curItem.issueState != idv.mesCore.IssueState.New)
            {
                appInstance.showInformation(cultureLanguage.getValue("cantModifyField", lblProduct.Text), informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                curItem.name = txtProduct.Text;
                curItem.productType = cboProductType.Text;
                curItem.fab = cboFAB.Text;
                curItem.composeSize = getNumericValue(txtLotSize.Text);
                curItem.productSize = txtProductSize.Text;
                curItem.packingQuantity = getNumericValue(txtPackingQty.Text);
                curItem.description = txtDescription.Text;
                curItem.modifyUser = mesRelease.USR.User.loginUser.name;

                curItem.Clear();
                foreach (ListViewItem routeItem in lvwSelected.Items)
                    curItem.Add(routeItem.Tag as Route);

                List<string> lstSkipDcSysId = new List<string>();
                foreach (DCItem dcItem in lvwDCItem.selectedMESItems)
                    lstSkipDcSysId.Add(dcItem.sysid);
                curItem.SetSkipDCItemSysIds(lstSkipDcSysId.ToArray());
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
                mesListView1.RemoveMESItem(curItem);
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
                mesListView1.UpdateMESItem(curItem);
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

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("ProductId,ProductType,Fab,LotSize,ProductSize,PackingQty,Description,Issue".Split(','));
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
                    Product item = new Product();
                    item.name = row["ProductId"].ToString();
                    item.productType = row["ProductType"].ToString();
                    item.fab = row["Fab"].ToString();
                    item.composeSize = getNumericValue(row["LotSize"].ToString());
                    item.productSize = row["ProductSize"].ToString();
                    item.packingQuantity = getNumericValue(row["PackingQty"].ToString());
                    item.description = row["Description"].ToString();
                    item.createUser = mesRelease.USR.User.loginUser.name;
                    item.createDate = DateTime.Now;
                    for (int i = 8; i < table.Columns.Count; i++)
                    {
                        if (row[i].ToString() == "") break;
                        Route r = new Route(row[i].ToString());
                        if (r.sysid == "")
                            throw new Exception("Route[" + row[i].ToString() + "] not found");
                        item.Add(r);
                    }
                    item.New();
                    if (row["Issue"].ToString() == "1")
                        item.Issue();
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
                        if (!s.ToUpper().StartsWith("ProductId\tProductType\tFab\tLotSize\tProductSize\tPackingQty\tDescription\tIssue".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] product = s.Split('\t');
                        try
                        {
                            Product item = new Product();
                            item.name = product[0];
                            item.productType = product[1];
                            item.fab = product[2];
                            item.composeSize = getNumericValue(product[3]);
                            item.productSize = product[4];
                            item.packingQuantity = getNumericValue(product[5]);
                            item.description = product[6];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;
                            for (int i = 8; i < product.Length; i++)
                            {
                                if (product[i] == "") break;
                                Route r = new Route(product[i]);
                                if (r.sysid == "")
                                    throw new Exception("Route[" + product[i] + "] not found");
                                item.Add(r);
                            }
                            item.New();
                            if (product[7] == "1")
                                item.Issue();
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
            idv.utilities.misc.SetValueChangeByItemName(Name);
            if (succeed)
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        int getNumericValue(string value)
        {
            int i = 0;
            int.TryParse(value, out i);
            return i;
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
                curItem = null;
            }
            else
            {
                curItem = item as Product;
                if (curItem != null)
                {
                    txtProduct.Text = curItem.name;
                    cboProductType.Text = curItem.productType;
                    cboFAB.Text = curItem.fab;
                    txtLotSize.Text = curItem.composeSize.ToString();
                    txtProductSize.Text = curItem.productSize;
                    txtPackingQty.Text = curItem.packingQuantity.ToString();
                    txtDescription.Text = curItem.description;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(curItem);
                }
            }
            showSelectedItems();
            showSkipDCItems();
        }

        void showSelectedItems()
        {
            lvwAvailable.UpdateMESItem(lvwSelected.GetAllMESItem());
            lvwSelected.RemoveAllMESItems();
            if (curItem == null)
            {
                //btnSelect.Enabled = false;
                //btnUnSelect.Enabled = false;
            }
            else
            {
                curItem.retrieveRoutes();
                lvwSelected.UpdateMESItem(curItem.Items.ToArray());
                lvwAvailable.RemoveMESItem(lvwSelected.GetAllMESItem());
                //btnSelect.Enabled = true;
                //btnUnSelect.Enabled = true;
            }
        }

        void showSkipDCItems()
        {
            lvwDCItem.UnCheckAllItems();
            if (curItem != null)
            {
                List<DCItem> list = new List<DCItem>();
                foreach (DCItem item in lvwDCItem.GetAllMESItem())
                {
                    if (curItem.GetSkipDCItemSysIds().Contains(item.sysid))
                        list.Add(item);
                }
                lvwDCItem.CheckMESItems(list.ToArray());
            }
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void lvwAvailable_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void lvwSelected_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvwAvailable.selectedMESItem == null) return;
            lvwSelected.UpdateMESItem(lvwAvailable.selectedMESItem);
            lvwAvailable.RemoveMESItem(null);
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (lvwSelected.selectedMESItem == null) return;
            lvwAvailable.UpdateMESItem(lvwSelected.selectedMESItem);
            lvwSelected.RemoveMESItem(null);
        }

        private void frmProduct_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmRoute", Name))
            {
                initRoute();
            }

            if (idv.utilities.misc.IsValueChanged("frmProductType", Name))
            {
                string orgType = cboProductType.Text;
                cboProductType.Items.Clear();
                cboProductType.Items.Add("");
                cboProductType.Items.AddRange(mesRelease.PRP.ProductType.GetProductTypes());
                if(!orgType.Equals(""))
                    cboProductType.Text = orgType;
            }

            if (idv.utilities.misc.IsValueChanged("frmFAB", Name))
            {
                string orgFab = cboFAB.Text;
                cboFAB.Items.Clear();
                cboFAB.Items.Add("");
                cboFAB.Items.AddRange(mesRelease.BAS.Fab.GetFabs());
                if (cboFAB.Items.Count > 2)
                    cboFAB.Items.Add("ALL");

                if (!orgFab.Equals(""))
                    cboFAB.Text = orgFab;
            }

            if (idv.utilities.misc.IsValueChanged("frmStepDC", Name))
            {
                lvwDCItem.ShowMESItems(DCItem.getDCItems());
                showSkipDCItems();
            }

            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmProduct_Activated", null);
        }
    }
}
