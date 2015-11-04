namespace LKK
{
    partial class search
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
            this.startLKKdate = new System.Windows.Forms.DateTimePicker();
            this.endLKKDate = new System.Windows.Forms.DateTimePicker();
            this.Surname = new System.Windows.Forms.CheckBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.CheckBox();
            this.ageStart = new System.Windows.Forms.NumericUpDown();
            this.ageEnd = new System.Windows.Forms.NumericUpDown();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.region = new System.Windows.Forms.CheckBox();
            this.diagnose = new System.Windows.Forms.CheckBox();
            this.diagnoseBox = new System.Windows.Forms.ComboBox();
            this.manWoman = new System.Windows.Forms.CheckBox();
            this.orphanDiseases = new System.Windows.Forms.CheckBox();
            this.lpzBox = new System.Windows.Forms.ComboBox();
            this.checkLPZ = new System.Windows.Forms.CheckBox();
            this.startSearch = new System.Windows.Forms.Button();
            this.betweenLKK = new System.Windows.Forms.Label();
            this.betweenAge = new System.Windows.Forms.Label();
            this.lkkDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // startLKKdate
            // 
            this.startLKKdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startLKKdate.Location = new System.Drawing.Point(171, 12);
            this.startLKKdate.Name = "startLKKdate";
            this.startLKKdate.Size = new System.Drawing.Size(92, 20);
            this.startLKKdate.TabIndex = 0;
            // 
            // endLKKDate
            // 
            this.endLKKDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endLKKDate.Location = new System.Drawing.Point(286, 12);
            this.endLKKDate.Name = "endLKKDate";
            this.endLKKDate.Size = new System.Drawing.Size(94, 20);
            this.endLKKDate.TabIndex = 1;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(12, 52);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(44, 17);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "ПІБ";
            this.Surname.UseVisualStyleBackColor = true;
            this.Surname.CheckedChanged += new System.EventHandler(this.Surname_CheckedChanged);
            // 
            // surnameText
            // 
            this.surnameText.Enabled = false;
            this.surnameText.Location = new System.Drawing.Point(115, 52);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(263, 20);
            this.surnameText.TabIndex = 4;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(12, 89);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(41, 17);
            this.age.TabIndex = 5;
            this.age.Text = "Вік";
            this.age.UseVisualStyleBackColor = true;
            this.age.CheckedChanged += new System.EventHandler(this.age_CheckedChanged);
            // 
            // ageStart
            // 
            this.ageStart.Enabled = false;
            this.ageStart.Location = new System.Drawing.Point(73, 88);
            this.ageStart.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageStart.Name = "ageStart";
            this.ageStart.Size = new System.Drawing.Size(87, 20);
            this.ageStart.TabIndex = 6;
            // 
            // ageEnd
            // 
            this.ageEnd.Enabled = false;
            this.ageEnd.Location = new System.Drawing.Point(199, 89);
            this.ageEnd.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageEnd.Name = "ageEnd";
            this.ageEnd.Size = new System.Drawing.Size(92, 20);
            this.ageEnd.TabIndex = 7;
            // 
            // regionBox
            // 
            this.regionBox.Enabled = false;
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Location = new System.Drawing.Point(73, 127);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(218, 21);
            this.regionBox.TabIndex = 8;
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.Location = new System.Drawing.Point(12, 131);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(57, 17);
            this.region.TabIndex = 9;
            this.region.Text = "Район";
            this.region.UseVisualStyleBackColor = true;
            this.region.CheckedChanged += new System.EventHandler(this.region_CheckedChanged);
            // 
            // diagnose
            // 
            this.diagnose.AutoSize = true;
            this.diagnose.Location = new System.Drawing.Point(12, 169);
            this.diagnose.Name = "diagnose";
            this.diagnose.Size = new System.Drawing.Size(66, 17);
            this.diagnose.TabIndex = 10;
            this.diagnose.Text = "Діагноз";
            this.diagnose.UseVisualStyleBackColor = true;
            this.diagnose.CheckedChanged += new System.EventHandler(this.diagnose_CheckedChanged);
            // 
            // diagnoseBox
            // 
            this.diagnoseBox.Enabled = false;
            this.diagnoseBox.FormattingEnabled = true;
            this.diagnoseBox.Location = new System.Drawing.Point(98, 165);
            this.diagnoseBox.Name = "diagnoseBox";
            this.diagnoseBox.Size = new System.Drawing.Size(280, 21);
            this.diagnoseBox.TabIndex = 11;
            // 
            // manWoman
            // 
            this.manWoman.AutoSize = true;
            this.manWoman.Location = new System.Drawing.Point(12, 243);
            this.manWoman.Name = "manWoman";
            this.manWoman.Size = new System.Drawing.Size(334, 17);
            this.manWoman.TabIndex = 12;
            this.manWoman.Text = "Виключити осіб яким на даний домент виповнилося 18 років";
            this.manWoman.UseVisualStyleBackColor = true;
            // 
            // orphanDiseases
            // 
            this.orphanDiseases.AutoSize = true;
            this.orphanDiseases.Location = new System.Drawing.Point(12, 275);
            this.orphanDiseases.Name = "orphanDiseases";
            this.orphanDiseases.Size = new System.Drawing.Size(144, 17);
            this.orphanDiseases.TabIndex = 13;
            this.orphanDiseases.Text = "Орфанні захворювання";
            this.orphanDiseases.UseVisualStyleBackColor = true;
            // 
            // lpzBox
            // 
            this.lpzBox.Enabled = false;
            this.lpzBox.FormattingEnabled = true;
            this.lpzBox.Location = new System.Drawing.Point(98, 204);
            this.lpzBox.Name = "lpzBox";
            this.lpzBox.Size = new System.Drawing.Size(280, 21);
            this.lpzBox.TabIndex = 15;
            // 
            // checkLPZ
            // 
            this.checkLPZ.AutoSize = true;
            this.checkLPZ.Location = new System.Drawing.Point(12, 208);
            this.checkLPZ.Name = "checkLPZ";
            this.checkLPZ.Size = new System.Drawing.Size(49, 17);
            this.checkLPZ.TabIndex = 14;
            this.checkLPZ.Text = "ЛПЗ";
            this.checkLPZ.UseVisualStyleBackColor = true;
            this.checkLPZ.CheckedChanged += new System.EventHandler(this.checkLPZ_CheckedChanged);
            // 
            // startSearch
            // 
            this.startSearch.Location = new System.Drawing.Point(216, 271);
            this.startSearch.Name = "startSearch";
            this.startSearch.Size = new System.Drawing.Size(177, 23);
            this.startSearch.TabIndex = 16;
            this.startSearch.Text = "Пошук......";
            this.startSearch.UseVisualStyleBackColor = true;
            this.startSearch.Click += new System.EventHandler(this.startSearch_Click);
            // 
            // betweenLKK
            // 
            this.betweenLKK.AutoSize = true;
            this.betweenLKK.Location = new System.Drawing.Point(265, 16);
            this.betweenLKK.Name = "betweenLKK";
            this.betweenLKK.Size = new System.Drawing.Size(19, 13);
            this.betweenLKK.TabIndex = 17;
            this.betweenLKK.Text = "до";
            // 
            // betweenAge
            // 
            this.betweenAge.AutoSize = true;
            this.betweenAge.Location = new System.Drawing.Point(169, 93);
            this.betweenAge.Name = "betweenAge";
            this.betweenAge.Size = new System.Drawing.Size(19, 13);
            this.betweenAge.TabIndex = 18;
            this.betweenAge.Text = "до";
            // 
            // lkkDate
            // 
            this.lkkDate.AutoSize = true;
            this.lkkDate.Location = new System.Drawing.Point(14, 15);
            this.lkkDate.Name = "lkkDate";
            this.lkkDate.Size = new System.Drawing.Size(156, 13);
            this.lkkDate.TabIndex = 19;
            this.lkkDate.Text = "Дата засідання ЛКК            з:";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 306);
            this.Controls.Add(this.lkkDate);
            this.Controls.Add(this.betweenAge);
            this.Controls.Add(this.betweenLKK);
            this.Controls.Add(this.startSearch);
            this.Controls.Add(this.lpzBox);
            this.Controls.Add(this.checkLPZ);
            this.Controls.Add(this.orphanDiseases);
            this.Controls.Add(this.manWoman);
            this.Controls.Add(this.diagnoseBox);
            this.Controls.Add(this.diagnose);
            this.Controls.Add(this.region);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.ageEnd);
            this.Controls.Add(this.ageStart);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.endLKKDate);
            this.Controls.Add(this.startLKKdate);
            this.Name = "search";
            this.Text = "search";
            ((System.ComponentModel.ISupportInitialize)(this.ageStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startLKKdate;
        private System.Windows.Forms.DateTimePicker endLKKDate;
        private System.Windows.Forms.CheckBox Surname;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.CheckBox age;
        private System.Windows.Forms.NumericUpDown ageStart;
        private System.Windows.Forms.NumericUpDown ageEnd;
        private System.Windows.Forms.ComboBox regionBox;
        private System.Windows.Forms.CheckBox region;
        private System.Windows.Forms.CheckBox diagnose;
        private System.Windows.Forms.ComboBox diagnoseBox;
        private System.Windows.Forms.CheckBox manWoman;
        private System.Windows.Forms.CheckBox orphanDiseases;
        private System.Windows.Forms.ComboBox lpzBox;
        private System.Windows.Forms.CheckBox checkLPZ;
        private System.Windows.Forms.Button startSearch;
        private System.Windows.Forms.Label betweenLKK;
        private System.Windows.Forms.Label betweenAge;
        private System.Windows.Forms.Label lkkDate;
    }
}