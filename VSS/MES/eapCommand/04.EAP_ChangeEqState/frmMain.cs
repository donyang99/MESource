using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace SampleAutoExe
{
    public partial class frmMain : Form
    {
        System.Timers.Timer tmr = new System.Timers.Timer(300);
        public frmMain()
        {
            InitializeComponent();
            serviceHost.ClientId = "Client:EAP." + Environment.MachineName + "." + AppDomain.CurrentDomain.FriendlyName.Split('.')[0] + "." +
                                    System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
            serviceHost.Init(Environment.MachineName, serviceHost.ClientId);
            serviceHost.MessageNotice += new MessageNoticeEventHandler(MessageIn);
            //serviceHost.EnableAutoReplyPing(serviceHost.ClientId);
            serviceHost.Register("EAP:EQPID");
            tmr.Elapsed += new System.Timers.ElapsedEventHandler(tmr_Elapsed);
        }

        bool bTstPing = false;
        void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (bTstPing)
                Invoke(new MethodInvoker(TestPing));
            else
                Invoke(new MethodInvoker(JavaTest));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serviceHost.Close();
            }
            catch { }
        }

        void MessageIn(messageBase item)
        {
            lock ("MessageIn")
            {
                if (item is idv.mesCommand.Command)
                {
                    doItem = item;
                    if (!chkTmr.Checked)
                        Invoke(new MethodInvoker(doShowTree));
                }
                else if (item is serverCommand && bTstPing)
                {
                    doCmd = item as serverCommand;
                    if (!chkTmr.Checked)
                        Invoke(new MethodInvoker(doShowPingReply));
                    else
                    {
                        lblLastDate.Text = DateTime.Now.ToString();
                        lblLastSender.Text = (item as serverCommand).sender;
                    }
                }
            }
        }

        serverCommand doCmd = null;
        void doShowPingReply()
        {
            treeView1.Nodes.Add(doCmd.sender).EnsureVisible();
        }

        messageBase doItem = null;
        void doShowTree()
        {
            showTree(doItem as idv.mesCommand.Command, false, Color.Red);
        }

        private void btnSampleAutoExe_Click(object sender, EventArgs e)
        {
            EapAutoChangeState();
            //EqpParmDataCollect();
            //if (bTstPing)
            //    TestPing();
            //else
            //    JavaTest();
        }

        
        void TestPing()
        {
            serverCommand cmd = new serverCommand();
            cmd.name = "ping";
            cmd.requestReply = true;
            cmd.sender = serviceHost.ClientId;
            cmd.To = "Client:";
            cmd.send();
        }

        int iii = 0;
        DataSet dsTmp = null;
        void JavaTest()
        {
            idv.mesCommand.Command msg = new idv.mesCommand.Command();
            if (dsTmp == null)
                dsTmp = serviceHost.Client.getDataSet("select * from language_map where key='WIP' ");
            if ((iii % 2) == 0)
            {
                msg.name = "test" + iii.ToString();
                msg.To = "FABA:A";
            }
            else if ((iii % 2) == 1)
            {
                msg.name = "test" + iii.ToString();
                msg.To = "FABB:B";
                msg.AddItem(dsTmp);
            }
            else
            {
                iii++;
                return;
            }
            iii++;

            msg.result = "PAS";
            msg.errMessage = "NoMsg";
            msg.AddArgument("argName1", "Value1");
            msg.AddArgument("argName2", 1);
            msg.AddArgument("argName3", (double)2);


            idv.mesCommand.ItemValue lotId = msg.AddItem("LotId", "Lot001");
            lotId.AddItem("com", "comp01");
            lotId.AddItem("comp02");
            lotId = lotId.AddItem("comp03");
            lotId.AddItem("REA01", 99);
            msg.AddItem("EqpId", "Eqp001");

            msg.send();
            if (!chkTmr.Checked)
                showTree(msg, false);
        }

        void NormalSampleAutoExe()
        {
            idv.mesCommand.Command cmd = new idv.mesCommand.Command();
            cmd.AssemblyName = "mesCommandTemplate";
            cmd.ClassName = "mesCommandTemplate.CommandInstance";
            cmd.AddArgument("abc", "test");
            cmd = cmd.doTxn();

            showTree(cmd, false);
        }

        void EqpParmDataCollect()
        {
            idv.mesCommand.Command cmd = new idv.mesCommand.Command();
            cmd.AssemblyName = "EqpParmDataCollect";
            cmd.ClassName = "EqpParmDataCollect.CommandInstance";
            //cmd.AddArgument("lotId", "IC_Order01-010");
            cmd.AddArgument("equipmentId", "Etch01");
            cmd.AddArgument("eq_dens", "77");
            cmd.AddArgument("tmp_dd", "79");
            cmd.Sender = "EAPID01";
            cmd = cmd.doTxn();

            showTree(cmd, false);
        }

        void EapAutoTrackIn()
        {
            idv.mesCommand.Command cmd = new idv.mesCommand.Command();
            cmd.AssemblyName = "eapAutoTrackIn";
            cmd.ClassName = "eapAutoTrackIn.CommandInstance";
            cmd.AddArgument("LotId", "Order01-005");
            cmd.AddArgument("EqpId", "CKen01");
            cmd = cmd.doTxn();

            showTree(cmd, false);
        }

        void EapAutoChangeState()
        {
            idv.mesCommand.Command cmd = new idv.mesCommand.Command();
            cmd.AssemblyName = "eapAutoChangeState";
            cmd.ClassName = "eapAutoChangeState.CommandInstance";
            cmd.AddArgument("time", DateTime.Now.ToString());
            cmd.AddArgument("tag", "totalstatus");
            cmd.AddArgument("EqpId", txtEqId.Text);
            cmd.AddArgument("before", "NONE");
            if (rdoDOWN.Checked)
                cmd.AddArgument("now", "DOWN");
            else
                cmd.AddArgument("now", "IDLE");
            //cmd.AddArgument("ReasonCode", "R1");
            cmd.Sender = "EAPID01";
            cmd = cmd.doTxn();

            showTree(cmd, false);
        }

        void showTree(idv.mesCommand.Command cmd, bool clearTree)
        {
            showTree(cmd, clearTree, Color.Black);
        }
        void showTree(idv.mesCommand.Command cmd, bool clearTree, Color color)
        {
            if (clearTree)
                treeView1.Nodes.Clear();
            TreeNode nodeCmd = treeView1.Nodes.Add(cmd.name);
            nodeCmd.ForeColor = color;
            string err = "";
            if (!cmd.result.Equals("PASS"))
                err = " ( ErrMsg:" + cmd.errMessage + " )";

            nodeCmd.Nodes.Add("Result = " + cmd.result + err);
            nodeCmd.Nodes.Add("ErrMsg = " + err);
            nodeCmd.Nodes.Add("To = " + cmd.To);
            nodeCmd.Nodes.Add("Sender = " + cmd.Sender);

            TreeNode temp = nodeCmd.Nodes.Add("參數");
            for (int i = 0; i < cmd.Arguments.Count; i++)
            {
                idv.mesCommand.ItemValue item = cmd.GetArgument(i);
                temp.Nodes.Add(item.name + " = " + item.Value.ToString() + " ( " + item.Value.GetType().ToString() + " )");
            }

            temp = nodeCmd.Nodes.Add("回傳");

            for (int i = 0; i < cmd.Count; i++)
            {
                idv.mesCommand.ItemValue item = cmd.Item(i);

                string text = "[no name]";
                if (item.name != null && !item.name.Equals(""))
                    text = item.name;

                if (item.Value != null)
                    text += " = " + item.Value.ToString() + " ( " + item.Value.GetType().ToString() + " )";

                TreeNode n = temp.Nodes.Add(text);

                showChildNode(n, item);
            }

            nodeCmd.ExpandAll();
        }

        void showChildNode(TreeNode node, idv.mesCommand.ItemValue item)
        {
            if (item.Count == 0) return;

            for (int i = 0; i < item.Count; i++)
            {
                idv.mesCommand.ItemValue subItem = item.Item(i);

                string text = "[no name]";
                if (subItem.name != null && !subItem.name.Equals(""))
                    text = subItem.name;

                if (subItem.Value != null)
                    text += " = " + subItem.Value.ToString() + " ( " + subItem.Value.GetType().ToString() + " )";

                TreeNode n = node.Nodes.Add(text);

                showChildNode(n, subItem);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void chkTmr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTmr.Enabled)
                iii = 0;
            tmr.Enabled = chkTmr.Checked;
        }

        private void chkPing_CheckedChanged(object sender, EventArgs e)
        {
            bTstPing = chkPing.Checked;
        }
    }
}
