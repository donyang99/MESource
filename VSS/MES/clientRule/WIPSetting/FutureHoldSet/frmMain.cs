using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.FutureHoldSet
{
    public partial class frmMain : Form
    {
        FutureHoldInfo currentItem = null;
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {                        
            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            initToolbar();
            dtStartDate.Value = dtStartDate.MinDate;
            dtExpireDate.Value = dtExpireDate.MaxDate;
            lvwFutureHold.prepareColumns();
            setTimingInfo();

            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        void setTimingInfo()
        {
            string desc = cultureLanguage.getValue(idv.mesCore.WIP.FutureActionTiming.BeforeTrackIn.ToString());
            if (desc == "")
                cboTiming.Items.Add(idv.mesCore.WIP.FutureActionTiming.BeforeTrackIn.ToString());
            else
                cboTiming.Items.Add(desc);


            desc = cultureLanguage.getValue(idv.mesCore.WIP.FutureActionTiming.AfterTrackOut.ToString());
            if (desc == "")
                cboTiming.Items.Add(idv.mesCore.WIP.FutureActionTiming.AfterTrackOut.ToString());
            else
                cboTiming.Items.Add(desc);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                idv.messageService.IMessageGuard client = idv.messageService.serviceHost.IsolationClient;

                cboOrderId.Items.Add("");
                string sql = "select order_id from mes_wip_order where status='Active'";
                DataSet ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                    cboOrderId.Items.Add(row["order_id"].ToString());

                cboProduct.Items.Add("");
                sql = "select product_id from mes_prp_product where issue_state='Active'";
                ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                    cboProduct.Items.Add(row["product_id"].ToString());

                cboRoute.Items.Add("");
                sql = "select route_id from mes_prp_routing where issue_state='Active'";
                ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                    cboRoute.Items.Add(row["route_id"].ToString());

                cboStepId.Items.Add("");
                sql = "select stage,step_id from mes_prp_step where issue_state='Active'";
                ds = client.getDataSet(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string description = "";
                    //description = idv.utilities.cultureLanguage.getValue(row["step_id"].ToString());
                    if (description == "")
                        cboStepId.Items.Add(row["step_id"].ToString());
                    else
                        cboStepId.Items.Add(row["step_id"].ToString() + " - " + description);
                }

                Invoke(new MethodInvoker(setComboAutoCompleteAttribute));
            }
            catch { }
        }

        void setComboAutoCompleteAttribute()
        {
            cboOrderId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboOrderId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboRoute.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboRoute.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboStepId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboStepId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.addButton("Clear", "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            standardStatusbar1.setInformation("");
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
            }
        }

        private void executeClear()
        {
            txtLotId.Text = "";
            cboOrderId.Text = "";
            cboProduct.Text = "";
            cboRoute.Text = "";
            cboStepId.Text = "";
            dtStartDate.Value = dtStartDate.MinDate;
            dtExpireDate.Value = dtExpireDate.MaxDate;
            if(cboTiming.Enabled)
                cboTiming.SelectedItem = null;
            cboHoldReason.Text = "";
        }

        private void executeQuery()
        {
            List<string> fixedCondiftion = new List<string>();

            fixedCondiftion.Add("delete_flag='0' and active='1'");
            if (txtLotId.Text != "" && tclTargetKind.SelectedTab== tabLot)
            {
                fixedCondiftion.Add("kind ='" + ((int)idv.mesCore.WIP.TargetKind.Lot).ToString() + "'");
                fixedCondiftion.Add("id ='" + txtLotId.Text + "'");
            }
            else if (cboOrderId.Text != "" && tclTargetKind.SelectedTab == tabOrder)
            {
                fixedCondiftion.Add("kind ='" + ((int)idv.mesCore.WIP.TargetKind.Order).ToString() + "'");
                fixedCondiftion.Add("id ='" + cboOrderId.Text + "'");
            }
            else if (cboProduct.Text != "" && tclTargetKind.SelectedTab == tabProduct)
            {
                fixedCondiftion.Add("kind ='" + ((int)idv.mesCore.WIP.TargetKind.Product).ToString() + "'");
                fixedCondiftion.Add("id ='" + cboProduct.Text + "'");
            }
            else if (cboRoute.Text != "" && tclTargetKind.SelectedTab == tabRoute)
            {
                fixedCondiftion.Add("kind ='" + ((int)idv.mesCore.WIP.TargetKind.Route).ToString() + "'");
                fixedCondiftion.Add("id ='" + cboRoute.Text + "'");
            }
            if (cboStepId.Text != "")
            {
                fixedCondiftion.Add("step_id ='" + cboStepId.Text + "'");
            }

            if (fixedCondiftion.Count > 0)
            {
                sqlCondition = string.Join(" and ", fixedCondiftion.ToArray());
            }

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(showResult));
            t.Start();
            Cursor = Cursors.WaitCursor;
        }
        string sqlCondition = "";
        void showResult()
        {
            lvwFutureHold.ShowMESItems(mesRelease.WIP.FutureHoldInfo.GetFutureHoldInfo(sqlCondition));
            Cursor = Cursors.Default;
        }

        private void executeAdd()
        {
            if (!CheckInputData()) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "add")) return;
            try
            {
                FutureHoldInfo item = new FutureHoldInfo();
                assignFutureHoldAttribute(item);
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                item.New();
                lvwFutureHold.UpdateMESItem(item);
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            catch (Exception ex)
            {
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
            }
        }

        private void executeModify()
        {
            if (currentItem == null)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("noItemSelected"), idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (!CheckInputData()) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "modify")) return;
            try
            {
                assignFutureHoldAttribute(currentItem);
                currentItem.Modify();
                lvwFutureHold.UpdateMESItem(currentItem);
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            catch (Exception ex)
            {
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
            }
        }

        private void executeDelete()
        {
            if (currentItem == null)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("noItemSelected"), idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "delete")) return;
            try
            {
                currentItem.Delete();
                lvwFutureHold.RemoveMESItem(currentItem);
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            catch (Exception ex)
            {
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
            }
        }

        private void assignFutureHoldAttribute(FutureHoldInfo fh)
        {
            if (tclTargetKind.SelectedTab == tabLot)
            {
                fh.targetKind = idv.mesCore.WIP.TargetKind.Lot;
                fh.name = txtLotId.Text;
            }
            else if (tclTargetKind.SelectedTab == tabOrder)
            {
                fh.targetKind = idv.mesCore.WIP.TargetKind.Order;
                fh.name = cboOrderId.Text;
            }
            else if (tclTargetKind.SelectedTab == tabProduct)
            {
                fh.targetKind = idv.mesCore.WIP.TargetKind.Product;
                fh.name = cboProduct.Text;
            }
            else if (tclTargetKind.SelectedTab == tabRoute)
            {
                fh.targetKind = idv.mesCore.WIP.TargetKind.Route;
                fh.name = cboRoute.Text;
            }
            fh.stepId = cboStepId.Text;
            fh.startDate = dtStartDate.Value;
            fh.expireDate = dtExpireDate.Value;
            fh.timing = (idv.mesCore.WIP.FutureActionTiming)cboTiming.SelectedIndex;
            if (cboHoldReason.SelectedItem != null)
                fh.reasonCode = (cboHoldReason.SelectedItem as mesRelease.BAS.ReasonCode).name;
            else
                fh.reasonCode = cboHoldReason.Text;
            fh.modifyUser = User.loginUser.name;
            fh.modifyDate = DateTime.Now;
        }

        private bool CheckInputData()
        {
            if (tclTargetKind.SelectedTab == tabLot)
            {
                return CheckInputData(txtLotId, lblLotId, cboStepId, lblStep, cboTiming, lblTiming, cboHoldReason, lblHoldReason);
            }
            else if (tclTargetKind.SelectedTab == tabOrder)
            {
                return CheckInputData(cboOrderId, lblOrderId, cboStepId, lblStep, cboTiming, lblTiming, cboHoldReason, lblHoldReason);
            }
            else if (tclTargetKind.SelectedTab == tabProduct)
            {
                return CheckInputData(cboProduct, lblProductId, cboStepId, lblStep, cboTiming, lblTiming, cboHoldReason, lblHoldReason);
            }
            else if (tclTargetKind.SelectedTab == tabRoute)
            {
                return CheckInputData(cboRoute, lblRouteId, cboStepId, lblStep, cboTiming, lblTiming, cboHoldReason, lblHoldReason);
            }
            return true;
        }

        private bool CheckInputData(params Control[] ctrls)
        {
            bool validFail = false;
            string field = "";
            foreach (Control ctrl in ctrls)
            {
                if (!validFail)
                {
                    if (ctrl.BackColor == SystemColors.Info && ctrl.Visible && ctrl.Text.Trim() == "")
                        validFail = true;
                }
                else
                {
                    field = ctrl.Text;
                    break;
                }
            }
            if (validFail)
            {

                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("requireField2", field),
                                                  idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else
                return true;
        }

        private void lvwFutureHold_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                currentItem = null;
                executeClear();
            }
            else
            {
                currentItem = item as FutureHoldInfo;
                if (currentItem.targetKind == idv.mesCore.WIP.TargetKind.Lot)
                {
                    tclTargetKind.SelectedTab = tabLot;
                    txtLotId.Text = currentItem.name;
                }
                else if (currentItem.targetKind == idv.mesCore.WIP.TargetKind.Order)
                {
                    tclTargetKind.SelectedTab = tabOrder;
                    cboOrderId.Text = currentItem.name;
                }
                else if (currentItem.targetKind == idv.mesCore.WIP.TargetKind.Product)
                {
                    tclTargetKind.SelectedTab = tabProduct;
                    cboProduct.Text = currentItem.name;
                }
                else if (currentItem.targetKind == idv.mesCore.WIP.TargetKind.Route)
                {
                    tclTargetKind.SelectedTab = tabRoute;
                    cboRoute.Text = currentItem.name;
                }
                cboStepId.Text = currentItem.stepId;
                if(cboTiming.Enabled)
                    cboTiming.SelectedIndex = (int)currentItem.timing;
                
                if (currentItem.startDate < dtStartDate.MinDate)
                    currentItem.startDate = dtStartDate.Value;
                if (currentItem.expireDate > dtExpireDate.MaxDate)
                    currentItem.expireDate = dtExpireDate.MaxDate;
                dtStartDate.Value = currentItem.startDate;
                dtExpireDate.Value = currentItem.expireDate;

                bool find = false;
                foreach (object o in cboHoldReason.Items)
                {
                    if ((o as mesRelease.BAS.ReasonCode).name == currentItem.reasonCode)
                    {
                        find = true;
                        cboHoldReason.SelectedItem = o;
                        break;
                    }
                }
                if (!find)
                    cboHoldReason.Text = currentItem.reasonCode;
            }
        }

        private void cboStepId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStepId.Text == "") return;
            cboHoldReason.Items.Clear();
            mesRelease.BAS.ReasonCategory rc = new mesRelease.BAS.ReasonCategory("Hold", cboStepId.Text);
            cboHoldReason.Items.AddRange(rc.Items.ToArray());
            if (cboHoldReason.Text != "")
            {
                cboHoldReason.Text = cboHoldReason.Text;
                if (cboHoldReason.SelectedItem == null)
                    cboHoldReason.Text = "";
            }
        }
    }
}
