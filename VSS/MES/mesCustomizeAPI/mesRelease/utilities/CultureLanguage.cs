using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.utilities;

namespace mesRelease.utilities
{
    public class CultureLanguage : cultureLanguage
    {
        public CultureLanguage(string cultureName) : base(cultureName) { } 
        public static void ReadDB()
        {
            readDB(false);
        }
        public static void ReadDB(bool force)
        {
            readDB(force);
        }
        public static void SwitchLanguage(Control ctl, params System.ComponentModel.Component[] comp)
        {
            switchLanguage(ctl, comp);
        }
        public static void SwitchLanguageSync(Control ctl, params System.ComponentModel.Component[] comp)
        {
            switchLanguageSync(ctl, comp);
        }

        public static void DoSwitch(Control ctl)
        {
            doSwitch(ctl);
        }
    }
}
