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
    public partial class frmReasonType : Form
    {
        public frmReasonType()
        {
            InitializeComponent();
            initToolbar();
        }

        private void initToolbar()
        {
            actionToolbar1.loadStandardButtons();//Add, Modify, Delete, Query
            actionToolbar1.Items["Modify"].Visible = false;
            actionToolbar1.Items["Query"].Visible = false;
        }

        private void actionToolbar1_ActionClicked(string actionName)
        {
            switch (actionName)
            {
                case "Add":
                    executeAdd();
                    break;
                case "Delete":
                    executeDelete();
                    break;
            }
        }

        private void frmReasonType_Load(object sender, EventArgs e)
        {
            foreach (string s in mesRelease.BAS.ReasonCode.ReasonTypeGet())
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
            if (!appInstance.CheckInputData(txtReasonType, lblReasonType)) return;
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("add"))) return;
            try
            {
                mesRelease.BAS.ReasonCode.ReasonTypeAdd(txtReasonType.Text, mesRelease.USR.User.loginUser.name);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                listView1.Items.Add(txtReasonType.Text).EnsureVisible();
                txtReasonType.Text = "";
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
            if (!messageBox.showMessageById("msgConfirmExecute", messageStyle.askYesNo, cultureLanguage.getValue("delete"))) return;
            try
            {
                ListViewItem item = listView1.SelectedItems[0];
                mesRelease.BAS.ReasonCode.ReasonTypeDelete(item.Text);
                appInstance.showInformationById("msgExecuteSucceed", informationType.succeed);
                listView1.Items.Remove(item);
                idv.utilities.misc.SetValueChangeByItemName(Name);
            }
            catch (Exception ex)
            {
                appInstance.showInformation(ex.Message, informationType.error);
            }
        }
    }
}
