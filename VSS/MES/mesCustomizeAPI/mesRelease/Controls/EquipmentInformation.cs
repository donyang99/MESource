using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mesRelease.EQP;

namespace mesRelease.Controls
{
    public delegate void EquipmentChangeEventHandler(Equipment equipment, ref bool accept);
    public partial class EquipmentInformation : UserControl
    {
        public event EquipmentChangeEventHandler EquipmentChanged;
        bool inited = false;
        idv.mesCore.Controls.BarcodeTextBox eqpText = new idv.mesCore.Controls.BarcodeTextBox();

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

        long _TimeoutMilliseconds = 500;
        public long TimeoutMilliseconds
        {
            get { return _TimeoutMilliseconds; }
            set { _TimeoutMilliseconds = value; }
        }

        bool _EnableBarcodeControl = false;
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
        Equipment _equipment = null;

        public Equipment equipment
        {
            get { return _equipment; }
        }

        public EquipmentInformation()
        {
            InitializeComponent();
        }

        public void Init(Equipment equipment)
        {
            try
            {
                Init();
                ShowEquipment(equipment);
            }
            catch { }
        }

        public void Init()
        {
            if (inited) return;
            if (displayProperties == null || displayProperties.Length == 0)
            {
                displayProperties = "name,state,type,recipe,owner,counter,fab".Split(',');
                displayPropertyTags = "equipmentId,state,equipmentType,recipe,owner,counter,fab".Split(',');
            }

            tablePanel.Controls.Clear();

            Label lbl = new Label();
            lbl.Name = "lblname";
            lbl.Tag = "equipmentId";
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.AutoSize = true;
            eqpText.Name = "name";
            eqpText.ReadOnly = !editable;
            if (eqpText.ReadOnly) eqpText.BackColor = SystemColors.Control;
            eqpText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            eqpText.TimeOutMilliseconds = TimeoutMilliseconds;
            eqpText.EnableBarcodeControl = EnableBarcodeControl;
            eqpText.ShowPopupMessage = ShowPopupMessage;
            eqpText.ToolTipFontSize = ToolTipFontSize;
            eqpText.CheckInputChar = CheckInputChar;
            tablePanel.RowStyles.Clear();
            tablePanel.RowCount = 2;
            tablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tablePanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tablePanel.Controls.Add(lbl, 0, 0);
            tablePanel.Controls.Add(eqpText, 1, 0);
            eqpText.Click += new EventHandler(txt_Click);
            eqpText.GotFocus += new EventHandler(txt_GotFocus);
            eqpText.BarcodeInput += new idv.mesCore.Controls.BarcodeTextBox.BarcodeInputEventHandler(eqpText_BarcodeInput);

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

        void eqpText_BarcodeInput(object sender, string barcode)
        {
            TextBox txt = sender as TextBox;
            if (txt.ReadOnly) return;

            Equipment eqp = new Equipment(txt.Text);
            if (eqp.sysid == "") eqp = null;
            bool accept = true;
            if (EquipmentChanged != null)
                EquipmentChanged(eqp, ref accept);
            if (accept)
                ShowEquipment(eqp);
        }

        public void ShowEquipment(Equipment equipment)
        {
            for (int i = 0; i < tablePanel.RowCount - 1; i++)//last row is empty
            {
                Control ctrl = tablePanel.GetControlFromPosition(1, i);
                if (equipment == null)
                    ctrl.Text = "";
                else
                    ctrl.Text = equipment.getPropertyInString(ctrl.Name);
            }
            if (equipment == null || equipment.sysid == "")
                _equipment = null;
            else
                _equipment = equipment;
        }

        string getTag(int index)
        {
            if (displayPropertyTags.Length > index && index > 0)
                return displayPropertyTags[index];
            else
                return displayProperties[index];
        }
    }
}
