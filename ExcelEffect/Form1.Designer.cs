namespace ExcelEffect
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.targetFilePathText = new System.Windows.Forms.TextBox();
            this.getTargetFileButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.targetWorksheetCombo = new System.Windows.Forms.ComboBox();
            this.reportText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.diffFilePathText = new System.Windows.Forms.TextBox();
            this.getDiffFileButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.outputDirectoryPathText = new System.Windows.Forms.TextBox();
            this.getOutputDirectoryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.doDebugButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.filterColnumCombo1 = new System.Windows.Forms.ComboBox();
            this.filterCondStr1 = new System.Windows.Forms.TextBox();
            this.filterColnumCombo2 = new System.Windows.Forms.ComboBox();
            this.filterCondStr2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diffWorksheetCombo = new System.Windows.Forms.ComboBox();
            this.filterCondChk1 = new System.Windows.Forms.CheckBox();
            this.filterCondChk2 = new System.Windows.Forms.CheckBox();
            this.filterCondRelationCombo = new System.Windows.Forms.ComboBox();
            this.filterCondRegxChk = new System.Windows.Forms.CheckBox();
            this.データ開始行 = new System.Windows.Forms.Label();
            this.dataStartRowCombo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataStartRowCombo2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.reportText, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.targetFilePathText);
            this.flowLayoutPanel1.Controls.Add(this.getTargetFileButton);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.targetWorksheetCombo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "処理対象ファイル";
            // 
            // targetFilePathText
            // 
            this.targetFilePathText.Location = new System.Drawing.Point(118, 3);
            this.targetFilePathText.Name = "targetFilePathText";
            this.targetFilePathText.Size = new System.Drawing.Size(333, 22);
            this.targetFilePathText.TabIndex = 1;
            // 
            // getTargetFileButton
            // 
            this.getTargetFileButton.Location = new System.Drawing.Point(457, 3);
            this.getTargetFileButton.Name = "getTargetFileButton";
            this.getTargetFileButton.Size = new System.Drawing.Size(36, 23);
            this.getTargetFileButton.TabIndex = 2;
            this.getTargetFileButton.Text = "...";
            this.getTargetFileButton.UseVisualStyleBackColor = true;
            this.getTargetFileButton.Click += new System.EventHandler(this.getTargetFileButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "対象シート";
            // 
            // targetWorksheetCombo
            // 
            this.targetWorksheetCombo.Enabled = false;
            this.targetWorksheetCombo.FormattingEnabled = true;
            this.targetWorksheetCombo.Location = new System.Drawing.Point(577, 3);
            this.targetWorksheetCombo.Name = "targetWorksheetCombo";
            this.targetWorksheetCombo.Size = new System.Drawing.Size(130, 23);
            this.targetWorksheetCombo.TabIndex = 7;
            this.targetWorksheetCombo.SelectedIndexChanged += new System.EventHandler(this.targetWorksheetCombo_SelectedIndexChanged);
            // 
            // reportText
            // 
            this.reportText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportText.Location = new System.Drawing.Point(3, 310);
            this.reportText.MaxLength = 0;
            this.reportText.Multiline = true;
            this.reportText.Name = "reportText";
            this.reportText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportText.Size = new System.Drawing.Size(746, 184);
            this.reportText.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.diffFilePathText);
            this.flowLayoutPanel5.Controls.Add(this.getDiffFileButton);
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Controls.Add(this.diffWorksheetCombo);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 50);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(746, 52);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "差分ファイル";
            // 
            // diffFilePathText
            // 
            this.diffFilePathText.Location = new System.Drawing.Point(88, 3);
            this.diffFilePathText.Name = "diffFilePathText";
            this.diffFilePathText.Size = new System.Drawing.Size(363, 22);
            this.diffFilePathText.TabIndex = 1;
            // 
            // getDiffFileButton
            // 
            this.getDiffFileButton.Location = new System.Drawing.Point(457, 3);
            this.getDiffFileButton.Name = "getDiffFileButton";
            this.getDiffFileButton.Size = new System.Drawing.Size(36, 23);
            this.getDiffFileButton.TabIndex = 2;
            this.getDiffFileButton.Text = "...";
            this.getDiffFileButton.UseVisualStyleBackColor = true;
            this.getDiffFileButton.Click += new System.EventHandler(this.getDiffFileButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.doDebugButton);
            this.flowLayoutPanel3.Controls.Add(this.filterCondRegxChk);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 258);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(746, 46);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.outputDirectoryPathText);
            this.flowLayoutPanel2.Controls.Add(this.getOutputDirectoryButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 108);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(746, 41);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "出力先フォルダ";
            // 
            // outputDirectoryPathText
            // 
            this.outputDirectoryPathText.Location = new System.Drawing.Point(104, 3);
            this.outputDirectoryPathText.Name = "outputDirectoryPathText";
            this.outputDirectoryPathText.Size = new System.Drawing.Size(445, 22);
            this.outputDirectoryPathText.TabIndex = 1;
            // 
            // getOutputDirectoryButton
            // 
            this.getOutputDirectoryButton.Location = new System.Drawing.Point(555, 3);
            this.getOutputDirectoryButton.Name = "getOutputDirectoryButton";
            this.getOutputDirectoryButton.Size = new System.Drawing.Size(36, 23);
            this.getOutputDirectoryButton.TabIndex = 2;
            this.getOutputDirectoryButton.Text = "...";
            this.getOutputDirectoryButton.UseVisualStyleBackColor = true;
            this.getOutputDirectoryButton.Click += new System.EventHandler(this.getOutputDirectoryButton_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.filterCondChk2);
            this.flowLayoutPanel4.Controls.Add(this.filterCondStr2);
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.filterColnumCombo2);
            this.flowLayoutPanel4.Controls.Add(this.label8);
            this.flowLayoutPanel4.Controls.Add(this.dataStartRowCombo2);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 204);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(746, 48);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // doDebugButton
            // 
            this.doDebugButton.Location = new System.Drawing.Point(3, 3);
            this.doDebugButton.Name = "doDebugButton";
            this.doDebugButton.Size = new System.Drawing.Size(75, 23);
            this.doDebugButton.TabIndex = 0;
            this.doDebugButton.Text = "処理実行";
            this.doDebugButton.UseVisualStyleBackColor = true;
            this.doDebugButton.Click += new System.EventHandler(this.doDebugButton_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.filterCondChk1);
            this.flowLayoutPanel6.Controls.Add(this.filterCondStr1);
            this.flowLayoutPanel6.Controls.Add(this.label3);
            this.flowLayoutPanel6.Controls.Add(this.filterColnumCombo1);
            this.flowLayoutPanel6.Controls.Add(this.データ開始行);
            this.flowLayoutPanel6.Controls.Add(this.dataStartRowCombo1);
            this.flowLayoutPanel6.Controls.Add(this.filterCondRelationCombo);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 155);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(746, 43);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // filterColnumCombo1
            // 
            this.filterColnumCombo1.Enabled = false;
            this.filterColnumCombo1.FormattingEnabled = true;
            this.filterColnumCombo1.Location = new System.Drawing.Point(353, 3);
            this.filterColnumCombo1.Name = "filterColnumCombo1";
            this.filterColnumCombo1.Size = new System.Drawing.Size(60, 23);
            this.filterColnumCombo1.TabIndex = 1;
            // 
            // filterCondStr1
            // 
            this.filterCondStr1.Location = new System.Drawing.Point(76, 3);
            this.filterCondStr1.Name = "filterCondStr1";
            this.filterCondStr1.Size = new System.Drawing.Size(213, 22);
            this.filterCondStr1.TabIndex = 4;
            // 
            // filterColnumCombo2
            // 
            this.filterColnumCombo2.Enabled = false;
            this.filterColnumCombo2.FormattingEnabled = true;
            this.filterColnumCombo2.Location = new System.Drawing.Point(353, 3);
            this.filterColnumCombo2.Name = "filterColnumCombo2";
            this.filterColnumCombo2.Size = new System.Drawing.Size(63, 23);
            this.filterColnumCombo2.TabIndex = 3;
            // 
            // filterCondStr2
            // 
            this.filterCondStr2.Location = new System.Drawing.Point(76, 3);
            this.filterCondStr2.Name = "filterCondStr2";
            this.filterCondStr2.Size = new System.Drawing.Size(213, 22);
            this.filterCondStr2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "対象シート";
            // 
            // diffWorksheetCombo
            // 
            this.diffWorksheetCombo.Enabled = false;
            this.diffWorksheetCombo.FormattingEnabled = true;
            this.diffWorksheetCombo.Location = new System.Drawing.Point(577, 3);
            this.diffWorksheetCombo.Name = "diffWorksheetCombo";
            this.diffWorksheetCombo.Size = new System.Drawing.Size(130, 23);
            this.diffWorksheetCombo.TabIndex = 4;
            // 
            // filterCondChk1
            // 
            this.filterCondChk1.AutoSize = true;
            this.filterCondChk1.Location = new System.Drawing.Point(3, 3);
            this.filterCondChk1.Name = "filterCondChk1";
            this.filterCondChk1.Size = new System.Drawing.Size(67, 19);
            this.filterCondChk1.TabIndex = 6;
            this.filterCondChk1.Text = "条件1";
            this.filterCondChk1.UseVisualStyleBackColor = true;
            // 
            // filterCondChk2
            // 
            this.filterCondChk2.AutoSize = true;
            this.filterCondChk2.Location = new System.Drawing.Point(3, 3);
            this.filterCondChk2.Name = "filterCondChk2";
            this.filterCondChk2.Size = new System.Drawing.Size(67, 19);
            this.filterCondChk2.TabIndex = 7;
            this.filterCondChk2.Text = "条件2";
            this.filterCondChk2.UseVisualStyleBackColor = true;
            // 
            // filterCondRelationCombo
            // 
            this.filterCondRelationCombo.FormattingEnabled = true;
            this.filterCondRelationCombo.Location = new System.Drawing.Point(603, 3);
            this.filterCondRelationCombo.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.filterCondRelationCombo.Name = "filterCondRelationCombo";
            this.filterCondRelationCombo.Size = new System.Drawing.Size(95, 23);
            this.filterCondRelationCombo.TabIndex = 8;
            // 
            // filterCondRegxChk
            // 
            this.filterCondRegxChk.AutoSize = true;
            this.filterCondRegxChk.Checked = true;
            this.filterCondRegxChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filterCondRegxChk.Location = new System.Drawing.Point(84, 3);
            this.filterCondRegxChk.Name = "filterCondRegxChk";
            this.filterCondRegxChk.Size = new System.Drawing.Size(89, 19);
            this.filterCondRegxChk.TabIndex = 1;
            this.filterCondRegxChk.Text = "正規表現";
            this.filterCondRegxChk.UseVisualStyleBackColor = true;
            // 
            // データ開始行
            // 
            this.データ開始行.AutoSize = true;
            this.データ開始行.Location = new System.Drawing.Point(419, 0);
            this.データ開始行.Name = "データ開始行";
            this.データ開始行.Size = new System.Drawing.Size(86, 15);
            this.データ開始行.TabIndex = 2;
            this.データ開始行.Text = "データ開始行";
            // 
            // dataStartRowCombo1
            // 
            this.dataStartRowCombo1.FormattingEnabled = true;
            this.dataStartRowCombo1.Location = new System.Drawing.Point(511, 3);
            this.dataStartRowCombo1.Name = "dataStartRowCombo1";
            this.dataStartRowCombo1.Size = new System.Drawing.Size(78, 23);
            this.dataStartRowCombo1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "列番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "列番号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "データ開始行";
            // 
            // dataStartRowCombo2
            // 
            this.dataStartRowCombo2.FormattingEnabled = true;
            this.dataStartRowCombo2.Location = new System.Drawing.Point(514, 3);
            this.dataStartRowCombo2.Name = "dataStartRowCombo2";
            this.dataStartRowCombo2.Size = new System.Drawing.Size(77, 23);
            this.dataStartRowCombo2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ExcelEffect";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetFilePathText;
        private System.Windows.Forms.Button getTargetFileButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputDirectoryPathText;
        private System.Windows.Forms.Button getOutputDirectoryButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button doDebugButton;
        private System.Windows.Forms.TextBox reportText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox filterColnumCombo1;
        private System.Windows.Forms.TextBox filterCondStr1;
        private System.Windows.Forms.ComboBox filterColnumCombo2;
        private System.Windows.Forms.TextBox filterCondStr2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diffFilePathText;
        private System.Windows.Forms.Button getDiffFileButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox targetWorksheetCombo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox diffWorksheetCombo;
        private System.Windows.Forms.CheckBox filterCondChk1;
        private System.Windows.Forms.ComboBox filterCondRelationCombo;
        private System.Windows.Forms.CheckBox filterCondChk2;
        private System.Windows.Forms.CheckBox filterCondRegxChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label データ開始行;
        private System.Windows.Forms.ComboBox dataStartRowCombo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dataStartRowCombo2;
    }
}

