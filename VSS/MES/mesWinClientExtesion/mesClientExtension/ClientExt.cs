using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using mesRelease.EQP;
using mesRelease.WF;
using mesRelease.WIP;
using mesRelease.USR;
using mesClientInterface;
using idv.utilities;
using System.Windows.Forms;
using idv.mesCore.Controls;

namespace mesWinClient.Ext
{
    public class ClientExt: ImesClientExtension 
    {
        Form _MainForm = null;
        TreeView _FabStepTree = null;
        MESListView _LotList = null;
        MESListView _EqpList = null;
        public override void init(Form mainForm, TreeView fabStepTree, MESListView lotList, MESListView equipmentList, params object[] others)
        {
            _MainForm = mainForm;
            _FabStepTree = fabStepTree;
            _LotList = lotList;
            _EqpList = equipmentList;
            //foreach (object o in others)
            //{
            //    if (o is Dictionary<string, object>)
            //    {
            //        Dictionary<string, object> dic = o as Dictionary<string, object>;
            //        dic["autoLogoutTime"] = 10;//可透過assign autoLogoutTime指定自動登出時間
            //    }
            //}

            //prepareAutoPacking();//自動化程式使用手動過帳同功能
        }

        public override void clientClose()
        {
            //
        }

        public override void serverNotice(itemBase item)
        {
            //
        }

        public override bool userLogin(string userId)
        {
            return true;
        }

        public override void userLogout(string userId)
        {
            //
        }

        public override bool workingAreaChange(string originalArea, string newArea)
        {
            return true;
        }

        public override void dispatchByEquipment(Equipment eqp)
        {
            frmSelectLot frm = new frmSelectLot();
            try
            {
                if (eqp == null) return;
                frm.AvailableLots = Lot.GetLotsByEquipment(eqp.fab, eqp.name, false, true);
                if (frm.AvailableLots.Length == 0) return;
                if (frm.AvailableLots.Length == 1)
                {
                    WorkFlow.DispatchLot(frm.AvailableLots[0], eqp.name);
                    return;
                }
                frm.Eqp = eqp;
                frm.ShowLots(_LotList.SmallImageList);
                frm.ShowDialog();
                if (!frm.Result) return;
                WorkFlow.DispatchLot(frm.SelectedLot, eqp.name);
            }
            catch 
            {
                throw;
            }
            finally
            {
                frm.Close();
            }            
        }

        public override mesDockContent[] DockForms
        {
            get 
            {
                List<mesDockContent> list = new List<mesDockContent>();
                list.Add(new frmLotProperty());
                if(idv.mesCore.systemConfig.assemblyMode)
                    list.Add(new frmWorkInstruction());
                else
                    list.Add(new frmEqpProperty());

                return list.ToArray();
            }
        }

        public override Equipment[] WorkingAreaEquipmentLoad(mesRelease.PRP.Step step, Equipment[] equipments)
        {
            //可實作過濾掉不可選的機台
            return equipments;
        }

        public override bool WorkingAreaEquipmentSelect(mesRelease.PRP.Step step, Equipment eqp)
        {
            //可實作檢查機台是否可選

            //可實作過濾不可選擇過帳功能(Rule)
            //if (step.name.Equals("StepA"))
            //{
            //    step.retrieveRules();
            //    List<mesRelease.PRP.Rule> rules = new List<mesRelease.PRP.Rule>();
            //    foreach (mesRelease.PRP.Rule r in step.GetGUIRules())
            //    {
            //        if (r.name.Equals("MoveIn")) continue;
            //        rules.Add(r);
            //    }
            //    step.addProperty("AvailableRules", rules.ToArray());//將可選的過帳功能透過step的AvailableRules屬性傳回(Rule[]類型)
            //}

            return true;
        }

        #region 自動化程式使用手動過帳同功能

        void prepareAutoPacking()
        {
            autoPacking = getAutoStepAndEqId();
            dPanel = _MainForm.Controls["dockPanel1"] as WeifenLuo.WinFormsUI.Docking.DockPanel;
            if (!autoPacking)
            {
                for (int i = 0; i < dPanel.Contents.Count; i++)
                    dPanel.Contents[i].DockHandler.Show();
                return;
            }
            User.loginUser = new User("admin");//Auto過帳時的用戶
            User.loginUserId = User.loginUser.name;
            idv.mesCore.systemConfig.setValidItem("loginDefaultForm", false);
        }

        bool autoPacking = false;
        WeifenLuo.WinFormsUI.Docking.DockPanel dPanel = null;
        string step = "";
        string eqId = "";

        //mesWinClient啟動最後會呼叫
        public void loadComplete()
        {
            if (!autoPacking) return;

            //主頁面選單跟工具列設為不可見
            _MainForm.Controls["tableLayoutPanel1"].Visible = false;
            _MainForm.Controls["menuStrip1"].Visible = false;

            //其它視窗設為不可見
            for (int i = 0; i < dPanel.Contents.Count; i++)
                dPanel.Contents[i].DockHandler.Hide();

            List<object> parms = new List<object>();
            parms.Add(_FabStepTree.Nodes[0].Name);//fab
            parms.Add(step);//step
            parms.Add(eqId);//eqId
            parms.Add("Packing");//rule

            Type ty = Type.GetType("AutoRuleAgent.Agent, AutoRuleAgent");
            ty.InvokeMember("Enabled", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.SetProperty, null, null, new object[] { true });

            Form frm = _FabStepTree.FindForm();
            frm.GetType().GetMethod("selectAssemblyRule").Invoke(frm, parms.ToArray());
        }
        bool getAutoStepAndEqId()
        {
            foreach (string s in Environment.GetCommandLineArgs())
            {
                if (s.StartsWith("-autoStep "))
                    step = s.Replace("-autoStep ", "");
                if (s.StartsWith("-autoEqId "))
                    eqId = s.Replace("-autoEqId ", "");
            }
            if (string.IsNullOrWhiteSpace(step))
            {
                if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "autoPacking.config"))
                {
                    foreach (string s in System.IO.File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "autoPacking.config"))
                    {
                        if (s.StartsWith("stepId="))
                            step = s.Split('=')[1].Trim();
                        else if (s.StartsWith("eqpId="))
                            eqId = s.Split('=')[1].Trim();
                    }
                }
            }
            return !string.IsNullOrWhiteSpace(step);
        }

        #endregion
    }
}
