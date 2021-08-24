using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using idv.mesCore.BAS;

namespace mesRelease.BAS
{
    public class LotType : lotType<LotType>
    {
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

        //static member
        public static bool IsCheckFutureHold(string lotType)
        {
            LotType t = GetLotType(lotType);
            if (t != null)
                return t.checkFutureHold;
            else
                return true;
        }

        public static bool IsCheckQTime(string lotType)
        {
            LotType t = GetLotType(lotType);
            if (t != null)
                return t.checkQTime;
            else
                return true;
        }

        public static bool IsCheckDcSelf(string lotType)
        {
            LotType t = GetLotType(lotType);
            if (t != null)
                return t.checkDcSelf;
            else
                return true;
        }

        public static bool IsCheckDcSpec(string lotType)
        {
            if (!idv.mesCore.systemConfig.productParameter) return false;
            LotType t = GetLotType(lotType);
            if (t != null)
                return t.checkDcSpec;
            else
                return true;
        }

        public static bool IsCheckRecipe(string lotType)
        {
            if (!idv.mesCore.systemConfig.parmEqTypeFlag) return false;
            LotType t = GetLotType(lotType);
            if (t != null)
                return t.checkRecipe;
            else
                return true;
        }

        public static bool IsCheckMaterial(string lotType)
        {
            if (!idv.mesCore.systemConfig.materialTracking || !idv.mesCore.systemConfig.productParameter) return false;
            LotType t = GetLotType(lotType);
            if (t != null)
                return t.checkMaterial;
            else
                return true;
        }

        public static bool IsCheckTooling(string lotType)
        {
            if (!idv.mesCore.systemConfig.validItem("toolingManagement") || !idv.mesCore.systemConfig.productParameter) return false;
            LotType t = GetLotType(lotType);
            if (t != null)
                return t.checkTooling;
            else
                return true;
        }
    }
}
