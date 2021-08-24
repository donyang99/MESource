using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.Updater;

namespace mesRelease.Updater
{
    public class MESUpdater : mesUpdater
    {
        public new MESUpdater doTxn()
        {
            return base.doTxn() as MESUpdater;
        }
    }
}
