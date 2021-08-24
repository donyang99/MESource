using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.WIP;

namespace mesRelease.Controls
{
    public delegate void LotChangeEventHandler(Lot lot, ref bool accept);
    public partial class LotInfomation : UserControl
    {
        public event LotChangeEventHandler LotChanged;
        bool inited = false;
        idv.mesCore.Controls.BarcodeTextBox lotText = new idv.mesCore.Controls.BarcodeTextBox();

        string[] _displayProperties = null;
        public string[] displayProperties
        {
            get { return _displayProperties; }
            set { _displayProperties = value; }
        }

        string[] _displayPropertyTags = null;
        public string[] displayPropertyTags
        {
            get { return _displayPropertyTags; }
            set { _displayPropertyTags = value; }
        }

        bool _editable = false;
        public bool editable
        {
            get { return _editable; }
            set { _editable = value; }
        }

        int _preferedHeight = 0;
        public int preferedHeight
        {
            get { return _preferedHeight; }
        }

        bool _showCustomerId = true;
        public bool showCustomerId
        {
            get { return _showCustomerId; }
            set { _showCustomerId = value; }
        }

        bool _showDueDate = true;
        public bool showDueDate
        {
            get { return _showDueDate; }
            set { _showDueDate = value; }
        }

        long _TimeoutMilliseconds = 500;
        public long TimeoutMilliseconds
        {
            get { return _TimeoutMilliseconds; }
            set { _TimeoutMilliseconds = value; }
        }

        bool _EnableBarcodeControl = true;
        public bool EnableBarcodeControl
        {
            get { return _EnableBarcodeControl; }
            set { _EnableBarcodeControl = value; }
        }

        bool _ShowPopupMessage = false;
        public bool ShowPopupMessage
        {
            get { return _ShowPopupMessage; }
            set { _ShowPopupMessage = value; }
        }

        float _ToolTipFontSize = (float)11.25;
        public float ToolTipFontSize
        {
            get { return _ToolTipFontSize; }
            set { _ToolTipFontSize = value; }
        }

        bool _CheckInputChar = false;
        public bool CheckInputChar
        {
            get { return _CheckInputChar; }
            set { _CheckInputChar = value; }
        }

        [NonSerialized]
        Lot _lot = null;

        public Lot lot
        {
            get { return _lot; }
        }

        public LotInfomation()
        {
            InitializeComponent();
        }

        public void Init(Lot lot)
        {
            try
            {
                Init();
                ShowLot(lot);
            }
            catch { }
        }

        public void Init()
        {
            if (inited) return;
            if(displayProperties == null || displayProperties.Length == 0)
            {
                displayProperties = _configDisplayProperties;
                displayPropertyTags = _configDiplayPropertyTags;
            }
            if (displayProperties == null || displayProperties.Length == 0)
            {
                displayProperties = "name,status,quantity,unit,lotType,productId,routeId,stepId,equipmentId,orderId,fab,specId,dueDate,customerId,customerDueDate".Split(',');
                displayPropertyTags = "lotId,status,quantity,unit,lotType,productId,routeId,stepId,equipmentId,orderId,fab,specId,dueDate,customerId,customerDueDate".Split(',');
            }
            List<string> lstProperty = new List<string>(displayProperties);
            List<string> lstTags = new List<string>(displayPropertyTags);
            if (!showCustomerId)
            {
                lstProperty.Remove("customerId");
                lstTags.Remove("customerId");
            }
            if (!showDueDate)
            {
                lstProperty.Remove("dueDate");
                lstTags.Remove("dueDate");
                lstProperty.Remove("customerDueDate");
                lstTags.Remove("customerDueDate");
            }
            if (!idv.mesCore.systemConfig.productParameter)
            {
                lstProperty.Remove("specId");
                lstTags.Remove("specId");
            }
            displayProperties = lstProperty.ToArray();
            displayPropertyTags = lstTags.ToArray();

            tablePanel.Controls.Clear();

            Label lbl = new Label();
            lbl.Name = "lblname";
            lbl.Tag = "lotId";
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.AutoSize = true;
            lotText.Name = "name";
            lotText.ReadOnly = !editable;
            if (lotText.ReadOnly) lotText.BackColor = SystemColors.Control;
            lotText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lotText.TimeOutMilliseconds = TimeoutMilliseconds;
            lotText.EnableBarcodeControl = EnableBarcodeControl;
            lotText.ShowPopupMessage = ShowPopupMessage;
            lotText.ToolTipFontSize = ToolTipFontSize;
            lotText.CheckInputChar = CheckInputChar;
            tablePanel.RowStyles.Clear();
            tablePanel.RowCount = 2;
            tablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tablePanel.Controls.Add(lbl, 0, 0);
            tablePanel.Controls.Add(lotText, 1, 0);
            lotText.Click += new EventHandler(txt_Click);
            lotText.GotFocus += new EventHandler(txt_GotFocus);
            lotText.BarcodeInput += new idv.mesCore.Controls.BarcodeTextBox.BarcodeInputEventHandler(lotText_BarcodeInput);

            int j = 1;
            for (int i = 0; i < displayProperties.Length; i++)
            {
                if (displayProperties[i] == "name") continue;
                TextBox txt = new TextBox();
                lbl = new Label();
                string name = displayProperties[i];
                lbl.Name = "lbl" + name;
                lbl.Tag = getTag(i);
                lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                lbl.AutoSize = true;
                txt.Name = name;
                txt.ReadOnly = true;
                txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                txt.GotFocus += new EventHandler(txt_GotFocus);
                txt.Click += new EventHandler(txt_Click);
                tablePanel.RowCount++;
                tablePanel.RowStyles.Insert(j, new RowStyle(SizeType.AutoSize));
                tablePanel.Controls.Add(lbl, 0, j);
                tablePanel.Controls.Add(txt, 1, j);
                j++;
            }
            inited = true;
            AutoScrollMinSize = new Size(100, tablePanel.PreferredSize.Height);
            _preferedHeight = AutoScrollMinSize.Height;
        }

        object lastClickObject = null;
        void txt_Click(object sender, EventArgs e)
        {
            if (lastClickObject == sender) return;
            (sender as TextBox).SelectAll();
            lastClickObject = sender;
        }

        void txt_GotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        void lotText_BarcodeInput(object sender, string barcode)
        {
            TextBox txt = sender as TextBox;
            if (txt.ReadOnly) return;

            Lot lot = Lot.GetLotByAny(txt.Text);
            bool accept = true;
            if (LotChanged != null)
                LotChanged(lot, ref accept);
            if (accept)
                ShowLot(lot);
        }

        public void ShowLot(Lot lot)
        {
            for (int i = 0; i < tablePanel.RowCount - 1; i++)//last row is empty
            {
                Control ctrl = tablePanel.GetControlFromPosition(1, i);
                if (lot == null)
                    ctrl.Text = "";
                else
                    ctrl.Text = lot.getPropertyInString(ctrl.Name);
            }
            if (lot == null || lot.sysid == "")
                _lot = null;
            else
                _lot = lot;
        }

        string getTag(int index)
        {
            if (displayPropertyTags.Length > index && index > 0)
                return displayPropertyTags[index];
            else
                return displayProperties[index];
        }

        static string[] _configDisplayProperties = null;
        static string[] _configDiplayPropertyTags = null;
        static LotInfomation()
        {
            if(!System.IO.File.Exists(idv.messageService.clientInfo.baseDirectory + "\\lotInformation.config")) return;
            string allText = System.IO.File.ReadAllText(idv.messageService.clientInfo.baseDirectory + "\\lotInformation.config");
            foreach(string s in allText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {                
                if(s.StartsWith("displayProperties"))
                {
                    _configDisplayProperties = s.Split('=')[1].Trim().Split(',');
                }
                else if(s.StartsWith("displayPropertyTags"))
                {
                    _configDiplayPropertyTags = s.Split('=')[1].Trim().Split(',');
                }
            }
        }
    }
}
