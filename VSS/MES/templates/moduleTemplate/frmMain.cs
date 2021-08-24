using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace moduleTemplate
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            functionTree1.privilegeStringPrefix = appInstance.PrivilegeString;
            appInstance.setMainStatusBar(standardStatusbar1);
            standardStatusbar1.setUser(mesRelease.USR.User.loginUser.name);
            standardStatusbar1.setVersion(Application.ProductVersion);

            getModuleFunctions();

            buildFunctionTree();

            buildFunctionTreeWithDll();//

            functionTree1.FunctionClicked += new idv.mesCore.Controls.FunctionTree.delFunctionClick(functionTree1_FunctionClicked);
            functionTree1.CheckPrivilege(mesRelease.USR.User.loginUser);
            functionTree1.LoadPocket(mesRelease.USR.User.loginUserId);
            splitter1.DoubleClick += new EventHandler(splitter1_DoubleClick);
            standardStatusbar1.setVersion(idv.messageService.dynamicAssembly.assemblyVersion(this.GetType().Namespace + ".dll"));
        }

        #region external Functions
        List<appModuleFunctionBase> moduleFunctions = new List<appModuleFunctionBase>();
        Dictionary<string, string> functionFormNames = new Dictionary<string, string>();
        void getModuleFunctions()
        {
            SortedList<int, appModuleFunctionBase> sortList = new SortedList<int, appModuleFunctionBase>();
            string[] file = System.IO.Directory.GetFiles(idv.messageService.clientInfo.baseDirectory, "*.dll", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string s in file)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(s);
                appModuleFunctionBase fun = null;
                try
                {
                    fun = dynamicAssembly.CreateNewInstance(fi.Name, fi.Name.Replace(fi.Extension, "") + ".appInstance", true) as appModuleFunctionBase;
                }
                catch { }
                if (fun == null || !fun.BelongToModule(appInstance.Name) || fun.groupName.EndsWith("Template")) continue;
                int grpIndex = fun.groupIndex;
                while (sortList.ContainsKey(grpIndex))
                    grpIndex++;
                sortList.Add(grpIndex, fun);
            }
            foreach (appModuleFunctionBase fun in sortList.Values)
            {
                fun.setLogger(appInstance.Logger);
                fun.setMainStatusBar(this.standardStatusbar1);
                moduleFunctions.Add(fun);
            }
        }
        void buildFunctionTreeWithDll()
        {
            foreach (appModuleFunctionBase fun in moduleFunctions)
            {
                if (!fun.groupName.Equals(""))
                {
                    if (fun.groupImage is Image)
                        imageList1.Images.Add("groupImageKey" + fun.groupName, fun.groupImage as Image);
                    else if (fun.groupImage is Icon)
                        imageList1.Images.Add("groupImageKey" + fun.groupName, fun.groupImage as Icon);
                    functionTree1.AddFunctionGroup(fun.groupName, "groupImageKey" + fun.groupName, fun.groupPrivilegeString, fun.groupIndex);
                }

                for (int i = 0; i < fun.Count; i++)
                {
                    object image = fun.functionImage(i);
                    if (image is Image)
                        imageList1.Images.Add("functionImageKey" + fun.functionName(i), image as Image);
                    else if (image is Icon)
                        imageList1.Images.Add("functionImageKey" + fun.functionName(i), image as Icon);

                    string groupName = fun.functionGroup(i);
                    if (groupName.Equals(""))
                        groupName = fun.groupName;
                    functionTree1.AddFunction(groupName, fun.functionName(i), "functionImageKey" + fun.functionName(i), fun.functionPrivilegeString(i), fun.functionIndex(i));
                }
            }
        }
        bool showExternalFunctionForm(string functionName, string modulePrivilegeString, string functionPrivilegeString, ref appModuleFunctionFormExt extForm)
        {
            string formName = "frm" + functionName;
            if (functionFormNames.ContainsKey(functionName))
                formName = functionFormNames[functionName];
            Form form = getChildForm(formName);
            if (form == null)
            {
                try
                {
                    foreach (appModuleFunctionBase fun in moduleFunctions)
                    {
                        for (int i = 0; i < fun.Count; i++)
                        {
                            if (fun.functionName(i).Equals(functionName))
                            {
                                Form frm = fun.functionForm(i);
                                if (frm != null)
                                {
                                    if (frm is appModuleFunctionFormExt)
                                        extForm = frm as appModuleFunctionFormExt;
                                    else
                                        form = frm;
                                }
                            }
                        }
                        if (extForm != null && form != null)
                            break;
                    }
                }
                catch { }
                if (form != null)
                {
                    if (!verifyUserPassword()) return true;//有找到表單就要回傳true (不會執行顯示本地端form邏輯)
                    if (!form.IsMdiContainer)
                        form.MdiParent = this;
                    if (extForm != null && form is appModuleFunctionForm)
                        (form as appModuleFunctionForm).SetExtForm(extForm);

                    if (imageList1.Images.ContainsKey(functionTree1.SelectedNode.ImageKey))
                    {
                        try
                        {
                            using (Bitmap bmp = new Bitmap(imageList1.Images[functionTree1.SelectedNode.ImageKey]))
                            {
                                form.Icon = Icon.FromHandle(bmp.GetHicon());
                            }
                        }
                        catch { }
                    }

                    form.Show();
                    idv.utilities.cultureLanguage.switchLanguage(form);
                    handleActionToolbar(form, modulePrivilegeString, functionPrivilegeString);
                    form.Location = new Point(0, 0);
                    functionFormNames[functionName] = form.Name;
                }
            }
            if (form == null)
                return false;
            else
            {
                form.Activate();
                return true;
            }
        }
        #endregion

        void functionTree1_FunctionClicked(string functionName, string modulePrivilegeString, string functionPrivilegeString)
        {
            standardStatusbar1.setInformation("");
            appModuleFunctionFormExt extForm = null;
            if (showExternalFunctionForm(functionName, modulePrivilegeString, functionPrivilegeString, ref extForm)) return;
            string formName = "frm" + functionName;
            showChildForm(formName, modulePrivilegeString, functionPrivilegeString, extForm);
        }
        bool verifyUserPassword()
        {
            if (!idv.mesCore.systemConfig.validateExecuteUser(1))//不需驗證就回傳true
                return true;
            else
                return mesRelease.USR.User.VerifyPassword();
        }
        internal Form getChildForm(string formName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(formName))
                    return f;
            }
            return null;
        }

        internal Form showChildForm(string formName, appModuleFunctionFormExt extForm)
        {
            showChildForm(formName, "", "", extForm);
            return getChildForm(formName);
        }

        internal void showChildForm(string formName, string modulePrivilegeString, string functionPrivilegeString, appModuleFunctionFormExt extForm)
        {
            Form childForm = getChildForm(formName);

            if (childForm == null)
            {
                if (!verifyUserPassword()) return;
                try
                {
                    childForm = dynamicAssembly.CreateNewInstance(this.GetType().Namespace + ".dll", this.GetType().Namespace + "." + formName, true) as Form;
                    if (extForm != null && childForm is appModuleFunctionForm)
                        (childForm as appModuleFunctionForm).SetExtForm(extForm);
                    childForm.MdiParent = this;
                    if (imageList1.Images.ContainsKey(functionTree1.SelectedNode.ImageKey))
                    {
                        try
                        {
                            using (Bitmap bmp = new Bitmap(imageList1.Images[functionTree1.SelectedNode.ImageKey]))
                            {
                                childForm.Icon = Icon.FromHandle(bmp.GetHicon());
                            }
                        }
                        catch { }
                    }
                    childForm.Show();
                    idv.utilities.cultureLanguage.switchLanguage(childForm);
                    handleActionToolbar(childForm, modulePrivilegeString, functionPrivilegeString);
                    childForm.Location = new Point(0, 0);
                }
                catch { }
            }
            if (childForm != null)
                childForm.Activate();
            else
                standardStatusbar1.setInformation("can't find form -[" + formName + "]", idv.mesCore.Controls.informationType.error);
        }

        void handleActionToolbar(Control ctl, string modulePrivilegeString, string functionPrivilegeString)
        {
            if (ctl is TableLayoutPanel) return;
            foreach (idv.mesCore.Controls.ActionToolbar o in ctl.Controls.OfType<idv.mesCore.Controls.ActionToolbar>())
            {
                if (o.apPrivilegeString.Equals(""))
                    o.apPrivilegeString = appInstance.PrivilegeString;
                if (o.modulePrivilegeString.Equals(""))
                    o.modulePrivilegeString = modulePrivilegeString;
                if (o.functionPrivilegeString.Equals(""))
                    o.functionPrivilegeString = functionPrivilegeString;
                o.CheckPrivilege(mesRelease.USR.User.loginUser);
            }

            foreach (Control subCtl in ctl.Controls.OfType<Panel>())
                handleActionToolbar(subCtl, modulePrivilegeString, functionPrivilegeString);
            foreach (Control subCtl in ctl.Controls.OfType<SplitContainer>())
            {
                SplitContainer sc = subCtl as SplitContainer;
                handleActionToolbar(sc.Panel1, modulePrivilegeString, functionPrivilegeString);
                handleActionToolbar(sc.Panel2, modulePrivilegeString, functionPrivilegeString);
            }
            foreach (Control subCtl in ctl.Controls.OfType<GroupBox>())
                handleActionToolbar(subCtl, modulePrivilegeString, functionPrivilegeString);
            foreach (Control subCtl in ctl.Controls.OfType<TabControl>())
            {
                TabControl tc = subCtl as TabControl;
                foreach (TabPage tp in tc.TabPages)
                    handleActionToolbar(tp, modulePrivilegeString, functionPrivilegeString);
            }
        }

        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            functionTree1.AutoWidth();
        }

        void buildFunctionTree()
        {
            functionTree1.AddFunctionGroup("groupFMS", "car", "CAR");
            functionTree1.AddFunction("groupFMS", "carrier", "carrier", "CARRIER");
            functionTree1.AddFunction("groupFMS", "cartype", "cartype", "CARTYPE");
        }
    }
}
