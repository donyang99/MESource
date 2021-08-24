using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mesRelease.PRP
{
    public class DCItem : idv.mesCore.PRP.dcItem<DCItem>
    {
        public DCItem() : base() { }
        public DCItem(string name) : base(name) { }

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

        internal new void putAttribute(System.Data.DataRow row, string affix)
        {
            base.putAttribute(row, affix);
        }

        public string GetCheckFailMessage()
        {
            if (message != null && !message.Trim().Equals(""))
            {
                string msg = idv.utilities.cultureLanguage.getValue(message, name);
                if (msg.Equals(""))
                    return message;
                else
                    return msg;
            }
            else
            {
                string itemName = idv.utilities.cultureLanguage.getValue(name);
                if (itemName.Equals(""))
                    return idv.utilities.cultureLanguage.getValue("msgParmCheckFail", name);
                else
                    return idv.utilities.cultureLanguage.getValue("msgParmCheckFail", itemName);
            }
        }
    }
}
