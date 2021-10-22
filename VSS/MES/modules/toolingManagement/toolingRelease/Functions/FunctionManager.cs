using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mesRelease.TOL.Functions
{
    public class funInfo
    {
        public string name { get; set; }
        public string privilege { get; set; }
        public string tag { get; set; }
        public string icon { get; set; }
    }
    public class FunctionManager
    {
        public static List<funInfo> GetFunctionInfoList()
        {
            List<funInfo> list = new List<funInfo>();
            funInfo funInfo = new funInfo();
            funInfo.name = "FunctionSample";
            funInfo.privilege = "Report";//IDE:TOL:TOOLINGID:FUNCTION:REPORT
            funInfo.tag = "Report";
            funInfo.icon = "tolReport.ico";
            list.Add(funInfo);

            return list;
        }

        public static void ExecuteFunction(string funName, ToolingId selectedTooling)
        {
            switch (funName)
            { 
                case "FunctionSample":
                    new frmFunctionSample().ShowDialog();
                    break;
            }
        }
    }
}
