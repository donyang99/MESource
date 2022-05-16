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
using idv.messageService.sql;

namespace alarmModule
{
    public partial class frmEditLineGroup : Form
    {
        bool result = false;
        public frmEditLineGroup()
        {
            InitializeComponent();
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Export", "");//add button needed with privilege string
        }

        private void frmEditLineGroup_Load(object sender, EventArgs e)
        {
            DataSet ds = idv.messageService.serviceHost.Client.getDataSetWithParameter("select value,remark from mes_misc where item=?", "lineToken");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Name = row["value"].ToString();
                item.Text = item.Name;
                item.SubItems.Add(row["remark"].ToString());
                lvwLine.Items.Add(item);
            }
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
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtLineId, lblLineId, txtLineToken, lblLineToken)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                sqlTable t = new sqlTable("mes_misc", eDMLtype.Insert);
                t.Add("item", "lineToken");
                t.Add("value", txtLineId.Text);
                t.Add("remark", txtLineToken.Text);
                t.Add("modify_user", mesRelease.USR.User.loginUserId);
                t.Add("modify_date", idv.messageService.serviceHost.dateTime);
                sqlExecuter.executeSqlTable(t, idv.messageService.serviceHost.Client);

                ListViewItem item = new ListViewItem();
                item.Name = txtLineId.Text;
                item.Text = item.Name;
                item.SubItems.Add(txtLineToken.Text);
                lvwLine.Items.Add(item);
                item.Selected = true;
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                result = true;
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeModify()
        {
            if (lvwLine.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            else if (!appInstance.CheckInputData(txtLineId, lblLineId, txtLineToken, lblLineToken)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("modify"))) return;
            try
            {
                ListViewItem item = lvwLine.SelectedItems[0];
                sqlTable t = new sqlTable("mes_misc", eDMLtype.Update);
                t.Add("item", "lineToken");
                t.Add("value", txtLineId.Text);
                t.Add("remark", txtLineToken.Text);
                t.Add("modify_user", mesRelease.USR.User.loginUserId);
                t.Add("modify_date", idv.messageService.serviceHost.dateTime);
                t.WhereClause.Add("item", "lineToken");
                t.WhereClause.Add("value", item.Name);

                sqlExecuter.executeSqlTable(t, idv.messageService.serviceHost.Client);
                
                item.Name = txtLineId.Text;
                item.Text = item.Name;
                item.SubItems[1].Text = txtLineToken.Text;

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                result = true;
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (lvwLine.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("noItemSelected", informationType.warn);
                return;
            }
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                ListViewItem item = lvwLine.SelectedItems[0];
                sqlTable t = new sqlTable("mes_misc", eDMLtype.Delete);
                t.WhereClause.Add("item", "lineToken");
                t.WhereClause.Add("value", item.Name);

                sqlExecuter.executeSqlTable(t, idv.messageService.serviceHost.Client);

                item.Remove();

                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                result = true;
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeExport()
        {
            if (mesRelease.utilities.ExcelAgent.WriteToFile(lvwLine))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }

        internal static bool edit()
        {
            frmEditLineGroup frm = new frmEditLineGroup();
            try
            {
                idv.utilities.cultureLanguage.switchLanguageSync(frm);
                frm.ShowDialog();
                return frm.result;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (!frm.IsDisposed)
                    frm.Close();
            }
        }

        private void lvwLine_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected || lvwLine.SelectedItems.Count == 0)
            {
                txtLineId.Text = "";
                txtLineToken.Text = "";
            }
            else
            {
                ListViewItem item = lvwLine.SelectedItems[0];
                txtLineId.Text = item.Text;
                txtLineToken.Text = item.SubItems[1].Text;
            }
        }


    }
}
