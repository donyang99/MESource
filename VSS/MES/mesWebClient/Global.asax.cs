using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace mesWebClient
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            idv.messageService.serviceHost.releaseClient(Session.SessionID);
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        static Global()
        {
            idv.utilities.cultureLanguage.readDB();
            idv.messageService.serviceHost.setClientType(1);
        }

        public static void SwitchLanguage(System.Web.UI.Page page)
        {
            HttpSessionState session = HttpContext.Current.Session;
            if (session["language"] == null)
                session["language"] = new System.Globalization.CultureInfo("zh-TW");
            System.Globalization.CultureInfo lang = session["language"] as System.Globalization.CultureInfo;
            idv.utilities.cultureLanguage.switchLanguageForWeb(page, lang);
        }

        public static void SetLanguage(string language)
        {
            HttpSessionState session = HttpContext.Current.Session;
            session["language"] = new System.Globalization.CultureInfo(language);           
        }

        public static string GetLanguageValue(string key, params string[] args)
        {
            HttpSessionState session = HttpContext.Current.Session;
            if (session["language"] == null)
                session["language"] = new System.Globalization.CultureInfo("zh-TW");
            System.Globalization.CultureInfo lang = session["language"] as System.Globalization.CultureInfo;
            return idv.utilities.cultureLanguage.getValue(key, lang, args);
        }
    }
}