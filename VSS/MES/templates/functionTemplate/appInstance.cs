using System;
using System.Collections.Generic;
using System.Text;
using idv.messageService;
using System.Drawing;
using System.Windows.Forms;

namespace functionTemplate
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
    public class appInstance: appModuleFunctionBase 
    {
        List<function> funList = new List<function>();
        public appInstance()//<=============================Need to Implememt
        {
            function fun = new function();
            fun.group = "";//指定群組時代表功能加在原有的群組裏
            fun.name = "Fun1";
            fun.image = null;
            fun.privilegeString = "FUN1";
            fun.index = -1;//順著排，不插隊
            funList.Add(fun);

            fun = new function();
            fun.group = "prpGroup";
            fun.name = "Step";//名稱及群組跟原有功能一樣，取代(或延伸)原有功能
            funList.Add(fun);

            fun = new function();
            fun.group = "prpGroup";
            fun.name = "Product";//名稱及群組跟原有功能一樣，且對應表單實作idv.messageService.appModuleFunctionFormExt界面
                                 //則延伸原有功能
            funList.Add(fun);
        }

        public override bool BelongToModule(string moduleName)//<==Need to Implement
        {
            return true;
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
            string desc = idv.utilities.cultureLanguage.getValue(functionName(index));
            if (desc.Equals(""))
                return functionName(index);
            else
                return desc;
        }

        public override Form functionForm(string name)//<<==Need to Implement
        {
            switch (name)
            { 
                case "Fun1":
                    return new frmSample();
                case "Step":
                    return new frmSample();
                case "Product":
                    return new frmSampleExt();
            }
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
                try
                {
                    Type t = Type.GetType(this.GetType().Namespace + ".frm" + functionName(index));
                    if (t != null)
                    {
                        System.Resources.ResourceManager resources = new System.Resources.ResourceManager(t);
                        return ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                    }
                    else
                        return functionForm(index).Icon;
                }
                catch { }
                return null;
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
                string desc = idv.utilities.cultureLanguage.getValue(groupName);
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
                return null;
            }//TreeNode display image(Icon or Image)
        }

        public override int groupIndex//<===================Need to Implement
        {
            get { return 10; }//Display sequence on TreeView
        }

        public override string groupName//<=================Need to Implement
        {
            get { return "functionTemplate2"; }//Name of Function Group
                                              //Key of Language_Map(Caption shown on TreeView)
        }

        public override string groupPrivilegeString//<======Need to Implement
        {
            get { return "EQP"; }//ex: IDE:EQP:EQUIPMENT:ADD
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
            showInformation(idv.utilities.cultureLanguage.getValue(messageId));
        }
        internal static void showInformationById(string messageId, idv.mesCore.Controls.informationType type)
        {
            showInformation(idv.utilities.cultureLanguage.getValue(messageId), type);
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
                showInformation(idv.utilities.cultureLanguage.getValue("requireField2").Replace("&", field),
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
