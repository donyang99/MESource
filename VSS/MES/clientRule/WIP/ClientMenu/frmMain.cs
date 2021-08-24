using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;
using mesRelease.EQP;
using mesRelease.USR;
using idv.utilities;

namespace ClientRule.ClientMenu
{
    public partial class frmMain : Form
    {
        static MenuStrip mainMenu = null;
        Lot currentLot = null;
        public frmMain()
        {
            InitializeComponent();
        }

        //init for GUI display
        private void frmMain_Load(object sender, EventArgs e)
        {                        
            currentLot = RuleInstance.GetItem(0);

            buildFunctionTree();

            lotInfomation1.Init(currentLot);

            lotInfomation1.LotChanged += new mesRelease.Controls.LotChangeEventHandler(lotInfomation1_LotChanged);

            idv.utilities.cultureLanguage.switchLanguageSync(this);
            CancelButton = btnCancel;
        }

        void lotInfomation1_LotChanged(Lot lot, ref bool accept)
        {
            currentLot = lot;
            accept = true;
        }

        void buildFunctionTree()
        {
            try
            {
                if (mainMenu == null)
                {
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm.Name.Equals("frmMain") && frm.Tag != null && frm.Tag.Equals("MES"))
                        {
                            int itmp = 0;
                            MenuStrip menu = frm.Controls["menuStrip1"] as MenuStrip;
                            if (menu == null) continue;
                            for (int i = 0; i < menu.Items.Count; i++)
                            {
                                if (menu.Items[i].Name.Equals("miView") || menu.Items[i].Name.Equals("miModules"))
                                    itmp++;
                            }
                            if (itmp == 2)
                            {
                                mainMenu = menu;
                                break;
                            }
                        }
                    }
                }
                tvwFunction.ImageList = mainMenu.ImageList;
                if (!tvwFunction.ImageList.Images.ContainsKey("folderImage"))
                    tvwFunction.ImageList.Images.Add("folderImage", Properties.Resources.folder);
                if (!tvwFunction.ImageList.Images.ContainsKey("funImage"))
                    tvwFunction.ImageList.Images.Add("funImage", Properties.Resources.function);
                bool start = false;
                foreach (ToolStripItem item in mainMenu.Items)
                {
                    if (item.Name.Equals("miModules")) break;
                    if (start && item.Visible && item.Enabled)
                    {
                        TreeNode node = tvwFunction.Nodes.Add(item.Text);
                        node.Name = item.Name;
                        node.Tag = item.Tag;
                        if (tvwFunction.ImageList.Images.ContainsKey("mnu" + node.Name))
                        {
                            node.ImageKey = "mnu" + node.Name;
                            node.SelectedImageKey = node.ImageKey;
                        }
                        else
                        {
                            node.ImageKey = "folderImage";
                            node.SelectedImageKey = node.ImageKey;
                        }
                        listFunction(item as ToolStripMenuItem, node);
                        if (node.Nodes.Count == 0)
                            tvwFunction.Nodes.Remove(node);
                    }
                    if (item.Name.Equals("miView")) start = true;
                }
                tvwFunction.ExpandAll();
                tvwFunction.Nodes[0].EnsureVisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void listFunction(ToolStripMenuItem menuItem, TreeNode parentNode)
        {
            if (menuItem == null) return;
            foreach (ToolStripItem item in menuItem.DropDownItems)
            {
                if (item.Enabled)
                {
                    TreeNode node = parentNode.Nodes.Add(item.Text);
                    node.Name = item.Name;
                    node.Tag = item.Tag;
                    node.ImageKey = "mnu" + node.Name;
                    listFunction(item as ToolStripMenuItem, node);
                    if (node.Nodes.Count == 0)
                    {
                        if (node.Tag.ToString().IndexOf("@ClientRule") == -1)
                            node.Remove();
                        else
                        {
                            if (tvwFunction.ImageList.Images.ContainsKey("mnu" + node.Name))
                            {
                                node.ImageKey = "mnu" + node.Name;
                                node.SelectedImageKey = node.ImageKey;
                            }
                            else
                            {
                                node.ImageKey = "funImage";
                                node.SelectedImageKey = node.ImageKey;
                            }
                        }
                    }
                    else
                    {
                        if (tvwFunction.ImageList.Images.ContainsKey("mnu" + node.Name))
                        {
                            node.ImageKey = "mnu" + node.Name;
                            node.SelectedImageKey = node.ImageKey;
                        }
                        else
                        {
                            node.ImageKey = "folderImage";
                            node.SelectedImageKey = node.ImageKey;
                        }
                    }
                }
            }
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
            if(currentLot == null)
            {
                idv.utilities.messageBox.showMessageById("noItemSelected");
                return false;
            }

            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!checkBeforeTxn()) return;
            currentLot.Refresh();
            lotInfomation1.ShowLot(currentLot);
        }

        private void btnLotProperty_Click(object sender, EventArgs e)
        {
            if (!checkBeforeTxn()) return;
            mesRelease.WF.WorkFlow.ExecuteRule(currentLot, "LotProperty");
        }

        private void tvwFunction_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.ToString().IndexOf("@ClientRule") == -1) return;
            TreeNode node = e.Node;
            while (node.Parent != null)
                node = node.Parent;
            
            if (node.Name.Equals("EQP"))
                mesRelease.WF.WorkFlow.ExecuteRule(mesRelease.WF.WorkFlow.CurrentEquipment, e.Node.Name);
            else
                mesRelease.WF.WorkFlow.ExecuteRule(currentLot, e.Node.Name);
        }
    }
}
