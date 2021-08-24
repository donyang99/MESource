using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace mesBasicData
{
    public partial class frmProductSpecQuery : Form
    {
        Dictionary<string, short> parmSteps = null;
        mesRelease.PRP.Product curProduct = null;
        volatile mesRelease.PRP.Route curRoute = null;
        volatile mesRelease.PARM.ProductSpec curSpec = null;

        public frmProductSpecQuery()
        {
            InitializeComponent();
            lvwProduct.prepareColumns();
            lvwSpec.prepareColumns();
            lvwRoute.prepareColumns();
            lvwStep.prepareColumns();
            initData();
            idv.utilities.misc.SetValueChangeByUseItem(Name);
        }
        void initData()
        {            
            parmSteps = mesRelease.PARM.StepParameter.GetParameteredSteps();
            if (mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToOrder)
            {
                cboOrderId.DropDownStyle = ComboBoxStyle.Simple;
                lvwSpec.Visible = false;
                pnlProductSpec.AutoSize = true;
            }
            else
            {
                tblOrderId.Visible = false;
            }
        }

        private void lvwProduct_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                curSpec = null;
                curRoute = null;
                curProduct = null;
                if (mesRelease.PARM.ProductSpec.productSpecSetting != idv.mesCore.PARM.productSpecType.specEqualsToOrder)
                    lvwSpec.RemoveAllMESItems();
                lvwRoute.RemoveAllMESItems();
            }
            else
            {
                curProduct = item as mesRelease.PRP.Product;
                showProductInfo();
            }
        }

        private void cboOrderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnGetOrderSpec.PerformClick();
        }
        private void btnGetOrderSpec_Click(object sender, EventArgs e)
        {
            if (cboOrderId.Text.Trim().Equals("")) return;
            lvwSpec.RemoveAllMESItems();
            mesRelease.PARM.ProductSpec spec = mesRelease.PARM.ProductSpec.GetSpecByName(cboOrderId.Text.Trim());
            if (spec != null)
            {
                spec.retrieveStepSpecs();
                lvwSpec.ShowMESItems(new mesRelease.PARM.ProductSpec[] { spec });
                if (lvwSpec.Items.Count == 1)
                    lvwSpec.Items[0].Selected = true;
            }
        }

        void showProductInfo()
        {
            if (curProduct == null) return;
            curProduct = new mesRelease.PRP.Product(curProduct.name);//取得最新產品(及可用流程)
               
            if(mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specEqualsToProduct)
            {
                mesRelease.PARM.ProductSpec spec = mesRelease.PARM.ProductSpec.GetSpecByName(curProduct.name);
                if (spec != null)
                {
                    spec.retrieveStepSpecs();
                    lvwSpec.ShowMESItems(new mesRelease.PARM.ProductSpec[] { spec });
                }
            }
            else if (mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.productSelectSpec ||
                     mesRelease.PARM.ProductSpec.productSpecSetting == idv.mesCore.PARM.productSpecType.specSelectProduct)
            {
                lvwSpec.ShowMESItems(mesRelease.PARM.ProductSpec.GetProductSpec(curProduct.name));
            }
            curProduct.retrieveRoutes();
            lvwRoute.ShowMESItems(curProduct.Items.ToArray());
            if (lvwSpec.Items.Count == 1)
                lvwSpec.Items[0].Selected = true;
            if (lvwRoute.Items.Count == 1)
                lvwRoute.Items[0].Selected = true;
        }

        private void lvwSpec_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                curSpec = null;
                lvwSpecDetail.Items.Clear();
                lvwSpecDetail.Groups.Clear();
            }
            else
            {
                curSpec = item as mesRelease.PARM.ProductSpec;
                if (curRoute == null) return;
                Thread t = new Thread(new ThreadStart(showStepParameter));
                t.Start();
            }
        }

        private void lvwRoute_MESItemSelectionChanged(idv.messageService.itemBase item, ListViewItem listItem, bool selected)
        {
            if (!selected)
            {
                curRoute = null;
                lvwSpecDetail.Items.Clear();
                lvwSpecDetail.Groups.Clear();
                lvwStep.RemoveAllMESItems();
            }
            else
            {
                curRoute = item as mesRelease.PRP.Route;
                if (curSpec == null) return;
                Thread t = new Thread(new ThreadStart(showStepParameter));
                t.Start();
            }           
        }

        object lockObj = new object();
        void showStepParameter()
        {
            lock (lockObj)
            {
                Cursor = Cursors.WaitCursor;
                if (curRoute == null)
                    return;
                try
                {
                    lvwStep.Hide();
                    curRoute.retrieveNodes();
                    List<mesRelease.PRP.Step> otherSteps = new List<mesRelease.PRP.Step>();
                    Dictionary<string, mesRelease.PRP.Step> dicStep = new Dictionary<string, mesRelease.PRP.Step>();
                    foreach (mesRelease.PRP.Step s in curRoute.GetMainSteps(otherSteps))
                    {
                        if (dicStep.ContainsKey(s.name)) continue;
                        dicStep[s.name] = s;
                    }
                    foreach (mesRelease.PRP.Step s in otherSteps)
                    {
                        if (dicStep.ContainsKey(s.name)) continue;
                        dicStep[s.name] = s;
                    }
                    List<mesRelease.PRP.Step> list = new List<mesRelease.PRP.Step>();
                    foreach (KeyValuePair<string, mesRelease.PRP.Step> kv in dicStep)
                    {
                        kv.Value.version = 0;//當成站點設定參數的數量
                        kv.Value.fab = "";//當成標準工時
                        if (parmSteps.ContainsKey(kv.Value.name))
                            kv.Value.version = parmSteps[kv.Value.name];
                        list.Add(kv.Value);                        
                    }
                    lvwStep.ShowMESItems(list.ToArray());

                    if (curSpec != null)
                    {
                        curSpec.retrieveStepSpecs();
                        foreach (mesRelease.PARM.StepParameter sp in curSpec.Items)
                            sp.RetrieveSpecInformation();

                        foreach (ListViewItem listItem in lvwStep.Items)
                        {
                            mesRelease.PARM.StepParameter sp = curSpec.Item(listItem.Text);
                            if (sp == null || sp.IsSettingEmpty()) continue;
                            listItem.BackColor = Color.LightGreen;
                            listItem.SubItems[2].Text = sp.stdProcessTime == 0 ? "" : sp.stdProcessTime.ToString();
                        }
                    }
                }
                finally
                {
                    lvwStep.Show();
                }

                try
                {
                    lvwSpecDetail.Hide();
                    showSpecDetail();
                }
                finally
                {
                    lvwSpecDetail.Show();
                }
                Cursor = Cursors.Default;
            }
        }

        void showSpecDetail()
        {
            lvwSpecDetail.Items.Clear();
            lvwSpecDetail.Groups.Clear();
            if (curSpec == null) return;

            List<mesRelease.PARM.StepParameter> lstSepParameter = new List<mesRelease.PARM.StepParameter>();
            foreach (ListViewItem listItem in lvwStep.Items)
            {
                mesRelease.PARM.StepParameter sp = curSpec.Item(listItem.Text);
                if (sp == null || sp.IsSettingEmpty()) continue;
                lstSepParameter.Add(sp);
            }

            foreach (mesRelease.PARM.StepParameter sp in lstSepParameter)
            {
                lvwSpecDetail.Groups.Add(sp.name, sp.name);
                //站點參數
                if (sp.Count > 0)
                {
                    ListViewItem item = new ListViewItem(idv.utilities.cultureLanguage.getValue("parameter"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("value"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("max"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("min"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("remark"));
                    item.Group = lvwSpecDetail.Groups[sp.name];
                    item.BackColor = Color.Gray;
                    item.ForeColor = Color.White;
                    lvwSpecDetail.Items.Add(item);
                    foreach (mesRelease.PARM.Parameter p in sp.Items)
                    {
                        item = new ListViewItem(p.name);
                        item.SubItems.Add(p.value == "" ? "--" : p.value);
                        item.SubItems.Add(p.max == double.MaxValue ? "--" : p.max.ToString());
                        item.SubItems.Add(p.min == double.MinValue ? "--" : p.min.ToString());
                        item.SubItems.Add(p.remark);
                        item.Group = lvwSpecDetail.Groups[sp.name];
                        lvwSpecDetail.Items.Add(item);
                    }
                }

                //站點耗用物料
                if (sp.MaterialTypeCount > 0)
                {
                    ListViewItem item = new ListViewItem(idv.utilities.cultureLanguage.getValue("materialTracking"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("materialType"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("materialPartNo"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("consumeRate"));
                    item.Group = lvwSpecDetail.Groups[sp.name];
                    item.BackColor = Color.DarkCyan;
                    item.ForeColor = Color.White;
                    lvwSpecDetail.Items.Add(item);
                    for (int i = 0; i < sp.MaterialTypeCount; i++)
                    {
                        mesRelease.PARM.SpecMaterial sm = sp.GetMaterialType(i);
                        bool showName = true;
                        foreach (string s in sm.partNOs)
                        {
                            item = new ListViewItem();
                            if (showName)
                            {
                                item.SubItems.Add(sm.name);
                                showName = false;
                            }
                            else
                                item.SubItems.Add("");

                            item.SubItems.Add(s);
                            item.SubItems.Add(sm.GetConsumeRate(s).ToString());
                            item.Group = lvwSpecDetail.Groups[sp.name];
                            lvwSpecDetail.Items.Add(item);
                        }
                    }
                }

                //機台程式
                string[] eqTypes = sp.GetEqTypes();
                if (eqTypes.Length > 0)
                {
                    ListViewItem item = new ListViewItem(idv.utilities.cultureLanguage.getValue("eqpEquipmentType"));
                    item.SubItems.Add(idv.utilities.cultureLanguage.getValue("recipe"));
                    item.Group = lvwSpecDetail.Groups[sp.name];
                    item.BackColor = Color.DarkKhaki;
                    item.ForeColor = Color.White;
                    lvwSpecDetail.Items.Add(item);
                    foreach (string eqType in eqTypes)
                    {
                        mesRelease.PARM.EqRecipe er = sp.GetEqRecipe(eqType);
                        item = new ListViewItem(eqType);
                        item.SubItems.Add(er == null ? "" : er.recipe);
                        item.Group = lvwSpecDetail.Groups[sp.name];
                        lvwSpecDetail.Items.Add(item);

                        //軌道用料
                        if (sp.EqTrackMaterialCount(eqType) > 0)
                        {
                            //Column Header
                            ListViewItem matItem = new ListViewItem();
                            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                            subItem = matItem.SubItems.Add(idv.utilities.cultureLanguage.getValue("track"));
                            subItem.BackColor = Color.DarkGray;
                            subItem.ForeColor = Color.White;

                            subItem = matItem.SubItems.Add(idv.utilities.cultureLanguage.getValue("materialPartNo"));
                            subItem.BackColor = Color.DarkGray;
                            subItem.ForeColor = Color.White;

                            subItem = matItem.SubItems.Add(idv.utilities.cultureLanguage.getValue("consumeRate"));
                            subItem.BackColor = Color.DarkGray;
                            subItem.ForeColor = Color.White;

                            matItem.Group = lvwSpecDetail.Groups[sp.name];
                            matItem.UseItemStyleForSubItems = false;
                            lvwSpecDetail.Items.Add(matItem);

                            string track = "";
                            foreach (mesRelease.PARM.EqTrackMaterial trackMat in sp.GetEqTrackMaterials(eqType))
                            {
                                foreach (string partNo in trackMat.partNOs)
                                {
                                    matItem = new ListViewItem();
                                    if (track.Equals(trackMat.track))
                                        matItem.SubItems.Add("");
                                    else
                                    {
                                        track = trackMat.track;
                                        matItem.SubItems.Add(track);
                                    }
                                    matItem.SubItems.Add(partNo);
                                    matItem.SubItems.Add(trackMat.GetConsumeRate(partNo).ToString());
                                    matItem.Group = lvwSpecDetail.Groups[sp.name];
                                    lvwSpecDetail.Items.Add(matItem);
                                }
                            }
                        }

                        //治工具
                        if (idv.mesCore.systemConfig.validItem("toolingManagement") && sp.EqToolingCount(eqType) > 0)
                        {
                            //Column Header
                            ListViewItem tolItem = new ListViewItem();
                            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                            subItem = tolItem.SubItems.Add(idv.utilities.cultureLanguage.getValue("ToolingType"));
                            subItem.BackColor = Color.CornflowerBlue;
                            subItem.ForeColor = Color.White;

                            subItem = tolItem.SubItems.Add(idv.utilities.cultureLanguage.getValue("ToolingPart"));
                            subItem.BackColor = Color.CornflowerBlue;
                            subItem.ForeColor = Color.White;

                            tolItem.Group = lvwSpecDetail.Groups[sp.name];
                            tolItem.UseItemStyleForSubItems = false;
                            lvwSpecDetail.Items.Add(tolItem);

                            string toolType = "";
                            foreach (mesRelease.PARM.EqTooling eqTool in sp.GetEqToolings(eqType))
                            {
                                foreach (string partNo in eqTool.partNOs)
                                {
                                    tolItem = new ListViewItem();
                                    if (toolType.Equals(eqTool.toolingType))
                                        tolItem.SubItems.Add("");
                                    else
                                    {
                                        toolType = eqTool.toolingType;
                                        tolItem.SubItems.Add(toolType);
                                    }
                                    tolItem.SubItems.Add(partNo);
                                    tolItem.Group = lvwSpecDetail.Groups[sp.name];
                                    lvwSpecDetail.Items.Add(tolItem);
                                }
                            }
                        }
                    }
                }
            }

            //lvwSpecDetail.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void frmProductSpecQuery_Activated(object sender, EventArgs e)
        {
            if (idv.utilities.misc.IsValueChanged("frmProduct", Name))
            {
                lvwProduct.ShowMESItems(mesRelease.PRP.Product.GetActiveProducts(""));
            }
        }

        private void lvwSpecDetail_Resize(object sender, EventArgs e)
        {
            int totalWidth = 0;
            for (int i = 0; i < lvwSpecDetail.Columns.Count - 1; i++)
                totalWidth += lvwSpecDetail.Columns[i].Width;

            totalWidth = lvwSpecDetail.Width - totalWidth - 10;
            if (totalWidth < 50) totalWidth = 50;
            lvwSpecDetail.Columns[lvwSpecDetail.Columns.Count - 1].Width = totalWidth;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (curSpec == null) return;
            executeExport();
        }
        void executeExport()
        {
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.Filter = "excel(*.xls)|*.xls";
            if (curSpec != null)
                sfg.FileName = curSpec.name;
            if (sfg.ShowDialog() == DialogResult.Cancel) return;
            if (sfg.FileName != "")
            {
                mesRelease.utilities.ExcelAgent exg = new mesRelease.utilities.ExcelAgent();
                exg.writeToFileWithListViewStyle(sfg.FileName, lvwSpecDetail, false);
                idv.utilities.messageBox.showMessageById("msgExecuteSucceed");
            }
        }
    }
}
