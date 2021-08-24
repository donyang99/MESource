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
using WeifenLuo.WinFormsUI.Docking;
using mesRelease.WIP.Txn;
using idv.messageService.sql;

namespace ClientRule.AssemblyTrackOut
{
    public partial class frmMain : DockContent
    {
        Lot currentLot = null;
        mesRelease.PARM.StepParameter stepParm = null;
        bool haveNextRule = false;
        bool displayParameter = false;

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
        }

        void MESApplication_TextCommandInput(Control sender, string commandText)
        {
            if (sender.FindForm() != this) return;
            MessageBox.Show("InputTextCommand=" + commandText);
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            idv.messageService.serviceHost.AutoClientMultiTxnControl = true;//啟用自動控制多交易
            List<int> lstColWidth = new List<int>();
            lstColWidth.Add(40);//位置
            lstColWidth.Add(100);//物料類別
            lstColWidth.Add(100);//物料料號
            lstColWidth.Add(100);//物料批號

            if (WorkFlow.CurrentEquipment.trackCount > 1)
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


            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            //put the logic that run with matin thread here
            mesRelease.PRP.Step step = new mesRelease.PRP.Step(WorkFlow.CurrentStep);
            Text = WorkFlow.CurrentWorkingArea;
            txtEquipmentId.Text = WorkFlow.CurrentEquipment.name;
            txtState.Text = WorkFlow.CurrentEquipment.state;
            WorkFlow.MESItemUpdated += new MESItemNoticeEventHandler(WorkFlow_MESItemUpdated);//訂閱Server端MES物件更新事件通知
            idv.MESApplication.TextCommandInput += new idv.MESApplication.InputCommandEventHandler(MESApplication_TextCommandInput);
            mesRelease.MESApplication.MessagePanel = pnlDisplayMessage;
            btnTxnOK.Enabled = WorkFlow.CurrentEquipment.available;

            stepDC1.Init(step, idv.mesCore.PRP.DcItemTiming.TrackOut);
            stepDC1.MaximumSize = new System.Drawing.Size(1000, 125);
            //stepDC1.AutoSize(0);
            pnlStepDC.Visible = stepDC1.VisibleCount > 0;

            bool haveTrackInRule = false;//沒有TrackIn，才在TrackOut顯示生產參數
            foreach (mesRelease.PRP.Rule r in step.Items)
            {
                if (r.name.ToUpper().IndexOf("TRACKIN") >= 0)
                {
                    haveTrackInRule = true;
                    break;
                }
            }
            displayParameter = !haveTrackInRule && idv.mesCore.systemConfig.productParameter && idv.mesCore.systemConfig.validItem("confirmParameter");
            if (displayParameter)
                lvwParameter.prepareColumns();
            else
                pnlParameter.Visible = false;

            t.Join();
            ActiveControl = txtLotId;

            try
            {
                ruleExtension.Agent.Init(this, step, null, ruleExt_InputDataCompleted);
                ruleExtension.Agent.RuleStart(this, WorkFlow.CurrentFAB, step, WorkFlow.CurrentEquipment, RuleInstance.RuleName, stepDC1, null, null, pnlLeft, pnlRight, RuleInstance.Logger);
            }
            catch (Exception ex)
            {
                messageBox.showMessage(ex.Message);
                Close();
            }

            cultureLanguage.switchLanguageSync(this);

            if (displayParameter)
            {                
                lvwParameter.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwParameter.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                lvwParameter.Columns[2].Width = lvwParameter.Width - lvwParameter.Columns[0].Width - lvwParameter.Columns[0].Width - 20;
            }

            mesRelease.MESApplication.AddFreeButton(btnTxnOK, btnGetLot);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {   //取消Server端MES物件更新事件通知
            WorkFlow.MESItemUpdated -= new MESItemNoticeEventHandler(WorkFlow_MESItemUpdated);
            idv.MESApplication.TextCommandInput -= new idv.MESApplication.InputCommandEventHandler(MESApplication_TextCommandInput);
            ruleExtension.Agent.RuleEnd(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            if (idv.mesCore.systemConfig.materialTracking && WorkFlow.CurrentEquipment.SetupInfo != null)
                lvwSetupMaterial.ShowMESItems(WorkFlow.CurrentEquipment.SetupInfo.Items.ToArray());

            if (idv.mesCore.systemConfig.operatorPerformance)
                taWorkInformation1.Init(WorkFlow.CurrentStep, WorkFlow.CurrentEquipment.name);
            else
                pnlCurrWorkInfo.Visible = false;
        }

        void WorkFlow_MESItemUpdated(idv.messageService.itemBase mesItem, Type type)
        {   //機台有更新時
            if(type.Equals(typeof(Equipment)) && mesItem.name.Equals(txtEquipmentId.Text))
            {
                txtState.Text = WorkFlow.CurrentEquipment.state;
                btnTxnOK.Enabled = WorkFlow.CurrentEquipment.available;
                lvwSetupMaterial.RemoveAllMESItems();
                if (idv.mesCore.systemConfig.materialTracking && WorkFlow.CurrentEquipment.SetupInfo != null)
                    lvwSetupMaterial.ShowMESItems(WorkFlow.CurrentEquipment.SetupInfo.ToSortedList());
            }
        }

        void stepDC1_InputDataCompleted(object sender, EventArgs e)
        {
            if (!ruleExtension.Agent.SetFocus(this))
            {
                txtLotId.SelectAll();
                txtLotId.Focus();
            }
        }

        void ruleExt_InputDataCompleted(object sender, EventArgs e)
        {
            txtLotId.SelectAll();
            txtLotId.Focus();
        }  

        string lastInputLotId = "";
        private void txtLotId_BarcodeInput(object sender, string barcode)
        {
            //for連續刷2次，執行過帳
            if (txtLotId.Text.Equals(lastInputLotId))
                btnTxnOK.PerformClick();
            else
            {
                btnGetLot.PerformClick();
                if (currentLot != null)
                {
                    lastInputLotId = currentLot.name;
                    if (stepDC1.Visible)
                        stepDC1.Focus();
                    else if (!ruleExtension.Agent.SetFocus(this))
                        txtLotId.SelectAll();
                }
                else
                    lastInputLotId = "";
            }
        }

        private void btnGetLot_Click(object sender, EventArgs e)
        {
            if (idv.MESApplication.TriggerInputCommand(txtLotId, txtLotId.Text)) return;

            if (txtLotId.Text.Trim().Equals(""))
            {
                idv.MESApplication.PlayNGSound();
                messageBox.showMessageById("requireField2", messageStyle.error, lblLotId.Text);
                focusLotId();
                return;
            }
            Lot lot = Lot.GetLotByAny(txtLotId.Text);
            if (lot == null)
            {
                idv.MESApplication.PlayNGSound();
                messageBox.showMessageById("msgCantFindLot", messageStyle.error);
                focusLotId();
                return;
            }
            else if (!lot.equipmentId.Equals("") && !lot.equipmentId.Equals(txtEquipmentId.Text))
            {
                idv.MESApplication.PlayNGSound();
                messageBox.showMessageById("msgWrongInfo", messageStyle.error, "Equipment");
                focusLotId();
                return;
            }
            txtLotStatus.Text = lot.status;
            if (!ruleExtension.Agent.LotRetrieved(this, lot))//延伸功能檢查要在WorkFlow.RuleBegin前(有可能要補過帳到當前站點)
            {
                focusLotId();
                return;
            }
            if (!WorkFlow.RuleBegin(lot, RuleInstance.ClientRule, WorkFlow.CurrentStep))
            {
                focusLotId();
                return;
            }
            if (stepDC1.Count > 0)
            {
                stepDC1.Init(lot);
                stepDC1.ApplyValues(lot);

                if (stepDC1.AssignFromContains("Equipment"))
                    stepDC1.ApplyValues(WorkFlow.CurrentEquipment);
                if (stepDC1.AssignFromContains("WorkOrder"))
                    stepDC1.ApplyValues(GetOrder(lot.orderId));
                if (stepDC1.AssignFromContains("Step"))
                    stepDC1.ApplyValues(lot.GetCurrentStep());
            }

            currentLot = lot;
            
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(getLotAsynchronize));
            t.Start();

            mesRelease.PRP.Step curStep = currentLot.GetCurrentStep();
            int ruleSeq=curStep.GetRuleSeq(lot.ruleId);
            haveNextRule = curStep.Count > (ruleSeq + 1);
            //有下一個Rule且為「非自動執行」時，不顯示出帳類型
            bool displayTrackOutType = true;
            if (haveNextRule && !curStep.Item(ruleSeq + 1).dispatchFlag)
                displayTrackOutType = false;
            lblTrackOutType.Visible = displayTrackOutType;
            trackOutType1.Visible = displayTrackOutType;

            t.Join();
            if (displayParameter)
            {
                if (lvwParameter.Items.Count > 0)
                {
                    pnlParameter.Visible = true;
                    lvwParameter.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvwParameter.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lvwParameter.Columns[2].Width = lvwParameter.Width - lvwParameter.Columns[0].Width - lvwParameter.Columns[1].Width - 6;
                }
                else
                    pnlParameter.Visible = false;
            }
        }
        //非同步執行刷入序號後的動作
        void getLotAsynchronize()
        {
            if (idv.mesCore.systemConfig.productParameter)
            {
                stepParm = currentLot.GetCurrentStepParameter();
                if (displayParameter && stepParm != null && stepParm.Count > 0)
                    lvwParameter.ShowMESItems(stepParm.Items.ToArray());
            }
            trackOutType1.ShowTrackOutPath(currentLot);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;

            RuleInstance.logFunctionIn("btnOK_Click", "lotId", currentLot.name);
            List<sqlTable> lstTable = new List<sqlTable>();//額外要執行的SqlTable清單
            //generate txn object and assign correspond information
            TrackOut txn = new TrackOut();
            txn.equipmentId = txtEquipmentId.Text;
            txn.txnUser = User.loginUser.name;
            txn.taWorkInfo = taWorkInformation1.taWorkInfo;
            if (stepDC1.Count > 0)
                txn.dcItemList.AddRange(stepDC1.GetDCItems());

            if (judgePath.StartsWith("HOLD"))
                txn.result = judgePath;
            else
                txn.result = trackOutType1.TrackOutPath;

            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentLot);

            if (!ruleExtension.Agent.CheckBeforeTxn(this, txn, lstTable, null))
            {
                if (txn.result.Equals("TXNFINISH"))//在延伸邏輯裏已完成交易
                    finishAction();
                return;
            }

            txn.extraSQLTable.AddRange(lstTable);//sqlTables for step rule extension

            Cursor = Cursors.WaitCursor;
            //dotxn and get return value
            try
            {
                idv.messageService.serviceHost.StartClientMultiTxn();//開始多交易控制
                if (haveNextRule || judgePath.StartsWith("HOLD"))//有下一個rule時，下一個rule依lot.ruleResult DispatchLotToNext
                    txn.dispatchPath = "PASS";//指定完成交易後，立即執行WorkFlow.Dispatch邏輯，路徑名為PASS
                else
                    txn.dispatchPath = trackOutType1.TrackOutPath;
                
                txn = txn.doTxn();
            }
            catch { }            

            RuleInstance.logFunctionOut("btnOK_Click");
            //check txn result and do correspond action
            if (txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                if (haveNextRule || judgePath.StartsWith("HOLD"))//有下一個rule時，下一個rule依lot.ruleResult DispatchLotToNext
                    RuleInstance.RuleResult = "PASS";
                else
                    RuleInstance.RuleResult = trackOutType1.TrackOutPath;

                //WorkFlow.DispatchLotToNext(currentLot, RuleInstance.RuleResult);
                if (!WorkFlow.DispatchLotToNext(txn, RuleInstance.RuleResult)) //多交易控制會在WorkFlow執行完成後Commit多交易(WorkFlow.autoFinish=true時(WorkFlow.autoFinish預設=!idv.mesCore.systemConfig.assemblyMode))
                {                                                              //PS:多交易過程中，位何Txn交敗，系統自動回滾DB交易，同時結束多交易控制
                    idv.MESApplication.PlayNGSound();
                    messageBox.showMessage(WorkFlow.lastError, messageStyle.error);
                    RuleInstance.RuleResult = "CANCEL";
                    Cursor = Cursors.Default;
                    return;
                }
                
                idv.messageService.serviceHost.FinishClientMultiTxn(true);//完成多交易控制
                
                idv.MESApplication.PlayOKSound();
                outputInfo1.ShowMessage(txn);

                if (judgePath.StartsWith("HOLD"))
                    messageBox.showMessage("Lot " + currentLot.name + " " + cultureLanguage.getValue("wasHeld"));

                finishAction();
            }
            else
            {
                idv.MESApplication.PlayNGSound();
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
        }

        string judgePath = "";
        bool checkBeforeTxn()
        {   
            if(currentLot == null)
            {
                idv.MESApplication.PlayNGSound();
                messageBox.showMessageById("noItemSelected");
                return false;
            }

            if (stepDC1.Count > 0)
            {
                if (!stepDC1.ValidateInputValue(true, true)) return false;
                List<idv.messageService.itemBase> list = new List<idv.messageService.itemBase>();
                list.Add(currentLot);
                list.Add(WorkFlow.CurrentEquipment);
                if (stepDC1.CompareToContains("WorkOrder"))
                    list.Add(GetOrder(currentLot.orderId));
                if (stepDC1.CompareToContains("Step"))
                    list.Add(currentLot.GetCurrentStep());
                stepDC1.SetParameters(list);
            }

            judgePath = "";
            if (trackOutType1.TrackOutPath.Equals("PASS"))
            {
                if (!WorkFlow.TxnBegin(currentLot, stepDC1, ref judgePath))
                {
                    if (judgePath.Equals(""))
                        return false;
                    else if (trackOutType1.ContainPath(judgePath))
                    {
                        trackOutType1.TrackOutPath = judgePath;
                        idv.MESApplication.PlayNGSound();
                        messageBox.showMessageById("msgJudgeLotToStep", currentLot.GetNextStepId(judgePath));
                    }
                    else if (!judgePath.StartsWith("HOLD"))
                    {
                        idv.MESApplication.PlayNGSound();
                        messageBox.showMessageById("msgJudgePathNotExist", judgePath);
                        return false;
                    }
                }
            }

            if (trackOutType1.TrackOutPath.Equals(""))
            {
                idv.MESApplication.PlayNGSound();
                messageBox.showMessageById("msgPathNotSelected");
                return false;
            }
            return true;
        }

        void focusLotId()
        {
            ActiveControl = txtLotId;
            txtLotId.SelectAll();
        }

        //完成Lot交易後，清空畫面及變數
        void finishAction()
        {
            lastInputLotId = "";
            txtLotId.Text = "";
            txtLotStatus.Text = "";
            WorkFlow.CurrentLot = null;
            stepParm = null;
            currentLot = null;
            //currentOrder = null;
            stepDC1.ClearValues();
            if (lvwParameter.Visible) lvwParameter.RemoveAllMESItems();
            txtLotId.Focus();
            trackOutType1.TrackOutPath = "PASS";
            mesRelease.MESApplication.ClearMessage();
            ruleExtension.Agent.ActionAfterTxn(this, RuleInstance.RuleResult);
        }
    }
}
