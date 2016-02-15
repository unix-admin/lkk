namespace LKK
{
    partial class invalidityRegister
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
            this.noLimit = new System.Windows.Forms.CheckBox();
            this.buttonAddLPZ = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.LPZ = new System.Windows.Forms.ComboBox();
            this.invalidityLabelText = new System.Windows.Forms.Label();
            this.invalidityDate = new System.Windows.Forms.DateTimePicker();
            this.addTown = new System.Windows.Forms.Button();
            this.town = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addRegion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.to18yo = new System.Windows.Forms.CheckBox();
            this.addDiagnose = new System.Windows.Forms.Button();
            this.diagnose = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toDatabase = new System.Windows.Forms.Button();
            this.additions = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.invalidityGroupe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // noLimit
            // 
            this.noLimit.AutoSize = true;
            this.noLimit.Location = new System.Drawing.Point(245, 168);
            this.noLimit.Name = "noLimit";
            this.noLimit.Size = new System.Drawing.Size(92, 17);
            this.noLimit.TabIndex = 84;
            this.noLimit.Text = "Безстроково";
            this.noLimit.UseVisualStyleBackColor = true;
            this.noLimit.CheckedChanged += new System.EventHandler(this.noLimit_CheckedChanged);
            // 
            // buttonAddLPZ
            // 
            this.buttonAddLPZ.Location = new System.Drawing.Point(241, 131);
            this.buttonAddLPZ.Name = "buttonAddLPZ";
            this.buttonAddLPZ.Size = new System.Drawing.Size(25, 23);
            this.buttonAddLPZ.TabIndex = 83;
            this.buttonAddLPZ.Text = "+";
            this.buttonAddLPZ.UseVisualStyleBackColor = true;
            this.buttonAddLPZ.Click += new System.EventHandler(this.buttonAddLPZ_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "ЛПЗ";
            // 
            // LPZ
            // 
            this.LPZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LPZ.FormattingEnabled = true;
            this.LPZ.Location = new System.Drawing.Point(51, 132);
            this.LPZ.Name = "LPZ";
            this.LPZ.Size = new System.Drawing.Size(184, 21);
            this.LPZ.Sorted = true;
            this.LPZ.TabIndex = 81;
            // 
            // invalidityLabelText
            // 
            this.invalidityLabelText.AutoSize = true;
            this.invalidityLabelText.Location = new System.Drawing.Point(15, 168);
            this.invalidityLabelText.Name = "invalidityLabelText";
            this.invalidityLabelText.Size = new System.Drawing.Size(115, 13);
            this.invalidityLabelText.TabIndex = 80;
            this.invalidityLabelText.Text = "Дата периотримання";
            // 
            // invalidityDate
            // 
            this.invalidityDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invalidityDate.Location = new System.Drawing.Point(136, 168);
            this.invalidityDate.Name = "invalidityDate";
            this.invalidityDate.Size = new System.Drawing.Size(103, 20);
            this.invalidityDate.TabIndex = 79;
            // 
            // addTown
            // 
            this.addTown.Location = new System.Drawing.Point(261, 70);
            this.addTown.Name = "addTown";
            this.addTown.Size = new System.Drawing.Size(25, 23);
            this.addTown.TabIndex = 78;
            this.addTown.Text = "+";
            this.addTown.UseVisualStyleBackColor = true;
            this.addTown.Click += new System.EventHandler(this.addTown_Click);
            // 
            // town
            // 
            this.town.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.town.FormattingEnabled = true;
            this.town.Location = new System.Drawing.Point(79, 72);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(176, 21);
            this.town.Sorted = true;
            this.town.TabIndex = 77;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(335, 101);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(213, 20);
            this.position.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Посада";
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(90, 101);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(182, 20);
            this.work.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 73;
            this.label13.Text = "Місце роботи";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(335, 73);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(213, 20);
            this.address.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Адреса";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "МІсто/Село";
            // 
            // addRegion
            // 
            this.addRegion.Location = new System.Drawing.Point(565, 45);
            this.addRegion.Name = "addRegion";
            this.addRegion.Size = new System.Drawing.Size(25, 23);
            this.addRegion.TabIndex = 69;
            this.addRegion.Text = "+";
            this.addRegion.UseVisualStyleBackColor = true;
            this.addRegion.Click += new System.EventHandler(this.addRegion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Район";
            // 
            // region
            // 
            this.region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.region.FormattingEnabled = true;
            this.region.Location = new System.Drawing.Point(400, 46);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(159, 21);
            this.region.Sorted = true;
            this.region.TabIndex = 67;
            this.region.SelectionChangeCommitted += new System.EventHandler(this.region_SelectionChangeCommitted);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(319, 45);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(31, 20);
            this.age.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Вік";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Дата народження";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(79, 12);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(485, 20);
            this.fio.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "ПІБ хворого";
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(216, 45);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(74, 20);
            this.birthDate.TabIndex = 50;
            this.birthDate.Leave += new System.EventHandler(this.birthDate_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Стать";
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Ж",
            "Ч"});
            this.sex.Location = new System.Drawing.Point(54, 44);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(51, 21);
            this.sex.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Група інвалідності";
            // 
            // to18yo
            // 
            this.to18yo.AutoSize = true;
            this.to18yo.Location = new System.Drawing.Point(340, 169);
            this.to18yo.Name = "to18yo";
            this.to18yo.Size = new System.Drawing.Size(65, 17);
            this.to18yo.TabIndex = 88;
            this.to18yo.Text = "До 18р.";
            this.to18yo.UseVisualStyleBackColor = true;
            this.to18yo.CheckedChanged += new System.EventHandler(this.to18yo_CheckedChanged);
            // 
            // addDiagnose
            // 
            this.addDiagnose.Location = new System.Drawing.Point(543, 265);
            this.addDiagnose.Name = "addDiagnose";
            this.addDiagnose.Size = new System.Drawing.Size(25, 23);
            this.addDiagnose.TabIndex = 91;
            this.addDiagnose.Text = "+";
            this.addDiagnose.UseVisualStyleBackColor = true;
            this.addDiagnose.Click += new System.EventHandler(this.addDiagnose_Click);
            // 
            // diagnose
            // 
            this.diagnose.Location = new System.Drawing.Point(79, 204);
            this.diagnose.Name = "diagnose";
            this.diagnose.Size = new System.Drawing.Size(458, 85);
            this.diagnose.TabIndex = 90;
            this.diagnose.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 89;
            this.label14.Text = "Діагноз";
            // 
            // toDatabase
            // 
            this.toDatabase.Location = new System.Drawing.Point(79, 394);
            this.toDatabase.Name = "toDatabase";
            this.toDatabase.Size = new System.Drawing.Size(480, 23);
            this.toDatabase.TabIndex = 94;
            this.toDatabase.Text = "В базу";
            this.toDatabase.UseVisualStyleBackColor = true;
            this.toDatabase.Click += new System.EventHandler(this.toDatabase_Click);
            // 
            // additions
            // 
            this.additions.Location = new System.Drawing.Point(79, 295);
            this.additions.Name = "additions";
            this.additions.Size = new System.Drawing.Size(458, 85);
            this.additions.TabIndex = 93;
            this.additions.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 92;
            this.label17.Text = "Примітка";
            // 
            // invalidityGroupe
            // 
            this.invalidityGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invalidityGroupe.FormattingEnabled = true;
            this.invalidityGroupe.Location = new System.Drawing.Point(375, 133);
            this.invalidityGroupe.Name = "invalidityGroupe";
            this.invalidityGroupe.Size = new System.Drawing.Size(91, 21);
            this.invalidityGroupe.TabIndex = 95;
            // 
            // invalidityRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 432);
            this.Controls.Add(this.invalidityGroupe);
            this.Controls.Add(this.toDatabase);
            this.Controls.Add(this.additions);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.addDiagnose);
            this.Controls.Add(this.diagnose);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.to18yo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.noLimit);
            this.Controls.Add(this.buttonAddLPZ);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LPZ);
            this.Controls.Add(this.invalidityLabelText);
            this.Controls.Add(this.invalidityDate);
            this.Controls.Add(this.addTown);
            this.Controls.Add(this.town);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.work);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addRegion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.region);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthDate);
            this.Name = "invalidityRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстр інвалідів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox noLimit;
        private System.Windows.Forms.Button buttonAddLPZ;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox LPZ;
        private System.Windows.Forms.Label invalidityLabelText;
        private System.Windows.Forms.DateTimePicker invalidityDate;
        private System.Windows.Forms.Button addTown;
        private System.Windows.Forms.ComboBox town;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addRegion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox region;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox to18yo;
        private System.Windows.Forms.Button addDiagnose;
        private System.Windows.Forms.RichTextBox diagnose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button toDatabase;
        private System.Windows.Forms.RichTextBox additions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox invalidityGroupe;
    }
}