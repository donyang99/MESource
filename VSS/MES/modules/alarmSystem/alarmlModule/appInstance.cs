using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using idv.messageService;
using idv.utilities;

namespace alarmModule
{
    public class function
    {
        public string group = "";
        public string name = "";
        public object image = null;
        public string privilegeString = "";
        public int index = -1;
        public override string ToString()
        {
            return name;
        }
    }
    public class appInstance : appModuleFunctionBase 
    {
        List<function> funList = new List<function>();
        public appInstance()//<=============================Need to Implememt
        {
            function fun = new function();
            fun.group = "";
            fun.name = "AlarmType";
            fun.image = null;
            fun.privilegeString = "ALARMTYPE";
            fun.index = -1;
            funList.Add(fun);

            fun = new function();
            fun.group = "";
            fun.name = "AlarmReason";
            fun.image = null;
            fun.privilegeString = "ALARMREASON";
            fun.index = -1;
            funList.Add(fun);

            fun = new function();
            fun.group = "";
            fun.name = "AlarmMessage";
            fun.image = null;
            fun.privilegeString = "ALARMMESSAGE";
            fun.index = -1;
            funList.Add(fun);

            fun = new function();
            fun.group = "";
            fun.name = "AlarmHistory";
            fun.image = null;
            fun.privilegeString = "ALARMHISTORY";
            fun.index = -1;
            funList.Add(fun);
        }

        public override bool BelongToModule(string moduleName)//<==Need to Implement
        {
            if (!moduleName.Equals("mesBasicData")) return false;
            return idv.mesCore.systemConfig.validItem("alarmSystem");
        }

        public override int Count
        {
            get { return funList.Count; }
        }

        public override string functionGroup(int index)
        {
            return funList[index].group;
        }

        public override string functionDescription(int index)
        {
            string desc = cultureLanguage.getValue(functionName(index));
            if (desc.Equals(""))
                return functionName(index);
            else
                return desc;
        }

        public override Form functionForm(string name)//<<==Need to Implement
        {
            try
            {
                return dynamicAssembly.CreateNewInstance(this.GetType().Namespace + ".dll", this.GetType().Namespace + ".frm" + name, true) as Form;
            }
            catch { }
            return null;
        }

        public override Form functionForm(int index)
        {
            return functionForm(functionName(index));
        }

        public override object functionImage(int index)
        {
            if (funList[index].image != null)
                return funList[index].image;
            else
            {
                return functionForm(index).Icon;
            }
        }

        public override string functionName(int index)
        {
            return funList[index].name;
        }

        public override string functionPrivilegeString(int index)
        {
            return funList[index].privilegeString;
        }

        public override int functionIndex(int index)
        {
            return funList[index].index;
        }

        public override string groupDescription
        {
            get
            {
                string desc = cultureLanguage.getValue(groupName);
                if (desc.Equals(""))
                    return groupName;
                else
                    return desc;
            }
        }

        public override object groupImage//<================Need to Implement
        {
            get 
            {
                return Properties.Resources.alarm;
            }//TreeNode display image(Icon or Image)
        }

        public override int groupIndex//<===================Need to Implement
        {
            get { return 30; }//Display sequence on TreeView
        }

        public override string groupName//<=================Need to Implement
        {
            get { return "alarmModule"; }//Name of Function Group
                                              //Key of Language_Map(Caption shown on TreeView)
        }

        public override string groupPrivilegeString//<======Need to Implement
        {
            get { return "ALM"; }//ex: IDE:EQP:EQUIPMENT:ADD
                                 //    ==>|   |<==
        }

        public override void setMainStatusBar(object statusBar)
        {
            _statusbar = statusBar as idv.mesCore.Controls.StandardStatusbar;
        }

        public override void setLogger(object logger)
        {
            Logger = logger as NLog.Logger;
        }

        internal static NLog.Logger Logger = null;
        static idv.mesCore.Controls.StandardStatusbar _statusbar = null;

        static appInstance()
        {
            
        }
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
            showInformation(cultureLanguage.getValue(messageId));
        }
        internal static void showInformationById(string messageId, idv.mesCore.Controls.informationType type)
        {
            showInformation(cultureLanguage.getValue(messageId), type);
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
                    if (ctrl.BackColor == SystemColors.Info && ctrl.Text.Trim() == "")
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
                showInformation(cultureLanguage.getValue("requireField2").Replace("&", field),
                                idv.mesCore.Controls.informationType.warn);
                return false;
            }
            else
                return true;
        }
        public override string ToString()
        {
            return groupName;
        }
       
    }
}
