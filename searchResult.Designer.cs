namespace LKK
{
    partial class searchResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultsLKK = new System.Windows.Forms.DataGridView();
            this.printLKK = new System.Windows.Forms.RadioButton();
            this.printReport = new System.Windows.Forms.RadioButton();
            this.printAll = new System.Windows.Forms.RadioButton();
            this.printButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.GroupBox();
            this.invalidity = new System.Windows.Forms.Label();
            this.children = new System.Windows.Forms.Label();
            this.womans = new System.Windows.Forms.Label();
            this.mans = new System.Windows.Forms.Label();
            this.allRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultsLKK)).BeginInit();
            this.statistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsLKK
            // 
            this.resultsLKK.AllowUserToAddRows = false;
            this.resultsLKK.AllowUserToDeleteRows = false;
            this.resultsLKK.AllowUserToOrderColumns = true;
            this.resultsLKK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsLKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsLKK.Location = new System.Drawing.Point(13, 13);
            this.resultsLKK.Name = "resultsLKK";
            this.resultsLKK.ReadOnly = true;
            this.resultsLKK.RowHeadersVisible = false;
            this.resultsLKK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsLKK.Size = new System.Drawing.Size(756, 226);
            this.resultsLKK.TabIndex = 0;
            // 
            // printLKK
            // 
            this.printLKK.AutoSize = true;
            this.printLKK.Location = new System.Drawing.Point(12, 256);
            this.printLKK.Name = "printLKK";
            this.printLKK.Size = new System.Drawing.Size(119, 17);
            this.printLKK.TabIndex = 1;
            this.printLKK.TabStop = true;
            this.printLKK.Text = "Друк рішення ЛКК";
            this.printLKK.UseVisualStyleBackColor = true;
            // 
            // printReport
            // 
            this.printReport.AutoSize = true;
            this.printReport.Location = new System.Drawing.Point(12, 286);
            this.printReport.Name = "printReport";
            this.printReport.Size = new System.Drawing.Size(149, 17);
            this.printReport.TabIndex = 2;
            this.printReport.TabStop = true;
            this.printReport.Text = "Друк протоколу хворого";
            this.printReport.UseVisualStyleBackColor = true;
            // 
            // printAll
            // 
            this.printAll.AutoSize = true;
            this.printAll.Location = new System.Drawing.Point(12, 316);
            this.printAll.Name = "printAll";
            this.printAll.Size = new System.Drawing.Size(89, 17);
            this.printAll.TabIndex = 3;
            this.printAll.TabStop = true;
            this.printAll.Text = "Друк списку";
            this.printAll.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(176, 278);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(122, 32);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Друк";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(347, 278);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(122, 32);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Змінити";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // statistic
            // 
            this.statistic.Controls.Add(this.invalidity);
            this.statistic.Controls.Add(this.children);
            this.statistic.Controls.Add(this.womans);
            this.statistic.Controls.Add(this.mans);
            this.statistic.Controls.Add(this.allRows);
            this.statistic.Location = new System.Drawing.Point(519, 249);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(250, 93);
            this.statistic.TabIndex = 7;
            this.statistic.TabStop = false;
            this.statistic.Text = "Статистика";
            // 
            // invalidity
            // 
            this.invalidity.AutoSize = true;
            this.invalidity.Location = new System.Drawing.Point(6, 65);
            this.invalidity.Name = "invalidity";
            this.invalidity.Size = new System.Drawing.Size(56, 13);
            this.invalidity.TabIndex = 4;
            this.invalidity.Text = "Інвалідів: ";
            // 
            // children
            // 
            this.children.AutoSize = true;
            this.children.Location = new System.Drawing.Point(6, 48);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(100, 13);
            this.children.TabIndex = 3;
            this.children.Text = "Дітей до 18 років: ";
            // 
            // womans
            // 
            this.womans.AutoSize = true;
            this.womans.Location = new System.Drawing.Point(131, 31);
            this.womans.Name = "womans";
            this.womans.Size = new System.Drawing.Size(44, 13);
            this.womans.TabIndex = 2;
            this.womans.Text = "Жінок: ";
            // 
            // mans
            // 
            this.mans.AutoSize = true;
            this.mans.Location = new System.Drawing.Point(6, 32);
            this.mans.Name = "mans";
            this.mans.Size = new System.Drawing.Size(61, 13);
            this.mans.TabIndex = 1;
            this.mans.Text = "Чоловіків: ";
            // 
            // allRows
            // 
            this.allRows.AutoSize = true;
            this.allRows.Location = new System.Drawing.Point(4, 16);
            this.allRows.Name = "allRows";
            this.allRows.Size = new System.Drawing.Size(90, 13);
            this.allRows.TabIndex = 0;
            this.allRows.Text = "Всього записів: ";
            // 
            // searchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 354);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.printAll);
            this.Controls.Add(this.printReport);
            this.Controls.Add(this.printLKK);
            this.Controls.Add(this.resultsLKK);
            this.Name = "searchResult";
            this.Text = "Результати пошуку";
            this.Shown += new System.EventHandler(this.searchResult_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.resultsLKK)).EndInit();
            this.statistic.ResumeLayout(false);
            this.statistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsLKK;
        private System.Windows.Forms.RadioButton printLKK;
        private System.Windows.Forms.RadioButton printReport;
        private System.Windows.Forms.RadioButton printAll;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox statistic;
        private System.Windows.Forms.Label invalidity;
        private System.Windows.Forms.Label children;
        private System.Windows.Forms.Label womans;
        private System.Windows.Forms.Label mans;
        private System.Windows.Forms.Label allRows;
    }
}