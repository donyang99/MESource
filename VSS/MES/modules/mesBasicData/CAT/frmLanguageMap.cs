using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;
using idv.utilities;
using idv.mesCore.Controls;
using idv.messageService.sql;

namespace mesBasicData
{
    public partial class frmLanguageMap : Form
    {
        public frmLanguageMap()
        {
            InitializeComponent();
            initToolbar();
            initData();
            autoSizeColumn();
        }

        private void frmLanguageMap_Load(object sender, EventArgs e)
        {
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        string ToCultureName(string value)
        {
            return value.Replace("_", "-");
        }
        string FromCultureName(string value)
        {
            return value.Replace("-", "_");
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.addButton("Clear", "");
            actionToolbar1.addButton("Export", "");
            actionToolbar1.addButton("LangInfo", "");
        }

        void initData()
        {
            DataSet ds = serviceHost.Client.getDataSet("select distinct language from language_map order by language");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Label lbl = null;
                TextBox txt = null;
                if (i == 0)
                {
                    lbl = lblLanguage;
                    txt = txtLanguage;
                }
                else
                {
                    lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Anchor = lblLanguage.Anchor;
                    lbl.Font = lblLanguage.Font;
                    //lbl.BorderStyle = lblLanguage.BorderStyle;
                    txt = new TextBox();
                    txt.Anchor = txtLanguage.Anchor;
                    txt.Font = txtLanguage.Font;
                    txt.BackColor = txtLanguage.BackColor;
                    tblLanguage.RowCount++;
                    tblLanguage.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tblLanguage.Controls.Add(lbl, 0, tblLanguage.RowCount-1);
                    tblLanguage.Controls.Add(txt, 1, tblLanguage.RowCount-1);

                    lvwLanguage.Columns.Add("");
                }
                lbl.Text = ds.Tables[0].Rows[i][0].ToString();
                lbl.Tag = ds.Tables[0].Rows[i][0].ToString();
                txt.Name = FromCultureName(ds.Tables[0].Rows[i][0].ToString());
                txt.Tag = lbl.Tag;

                lvwLanguage.Columns[i + 1].Name = txt.Name;
                lvwLanguage.Columns[i + 1].Text = lbl.Text;
                lvwLanguage.Columns[i + 1].Tag = lbl.Tag;
            }
        }

        void autoSizeColumn()
        {
            lvwLanguage.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            if (lvwLanguage.Columns[0].Width < 100) lvwLanguage.Columns[0].Width = 100;
            int width = (lvwLanguage.Width - lvwLanguage.Columns[0].Width - 20) / (lvwLanguage.Columns.Count - 1);
            for (int i = 1; i < lvwLanguage.Columns.Count; i++)
                lvwLanguage.Columns[i].Width = width;
        }

        void actionToolbar1_ActionClicked(string actionName)
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
                case "Clear":
                    executeClear();
                    break;
                case "Query":
                    executeQuery();
                    break;
                case "Export":
                    executeExport();
                    break;
                case "LangInfo":
                    executeLangInfo();
                    break;
            }
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtKey, lblKey)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;

            try
            {
                List<sqlTable> list = new List<sqlTable>();
                sqlTable table = null;
                foreach (Control ctl in tblLanguage.Controls)
                {
                    if (ctl is TextBox && ctl.Tag != null)
                    {
                        table = new sqlTable("language_map", eDMLtype.Insert);
                        table.Add("language", ToCultureName(ctl.Name));
                        table.Add("key", txtKey.Text);
                        table.Add("value", ctl.Text);
                        list.Add(table);
                    }
                }
                table = new sqlTable("mes_system_config", eDMLtype.Update);
                table.Add("validation", DateTime.Now.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US").DateTimeFormat));
                table.WhereClause.Add("item", "LanguageUpdateDate");
                list.Add(table);
                sqlExecuter.executeSqlTables(list, serviceHost.Client);
                
                showListView(null);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            if (lvwLanguage.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("msgDeleteNoSelect", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                List<sqlTable> list = new List<sqlTable>();
                sqlTable table = new sqlTable("language_map", eDMLtype.Delete);
                table.WhereClause.Add("key", lvwLanguage.SelectedItems[0].Text);
                list.Add(table);

                foreach (Control ctl in tblLanguage.Controls)
                {
                    if (ctl is TextBox && ctl.Tag != null)
                    {
                        table = new sqlTable("language_map", eDMLtype.Insert);
                        table.Add("language", ToCultureName(ctl.Name));
                        table.Add("key", txtKey.Text);
                        table.Add("value", ctl.Text);
                        list.Add(table);
                    }
                }
                table = new sqlTable("mes_system_config", eDMLtype.Update);
                table.Add("validation", DateTime.Now.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US").DateTimeFormat));
                table.WhereClause.Add("item", "LanguageUpdateDate");
                list.Add(table);
                serviceHost.Client.beginTxn();
                sqlExecuter.executeSqlTables(list, serviceHost.Client);
                serviceHost.Client.commitTxn();
                showListView(lvwLanguage.SelectedItems[0]);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                serviceHost.Client.rollbackTxn();
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (lvwLanguage.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("msgDeleteNoSelect", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                sqlTable table = new sqlTable("language_map", eDMLtype.Delete);
                table.WhereClause.Add("key", lvwLanguage.SelectedItems[0].Text);
                sqlExecuter.executeSqlTable(table, serviceHost.Client);

                table = new sqlTable("mes_system_config", eDMLtype.Update);
                table.Add("validation", DateTime.Now.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US").DateTimeFormat));
                table.WhereClause.Add("item", "LanguageUpdateDate");
                sqlExecuter.executeSqlTable(table, serviceHost.Client);

                lvwLanguage.SelectedItems[0].Remove();
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void showListView(ListViewItem item)
        {
            if (item == null)
            {
                item = new ListViewItem();
                lvwLanguage.Items.Add(item);
                for (int i = 1; i < lvwLanguage.Columns.Count; i++)
                {
                    ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                    subItem.Name = lvwLanguage.Columns[i].Name;
                    item.SubItems.Add(subItem);
                }
            }
            item.Text = txtKey.Text;
            item.Name = txtKey.Text;
            for (int i = 1; i < item.SubItems.Count; i++)
            { 
                ListViewItem.ListViewSubItem subItem=item.SubItems[i];
                Control txt = tblLanguage.Controls[subItem.Name];
                if (txt != null)
                    subItem.Text = txt.Text;
            }
            item.Selected = true;
            item.EnsureVisible();
        }

        void executeQuery()
        {
            Dictionary<string, object> dicCondition = new Dictionary<string, object>();
            if (!txtKey.Text.Trim().Equals(""))
                dicCondition["key like ?"] = "%" + txtKey.Text + "%";
            
            if (!txtLanguage.Text.Trim().Equals(""))
            {
                string tmp = "key in (select key from language_map where value like ?)";
                dicCondition[tmp] = "%" + txtLanguage.Text + "%";
            }

            string sql = "select * from language_map";
            if (dicCondition.Count > 0)
                sql += " where " + string.Join(" and ", dicCondition.Keys.ToArray());

            sql += " order by key,language";
            DataSet ds = serviceHost.Client.getDataSetWithParameter(sql,dicCondition.Values.ToArray());

            lvwLanguage.Items.Clear();
            string key = "";
            ListViewItem item = null;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (!key.Equals(row["key"].ToString()))
                {
                    key = row["key"].ToString();
                    item = lvwLanguage.Items[key];
                    if (item == null)
                    {
                        item = new ListViewItem(key);
                        item.Name = key;
                        lvwLanguage.Items.Add(item);
                        for (int i = 1; i < lvwLanguage.Columns.Count; i++)
                        {
                            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                            subItem.Name = lvwLanguage.Columns[i].Name;
                            item.SubItems.Add(subItem);
                        }
                    }
                }
                item.SubItems[FromCultureName(row["language"].ToString())].Text = row["value"].ToString();
            }
            autoSizeColumn();
            executeClear();
        }

        void executeClear()
        {
            txtKey.Text = "";
            foreach (Control ctl in tblLanguage.Controls)
            {
                if (ctl is TextBox && ctl.Tag != null)
                    ctl.Text = "";
            }
        }

        void executeExport()
        {
            if (lvwLanguage.Items.Count == 0) return;
            string[] selLanguage = selectLanguage();
            if (selLanguage.Length == 0) return;

            SaveFileDialog ofg = new SaveFileDialog();
            ofg.Filter = "Text(*.txt)|*.txt";
            ofg.FileName = "LanguageMap.txt";
            ofg.ShowDialog();
            if (ofg.FileName == "") return;

            List<string> list = new List<string>();
            foreach (ListViewItem item in lvwLanguage.Items)
            {
                for (int i = 1; i < lvwLanguage.Columns.Count; i++)
                {
                    ListViewItem.ListViewSubItem subItem = item.SubItems[lvwLanguage.Columns[i].Name];
                    if (!selLanguage.Contains(ToCultureName(subItem.Name))) continue;
                    sqlTable table = new sqlTable("language_map", eDMLtype.Insert);
                    table.Add("language", ToCultureName(subItem.Name));
                    table.Add("key", item.SubItems[0].Text);
                    table.Add("value", subItem.Text);
                    list.Add(table.ToSQL());
                }
            }
            System.IO.File.WriteAllText(ofg.FileName, string.Join(";" + Environment.NewLine, list.ToArray())); 
            MessageBox.Show("OK");
        }
        string[] selectLanguage()
        {
            Form frm = new Form();
            frm.Font = lvwLanguage.Font;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = new System.Drawing.Size(400, 400);
            ListView lvw = new ListView();
            frm.Controls.Add(lvw);
            lvw.View = View.Details;
            lvw.Columns.Add("CultureName").Width = 120;
            lvw.Columns.Add("DisplayName").Width = 250;
            lvw.FullRowSelect = true;
            lvw.Dock = DockStyle.Fill;
            lvw.Sorting = SortOrder.Ascending;
            lvw.CheckBoxes = true;

            for (int i = 1; i < lvwLanguage.Columns.Count; i++)
            {
                string cultureName = ToCultureName(lvwLanguage.Columns[i].Name);
                System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo(cultureName);
                lvw.Items.Add(ToCultureName(cultureName)).SubItems.Add(cul == null ? "" : cul.DisplayName);
            }

            frm.ShowDialog();
            List<string> list = new List<string>();
            foreach (ListViewItem item in lvw.CheckedItems)
                list.Add(item.Text);
            return list.ToArray();
        }

        void executeLangInfo()
        {
            Form frm = new Form();
            frm.Font = lvwLanguage.Font;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = new System.Drawing.Size(400, 400);
            ListView lvw = new ListView();
            frm.Controls.Add(lvw);
            lvw.View = View.Details;
            lvw.Columns.Add("CultureName").Width = 120;
            lvw.Columns.Add("DisplayName").Width = 250;
            lvw.FullRowSelect = true;
            lvw.Dock = DockStyle.Fill;
            lvw.Sorting = SortOrder.Ascending;
            
            foreach (System.Globalization.CultureInfo cul in System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.AllCultures))
            {
                lvw.Items.Add(cul.TextInfo.CultureName).SubItems.Add(cul.DisplayName);
                System.Diagnostics.Trace.WriteLine(cul.Name + "=" + cul.DisplayName);
            }
            frm.ShowDialog();
        }

        private void frmLanguageMap_Resize(object sender, EventArgs e)
        {
            autoSizeColumn();
        }

        private void lvwLanguage_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                executeClear();
            }
            else
            {
                txtKey.Text = e.Item.Text;
                foreach (Control ctl in tblLanguage.Controls)
                {
                    if (ctl is TextBox && ctl.Tag != null)
                    {
                        ListViewItem.ListViewSubItem subItem = e.Item.SubItems[FromCultureName(ctl.Tag.ToString())];
                        if (subItem != null)
                            ctl.Text = subItem.Text;
                    }
                }
            }
        }
    }
}
