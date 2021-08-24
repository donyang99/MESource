using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DockLibrary = WeifenLuo.WinFormsUI.Docking;
using idv.messageService;
using idv.utilities;
using mesRelease.USR;

namespace mesFABMonitor
{
    public partial class frmMain : Form
    {
        #region 區域變數
        public static Dictionary<string, Color> stateColor = new Dictionary<string, Color>();
        public static bool includeEQAlarmInfo = Properties.Settings.Default.includeEQAlarmInfo;
        public static bool includeLotInfo = Properties.Settings.Default.includeLotInfo;
        public static int lotWarningTime = Properties.Settings.Default.lotWarningTime;//lotInfo progress bar warning time(minute)

        private Dictionary<string, object> controledObject = new Dictionary<string, object>();//存放要控制使用者權限的控制項

        private delegate void delegateMainFormNotice(string name, string message);
        private delegateMainFormNotice noticeToChildForm;

        private frmArea areaForm = new frmArea();
        private frmSummary summaryForm = new frmSummary();
        private frmNotice noticeForm = new frmNotice();
        private Dictionary<string, frmEqMonitor> dicEqMonitor = new Dictionary<string, frmEqMonitor>();
        private System.Timers.Timer tmrRefresh = new System.Timers.Timer(60000);
        private System.Timers.Timer timer = new System.Timers.Timer(Properties.Settings.Default.queryDBInterval);
        private idv.mesCore.Controls.MESListView lvwAlarmInfo = null;
        #endregion

        public frmMain()
        {
            InitializeComponent();
            serviceHost.Init(Environment.MachineName, mesRelease.WF.WorkFlow.ClientId);
            cultureLanguage.readDB();
            serviceHost.MessageNotice += new MessageNoticeEventHandler(MessageIn);
            includeEQAlarmInfo = includeEQAlarmInfo && idv.mesCore.systemConfig.validItem("alarmSystem");
            includeLotInfo = includeLotInfo && idv.mesCore.systemConfig.lotTrackingRecord;
            this.dkPanel.Dock = DockStyle.Fill;
            this.dkPanel.DocumentStyle = DockLibrary.DocumentStyle.DockingWindow;
            this.dkPanel.AllowEndUserDocking = false;
            init();
            checkModulePrivilege();
            cultureLanguage.switchLanguage(this);
            if (includeLotInfo || includeEQAlarmInfo)
            {
                if (timer.Interval > 0)
                {
                    timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
                    timer.Start();
                    timer_Elapsed(null, null);
                }

                if (includeEQAlarmInfo)
                    miNotice.PerformClick();

                if (includeLotInfo)
                {
                    tmrRefresh.Elapsed += new System.Timers.ElapsedEventHandler(tmrRefresh_Elapsed);
                    tmrRefresh.Start();
                }
            }            
            serviceHost.Register("FMS:FabMonitor");
        }

        void tmrRefresh_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (frmEqMonitor frm in dicEqMonitor.Values)
            {
                try
                {
                    frm.refresh();
                }
                catch { }
            }
        }

        public frmMain(string[] args)
            : this()
        {
            foreach (string s in args)
            {
                string[] values = s.Split(new char[] { ' ' });
                if (values[0] == "-a")
                {
                    mesRelease.USR.User.AutoLogin = true;
                    miLogin.PerformClick();
                }
            }
        }

        private void init()
        {
            ToolStripMenuItem tsmi = null;
            
            #region 可用語言
            foreach (string s in cultureLanguage.availableLanguage)
            {
                tsmi = new ToolStripMenuItem();
                tsmi.Tag = s;
                tsmi.Name = s;
                tsmi.Click += new EventHandler(language_Click);
                if (s == cultureLanguage.CurrentCulture.ToString())
                    tsmi.Enabled = false;
                else
                    tsmi.Enabled = true;
                miLanguage.DropDownItems.Add(tsmi);
            }
            #endregion                      

            //加入其它可執行功能到[Modules]選單裏
            #region 其它執行功能
            //基本資料設定
            tsmi = new ToolStripMenuItem();
            tsmi.Tag = "mesBasicData"; //切換語言的key
            tsmi.Name = "mesBasicData";
            tsmi.Text = "mesBasicData";
            tsmi.Click += new EventHandler(tsmi_Click);//加入要處理的事件名稱
            miModules.DropDownItems.Add(tsmi);
            controledObject.Add("IDE", tsmi);//將要控制的項目加到controledObject集合裏(Key=權限字串，Value=控制的按項(控制項))

            //Layout equipment擺放位置
            tsmi = new ToolStripMenuItem();
            tsmi.Tag = "layoutEquipment"; //切換語言的key
            tsmi.Name = "layoutEquipment";
            tsmi.Text = "layoutEquipment";
            tsmi.Click += new EventHandler(tsmi_Click);//加入要處理的事件名稱
            miModules.DropDownItems.Add(tsmi);
            controledObject.Add("IDE:FMS:LAYOUT:MODIFY", tsmi);//將要控制的項目加到controledObject集合裏(Key=權限字串，Value=控制的按項(控制項))
            #endregion

            #region 加入浮動面板
            //左邊顯示區域
            areaForm.areaSelected += new frmArea.areaSelectEventHandler(frmMain_areaSelected);
            areaForm.Show(this.dkPanel, DockLibrary.DockState.DockLeftAutoHide);
            
            //下方顯示統計資料
            summaryForm.Show(this.dkPanel, DockLibrary.DockState.DockBottomAutoHide);
            summaryForm.DockState = DockLibrary.DockState.Hidden;
            //上方顯示警示訊息
            if (includeEQAlarmInfo)
                lvwAlarmInfo = noticeForm.lvwAlarm;
            
            miNotice.Visible = includeEQAlarmInfo;
            #endregion
        }

        void frmMain_areaSelected(object sender, string areaId,string imageFile)
        {
            frmEqMonitor fe;
            dicEqMonitor.TryGetValue(areaId, out fe);
            if (fe==null)
            {
                fe = new frmEqMonitor(areaId, imageFile);
                fe.Name = areaId;
                fe.FormClosed += new FormClosedEventHandler(frmEqMonitor_FormClosed);

                EquipmentUpdate += fe.OnEquipmentUpdate; //for 通知機台狀態改變

                if (includeLotInfo)
                {
                    LotTrackInfoRetrieved += fe.OnLotTrackInEqRetrieved;
                    LotUpdate += fe.OnLotUpdate;
                }

                if (includeEQAlarmInfo)
                {
                    EqAlarmInfoRetrieved += fe.OnEqAlarmInfoRetrieved;
                    EqAlarmOccurred += fe.OnEqAlarmOccurred;
                }

                noticeToChildForm += fe.OnMainFormNotice;

                idv.utilities.cultureLanguage.switchLanguage(fe);

                dicEqMonitor.Add(areaId, fe);
                fe.Show(this.dkPanel, DockLibrary.DockState.Document);

                retrieveLotTrackInfoAndEqAlarmInfo();
            }
            else
            {
                fe.Show();
            }
        }

        void frmEqMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEqMonitor fe = sender as frmEqMonitor;
            if (fe != null)
            {
                EquipmentUpdate -= fe.OnEquipmentUpdate;
                LotTrackInfoRetrieved -= fe.OnLotTrackInEqRetrieved;
                LotUpdate -= fe.OnLotUpdate;
                EqAlarmInfoRetrieved -= fe.OnEqAlarmInfoRetrieved;
                EqAlarmOccurred -= fe.OnEqAlarmOccurred;
                noticeToChildForm -= fe.OnMainFormNotice;
                summaryForm.clearEqMonitor(fe);
                dicEqMonitor.Remove(fe.Name);                
            }
        }

        void tsmi_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            switch (item.Name) 
            {
                case "mesBasicData":
                    showIDEApplication(item);
                    break;
                case "layoutEquipment":
                    showLayoutEquipment(item);
                    break;
                default:
                    break;
            }
        }

        void showIDEApplication(ToolStripItem oItem)
        {
            appModuleBase bM = oItem.Tag as appModuleBase;
            if (bM == null)
            {
                try
                {
                    bM = (appModuleBase)dynamicAssembly.CreateNewInstance("mesBasicData.dll", "mesBasicData.appInstance", true);
                    oItem.Tag = bM;
                }
                catch { }
            }
            if (bM != null)
            {
                bM.showGUI();
            }
        }

        void showLayoutEquipment(ToolStripItem oItem)
        {
            frmLayout form = new frmLayout();
            try
            {
                cultureLanguage.switchLanguage(form);
                form.ShowDialog();
            }
            finally { form.Close(); }
        }

        void language_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem selMenu = sender as ToolStripMenuItem;
            if (selMenu == null) return;
            
            cultureLanguage.setCulture(selMenu.Name);
            cultureLanguage.switchLanguage(this);

            //切換Menu顯示語言
            foreach (ToolStripItem tsi in miLanguage.DropDownItems)
            {
                if (tsi.Equals(selMenu))
                    tsi.Enabled = false;
                else
                    tsi.Enabled = true;
            }

            if (noticeToChildForm != null)
            {
                noticeToChildForm("languageChange", "");
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User.LogOn();
            }
            catch { }
            
            if (User.loginUser != null)
            {
                miLogin.Enabled = false;
                miLogout.Enabled = true;
                checkModulePrivilege();
            }
        }

        private void miLogout_Click(object sender, EventArgs e)
        {
            User.LogOff();
            miLogin.Enabled = true;
            miLogout.Enabled = false;
            checkModulePrivilege();
        }

        //檢查登入者是否有權限
        private void checkModulePrivilege()
        {
            foreach (KeyValuePair<string, object> o in controledObject)
            {
                bool bPermit = false;
                if (User.loginUser != null && User.loginUser.CheckModulePrivilege(o.Key))
                    bPermit = true;

                Control ctrl = o.Value as Control;
                if (ctrl != null)
                    ctrl.Enabled = bPermit;
                else
                {
                    ToolStripItem item = o.Value as ToolStripItem;
                    if (item != null)
                        item.Enabled = bPermit;
                }
            }
            if (includeEQAlarmInfo)
                noticeForm.CheckPrivilege();
        }

        private void miArea_Click(object sender, EventArgs e)
        {
            areaForm.Show();
        }

        bool noticeFormFirstShow = true;
        private void miNotice_Click(object sender, EventArgs e)
        {
            if (noticeFormFirstShow)
            {
                noticeForm.Show(this.dkPanel, DockLibrary.DockState.DockTopAutoHide);
                cultureLanguage.switchLanguageSync(noticeForm);
            }
            else
                noticeForm.Show();
            noticeFormFirstShow = false;
        }

        private void miSummary_Click(object sender, EventArgs e)
        {
            summaryForm.Show();
        }

        private void dkPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            DockLibrary.DockPanel pnl = sender as DockLibrary.DockPanel;
            if (pnl != null)
            {
                frmEqMonitor eqMonitor = pnl.ActiveDocument as frmEqMonitor;                
                if (eqMonitor != null)
                {
                    summaryForm.setEqMonitor(eqMonitor);
                }
            }
            
        }

        private void miFullScreen_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.menuStrip1.Visible = false;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
                {
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    this.menuStrip1.Visible = true;
                    this.TopMost = false;
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bool result = idv.utilities.messageBox.showMessageById("msgAreYouSure", idv.utilities.messageStyle.askYesNo);
                if (!result)
                {
                    e.Cancel = true;
                    return;
                }
                timer.Stop();
                mesRelease.USR.User.LogOff();
                idv.messageService.serviceHost.Close();
                idv.utilities.cultureLanguage.writeToXML();
            }
            catch { }            
        }
    }
}
