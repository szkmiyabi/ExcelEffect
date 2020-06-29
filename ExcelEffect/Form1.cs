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
        string outputWbPath;
        string saveDirPath;
        XLWorkbook currentWb;
        XLWorkbook outputWb;
        IXLWorksheet currentWs;

        //コンストラクタ
        public Form1()
        {
            InitializeComponent();
            currentWbPath = "";
            outputWbPath = "";
            currentWb = null;
            outputWb = null;
            currentWs = null;
        }

        //処理対象ファイル選択ボタン
        private void getTargetFileButton_Click(object sender, EventArgs e)
        {
            string path = getLoadPath("xlsx");
            if (path.Equals("")) return;
            currentWbPath = path;
            targetFilePathText.Text = path;
        }

        //出力先フォルダ選択ボタン
        private void getOutputDirectoryButton_Click(object sender, EventArgs e)
        {
            string dir = getSaveFolderName();
            if (dir.Equals("")) return;
            saveDirPath = dir;
            outputDirectoryPathText.Text = dir;
        }

        //デバッグ（動作確認用）ボタン
        private void doDebugButton_Click(object sender, EventArgs e)
        {
            openExcelFile();
        }
    }
}
