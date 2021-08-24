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

namespace mesBasicData
{
    public partial class frmDivision : Form
    {
        public frmDivision()
        {
            InitializeComponent();
            initToolbar();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Modify"].Visible = false;
            actionToolbar1.Items["Query"].Visible = false;
            actionToolbar1.addButton("Export", "");
        }

        private void frmDivision_Load(object sender, EventArgs e)
        {
            executeQuery();
        }

        void actionToolbar1_ActionClicked(string actionName)
        {
            appInstance.showInformation("");
            switch (actionName)
            {
                case "Add":
                    executeAdd();
                    break;
                case "Delete":
                    executeDelete();
                    break;
                case "Export":
                    executeExport();
                    break;
            }
        }

        void executeQuery()
        {
            foreach (string s in idv.mesCore.misc.DivisionGet())
            {
                listView1.Items.Add(s);
            }
            if (listView1.Items.Count > 0)
                listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            if (listView1.Columns[0].Width < 150)
                listView1.Columns[0].Width = 150;
        }

        void executeAdd()
        {
            if (!appInstance.CheckInputData(txtDivision, lblDivision)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                idv.mesCore.misc.DivisionAdd(txtDivision.Text, mesRelease.USR.User.loginUser.name);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                listView1.Items.Add(txtDivision.Text).EnsureVisible();
                txtDivision.Text = "";
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        void executeDelete()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                appInstance.showInformationById("msgDeleteNoSelect", informationType.warn);
                return;
            }
            ListViewItem item = listView1.SelectedItems[0];
            if (isDivisionUsed(item.Text)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                idv.mesCore.misc.DivisionDelete(item.Text);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                listView1.Items.Remove(item);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }

        bool isDivisionUsed(string division)
        {
            string sql = "select count(*) from mes_user_profile where division =?";
            if (idv.messageService.serviceHost.Client.getValueWithParameter(sql, division).Equals("0"))
                return false;
            else
            {
                messageBox.showMessageById("cantDelDefaults", messageStyle.confirmation);
                return true;
            }
        }

        void executeExport()
        {
            appInstance.showInformation("");
            if (mesRelease.utilities.ExcelAgent.WriteToFile(listView1))
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
        }
    }
}
