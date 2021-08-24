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


namespace ClientRule.OnLineNotice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {                        
            //process with multi thread for better proformance
            //put the logic supposed spent more time in initAsynchronize() sub
            //this is not necessary
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(initAsynchronize));
            t.Start();

            t.Join();
            idv.utilities.cultureLanguage.switchLanguage(this);
        }

        //a part of init for GUI, executing by asynchronize way
        void initAsynchronize()
        {
            try
            {
                cboDivision.Items.Add("");
                cboDivision.Items.AddRange(idv.mesCore.misc.DivisionGet());
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if user input collect data for txn
            if (!checkBeforeTxn()) return;
            Cursor = Cursors.WaitCursor;
            RuleInstance.logFunctionIn("btnOK_Click");
            //generate txn object and assign correspond information
            

            //add protagonist to txn item collcation by txn.add method


            //dotxn and get return value
            try
            {
                serverCommand sc = new serverCommand();
                sc.name = "notify";
                sc.requestReply = false;
                sc.sender = mesRelease.WF.WorkFlow.ClientId;
                sc.To = "*";
                serverCommandArgument arg = new serverCommandArgument();
                arg.name = "userId";
                arg.value = txtUserId.Text;
                sc.Add(arg);

                arg = new serverCommandArgument();
                arg.name = "division";
                arg.value = cboDivision.Text;
                sc.Add(arg);

                arg = new serverCommandArgument();
                arg.name = "clientId";
                arg.value = "";
                sc.Add(arg);

                arg = new serverCommandArgument();
                arg.name = "title";
                arg.value = txtTitle.Text;
                if (mesRelease.USR.User.loginUser != null)
                    arg.value += " (" + mesRelease.USR.User.loginUser.name + " - " + mesRelease.USR.User.GetUserName(mesRelease.USR.User.loginUser.name) + ")";
                sc.Add(arg);

                arg = new serverCommandArgument();
                arg.name = "message";
                arg.value = txtMessage.Text;
                sc.Add(arg);

                arg = new serverCommandArgument();
                arg.name = "second";
                arg.value = txtDisplay.Text;
                sc.Add(arg);

                sc.send();
            }
            catch { }

            RuleInstance.logFunctionOut("btnOK_Click");
            //check txn result and do correspond action
            
            Cursor = Cursors.Default;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //assign CANCEL to RuleResult if user abandon txn, to tell WF to go back original status
            RuleInstance.RuleResult = "CANCEL";
            Close();
        }

        bool checkBeforeTxn()
        {
            standardStatusbar1.setInformation("");
            if (txtMessage.Text.Trim() == "")
            {
                standardStatusbar1.setInformation(cultureLanguage.getValue("requireField2", lblMessage.Text), idv.mesCore.Controls.informationType.warn);
                return false;
            }
            return true;
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
