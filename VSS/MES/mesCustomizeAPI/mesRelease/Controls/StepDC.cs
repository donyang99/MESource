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
    public partial class StepDC : UserControl
    {
        public event EventHandler InputDataCompleted;
        PRP.DCItem[] dcItems = null;

        public StepDC()
        {
            InitializeComponent();
        }

        public PRP.DCItem[] GetDCItems()
        {
            List<PRP.DCItem> list = new List<PRP.DCItem>();
            if (dcItems != null)
            {
                foreach (PRP.DCItem dcItem in dcItems)
                {
                    if (isSkipDCItem(dcItem)) continue;
                    PRP.DCItem item = dcItem.Clone();
                    list.Add(item);
                }
            }
            return list.ToArray();
        }

        public int Count
        {
            get
            {
                if (dcItems == null)
                    return 0;
                else
                    return dcItems.Length;
            }
        }

        public int VisibleCount
        {
            get
            {
                if (dcItems == null)
                    return 0;
                else
                {
                    int i = 0;
                    foreach (mesRelease.PRP.DCItem item in dcItems)
                    {
                        if (isSkipDCItem(item)) continue;
                        if (item.visible)
                            i++;
                    }
                    return i;
                }
            }
        }

        idv.messageService.itemBase[] parmItems = null;
        public void SetParameters(List<idv.messageService.itemBase> itemList)
        {
            if (itemList == null)
                parmItems = new idv.messageService.itemBase[] { };
            else
                parmItems = itemList.ToArray();
        }

        public bool ValidateInputValue(bool checkInputEmptyOnly, bool showMessage, params idv.messageService.itemBase[] items)
        {
            string errMsg = "";
            return ValidateInputValue(checkInputEmptyOnly, showMessage, ref errMsg, items);
        }
        public bool ValidateInputValue(bool checkInputEmptyOnly, bool showMessage,ref string errMessage, params idv.messageService.itemBase[] items)
        {
            return ValidateInputValue(checkInputEmptyOnly, showMessage, ref errMessage, null, items);
        }

        public bool ValidateInputValue(bool checkInputEmptyOnly, bool showMessage, List<PRP.DCItem> checkFailItemsWithPath, params idv.messageService.itemBase[] items)
        {
            string errMsg = "";
            return ValidateInputValue(checkInputEmptyOnly, showMessage, ref errMsg, checkFailItemsWithPath, items);
        }
        public bool ValidateInputValue(bool checkInputEmptyOnly, bool showMessage, ref string errMessage, List<PRP.DCItem> checkFailItemsWithPath, params idv.messageService.itemBase[] items)
        {
            if (dcItems == null) return true;
            foreach (PRP.DCItem dcItem in dcItems)
            {
                if (isSkipDCItem(dcItem) || !dcItem.required) continue;
                if (dcItem.itemValue.Equals(""))
                {
                    errMessage = idv.utilities.cultureLanguage.getValue(dcItem.name);
                    if (errMessage.Equals("")) errMessage = dcItem.name;
                    errMessage = idv.utilities.cultureLanguage.getValue("msgStepDCValiddateFail", errMessage);
                    if (showMessage)
                    {
                        idv.MESApplication.PlayNGSound();
                        idv.utilities.messageBox.showMessage(errMessage);
                    }
                    return false;
                }
                else if (dcItem.dataType == idv.mesCore.DataType.Numeric)
                {
                    double d = 0;
                    if (!double.TryParse(dcItem.itemValue, out d))
                    {
                        errMessage = idv.utilities.cultureLanguage.getValue(dcItem.name);
                        if (errMessage.Equals("")) errMessage = dcItem.name;
                        errMessage = idv.utilities.cultureLanguage.getValue("msgStepDCValiddateFail", errMessage);
                        if (showMessage)
                        {
                            idv.MESApplication.PlayNGSound();
                            idv.utilities.messageBox.showMessage(errMessage);
                        }
                        return false;
                    }
                }
            }
            if (checkInputEmptyOnly) return true;//只檢查是否有沒有輸入的收集項目

            bool returnValue = true;
            bool checkDcSelf = true;
            if (items.Length == 0 && parmItems != null) items = parmItems;
            foreach (idv.messageService.itemBase item in items)
            {
                if (item is Lot)
                {
                    checkDcSelf = (item as Lot).IsCheckDcSelf();
                    break;
                }
            }
            SortedList<byte, PRP.DCItem> failList = new SortedList<byte, PRP.DCItem>();//若有多個有failPath的dcItem檢查失敗放這裏
            if (checkDcSelf)
            {
                foreach (PRP.DCItem dcItem in dcItems)
                {
                    if (isSkipDCItem(dcItem) || !dcItem.required) continue;
                    if (!dcItem.CompareValue(items))
                    {
                        errMessage = dcItem.GetCheckFailMessage();
                        if (showMessage)
                        {
                            idv.MESApplication.PlayNGSound();
                            idv.utilities.messageBox.showMessage(errMessage);
                        }

                        if (dcItem.checkFailPath.Trim().Equals(""))//沒有檢查失敗要跑的路徑
                            return false;
                        else
                        {
                            returnValue = false;
                            byte key = dcItem.checkSeq;
                            while (failList.ContainsKey(key))
                                key++;
                            failList.Add(key, dcItem);
                        }
                    }
                }
            }
            if (checkFailItemsWithPath != null)
                checkFailItemsWithPath.AddRange(failList.Values);

            return returnValue;
        }

        string[] skipDCItemSysIds = new string[] { };
        bool isSkipDCItem(PRP.DCItem dcItem)
        {
            return skipDCItemSysIds.Contains(dcItem.sysid);
        }

        PRP.Product curProd = null;
        public void Init(Lot lot)
        {
            ClearValues();
            Init(lot.GetCurrentStep());
            if (curProd == null || !curProd.name.Equals(lot.productId))
            {
                curProd = WF.WorkFlow.CurrentProduct(lot.productId);
                skipDCItemSysIds = curProd.GetSkipDCItemSysIds();

                if (dcItems != null)
                {
                    foreach (PRP.DCItem item in dcItems)
                    {
                        Control lbl = tablePanel.Controls["lbl" + item.name];
                        Control txt = tablePanel.Controls[item.name];
                        if (isSkipDCItem(item))
                        {
                            if (lbl != null) lbl.Visible = false;
                            if (txt != null) txt.Visible = false;
                        }
                        else
                        {
                            if (lbl != null) lbl.Visible = true;
                            if (txt != null) txt.Visible = true;
                        }
                    }
                    AutoScrollMinSize = new Size(100, tablePanel.PreferredSize.Height);
                }
            }
        }

        public void Init(PRP.Step step)
        {
            if (idv.mesCore.systemConfig.assemblyMode)
                Init(step, idv.mesCore.PRP.DcItemTiming.TrackOut);
            else
                Init(step, idv.mesCore.PRP.DcItemTiming.TrackIn);
        }

        bool _inited = false;
        public void Init(PRP.Step step, idv.mesCore.PRP.DcItemTiming timing)
        {
            if (_inited) return;
            _inited = true;
            List<PRP.DCItem> lstDcItem = new List<PRP.DCItem>();
            foreach (PRP.DCItem item in step.DCItemsGet())
            {
                if (item.timing == timing || item.timing == idv.mesCore.PRP.DcItemTiming.Both)
                    lstDcItem.Add(item);
            }
            dcItems = lstDcItem.ToArray();
            tablePanel.Controls.Clear();
            tablePanel.RowCount = 2;
            while (tablePanel.RowStyles.Count > 2)
                tablePanel.RowStyles.RemoveAt(tablePanel.RowStyles.Count - 1);
            for (int i = 0; i < dcItems.Length; i++)
            {
                PRP.DCItem dcItem = dcItems[i];
                Control txt = null;
                if (dcItem.dataType == idv.mesCore.DataType.Options)
                {
                    ComboBox c = new ComboBox();
                    c.MaxLength = dcItem.length;
                    c.Enabled = dcItem.enabled;
                    c.DropDownStyle = ComboBoxStyle.DropDownList;
                    c.Items.AddRange(dcItem.GetOptionList());
                    c.SelectedValueChanged += new EventHandler(txt_TextChanged);
                    txt = c;
                }
                else
                {
                    TextBox t = new TextBox();
                    t.MaxLength = dcItem.length;
                    t.ReadOnly = !dcItem.enabled;
                    t.TextChanged += new EventHandler(txt_TextChanged);
                    txt = t;
                }
                Label lbl = new Label();
                string name = dcItem.name;
                lbl.Name = "lbl" + name;
                lbl.Text = name;
                lbl.Tag = name;
                lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                lbl.AutoSize = true;
                txt.Name = name;
                if (dcItem.required) txt.BackColor = SystemColors.Info;
                txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
                txt.KeyUp += new KeyEventHandler(txt_KeyUp);

                if (!dcItem.enabled)
                    txt.BackColor = SystemColors.Control;

                if (dcItem.visible)
                {
                    tablePanel.RowCount++;
                    tablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tablePanel.Controls.Add(lbl, 0, i);
                    tablePanel.Controls.Add(txt, 1, i);
                }
            }

            AutoScrollMinSize = new Size(100, tablePanel.PreferredSize.Height);
        }

        public bool AssignFromContains(string className)
        {
            foreach (mesRelease.PRP.DCItem dcItem in dcItems)
            {
                if (isSkipDCItem(dcItem)) continue;
                if (dcItem.assignFrom.Equals(className))
                    return true;
            }
            return false;
        }

        public bool CompareToContains(string className)
        {
            foreach (mesRelease.PRP.DCItem dcItem in dcItems)
            {
                if (isSkipDCItem(dcItem)) continue;
                if (dcItem.compareTo.Equals(className))
                    return true;
            }
            return false;
        }

        Dictionary<string, bool> userInputCol = new Dictionary<string, bool>();
        bool isUserInput(string name)
        {
            if (!userInputCol.ContainsKey(name))
                return false;
            else
                return userInputCol[name];
        }

        public void ApplyValues(params idv.messageService.itemBase[] items)
        {
            if (dcItems == null) return;
            foreach (PRP.DCItem dcItem in dcItems)
            {
                if (isSkipDCItem(dcItem)) continue;
                if (isUserInput(dcItem.name)) continue;
                foreach (idv.messageService.itemBase item in items)
                {
                    if (dcItem.AssignValue(item))
                    {
                        Control ctl = tablePanel.Controls[dcItem.name];
                        if (ctl != null)
                            ctl.Text = dcItem.itemValue;
                    }
                }
            }
        }
        public void ApplyValue(string nameOrSysid, string value)
        {
            foreach (PRP.DCItem dcItem in dcItems)
            {
                if (isSkipDCItem(dcItem)) continue;
                if (isUserInput(dcItem.name)) continue;

                if (dcItem.name.Equals(nameOrSysid) || dcItem.sysid.Equals(nameOrSysid))
                {
                    dcItem.itemValue = value;
                    Control ctl = tablePanel.Controls[dcItem.name];
                    if (ctl != null)
                        ctl.Text = dcItem.itemValue;
                }
            }
        }

        public void ClearValues()
        {
            userInputCol.Clear();
            parmItems = null;
            foreach(Control ctrl in tablePanel.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
                else if (ctrl is ComboBox)
                    (ctrl as ComboBox).SelectedIndex = -1;
            }
        }

        public new void AutoSize(int add)
        {
            Height = tablePanel.PreferredSize.Height;            
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control txt = sender as Control;
                PRP.DCItem dcItem = getDCItem(txt.Name);
                dcItem.itemValue = txt.Text;
            }
            catch { }
        }

        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Control txt = sender as Control;
                PRP.DCItem dcItem = getDCItem(txt.Name);
                if (dcItem.dataType == idv.mesCore.DataType.Numeric)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                        e.Handled = true;
                    else if (e.KeyChar == '-')
                    {
                        if (txt.Text.IndexOf('-') >= 0 || (txt is TextBox && (txt as TextBox).SelectionStart > 0))
                            e.Handled = true;
                    }
                    else if (e.KeyChar == '.' && (txt.Text.IndexOf('.') >= 0 || txt.Text == ""))
                        e.Handled = true;
                }

                if(!e.Handled)
                    userInputCol[txt.Name] = true;
            }
            catch { }
        }

        void txt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Control txt = sender as Control;
                PRP.DCItem dcItem = getDCItem(txt.Name);
                if (e.KeyCode == Keys.Enter && !txt.Text.Equals(""))
                {
                    int maxVisibleIndex = 0;
                    int curItemIndex = 0;
                    for (int i = 0; i < dcItems.Length; i++)
                    {
                        if (!isSkipDCItem(dcItems[i]))
                            maxVisibleIndex = i;
                        if (dcItem == dcItems[i])
                            curItemIndex = i;
                    }
                    if (maxVisibleIndex == curItemIndex)
                    {
                        if (InputDataCompleted != null)
                            InputDataCompleted(this, new EventArgs());
                    }
                    else
                        SendKeys.SendWait("{TAB}");
                }
            }
            catch { }
        }

        PRP.DCItem getDCItem(string name)
        {
            if (dcItems == null)
                return null;
            else
            {
                foreach (PRP.DCItem dcItem in dcItems)
                {
                    if (dcItem.name.Equals(name))
                        return dcItem;
                }
            }
            return null;
        }

        public bool PutDcItemValue(string name, string value)
        {
            PRP.DCItem item = getDCItem(name);
            if (item == null)
                return false;
            else
            {
                item.itemValue = value;
                Control ctl = tablePanel.Controls[name];
                if (ctl != null)
                    ctl.Text = value;
            }
            return true;
        }

        public bool PutDcItemValue(PRP.DCItem dcItem)
        {
            return PutDcItemValue(dcItem.name, dcItem.itemValue);
        }
    }
}
