using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.WIP;
using idv.messageService;
using idv.messageService.sql;
using idv.mesCore.WIP.Txn;

namespace mesRelease.WIP.Txn
{
    public class SplitLotInfo : splitLotInfo<Lot>
    {
        ComponentInfo _componentInfo = null;
        public ComponentInfo componentInfo
        {
            get { return _componentInfo; }
            set { _componentInfo = value; }
        }

        protected override componentInfoBase getComponentInfo()
        {
            return componentInfo;
        }

        List<CAR.Carrier> _carrierList = new List<CAR.Carrier>();
        public List<CAR.Carrier> carrierList
        {
            get { return _carrierList; }
            set { _carrierList = value; }
        }

        protected override int carrierCount
        {
            get { return carrierList.Count; }
        }
        protected override idv.mesCore.CAR.carrierBase getCarrier(int index)
        {
            return carrierList[index];
        }

        protected override void OnInitChildLot(Lot childLot, Lot parentLot)
        {
            
        }
    }
}
