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
using mesRelease.PARM;
using idv.utilities;

namespace ClientRule.EqSetupTooling
{
    public partial class frmMain : Form
    {
        WorkOrder currentOrder = null;
        StepParameter currentStepParameter = null;
        Equipment currentEqp = null;
        bool isToolingSettingReady = false;

        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            currentEqp = RuleInstance.GetItem(0);
            lvwSetupTooling.prepareColumns();
            lvwSetupTooling.Columns[0].Width = 100;
            lvwSetupTooling.Columns[1].Width = 100;
            lvwSetupTooling.Columns[2].Width = 150;
            equipmentInformation1.Init(currentEqp);
            if (currentEqp != null)
            {
                currentEqp.Refresh(true);
                showCurrentEqpInfo();
                clearInputValues();
                showUsedSteps();
                if (cboStepId.Items.Count > 1)
                    ActiveControl = cboStepId;
                else
                    ActiveControl = cboOrderId;
            }

            if (!idv.mesCore.systemConfig.productParameter)
            {
                tblTarget.Visible = false;
                lblTarget.Visible = false;
                splitContainer2.Panel1Collapsed = true;
                ActiveControl = txtToolingId;
            }

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        private void equipmentInformation1_EquipmentChanged(Equipment equipment, ref bool accept)
        {
            if (equipment == null)
            {
                equipmentInformation1.Init(currentEqp);
                accept = false;
                return; 
            }
            if (currentEqp != null && !equipment.name.Equals(currentEqp.name))
            {
                if (!messageBox.showMessageById("msgSelectOthers", messageStyle.askYesNo))
                {
                    equipmentInformation1.Init(currentEqp);
                    accept = false;
                    return;
                }
            }
            clearInputValues();  
            currentEqp = equipment;
            showCurrentEqpInfo();                      

            showUsedSteps();
            if (cboStepId.Items.Count > 1)
                cboStepId.Focus();
            else
                cboOrderId.Focus();
        }

        void showUsedSteps()
        {
            cboStepId.Items.Clear();
            cboStepId.Items.AddRange(currentEqp.GetUsedbySteps());
            if (cboStepId.Items.Count == 1)
            {
                cboStepId.SelectedIndex = 0;
                cboStepId.Enabled = false;
            }
            else
                cboStepId.Enabled = true;
        }
        void showCurrentEqpInfo()
        {
            showSettingToolings();
            Type tToolingId = Type.GetType("mesRelease.TOL.ToolingId, toolingRelease");
            object returnValue = tToolingId.BaseType.InvokeMember("GetToolings", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                    System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { "", "", currentEqp.name, "", false });

            idv.messageService.itemBase[] toolingIds = returnValue as idv.messageService.itemBase[];
            if (toolingIds.Length > 0)
            {
                foreach (idv.messageService.itemBase tol in toolingIds)
                {
                    if (lvwSetupTooling.Items.ContainsKey(tol.getPropertyInString("toolingType")))
                        tol.sysid = tol.getPropertyInString("toolingType");
                    else
                        tol.sysid = tol.getPropertyInString("toolingType") + "--";//不存在於設定裏需要架機的治工具類型   
                    lvwSetupTooling.UpdateMESItem(tol);
                }
                
                if (isToolingSettingReady)
                {
                    foreach (ListViewItem item in lvwSetupTooling.Items)
                    {
                        if (item.Name.EndsWith("--"))
                        {
                            item.Checked = true;
                            item.ForeColor = Color.Red;
                            item.UseItemStyleForSubItems = true;
                        }
                    }
                }
            }
            txtToolingId.Focus();
        }
        
        //依設定顯示機台可上物料資訊
        void showSettingToolings()
        {
            if (isToolingSettingReady)
            {
                lvwSetupTooling.UnCheckAllItems();
                foreach (idv.messageService.itemBase  tol in lvwSetupTooling.GetAllMESItem())
                {
                    if (tol.sysid.Equals(tol.getPropertyInString("toolingType")))
                    {
                        tol.name = "";
                        tol.setProperty("partNo", "");                        
                        lvwSetupTooling.UpdateMESItem(tol);
                    }
                    else
                    {
                        lvwSetupTooling.RemoveMESItem(tol);
                    }
                }
                return;
            }

            lvwSetupTooling.RemoveAllMESItems();
            if (idv.mesCore.systemConfig.productParameter && currentStepParameter == null) return;
            isToolingSettingReady = true;
            if (idv.mesCore.systemConfig.productParameter)
            {
                Type tTolId = Type.GetType("mesRelease.TOL.ToolingId, toolingRelease");
                foreach (EqTooling eqTool in currentStepParameter.GetEqToolings(currentEqp.type))
                {
                    idv.messageService.itemBase tol = Activator.CreateInstance(tTolId) as idv.messageService.itemBase;
                    tol.sysid = eqTool.toolingType;
                    tol.setProperty("toolingType", eqTool.toolingType);
                    lvwSetupTooling.UpdateMESItem(tol);
                }
            }
            else
            {
                Type tTolType = Type.GetType("mesRelease.TOL.ToolingType, toolingRelease");
                object returnValue = tTolType.BaseType.BaseType.InvokeMember("GetToolingTypeNameByEqType", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                        System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { currentEqp.type });

                string[] toolingTypes = returnValue as string[];
                Type tTolId = Type.GetType("mesRelease.TOL.ToolingId, toolingRelease");
                foreach (string type in toolingTypes)
                {
                    idv.messageService.itemBase tol = Activator.CreateInstance(tTolId) as idv.messageService.itemBase;
                    tol.sysid = type;
                    tol.setProperty("toolingType", type);
                    lvwSetupTooling.UpdateMESItem(tol);
                }
            }
            lvwSetupTooling.SelectedItems.Clear();
        }
        void clearInputValues()
        {
            txtToolingId.Text = "";
            txtToolingPart.Text = "";
            txtToolingType.Text = "";
            isToolingSettingReady = false;
            btnClearOrder.PerformClick();            
        }

        private void cboStepId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOrderId.Focus();
        }

        private void cboOrderId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnConfirmOrder.PerformClick();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (currentEqp == null)
            {
                idv.utilities.messageBox.showMessageById("msgPlsSelectItem", cultureLanguage.getValue("Equipment"));
                return;
            }
            if (cboOrderId.Text.Trim().Equals("")) return;
            if (cboStepId.Text.Equals(""))
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblStepId.Text);
                return;
            }
            WorkOrder order = new WorkOrder(cboOrderId.Text);
            if (order.sysid.Equals(""))
            {
                idv.utilities.messageBox.showMessageById("msgWrongInfo", lblOrderId.Text);
                return;
            }
            currentOrder = order;

            if (idv.mesCore.systemConfig.productParameter)
            {
                if (!currentOrder.specSysId.Equals(""))
                    currentStepParameter = StepParameter.GetSpecStep(currentOrder.specSysId, cboStepId.Text);
                else
                    currentStepParameter = StepParameter.GetActiveSpecStep(currentOrder.specId, cboStepId.Text);

                if (currentStepParameter != null)
                {
                    currentStepParameter.RetrieveSpecInformation();
                    showCurrentEqpInfo();
                }
            }

            cboStepId.Enabled = false;
            cboOrderId.Enabled = false;
            btnConfirmOrder.Enabled = false;
            btnClearOrder.Enabled = true;
        }
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            cboOrderId.Text = "";
            currentOrder = null;
            currentStepParameter = null;

            cboStepId.Enabled = cboStepId.Items.Count > 1;
            cboOrderId.Enabled = true;
            btnConfirmOrder.Enabled = true;
            btnClearOrder.Enabled = false;
            isToolingSettingReady = false;
        }

        private void txtToolingId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !txtToolingId.Text.Equals(""))
                btnAddTooling.PerformClick();
        }

        public bool checkToolingInput()
        {
            if (idv.mesCore.systemConfig.productParameter && currentOrder == null)
            {
                messageBox.showMessageById("msgPlsSelectItem", lblOrderId.Text);
                cboOrderId.Focus();
                return false;
            }
            if (txtToolingId.Text.Trim().Equals(""))
            {
                messageBox.showMessageById("requireField2", lblToolingId.Text);
                txtToolingId.Focus();
                return false;
            }
            return true;
        }
        private void btnAddTooling_Click(object sender, EventArgs e)
        {
            standardStatusbar1.setInformation("");
            if (!checkToolingInput()) return;
            Type tTolId = Type.GetType("mesRelease.TOL.ToolingId, toolingRelease");
            object returnValue = tTolId.BaseType.InvokeMember("GetToolings", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                        System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { new string[] { txtToolingId.Text } });

            idv.messageService.itemBase[] tolIds = returnValue as idv.messageService.itemBase[];
            if (tolIds.Length == 0)
            {
                txtToolingId.SelectAll();
                txtToolingId.Focus();
                messageBox.showMessageById("msgCantFindLot2", lblToolingId.Text);
                return;
            }
            idv.messageService.itemBase tolId = tolIds[0];

            if (!lvwSetupTooling.Items.ContainsKey(tolId.getPropertyInString("toolingType")))//當前機台需要的治工具類型
            {
                txtToolingId.SelectAll();
                txtToolingId.Focus();
                messageBox.showMessageById("msgMakesureInformation", lblToolingType.Text);
                return;
            }
            else if (!lvwSetupTooling.Items[tolId.getPropertyInString("toolingType")].SubItems[1].Text.Trim().Equals(""))
            {
                txtToolingId.SelectAll();
                txtToolingId.Focus();
                messageBox.showMessageById("msgEqToolingExist", tolId.getPropertyInString("toolingType"));
                return;
            }

            if (!tolId.getPropertyInString("status").Equals("SETUP"))//狀態必須為SETUP才可以
            {
                txtToolingId.SelectAll();
                txtToolingId.Focus();
                messageBox.showMessageById("msgMakesureInformation", lblToolingId.Text + cultureLanguage.getValue("status"));
                return;
            }
            txtToolingPart.Text = tolId.getPropertyInString("partNo");
            txtToolingType.Text = tolId.getPropertyInString("toolingType");
            if (currentStepParameter != null && !currentStepParameter.CheckTooling(currentEqp.type, txtToolingType.Text, txtToolingPart.Text))
            {
                txtToolingId.SelectAll();
                txtToolingId.Focus();
                messageBox.showMessageById("msgMakesureInformation", lblToolingPart.Text);
                return;
            }

            tolId.sysid = txtToolingType.Text;
            if (AddTooling(tolId))
            {
                txtToolingId.Text = "";
                txtToolingPart.Text = "";
                txtToolingType.Text = "";
                currentEqp.Refresh();
            }
            showCurrentEqpInfo();
            equipmentInformation1.Init(currentEqp);
        }

        private bool AddTooling(idv.messageService.itemBase tooling)
        {            
            List<object> lstArgu = new List<object>();
            List<string> lstTooling = new List<string>();
            Type tTxnEvent = Type.GetType("mesRelease.TOL.Txn.TxnEvent, toolingRelease");

            lstTooling.Add(tooling.name);
            lstArgu.Add(currentEqp.name);
            lstArgu.Add("");//comment
            lstArgu.Add(User.loginUserId);
            lstArgu.Add(null);//sqlTable List
            lstArgu.Add(idv.messageService.TransactionActor.First);
            lstArgu.Add(lstTooling.ToArray());
            try
            {
                idv.messageService.txnBase txn = tTxnEvent.BaseType.InvokeMember("HWSetup", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                                                 System.Reflection.BindingFlags.InvokeMethod, null, null, lstArgu.ToArray()) as idv.messageService.txnBase;

                LogEqHistory("SetupTooling", tooling.name, "-");

                RuleInstance.RuleResult = "PASS";
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
                return true;
            }
            catch(Exception ex)
            {
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(ex.ToString(), messageStyle.error);       
                return false;
            }
        }
        private bool RemoveTooling(idv.messageService.itemBase[] tooling)
        {
            List<object> lstArgu = new List<object>();
            List<string> lstTooling = new List<string>();
            Type tTxnEvent = Type.GetType("mesRelease.TOL.Txn.TxnEvent, toolingRelease");
            foreach (idv.messageService.itemBase tool in tooling)
                lstTooling.Add(tool.name);
            lstArgu.Add("");//comment
            lstArgu.Add(User.loginUserId);
            lstArgu.Add(null);//sqlTable List
            lstArgu.Add(idv.messageService.TransactionActor.First);
            lstArgu.Add(lstTooling.ToArray());
            try
            {
                idv.messageService.txnBase txn = tTxnEvent.BaseType.InvokeMember("UnLoad", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                                                 System.Reflection.BindingFlags.InvokeMethod, null, null, lstArgu.ToArray()) as idv.messageService.txnBase;

                Dictionary<string, int> EqToolingCount = txn.getProperty("EqToolingCount") as Dictionary<string, int>;
                string tolSetupInf = "";
                if (EqToolingCount.ContainsKey(currentEqp.name) && EqToolingCount[currentEqp.name] > 0)
                    tolSetupInf = "-";
                string tolIds = string.Join(",", lstTooling);
                if (tolIds.Length > 255) tolIds = tolIds.Substring(0, 255);

                LogEqHistory("UnloadTooling", tolIds, tolSetupInf);

                RuleInstance.RuleResult = "PASS";
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
                return true;
            }
            catch (Exception ex)
            {
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(ex.ToString(), messageStyle.error);
                return false;
            }
        }

        private void LogEqHistory(string activity, string toolingId, string tolSetupInfo)
        {
            currentEqp.toolingSetupInfo = tolSetupInfo;
            mesRelease.EQP.Txn.EqLogHistory txn = new mesRelease.EQP.Txn.EqLogHistory();
            txn.name = activity;
            txn.txnUser = mesRelease.USR.User.loginUserId;
            txn.Add(currentEqp);
            txn.txnActor = idv.messageService.TransactionActor.Last;
            if (toolingId != null && !toolingId.Equals(""))
                txn.comments = toolingId;
            try
            {
                txn = txn.doTxn();
            }
            catch (Exception ex)
            {
                txn.errMessage = ex.ToString();
            }
            if (!txn.result.Equals("PASS"))
                throw new Exception(txn.errMessage);
        }

        private void btnDelTooling_Click(object sender, EventArgs e)
        {
            standardStatusbar1.setInformation("");
            if (lvwSetupTooling.selectedMESItems.Length == 0) return;
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo)) return;

            if (RemoveTooling(lvwSetupTooling.selectedMESItems))
            {
                currentEqp.Refresh();
            }
            showCurrentEqpInfo();
            equipmentInformation1.Init(currentEqp);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!idv.utilities.messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            Close();
        }

        private void lvwSetupTooling_MESItemCheckChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected, ref bool Cancel)
        {
            if (selected)
            {
                if (item == null || item.name.Equals(""))
                    Cancel = true;
            }
        }
    }
}
