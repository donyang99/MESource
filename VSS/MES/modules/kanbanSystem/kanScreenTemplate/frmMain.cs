using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using idv.messageService;

namespace kanScreenTemplate
{
    public partial class frmMain : Form
    {
        string fab = "";
        public frmMain()
        {
            InitializeComponent();
        }

        //看板載入時被呼叫
        internal void init(Dictionary<string, string> argus)
        {
            fab = argus["fab"];//取得執行參數
            timerElapsed();
        }

        //MES有Lot, Equipment異動時被呼叫
        internal void processMessage(messageBase item)
        { 
        
        }

        //看板設定的更新時間到時被呼叫
        internal void timerElapsed()
        {
            
        }
    }
}
