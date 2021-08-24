using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;

namespace ClientRule.HoldLotReport
{
    public class ColumnSetting
    {
        bool _AutoSize = false;
        int _Width;
        public HorizontalAlign HAlign = HorizontalAlign.NotSet;
        public HorizontalAlign CaptionHAlign = HorizontalAlign.Center;

        public System.Drawing.Color BackColor = System.Drawing.Color.White;
        public System.Drawing.Color CaptionBackColor = System.Drawing.Color.LightGray;

        public string Format = "";

        public int Width
        {
            get { return _Width; }
            set
            {
                _Width = value;
                if (_Width == 0)
                    AutoSize = true;
            }
        }
        public bool AutoSize
        {
            get { return _AutoSize; }
            set
            {
                _AutoSize = value;
                if (_AutoSize && lbl == null)
                {
                    lbl = new System.Windows.Forms.Label();
                    frm.Controls.Add(lbl);
                    lbl.AutoSize = true;
                }
            }
        }
        public ColumnSetting()
        {

        }
        public ColumnSetting(int width, HorizontalAlign align, HorizontalAlign captionAlign, string format, string fieldName)
        {
            Width = width;
            HAlign = align;
            CaptionHAlign = captionAlign;
            if (width == 0)
                AutoSize = true;
            Format = format;
            if (fieldName != null)
                FieldName = fieldName;
        }

        System.Windows.Forms.Label lbl;
        static System.Windows.Forms.Form frm = new System.Windows.Forms.Form();
        public System.Drawing.Font Font
        {
            set 
            {
                if (!_AutoSize) return;
                lbl.Font = value; 
            }
        }
        public void TestWidth(string text)
        {
            if (!_AutoSize) return;
            lbl.Text = text;
            if (lbl.Width > _Width)
                _Width = lbl.Width;
        }

        string _FieldNames = "";      
        public string FieldName
        {
            get { return _FieldNames; }
            set { _FieldNames = value; }
        }

        int _FieldIndex = 0;
        public int FieldIndex
        {
            get { return _FieldIndex; }
            set { _FieldIndex = value; }
        }

        bool _DisplayFlag = true;
        public bool DisplayFlag
        {
            get { return _DisplayFlag; }
            set { _DisplayFlag = value; }
        }

        public string PreValue { get; set; }

        public string Value { get; set; }

        public TableCell tableCell { get; set; }

        public bool MergeRow { get; set; }

        public bool CheckMerge
        {
            get
            {
                if (!MergeRow) return false;
                if (PreValue == Value)
                    return true;
                else
                    return false;
            }
        }

        public bool CheckMergeFoCaption(string text)
        {
            bool result = PreValue == text;
            PreValue = text;
            Value = text;
            return result;
        }

        public string GetValue(DataRow row)
        {
            PreValue = Value;
            if (Format == "")
            {
                if (FieldName != "")
                    Value = row[FieldName].ToString();
                else
                    Value = row[FieldIndex].ToString();
            }
            else
            {
                if (FieldName != "")
                    Value = string.Format(Format, row[FieldName]);
                else
                    Value = string.Format(Format, row[FieldIndex]);
            }

            if (Accumulation && Value != "")
            {
                double d;
                if (double.TryParse(Value, out d))
                {
                    AccCount++;
                    AccSum += d;
                    AccSubCount++;
                    AccSubSum += d;
                }
            }

            return Value;
        }

        public bool Accumulation { get; set; }
        public int AccCount { get; set; } //總筆數
        public double AccSum { get; set; }//總加總
        public string AccCountFormat
        {
            get
            {
                if (Format == "")
                    return AccCount.ToString();
                else
                    return string.Format(Format, AccCount);
            }
        }
        public string AccSumFormat
        {
            get
            {
                if (Format == "")
                    return AccSum.ToString();
                else
                    return string.Format(Format, AccSum);
            }
        }

        public void ResetSubAcc()
        {
            AccSubCount = 0;
            AccSubSum = 0;
        }
        public int AccSubCount { get; set; }//累加筆數
        public double AccSubSum { get; set; }//累加加總
        public string AccSubCountFormat
        {
            get
            {
                if (Format == "")
                    return AccSubCount.ToString();
                else
                    return string.Format(Format, AccSubCount);
            }
        }
        public string AccSubSumFormat
        {
            get
            {
                if (Format == "")
                    return AccSubSum.ToString();
                else
                    return string.Format(Format, AccSubSum);
            }
        }
    }
    public class DSTable
    {        
        List<List<string>> Captions = new List<List<string>>();
        List<ColumnSetting> columnSettings = new List<ColumnSetting>();
        bool Accumulation = false;
        public void AddColumn(int index, string text)
        {
            while (index > (Captions.Count - 1))
                Captions.Add(new List<string>());
            Captions[index].Add(text);               
        }
        public void AddColumn(string text)
        {
            AddColumn(0, text);
        }
        public ColumnSetting AddColumnSetting(ColumnSetting columnSetting, bool accumulation)
        {
            columnSetting.FieldIndex = columnSettings.Count;
            columnSetting.Accumulation = accumulation;
            if (accumulation) Accumulation = true;
            columnSettings.Add(columnSetting);
            return columnSetting;
        }
        public ColumnSetting AddColumnSetting(ColumnSetting columnSetting)
        {
            return AddColumnSetting(columnSetting, false);
        }
        public ColumnSetting GetColumnSetting(int index)
        {
            return columnSettings[index];
        }
        public ColumnSetting GetColumnSetting(string fieldName)
        {
            foreach (ColumnSetting cs in columnSettings)
            {
                if (cs.FieldName == fieldName)
                    return cs;
            }
            return null;
        }
        public int ColumnSettingCount
        {
            get { return columnSettings.Count; }
        }
        ColumnSetting GetDisplayColumnSetting(int index)
        {
            int i = 0;
            for (int j = 0; j < columnSettings.Count; j++)
            {
                if (columnSettings[j].DisplayFlag)
                {
                    if (i == index)
                        return columnSettings[j];
                    i++;
                }
            }
            return null;
        }

        public System.Drawing.Color CaptionBackColor { get; set; }
        public System.Drawing.Color CaptionForeColor { get; set; }
        public int CaptionFontSize { get; set; }
        public bool CaptionFontBold { get; set; }

        public bool FooterEnable { get; set; }
        public System.Drawing.Color FooterBackColor { get; set; }
        public System.Drawing.Color FooterForeColor { get; set; }
        public int FooterFontSize { get; set; }
        public bool FooterFontBold { get; set; }

        public int FontSize { get; set; }
        public System.Drawing.Color BackColor { get; set; }
        public System.Drawing.Color BackColorAlternate { get; set; }
        public System.Drawing.Color BorderColor { get; set; }
        public bool Alternate { get; set; }
        TableCell[] mgTR = new TableCell[0];
        public int mergeColumnCount
        {
            get
            {
                return mgTR.Length;
            }
            set
            {
                mgTR = new TableCell[value];
            }
        }
        public bool ShowRowNum { get; set; }

        public DSTable()
        {
            CaptionBackColor = System.Drawing.Color.LightGray;
            CaptionForeColor = System.Drawing.Color.Black;            
            CaptionFontSize = 11;
            CaptionFontBold = true;

            FooterBackColor = System.Drawing.Color.LightGray;
            FooterForeColor = System.Drawing.Color.Black;
            FooterFontSize = 11;
            FooterFontBold = false;
            FooterEnable = false;

            FontSize = 11;
            BackColor = System.Drawing.Color.White;
            BackColorAlternate = System.Drawing.Color.LightYellow;
            BorderColor = System.Drawing.Color.DarkSlateGray;
            Alternate = true;
        }

        public string Render(System.Data.DataTable dt)
        {
            Table table = new Table();            
            table.CellSpacing = 0;
            //table.CellPadding = 3;
            table.BorderColor = BorderColor;
            table.Style.Add(System.Web.UI.HtmlTextWriterStyle.FontSize, FontSize.ToString());
            if (columnSettings.Count == 0)
            {
                while (dt.Columns.Count > columnSettings.Count)
                    columnSettings.Add(new ColumnSetting());
            }

            #region Rows
            int iRow = dt.Rows.Count;
            //for calc auto width
            foreach (ColumnSetting cs in columnSettings)
                cs.Font = new System.Drawing.Font(table.Font.Name, FontSize);

            for (int i = 0; i < iRow; i++)
            {
                DataRow r = dt.Rows[i];
                TableRow tr = new TableRow();                
                tr.BackColor = BackColor;
                if (Alternate && i % 2 == 0)
                    tr.BackColor = BackColorAlternate;
                tr.Font.Size = FontSize;
                if (ShowRowNum)
                {
                    TableCell td = new TableCell();
                    td.Text = (i + 1).ToString();
                    td.BorderWidth = 1;
                    td.BackColor = CaptionBackColor;
                    tr.Cells.Add(td);
                }
                foreach (ColumnSetting cs in columnSettings)
                {
                    TableCell td = null;
                    string text = cs.GetValue(r);
                    if (!cs.DisplayFlag) continue;
                    if (!cs.CheckMerge)
                    {
                        td = new TableCell();                        
                        td.Text = text;
                        td.BorderWidth = 1;
                        td.HorizontalAlign = cs.HAlign;
                        if (cs.BackColor != BackColor)
                            td.BackColor = cs.BackColor;
                        cs.TestWidth(text);
                        tr.Cells.Add(td);
                        cs.tableCell = td;
                    }
                    else
                    {
                        td = cs.tableCell;
                        if (td.RowSpan == 0)
                            td.RowSpan = 1;
                        td.RowSpan++;
                    }
                }
                table.Rows.Add(tr);
            }
            #endregion

            if (Accumulation)
            {
                TableRow tr = new TableRow();
                if (ShowRowNum)
                {
                    TableCell td = new TableCell();
                    td.Text = "Total";
                    td.BorderWidth = 1;
                    tr.Cells.Add(td);
                }
                foreach (ColumnSetting cs in columnSettings)
                {
                    TableCell td = new TableCell();
                    if (!cs.DisplayFlag) continue;
                    if (cs.Accumulation)
                        td.Text = cs.AccSumFormat;
                    else
                    {
                        if (cs.FieldIndex == 0 && !ShowRowNum)
                            td.Text = "Total";
                        else
                            td.Text = "";
                    }
                    td.BorderWidth = 1;
                    td.HorizontalAlign = cs.HAlign;
                    cs.TestWidth(td.Text);
                    tr.Cells.Add(td);
                    cs.tableCell = td;
                }

                table.Rows.Add(tr);
            }

            //為了要自動調整欄寬，只能在所有的Row都跑完之後才能知道最佳欄寬
            #region Caption

            foreach (ColumnSetting cs in columnSettings)
            {
                if (CaptionFontBold)
                    cs.Font = new System.Drawing.Font(table.Font.Name, CaptionFontSize, System.Drawing.FontStyle.Bold);
                else
                    cs.Font = new System.Drawing.Font(table.Font.Name, CaptionFontSize);
            }
            mergeColumnCount = columnSettings.Count;
            TableCell tc = null;
            for (int i = 0; i < Captions.Count; i++)
            {
                string prevText = "";//prev column text
                TableRow tr = new TableRow();                
                tr.BackColor = CaptionBackColor;
                tr.ForeColor = CaptionForeColor;
                tr.Font.Bold = CaptionFontBold;
                tr.Font.Size = CaptionFontSize;
                List<string> caption = Captions[i];

                if (ShowRowNum)
                {
                    tc = new TableCell();
                    tc.Width = 30;
                    tc.BorderWidth = 1;
                    tr.Cells.Add(tc);
                }
                for (int j = 0; j < caption.Count; j++)
                {
                    ColumnSetting cs = GetDisplayColumnSetting(j);
                    bool merge = cs.CheckMergeFoCaption(caption[j]);
                    if (prevText == cs.Value)
                    {
                        if (tc.ColumnSpan == 0)
                            tc.ColumnSpan = 1;
                        tc.ColumnSpan++;
                        cs.TestWidth(prevText);
                        tc.Width = (int)(tc.Width.Value + cs.Width);
                    }
                    else if (merge)
                    {
                        TableCell td2 = cs.tableCell;
                        if (td2.RowSpan == 0)
                            td2.RowSpan = 1;
                        td2.RowSpan++;
                    }
                    else
                    {
                        tc = new TableCell();
                        tc.Text = caption[j];
                        tc.BorderWidth = 1;
                        tc.HorizontalAlign = cs.CaptionHAlign;
                        if (cs.CaptionBackColor != CaptionBackColor)
                            tc.BackColor = cs.CaptionBackColor;
                        cs.TestWidth(tc.Text);
                        tc.Width = cs.Width;
                        tr.Cells.Add(tc);
                        cs.tableCell = tc;
                    }
                    prevText = caption[j];
                }
                table.Rows.AddAt(i, tr);
            }
            #endregion

            #region Footer
            if (FooterEnable)
            {
                table.Rows[table.Rows.Count - 1].BackColor = FooterBackColor;
                table.Rows[table.Rows.Count - 1].ForeColor = FooterForeColor;
                table.Rows[table.Rows.Count - 1].Font.Bold = FooterFontBold;
                table.Rows[table.Rows.Count - 1].Font.Size = FooterFontSize;
            }
            #endregion

            int tableWidth = 0;
            foreach (ColumnSetting cs in columnSettings)
                tableWidth += cs.Width;
            table.Width = tableWidth + (ShowRowNum ? 30 : 0);

            StringBuilder sb = new StringBuilder();
            System.IO.TextWriter tw = new System.IO.StringWriter(sb);
            System.Web.UI.HtmlTextWriter ht = new System.Web.UI.HtmlTextWriter(tw);
            table.RenderControl(ht);
            return sb.ToString();
        }
    }
}
