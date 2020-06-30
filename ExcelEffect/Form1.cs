using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelEffect
{
    public partial class Form1 : Form
    {

        string currentWbPath;
        string diffWbPath;
        string outputWbPath;
        string saveDirPath;
        XLWorkbook currentWb;
        XLWorkbook diffWb;
        XLWorkbook outputWb;
        IXLWorksheet currentWs;
        IXLWorksheet diffWs;

        //コンストラクタ
        public Form1()
        {
            InitializeComponent();
            currentWbPath = "";
            diffWbPath = "";
            outputWbPath = "";
            currentWb = null;
            diffWb = null;
            outputWb = null;
            currentWs = null;
            diffWs = null;

            saveDirPath = getUserHomePath() + @"\Desktop";
            outputDirectoryPathText.Text = saveDirPath;

            filterCondRelationCombo.Items.Add("AND");
            filterCondRelationCombo.Items.Add("OR");
            filterCondRelationCombo.Items.Add("TtoD");

            for(int i=1; i<=20; i++)
            {
                dataStartRowCombo1.Items.Add(i.ToString());
                dataStartRowCombo2.Items.Add(i.ToString());
            }

        }


        //処理対象ファイル選択ボタンクリック
        private void getTargetFileButton_Click(object sender, EventArgs e)
        {
            string path = getLoadPath("xlsx");
            if (path.Equals("")) return;
            currentWbPath = path;
            targetFilePathText.Text = path;
            initTargetWorksheetCombo();
        }

        //差分ファイル選択ボタンクリック
        private void getDiffFileButton_Click(object sender, EventArgs e)
        {
            string path = getLoadPath("xlsx");
            if (path.Equals("")) return;
            diffWbPath = path;
            diffFilePathText.Text = path;
            initDiffWorksheetCombo();
        }

        //対象シートコンボのセットアップ
        private void initTargetWorksheetCombo()
        {
            initCurrentBook();
            targetWorksheetCombo.Items.Clear();

            var sheets = currentWb.Worksheets;
            foreach(IXLWorksheet st in sheets)
            {
                string sname = st.Name;
                targetWorksheetCombo.Items.Add(sname);
            }

            targetWorksheetCombo.Enabled = true;
        }

        //差分シートコンボのセットアップ
        private void initDiffWorksheetCombo()
        {
            initDiffBook();
            diffWorksheetCombo.Items.Clear();

            var sheets = diffWb.Worksheets;
            foreach (IXLWorksheet st in sheets)
            {
                string sname = st.Name;
                diffWorksheetCombo.Items.Add(sname);
            }

            diffWorksheetCombo.Enabled = true;

        }

        //列番号のセットアップ
        private void initColnumCombo()
        {
            if (currentWb == null) initCurrentBook();

            string currentWsName = targetWorksheetCombo.Text;
            initCurrentWorksheet(currentWsName);

            filterColnumCombo1.Items.Clear();
            filterColnumCombo2.Items.Clear();
            int startCol = getStartCol();
            int endCol = getEndCol();
            List<int> arr = new List<int>();
            for (int i = startCol; i <= endCol; i++)
            {
                arr.Add(i);
            }
            foreach (int ix in arr)
            {
                string vl = ix.ToString();
                filterColnumCombo1.Items.Add(vl);
                filterColnumCombo2.Items.Add(vl);
            }

            filterColnumCombo1.Enabled = true;
            filterColnumCombo2.Enabled = true;

        }

        //出力先フォルダ選択ボタンクリック
        private void getOutputDirectoryButton_Click(object sender, EventArgs e)
        {
            string dir = getSaveFolderName();
            if (dir.Equals("")) return;
            saveDirPath = dir;
            outputDirectoryPathText.Text = dir;
        }

        //デバッグ（動作確認用）ボタンクリック
        private void doDebugButton_Click(object sender, EventArgs e)
        {
            //openExcelFile();
            filteredOutputExcelFile();
        }

        //対象シートコンボの値を変更
        private void targetWorksheetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            initColnumCombo();
        }

    }
}
