using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mesFABMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //if (IsRunning())
            //{
            //    Application.ExitThread();
            //    MessageBox.Show("One Instance Of This Application Allowed.");
            //    return;
            //}            

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!CheckSource())
                return;
            if (!updateFiles(args))
                return;

            if (!idv.messageService.serviceHost.connectState)
            {
                MessageBox.Show("無法連接伺服器，請聯絡相關人員\nConnect to Server fail...");
            }
            else
                Application.Run(new frmMain(args));
        }

        static System.Threading.Mutex MyMutex;
        static bool IsRunning()
        {
            bool isNew;
            MyMutex = new System.Threading.Mutex(true, Application.ProductName, out isNew);
            if (isNew)
                return false;
            else
            {
                GC.KeepAlive(MyMutex);
                return true;
            }
        }

        static bool updateFiles(string[] args)
        {
            foreach (string s in args)
            {
                if (s.Equals("-i"))//ignore update
                    return true;
            }
            frmUpdating frmWait = new frmUpdating();
            frmWait.Show();
            frmWait.Refresh();

            lstArgus.AddRange(args);
            try
            {
                if (Properties.Settings.Default.UpdateType == "0")
                    return idv.updater.Updater.Update(lstArgus.ToArray());
                else
                    return updateFilesByTxn(args);
            }
            catch { return true; }
            finally
            {
                frmWait.Close();
            }
        }

        static bool updateFilesByTxn(string[] args)
        {
            mesRelease.Updater.MESUpdater updater = new mesRelease.Updater.MESUpdater();
            updater.localPath = idv.messageService.clientInfo.baseDirectory;
            updater.remotePath = idv.updater.Updater.sourcePath;
            updater.localTempPath = updater.localPath + "\\" + System.Guid.NewGuid().ToString();
            updater.excludePaths.AddRange(idv.updater.Updater.IgnorePath);
            updater.excludeFile = "localSetting.config,dsLang.xml";
            if (idv.updater.Updater.IgnoreFile.Count != 0)
                updater.excludeFile += "," + string.Join(",", idv.updater.Updater.IgnoreFile.ToArray());
            updater.action = idv.mesCore.Updater.Action.Update;
            updater.Init();
            updater = updater.doTxn();
            if (updater.Count > 0)
            {
                updater.Update();
                if (!System.IO.Directory.Exists(updater.localTempPath))
                    return true;

                string argus = "\"-w 2\" \"-s " + updater.localTempPath + " \" " +
                               "\"-d " + updater.localPath + "\" " +
                               "\"-t 1 \" " +
                               "\"-l\" " +
                               "\"-e " + AppDomain.CurrentDomain.FriendlyName + "\" " +
                               "\"-a '" + string.Join("' '", args) + "'\"";
                System.Diagnostics.Process.Start("fileCopy.exe", argus);
                idv.messageService.serviceHost.getHostClient.close();
                return false;
            }
            else
                return true;
        }

        static List<string> lstArgus = new List<string>();
        static bool CheckSource()
        {
            bool result = true;
            string checkFile = "";
            string checkContext = "";
            try
            {
                System.Data.DataSet dsConFile = idv.messageService.serviceHost.Client.getDataSetWithParameter("select * from MES_SYSTEM_CONFIG_FILE where user_id=?", "system");
                foreach (System.Data.DataRow row in dsConFile.Tables[0].Rows)
                {
                    switch (row["item"].ToString())
                    {
                        case "check":
                            checkFile = row["file_name"].ToString();
                            checkContext = row["contents"].ToString();
                            lstArgus.Add("-checkFile " + checkFile);
                            lstArgus.Add("-checkContext " + checkContext);
                            break;
                        case "updater":
                            if (!row["contents"].ToString().Equals(""))
                            {
                                string filePath = idv.utilities.cultureLanguage.assemblyPath + "\\" + row["file_name"].ToString();
                                if (System.IO.File.Exists(filePath))
                                    System.IO.File.SetAttributes(filePath, System.IO.FileAttributes.Normal);
                                System.IO.File.WriteAllText(filePath, row["contents"].ToString());
                            }
                            break;
                    }
                }
            }
            catch
            {
                return false;
            }
            return result;
        }
    }
}
