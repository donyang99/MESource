using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.messageService;
using idv.mesCore.PRP;

namespace dcItemExtension
{
    public class ExtInstance : IdcItemExt
    {
        public bool CheckData(dcItemBase dcItem, params itemBase[] items)
        {
            int value = 0;
            int.TryParse(dcItem.itemValue, out value);
            if (value == 0)
                return false;
            else
            {
                dcItem.itemValue = (value * value).ToString();
                return true;
            }
        }
    }
}
