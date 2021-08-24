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
using idv.messageService;

namespace ClientRule.TrackIn
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {                        
            currentLot = RuleInstance.GetItem(0);
            lvwEquipment.prepareColumns();
            lvwCarrier.prepareColumns();
            lvwParameter.prepareColumns();

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            lotInfomation1.Init(currentLot);
            t.Join();

            string eqpId = RuleInstance.GetParameter("equipmentId");
            if (!eqpId.Equals(""))
            {
                if (lvwEquipment.SelectMESItem(eqpId))
                    lvwEquipment.Enabled = false;
            }

            idv.utilities.cultureLanguage.switchLanguage(this);
        }
        void initAsynchronize()
        {
            try
            {
                lvwEquipment.ShowMESItems(Equipment.GetEquipmentsByStep(currentLot.fab, "", currentLot.stepId));
                lvwCarrier.ShowMESItems(currentLot.CarrierList.ToArray());
                if (idv.mesCore.systemConfig.productParameter && currentLot.specSysId != "" && currentLot.GetCurrentStepParameter() != null)
                    lvwParameter.ShowMESItems(currentLot.GetCurrentStepParameter().Items.ToArray());               
                workingInstruction1.ShowInstruction(currentLot);
            }
            catch { }
        }

        string TID = "";
        System.Threading.AutoResetEvent ar = new System.Threading.AutoResetEvent(false);
        volatile bool reply = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            mesRelease.WIP.Txn.TrackIn txn = new mesRelease.WIP.Txn.TrackIn();
            txn.txnUser = User.loginUser.name;
            txn.comments = reasonCode1.comments;
            txn.Equipment = lvwEquipment.selectedMESItem as Equipment;

            for (int i = 0; i < RuleInstance.ItemCount; i++)
            {
                txn.Add(RuleInstance.GetItem(i));
            }
            try
            {
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            if (txn.result == "PASS")
            {
                RuleInstance.RuleResult = "PASS";
                executeResult = "PASS";
                //Notice WIS EAP WISStartInfro
                lblInfo.ForeColor = Color.Blue;
                lblInfo.Text = cultureLanguage.getValue("waitingForEQReply");
                Refresh();

                reply = false;
                TID = DateTime.Now.ToBinary().ToString();
                serviceHost.MessageNotice += new MessageNoticeEventHandler(serviceHost_MessageNotice);

                for (int i = 0; i < RuleInstance.ItemCount; i++)
                {
                    mesRelease.WIS.WISStartInfo info = new mesRelease.WIS.WISStartInfo();
                    info.Lot = RuleInstance.GetItem(i);
                    info.EquipmentId = txn.Equipment.name;
                    info.ClientId = mesRelease.WF.WorkFlow.ClientId;
                    info.TID = TID;
                    info.To = "EAP:" + txn.Equipment.name;
                    info.send();
                }

                if (!reply)
                    ar.WaitOne(5000);
            }
            else
            {
                reply = true;
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            serviceHost.MessageNotice -= new MessageNoticeEventHandler(serviceHost_MessageNotice);
            if (reply)
                Close();
            else
            {
                btnOK.Enabled = false;
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = cultureLanguage.getValue("waitingForEQReplyFail");
            }
        }

        string executeResult = "";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (executeResult == "")
                RuleInstance.RuleResult = "CANCEL";
            else
                RuleInstance.RuleResult = executeResult;
            Close();
        }

        bool checkBeforeTxn()
        {
            if (lvwEquipment.selectedMESItem == null)
            {
                messageBox.showMessageById("msgNoItemSelected", cultureLanguage.getValue("Equipment"));
                return false;
            }
            else
            {
                Equipment eq = lvwEquipment.selectedMESItem as Equipment;
                if (!eq.available)
                {
                    messageBox.showMessageById("msgEqNotAvailable");
                    return false;
                }
                else if (eq.capacity == eq.capacityUsed)
                {
                    messageBox.showMessageById("msgEqCapacityNotEnough");
                    return false;
                }
                else if (idv.mesCore.systemConfig.productParameter && currentLot.specSysId != "" && currentLot.GetCurrentStepParameter() != null)
                {
                    //check eq recipe
                    mesRelease.PARM.EqRecipe er = currentLot.GetCurrentStepParameter().GetEqRecipe(eq.type);
                    if (er != null && er.recipe != eq.recipe)
                    {
                        messageBox.showMessageById("msgWrongRecipe", eq.recipe, er.recipe);
                        return false;
                    }

                    //check consume material
                    if (eq.SetupInfo != null)
                    {
                        foreach (SetupMaterial material in eq.SetupInfo.Items)
                        {
                            mesRelease.PARM.SpecMaterial specMaterial = currentLot.GetCurrentStepParameter().GetMaterialType(material.name);
                            if (specMaterial == null || specMaterial.Count == 0) continue;
                            if (!specMaterial.usePartNo(material.partNo))
                            {
                                messageBox.showMessageById("msgWrongEqSetupMaterial", material.partNo, string.Join(",", specMaterial.partNOs));
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        void serviceHost_MessageNotice(messageBase item)
        {
            if (item is mesRelease.WIS.WISStartInfo)
            {
                if ((item as mesRelease.WIS.WISStartInfo).TID == TID)
                {
                    reply = true;
                    ar.Set();
                }
            }
        }
    }
}
