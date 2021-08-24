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

namespace ClientRule.Pallet
{
    public partial class frmMain : DockContent
    {
        Equipment currentEqp = null;
        mesRelease.WIP.Pallet currentPallet = null;
        mesRelease.PRP.Step currentStep = null;
        public void SetCurrentStep(mesRelease.PRP.Step step)
        {
            currentStep = step;
            cboEquipmentId.Items.Clear();
            cboEquipmentId.Items.AddRange(EqGroup.GetEquipments(step.equipmentGroup, true));
        }

        public frmMain()
        {
            InitializeComponent();
        }

        void MESApplication_TextCommandInput(Control sender, string commandText)
        {
            if (sender.FindForm() != this) return;
            MessageBox.Show("InputTextCommand=" + commandText);
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            WorkFlow.MESItemUpdated += new MESItemNoticeEventHandler(WorkFlow_MESItemUpdated);//訂閱Server端MES物件更新事件通知
            idv.MESApplication.TextCommandInput += new idv.MESApplication.InputCommandEventHandler(MESApplication_TextCommandInput);
            mesRelease.MESApplication.MessagePanel = pnlDisplayMessage;
            mesRelease.WF.WorkFlow.DisErrStyle = DisplayErrorStyle.MessagePanel;

            //put the logic that run with matin thread here
            lvwPalletInfo.prepareColumns();
            lvwCartonInfo.prepareColumns();
            lvwLotInfo.prepareColumns();
            btnExit.Visible = Parent == null;

            Text = WorkFlow.CurrentWorkingArea;
            if (WorkFlow.CurrentEquipment != null)
                cboEquipmentId.Text = WorkFlow.CurrentEquipment.name;

            if (idv.mesCore.systemConfig.assemblyMode)
                cboEquipmentId.Enabled = false;

            ActiveControl = txtCartonId;

            idv.utilities.cultureLanguage.switchLanguageSync(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {   //取消Server端MES物件更新事件通知
            WorkFlow.MESItemUpdated -= new MESItemNoticeEventHandler(WorkFlow_MESItemUpdated);
            idv.MESApplication.TextCommandInput -= new idv.MESApplication.InputCommandEventHandler(MESApplication_TextCommandInput);
        }

        void WorkFlow_MESItemUpdated(idv.messageService.itemBase mesItem, Type type)
        {   //機台有更新時
            if(type.Equals(typeof(Equipment)) && mesItem.name.Equals(cboEquipmentId.Text))
            {
                txtState.Text = WorkFlow.CurrentEquipment.state;
                btnGetCarton.Enabled = WorkFlow.CurrentEquipment.available;
            }
        }

        private void cboEquipmentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentEqp = cboEquipmentId.SelectedItem as Equipment;
            if (currentEqp != null)
            {
                lvwPalletInfo.ShowMESItems(mesRelease.WIP.Pallet.GetPalletByLocation(currentEqp.name));
                if (lvwPalletInfo.TotalCount == 1)
                    lvwPalletInfo.Items[0].Selected = true;
                txtState.Text = currentEqp.state;
                btnGetCarton.Enabled = currentEqp.available;
            }
            else
            {
                lvwPalletInfo.RemoveAllMESItems();
                txtState.Text = "";
                btnGetCarton.Enabled = false;
            }
        }

        private void txtCartonId_BarcodeInput(object sender, string barcode)
        {
            btnGetCarton.PerformClick();
        }

        private void btnGetCarton_Click(object sender, EventArgs e)
        {
            if (idv.MESApplication.TriggerInputCommand(txtCartonId, txtCartonId.Text)) return;
            mesRelease.MESApplication.ClearMessage();

            if (currentPallet == null)
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgPlsSelectItem", lblPalletId.Text), Color.Red);
                return; 
            }

            if (txtCartonId.Text.Trim().Equals(""))
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("requireField2", lblCartonId.Text), Color.Red);
                focusCartonId();
                return;
            }
            Carton carton = Carton.GetCartonById(txtCartonId.Text);
            if (carton == null)
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgCantFindLot2", lblCartonId.Text), Color.Red);
                focusCartonId();
                return;
            }
            else if (!checkCarton(carton))
            {
                focusCartonId();
                return;
            }
            txtCartonStatus.Text = carton.status;

            //if (!currentPallet.orderId.Equals("") && !currentPallet.orderId.Equals(carton.orderId))//限制棧板一定要放相同工單的貨
            //{
            //    idv.MESApplication.PlayNGSound();
            //    mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgWrongInfo", cultureLanguage.getValue("orderId")), Color.Red);
            //    focusCartonId();
            //    return;
            //}

            try
            {
                if (currentPallet.Item(carton.name) == null)
                {
                    currentPallet.Add(carton);
                    lvwCartonInfo.UpdateMESItem(carton);
                    idv.MESApplication.PlayOKSound();
                }
                else if (messageBox.showMessageById("msgRemoveItem", messageStyle.askYesNo, carton.name, currentPallet.name))
                {
                    currentPallet.Remove(carton.name);
                    lvwCartonInfo.RemoveMESItem(carton);
                }
                lvwPalletInfo.UpdateCurrentItem(currentPallet);
                txtCartonId.Text = "";
            }
            catch (Exception ex)
            {
                focusCartonId();
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(ex.Message, Color.Red);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCartonId.Text = "";
            txtCartonId.Focus();
        }

        bool checkCarton(Carton carton)
        {
            if (!carton.status.Equals(idv.mesCore.WIP.CartonStatus.CLOSE.ToString()) || (carton.locationType == idv.mesCore.WIP.CartonLocation.Pallet && !carton.location.Equals(currentPallet.name)))
            {
                idv.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("cartonId") + "[" + carton.name + "] " + cultureLanguage.getValue("msgWrongInfo", "&status"), Color.Red);
                return false;
            }
            return true;
        }
        bool checkBeforeTxn(List<Lot> lotList)
        {
            mesRelease.MESApplication.ClearMessage();
            if (currentPallet == null)
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("noItemSelected"), Color.Red);
                return false;
            }

            currentPallet.refresh();
            foreach (Carton car in currentPallet.Items)
            {
                if (!checkCarton(car))
                    return false;
            }

            lotList.AddRange(mesRelease.WIP.Pallet.GetLotsByPalletUseId(currentPallet.useId));
            foreach (Lot lot in lotList)
            { 
                if(!lot.status.Equals(idv.mesCore.WIP.LotStatus.WAIT.ToString()))
                {
                    idv.MESApplication.PlayNGSound();
                    mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("lotId") + "[" + lot.name + "] " + cultureLanguage.getValue("msgWrongInfo", "&status"), Color.Red);
                    return false;
                }
            }

            return true;
        }

        private void doPallet()
        {
            List<Lot> lotList = new List<Lot>();
            if (!checkBeforeTxn(lotList)) return;
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
                return;
            RuleInstance.logFunctionIn("btnOK_Click", "palletId", currentPallet.name);

            Cursor = Cursors.WaitCursor;
            //dotxn and get return value
            try
            {
                currentPallet.status = idv.mesCore.WIP.CartonStatus.CLOSE.ToString();
                currentPallet.locationType = idv.mesCore.WIP.PalletLocation.BankArea;
                currentPallet.location = "";
                currentPallet.modifyUser = User.loginUserId;
                currentPallet.Modify();
                WorkFlow.DispatchLotToNext(lotList.ToArray(), "PASS", "PASS");//若有OutStepCheck Rule，也以PASS路徑自動往下走

                idv.MESApplication.PlayOKSound();
                RuleInstance.RuleResult = "PASS";
                lvwPalletInfo.RemoveMESItem(currentPallet);
                currentPallet = null;
                finishAction();
            }
            catch (Exception ex)
            {
                idv.MESApplication.PlayNGSound();
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(ex.Message, messageStyle.error);
            }

            RuleInstance.logFunctionOut("btnOK_Click");
            Cursor = Cursors.Default;
        }

        void focusCartonId()
        {
            ActiveControl = txtCartonId;
            txtCartonId.SelectAll();
        }

        //完成Lot交易後，清空畫面及變數
        void finishAction()
        {
            txtCartonId.Text = "";
            txtCartonStatus.Text = "";
            txtCartonId.Focus();
            mesRelease.MESApplication.ClearMessage();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPalletId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtPalletId.Text.Trim().Equals(""))
            {
                mesRelease.MESApplication.ClearMessage();
                if (cboEquipmentId.Text.Equals(""))
                {
                    mesRelease.MESApplication.PlayNGSound();
                    mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgPlsSelectItem", lblEquipment.Text), Color.Red);
                    return;
                }
                mesRelease.WIP.Pallet pal = mesRelease.WIP.Pallet.GetPalletById(txtPalletId.Text.Trim());
                if (pal == null)
                {
                    mesRelease.MESApplication.PlayNGSound();
                    mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgCantFindLot2",lblPalletId.Text), Color.Red);
                    return;
                }
                if (!pal.status.Equals(idv.mesCore.WIP.CartonStatus.WAIT.ToString()) || pal.locationType != idv.mesCore.WIP.PalletLocation.None)
                {
                    mesRelease.MESApplication.PlayNGSound();
                    mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgWrongInfo", "&status"), Color.Red);
                    return;
                }
                pal.fab = WorkFlow.loginFAB;
                pal.locationType = idv.mesCore.WIP.PalletLocation.Equipment;
                pal.location = cboEquipmentId.Text;
                pal.modifyUser = mesRelease.USR.User.loginUserId;
                try
                {
                    pal.Modify();
                    lvwPalletInfo.UpdateMESItem(pal);
                    focusCartonId();
                }
                catch (Exception ex)
                {
                    mesRelease.MESApplication.PlayNGSound();
                    mesRelease.MESApplication.AddMessage(ex.Message, Color.Red);
                }
            }
        }
        private void btnAddPallet_Click(object sender, EventArgs e)
        {
            mesRelease.MESApplication.ClearMessage();
            if (cboEquipmentId.Text.Equals(""))
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("msgPlsSelectItem", lblEquipment.Text), Color.Red);
                return;
            }
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
                return;
            mesRelease.WIP.Pallet pal = new mesRelease.WIP.Pallet();
            pal.name = mesRelease.WIP.Pallet.GetPalletId();
            pal.fab = WorkFlow.loginFAB;
            pal.locationType = idv.mesCore.WIP.PalletLocation.Equipment;
            pal.location = cboEquipmentId.Text;
            pal.createUser = mesRelease.USR.User.loginUserId;
            try
            {
                pal.New();
                lvwPalletInfo.UpdateMESItem(pal);
                focusCartonId();
            }
            catch (Exception ex)
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(ex.Message, Color.Red);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            mesRelease.MESApplication.ClearMessage();
            if (currentPallet == null)
            {
                //mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(cultureLanguage.getValue("noItemSelected"), Color.Red);
                return;
            }
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo))
                return;

            try
            {
                currentPallet.Delete();
                lvwPalletInfo.RemoveMESItem(currentPallet);
            }
            catch (Exception ex)
            {
                mesRelease.MESApplication.PlayNGSound();
                mesRelease.MESApplication.AddMessage(ex.Message, Color.Red);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            doPallet();
        }

        private void lvwPalletInfo_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                currentPallet = null;
                txtPalletId.Text = "";
                lvwCartonInfo.RemoveAllMESItems();
                lvwLotInfo.RemoveAllMESItems();
            }
            else
            {
                currentPallet = item as mesRelease.WIP.Pallet;
                if (currentPallet == null) return;
                txtPalletId.Text = currentPallet.name;
                currentPallet.retrieveCartons();
                lvwCartonInfo.ShowMESItems(currentPallet.Items.ToArray());
            }
        }

        private void lvwCartonInfo_DoubleClick(object sender, EventArgs e)
        {
            if (lvwCartonInfo.selectedMESItem == null)
                lvwLotInfo.RemoveAllMESItems();
            else
            {
                Carton car = lvwCartonInfo.selectedMESItem as Carton;
                if (car == null) return;
                car.retrieveLots();
                lvwLotInfo.ShowMESItems(car.Items.ToArray());
            }
        }
    }
}
