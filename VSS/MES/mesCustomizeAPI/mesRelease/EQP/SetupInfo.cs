using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using idv.messageService.sql;
using idv.mesCore.EQP;

namespace mesRelease.EQP
{
    public class SetupInfo : setupInfo<SetupMaterial>
    {
        public SetupInfo() : base() { }
        public SetupInfo(string eqType) : base(eqType) { }
        public SetupInfo(string eqType, string eqpSetupInfo) : base(eqType, eqpSetupInfo) { }

        protected override void OnNew(List<sqlTable> executeSQL)
        {
            
        }

        protected override void OnInit(DataRow row)
        {
            
        }

        public override void OnMaterialQuantityNotEnough(string materialType, double qtyGap)
        {
            //實作
            //當耗用物料數量不足讓批號扣時
        }

        public SetupMaterial[] ToSortedList()
        {
            SortedList<string, SetupMaterial> list = new SortedList<string, SetupMaterial>();
            int tmp = 0;
            foreach (SetupMaterial item in Items)
            {
                if (item.seq == -1)
                {
                    item.seq = 0;
                    EqType t = EqType.GetEqType(name, false);
                    for (int i = 0; i < t.trackCount; i++)
                    {
                        if (t.tracks[i].Equals(item.position))
                        {
                            item.seq = (short)i;
                            break;
                        }
                    }
                }
                if (item.position.Equals(""))
                    list.Add(item.name + item.setupDate.ToString("yyyyMMddHHmmss") + tmp.ToString("000"), item);
                else
                    list.Add(item.seq.ToString("000") + item.setupDate.ToString("yyyyMMddHHmmss") + item.name + tmp.ToString("000"), item);
                tmp++;
            }
            return list.Values.ToArray();
        }
    }
}
