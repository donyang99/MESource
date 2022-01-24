using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.utilities;
using idv.mesCore.Controls;
using mesRelease.TOL;


namespace toolingFunction
{
    public partial class frmToolingType : Form, idv.messageService.appModuleFunctionForm
    {   //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }

        ToolingType curItem = null;
        public frmToolingType()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void frmToolingType_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmEquipmentType", Name))
            {
                Type tt = Type.GetType("mesRelease.EQP.EqType, mesRelease");
                object returnValue = tt.BaseType.InvokeMember("GetEqTypes", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static |
                                       System.Reflection.BindingFlags.InvokeMethod, null, null, new object[] { "" });
                if (returnValue is Array)
                {
                    lvwEqType.ShowMESItems(returnValue as idv.messageService.itemBase[]);
                    if (curItem != null)
                        lvwEqType.CheckMESItems(curItem.eqTypeList.ToArray());
                }
            }
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query                        
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.Items["Query"].Visible = false;
            //actionToolbar1.addButton("Import", "ADD");//Import privilege is the same as Add privilege
            //actionToolbar1.addButton("Export", "");
        }
        private void frmToolingType_Load(object sender, EventArgs e)
        {
            initToolbar();
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

            cboControlType.Items.AddRange(Enum.GetNames(typeof(idv.mesCore.TOL.ControlType)));
            cboCounterType.Items.AddRange(Enum.GetNames(typeof(idv.mesCore.TOL.ConsumeType)));

            lvwEqType.prepareColumns();
            executeQuery();
        }

        private void frmToolingType_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmExt != null)//維護畫面延伸功能
                frmExt.Exit(this);
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            appInstance.showInformation("");
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
                    executeShowData(null);
                    break;
            }
        }

        void executeShowData(ToolingType item)
        {
            if (item == null)
            {
                txtToolingType.Text = "";
                cboControlType.SelectedIndex = -1;
                cboCounterType.SelectedIndex = -1;
                chkRunTimeFlag.Checked = false;
                chkVerify.Checked = true;
                txtOwnDept.Text = "";
                txtDescription.Text = "";
                lvwEqType.UnCheckAllItems();

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ClearData();
            }
            else
            {
                txtToolingType.Text = item.name;
                cboCounterType.SelectedIndex = (int)item.consumeType;
                cboControlType.SelectedIndex = (int)item.controlType;
                chkRunTimeFlag.Checked = item.runTimeFlag;
                chkVerify.Checked = item.verifyFlag;
                txtOwnDept.Text = item.ownerDept;
                txtDescription.Text = item.description;
                lvwEqType.CheckMESItems(item.eqTypeList.ToArray());

                if (frmExt != null)//維護畫面延伸功能
                    frmExt.ShowData(item);
            }
        }

        void executeQuery()
        {
            mesListView1.ShowMESItems(ToolingType.GetToolingTypes());
        }

        List<string> lstEqTypeChanged = new List<string>();//異動的EqType要更新EqType的modifyDate
        void assignValues(ToolingType item)
        {
            item.controlType = (idv.mesCore.TOL.ControlType)cboControlType.SelectedIndex;
            if (cboCounterType.SelectedIndex >= 0)
                item.consumeType = (idv.mesCore.TOL.ConsumeType)cboCounterType.SelectedIndex;
            item.runTimeFlag = chkRunTimeFlag.Checked;
            item.verifyFlag = chkVerify.Checked;
            item.ownerDept = txtOwnDept.Text;
            item.description = txtDescription.Text;
            item.modifyUser = idv.mesCore.USR.userBase.loginUserId;

            lstEqTypeChanged.Clear();
            lstEqTypeChanged.AddRange(item.eqTypeList.ToArray());//for異動的EqType要更新

            item.eqTypeList.Clear();
            foreach (idv.messageService.itemBase eqType in lvwEqType.selectedMESItems)
            {
                item.eqTypeList.Add(eqType.name);

                //for異動的EqType要更新
                if (lstEqTypeChanged.Contains(eqType.name))
                    lstEqTypeChanged.Remove(eqType.name);
                else
                    lstEqTypeChanged.Add(eqType.name);
            }

            if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
        }
        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtToolingType, lblToolingType, cboControlType, lblControlType)) return;
            if (cboControlType.Text.Equals("Count") && (cboCounterType.Text.Equals("") || cboCounterType.Text.Equals("None")))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", lblCounterType.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                ToolingType item = new ToolingType();
                item.retrieveEqType();
                item.name = txtToolingType.Text;
                assignValues(item);
                item.createUser = idv.mesCore.USR.userBase.loginUserId;
                item.createDate = idv.messageService.serviceHost.dateTime;

                item.New();
                mesListView1.UpdateMESItem(item);

                updateEqTypeModifyDate();

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
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!appInstance.CheckInputData(txtToolingType, lblToolingType, cboControlType, lblControlType)) return;
            if (cboControlType.Text.Equals("Count") && (cboCounterType.Text.Equals("") || cboCounterType.Text.Equals("None")))
            {
                appInstance.showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", lblCounterType.Text),
                    idv.mesCore.Controls.informationType.warn);
                return;
            }
            if (frmExt != null && !frmExt.CheckData("modify", curItem)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                assignValues(curItem);
                curItem.Modify();
                mesListView1.UpdateMESItem(curItem);

                updateEqTypeModifyDate();

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (curItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;

            //for異動的EqType要更新
            lstEqTypeChanged.Clear();
            lstEqTypeChanged.AddRange(curItem.eqTypeList.ToArray());

            try
            {
                curItem.modifyUser = idv.mesCore.USR.userBase.loginUserId;
                curItem.Delete();
                mesListView1.RemoveMESItem(curItem);

                updateEqTypeModifyDate();

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void updateEqTypeModifyDate()
        {
            if (lstEqTypeChanged.Count == 0) return;
            try
            {
                List<idv.messageService.sql.sqlTable> lstTable = new List<idv.messageService.sql.sqlTable>();
                foreach (string s in lstEqTypeChanged)
                {
                    idv.messageService.sql.sqlTable t = new idv.messageService.sql.sqlTable("mes_eqp_type", idv.messageService.sql.eDMLtype.Update);
                    t.Add("modify_date", DateTime.Now);
                    t.WhereClause.Add("eq_type", s);
                    t.ignoreError = true;
                    lstTable.Add(t);
                }
                idv.messageService.sql.sqlExecuter.executeSqlTables(lstTable, idv.messageService.serviceHost.Client);
            }
            catch { }
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                curItem = null;
                executeShowData(null);
            }
            else
            {
                curItem = item as ToolingType;
                curItem.retrieveEqType();
                executeShowData(curItem);
            }
        }

        private void cboControlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCounterType.Enabled = cboControlType.Text.Equals("Count");
            lblCounterType.Enabled = cboCounterType.Visible;
            if (!cboCounterType.Enabled) cboCounterType.Text = "None";
            if (cboControlType.Text.Equals("None"))
            {
                chkRunTimeFlag.Enabled = false;
                chkRunTimeFlag.Checked = false;
            }
            else
            {
                chkRunTimeFlag.Enabled = true;
                if (curItem != null)
                    chkRunTimeFlag.Checked = curItem.runTimeFlag;
            }
        }
    }
}
