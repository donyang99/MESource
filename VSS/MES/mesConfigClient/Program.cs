using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace mesConfigClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (IsRunning() && !isDebug(args))
            {
                Application.ExitThread();
                MessageBox.Show("One Instance Of This Application Allowed.");
                return;
            }

            idv.mesCore.log.initLogger();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!CheckSource())
                return;
            if (!updateFiles(GetIgnoreFiles(args))) return;

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

        static bool isDebug(string[] args)
        {
            foreach (string s in args)
            {
                if (s.StartsWith("-d") || s.StartsWith("-restart"))
                    return true;
            }
            return false;
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
        static bool CheckSource(bool client = true)
        {
            if (!idv.messageService.serviceHost.connectState) return true;
            bool result = true;
            string checkFile = "";
            string checkContext = "";
            SortedList<int, System.Data.DataRow> srtRows = new SortedList<int, System.Data.DataRow>();
            try
            {
                System.Data.DataSet dsConFile = idv.messageService.serviceHost.Client.getDataSetWithParameter("select * from MES_SYSTEM_CONFIG_FILE where user_id=? order by item", "system");
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
                        default:
                            string item = row["item"].ToString().ToLower();
                            if (!row["contents"].ToString().Trim().Equals(""))
                            {
                                if (item.Equals("updater"))
                                    srtRows[0] = row;
                                else if (item.Equals("udr." + idv.messageService.clientInfo.computerName.ToLower()))
                                    srtRows[999] = row;
                                else if (item.StartsWith("updater"))
                                {
                                    if (item.EndsWith(".all") || (client && item.EndsWith(".client")) || (!client && item.EndsWith(".server")))
                                        srtRows[srtRows.Count + 1] = row;
                                }
                            }
                            break;
                    }

                }
                foreach (System.Data.DataRow row in srtRows.Values)
                {
                    string filePath = AppDomain.CurrentDomain.BaseDirectory + row["file_name"].ToString();
                    if (File.Exists(filePath))
                        File.SetAttributes(filePath, FileAttributes.Normal);
                    File.WriteAllText(filePath, row["contents"].ToString());
                }
            }
            catch { }
            return result;
        }

        /// <summary>獲取需要忽略的文件</summary>
        static string[] GetIgnoreFiles(string[] args)
        {
            if (args.Contains("-i") || !idv.messageService.serviceHost.connectState) return args;
            try
            {
                System.Data.DataSet dsUnUpdateFile = idv.messageService.serviceHost.Client.getDataSetWithParameter("select * from MES_MISC where ITEM= 'IgnoreFiles' and REMARK like ? and (modify_date >= ? or modify_date is null)", "%" + idv.messageService.clientInfo.computerName + "%", DateTime.Now);
                if (dsUnUpdateFile.Tables[0].Rows.Count == 0)
                    return args;

                List<string> files = new List<string>();
                foreach (System.Data.DataRow fileName in dsUnUpdateFile.Tables[0].Rows)
                {
                    if (fileName["VALUE"].ToString().Trim().Equals("-i"))
                        return args = args.Concat(new List<string> { "-i" }).ToArray();
                    foreach (string s in fileName["VALUE"].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                        files.Add(s.Trim());
                }
                args = args.Concat(new List<string> { "-i " + string.Join(",", files) }).ToArray();
            }
            catch { }
            return args;
        }
    }
}
