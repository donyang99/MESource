using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.PARM;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.EqSetup
{
    public partial class frmMain : Form
    {
        List<string> lstPosition = new List<string>();//所有軌道
        WorkOrder currentOrder = null;
        StepParameter currentStepParameter = null;
        Equipment currentEqp = null;
        bool originalMaterialQtyChanged = false;

        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {
            RuleInstance.RuleResult = "CANCEL";
            currentEqp = RuleInstance.GetItem(0);

            lvwCurSetupMaterial.columnNames = "position,name,partNo,materialLotId,quantity".Split(',');
            lvwCurSetupMaterial.columnTags = "position,materialType,materialPartNo,materialLotId,quantity".Split(',');
            lvwSetupMaterial.columnNames = lvwCurSetupMaterial.columnNames;
            lvwSetupMaterial.columnTags = lvwCurSetupMaterial.columnTags;

            if (!idv.mesCore.systemConfig.materialConsuming)
            {
                //lvwCurSetupMaterial.columnHide = "quantity".Split(',');
                tblModifyQty.Visible = false;
                //lblMaterialQty.Visible = false;
                //txtMaterialQty.Visible = false;
            }

            if (idv.mesCore.systemConfig.materialTracking)
            {
                lvwCurSetupMaterial.prepareColumns();
                //lvwSetupMaterial.columnHide = lvwCurSetupMaterial.columnHide;
                lvwSetupMaterial.prepareColumns();
                lvwSetupMaterial.Columns[0].Width = 70;
                lvwSetupMaterial.Columns[1].Width = 130;
                lvwSetupMaterial.Columns[2].Width = 130;
                lvwSetupMaterial.Columns[3].Width = 130;
                lvwSetupMaterial.Columns[4].Width = 60;
                for (int i = 0; i < lvwCurSetupMaterial.Columns.Count; i++)
                    lvwCurSetupMaterial.Columns[i].Width = lvwSetupMaterial.Columns[i].Width;
            }
            else
            {                
                lvwCurSetupMaterial.Visible = false;
                pnlSetupMaterial.Visible = false;
                tblMaterialInfo.Visible = false;
            }

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
            
            pnlTarget.Visible = idv.mesCore.systemConfig.productParameter;

            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                lvwCurTooling.prepareColumns();
                lvwSetupTooling.prepareColumns();
                lvwCurTooling.Columns[0].Width = 100;
                lvwCurTooling.Columns[1].Width = 100;
                lvwCurTooling.Columns[2].Width = 150;
                lvwSetupTooling.Columns[0].Width = 100;
                lvwSetupTooling.Columns[1].Width = 100;
                lvwSetupTooling.Columns[2].Width = 150;
            }
            else
            {
                pnlCurToolingInfo.Visible = false;
                pnlSetupToolingInfo.Visible = false;                
            }

            if (!idv.mesCore.systemConfig.materialTracking && !idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                Width = 950;
                Height = 310;
                splSetupInfo.SplitterDistance = 350;
            }
            else if (!idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                Height = 650;
            }
            else if (!idv.mesCore.systemConfig.materialTracking)
            {
                Height = 500;
                pnlCurToolingInfo.BringToFront();
                pnlSetupToolingInfo.BringToFront();
                pnlCurToolingInfo.Dock = DockStyle.Fill;
                pnlSetupToolingInfo.Dock = DockStyle.Fill;
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
            if (currentEqp != null && !equipment.name.Equals(currentEqp.name) && isAnyDataChanged())
            {
                if (!messageBox.showMessageById("msgSelectOthers", messageStyle.askYesNo))
                {
                    equipmentInformation1.Init(currentEqp);
                    accept = false;
                    return;
                }
            }
            currentEqp = equipment;
            showCurrentEqpInfo();
            clearInputValues();

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
            new System.Threading.Thread(doShowCurrentEqpInfo).Start();
            //doShowCurrentEqpInfo();
        }
        void doShowCurrentEqpInfo()
        {
            originalMaterialQtyChanged = false;
            txtCurRecipe.Text = currentEqp.recipe;
            cboPosition.Enabled = currentEqp.trackCount > 1;
            if (idv.mesCore.systemConfig.materialTracking)
            {
                lvwCurSetupMaterial.RemoveAllMESItems();
                if (currentEqp.SetupInfo != null)
                    lvwCurSetupMaterial.ShowMESItems(currentEqp.SetupInfo.ToSortedList());

                tblModifyQty.Enabled = lvwCurSetupMaterial.Items.Count > 0;

                showSetupMaterials();

                if (cboPosition.Enabled)
                {
                    lvwCurSetupMaterial.Columns[0].Width = 70;
                    lvwSetupMaterial.Columns[0].Width = 70;
                    cboPosition.Visible = true;
                    lblPosition.Visible = true;
                }
                else
                {
                    lvwCurSetupMaterial.Columns[0].Width = 0;
                    lvwSetupMaterial.Columns[0].Width = 0;             
                    cboPosition.Visible = false;
                    lblPosition.Visible = false;
                }
            }

            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                lvwCurTooling.RemoveAllMESItems();
                Type tToolingId = Type.GetType("mesRelease.TOL.ToolingId, toolingRelease");
                object returnValue = tToolingId.BaseType.InvokeMember("GetToolings", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                                        System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { "", "", currentEqp.name, "", false });

                idv.messageService.itemBase[] toolingIds = returnValue as idv.messageService.itemBase[];
                if (toolingIds.Length > 0)
                    lvwCurTooling.ShowMESItems(toolingIds);

                showSetupToolings();
            }
        }
        void showSetupMaterials()
        {
            lstPosition.Clear();
            cboPosition.Items.Clear();
            lvwSetupMaterial.RemoveAllMESItems();            
            if (idv.mesCore.systemConfig.productParameter && currentStepParameter == null) return;

            if (currentEqp.trackCount > 1)
            {
                if (idv.mesCore.systemConfig.productParameter)
                {
                    foreach (EqTrackMaterial trackMat in currentStepParameter.GetEqTrackMaterials(currentEqp.type))
                    {
                        if (trackMat.Count == 0) continue;
                        lstPosition.Add(trackMat.track);
                        if (!isPositionUsed(trackMat.track))
                            cboPosition.Items.Add(trackMat.track);
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
                        if (!isPositionUsed(track))
                            cboPosition.Items.Add(track);
                        SetupMaterial material = new SetupMaterial();
                        material.position = track;
                        material.sysid = track;
                        lvwSetupMaterial.UpdateMESItem(material);
                    }
                }
                if (cboPosition.Items.Count > 0)
                    cboPosition.SelectedIndex = 0;
                else
                    cboPosition.Text = "";
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

        void showSetupToolings()
        {
            lvwSetupTooling.RemoveAllMESItems();
            if (idv.mesCore.systemConfig.productParameter && currentStepParameter == null) return;

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
        }

        void clearInputValues()
        {
            txtInputRecipe.Text = "";

            if (cboPosition.Items.Count > 0)
                cboPosition.SelectedIndex = 0;
            else
                cboPosition.Text = "";
            txtMaterialPartNo.Text = "";
            txtMaterialType.Text = "";
            txtMaterialLotId.Text = "";
            txtMaterialQty.Text = "";

            txtToolingId.Text = "";
            txtToolingPart.Text = "";
            txtToolingType.Text = "";

            btnClearOrder.PerformClick();
            cboOrderId.Text = "";
        }
        bool isPositionUsed(string position)
        {
            if (currentEqp == null || currentEqp.SetupInfo == null) return false;
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
                messageBox.showMessageById("msgPlsSelectItem", cultureLanguage.getValue("Equipment"));
                return;
            }
            if (cboOrderId.Text.Trim().Equals("")) return;
            if (cboStepId.Text.Equals(""))
            {
                messageBox.showMessageById("requireField2", lblStepId.Text);
                return;
            }
            WorkOrder order = new WorkOrder(cboOrderId.Text);
            if (order.sysid.Equals(""))
            {
                messageBox.showMessageById("msgWrongInfo", lblOrderId.Text);
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
                    if (idv.mesCore.systemConfig.materialTracking)
                        showSetupMaterials();
                    if (idv.mesCore.systemConfig.validItem("toolingManagement"))
                        showSetupToolings();
                }
            }

            cboStepId.Enabled = false;
            cboOrderId.Enabled = false;
            btnConfirmOrder.Enabled = false;
            btnClearOrder.Enabled = true;
            txtInputRecipe.Focus();
        }
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            cboOrderId.SelectAll();
            currentOrder = null;
            currentStepParameter = null;

            cboStepId.Enabled = cboStepId.Items.Count > 1;
            cboOrderId.Enabled = true;
            btnConfirmOrder.Enabled = true;
            btnClearOrder.Enabled = false;

            if (idv.mesCore.systemConfig.productParameter)
            {
                cboPosition.Items.Clear();
                lvwSetupMaterial.RemoveAllMESItems();
            }

            if (idv.mesCore.systemConfig.validItem("toolingManagement"))
                lvwSetupTooling.RemoveAllMESItems();
        }

        private void txtInputRecipe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (cboPosition.Enabled)
                    cboPosition.Focus();
                else
                    txtMaterialPartNo.Focus();
            }
        }

        private void lvwCurSetupMaterial_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (selected)
            {
                SetupMaterial material = item as SetupMaterial;
                if (material != null)
                {
                    txtModifyQty.Text = material.quantity.ToString();
                }
            }
            else
            {
                txtModifyQty.Text = "";
            }
        }

        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btnModifyCurQty_Click(object sender, EventArgs e)
        {
            if (lvwCurSetupMaterial.selectedMESItem == null) return;
            SetupMaterial material = lvwCurSetupMaterial.selectedMESItem as SetupMaterial;
            if (material == null) return;
            int qty = 0;
            if (!int.TryParse(txtModifyQty.Text, out qty)) return;
            material.quantity = qty;
            lvwCurSetupMaterial.UpdateMESItem(material);
            originalMaterialQtyChanged = true;
        }

        private void btnDeleteCurMaterial_Click(object sender, EventArgs e)
        {
            if (lvwCurSetupMaterial.selectedMESItem == null || currentEqp == null) return;
            SetupMaterial material = lvwCurSetupMaterial.selectedMESItem as SetupMaterial;
            if (material == null) return;
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo)) return;
            currentEqp.SetupInfo.Remove(material);
            lvwCurSetupMaterial.RemoveMESItem(material);
            originalMaterialQtyChanged = true;
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
                    messageBox.showMessageById("msgWrongInfo", lblMaterialPartNo.Text);
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

        private void txtToolingId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !txtToolingId.Text.Equals(""))
                btnAddTooling.PerformClick();
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
                messageBox.showMessageById("msgPlsSelectItem", lblOrderId.Text);
                cboOrderId.Focus();
                return false;
            }
            if (cboPosition.Enabled)
            {
                if (cboPosition.Text.Equals(""))
                {
                    messageBox.showMessageById("msgPlsSelectItem", lblPosition.Text);
                    cboPosition.Focus();
                    return false;
                }
                else if (!lstPosition.Contains(cboPosition.Text))
                {
                    messageBox.showMessageById("msgCantFindLot2", lblPosition.Text);
                    cboPosition.Focus();
                    return false;
                }
            }
            if (txtMaterialPartNo.Text.Trim().Equals(""))
            {
                messageBox.showMessageById("requireField2", lblMaterialPartNo.Text);
                txtMaterialPartNo.Focus();
                return false;
            }
            showMaterialType(txtMaterialPartNo.Text);
            if (part == null || part.sysid.Equals(""))
            {
                messageBox.showMessageById("requireField2", lblMaterialPartNo.Text);
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
                    messageBox.showMessageById("msgMakesureInformation", Text);
                    return false;
                }
            }

            if (currentStepParameter != null && !currentStepParameter.CheckMaterial(currentEqp.type, cboPosition.Text, txtMaterialType.Text, txtMaterialPartNo.Text))
            {
                txtMaterialPartNo.SelectAll();
                txtMaterialPartNo.Focus();
                messageBox.showMessageById("msgMakesureInformation", Text);
                return false;
            }

            if (txtMaterialQty.Visible && txtMaterialQty.Text.Trim().Equals(""))
            {
                messageBox.showMessageById("requireField2", lblMaterialQty.Text);
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
            lvwSetupMaterial.UpdateMESItem(material);

            txtMaterialPartNo.Text = "";
            txtMaterialLotId.Text = "";
            txtMaterialQty.Text = "";
            txtMaterialType.Text = "";
            if (cboPosition.Enabled)
            {
                int selIndex = cboPosition.SelectedIndex;
                cboPosition.Items.Remove(cboPosition.Text);
                if (selIndex > -1 && selIndex <= (cboPosition.Items.Count - 1))
                {
                    cboPosition.SelectedIndex = selIndex;
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
            lvwSetupTooling.UpdateMESItem(tolId);
            txtToolingId.Text = "";
            txtToolingPart.Text = "";
            txtToolingType.Text = "";
            txtToolingId.Focus();
        }

        int GetQuantity(string quantity)
        {
            int qty = 0;
            int.TryParse(quantity, out qty);
            return qty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwSetupMaterial.selectedMESItem == null) return;
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo)) return;

            SetupMaterial material = lvwSetupMaterial.selectedMESItem as SetupMaterial;
            material.partNo = "";
            material.materialLotId = "";
            material.quantity = 0;

            if (currentEqp.trackCount > 1)
                material.name = "";

            lvwSetupMaterial.UpdateMESItem(material);
        }

        private void btnDelTooling_Click(object sender, EventArgs e)
        {
            if (lvwSetupTooling.selectedMESItem == null) return;
            if (!messageBox.showMessageById("msgAreYouSure", messageStyle.askYesNo)) return;

            idv.messageService.itemBase tolId = lvwSetupTooling.selectedMESItem as idv.messageService.itemBase;
            tolId.setProperty("partNo", "");
            tolId.setProperty("name", "");

            lvwSetupTooling.UpdateMESItem(tolId);
        }

        void SendBroadcast(Equipment eq)
        {
            try
            {
                eq.send();
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            mesRelease.EQP.Txn.Setup txn = new mesRelease.EQP.Txn.Setup();
            txn.txnUser = User.loginUserId;
            if (!txtInputRecipe.Text.Equals("")) txn.recipe = txtInputRecipe.Text;

            List<string> matKey = new List<string>();
            SetupInfo info = new SetupInfo(currentEqp.type);
            foreach (SetupMaterial material in lvwSetupMaterial.GetAllMESItem())
            {
                if (!material.partNo.Equals(""))
                {
                    info.Add(material);
                    if (cboPosition.Enabled)
                        matKey.Add(material.position);
                    else
                        matKey.Add(material.name);
                }
            }

            if (currentEqp.SetupInfo != null)
            {
                foreach (SetupMaterial material in currentEqp.SetupInfo.Items)
                {
                    if (cboPosition.Enabled)
                    {
                        if (!matKey.Contains(material.position) && lvwSetupMaterial.Items.ContainsKey(material.position))
                            info.Add(material);
                    }
                    else
                    {
                        if (!matKey.Contains(material.name) && lvwSetupMaterial.Items.ContainsKey(material.name))
                            info.Add(material);
                    }
                }
            }

            //Check StepParameter
            if (!checkStepParameter(info)) return;

            //Tooling
            Dictionary<string, idv.messageService.itemBase> dicTooling = new Dictionary<string, idv.messageService.itemBase>();//新上機治具
            List<idv.messageService.itemBase> lstUnloadTooling = new List<idv.messageService.itemBase>();//Unload治具
            List<idv.messageService.itemBase> lstRemainTooling = new List<idv.messageService.itemBase>();//原機上治具(不上機也不Unload)
            foreach (idv.messageService.itemBase tolId in lvwSetupTooling.GetAllMESItem())
            {
                if (!tolId.getPropertyInString("partNo").Equals(""))
                    dicTooling.Add(tolId.getPropertyInString("toolingType"), tolId);
            }
            foreach (idv.messageService.itemBase tolId in lvwCurTooling.GetAllMESItem())
            {
                if (dicTooling.ContainsKey(tolId.getPropertyInString("toolingType")))
                    lstUnloadTooling.Add(tolId);
                else if (lvwSetupTooling.Items.ContainsKey(tolId.getPropertyInString("toolingType")))
                    lstRemainTooling.Add(tolId);
                else
                    lstUnloadTooling.Add(tolId);
            }
            if (!checkCheckParameterTooling(dicTooling.Values.ToArray(), lstRemainTooling.ToArray())) return;

            Cursor = Cursors.WaitCursor;

            txn.setupInfo = info;
            if (dicTooling.Count > 0)
                currentEqp.toolingSetupInfo = "-";
            txn.Add(currentEqp);
            txn.setupType = idv.mesCore.EQP.Txn.SetupMaterialType.FullSetup;
            try
            {
                if (ToolingTxn(dicTooling.Values.ToArray(), lstUnloadTooling.ToArray()))
                    txn.txnActor = idv.messageService.TransactionActor.Last;

                txn = txn.doTxn();
            }
            catch(Exception ex)
            {
                txn.errMessage = ex.ToString();
            }

            RuleInstance.logFunctionOut("btnOK_Click");
            currentEqp = txn.Item(0);
            equipmentInformation1.Init(currentEqp);
            //check txn result and do correspond action
            if (txn.result.Equals("PASS"))
            {
                //*IMPORTANT*
                //assign RuleInstance.RuleResult, PASS is default to tell WF to go to next
                //if there are non PASS path in Route, you can also assign other path name in RuleResult
                RuleInstance.RuleResult = "PASS";
                showCurrentEqpInfo();
                clearInputValues();
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
        bool ToolingTxn(idv.messageService.itemBase[] setupTooling, idv.messageService.itemBase[] unloadTooling)
        {
            if (setupTooling.Length == 0 && unloadTooling.Length == 0) return false;
            idv.messageService.TransactionActor actor = idv.messageService.TransactionActor.First;
            List<object> lstArgu = new List<object>();
            List<string> lstTooling = new List<string>();
            Type tTxnEvent = Type.GetType("mesRelease.TOL.Txn.TxnEvent, toolingRelease");

            if (unloadTooling.Length > 0)
            {
                foreach (idv.messageService.itemBase item in unloadTooling)
                    lstTooling.Add(item.name);
                lstArgu.Add("");//comment
                lstArgu.Add(User.loginUserId);
                lstArgu.Add(null);//sqlTable List
                lstArgu.Add(actor);
                lstArgu.Add(lstTooling.ToArray());

                object returnValue = tTxnEvent.BaseType.InvokeMember("UnLoad", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                        System.Reflection.BindingFlags.InvokeMethod, null, null, lstArgu.ToArray());
                actor = idv.messageService.TransactionActor.Interior;
            }
            if (setupTooling.Length > 0)
            {
                lstTooling.Clear();
                lstArgu.Clear();
                foreach (idv.messageService.itemBase item in setupTooling)
                    lstTooling.Add(item.name);
                lstArgu.Add(currentEqp.name);
                lstArgu.Add("");//comment
                lstArgu.Add(User.loginUserId);
                lstArgu.Add(null);//sqlTable List
                lstArgu.Add(actor);
                lstArgu.Add(lstTooling.ToArray());

                object returnValue = tTxnEvent.BaseType.InvokeMember("HWSetup", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                        System.Reflection.BindingFlags.InvokeMethod, null, null, lstArgu.ToArray());
            }
            return true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentEqp != null && isAnyDataChanged())
            {
                if (!messageBox.showMessageById("quitWithoutSave", messageStyle.askYesNo))
                {
                    DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }
            }
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            Close();
        }
        bool isAnyDataChanged()
        {
            if (!txtInputRecipe.Text.Equals("") || originalMaterialQtyChanged)
                return true;
            else
            {
                foreach (SetupMaterial material in lvwSetupMaterial.GetAllMESItem())
                {
                    if (idv.mesCore.systemConfig.materialConsuming)
                    {
                        if (material.quantity > 0)
                            return true;
                    }
                    else
                    {
                        if (!material.partNo.Equals(""))
                            return true;
                    }
                }
                foreach (idv.messageService.itemBase tolId in lvwSetupTooling.GetAllMESItem())
                {
                    if (!tolId.name.Equals(""))
                        return true;
                }
            }
            return false;
        }
        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if (idv.mesCore.systemConfig.productParameter && currentOrder == null)
            {
                messageBox.showMessageById("msgPlsSelectItem", lblOrderId.Text);
                cboOrderId.Focus();
                return false;
            }
            else if (currentEqp == null)
            {
                messageBox.showMessageById("noItemSelected");
                return false;
            }
            else if (!isAnyDataChanged())
            {
                messageBox.showMessageById("noDataChanged");
                return false;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, Text + " (" + currentEqp.name + ")"))
            {
                return false;
            }
            return true;
        }
        bool checkStepParameter(SetupInfo setupInfo)
        {
            if (idv.mesCore.systemConfig.productParameter)
            {
                if (currentOrder.specId.Equals("") && currentOrder.specSysId.Equals("") && mesRelease.BAS.LotType.GetLotType(currentOrder.orderType).IsNeedSpec())
                {
                    messageBox.showMessageById("msgCantFindLot2", cultureLanguage.getValue("productParameter"));
                    return false;
                }

                if (currentStepParameter == null) return true;

                if (!txtInputRecipe.Text.Equals(""))
                {
                    if (!currentStepParameter.CheckRecipe(currentEqp.type, txtInputRecipe.Text))
                    {
                        messageBox.showMessageById("msgWrongInfo", lblInputRecipe.Text);
                        return false;
                    }
                }

                SetupMaterial setupMat = null;
                if (idv.mesCore.systemConfig.materialTracking && !currentStepParameter.CheckMaterial(currentEqp.type, setupInfo, ref setupMat))
                {
                    if (setupMat.position.Equals(""))
                        messageBox.showMessageById("msgWrongSetupOnTrack", setupMat.partNo, setupMat.name);
                    else
                        messageBox.showMessageById("msgWrongSetupOnTrack", setupMat.partNo, setupMat.position);

                    return false;
                }
            }
            return true;
        }
        bool checkCheckParameterTooling(idv.messageService.itemBase[] setupTooling, idv.messageService.itemBase[] remainTooling)
        {
            if (idv.mesCore.systemConfig.productParameter && idv.mesCore.systemConfig.validItem("toolingManagement"))
            {
                if (currentStepParameter == null) return true;
                List<string> lstParmTolType = new List<string>();
                foreach (EqTooling et in currentStepParameter.GetEqToolings(currentEqp.type))
                    lstParmTolType.Add(et.toolingType);
                foreach (idv.messageService.itemBase tolId in setupTooling)
                {
                    if (!currentStepParameter.CheckTooling(currentEqp.type, tolId.getPropertyInString("toolingType"), tolId.getPropertyInString("partNo")))
                    {
                        messageBox.showMessageById("msgWrongSetupTooling", tolId.getPropertyInString("partNo"), tolId.getPropertyInString("toolingType"));
                        return false;
                    }
                    lstParmTolType.Remove(tolId.getPropertyInString("toolingType"));
                }
                foreach (idv.messageService.itemBase tolId in remainTooling)
                {
                    if (!currentStepParameter.CheckTooling(currentEqp.type, tolId.getPropertyInString("toolingType"), tolId.getPropertyInString("partNo")))
                    {
                        messageBox.showMessageById("msgWrongSetupTooling", tolId.getPropertyInString("partNo"), tolId.getPropertyInString("toolingType"));
                        return false;
                    }
                    lstParmTolType.Remove(tolId.getPropertyInString("toolingType"));
                }
                if (lstParmTolType.Count > 0)
                {
                    messageBox.showMessageById("msgWrongSetupTooling", "", lstParmTolType[0]);
                    return false;
                }
            }
            return true;
        }
    }
}
