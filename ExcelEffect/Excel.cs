using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ExcelEffect
{
    partial class Form1
    {

        //カレントWorkbookをセット
        private void initCurrentBook()
        {
            currentWb = new XLWorkbook(currentWbPath);
        }

        //カレントWorkbookのカレントSheetをセット
        private void initCurrentWorksheet(int idx)
        {
            currentWs = currentWb.Worksheet(idx);
        }

        //出力用Workbookをセット
        private void initOutputBook()
        {
            outputWb = new XLWorkbook();
        }

        //カレントSheetのデータ範囲開始行を取得
        private int getStartRow()
        {
            var first = currentWs.FirstCellUsed();
            return first.WorksheetRow().RowNumber();
        }

        //カレントSheetのデータ範囲最終行を取得
        private int getEndRow()
        {
            var last = currentWs.LastCellUsed();
            return last.WorksheetRow().RowNumber();
        }

        //カレントSheetのデータ範囲開始列を取得
        private int getStartCol()
        {
            var first = currentWs.FirstCellUsed();
            return first.WorksheetColumn().ColumnNumber();
        }

        //カレントSheetのデータ範囲最終列を取得
        private int getEndCol()
        {
            var last = currentWs.LastCellUsed();
            return last.WorksheetColumn().ColumnNumber();
        }

        //Excelファイルを加工して出力
        public void openExcelFile()
        {
            initCurrentBook();
            initCurrentWorksheet(1);

            initOutputBook();
            var outputWs = outputWb.Worksheets.Add("Sheet1");
            int r = getStartRow();
            int rx = getEndRow();
            int c = getStartCol();
            int cx = getEndCol();
            int nr = 1;

            for (int i=r; i<=rx; i++)
            {
                
                StringBuilder sb = new StringBuilder();

                for (int j=c; j<=cx; j++)
                {
                    var val = currentWs.Cell(i, j).Value;

                    Type t = currentWs.Cell(i, j).Value.GetType();
                    if (t.Equals(typeof(double)) || t.Equals(typeof(int)) || t.Equals(typeof(float)))
                        val = val.ToString();
                    else if (t.Equals(typeof(DateTime)))
                        val = val.ToString();
                    if (t.Equals(typeof(ClosedXML.Excel.XLHyperlink)))
                        val = val;
                    else
                        val = (string)val;

                    sb.Append(val);
                    //string tmp = (string)val;

                    if (t.Equals(typeof(ClosedXML.Excel.XLHyperlink)))
                        outputWs.Cell(nr, j).Hyperlink = (ClosedXML.Excel.XLHyperlink)val;
                    else
                        outputWs.Cell(nr, j).SetValue(val);

                    if (j != cx) sb.Append("\t");

                }
                sb.Append("\r\n");
                reportText.AppendText(sb.ToString());
                nr++;
                if (i == 200) break;
            }
            string path = getSavePath("xlsx");
            outputWb.SaveAs(path);

        }


    }
}
