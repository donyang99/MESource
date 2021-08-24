using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace mesBasicDataBlank
{
    public partial class frmMain : Form
    {
        idv.mesCore.brmExtension brmExt = null;
        public frmMain()
        {
            InitializeComponent();
            functionTree1.privilegeStringPrefix = appInstance.PrivilegeString;
            appInstance.setMainStatusBar(standardStatusbar1);
            standardStatusbar1.setUser(mesRelease.USR.User.loginUser.name);
            standardStatusbar1.setVersion(Application.ProductVersion);
            Icon ico = idv.MESApplication.GetImageFromFile("mesBasicData.ico") as Icon;
            if (ico != null)
                Icon = ico;

            brmExt = new idv.mesCore.brmExtension(appInstance.Name, appInstance.PrivilegeString, this, appInstance.Logger, verifyUserPassword, getFormName);

            buildFunctionTree();

            brmExt.buildFunctionTreeWithDll();//

            functionTree1.CheckPrivilege(mesRelease.USR.User.loginUser);
            functionTree1.LoadPocket(mesRelease.USR.User.loginUserId);
            splitter1.DoubleClick += new EventHandler(splitter1_DoubleClick);
            standardStatusbar1.setVersion(idv.messageService.dynamicAssembly.assemblyVersion("mesBasicData.dll"));
        }

        bool verifyUserPassword()
        {
            if (!idv.mesCore.systemConfig.validateExecuteUser(1))//不需驗證就回傳true
                return true;
            else
                return mesRelease.USR.User.VerifyPassword();
        }
        string getFormName(string functionName)
        {
            return null;
        }

        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            functionTree1.AutoWidth();
        }

        void buildFunctionTree()
        {

        }
    }
}
