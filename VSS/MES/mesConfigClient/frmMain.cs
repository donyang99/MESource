using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace mesConfigClient
{
    public partial class frmMain : Form
    {
        delegate void noArguEvnet();
        noArguEvnet languageSwitch, userLogin, userLogout;
        idv.messageService.appModuleBase defaultModule = null;

        public frmMain()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            this.Activated += new EventHandler(frmMain_Activated);
            mesRelease.USR.User.UseAD = Properties.Settings.Default.UseAD;
        }

        bool firstActived = true;
        void frmMain_Activated(object sender, EventArgs e)
        {
            if (!firstActived) return;
            firstActived = false;
            if (_debugModule == null)
                showDefaultModule();
            else
                Close();
        }
        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string err = "";
            if (e.ExceptionObject != null)
            {
                err = e.ExceptionObject.ToString();
            }
            SaveErrorInfoToDB("UnhandledException", err);
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string err = "";
            if (e.Exception != null)
            {
                err = e.Exception.ToString();
            }
            SaveErrorInfoToDB("ThreadException", err);
        }

        void SaveErrorInfoToDB(string errFrom, string errMessage)
        {
            try
            {
                idv.messageService.sql.sqlTable table = new idv.messageService.sql.sqlTable("performancemonitor", idv.messageService.sql.eDMLtype.Insert);
                table.Add("txn_name", errFrom);
                table.Add("item_name", idv.messageService.clientInfo.computerName + "[" + idv.messageService.clientInfo.ipAddress + "]");
                table.Add("params", idv.messageService.clientInfo.loginUserName);
                table.Add("result", mesRelease.USR.User.loginUserId);
                table.Add("error_message", errMessage);
                table.Add("modify_date", DateTime.Now);
                idv.messageService.sql.sqlExecuter.executeSqlTable(table, idv.messageService.serviceHost.Client);
            }
            catch { }
        }
        public frmMain(string[] args)
            : this()
        {
            try
            {
                Tag = Properties.Settings.Default.FormTag;
                initShareComponents();
                foreach (string s in args)
                {
                    string[] values = s.Split(new char[] { ' ' });
                    if (values[0] == "-m")  //default module
                    {
                        if (values.Length <= 1) break;

                        foreach (ToolStripMenuItem tsmi in miModules.DropDownItems)
                        {
                            appModuleBase bm = tsmi.Tag as appModuleBase;
                            if (bm != null)
                            {
                                if (bm.name == values[1])
                                    defaultModule = bm;
                            }
                        }
                    }
                    else if (values[0] == "-a")
                    {
                        mesRelease.USR.User.AutoLogin = true;
                    }
                    else if (values[0] == "-d")
                    {
                        try
                        {
                            _debugUser = values[1];
                            _debugModule = values[2];
                        }
                        catch { }
                    }
                }
                if (!doDebug())
                {
                    miLogin.PerformClick();                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SaveErrorInfoToDB("mesConfigClient.frmMain", ex.ToString());
                Close();
            }
        }

        private void initShareComponents()
        {
            frmLogo logo = null; ;
            try
            {                
                logo = new frmLogo();
                logo.Show();
                logo.dispalyInformation("connecting to Server...");
                serviceHost.Init(Environment.MachineName, mesRelease.WF.WorkFlow.ClientId);
                serviceHost.Register("X");
                logo.dispalyInformation("reading culture information...");
                idv.utilities.cultureLanguage.readDB();
                ////idv.component.cultureLanguage.setCulture("en-US");

                logo.dispalyInformation("get available language...");
                foreach (string s in idv.utilities.cultureLanguage.availableLanguage)
                {
                    ToolStripMenuItem tsmi = new ToolStripMenuItem();
                    tsmi.Tag = s;
                    tsmi.Name = s;
                    tsmi.Click += new EventHandler(language_Click);
                    if (s == idv.utilities.cultureLanguage.CurrentCulture.ToString())
                        tsmi.Enabled = false;
                    else
                        tsmi.Enabled = true;
                    miLanguage.DropDownItems.Add(tsmi);
                }

                logo.dispalyInformation("get available modules...");
                getAvailableModules();

                logo.dispalyInformation("switch caption for current culture...");
                idv.utilities.cultureLanguage.switchLanguageSync(this, notifyIcon1);

                miLogout.Enabled = false;
                miChangePassword.Enabled = false;
                miChangePassword.Visible = !Properties.Settings.Default.UseAD;

                getMainFormLogo();
            }
            catch { throw; }
            finally
            {                
                logo.Close();
            }
        }
        void language_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem selMenu = sender as ToolStripMenuItem;
            if (selMenu == null) return;
            idv.utilities.cultureLanguage.setCulture(selMenu.Name);
            idv.utilities.cultureLanguage.switchLanguage(this, notifyIcon1);

            //切換Menu顯示語言
            foreach (ToolStripItem tsi in miLanguage.DropDownItems)
            {
                if (tsi.Equals(selMenu))
                    tsi.Enabled = false;
                else
                    tsi.Enabled = true;
            }
            //切換功能圖示顯示語言
            foreach (Control o in tableLayoutPanel1.Controls)
            {
                PictureBox pb = o as PictureBox;
                if (pb != null)
                {
                    appModuleBase bm = pb.Tag as appModuleBase;
                    if (bm != null)
                        toolTip1.SetToolTip(pb, idv.utilities.cultureLanguage.getValue(bm.name));
                }
            }

            if (languageSwitch != null)            
                languageSwitch.Invoke();
            
            //自動幫所有Module loaded forms換語言
            try
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (!this.Equals(f))
                        idv.utilities.cultureLanguage.switchLanguage(f);
                }
            }
            catch { }
        }

        private void getAvailableModules()
        {
            string[] file = System.IO.Directory.GetFiles(".", "*.dll", System.IO.SearchOption.AllDirectories);
            for (int i = 0; i < file.Length; i++)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(file[i]);
                try
                {
                    appModuleBase bM = (appModuleBase)dynamicAssembly.CreateNewInstance(fi.Name, fi.Name.Replace(fi.Extension, "") + ".appInstance", true);
                    if (bM == null) continue;
                    if (bM.name.EndsWith("Template")) continue;

                    ToolStripMenuItem tsmi = new ToolStripMenuItem();
                    tsmi.Name = bM.name;
                    tsmi.Text = bM.name;
                    tsmi.Click += new EventHandler(module_Click);
                    tsmi.Tag = bM;
                    tsmi.Enabled = false;

                    //將各mehtod加到degelate裏，以便用廣播的方式一次呼叫所有的物件
                    languageSwitch += bM.languageSwitch;
                    userLogin += bM.userLogin;
                    userLogout += bM.userLogout;

                    miModules.DropDownItems.Add(tsmi);

                    //加項目到圖示
                    PictureBox p = new PictureBox();
                    p.Image = bM.image;
                    p.Anchor = AnchorStyles.None;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Size = bM.image.Size;

                    p.Cursor = Cursors.No;
                    p.Tag = bM;
                    p.Click += new EventHandler(modulePicture_Click);

                    toolTip1.SetToolTip(p, idv.utilities.cultureLanguage.getValue(bM.name));

                    tableLayoutPanel1.Controls.Add(p);
                }
                catch { }
            }
        }
        void modulePicture_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                if (pb.Cursor == Cursors.No) return;
                appModuleBase bm = pb.Tag as appModuleBase;
                if (bm != null)
                    bm.showGUI();
            }
        }
        void module_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            if (tsmi != null)
            {
                appModuleBase bm = tsmi.Tag as appModuleBase;
                if (bm != null)
                    bm.showGUI();
            }
        }
        private void getMainFormLogo()
        {
            string[] file = System.IO.Directory.GetFiles(".", "logo.*", System.IO.SearchOption.AllDirectories);
            for (int i = 0; i < file.Length; i++)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(file[i]);
                try
                {
                    Image img = Image.FromFile(fi.Name);
                    pictureBox1.Image = img;
                    break;
                }
                catch { }
            }
            try
            {
                notifyIcon1.Icon = new Icon("notifyIcon.ico");
                Icon = notifyIcon1.Icon;
            }
            catch { }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                Visible = false;
                do
                {
                    if (menuStrip1.Items.Count == 0) break;
                    ToolStripItem tsi = menuStrip1.Items[0];
                    contextMenuStrip1.Items.Add(tsi);
                } while (menuStrip1.Items.Count > 0);
            }
            else
            {
                notifyIcon1.Visible = false;
                do
                {
                    if (contextMenuStrip1.Items.Count == 0) break;
                    ToolStripItem tsi = contextMenuStrip1.Items[0];
                    menuStrip1.Items.Add(tsi);
                } while (contextMenuStrip1.Items.Count > 0);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_debugModule == null)
            {
                idv.utilities.messageBox.displayDontShowMessageAgain = false;
                bool result = idv.utilities.messageBox.showMessageById("msgAreYouSure", idv.utilities.messageStyle.askYesNo);
                if (!result)
                {
                    e.Cancel = true;
                    return;
                }
            }
            try
            {
                mesRelease.USR.User.LogOff();
                idv.messageService.serviceHost.Close();
                idv.utilities.cultureLanguage.writeToXML();
            }
            catch { }
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            if (mesRelease.USR.User.loginUser == null)
            {
                mesRelease.USR.User.LogOn();
            }

            if (mesRelease.USR.User.loginUser != null)
            {
                foreach (ToolStripMenuItem tsmi in miModules.DropDownItems)
                {
                    appModuleBase bm = tsmi.Tag as appModuleBase;
                    if (bm != null)
                    {
                        //檢查各模組權限
                        tsmi.Enabled = mesRelease.USR.User.loginUser.CheckModulePrivilege(bm.privilegeString);
                    }
                    else
                    {
                        tsmi.Enabled = false;
                    }
                }


                foreach (Control o in tableLayoutPanel1.Controls)
                {
                    PictureBox pb = o as PictureBox;
                    if (pb == null) continue;
                    appModuleBase bm = pb.Tag as appModuleBase;
                    if (bm != null)
                    {
                        if (mesRelease.USR.User.loginUser.CheckModulePrivilege(bm.privilegeString))
                            pb.Cursor = Cursors.Hand;
                        else
                            pb.Cursor = Cursors.No;
                    }
                    else
                    {
                        if (pb.Tag != null)
                            pb.Cursor = Cursors.No;
                    }
                }

                if (userLogin != null)
                {
                    userLogin.Invoke();
                }
                miLogin.Enabled = false;
                miLogout.Enabled = true;
                miChangePassword.Enabled = true;

                if (mesRelease.USR.User.loginUser.language != "")
                {
                    idv.utilities.cultureLanguage.setCulture(mesRelease.USR.User.loginUser.language);
                    idv.utilities.cultureLanguage.switchLanguage(this, notifyIcon1);
                    foreach (ToolStripItem tsi in miLanguage.DropDownItems)
                    {
                        if (tsi.Tag.ToString()==mesRelease.USR.User.loginUser.language)
                            tsi.Enabled = false;
                        else
                            tsi.Enabled = true;
                    }
                }
            }
        }

        private void miLogout_Click(object sender, EventArgs e)
        {
            mesRelease.USR.User.LogOff();
            foreach (ToolStripMenuItem tsmi in miModules.DropDownItems)
            {
                tsmi.Enabled = false;
                //功能圖示
            }

            foreach (Control o in tableLayoutPanel1.Controls)
            {
                PictureBox pb = o as PictureBox;
                if (pb != null)
                {
                    if (pb.Tag == null) continue;
                    pb.Cursor = Cursors.No;
                }
            }

            if (userLogout != null)
            {
                userLogout.Invoke();
            }

            //自動關掉所有Module loaded forms
            try
            {
                int i = 0;
                do
                {
                    if (Application.OpenForms[i].Equals(this))
                        i++;
                    Application.OpenForms[i].Close();
                } while (Application.OpenForms.Count > 1);
            }
            catch { }

            miLogin.Enabled = true;
            miLogout.Enabled = false;
            miChangePassword.Enabled = false;
        }

        private void miChangePassword_Click(object sender, EventArgs e)
        {
            mesRelease.USR.User.ChangePassword();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        void showDefaultModule()
        {
            if (defaultModule != null)
            {
                if (mesRelease.USR.User.loginUser != null)
                {
                    if (mesRelease.USR.User.loginUser.CheckModulePrivilege(defaultModule.privilegeString))
                    {
                        defaultModule.showGUI();
                        this.WindowState = FormWindowState.Minimized;
                        return;
                    }
                }
            }
            this.WindowState = FormWindowState.Normal;
        }

        private string _debugModule = null;
        private string _debugUser = null;
        private bool doDebug()
        {
            if (_debugModule == null) return false;
            try
            {
                appModuleBase bM = (appModuleBase)dynamicAssembly.CreateNewInstance(_debugModule + ".dll", _debugModule + ".appInstance", true);
                languageSwitch += bM.languageSwitch;
                userLogin += bM.userLogin;
                userLogout += bM.userLogout;

                mesRelease.USR.User u = new mesRelease.USR.User(_debugUser);
                if (u.sysid == "") throw new Exception("Can't find User [" + _debugUser + "]");
                mesRelease.USR.User.loginUser = u;
                bM.ShowDialog();                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
