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

namespace ClientRule.CreateOrder
{
    public partial class frmMain : Form
    {
        WorkOrder currentOrder = null;
        mesRelease.PRP.Route[] allRoutes = null;
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {                        
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            if (!idv.mesCore.systemConfig.productParameter || mesRelease.PARM.ProductSpec.productSpecSetting== idv.mesCore.PARM.productSpecType.specEqualsToOrder
                || mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToProduct)
            {
                lblSpecId.Visible = false;
                cboSpecId.Visible = false;
                //GetSpecIds
            }
            dtpPlanStartDate.Value = DateTime.Now;
            dtpPlanStartDate.Checked = true;
            dtpDueDate.Value = DateTime.Now.AddMonths(1);
            dtpDueDate.Checked = false;
            dtpCustomerDueDate.Value = DateTime.Now.AddMonths(1);
            dtpCustomerDueDate.Checked = false;

            cboStatus.Items.Add("");
            foreach (string s in Enum.GetNames(typeof(idv.mesCore.WIP.OrderStatus)))
                cboStatus.Items.Add(s);
            cboStatus.Text = "Active";

            actionToolbar1.loadStandardButtons();
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Exit", "");

            lvwOrder.prepareColumns();

            t.Join();
            cboProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                cboOrderType.Items.AddRange(mesRelease.BAS.LotType.GetLotTypes());
                if (cboOrderType.Items.Count == 1) cboOrderType.SelectedIndex = 0;

                cboFab.Items.AddRange(mesRelease.BAS.Fab.GetFabNames());
                if (cboFab.Items.Count == 1) cboFab.SelectedIndex = 0;

                for (int i = 1; i < 10; i++)
                    cboPriority.Items.Add(i.ToString());
                cboPriority.SelectedIndex = 4;

                foreach (mesRelease.PRP.Product prod in mesRelease.PRP.Product.GetActiveProducts(""))
                    cboProduct.Items.Add(prod);

                cboOwner.DisplayMember = "nickName";
                foreach (User u in User.GetUsers(""))
                    cboOwner.Items.Add(u);

                //GetCustomerIds
                //cboCustomerId.Items.Add("");
            }
            catch { }
        }
        string OwnerAttribute
        {
            get
            {
                if ((cboOwner.SelectedItem as User) != null)
                {
                    return (cboOwner.SelectedItem as User).name;
                }
                return "";
            }
            set
            {
                foreach (User u in cboOwner.Items)
                {
                    if (u.name.Equals(value))
                    {
                        cboOwner.SelectedItem = u;
                        break;
                    }
                }
            }
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
                //case "Copy":
                //    executeCopy();
                //    break;
                case "Clear":
                    executeClear();
                    break;
                case "Exit":
                    if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("exit"))) return;
                    Close();
                    break;
            }
        }

        bool AssignAttribute(WorkOrder order)
        {
            mesRelease.PRP.Route r = cboRoute.SelectedItem as mesRelease.PRP.Route;
            if (r == null)
            {
                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("msgCannotFindData") + " - " + lblRouteId.Text + " " +
                    cboRoute.Text, idv.mesCore.Controls.informationType.warn);
                return false;
            }
            mesRelease.PRP.Step s = cboStartStep.SelectedItem as mesRelease.PRP.Step;
            order.name = txtOrderId.Text;
            order.orderType = cboOrderType.Text;
            order.fab = cboFab.Text;
            order.priority = Convert.ToByte(cboPriority.Text);
            order.productId = cboProduct.Text;
            order.routeId = r.name;
            order.routeVersion = r.version;
            if (s != null)
            {
                order.startStep = s.name;
                order.startStepHandle = s.stepHandle;
            }
            order.quantity = Convert.ToInt32(txtQuantity.Text);
            order.owner = OwnerAttribute;
            order.customerId = cboCustomerId.Text;
            if (dtpPlanStartDate.Checked)
                order.planStartDate = dtpPlanStartDate.Value.Date;
            if (dtpDueDate.Checked)
                order.dueDate = dtpDueDate.Value.Date;
            if (dtpCustomerDueDate.Checked)
                order.customerDueDate = dtpCustomerDueDate.Value.Date;
            order.remark = txtRemark.Text;
            order.createUser = User.loginUser.name;

            if (cboSpecId.Visible)
                order.specId = cboSpecId.Text;

            return true;
        }

        void executeClear()
        {
            foreach (Control ctl in tblOrderDetail.Controls)
            {
                if (ctl is TextBox)
                    ctl.Text = "";
                else if (ctl is ComboBox)
                {
                    (ctl as ComboBox).SelectedIndex = -1;
                    ctl.Text = "";
                }
                else if (ctl is DateTimePicker)
                {
                    DateTimePicker dtPicker = ctl as DateTimePicker;
                    dtPicker.Value = idv.messageService.serviceHost.dateTime;
                    dtPicker.Checked = false;
                }
            }
            cboStatus.Text = "Active";
        }

        void executeQuery()
        {
            if (!txtOrderId.Text.Equals(""))
            {
                lvwOrder.ShowMESItems(mesRelease.WIP.WorkOrder.GetOrders("order_id='" + txtOrderId.Text + "'"));
            }
            else
            {
                List<string> condition = new List<string>();
                if (cboFab.Text != "")
                    condition.Add("fab='" + cboFab.Text + "'");
                if (cboProduct.Text != "")
                    condition.Add("product_id='" + cboProduct.Text + "'");
                if (cboOrderType.Text != "")
                    condition.Add("order_type='" + cboOrderType.Text + "'");
                if (cboCustomerId.Text != "")
                    condition.Add("customer_id='" + cboCustomerId.Text + "'");
                if (cboStatus.Text != "")
                    condition.Add("status='" + cboStatus.Text + "'");
                if (condition.Count == 0)
                {
                    messageBox.showMessageById("msgNoConditionSpecified");
                    return;
                }
                mesRelease.WIP.WorkOrder[] orders = mesRelease.WIP.WorkOrder.GetOrders(string.Join(" and ", condition.ToArray()));
                lvwOrder.ShowMESItems(orders);
            }
        }

        void executeAdd()
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            RuleInstance.logFunctionIn("executeAdd");

            WorkOrder order = new WorkOrder();
            if (!AssignAttribute(order)) return;
            order.status = idv.mesCore.WIP.OrderStatus.Active.ToString();

            try
            {
                order.New();
                lvwOrder.UpdateMESItem(order);
                txtOrderId.Focus();
                txtOrderId.SelectAll();
                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            catch(Exception ex)
            {
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
            }
            RuleInstance.logFunctionOut("executeAdd");
        }

        void executeModify()
        {
            if (currentOrder == null)
            {
                messageBox.showMessageById("noItemSelected");
                return;
            }
            
            if (!checkBeforeTxn()) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;

            RuleInstance.logFunctionIn("executeModify");

            if (!AssignAttribute(currentOrder)) return;
            currentOrder.status = cboStatus.Text;

            try
            {
                currentOrder.Modify();
                lvwOrder.UpdateMESItem(currentOrder);
                txtOrderId.Focus();
                txtOrderId.SelectAll();
                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            catch (Exception ex)
            {
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
            }
            RuleInstance.logFunctionOut("executeModify");
        }

        void executeDelete()
        {
            if (currentOrder == null)
            {
                messageBox.showMessageById("noItemSelected");
                return;
            }

            if (currentOrder.startQuantity != 0)
            {
                messageBox.showMessageById("cantDelDefaults");
                return;
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;

            RuleInstance.logFunctionIn("executeDelete");

            try
            {
                currentOrder.Delete();
                lvwOrder.RemoveMESItem(currentOrder);
                txtOrderId.Focus();
                txtOrderId.SelectAll();
                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            catch (Exception ex)
            {
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
            }
            RuleInstance.logFunctionOut("executeDelete");
        }

        bool checkBeforeTxn()
        {
            int qty = 0;
            int.TryParse(txtQuantity.Text, out qty);
            if (qty <= 0) txtQuantity.Text = "";
            bool checkResult = CheckInputData(txtOrderId, lblOrderId, cboOrderType, lblOrderType, cboFab, lblFab,
                               cboProduct, lblProductId, cboRoute, lblRouteId, txtQuantity, lblQuantity, cboSpecId, lblSpecId);
            return checkResult;
        }
        bool CheckInputData(params Control[] ctrls)
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
                standardStatusbar1.setInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", field),
                                idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else
                return true;
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            mesRelease.PRP.Product prod = cbo.SelectedItem as mesRelease.PRP.Product;
            if (prod == null) return;
            prod.retrieveRoutes();

            cboRoute.SelectedIndex = -1;
            cboRoute.Items.Clear();
            if (prod.Count > 0)
            {
                cboRoute.Items.AddRange(prod.Items.ToArray());
            }
            else
            {
                if (allRoutes == null)
                    allRoutes = mesRelease.PRP.Route.GetActiveVersionRoutes("");
                cboRoute.Items.AddRange(allRoutes);
            }
            
            if (cboRoute.Items.Count == 1) cboRoute.SelectedIndex = 0;

            if (cboSpecId.Visible)
            {
                cboSpecId.SelectedIndex = -1;
                cboSpecId.Items.Clear();
                cboSpecId.Items.AddRange(mesRelease.PARM.ProductSpec.GetProductSpec(prod.name));
                if (cboSpecId.Items.Count == 1) cboSpecId.SelectedIndex = 0;
            }
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStartStep.SelectedIndex = -1;
            cboStartStep.Items.Clear();
            cboStartStep.Items.Add("");
            mesRelease.PRP.Route route = cboRoute.SelectedItem as mesRelease.PRP.Route;
            if (route == null) return;
            route.retrieveNodes();
            mesRelease.PRP.Step step = route.FirstStep();//第一站不顯示
            step = route.NextStep(step.stepHandle, "PASS");
            while (step != null)
            {
                cboStartStep.Items.Add(step);
                step = route.NextStep(step.stepHandle, "PASS");
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void lvwOrder_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                currentOrder = null;
                executeClear();
            }
            else
            {
                currentOrder = item as WorkOrder;
                if (currentOrder == null) return;
                txtOrderId.Text = currentOrder.name;
                cboOrderType.Text = currentOrder.orderType;
                cboFab.Text = currentOrder.fab;
                cboPriority.Text = currentOrder.priority.ToString();
                cboProduct.Text = currentOrder.productId;
                cboRoute.Text = currentOrder.routeId;
                cboStartStep.Text = currentOrder.startStep;
                txtQuantity.Text = currentOrder.quantity.ToString();
                cboCustomerId.Text = currentOrder.customerId;
                OwnerAttribute = currentOrder.owner;
                cboStatus.Text = currentOrder.status;
                txtRemark.Text = currentOrder.remark;                    

                if (currentOrder.planStartDate.Equals(DateTime.MinValue))
                    dtpPlanStartDate.Checked = false;
                else
                    dtpPlanStartDate.Value = currentOrder.planStartDate;

                if (currentOrder.dueDate.Equals(DateTime.MinValue))
                    dtpDueDate.Checked = false;
                else
                    dtpDueDate.Value = currentOrder.dueDate;

                if (currentOrder.customerDueDate.Equals(DateTime.MinValue))
                    dtpCustomerDueDate.Checked = false;
                else
                    dtpCustomerDueDate.Value = currentOrder.customerDueDate;

                if (cboSpecId.Visible)
                    cboSpecId.Text = currentOrder.specId;
            }
        }
    }
}
