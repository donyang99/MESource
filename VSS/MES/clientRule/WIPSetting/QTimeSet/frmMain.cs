using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.WIP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.QTimeSet
{
    public partial class frmMain : Form
    {
        qTimeSetting currentItem = null;
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
            lvwQTime.prepareColumns();

            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                cboProduct.Items.AddRange(mesRelease.PRP.Product.GetProducts(""));
                Invoke(new MethodInvoker(setComboAutoCompleteAttribute));

                int i = 0;
                qTimeType qType = (qTimeType)i;
                while (!i.ToString().Equals(qType.ToString()))
                {
                    cboQTimeType.Items.Add(qType);
                    i++;
                    qType = (qTimeType)i;
                }
                i = 0;
                qTimeAction qAction = (qTimeAction)i;
                while (!i.ToString().Equals(qAction.ToString()))
                {
                    cboAction.Items.Add(qAction);
                    i++;
                    qAction = (qTimeAction)i;
                }
            }
            catch { }
        }

        void setComboAutoCompleteAttribute()
        {
            cboProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboRoute.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboRoute.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            cboProduct.Text = "";
            cboRoute.Text = "";
            rcbFromStep.Text = "";
            rcbToStep.Text = "";
            txtQTime.Text = "";
            cboQTimeType.SelectedIndex = -1;
            cboAction.SelectedIndex = -1;
        }

        private void executeQuery()
        {
            List<string> fixedCondiftion = new List<string>();

            fixedCondiftion.Add("delete_flag='0'");

            if (cboProduct.Text != "")
            {
                fixedCondiftion.Add("product_id ='" + cboProduct.Text + "'");
            }
            if (cboRoute.Text != "")
            {
                fixedCondiftion.Add("route_id ='" + cboRoute.Text + "'");
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
            lvwQTime.ShowMESItems(qTimeSetting.GetQTimeSetting(sqlCondition));
            Cursor = Cursors.Default;
        }

        private void executeAdd()
        {
            if (!CheckInputData()) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, "add")) return;
            try
            {
                qTimeSetting item = new qTimeSetting();
                assignQTimeAttribute(item);
                item.createUser = User.loginUser.name;
                item.createDate = DateTime.Now;
                item.New();
                lvwQTime.UpdateMESItem(item);
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
                assignQTimeAttribute(currentItem);
                currentItem.Modify();
                lvwQTime.UpdateMESItem(currentItem);
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
                lvwQTime.RemoveMESItem(currentItem);
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
            }
            catch (Exception ex)
            {
                standardStatusbar1.setInformation(ex.Message, idv.mesCore.Controls.informationType.error);
            }
        }

        private void assignQTimeAttribute(qTimeSetting qs)
        {
            qs.productId = cboProduct.Text;
            qs.routeId = cboRoute.Text;
            qs.fromStepId = rcbFromStep.selectedStep.name;
            qs.toStepId = rcbToStep.selectedStep.name;
            qs.qTime = Convert.ToInt32(txtQTime.Text);
            qs.type = (qTimeType)cboQTimeType.SelectedItem;
            qs.action = (qTimeAction)cboAction.SelectedItem;
            qs.modifyUser = User.loginUser.name;
            qs.modifyDate = DateTime.Now;
        }

        private bool CheckInputData()
        {
            if (rcbFromStep.selectedStep == null)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", lblFromStep.Text),
                                                    idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else if (rcbToStep.selectedStep == null)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", lblToStep.Text),
                                                    idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else
            {
                int i = 0;
                if (!int.TryParse(txtQTime.Text, out i))
                {
                    standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", lblQTime.Text),
                                                        idv.mesCore.Controls.informationType.warn);
                    return false;
                }
            }
            return CheckInputData(cboProduct, lblProductId, cboRoute, lblRouteId, txtQTime, lblQTime, cboQTimeType, lblQTimeType, cboAction, lblAction);
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

        private void lvwQTime_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                currentItem = null;
                executeClear();
            }
            else
            {
                currentItem = item as qTimeSetting;
                cboProduct.Text = currentItem.productId;
                cboRoute.Text = currentItem.routeId;
                rcbFromStep.Text = currentItem.fromStepId;
                rcbToStep.Text = currentItem.toStepId;
                txtQTime.Text = currentItem.qTime.ToString();
                cboAction.Text = currentItem.action.ToString();
                cboQTimeType.SelectedItem = currentItem.type;
            }
        }

        private void txtQTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesRelease.PRP.Product prod = cboProduct.SelectedItem as mesRelease.PRP.Product;
            if (prod == null) return;
            prod.retrieveRoutes();
            cboRoute.Items.Clear();
            cboRoute.Items.AddRange(prod.Items.ToArray());
        }

        private void cboRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesRelease.PRP.Route route = cboRoute.SelectedItem as mesRelease.PRP.Route;
            if (route == null) return;
            route.retrieveNodes();
            rcbFromStep.Init(route, "");
        }

        private void rcbFromStep_MESStepSelectionChanged(mesRelease.PRP.Step step)
        {
            if (step == null)
                rcbToStep.Text = "";
            else
            {
                mesRelease.PRP.Route route = cboRoute.SelectedItem as mesRelease.PRP.Route;
                if (route == null) return;
                rcbToStep.Init(route, step.stepHandle);
            }
        }
    }
}
