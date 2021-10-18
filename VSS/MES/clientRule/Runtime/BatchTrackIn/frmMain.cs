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
using mesRelease.WF;
using idv.utilities;
using idv.mesCore.EQP;
using idv.messageService.sql;
using mesRelease.PRP;

namespace ClientRule.TrackIn
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        mesRelease.PARM.StepParameter stepParm = null;

        WorkOrder currentOrder = null;
        WorkOrder GetOrder(string orderId)
        {
            if (currentOrder == null || !currentOrder.name.Equals(orderId))
                currentOrder = new WorkOrder(orderId);
            return currentOrder;
        }

        public frmMain()
        {
            InitializeComponent();
            stepDC1.InputDataCompleted += new EventHandler(stepDC1_InputDataCompleted);
            Activated += new EventHandler(frmMain_Activated);
        }

        bool firstActive = true;
        void frmMain_Activated(object sender, EventArgs e)
        {
            if (firstActive)
            {
                firstActive = false;
                if (ruleExtension.Agent.SetFocus(this))
                    return;
                if (stepDC1.Visible)
                    stepDC1.Focus();
                else
                    reasonCode1.Focus();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {                        
            currentLot = RuleInstance.GetItem(0);
            Step step = currentLot.GetCurrentStep();
            lvwEquipment.prepareColumns();           
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            string columnNames = "name,status,quantity,unit,stepId,routeId,productId,ruleId,lotType,carrierId," +
                     "equipmentId,orderId,fab,specId,customerId,modifyUser,modifyDate";
            lvwLots.columnNames = columnNames.Split(',');
            columnNames = "lotId,status,quantity,unit,stepId,routeId,productId,ruleId,lotType,carrierId," +
                          "equipmentId,orderId,fab,specId,customerId,modifyUser,modifyDate";
            lvwLots.columnTags = columnNames.Split(',');
            lvwLots.prepareColumns();

            lvwLots.ShowMESItems(Lot.GetLots("step_id", currentLot.stepId, "rule_id", currentLot.ruleId));

            lvwLots.SelectMESItem(currentLot);

            stepDC1.Init(step, idv.mesCore.PRP.DcItemTiming.TrackIn);
            stepDC1.MaximumSize = new System.Drawing.Size(1000, 125);
            pnlStepDC.Visible = stepDC1.VisibleCount > 0;
            if (stepDC1.Count > 0)
            {
                stepDC1.Init(currentLot);
                stepDC1.ApplyValues(currentLot);
                if (stepDC1.AssignFromContains("WorkOrder"))
                    stepDC1.ApplyValues(GetOrder(currentLot.orderId));
                if (stepDC1.AssignFromContains("Step"))
                    stepDC1.ApplyValues(currentLot.GetCurrentStep());
            }
            t.Join();
            
            string eqpId = RuleInstance.GetParameter("equipmentId");
            if (!eqpId.Equals(""))
            {
                if (lvwEquipment.SelectMESItem(eqpId))
                    lvwEquipment.Enabled = false;
            }

            try
            {
                ruleExtension.Agent.Init(this, step, null, ruleExt_InputDataCompleted);
                ruleExtension.Agent.RuleStart(this, WorkFlow.CurrentFAB, step, WorkFlow.CurrentEquipment, RuleInstance.RuleName, stepDC1, null, null, pnlLeft, pnlRight, RuleInstance.Logger);
                if (!ruleExtension.Agent.LotRetrieved(this, currentLot))
                {
                    btnOK.Enabled = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.Message);
                btnOK.Enabled = false;
                return;
            }

            if (pnlLeft.Controls.Count == 0 && pnlRight.Controls.Count == 0)
                pnlCustomize.Visible = false;
            else
                pnlRight.Visible = pnlRight.Controls.Count != 0;

            if (lvwParameter.Items.Count == 0) pnlParameter.Visible = false;
            cultureLanguage.switchLanguage(this);
            
            if (lvwParameter.Visible)
            {
                lvwParameter.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwParameter.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvwParameter.Columns[2].Width = lvwParameter.Width - lvwParameter.Columns[0].Width - lvwParameter.Columns[1].Width - 6;
            }
        }
        void initAsynchronize()
        {
            try
            {
                lvwEquipment.ShowMESItems(Equipment.GetEquipmentsByStep(currentLot.fab, "", currentLot.stepId, true));              
                prepareMaterialList(lvwEquipment.Items[0].Tag as Equipment);
                if (idv.mesCore.systemConfig.productParameter)
                {
                    stepParm = currentLot.GetCurrentStepParameter();
                    if (stepParm != null && stepParm.Count > 0 && idv.mesCore.systemConfig.validItem("confirmParameter"))
                    {
                        lvwParameter.prepareColumns();
                        lvwParameter.ShowMESItems(stepParm.Items.ToArray());
                    }
                }
                
                workingInstruction1.ShowInstruction(currentLot);
            }
            catch { }
        }
        void prepareMaterialList(Equipment eqp)
        {
            List<int> lstColWidth = new List<int>();
            lstColWidth.Add(40);//位置
            lstColWidth.Add(100);//物料類別
            lstColWidth.Add(100);//物料料號
            lstColWidth.Add(100);//物料批號

            if (eqp !=null && eqp.trackCount > 1)
            {
                lvwSetupMaterial.columnNames = "position,name,partNo,materialLotId".Split(new char[] { ',' });
                lvwSetupMaterial.columnTags = "position,materialType,materialPartNo,materialLotId".Split(new char[] { ',' });
            }
            else
            {
                lvwSetupMaterial.columnNames = "name,partNo,materialLotId".Split(new char[] { ',' });
                lvwSetupMaterial.columnTags = "materialType,materialPartNo,materialLotId".Split(new char[] { ',' });
                lstColWidth.RemoveAt(0);
            }
            lvwSetupMaterial.prepareColumns();
            for (int i = 0; i < lvwSetupMaterial.Columns.Count; i++)
                lvwSetupMaterial.Columns[i].Width = lstColWidth[i];
        }

        void ruleExt_InputDataCompleted(object sender, EventArgs e)
        {
            if (stepDC1.Visible)
                stepDC1.Focus();
            else
                reasonCode1.Focus();
        }

        void stepDC1_InputDataCompleted(object sender, EventArgs e)
        {
            reasonCode1.Focus();
        }

        private void lvwEquipment_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            Equipment eq = item as Equipment;
            lvwSetupMaterial.RemoveAllMESItems();
            if (idv.mesCore.systemConfig.materialTracking && eq.SetupInfo != null)
                lvwSetupMaterial.ShowMESItems(eq.SetupInfo.ToSortedList());
            if (stepDC1.Count > 0)
            {
                if (stepDC1.AssignFromContains("Equipment"))
                    stepDC1.ApplyValues(eq);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");

            List<sqlTable> lstTable = new List<sqlTable>();//額外要執行的SqlTable清單
            mesRelease.WIP.Txn.TrackIn txn = new mesRelease.WIP.Txn.TrackIn();
            txn.txnUser = User.loginUser.name;
            txn.comments = reasonCode1.comments;
            txn.Equipment = lvwEquipment.selectedMESItem as Equipment;
            txn.changeEqCapacity = true;
            txn.result = "PASS";
            if (stepDC1.Count > 0)
                txn.dcItemList.AddRange(stepDC1.GetDCItems());

            foreach (Lot lot in lvwLots.selectedMESItems)
                txn.Add(lot);


            if (!ruleExtension.Agent.CheckBeforeTxn(this, txn, lstTable, null))
            {
                if (txn.result.Equals("TXNFINISH"))//在延伸邏輯裏已完成交易
                    Close();
                return;
            }
            txn.extraSQLTable.AddRange(lstTable);//sqlTables for step rule extension
            txn.dispatchPath = "PASS";//交易和帳流一起執行

            try
            {
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            if (txn.result.Equals("PASS"))
            {
                RuleInstance.RuleResult = "N/A";//交易和帳流一起執行時，回傳N/A
            }
            else
            {
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            ruleExtension.Agent.ActionAfterTxn(this, RuleInstance.RuleResult);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        bool checkBeforeTxn()
        {
            Equipment selEqp = lvwEquipment.selectedMESItem as Equipment;
            if (chkConfirmParameter.Visible && !chkConfirmParameter.Checked)
            {
                messageBox.showMessageById("msgConfirmParameter");
                return false;
            }
            if (selEqp == null)
            {
                messageBox.showMessageById("msgNoItemSelected", cultureLanguage.getValue("Equipment"));
                return false;
            }
            else
            {
                if (!selEqp.available)
                {
                    messageBox.showMessageById("msgEqNotAvailable");
                    return false;
                }
                else if (selEqp.capacity == selEqp.capacityUsed)
                {
                    messageBox.showMessageById("msgEqCapacityNotEnough");
                    return false;
                }
                else if (!selEqp.reservedBy.Trim().Equals("") && !selEqp.reservedBy.Equals(currentLot.orderId))
                {
                    messageBox.showMessageById("msgWrongOrder", selEqp.reservedBy);
                    return false;
                }

                string judgePath = null;

                if (stepDC1.Count > 0)
                {
                    if (!stepDC1.ValidateInputValue(true, true)) return false;
                    List<idv.messageService.itemBase> list = new List<idv.messageService.itemBase>();
                    list.Add(currentLot);
                    list.Add(selEqp);
                    if (stepDC1.CompareToContains("WorkOrder"))
                        list.Add(GetOrder(currentLot.orderId));
                    if (stepDC1.CompareToContains("Step"))
                        list.Add(currentLot.GetCurrentStep());
                    stepDC1.SetParameters(list);
                }
                if (!WorkFlow.TxnBegin(currentLot, selEqp, stepDC1, ref judgePath))
                    return false;
            }

            return true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ruleExtension.Agent.RuleEnd(this);
        }
    }
}
