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

namespace ClientRule.ScrapLot
{
    public partial class frmMain : Form
    {
        Lot currentLot = null;
        Lot currentChild = null;
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            currentLot = RuleInstance.GetItem(0);

            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();
            lotInfomation1.Init(currentLot);

            lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);

            layoutForm();
            InitParentLot();
            InitChildLot();
            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        void lotInfomation1_LotChanged(Lot lot, ref bool accept)
        {
            if(!lot.IsWIPStatus())
            {
                idv.utilities.messageBox.showMessageById("msgStatusInvalid");
                accept = false;
            }
            else
            {
                currentLot = lot;
                initAsynchronize();
                InitParentLot();
                InitChildLot();
                accept = true;
            }
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                reasonCode1.Init("Scrap", currentLot.stepId);
            }
            catch { }
        }

        void layoutForm()
        {
            compParentComponent.prepare();
            compChildComponent.prepare();
            carParentCarrier.prepare();
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    carParentCarrier.Visible = false;
                    compParentComponent.Dock = DockStyle.Fill;
                    compChildComponent.Dock = DockStyle.Fill;
                }
                else
                {
                    tblParentCarrier.Hide();
                    tblChildCarrier.Hide();
                    compParentComponent.Visible = false;
                    compChildComponent.Visible = false;
                    btnUnSelect.Hide();
                    carParentCarrier.Dock = DockStyle.Fill;
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                tblParentCarrier.Hide();
                tblChildCarrier.Hide();
                carParentCarrier.Visible = false;
                compParentComponent.Dock = DockStyle.Fill;
                compChildComponent.Dock = DockStyle.Fill;
            }
            else
            {
                pnlParent.Hide();
                tblMove.Hide();
                compChildComponent.Hide();
                tblChildCarrier.Hide();
                lblChild.Hide();
                tblInputData.ColumnStyles[0].Width = 0;
                tblInputData.ColumnStyles[1].Width = 0;
                txtScrapQuantity.ReadOnly = false;
                txtScrapQuantity.BackColor = SystemColors.Info;
                Width = 560;
                Height = 402;
                splitContainer1.SplitterDistance = 224;
                splitContainer2.SplitterDistance = 124;
            }
        }

        mesRelease.WIP.Txn.SplitLot splitScrapLot()
        {
            mesRelease.WIP.Txn.SplitLot txn = new mesRelease.WIP.Txn.SplitLot();
            txn.txnActor = idv.messageService.TransactionActor.First;
            txn.txnUser = User.loginUser.name;

            txn.Add(currentLot);

            mesRelease.WIP.Txn.SplitLotInfo splitInfo = new mesRelease.WIP.Txn.SplitLotInfo();
            currentChild.name = Lot.NextChildLotId(currentLot);
            splitInfo.childLotId = currentChild.name;
            splitInfo.quantity = currentChild.quantity;
            splitInfo.componentInfo = currentChild.ComponentInfo;
            txn.splitInfo.Add(splitInfo);

            try
            {
                txn.name = "SplitForScrap";
                txn.allowStatusRUN = true;
                txn = txn.doTxn();
            }
            catch { }

            return txn;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.WIP.Txn.ScrapLot txn = new mesRelease.WIP.Txn.ScrapLot();
            txn.txnUser = User.loginUser.name;
            txn.reasonCode = reasonCode1.reasonCode;
            txn.comments = reasonCode1.comments;

            Lot scrapLot = null;
            if (currentChild.quantity == 0 || currentChild.quantity == currentLot.quantity)//整批報廢
                scrapLot = currentLot;
            else
            {
                mesRelease.WIP.Txn.SplitLot splitTxn = splitScrapLot();
                if (splitTxn.result != "PASS")//retry, for ScrapLotId也許剛好被其它批號分批時使用了
                    splitTxn = splitScrapLot();

                if (splitTxn.result != "PASS")
                {
                    RuleInstance.RuleResult = "CANCEL";
                    Cursor = Cursors.Default;
                    messageBox.showMessage(splitTxn.errMessage, messageStyle.error);
                    return;
                }

                txn.publishTxn.Add(splitTxn);
                scrapLot = splitTxn.Item(currentChild.name);//取得分批後的子批
                txn.txnActor = idv.messageService.TransactionActor.Last;
                txn.mainTxnSysId = splitTxn.mainTxnSysId;
                txn.allowStatusRUN = true;
            }

            //add protagonist to txn item collcation by txn.add method
            txn.Add(scrapLot);
            
            //dotxn and get return value
            try
            {              
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            //check txn result and do correspond action
            if(txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                RuleInstance.RuleResult = "PASS";
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;

            lotInfomation1.ShowLot(null);
            currentLot = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            double qty = 0;
            double.TryParse(txtScrapQuantity.Text, out qty);
            if(currentChild.CarrierList.Count > 0 || qty > 0 ||
                (currentChild.ComponentInfo != null && currentChild.ComponentInfo.Count > 0))
            {
                if(!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if(currentLot == null)
            {
                idv.utilities.messageBox.showMessageById("noItemSelected");
                return false;
            }
            else if(reasonCode1.reasonCode.Equals(""))
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", "&ReasonCode")
                                                          , idv.mesCore.Controls.informationType.warn);
                return false;
            }
            double scrapQty = 0;
            double.TryParse(txtScrapQuantity.Text, out scrapQty);
            if (scrapQty > currentLot.quantity)
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&quantity")
                                                              , idv.mesCore.Controls.informationType.warn);
                return false;
            }
            currentChild.quantity = scrapQty;

            if (idv.mesCore.systemConfig.componentInfo)
            {
                compParentComponent.Confirm();
                compChildComponent.Confirm();
            }
            else if (idv.mesCore.systemConfig.carrierManagement)
            {
                int carQty = 0;
                foreach(mesRelease.CAR.Carrier car in currentLot.CarrierList)
                    carQty+=car.componentQty;
                if (carQty + scrapQty != Math.Ceiling(currentLot.quantity))
                {
                    standardStatusbar1.setInformation(cultureLanguage.getValue("msgMakesureInformation", "&carrier")
                                  , idv.mesCore.Controls.informationType.warn);
                    return false;
                }
            }

            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text))
                return false;
            return true;
        }

        void InitParentLot()
        {
            cboParentCarrier.Items.Clear();
            compParentComponent.Clear();
            if(currentLot == null) return;
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    cboParentCarrier.Items.Add("");
                    cboParentCarrier.Items.AddRange(currentLot.CarrierList.ToArray());
                    if (cboParentCarrier.Items.Count == 2)
                        cboParentCarrier.SelectedIndex = 1;
                }
                else
                {
                    carParentCarrier.ShowCarriers(currentLot.CarrierList, null);
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                compParentComponent.ShowComponents(currentLot.ComponentInfo);
            }
            txtScrapQuantity.MaxLength = ((int)currentLot.quantity).ToString().Length + 2;
        }
        void InitChildLot()
        {
            currentChild = new Lot();
            compChildComponent.Clear();
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    currentChild.ComponentInfo = new ComponentInfo();
                    compChildComponent.ShowComponents(currentChild.ComponentInfo);
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                currentChild.ComponentInfo = new ComponentInfo();
                compChildComponent.ShowComponents(currentChild.ComponentInfo);
            }
        }

        private void cboParentCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            compParentComponent.Confirm();
            compParentComponent.Clear();
            mesRelease.CAR.Carrier car = cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier;
            compParentComponent.ShowComponents(currentLot.ComponentInfo, car);
        }

        private void btnMoveCarrier_Click(object sender, EventArgs e)
        {
            btnSelectAll.PerformClick();
            //mesRelease.CAR.Carrier carrier = cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier;
            //if (carrier == null) return;
            //WipComponent[] comps = compParentComponent.RemoveComponentByCarrier(carrier.name);
            //if (comps.Length == 0) return;
            //cboParentCarrier.Items.Remove(carrier);
            //currentLot.CarrierList.Remove(carrier);
            //if (cboParentCarrier.Items.Count == 2)
            //    cboParentCarrier.SelectedIndex = 1;
            //else
            //    cboParentCarrier.SelectedIndex = -1;

            //foreach (WipComponent comp in comps)
            //    currentChild.ComponentInfo.Add(comp);

            //showScrapQuantity();
        }

        void showScrapQuantity()
        {
            if (idv.mesCore.systemConfig.carrierManagement)
            {
                if (idv.mesCore.systemConfig.componentInfo)
                {
                    double qty = 0;
                    foreach (WipComponent comp in currentChild.ComponentInfo.Items)
                        qty += comp.integrity;
                    txtScrapQuantity.Text = qty.ToString();
                }
                else
                {
                    int qty = 0;
                    foreach (mesRelease.CAR.Carrier car in currentLot.CarrierList)
                        qty += car.componentQty;
                    txtScrapQuantity.Text = (currentLot.quantity - (double)qty).ToString();
                }
            }
            else if (idv.mesCore.systemConfig.componentInfo)
            {
                double qty = 0;
                foreach (WipComponent comp in currentChild.ComponentInfo.Items)
                    qty += comp.integrity;
                txtScrapQuantity.Text = qty.ToString();
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.componentInfo)
            {
                compParentComponent.SelectAll();
                WipComponent[] comps = compParentComponent.GetSelectedComponent();
                foreach (WipComponent comp in comps)
                {
                    compParentComponent.RemoveComponent(comp);
                    compChildComponent.AddComponent(comp);
                }
                showScrapQuantity();
            }
            else
            {
                while (carParentCarrier.carrierList.Count > 0)
                {
                    mesRelease.CAR.Carrier car = carParentCarrier.carrierList[0];
                    carParentCarrier.RemoveCarrier(car.name);
                }
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.componentInfo)
            {
                if (compChildComponent.componentInfo == null) return;
                WipComponent[] comps = compParentComponent.GetSelectedComponent();
                foreach (WipComponent comp in comps)
                {
                    compParentComponent.RemoveComponent(comp);
                    compChildComponent.AddComponent(comp);
                }
                showScrapQuantity();
            }
            else
            {
                mesRelease.CAR.Carrier car = carParentCarrier.selectedCarrier;
                if (car != null)
                {
                    carParentCarrier.RemoveCarrier(car.name);
                }
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (idv.mesCore.systemConfig.componentInfo)
            {
                if ((cboParentCarrier.SelectedItem as mesRelease.CAR.Carrier) == null
                               && idv.mesCore.systemConfig.carrierManagement) return;
                if (compParentComponent.componentInfo == null) return;
                WipComponent[] comps = compChildComponent.GetSelectedComponent();
                foreach (WipComponent comp in comps)
                {
                    compChildComponent.RemoveComponent(comp);
                    compParentComponent.AddComponent(comp);
                }
                showScrapQuantity();
            }
        }

        private void carChildCarrier_AfterEdit(object sender, EventArgs e)
        {
            showScrapQuantity();
        }

        private void compParentComponent_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void carParentCarrier_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void compChildComponent_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void carChildCarrier_DoubleClick(object sender, EventArgs e)
        {
            btnUnSelect.PerformClick();
        }

        private void txtChildLotQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else if (e.KeyChar == '.' && (txtScrapQuantity.Text.IndexOf('.') >= 0 || txtScrapQuantity.Text == ""))
                e.Handled = true;
        }

        private void carParentCarrier_AfterEdit(object sender, EventArgs e)
        {
            showScrapQuantity();
        }
    }
}
