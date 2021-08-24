using System;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using System.Data;
using System.Windows.Forms;

namespace mesRelease.utilities
{
    public class ExcelAgent : IDisposable
    {
        string _path = "";
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }

        string _sheetName = "Sheet1";
        public string sheetName
        {
            get { return _sheetName; }
            set { _sheetName = value; }
        }

        int _fontSize = 9;
        public int fontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                tmpLabel.Font = new System.Drawing.Font(tmpLabel.Font.FontFamily, float.Parse(_fontSize.ToString()));
            }
        }

        private void writeToFile(ListView lv)
        {
            DataSet ds = new DataSet();
            DataTable table = ds.Tables.Add();
            foreach (ColumnHeader col in lv.Columns)
            {
                table.Columns.Add(col.Text);
            }
            foreach (ListViewItem item in lv.Items)
            {
                DataRow dr = table.NewRow();
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    dr[i] = item.SubItems[i].Text;
                }
                table.Rows.Add(dr);
            }
            writeToFile(ds);
        }

        private void writeToFile(DataSet ds)
        {
            Dictionary<int, int> columnWidth = new Dictionary<int, int>();
            IWorkbook book = null;
            if (path.IndexOf(".xlsx") > 0) // 2007版本
                book = new NPOI.XSSF.UserModel.XSSFWorkbook();
            else if (path.IndexOf(".xls") > 0) // 2003版本
                book = new NPOI.HSSF.UserModel.HSSFWorkbook();
            ICellStyle cStyle = columnHeaderStyle(book);
            ICellStyle rStyle = rowStyle(book);

            ISheet sheet = book.CreateSheet(sheetName);
            IRow row = sheet.CreateRow(0);
            int i = 0;
            foreach (DataColumn col in ds.Tables[0].Columns)
            {
                ICell cell = row.CreateCell(i, CellType.String);
                cell.SetCellValue(col.ColumnName);
                cell.CellStyle = cStyle;
                columnWidth[i] = TextWidth(col.ColumnName);
                i++;
            }

            i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                row = sheet.CreateRow(sheet.PhysicalNumberOfRows);
                i = 0;
                foreach (DataColumn col in ds.Tables[0].Columns)
                {
                    ICell cell = row.CreateCell(i, CellType.String);
                    cell.SetCellValue(dr[col.ColumnName].ToString());
                    cell.CellStyle = rStyle;
                    if (TextWidth(dr[col].ToString()) > columnWidth[i])
                        columnWidth[i] = (TextWidth(dr[col].ToString()));
                    i++;
                }
            }

            i = 0;
            foreach (DataColumn col in ds.Tables[0].Columns)
            {
                sheet.SetColumnWidth(i, columnWidth[i]);
                i++;
            }
            using (System.IO.FileStream stm = System.IO.File.Create(path))
            {
                book.Write(stm);
            }
        }

        ICellStyle whiteBackColor(IWorkbook wb, bool bold)
        {
            ICellStyle style = wb.CreateCellStyle();
            style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            style.VerticalAlignment = VerticalAlignment.Center;

            IFont f = wb.CreateFont();
            f.IsBold = bold;
            f.Color = IndexedColors.White.Index;
            f.FontHeightInPoints = (short)fontSize;
            style.SetFont(f);

            style.FillForegroundColor = IndexedColors.White.Index;
            style.FillPattern = FillPattern.SolidForeground;

            return style;
        }
        ICellStyle columnHeaderStyle(IWorkbook wb)
        {
            ICellStyle style = wb.CreateCellStyle(); // new WorksheetStyle("columnHeader");            
            style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            style.VerticalAlignment = VerticalAlignment.Center;

            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.LeftBorderColor = IndexedColors.Black.Index;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BottomBorderColor = IndexedColors.Black.Index;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.RightBorderColor = IndexedColors.Black.Index;
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style.TopBorderColor = IndexedColors.Black.Index;

            style.FillPattern = FillPattern.SolidForeground;

            if (wb is NPOI.HSSF.UserModel.HSSFWorkbook)
            {
                NPOI.HSSF.UserModel.HSSFPalette palette = (wb as NPOI.HSSF.UserModel.HSSFWorkbook).GetCustomPalette();

                System.Drawing.Color col = System.Drawing.Color.Gray;
                if (palette.FindColor(col.R, col.G, col.B) == null)
                    palette.SetColorAtIndex(++colIndex, col.R, col.G, col.B);
                style.FillForegroundColor = palette.FindColor(col.R, col.G, col.B).Indexed;

                col = System.Drawing.Color.White;
                if (palette.FindColor(col.R, col.G, col.B) == null)
                    palette.SetColorAtIndex(++colIndex, col.R, col.G, col.B);
                IFont f = wb.CreateFont();
                f.IsBold = true;
                f.Color = palette.FindColor(col.R, col.G, col.B).Indexed;
                f.FontHeightInPoints = (short)fontSize;

                style.SetFont(f);
            }
            else if (wb is NPOI.XSSF.UserModel.XSSFWorkbook)
            {
                (style as NPOI.XSSF.UserModel.XSSFCellStyle).SetFillForegroundColor(new NPOI.XSSF.UserModel.XSSFColor(System.Drawing.Color.Gray));

                IFont f = wb.CreateFont();
                f.IsBold = true;
                (f as NPOI.XSSF.UserModel.XSSFFont).SetColor(new NPOI.XSSF.UserModel.XSSFColor(System.Drawing.Color.White));
                f.FontHeightInPoints = (short)fontSize;

                style.SetFont(f);
            }
            return style;
        }
        ICellStyle rowStyle(IWorkbook wb)
        {
            ICellStyle style = wb.CreateCellStyle();
            style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            style.VerticalAlignment = VerticalAlignment.Center;

            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.LeftBorderColor = IndexedColors.Black.Index;
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BottomBorderColor = IndexedColors.Black.Index;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.RightBorderColor = IndexedColors.Black.Index;
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            style.TopBorderColor = IndexedColors.Black.Index;

            IFont f = wb.CreateFont();
            f.FontHeightInPoints = (short)fontSize;
            style.SetFont(f);

            return style;
        }
        short colIndex = 9;
        ICellStyle getStyle(IWorkbook wb, System.Drawing.Color fontColor, System.Drawing.Color backColor, bool bold, int size)
        {
            return getStyle(wb, fontColor, backColor, bold, size, true);
        }
        ICellStyle getStyle(IWorkbook wb, System.Drawing.Color fontColor, System.Drawing.Color backColor, bool bold, int size, bool borderLine)
        {
            ICellStyle style = wb.CreateCellStyle();
            style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
            style.VerticalAlignment = VerticalAlignment.Center;

            if (borderLine)
            {
                style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                style.LeftBorderColor = IndexedColors.Black.Index;
                style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                style.BottomBorderColor = IndexedColors.Black.Index;
                style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                style.RightBorderColor = IndexedColors.Black.Index;
                style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            }
            style.FillPattern = FillPattern.SolidForeground;

            if (wb is NPOI.HSSF.UserModel.HSSFWorkbook)
            {
                NPOI.HSSF.UserModel.HSSFPalette palette = (wb as NPOI.HSSF.UserModel.HSSFWorkbook).GetCustomPalette();

                if (palette.FindColor(backColor.R, backColor.G, backColor.B) == null)
                    palette.SetColorAtIndex(++colIndex, backColor.R, backColor.G, backColor.B);

                style.FillForegroundColor = palette.FindColor(backColor.R, backColor.G, backColor.B).Indexed;

                if (palette.FindColor(fontColor.R, fontColor.G, fontColor.B) == null)
                    palette.SetColorAtIndex(++colIndex, fontColor.R, fontColor.G, fontColor.B);
                IFont f = wb.CreateFont();
                f.IsBold = bold;
                f.Color = palette.FindColor(fontColor.R, fontColor.G, fontColor.B).Indexed;
                f.FontHeightInPoints = (short)size;

                style.SetFont(f);
            }
            else if (wb is NPOI.XSSF.UserModel.XSSFWorkbook)
            {
                (style as NPOI.XSSF.UserModel.XSSFCellStyle).SetFillForegroundColor(new NPOI.XSSF.UserModel.XSSFColor(backColor));

                IFont f = wb.CreateFont();
                f.IsBold = bold;
                (f as NPOI.XSSF.UserModel.XSSFFont).SetColor(new NPOI.XSSF.UserModel.XSSFColor(fontColor));
                f.FontHeightInPoints = (short)size;

                style.SetFont(f);
            }

            return style;
        }
        public void writeToFileWithListViewStyle(string filePath, ListView lv, bool includeHeader)
        {
            tmpLabel.Font = lv.Font;
            Dictionary<int, int> columnWidth = new Dictionary<int, int>();
            Dictionary<string, ICellStyle> dicStyle = new Dictionary<string, ICellStyle>();

            IWorkbook book = null;
            if (filePath.IndexOf(".xlsx") > 0) // 2007版本
                book = new NPOI.XSSF.UserModel.XSSFWorkbook();
            else if (filePath.IndexOf(".xls") > 0) // 2003版本
                book = new NPOI.HSSF.UserModel.HSSFWorkbook();

            ICellStyle cStyle = columnHeaderStyle(book);
            ICellStyle rStyle = rowStyle(book);

            //ICellStyle wStyle = whiteBackColor(book, true);
            ISheet sheet = book.CreateSheet(sheetName);

            int iRow = 0;
            IRow row = null;
            if (includeHeader)
            {
                row = sheet.CreateRow(0);
                foreach (ColumnHeader col in lv.Columns)
                {
                    ICell cell = row.CreateCell(iRow, CellType.String);
                    cell.SetCellValue(col.Text);
                    cell.CellStyle = cStyle;
                    columnWidth[iRow] = TextWidth(col.Text);
                    iRow++;
                }
            }

            string groupId = "";
            foreach (ListViewItem vItem in lv.Items)
            {
                if (vItem.Group != null && !vItem.Group.Name.Equals(groupId))
                {
                    if (!groupId.Equals("")) sheet.CreateRow(sheet.PhysicalNumberOfRows);//新增空白列(除了第一行外)
                    groupId = vItem.Group.Name;
                    row = sheet.CreateRow(sheet.PhysicalNumberOfRows);
                    if (!dicStyle.ContainsKey("step"))
                    {
                        ICellStyle style = getStyle(book, System.Drawing.Color.Black, System.Drawing.Color.White, true, (int)lv.Font.Size, false);
                        dicStyle["step"] = style;
                    }
                    ICell cell = row.CreateCell(row.PhysicalNumberOfCells, CellType.String);
                    cell.SetCellValue(groupId);
                    cell.CellStyle = dicStyle["step"];

                    for (int i = 1; i < lv.Columns.Count; i++)
                    {
                        cell = row.CreateCell(row.PhysicalNumberOfCells, CellType.String);
                        cell.SetCellValue("");
                        cell.CellStyle = dicStyle["step"];
                    }
                }

                row = sheet.CreateRow(sheet.PhysicalNumberOfRows);
                ICellStyle lastStyle = rStyle;
                for (int i = 0; i < lv.Columns.Count; i++)
                {
                    ICell cell = row.CreateCell(row.PhysicalNumberOfCells, CellType.String);
                    cell.CellStyle = lastStyle;
                    cell.SetCellValue("");
                    if (i >= vItem.SubItems.Count) continue;
                    ListViewItem.ListViewSubItem subItem = vItem.SubItems[i];
                    cell.SetCellValue(subItem.Text);
                    System.Drawing.Color backColor = subItem.BackColor;
                    System.Drawing.Color fontColor = subItem.ForeColor;
                    if (vItem.UseItemStyleForSubItems)
                    {
                        backColor = vItem.BackColor;
                        fontColor = vItem.ForeColor;
                    }

                    if (!dicStyle.ContainsKey(backColor.Name))
                    {
                        ICellStyle style = getStyle(book, fontColor, backColor, false, (int)lv.Font.Size);
                        dicStyle[backColor.Name] = style;
                    }
                    cell.CellStyle = dicStyle[backColor.Name];
                    lastStyle = dicStyle[backColor.Name];
                    int width = TextWidth(subItem.Text);

                    if (columnWidth.ContainsKey(i))
                    {
                        if (width > columnWidth[i])
                            columnWidth[i] = width;
                    }
                    else
                        columnWidth[i] = width;

                }
            }
            foreach (int i in columnWidth.Keys)
            {
                sheet.SetColumnWidth(i, columnWidth[i]);
            }

            using (System.IO.FileStream stm = System.IO.File.Create(filePath))
            {
                book.Write(stm);
            }
        }

        Form tmpForm = new Form();
        Label tmpLabel = new Label();
        int TextWidth(string text)
        {
            tmpLabel.Text = text;
            if (tmpLabel.Size.Width < 10)
                return 10 * 50;
            else if (tmpLabel.Size.Width > 500)
                return 500 * 50;
            else
                return tmpLabel.Width * 50;
        }
        public ExcelAgent()
        {
            tmpLabel.AutoSize = true;
            tmpForm.Controls.Add(tmpLabel);
        }
        public void Dispose()
        {
            try
            {
                tmpForm.Close();
            }
            catch { }
        }

        public static bool WriteToFile(ListView source)
        {
            return WriteToFile(source, 9);
        }
        public static bool WriteToFile(ListView source, string fileName)
        {
            return WriteToFile(source, 9, fileName);
        }
        public static bool WriteToFile(ListView source, int fontSize)
        {
            return WriteToFile(source, fontSize, "");
        }
        public static bool WriteToFile(ListView source, int fontSize, string fileName)
        {
            if (fileName == null || fileName.Equals(""))
            {
                if (source.Columns.Count > 0)
                    fileName = source.Columns[0].Text + "_" + idv.messageService.serviceHost.dateTime.ToString("yyyyMMdd");
            }
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.Filter = "excel(*.xls)|*.xls";
            sfg.FileName = fileName;
            if (sfg.ShowDialog() == DialogResult.Cancel) return false;
            if (sfg.FileName != "")
            {
                try
                {
                    using (ExcelAgent ea = new ExcelAgent())
                    {
                        ea.fontSize = fontSize;
                        ea.path = sfg.FileName;
                        ea.writeToFile(source);
                        return true;
                    }
                }
                catch { }
            }
            return false;
        }

        public static DataTable ImpportSelectExcel(string initDir = "", string sheetName = "", bool firstRowIsColumnName = true)
        {
            var openFile = new OpenFileDialog();
            if (!string.IsNullOrWhiteSpace(initDir))
                openFile.InitialDirectory = initDir;

            openFile.Filter = @"Excel(*.xls;*.xlsx)|*.xls;*.xlsx";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
                return ImportFromExcel(openFile.FileName, sheetName, firstRowIsColumnName);

            return null;
        }
        public static DataTable ImportFromExcel(string path, string sheetName = "", bool firstRowIsColumnName = true)
        {
            using (System.IO.FileStream inputStream = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite))
            {
                return excelToDataTable(WorkbookFactory.Create(inputStream), sheetName, firstRowIsColumnName);
            }
        }
        static DataTable excelToDataTable(IWorkbook xlbook, string sheetName, bool firstRowIsColumnName)
        {
            ISheet xlSheet = string.IsNullOrWhiteSpace(sheetName) ? xlbook.GetSheetAt(0) : xlbook.GetSheet(sheetName);
            DataTable dt = new DataTable(sheetName);
            IRow xlRow = xlSheet.GetRow(xlSheet.FirstRowNum);

            List<string> list = new List<string>();
            for (int i = xlRow.FirstCellNum; i < xlRow.LastCellNum; i++)
            {
                string colName = firstRowIsColumnName ? xlRow.GetCell(i).ToString() : "Column_" + (i + 1).ToString();
                if (string.IsNullOrWhiteSpace(colName))
                    colName = "Column_" + (i + 1).ToString();
                if (list.Contains(colName))
                {
                    int j = 2;
                    while (list.Contains(colName + "_" + j.ToString()))
                        j++;
                    colName += "_" + j.ToString();
                }
                list.Add(colName);
                dt.Columns.Add(new DataColumn(colName));
            }

            for (int i = xlSheet.FirstRowNum + (firstRowIsColumnName ? 1 : 0); i <= xlSheet.LastRowNum; i++)
            {
                DataRow dtRow = dt.NewRow();
                xlRow = xlSheet.GetRow(i);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = xlRow.GetCell(j);
                    dtRow[j] = cell == null ? "" : cell.ToString();
                }
                dt.Rows.Add(dtRow);
            }

            return dt;
        }
    }
}
