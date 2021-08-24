using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace functionTemplate
{
    public partial class frmSampleExt : Form, idv.messageService.appModuleFunctionFormExt
    {
        public frmSampleExt()
        {
            InitializeComponent();
        }

        public List<idv.messageService.appModuleFunctionFormControlDefine> Init(Form ownerForm, Panel ownerPanel, List<string> columnNames, List<string> columnTags)
        {//畫面開啟時被調用  
            
            columnNames.Add("customer");//增加要顯示在清單中的欄位
            columnTags.Add("customer");//增加要顯示在清單中欄位的語系key

            //1. 將要顯示在功能畫面上的內容整個放到ownerPanel上
            //panel1.Parent = ownerPanel;//將要顯示的內容指定Parent屬性為ownerPanel
            //panel1.Location = new Point(0, 0);
            //panel1.Dock = DockStyle.Top;

            //2. 或 將要顯示的資訊回傳，讓功能畫面排列在TableLayoutPanel裏
            List<idv.messageService.appModuleFunctionFormControlDefine> list = new List<idv.messageService.appModuleFunctionFormControlDefine>();
            idv.messageService.appModuleFunctionFormControlDefine def = new idv.messageService.appModuleFunctionFormControlDefine(); //產生顯示定義類別
            def.label = lblCustomer; //指定要顯示的Label控制項 (用以顯示欄位名稱)
            def.control = txtCustomer; //指定要顯示的Control控制項 (用來輸入或顯示欄位值)

            def.rowNum = 0; //指定Row Number (從0開始)
            def.rowLabelSpan = 1; //指定Label控制項要佔幾個row
            def.rowControlSpan = 1; //指定Control控制項要佔幾個row

            def.colNum = 0; //指定Column Number(從0開始)
            def.colLabelSpan = 1; //指定Label控制項要佔幾個column
            def.colControlSpan = 1; //指定Control控制項要佔幾個column

            def.labelAnchor = AnchorStyles.Right; //指定Label控制項Anchor
            def.controlAnchor = AnchorStyles.Left | AnchorStyles.Right; //指定Control控制項Anchor
            list.Add(def);
            
            //第二個要顯示的資訊
            def = new idv.messageService.appModuleFunctionFormControlDefine();
            def.label = label1;
            def.control = textBox1;
            def.rowNum = 0; //跟上一 個資訊Row Number一樣，則顯示在同一個Row
            def.rowLabelSpan = 1;
            def.rowControlSpan = 2;

            def.colNum = 3; //跟上一個資訊顯示在同一個Row時，指定正確的Column Number，讓此資訊排在上一個同Row Number資訊的後面
            def.colLabelSpan = 1;
            def.colControlSpan = 2;

            def.labelAnchor = AnchorStyles.Right;
            def.controlAnchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            list.Add(def);

            //第三個要顯示的資訊
            def = new idv.messageService.appModuleFunctionFormControlDefine();
            def.label = label2;
            def.control = textBox2;
            def.rowNum = 1;
            def.rowLabelSpan = 1;
            def.rowControlSpan = 1;

            def.colNum = 0;
            def.colLabelSpan = 1;
            def.colControlSpan = 1;

            def.labelAnchor = AnchorStyles.Right;
            def.controlAnchor = AnchorStyles.Left | AnchorStyles.Right;
            list.Add(def);
            return list;
        }

        public void ShowData(idv.messageService.itemBase item)
        {//資訊要顯示時被調用
            txtCustomer.Text = item.name;
        }

        public bool CheckData(string action, idv.messageService.itemBase item)
        {//新增/修改資料前檢查資料時被調用，回傳false可中止新增/修戶
            if (txtCustomer.Text.Equals(""))
            {
                idv.utilities.messageBox.showMessage("Customer is required");
                return false;
            }
            return true;
        }

        public void AssignValue(idv.messageService.itemBase item)
        {//新增/修戶資料賦值時被調用

            //item.customer = txtCustomer.Text;
        }

        public void ClearData()
        {//清除畫面顯示時被調用
            txtCustomer.Text = "";
        }

        public bool EventNotice(string eventName, idv.messageService.itemBase item, params object[] args)
        {//備用事件
            return true; 
        }

        public void Exit(Form ownerForm)
        {//主畫面關閉時被調用
            
        }

        


    }
}
