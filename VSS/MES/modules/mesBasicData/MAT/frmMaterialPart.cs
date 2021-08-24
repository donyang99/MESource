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
using mesRelease.MAT;

namespace mesBasicData
{
    public partial class frmMaterialPart : Form, idv.messageService.appModuleFunctionForm
    {
        //維護畫面延伸功能
        idv.messageService.appModuleFunctionFormExt frmExt = null;
        public void SetExtForm(idv.messageService.appModuleFunctionFormExt extForm)
        {
            frmExt = extForm;
        }
        public frmMaterialPart()
        {
            InitializeComponent();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Import", "ADD");
            actionToolbar1.addButton("Export", "");
        }

        private void frmMaterialPart_Load(object sender, EventArgs e)
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
        }

        private void frmMaterialPart_FormClosed(object sender, FormClosedEventArgs e)
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
                    executeClear();
                    break;
                case "Import":
                    executeImport();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        private void mesListView1_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if(!selected)
            {
                executeClear();
            }
            else
            {
                MaterialPart m = item as MaterialPart;
                if(m != null)
                {
                    txtMaterialPart.Text = m.name;
                    cboMaterialType.Text = m.materialType;
                    txtDescription.Text = m.description;

                    if (frmExt != null)//維護畫面延伸功能
                        frmExt.ShowData(m);
                }
            }   
        }

        void executeClear()
        {
            txtMaterialPart.Text = "";
            cboMaterialType.Text = "";
            txtDescription.Text = "";

            if (frmExt != null)//維護畫面延伸功能
                frmExt.ClearData();
        }

        void executeQuery()
        {
            string condition = "";
            if(txtMaterialPart.Text.Trim() != "")
                condition = "part_no like '%" + txtMaterialPart.Text.Trim() + "%'";
            if(cboMaterialType.Text != "")
            {
                if(condition != "") condition += " and ";
                condition += "material_type='" + cboMaterialType.Text + "'";
            }
            MaterialPart[] items = MaterialPart.GetMaterialParts(condition);
            mesListView1.ShowMESItems(items);    
        }

        void executeAdd()
        {
            if(!appInstance.CheckInputData(txtMaterialPart, lblMaterialPart, cboMaterialType, lblMaterialType)) return;
            if (frmExt != null && !frmExt.CheckData("add", null)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                MaterialPart item = new MaterialPart();
                item.name = txtMaterialPart.Text;
                item.materialType = cboMaterialType.Text;
                item.description = txtDescription.Text;
                item.createUser = mesRelease.USR.User.loginUser.name;
                item.createDate = DateTime.Now;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.New();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch(Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            if(mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if(!appInstance.CheckInputData(txtMaterialPart, lblMaterialPart, cboMaterialType, lblMaterialType))
                return;

            MaterialPart item = mesListView1.selectedMESItem as MaterialPart;
            if (frmExt != null && !frmExt.CheckData("modify", item)) return;//維護畫面延伸功能
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                item.name = txtMaterialPart.Text;
                item.materialType = cboMaterialType.Text;
                item.description = txtDescription.Text;
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                if (frmExt != null) frmExt.AssignValue(item);//維護畫面延伸功能
                item.Modify();
                mesListView1.UpdateMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch(Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if(mesListView1.selectedMESItem == null)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if(!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            MaterialPart item = mesListView1.selectedMESItem as MaterialPart;
            try
            {
                item.modifyUser = mesRelease.USR.User.loginUser.name;
                item.Delete();
                mesListView1.RemoveMESItem(item);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch(Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeImport()
        {
            bool allSucceed = true;
            DataTable table = mesRelease.utilities.ExcelAgent.ImpportSelectExcel();
            List<string> columns = new List<string>();
            columns.AddRange("PartNo,MaterialType,Description".Split(','));
            foreach (DataColumn col in table.Columns)
                columns.Remove(col.ColumnName);
            if (columns.Count > 0)
            {
                appInstance.showInformationById("invalidFormat", informationType.warn);
                return;
            }
            bool makeSureItemVisible = mesListView1.makesureNewItemVisible;
            mesListView1.makesureNewItemVisible = false;

            foreach (DataRow row in table.Rows)
            {
                try
                {
                    MaterialPart item = new MaterialPart();
                    item.name = row["PartNo"].ToString();
                    item.materialType = row["MaterialType"].ToString();
                    item.description = row["Description"].ToString();
                    item.createUser = mesRelease.USR.User.loginUser.name;
                    item.createDate = DateTime.Now;

                    if (!cboMaterialType.Items.Contains(item.materialType))
                        throw new Exception("Can't Find MaterialType - " + item.materialType);

                    item.New();
                    mesListView1.UpdateMESItem(item);
                }
                catch (Exception ex)
                {
                    allSucceed = false;
                    messageBox.showMessage(ex.Message, messageStyle.error);
                    break;
                }
            }
            if (allSucceed)
                messageBox.showMessageById("msgExecuteSucceed");

            mesListView1.makesureNewItemVisible = makeSureItemVisible;
        }

        void executeImport2()
        {
            bool succeed = false;
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "excel(*.xls)|*.xls";
            ofg.ShowDialog();
            if(ofg.FileName == "") return;
            
            bool makeSureItemVisible = mesListView1.makesureNewItemVisible;
            mesListView1.makesureNewItemVisible = false;

            using(System.IO.TextReader reader = new System.IO.StreamReader(ofg.FileName, Encoding.Default))
            {
                bool check = false;
                mesListView1.RemoveAllMESItems();
                do
                {
                    string s = reader.ReadLine();
                    if(s == null) break;
                    if(!check)
                    {
                        if(!s.ToUpper().StartsWith("PartNo\tMaterialType".ToUpper()))
                        {
                            appInstance.showInformationById("invalidFormat", informationType.warn);
                            break;
                        }
                        check = true;
                        succeed = true;
                    }
                    else
                    {
                        string[] rea = s.Split('\t');
                        try
                        {
                            MaterialPart item = new MaterialPart();
                            item.name = rea[0];
                            item.materialType = rea[1];
                            item.description = rea[2];
                            item.createUser = mesRelease.USR.User.loginUser.name;
                            item.createDate = DateTime.Now;

                            if(!cboMaterialType.Items.Contains(item.materialType))
                                throw new Exception("Can't Find MaterialType - " + item.materialType);

                            item.New();   
                            mesListView1.UpdateMESItem(item);
                        }
                        catch(Exception ex)
                        {
                            succeed = false;
                            appInstance.showInformation(ex.Message, informationType.error);
                            break;
                        }
                    }
                } while(true);
            }
            if(succeed)
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);

            mesListView1.makesureNewItemVisible = makeSureItemVisible;
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if(mesRelease.utilities.ExcelAgent.WriteToFile(mesListView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        private void frmMaterialPart_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmMaterialType", Name))
            {
                string orgType = cboMaterialType.Text;
                cboMaterialType.Items.Clear();
                cboMaterialType.Items.Add("");
                cboMaterialType.Items.AddRange(idv.mesCore.misc.MaterialTypeGet());
                if(!orgType.Equals(""))
                    cboMaterialType.Text = orgType;
            }
            if (frmExt != null)//維護畫面延伸功能
                frmExt.EventNotice("frmMaterialPart_Activated", null);
        }
    }
}
