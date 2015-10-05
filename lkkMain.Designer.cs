namespace LKK
{
    partial class lkkMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.lkkDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lkkNumber = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doctor = new System.Windows.Forms.ComboBox();
            this.addDepartment = new System.Windows.Forms.Button();
            this.addDoctor = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.yearBirth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.region = new System.Windows.Forms.ComboBox();
            this.addRegion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.town = new System.Windows.Forms.ComboBox();
            this.addTown = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.diagnose = new System.Windows.Forms.RichTextBox();
            this.lkk = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.msek = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.additions = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.toDatabase = new System.Windows.Forms.Button();
            this.addLkk = new System.Windows.Forms.Button();
            this.addDiagnose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата засідання лкк";
            // 
            // lkkDate
            // 
            this.lkkDate.Location = new System.Drawing.Point(127, 13);
            this.lkkDate.Name = "lkkDate";
            this.lkkDate.Size = new System.Drawing.Size(151, 20);
            this.lkkDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "№ протоколу ЛКК";
            // 
            // lkkNumber
            // 
            this.lkkNumber.Location = new System.Drawing.Point(435, 16);
            this.lkkNumber.Name = "lkkNumber";
            this.lkkNumber.Size = new System.Drawing.Size(116, 20);
            this.lkkNumber.TabIndex = 3;
            // 
            // department
            // 
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.FormattingEnabled = true;
            this.department.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.department.Location = new System.Drawing.Point(82, 42);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(196, 21);
            this.department.Sorted = true;
            this.department.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Відділення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Лікар";
            // 
            // doctor
            // 
            this.doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctor.FormattingEnabled = true;
            this.doctor.Location = new System.Drawing.Point(370, 45);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(181, 21);
            this.doctor.Sorted = true;
            this.doctor.TabIndex = 6;
            // 
            // addDepartment
            // 
            this.addDepartment.Location = new System.Drawing.Point(284, 42);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(25, 23);
            this.addDepartment.TabIndex = 8;
            this.addDepartment.Text = "+";
            this.addDepartment.UseVisualStyleBackColor = true;
            // 
            // addDoctor
            // 
            this.addDoctor.Location = new System.Drawing.Point(557, 45);
            this.addDoctor.Name = "addDoctor";
            this.addDoctor.Size = new System.Drawing.Size(25, 23);
            this.addDoctor.TabIndex = 9;
            this.addDoctor.Text = "+";
            this.addDoctor.UseVisualStyleBackColor = true;
            this.addDoctor.Click += new System.EventHandler(this.addDoctor_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(82, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(469, 20);
            this.name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ПІБ хворого";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Стать";
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Location = new System.Drawing.Point(82, 104);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(51, 21);
            this.sex.TabIndex = 12;
            // 
            // yearBirth
            // 
            this.yearBirth.Location = new System.Drawing.Point(226, 107);
            this.yearBirth.Name = "yearBirth";
            this.yearBirth.Size = new System.Drawing.Size(49, 20);
            this.yearBirth.TabIndex = 15;
            this.yearBirth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Рік народження";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(311, 107);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(31, 20);
            this.age.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Вік";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Район";
            // 
            // region
            // 
            this.region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.region.FormattingEnabled = true;
            this.region.Location = new System.Drawing.Point(392, 108);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(159, 21);
            this.region.Sorted = true;
            this.region.TabIndex = 18;
            this.region.SelectedIndexChanged += new System.EventHandler(this.region_SelectedIndexChanged);
            this.region.SelectionChangeCommitted += new System.EventHandler(this.region_SelectionChangeCommitted);
            // 
            // addRegion
            // 
            this.addRegion.Location = new System.Drawing.Point(557, 107);
            this.addRegion.Name = "addRegion";
            this.addRegion.Size = new System.Drawing.Size(25, 23);
            this.addRegion.TabIndex = 20;
            this.addRegion.Text = "+";
            this.addRegion.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "МІсто/Село";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(338, 135);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(213, 20);
            this.address.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Адреса";
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(338, 163);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(213, 20);
            this.position.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Посада";
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(93, 163);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(182, 20);
            this.work.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Місце роботи";
            // 
            // town
            // 
            this.town.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.town.FormattingEnabled = true;
            this.town.Location = new System.Drawing.Point(82, 134);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(176, 21);
            this.town.TabIndex = 29;
            // 
            // addTown
            // 
            this.addTown.Location = new System.Drawing.Point(264, 132);
            this.addTown.Name = "addTown";
            this.addTown.Size = new System.Drawing.Size(25, 23);
            this.addTown.TabIndex = 30;
            this.addTown.Text = "+";
            this.addTown.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Діагноз";
            // 
            // diagnose
            // 
            this.diagnose.Location = new System.Drawing.Point(93, 194);
            this.diagnose.Name = "diagnose";
            this.diagnose.Size = new System.Drawing.Size(458, 96);
            this.diagnose.TabIndex = 32;
            this.diagnose.Text = "";
            // 
            // lkk
            // 
            this.lkk.Location = new System.Drawing.Point(93, 296);
            this.lkk.Name = "lkk";
            this.lkk.Size = new System.Drawing.Size(458, 96);
            this.lkk.TabIndex = 34;
            this.lkk.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Висновок ЛКК";
            // 
            // msek
            // 
            this.msek.Location = new System.Drawing.Point(93, 398);
            this.msek.Name = "msek";
            this.msek.Size = new System.Drawing.Size(458, 96);
            this.msek.TabIndex = 36;
            this.msek.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Висновок МСЕК";
            // 
            // additions
            // 
            this.additions.Location = new System.Drawing.Point(93, 500);
            this.additions.Name = "additions";
            this.additions.Size = new System.Drawing.Size(458, 96);
            this.additions.TabIndex = 38;
            this.additions.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Примітка";
            // 
            // toDatabase
            // 
            this.toDatabase.Location = new System.Drawing.Point(82, 605);
            this.toDatabase.Name = "toDatabase";
            this.toDatabase.Size = new System.Drawing.Size(500, 23);
            this.toDatabase.TabIndex = 39;
            this.toDatabase.Text = "В базу";
            this.toDatabase.UseVisualStyleBackColor = true;
            this.toDatabase.Click += new System.EventHandler(this.toDatabase_Click);
            // 
            // addLkk
            // 
            this.addLkk.Location = new System.Drawing.Point(557, 369);
            this.addLkk.Name = "addLkk";
            this.addLkk.Size = new System.Drawing.Size(25, 23);
            this.addLkk.TabIndex = 41;
            this.addLkk.Text = "+";
            this.addLkk.UseVisualStyleBackColor = true;
            // 
            // addDiagnose
            // 
            this.addDiagnose.Location = new System.Drawing.Point(557, 267);
            this.addDiagnose.Name = "addDiagnose";
            this.addDiagnose.Size = new System.Drawing.Size(25, 23);
            this.addDiagnose.TabIndex = 40;
            this.addDiagnose.Text = "+";
            this.addDiagnose.UseVisualStyleBackColor = true;
            // 
            // lkkMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 640);
            this.Controls.Add(this.addLkk);
            this.Controls.Add(this.addDiagnose);
            this.Controls.Add(this.toDatabase);
            this.Controls.Add(this.additions);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.msek);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lkk);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.diagnose);
            this.Controls.Add(this.label14);
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
            this.Controls.Add(this.yearBirth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addDoctor);
            this.Controls.Add(this.addDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.department);
            this.Controls.Add(this.lkkNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lkkDate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(617, 679);
            this.MinimizeBox = false;
            this.Name = "lkkMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lkkMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker lkkDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lkkNumber;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox doctor;
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.Button addDoctor;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.TextBox yearBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox region;
        private System.Windows.Forms.Button addRegion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox town;
        private System.Windows.Forms.Button addTown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox diagnose;
        private System.Windows.Forms.RichTextBox lkk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox msek;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox additions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button toDatabase;
        private System.Windows.Forms.Button addLkk;
        private System.Windows.Forms.Button addDiagnose;
    }
}