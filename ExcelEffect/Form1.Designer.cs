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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.outputDirectoryPathText = new System.Windows.Forms.TextBox();
            this.getOutputDirectoryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.doDebugButton = new System.Windows.Forms.Button();
            this.reportText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.86364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.13636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 249);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.targetFilePathText);
            this.flowLayoutPanel1.Controls.Add(this.getTargetFileButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(642, 37);
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
            this.targetFilePathText.Size = new System.Drawing.Size(431, 22);
            this.targetFilePathText.TabIndex = 1;
            // 
            // getTargetFileButton
            // 
            this.getTargetFileButton.Location = new System.Drawing.Point(555, 3);
            this.getTargetFileButton.Name = "getTargetFileButton";
            this.getTargetFileButton.Size = new System.Drawing.Size(36, 23);
            this.getTargetFileButton.TabIndex = 2;
            this.getTargetFileButton.Text = "...";
            this.getTargetFileButton.UseVisualStyleBackColor = true;
            this.getTargetFileButton.Click += new System.EventHandler(this.getTargetFileButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.outputDirectoryPathText);
            this.flowLayoutPanel2.Controls.Add(this.getOutputDirectoryButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(642, 39);
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
            this.flowLayoutPanel4.Controls.Add(this.doDebugButton);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(295, 198);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(350, 48);
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
            // reportText
            // 
            this.reportText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportText.Location = new System.Drawing.Point(3, 91);
            this.reportText.MaxLength = 0;
            this.reportText.Multiline = true;
            this.reportText.Name = "reportText";
            this.reportText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportText.Size = new System.Drawing.Size(642, 101);
            this.reportText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 285);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ExcelEffect";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
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
    }
}

