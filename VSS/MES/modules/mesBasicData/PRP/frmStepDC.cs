using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.mesCore.Controls;
using idv.utilities;
using mesRelease.PRP;

namespace mesBasicData
{
    public partial class frmStepDC : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        Step curStep = null;
        ComboBox cboInput = new ComboBox();
        bool inputNumericOnly = false;
        public frmStepDC()
        {
            InitializeComponent();
            initToolbar();
            mesListView1.columnHide = new string[] { "required", "timing", "checkFailPath", "checkSeq", "message" };
        }

        public frmStepDC(Step step)
        {
            InitializeComponent();
            actionToolbar1.addButton("OK", "");
            actionToolbar1.addButton("Exit", "");
            mesListView1.columnHide = new string[] { "modifyTarget", "attributeName", "columnName", "modifyUser", "modifyDate" };
            mesListView1.CheckBoxes = true;
            groupBox1.Visible = false;
            pnlUpDown.Visible = true;
            curStep = step;
            mesListView1.Controls.Add(cboInput);
            cboInput.Visible = false;
            cboInput.Font = mesListView1.Font;
            cboInput.BackColor = SystemColors.Info;
            cboInput.Leave += new EventHandler(cboInput_Leave);
            cboInput.DropDownClosed += new EventHandler(cboInput_DropDownClosed);
            cboInput.KeyUp += new KeyEventHandler(cboInput_KeyUp);
            cboInput.KeyPress += new KeyPressEventHandler(cboInput_KeyPress);
        }

        void cboInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (inputNumericOnly)
            {
                if ((int)e.KeyChar == 8) return;
                if (!char.IsNumber(e.KeyChar))
                    e.Handled = true;
            }
        }
        void cboInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cboInput_Leave(sender, e);
        }
        void cboInput_DropDownClosed(object sender, EventArgs e)
        {
            cboInput_Leave(sender, e);
        }
        void cboInput_Leave(object sender, EventArgs e)
        {
            if (cboInput.Tag == null) return;
            ListViewHitTestInfo hitInfo = cboInput.Tag as ListViewHitTestInfo;
            ListViewItem.ListViewSubItem subItem = cboInput.Tag as ListViewItem.ListViewSubItem;
            for (int i = 0; i < mesListView1.Columns.Count; i++)
            {
                if (hitInfo.Item.SubItems[i] == hitInfo.SubItem)
                {
                    DCItem dcItem = hitInfo.Item.Tag as DCItem;
                    if (i == mesListView1.Columns["required"].Index)
                    {
                        try
                        {
                            dcItem.required = (bool)cboInput.SelectedItem;
                            if (!dcItem.required)
                            {
                                dcItem.checkFailPath = "";
                                dcItem.checkSeq = 0;
                            }
                        }
                        catch { }
                    }
                    else if (i == mesListView1.Columns["timing"].Index)
                    {
                        try
                        {
                            dcItem.timing = (idv.mesCore.PRP.DcItemTiming)cboInput.SelectedItem;
                            if (dcItem.timing == idv.mesCore.PRP.DcItemTiming.TrackIn)
                            {
                                dcItem.checkFailPath = "";
                                dcItem.checkSeq = 0;
                            }
                        }
                        catch { }
                        
                    }
                    else if (i == mesListView1.Columns["checkFailPath"].Index)
                    {
                        dcItem.checkFailPath = cboInput.Text;
                    }
                    else if (i == mesListView1.Columns["checkSeq"].Index)
                    {
                        byte seq = 0;
                        byte.TryParse(cboInput.Text, out seq);
                        dcItem.checkSeq = seq;
                    }
                    else if (i == mesListView1.Columns["message"].Index)
                    {
                        dcItem.message = cboInput.Text.Trim();
                    }
                    mesListView1.UpdateMESItem(dcItem);
                    break;
                }
            }
            cboInput.Tag = null;
            cboInput.Visible = false;
        }

        void executeOK()
        {
            if (curStep == null) return;
            if (cboInput.Visible) cboInput.Visible = false;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("buttonOK"))) return;
            List<DCItem> list = new List<DCItem>();
            foreach (idv.messageService.itemBase item in mesListView1.selectedMESItems)
            {
                list.Add(item as DCItem);
            }
            curStep.DCItemsSet(list.ToArray());
            Hide();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Use", "");
            actionToolbar1.Items["Use"].Tag = "whereUsed";
        }

        private void frmStepDC_Load(object sender, EventArgs e)
        {
            List<string> lstNames = new List<string>();
            List<string> lstTags = new List<string>();
            lstNames.AddRange(mesListView1.columnNames);
            lstTags.AddRange(mesListView1.columnTags);
            if (frmExt != null)//維護畫面延伸功能
                idv.messageService.appModuleFunctionFormControlDefine.Init(frmExt, this, pnlExt, tblDetail, lstNames, lstTags);
            mesListView1.columnNames = lstNames.ToArray();
            mesListView1.columnTags = lstTags.ToArray();
            mesListView1.prepareColumns();
            pnlExt.AutoSize = true;
            initData();
            if (curStep != null)
            {
                int i = 0;
                foreach (DCItem d in curStep.DCItemsGet())
                {
                    ListViewItem item = mesListView1.Items[d.sysid];
                    if (item != null)
                    {
                        mesListView1.Items.Remove(item);
                        mesListView1.Items.Insert(i, item);
                        item.Checked = true;
                        mesListView1.UpdateMESItem(d);
                        i++;
                    }
                }
                cultureLanguage.switchLanguage(this);
                mesListView1.Columns["message"].Width = -1;
                if (mesListView1.Columns["message"].Width < 120) mesListView1.Columns["message"].Width = 120;
            }
        }

        private void frmStepDC_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        void initData()
        {
            mesListView1.ShowMESItems(DCItem.getDCItems());
            showDCItemDetail(false);
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
                case "Clear":
                    executeClear();
                    break;
                case "OK":
                    executeOK();
                    break;
                case "Use":
                    executeWhereUse();
                    break;
                case "Exit":
                    Hide();
                    break;
            }
        }
        idv.mesCore.DataType ControlDataType
        {
            get
            {
                if (rdoString.Checked)
                    return idv.mesCore.DataType.String;
                else if (rdoNumber.Checked)
                    return idv.mesCore.DataType.Numeric;
                else
                    return idv.mesCore.DataType.Options;
            }
            set
            {
                if (value == idv.mesCore.DataType.String)
                    rdoString.Checked = true;
                else if (value == idv.mesCore.DataType.Numeric)
                    rdoNumber.Checked = true;
                else
                    rdoOptions.Checked = true;
            }
        }
        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                executeClear();
            }
            else
            {
                showDCItemDetail(false);
            }  
        }
        void showDCItemDetail(bool callByRadioEvent)
        {
            DCItem d = mesListView1.selectedMESItem as DCItem;
            if (d != null)
            {
                txtDCItem.Text = d.name;
                ControlDataType = d.dataType;
                txtLength.Text = d.length.ToString();
                chkEnabled.Checked = d.enabled;
                chkVisible.Checked = d.visible;
                cboModifyTarget.Text = d.modifyTarget;
                cboAttributeName.Text = d.attributeName;
                txtColumnName.Text = d.columnName;
                cboAssignFrom.Text = d.assignFrom;
                cboAssignAttribute.Text = d.assignAttribute;
                cboCompareTo.Text = d.compareTo;
                cboCompareAttribute.Text = d.compareAttribute;
                cboOperator.Text = d.compareOperator;
                txtDescription.Text = d.description;
                txtAssemblyName.Text = d.compareTo;
                txtSourceDB.Text = d.compareSourceDB;
                txtSourceSql.Text = d.compareValue;
                txtTargetDB.Text = d.compareToDB;
                txtTargetSql.Text = d.compareToValue;
                txtOptions.Text = d.optionList;
                compareTypeChangeEventFlag = false;
                if (!callByRadioEvent)
                {
                    if (d.compareType == idv.mesCore.PRP.DcItemCompareType.NoCompare)
                        rdoNone.Checked = true;
                    else if (d.compareType == idv.mesCore.PRP.DcItemCompareType.BySetting)
                        rdoBySetting.Checked = true;
                    else if (d.compareType == idv.mesCore.PRP.DcItemCompareType.CustomExtension)
                        rdoCustom.Checked = true;
                }
                compareTypeChangeEventFlag = true;
                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(d);
            }
            cboOperator.Enabled = true;
            txtAssemblyName.Enabled = true;
            txtSourceDB.Enabled = true;
            txtSourceSql.Enabled = true;
            cboCompareTo.Enabled = true;
            cboCompareAttribute.Enabled = true;
            txtTargetDB.Enabled = true;
            txtTargetSql.Enabled = true;
            if (rdoNone.Checked)
            {
                cboOperator.SelectedIndex = -1;
                cboOperator.Enabled = false;
                txtAssemblyName.Text = "";
                txtAssemblyName.Enabled = false;
                txtSourceDB.Text = "";
                txtSourceDB.Enabled = false;
                txtSourceSql.Text = "";
                txtSourceSql.Enabled = false;
                cboCompareTo.SelectedIndex = -1;
                cboCompareTo.Enabled = false;
                cboCompareAttribute.SelectedIndex = -1;
                cboCompareAttribute.Enabled = false;
                txtTargetDB.Text = "";
                txtTargetDB.Enabled = false;
                txtTargetSql.Text = "";
                txtTargetSql.Enabled = false;
            }
            else if (rdoBySetting.Checked)
            {
                txtAssemblyName.Text = "";
                txtAssemblyName.Enabled = false;
            }
            else if (rdoCustom.Checked)
            {
                txtSourceDB.Text = "";
                txtSourceDB.Enabled = false;
                txtSourceSql.Text = "";
                txtSourceSql.Enabled = false;
                cboCompareTo.SelectedIndex = -1;
                cboCompareTo.Enabled = false;
                cboCompareAttribute.SelectedIndex = -1;
                cboCompareAttribute.Enabled = false;
                txtTargetDB.Text = "";
                txtTargetDB.Enabled = false;
                txtTargetSql.Text = "";
                txtTargetSql.Enabled = false;
            }
        }
        bool compareTypeChangeEventFlag = true;
        private void CompareTypeChange(object sender, EventArgs e)
        {
            if (!compareTypeChangeEventFlag) return;
            showDCItemDetail(true);
        }

        void executeClear()
        {
            txtDCItem.Text = "";
            rdoString.Checked = true;
            txtLength.Text = "";
            chkEnabled.Checked = true;
            chkVisible.Checked = true;
            cboModifyTarget.Text = "";
            cboAttributeName.Text = "";
            txtColumnName.Text = "";
            cboAssignFrom.Text = "";
            cboAssignAttribute.Text = "";
            cboCompareTo.Text = "";
            cboCompareAttribute.Text = "";
            cboOperator.Text = "";
            txtDescription.Text = "";
            txtAssemblyName.Text = "";
            txtSourceDB.Text = "";
            txtSourceSql.Text = "";
            txtTargetDB.Text = "";
            txtTargetSql.Text = "";
            txtOptions.Text = "";
            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtDCItem, lblDCItem, txtLength, lblLength)) return;
            if (rdoCustom.Checked && txtAssemblyName.Text.Trim().Equals(""))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", lblAssemblyName.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (ControlDataType == idv.mesCore.DataType.Options && txtOptions.Text.Trim().Equals(""))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", rdoOptions.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                DCItem item = new DCItem();
                item.name = txtDCItem.Text;
                item.dataType = ControlDataType;
                item.length = Convert.ToInt32(txtLength.Text);
                item.enabled = chkEnabled.Checked;
                item.visible = chkVisible.Checked;
                item.modifyTarget = cboModifyTarget.Text;
                item.attributeName = cboAttributeName.Text;
                item.columnName = txtColumnName.Text;
                item.assignFrom = cboAssignFrom.Text;
                item.assignAttribute = cboAssignAttribute.Text;
                item.compareTo = cboCompareTo.Text;
                item.compareAttribute = cboCompareAttribute.Text;
                item.compareOperator = cboOperator.Text;
                item.description = txtDescription.Text;
                item.compareSourceDB = txtSourceDB.Text;
                item.compareValue = txtSourceSql.Text;
                item.compareToDB = txtTargetDB.Text;
                item.compareToValue = txtTargetSql.Text;
                item.optionList = txtOptions.Text;
                if (rdoNone.Checked)
                    item.compareType = idv.mesCore.PRP.DcItemCompareType.NoCompare;
                else if (rdoBySetting.Checked)
                    item.compareType = idv.mesCore.PRP.DcItemCompareType.BySetting;
                else if (rdoCustom.Checked)
                {
                    item.compareType = idv.mesCore.PRP.DcItemCompareType.CustomExtension;
                    item.compareTo = txtAssemblyName.Text;
                }
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(txtDCItem, lblDCItem, txtLength, lblLength))
                return;
            if (rdoCustom.Checked && txtAssemblyName.Text.Trim().Equals(""))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", lblAssemblyName.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (ControlDataType == idv.mesCore.DataType.Options && txtOptions.Text.Trim().Equals(""))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", rdoOptions.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            DCItem item = mesListView1.selectedMESItem as DCItem;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                item.name = txtDCItem.Text;
                item.dataType = ControlDataType;
                item.length = Convert.ToInt32(txtLength.Text);
                item.enabled = chkEnabled.Checked;
                item.visible = chkVisible.Checked;
                item.modifyTarget = cboModifyTarget.Text;
                item.attributeName = cboAttributeName.Text;
                item.columnName = txtColumnName.Text;
                item.assignFrom = cboAssignFrom.Text;
                item.assignAttribute = cboAssignAttribute.Text;
                item.compareTo = cboCompareTo.Text;
                item.compareAttribute = cboCompareAttribute.Text;
                item.compareOperator = cboOperator.Text;
                item.description = txtDescription.Text;
                item.compareSourceDB = txtSourceDB.Text;
                item.compareValue = txtSourceSql.Text;
                item.compareToDB = txtTargetDB.Text;
                item.compareToValue = txtTargetSql.Text;
                item.optionList = txtOptions.Text;
                if (rdoNone.Checked)
                    item.compareType = idv.mesCore.PRP.DcItemCompareType.NoCompare;
                else if (rdoBySetting.Checked)
                    item.compareType = idv.mesCore.PRP.DcItemCompareType.BySetting;
                else if (rdoCustom.Checked)
                {
                    item.compareType = idv.mesCore.PRP.DcItemCompareType.CustomExtension;
                    item.compareTo = txtAssemblyName.Text;
                }
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            DCItem item = mesListView1.selectedMESItem as DCItem;
            try
            {
                item.Delete();
                mesListView1.RemoveMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeWhereUse()
        {
            DCItem d = mesListView1.selectedMESItem as DCItem;
            if (d == null) return;
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter("select step_id from mes_prp_step_dc_link where dc_item_sysid=?", d.sysid);
            List<string> list = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
                list.Add(row["step_id"].ToString());
            frmWhereUsed.ShowWhereUsed(list.ToArray());
        }
        
        private void HanlderNumericOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void HandlerSendKeyTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as Control).Text.Length > 0)
                    SendKeys.Send("{TAB}");
            }
        }

        private void mesListView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (curStep == null) return;
                ListViewHitTestInfo hitInfo = mesListView1.HitTest(e.Location);
                if (hitInfo == null || hitInfo.Item == null) return;
                if (!hitInfo.Item.Checked) return;
                DCItem selDcItem = hitInfo.Item.Tag as DCItem;
                for (int i = 0; i < mesListView1.Columns.Count; i++)
                {
                    if (hitInfo.Item.SubItems[i] == hitInfo.SubItem)
                    {
                        cboInput.Items.Clear();
                        if (i == mesListView1.Columns["required"].Index)
                        {
                            cboInput.DropDownStyle = ComboBoxStyle.DropDownList;
                            cboInput.Items.Add(true);
                            cboInput.Items.Add(false);
                            cboInput.Text = hitInfo.SubItem.Text;
                            cboInput.Bounds = new Rectangle(hitInfo.SubItem.Bounds.Left - 1, hitInfo.SubItem.Bounds.Top - 2, hitInfo.SubItem.Bounds.Width + 2, hitInfo.SubItem.Bounds.Height + 1);
                            cboInput.Tag = hitInfo;
                            cboInput.Visible = true;
                            cboInput.Focus();
                            cboInput.DroppedDown = true;
                        }
                        else if (i == mesListView1.Columns["timing"].Index)
                        {
                            cboInput.DropDownStyle = ComboBoxStyle.DropDownList;
                            cboInput.Items.Add(idv.mesCore.PRP.DcItemTiming.TrackIn);
                            cboInput.Items.Add(idv.mesCore.PRP.DcItemTiming.TrackOut);
                            cboInput.Items.Add(idv.mesCore.PRP.DcItemTiming.Both);
                            cboInput.Text = hitInfo.SubItem.Text;
                            cboInput.Bounds = new Rectangle(hitInfo.SubItem.Bounds.Left - 1, hitInfo.SubItem.Bounds.Top - 2, hitInfo.SubItem.Bounds.Width + 2, hitInfo.SubItem.Bounds.Height + 1);
                            cboInput.Tag = hitInfo;
                            cboInput.Visible = true;
                            cboInput.Focus();
                            cboInput.DroppedDown = true;
                        }
                        else if (i == mesListView1.Columns["checkFailPath"].Index)
                        {
                            if (!selDcItem.required || selDcItem.timing == idv.mesCore.PRP.DcItemTiming.TrackIn) break;
                            cboInput.DropDownStyle = ComboBoxStyle.Simple;
                            inputNumericOnly = false;
                            cboInput.MaxLength = 40;
                            cboInput.Text = hitInfo.SubItem.Text;
                            cboInput.Bounds = new Rectangle(hitInfo.SubItem.Bounds.Left - 1, hitInfo.SubItem.Bounds.Top - 2, hitInfo.SubItem.Bounds.Width + 2, hitInfo.SubItem.Bounds.Height + 1);
                            cboInput.Tag = hitInfo;
                            cboInput.Visible = true;
                            cboInput.Focus();
                            cboInput.SelectAll();
                        }
                        else if (i == mesListView1.Columns["checkSeq"].Index)
                        {
                            if (!selDcItem.required || selDcItem.timing == idv.mesCore.PRP.DcItemTiming.TrackIn) break;
                            cboInput.DropDownStyle = ComboBoxStyle.Simple;
                            inputNumericOnly = true;
                            cboInput.MaxLength = 2;
                            cboInput.Text = hitInfo.SubItem.Text;
                            cboInput.Bounds = new Rectangle(hitInfo.SubItem.Bounds.Left - 1, hitInfo.SubItem.Bounds.Top - 2, hitInfo.SubItem.Bounds.Width + 2, hitInfo.SubItem.Bounds.Height + 1);
                            cboInput.Tag = hitInfo;
                            cboInput.Visible = true;
                            cboInput.Focus();
                            cboInput.SelectAll();
                        }
                        else if (i == mesListView1.Columns["message"].Index)
                        {
                            cboInput.DropDownStyle = ComboBoxStyle.Simple;
                            inputNumericOnly = false;
                            cboInput.MaxLength = 100;
                            cboInput.Text = hitInfo.SubItem.Text;
                            cboInput.Bounds = new Rectangle(hitInfo.SubItem.Bounds.Left - 1, hitInfo.SubItem.Bounds.Top - 2, hitInfo.SubItem.Bounds.Width + 2, hitInfo.SubItem.Bounds.Height + 1);
                            cboInput.Tag = hitInfo;
                            cboInput.Visible = true;
                            cboInput.Focus();
                            cboInput.SelectAll();
                        }
                        break;
                    }
                }
            }
            catch { }
        }

        private void cboModifyTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtColumnName.Text = "";
            cboAttributeName.Text = "";
            cboAttributeName.Items.Clear();
            cboAttributeName.Items.Add("");
            if (cboModifyTarget.Text.Equals("Lot"))
            {
                mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot();
                foreach (System.Reflection.PropertyInfo proInfo in lot.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Lot") || proInfo.DeclaringType.Name.Equals("lotBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboAttributeName.Items.Add(proInfo.Name);
                    //}
                }
            }
            else if (cboModifyTarget.Text.Equals("Equipment"))
            {
                mesRelease.EQP.Equipment eqp = new mesRelease.EQP.Equipment();
                foreach (System.Reflection.PropertyInfo proInfo in eqp.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Equipment") || proInfo.DeclaringType.Name.Equals("equipmentBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboAttributeName.Items.Add(proInfo.Name);
                    //}
                }
            }
        }

        private void cboAssignFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAssignAttribute.Text = "";
            cboAssignAttribute.Items.Clear();
            cboAssignAttribute.Items.Add("");
            if (cboAssignFrom.Text.Equals("Lot"))
            {
                mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot();
                foreach (System.Reflection.PropertyInfo proInfo in lot.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Lot") || proInfo.DeclaringType.Name.Equals("lotBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboAssignAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
            else if (cboAssignFrom.Text.Equals("Equipment"))
            {
                mesRelease.EQP.Equipment eqp = new mesRelease.EQP.Equipment();
                foreach (System.Reflection.PropertyInfo proInfo in eqp.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Equipment") || proInfo.DeclaringType.Name.Equals("equipmentBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboAssignAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
            else if (cboAssignFrom.Text.Equals("Step"))
            {
                Step step = new Step();
                foreach (System.Reflection.PropertyInfo proInfo in step.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Equipment") || proInfo.DeclaringType.Name.Equals("equipmentBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboAssignAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
            else if (cboAssignFrom.Text.Equals("WorkOrder"))
            {
                mesRelease.WIP.WorkOrder order = new mesRelease.WIP.WorkOrder();
                foreach (System.Reflection.PropertyInfo proInfo in order.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("WorkOrder") || proInfo.DeclaringType.Name.Equals("workOrderBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboAssignAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
        }

        private void cboCompareTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCompareAttribute.Text = "";
            cboCompareAttribute.Items.Clear();
            cboCompareAttribute.Items.Add("");
            if (cboCompareTo.Text.Equals("Lot"))
            {
                mesRelease.WIP.Lot lot = new mesRelease.WIP.Lot();
                foreach (System.Reflection.PropertyInfo proInfo in lot.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Lot") || proInfo.DeclaringType.Name.Equals("lotBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboCompareAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
            else if (cboCompareTo.Text.Equals("Equipment"))
            {
                mesRelease.EQP.Equipment eqp = new mesRelease.EQP.Equipment();
                foreach (System.Reflection.PropertyInfo proInfo in eqp.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Equipment") || proInfo.DeclaringType.Name.Equals("equipmentBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboCompareAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
            else if (cboCompareTo.Text.Equals("Step"))
            {
                Step step = new Step();
                foreach (System.Reflection.PropertyInfo proInfo in step.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("Equipment") || proInfo.DeclaringType.Name.Equals("equipmentBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboCompareAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
            else if (cboCompareTo.Text.Equals("WorkOrder"))
            {
                mesRelease.WIP.WorkOrder order = new mesRelease.WIP.WorkOrder();
                foreach (System.Reflection.PropertyInfo proInfo in order.GetType().GetProperties())
                {
                    //if (proInfo.DeclaringType.Name.Equals("WorkOrder") || proInfo.DeclaringType.Name.Equals("workOrderBase"))
                    //{
                        if ((proInfo.PropertyType.IsValueType || proInfo.PropertyType.Equals(typeof(string))) && proInfo.CanWrite)
                            cboCompareAttribute.Items.Add(proInfo.Name);
                    //}
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (mesListView1.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = mesListView1.SelectedItems[0];
            i = item.Index - 1;
            if (i < 0) return;
            mesListView1.Items.Remove(item);
            mesListView1.Items.Insert(i, item);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (mesListView1.SelectedItems.Count == 0) return;
            int i = 0;
            ListViewItem item = mesListView1.SelectedItems[0];
            i = item.Index + 1;
            if (i >= mesListView1.Items.Count) return;
            mesListView1.Items.Remove(item);
            mesListView1.Items.Insert(i, item);
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            txtOptions.Enabled = rdoOptions.Checked;
            if (txtOptions.Enabled)
                txtOptions.BackColor = SystemColors.Info;
            else
                txtOptions.BackColor = SystemColors.Control;
        }
    }
}
