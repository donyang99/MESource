using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.EQP;
using mesRelease.WIP;
using mesRelease.PRP;
using idv.mesCore.Controls;
using idv.messageService;
using idv.messageService.sql;
using mesRelease.Controls;
using ruleExtension;

namespace step_Assembly
{                                    //繼承 extensionForm
    public partial class frmTrackOut : extensionForm
    {
        Lot currenLot = null;
        public frmTrackOut()
        {
            InitializeComponent();
        }

        public override void RuleStart()//實作RuleStart--在Rule被載入時呼叫
        {                               //base.RuleInfo可取得Rule執行的相關資訊

        }

        public override void RuleEnd()//實作RuleEnd--在Rule被關閉時呼叫
        {

        }

        public override Panel GetLeftContent()//實作GetLeftContent--回傳要顯示在主過帳畫面「左方」的內容
        {
            return pnlTrackOut;
        }

        public override Panel GetBottomContent()//實作GetBottomContent--回傳要顯示在主過帳畫面「下方」的內容
        {
            return null;
        }

        public override bool LotRetrieved(Lot lot)//實作LotRetrieved--當Lot被刷入時被呼叫，回傳true=允許繼續，false=不可繼續
        {                                         //傳入的lot為被刷入的Lot
            //MessageBox.Show("LotRetrieved - " + lot.name);
            currenLot = lot;
            return true;
        }

        public override bool CheckBeforeTxn(txnBase txn, List<sqlTable> executeSQL, List<object> objectList)//實作CheckBeforeTxn--當使用者按確認鍵後被呼叫，回傳true=允許繼續，false=不可繼續
        {                                                             //傳入的executeSQL為sql陳述式的集合，可加入需要執行的sql陳述式            

            //sqlTable table = new sqlTable("table1", eDMLtype.Insert);
            //table.Add("col_1", "Lot");
            //table.Add("col_2", currenLot.name);
            //executeSQL.Add(table);
            return true;
        }

        public override void ActionAfterTxn(string result)//實作GetBottomContent--當交易確定執行成功後被呼叫
        {                                                 //傳入的result為執行的結果，在此應清空控件顯示內容
            //MessageBox.Show("ActionAfterTxn - " + result);
            currenLot = null;
        }

        public override bool SetFocus() //取得輸入焦點。若不需要，則回傳false
        {
            //textBox1.Focus();
            return false;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e) //完成最後一個輸入時呼叫InputDataComplete，請主畫面控制輸入焦點
        {
            if (e.KeyData == Keys.Enter)
                RuleInfo.InputDataComplete();
        }   
    }
}
