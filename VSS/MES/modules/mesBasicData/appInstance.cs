using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using System.Drawing;
using System.Windows.Forms;

namespace mesBasicData
{
    public class appInstance: appModuleBase 
    {
        internal static string PrivilegeString = "IDE";
        internal static string Name = "mesBasicData";
        internal static NLog.Logger Logger = null;

        static appInstance()
        {
            Logger = NLog.LogManager.GetCurrentClassLogger();
        }

        public override string description
        {
            get
            {
                return idv.utilities.cultureLanguage.getValue(Name);
            }
        }

        public override System.Drawing.Image image
        {
            get { return Properties.Resources.basicData; }
        }

        public override void languageSwitch()
        {
            //
        }

        public override string name
        {
            get { return Name; }
        }

        public override string privilegeString
        {
            get { return PrivilegeString; }
        }

        static frmMain mainForm = null;
        public override void showGUI()
        {
            if (mainForm == null || mainForm.IsDisposed)
            {
                mainForm = new frmMain();                
                idv.utilities.cultureLanguage.switchLanguageSync(mainForm);
                mainForm.Show();
            }
            mainForm.Activate();
        }
        public override void ShowDialog()
        {
            mainForm = new frmMain();
            idv.utilities.cultureLanguage.switchLanguage(mainForm);
            mainForm.ShowDialog();
        }

        public override void userLogin()
        {
            //
        }

        public override void userLogout()
        {
            //
        }

        static idv.mesCore.Controls.StandardStatusbar _statusbar = null;
        internal static void setMainStatusBar(idv.mesCore.Controls.StandardStatusbar statusbar)
        {
            _statusbar = statusbar;
        }
        internal static void showInformation(string information)
        {
            if (_statusbar != null)
                _statusbar.setInformation(information.Replace("\n", " "));
        }
        internal static void showInformation(string information, idv.mesCore.Controls.informationType type)
        {
            if (_statusbar != null)
                _statusbar.setInformation(information.Replace("\n", " "), type);
        }
        internal static void showInformationById(string messageId)
        {
            showInformation(idv.utilities.cultureLanguage.getValue(messageId));
        }
        internal static void showInformationById(string messageId, idv.mesCore.Controls.informationType type)
        {
            showInformation(idv.utilities.cultureLanguage.getValue(messageId), type);
        }
        internal static frmMain MainForm
        {
            get { return mainForm; }
        }

        /// <summary>
        /// CheckControls for input request
        /// </summary>
        /// <param name="ctrls">inputControl, captionControl</param>
        /// <returns></returns>
        public static bool CheckInputData(params Control[] ctrls)
        {
            bool validFail = false;
            string field = "";
            foreach (Control ctrl in ctrls)
            {
                if (!validFail)
                {
                    if (ctrl.BackColor == SystemColors.Info && ctrl.Visible && ctrl.Text.Trim() == "")
                        validFail = true;
                }
                else
                {
                    field = ctrl.Text;
                    break;
                }
            }
            if (validFail)
            {
                showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", field),
                                idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else
                return true;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
