namespace DesktopAppSearchFilesV2
{
    partial class SearchFilesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.filesTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.searchFilesTextBox = new System.Windows.Forms.TextBox();
            this.buttonSelectFileInPC = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.stopSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNameSearchDirectory = new System.Windows.Forms.Label();
            this.labelCountFilesFound = new System.Windows.Forms.Label();
            this.labelCountFiles = new System.Windows.Forms.Label();
            this.labelTimeAfterStartSearch = new System.Windows.Forms.Label();
            this.timerAfterStartSearch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // filesTreeView
            // 
            this.filesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesTreeView.Location = new System.Drawing.Point(11, 107);
            this.filesTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filesTreeView.Name = "filesTreeView";
            this.filesTreeView.Size = new System.Drawing.Size(679, 281);
            this.filesTreeView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стартовая директория:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя файла:";
            // 
            // startDirectoryTextBox
            // 
            this.startDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDirectoryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDirectoryTextBox.Location = new System.Drawing.Point(187, 6);
            this.startDirectoryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startDirectoryTextBox.Name = "startDirectoryTextBox";
            this.startDirectoryTextBox.Size = new System.Drawing.Size(403, 27);
            this.startDirectoryTextBox.TabIndex = 0;
            // 
            // searchFilesTextBox
            // 
            this.searchFilesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFilesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFilesTextBox.Location = new System.Drawing.Point(187, 37);
            this.searchFilesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchFilesTextBox.Name = "searchFilesTextBox";
            this.searchFilesTextBox.Size = new System.Drawing.Size(503, 27);
            this.searchFilesTextBox.TabIndex = 3;
            // 
            // buttonSelectFileInPC
            // 
            this.buttonSelectFileInPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFileInPC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectFileInPC.Location = new System.Drawing.Point(597, 5);
            this.buttonSelectFileInPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectFileInPC.Name = "buttonSelectFileInPC";
            this.buttonSelectFileInPC.Size = new System.Drawing.Size(94, 24);
            this.buttonSelectFileInPC.TabIndex = 16;
            this.buttonSelectFileInPC.Text = "Обзор";
            this.buttonSelectFileInPC.UseVisualStyleBackColor = true;
            this.buttonSelectFileInPC.Click += new System.EventHandler(this.buttonSelectFileInPC_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(440, 71);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 29);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // stopSearchButton
            // 
            this.stopSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopSearchButton.Location = new System.Drawing.Point(568, 71);
            this.stopSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopSearchButton.Name = "stopSearchButton";
            this.stopSearchButton.Size = new System.Drawing.Size(122, 29);
            this.stopSearchButton.TabIndex = 6;
            this.stopSearchButton.Text = "Остановить";
            this.stopSearchButton.UseVisualStyleBackColor = true;
            this.stopSearchButton.Click += new System.EventHandler(this.stopSearchButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поиск идет в директории:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Файлов найдено:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Всего файлов:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Времени с начала поиска:";
            // 
            // labelNameSearchDirectory
            // 
            this.labelNameSearchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNameSearchDirectory.AutoSize = true;
            this.labelNameSearchDirectory.Location = new System.Drawing.Point(207, 399);
            this.labelNameSearchDirectory.Name = "labelNameSearchDirectory";
            this.labelNameSearchDirectory.Size = new System.Drawing.Size(0, 20);
            this.labelNameSearchDirectory.TabIndex = 12;
            // 
            // labelCountFilesFound
            // 
            this.labelCountFilesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountFilesFound.AutoSize = true;
            this.labelCountFilesFound.Location = new System.Drawing.Point(207, 419);
            this.labelCountFilesFound.Name = "labelCountFilesFound";
            this.labelCountFilesFound.Size = new System.Drawing.Size(0, 20);
            this.labelCountFilesFound.TabIndex = 13;
            // 
            // labelCountFiles
            // 
            this.labelCountFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCountFiles.AutoSize = true;
            this.labelCountFiles.Location = new System.Drawing.Point(207, 439);
            this.labelCountFiles.Name = "labelCountFiles";
            this.labelCountFiles.Size = new System.Drawing.Size(0, 20);
            this.labelCountFiles.TabIndex = 14;
            // 
            // labelTimeAfterStartSearch
            // 
            this.labelTimeAfterStartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTimeAfterStartSearch.AutoSize = true;
            this.labelTimeAfterStartSearch.Location = new System.Drawing.Point(207, 459);
            this.labelTimeAfterStartSearch.Name = "labelTimeAfterStartSearch";
            this.labelTimeAfterStartSearch.Size = new System.Drawing.Size(0, 20);
            this.labelTimeAfterStartSearch.TabIndex = 15;
            // 
            // timerAfterStartSearch
            // 
            this.timerAfterStartSearch.Interval = 1000;
            this.timerAfterStartSearch.Tick += new System.EventHandler(this.timerAfterStartSearch_Tick);
            // 
            // SearchFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 485);
            this.Controls.Add(this.labelTimeAfterStartSearch);
            this.Controls.Add(this.labelCountFiles);
            this.Controls.Add(this.labelCountFilesFound);
            this.Controls.Add(this.labelNameSearchDirectory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.buttonSelectFileInPC);
            this.Controls.Add(this.searchFilesTextBox);
            this.Controls.Add(this.startDirectoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesTreeView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchFilesForm";
            this.Text = "Поиск файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchFilesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView filesTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startDirectoryTextBox;
        private System.Windows.Forms.TextBox searchFilesTextBox;
        private System.Windows.Forms.Button buttonSelectFileInPC;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button stopSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNameSearchDirectory;
        private System.Windows.Forms.Label labelCountFilesFound;
        private System.Windows.Forms.Label labelCountFiles;
        private System.Windows.Forms.Label labelTimeAfterStartSearch;
        private System.Windows.Forms.Timer timerAfterStartSearch;
    }
}

