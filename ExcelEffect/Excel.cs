using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //カレントWorkbookのカレントSheetをセット（オーバーライド）
        private void initCurrentWorksheet(string sname)
        {
            currentWs = currentWb.Worksheets.Worksheet(sname);
        }

        //差分Workbookをセット
        private void initDiffBook()
        {
            diffWb = new XLWorkbook(diffWbPath);
        }

        //差分WorkbookのカレントSheetをセット
        private void initDiffWorksheet(int idx)
        {
            diffWs = diffWb.Worksheet(idx);
        }

        //差分WorkbookのカレントSheetをセット（オーバーライド）
        private void initDiffWorksheet(string sname)
        {
            diffWs = diffWb.Worksheets.Worksheet(sname);
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
            //initCurrentBook();
            //initCurrentWorksheet(1);

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

        //条件一致した行のみ出力する
        private void filteredOutputExcelFile()
        {
            if (currentWb == null) return;
            if (currentWs == null) return;

            initOutputBook();
            var outputWs = outputWb.Worksheets.Add("Sheet1");
            int r = getStartRow();
            int rx = getEndRow();
            int c = getStartCol();
            int cx = getEndCol();
            int nr = 1;

            int irx = 0;
            if(filterCondChk1.Checked) irx = Int32.Parse(dataStartRowCombo1.Text);

            int icx = 0;
            if (filterCondChk1.Checked) icx = Int32.Parse(filterColnumCombo1.Text);


            string key = "";
            Regex regxKey = null;

            if (filterCondChk1.Checked) key = filterCondStr1.Text;
            if (filterCondRegxChk.Checked) regxKey = new Regex(key);

            for (int i = r; i <= rx; i++)
            {

                StringBuilder sb = new StringBuilder();

                var chk_val = currentWs.Cell(i, icx).Value;
                Type chk_t = currentWs.Cell(i, icx).Value.GetType();

                if (chk_t.Equals(typeof(double)) || chk_t.Equals(typeof(int)) || chk_t.Equals(typeof(float)))
                {
                    chk_val = chk_val.ToString();
                }
                else if (chk_t.Equals(typeof(DateTime)))
                {
                    chk_val = chk_val.ToString();
                }
                else if (chk_t.Equals(typeof(ClosedXML.Excel.XLHyperlink)))
                {
                    chk_val = (ClosedXML.Excel.XLHyperlink)chk_val;
                    chk_val = chk_val.ToString();
                }
                else
                {
                    chk_val = (string)chk_val;
                }

                if (!regxKey.IsMatch((string)chk_val) && i >= irx) continue;


                for (int j = c; j <= cx; j++)
                {
                    var val = currentWs.Cell(i, j).Value;
                    Type t = currentWs.Cell(i, j).Value.GetType();

                    if (t.Equals(typeof(ClosedXML.Excel.XLHyperlink)))
                    {
                        outputWs.Cell(nr, j).Hyperlink = (ClosedXML.Excel.XLHyperlink)val;
                        var href = outputWs.Cell(nr, j).Hyperlink;
                        outputWs.Cell(nr, j).Value = href.ExternalAddress.ToString();
                    }
                    else
                    {
                        outputWs.Cell(nr, j).Value = val;
                    }
                }
                reportText.AppendText(i + "行目処理中\r\n");
                nr++;

            }
            string path = getSavePath("xlsx");
            outputWb.SaveAs(path);
        }


    }
}
