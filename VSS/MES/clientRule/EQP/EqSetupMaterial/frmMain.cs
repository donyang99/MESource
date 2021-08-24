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

namespace ClientRule.EqSetupMaterial
{
    public partial class frmMain : Form
    {
        List<string> lstPosition = new List<string>();//所有軌道
        WorkOrder currentOrder = null;
        StepParameter currentStepParameter = null;
        Equipment currentEqp = null;
        bool isMatSettingReady = false;
        bool isAllowMultiMaterial = true;//是否允許一個軌道上多個料
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            currentEqp = RuleInstance.GetItem(0);

            lvwSetupMaterial.columnNames = "position,name,partNo,materialLotId,quantity".Split(',');
            lvwSetupMaterial.columnTags = "position,materialType,materialPartNo,materialLotId,quantity".Split(',');

            lvwSetupMaterial.prepareColumns();

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
                if (cboPosition.Enabled)
                    ActiveControl = cboPosition;
                else
                    ActiveControl = txtMaterialPartNo;
            }

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            lvwSetupMaterialWidth();
            CancelButton = btnCancel;
        }
        void lvwSetupMaterialWidth()
        {
            if (cboPosition.Enabled)
            {
                lvwSetupMaterial.Columns[0].Width = 70;
                lvwSetupMaterial.Columns[0].Text = cultureLanguage.getValue("position");
                cboPosition.Visible = true;
                lblPosition.Visible = true;
            }
            else
            {
                lvwSetupMaterial.Columns[0].Width = 30;
                lvwSetupMaterial.Columns[0].Text = "";
                cboPosition.Visible = false;
                lblPosition.Visible = false;
            }
            lvwSetupMaterial.Columns[1].Width = 130;
            lvwSetupMaterial.Columns[2].Width = 130;
            lvwSetupMaterial.Columns[3].Width = 130;
            lvwSetupMaterial.Columns[4].Width = 60;
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
            showSettingMaterials();
            cboPosition.Items.Clear();
            cboPosition.Enabled = currentEqp.trackCount > 1;
            if (cboPosition.Enabled)
                cboPosition.Items.AddRange(lstPosition.ToArray());
            
            if (currentEqp.SetupInfo != null)
            {
                Dictionary<string, byte> dicTemp = new Dictionary<string, byte>();//設定的軌道(物料類型)已上料數
                foreach (SetupMaterial mat in currentEqp.SetupInfo.ToSortedList())
                {
                    if (mat.position.Equals(""))//依物料類型
                    {
                        if (!dicTemp.ContainsKey(mat.name))
                        {
                            mat.sysid = mat.name;
                            dicTemp[mat.name] = 1;
                        }
                        else
                        {
                            mat.sysid = mat.name + dicTemp[mat.name].ToString();
                            dicTemp[mat.name]++;
                        }
                    }
                    else//依軌道
                    {
                        if (!dicTemp.ContainsKey(mat.position))
                        {
                            mat.sysid = mat.position;
                            dicTemp[mat.position] = 1;
                        }
                        else
                        {
                            mat.sysid = mat.position + dicTemp[mat.position].ToString();
                            dicTemp[mat.position]++;
                        }
                        if (isPositionUsed(mat.position))//機台該軌道是否已有料(如有，Postion ComboBox就不顯示了)
                            cboPosition.Items.Remove(mat.position);
                    }
                    lvwSetupMaterial.UpdateMESItem(mat);
                }
            }
            if (cboPosition.Enabled)
            {
                if (cboPosition.Items.Count > 0)
                {
                    cboPosition.SelectedIndex = 0;
                    txtMaterialPartNo.Focus();
                }
                else
                {
                    cboPosition.Text = "";
                    cboPosition.Focus();
                }
            }
            else
                txtMaterialPartNo.Focus();

            lvwSetupMaterialWidth();
        }
        
        //依設定顯示機台可上物料資訊
        void showSettingMaterials()
        {
            if (isMatSettingReady)
            {
                lvwSetupMaterial.UnCheckAllItems();
                foreach (SetupMaterial mat in lvwSetupMaterial.GetAllMESItem())
                {
                    if (mat.sysid.Equals(mat.position) || mat.sysid.Equals(mat.name))
                    {
                        mat.partNo = "";
                        mat.materialLotId = "";
                        mat.quantity = 0;
                        lvwSetupMaterial.UpdateMESItem(mat);
                    }
                    else
                    {
                        lvwSetupMaterial.RemoveMESItem(mat);
                    }
                }
                return;
            }
            lstPosition.Clear();
            
            lvwSetupMaterial.RemoveAllMESItems();
            if (idv.mesCore.systemConfig.productParameter && currentStepParameter == null) return;
            isMatSettingReady = true;
            if (currentEqp.trackCount > 1)
            {
                if (idv.mesCore.systemConfig.productParameter)
                {
                    foreach (EqTrackMaterial trackMat in currentStepParameter.GetEqTrackMaterials(currentEqp.type))
                    {
                        if (trackMat.Count == 0) continue;
                        lstPosition.Add(trackMat.track);
                        SetupMaterial material = new SetupMaterial();
                        material.position = trackMat.track;
                        material.sysid = trackMat.track;
                        lvwSetupMaterial.UpdateMESItem(material);
                    }
                }
                else
                {
                    foreach (string track in EqType.GetEqType(currentEqp.type).tracks)
                    {
                        lstPosition.Add(track);
                        SetupMaterial material = new SetupMaterial();
                        material.position = track;
                        material.sysid = track;
                        lvwSetupMaterial.UpdateMESItem(material);
                    }
                }
            }
            else
            {
                if (idv.mesCore.systemConfig.productParameter)
                {
                    for (int i = 0; i < currentStepParameter.MaterialTypeCount; i++)
                    {
                        SpecMaterial specMat = currentStepParameter.GetMaterialType(i);
                        if (!specMat.required) continue;
                        SetupMaterial material = new SetupMaterial();
                        material.name = specMat.name;
                        material.sysid = specMat.name;
                        lvwSetupMaterial.UpdateMESItem(material);
                    }
                }
                else
                {
                    foreach (string matType in mesRelease.MAT.StepMaterialType.GetStepMaterialTypesByEquipment(currentEqp.name))
                    {
                        SetupMaterial material = new SetupMaterial();
                        material.name = matType;
                        material.sysid = matType;
                        lvwSetupMaterial.UpdateMESItem(material);
                    }
                }
            }
            lvwSetupMaterial.SelectedItems.Clear();
        }
        void clearInputValues()
        {
            cboPosition.Text = "";
            txtMaterialPartNo.Text = "";
            txtMaterialType.Text = "";
            txtMaterialLotId.Text = "";
            txtMaterialQty.Text = "";
            isMatSettingReady = false;
            btnClearOrder.PerformClick();            
        }
        bool isPositionUsed(string position)
        {
            if (currentEqp == null) return false;
            if (currentEqp.SetupInfo == null) return false;
            foreach (SetupMaterial mat in currentEqp.SetupInfo.Items)
            {
                if (mat.position.Equals(position))
                    return true;
            }
            return false;
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
            isMatSettingReady = false;
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
        
        mesRelease.MAT.MaterialPart part = null;
        bool showMaterialType(string partId)
        {
            txtMaterialType.Text = "";
            if (part == null || !part.name.Equals(partId))
            {
                part = new mesRelease.MAT.MaterialPart(partId);
                if (part.sysid.Equals(""))
                {
                    part = null;
                    idv.utilities.messageBox.showMessageById("msgWrongInfo", lblMaterialPartNo.Text);
                    return false;
                }
            }
            txtMaterialType.Text = part.materialType;
            return true;
        }
        private void txtMaterialPartNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !txtMaterialPartNo.Text.Trim().Equals(""))
            {
                if (txtMaterialPartNo.SelectedText.Equals(txtMaterialPartNo.Text)) return;
                if (showMaterialType(txtMaterialPartNo.Text))
                    HandlerSendKeyTab(sender, e);
                else
                    txtMaterialPartNo.SelectAll();
            }
        }

        private void txtMaterialLotId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !txtMaterialLotId.Text.Equals(""))
            {
                if (txtMaterialQty.Visible)
                    HandlerSendKeyTab(sender, e);
                else
                    btnAdd.PerformClick();
            }
        }

        private void txtMaterialQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !txtMaterialQty.Text.Equals(""))
                btnAdd.PerformClick();
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        bool checkMaterialInput()
        {
            if (idv.mesCore.systemConfig.productParameter && currentOrder == null)
            {
                idv.utilities.messageBox.showMessageById("msgPlsSelectItem", lblOrderId.Text);
                cboOrderId.Focus();
                return false;
            }
            if (cboPosition.Enabled )
            {
                if (cboPosition.Text.Equals(""))
                {
                    idv.utilities.messageBox.showMessageById("msgPlsSelectItem", lblPosition.Text);
                    return false;
                }
                else if (!lstPosition.Contains(cboPosition.Text))
                {
                    idv.utilities.messageBox.showMessageById("msgCantFindLot2", lblPosition.Text);
                    return false;                
                }
            }
            if (txtMaterialPartNo.Text.Trim().Equals(""))
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblMaterialPartNo.Text);
                txtMaterialPartNo.Focus();
                return false;
            }
            showMaterialType(txtMaterialPartNo.Text);
            if (part == null || part.sysid.Equals(""))
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblMaterialPartNo.Text);
                txtMaterialPartNo.SelectAll();
                txtMaterialPartNo.Focus();
                return false;
            }

            if (!cboPosition.Enabled)//無軌道，by MaterialType上料
            {
                bool matTypeFlag = false;
                foreach (SetupMaterial material in lvwSetupMaterial.GetAllMESItem())
                {
                    if (material.name.Equals(txtMaterialType.Text))
                        matTypeFlag = true;
                }
                if (!matTypeFlag)
                {
                    txtMaterialPartNo.SelectAll();
                    txtMaterialPartNo.Focus();
                    idv.utilities.messageBox.showMessageById("msgMakesureInformation", Text);
                    return false;
                }
            }

            if (currentStepParameter != null && !currentStepParameter.CheckMaterial(currentEqp.type, cboPosition.Text, txtMaterialType.Text, txtMaterialPartNo.Text))
            {
                txtMaterialPartNo.SelectAll();
                txtMaterialPartNo.Focus();
                idv.utilities.messageBox.showMessageById("msgMakesureInformation", Text);
                return false;
            }

            if (txtMaterialQty.Visible && txtMaterialQty.Text.Trim().Equals(""))
            {
                idv.utilities.messageBox.showMessageById("requireField2", lblMaterialQty.Text);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkMaterialInput()) return;
            SetupMaterial material = new SetupMaterial();
            material.name = txtMaterialType.Text;
            if (currentEqp.trackCount > 0)
                material.sysid = cboPosition.Text;//以軌道為key
            else
                material.sysid = material.name;//以材料類型為key
            material.partNo = txtMaterialPartNo.Text;
            material.materialLotId = txtMaterialLotId.Text;
            material.position = cboPosition.Text;
            material.quantity = GetQuantity(txtMaterialQty.Text);

            if (AddMaterial(material))
            {
                txtMaterialPartNo.Text = "";
                txtMaterialLotId.Text = "";
                txtMaterialQty.Text = "";
                txtMaterialType.Text = "";
            }
            else
            {
                string orgPosition = cboPosition.Text;
                currentEqp.Refresh(true);
                cboPosition.Text = orgPosition;
            }
            showCurrentEqpInfo();
            equipmentInformation1.Init(currentEqp);
        }
        private bool AddMaterial(SetupMaterial material)
        {
            bool succeed = false;
            standardStatusbar1.setInformation("");
            RuleInstance.logFunctionIn("AddMaterial");
            //generate txn object and assign correspond information
            mesRelease.EQP.Txn.Setup txn = new mesRelease.EQP.Txn.Setup();
            txn.txnUser = User.loginUser.name;

            SetupInfo info = new SetupInfo(currentEqp.type);
            info.Add(material);

            Cursor = Cursors.WaitCursor;

            txn.setupInfo = info;
            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentEqp);

            txn.setupType = idv.mesCore.EQP.Txn.SetupMaterialType.AddMaterial;
            txn.allowMultiMaterial = isAllowMultiMaterial;
            try
            {
                //dotxn and get return value
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("AddMaterial");
            //check txn result and do correspond action
            if (txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                currentEqp = txn.Item(0);
                succeed = true;
                RuleInstance.RuleResult = "PASS";                
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
                if (txn.localMode)
                    SendBroadcast(currentEqp);
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
            return succeed;
        }

        int GetQuantity(string quantity)
        {
            int qty = 0;
            int.TryParse(quantity, out qty);
            return qty;
        }

        private void lvwSetupMaterial_MESItemCheckChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected, ref bool Cancel)
        {
            if (selected)
            {
                SetupMaterial mat = item as SetupMaterial;
                if (mat == null || mat.partNo.Equals(""))
                    Cancel = true;
            }
        } 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwSetupMaterial.selectedMESItem == null) return;
            if (!idv.utilities.messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo)) return;

            List<SetupMaterial> list = new List<SetupMaterial>();
            foreach (SetupMaterial mat in lvwSetupMaterial.selectedMESItems)
                list.Add(mat);

            RemoveMaterial(list.ToArray());

            showCurrentEqpInfo();
        }
        private void RemoveMaterial(SetupMaterial[] materials)
        {
            standardStatusbar1.setInformation("");
            RuleInstance.logFunctionIn("RemoveMaterial");
            //generate txn object and assign correspond information
            mesRelease.EQP.Txn.Setup txn = new mesRelease.EQP.Txn.Setup();
            txn.txnUser = User.loginUser.name;

            SetupInfo info = new SetupInfo(currentEqp.type);
            foreach (SetupMaterial mat in materials)
                info.Add(mat);

            Cursor = Cursors.WaitCursor;

            txn.setupInfo = info;
            //add protagonist to txn item collcation by txn.add method
            txn.Add(currentEqp);

            txn.setupType = idv.mesCore.EQP.Txn.SetupMaterialType.RemoveMaterial;
            try
            {
                //dotxn and get return value
                txn = txn.doTxn();
            }
            catch { }

            RuleInstance.logFunctionOut("RemoveMaterial");
            currentEqp = txn.Item(0);
            equipmentInformation1.Init(currentEqp);
            //check txn result and do correspond action
            if (txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                RuleInstance.RuleResult = "PASS";
                standardStatusbar1.setInformation(cultureLanguage.getValue("msgExecuteSucceed"), idv.mesCore.Controls.informationType.succeed);
                if (txn.localMode)
                    SendBroadcast(currentEqp);
            }
            else
            {
                //assign CANCEL to RuleResult if txn fail, to tell WF to go back original status
                RuleInstance.RuleResult = "CANCEL";
                messageBox.showMessage(txn.errMessage, messageStyle.error);
            }
            Cursor = Cursors.Default;
        }

        void SendBroadcast(Equipment eq)
        {
            try
            {
                eq.send();
            }
            catch { }
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
    }
}
