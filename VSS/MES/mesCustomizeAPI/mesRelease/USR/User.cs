using System;
using System.Collections.Generic;
using System.Text;
using idv.mesCore.USR;
using System.DirectoryServices.AccountManagement;
using System.Security.Cryptography;
using System.IO;

namespace mesRelease.USR
{
    public class User : user<User, PrivilegeString>
    {
        public User() : base() { }
        public User(string name) : base(name) { }
        protected override void OnInit(System.Data.DataRow row)
        {

        }
        protected override void OnNew(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnModify(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        protected override void OnDelete(List<idv.messageService.sql.sqlTable> executeSQL)
        {

        }

        public override bool CheckFunctionPrivilege(string privilegeString)
        {            
            return base.CheckFunctionPrivilege(privilegeString);
        }

        public override bool CheckModulePrivilege(string privilegeString)
        {
            return base.CheckModulePrivilege(privilegeString);
        }

        public static void LogOn()
        {
            if (AutoLogin)
            {
                AutoLogin = false;
                loginByAD = false;
                if (UseAD)
                {
                    UserPrincipal curUser = UserPrincipal.Current;
                    if (curUser.ContextType != ContextType.Machine)
                    {
                        try
                        {
                            string userId = curUser.Name;
                            if (userId.ToLower() == "administrator") userId = "admin";//windows administrator = mes admin
                            User u = new User(userId);
                            u.LogIn(null);//ignore password  check, keep login record
                            loginUser = u;
                            loginByAD = true;
                            if (u.fabs.Length == 1) WF.WorkFlow.loginFAB = u.fab;
                            return;
                        }
                        catch
                        { }
                    }
                }
                else
                {
                    try
                    {
                        string userId = Environment.UserName;
                        if (userId.ToLower() == "administrator") userId = "admin";//windows administrator = mes admin
                        User u = new User(userId);
                        u.LogIn(null);//ignore password  check, keep login record
                        loginUser = u;
                        if (u.fabs.Length == 1) WF.WorkFlow.loginFAB = u.fab;
                        return;
                    }
                    catch
                    { }
                }
            }

            frmLogin frm = new frmLogin();
            try
            {
                frm.ShowDialog();
            }
            finally
            {
                frm.Close();
            }
        }

        public static void LogOn(string userId, string password)
        {
            loginByAD = false;
            if (UseAD)
            {
                try
                {
                    checkAD.CheckServerAD(userId, password);
                    User user = new User(userId);
                    user.LogIn(null);
                    loginUser = user;
                    loginByAD = true;
                }
                catch(Exception ex)
                {   //用戶不是domain user, 嘗試用MES帳號登入
                    if (ex.Message.Equals("userNotFound"))
                    {
                        User user = new User(userId);
                        user.LogIn(password);
                        loginUser = user;
                    }
                    else
                        throw;
                }
            }
            else
            {
                User user = new User(userId);
                user.LogIn(password);
                loginUser = user;
            }
        }
        public static void LogOff()
        {
            if (loginUser == null) return;
            loginUser.LogOut();
            loginUser = null;
        }

        public static void ChangePassword()
        {
            ChangePassword(false);
        }
        public static void ChangePassword(bool force)
        {
            if (loginUser == null) return;
            frmChangePassword frm = new frmChangePassword();
            try
            {
                frm.force = force;
                idv.utilities.cultureLanguage.switchLanguageSync(frm);
                frm.ShowDialog();
            }
            catch { }
            finally
            {
                frm.Close();
            }
        }

        static Dictionary<string, string> _userName = new Dictionary<string, string>();
        public static string GetUserName(string userId)
        {
            lock (_userName)
            {
                if (_userName.ContainsKey(userId))
                    return _userName[userId];
                else
                {
                    string sql = "select user_name from mes_user_profile where user_id='" + userId + "'";
                    System.Data.DataSet ds = idv.messageService.serviceHost.Client.getDataSet(sql);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string userName = ds.Tables[0].Rows[0]["user_name"].ToString();
                        try
                        {
                            _userName.Add(userId, userName);
                        }
                        catch { }
                        return userName;
                    }
                    return "";
                }
            }
        }
    }


}
