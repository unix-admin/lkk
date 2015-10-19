namespace LKK
{
    partial class formData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.mainDs = new System.Windows.Forms.CheckBox();
            this.formDisease = new System.Windows.Forms.GroupBox();
            this.hard = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.Light = new System.Windows.Forms.RadioButton();
            this.stadia = new System.Windows.Forms.GroupBox();
            this.medicsubcomp = new System.Windows.Forms.RadioButton();
            this.subcompens = new System.Windows.Forms.RadioButton();
            this.decomp = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.formDisease.SuspendLayout();
            this.stadia.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(687, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(220, 373);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(118, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Додати дані";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(571, 373);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Видилити дані";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(402, 373);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(118, 23);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Змінити дані";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // mainDs
            // 
            this.mainDs.AutoSize = true;
            this.mainDs.Checked = true;
            this.mainDs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainDs.Location = new System.Drawing.Point(13, 265);
            this.mainDs.Name = "mainDs";
            this.mainDs.Size = new System.Drawing.Size(146, 17);
            this.mainDs.TabIndex = 4;
            this.mainDs.Text = "Использовать код МКБ";
            this.mainDs.UseVisualStyleBackColor = true;
            this.mainDs.Visible = false;
            // 
            // formDisease
            // 
            this.formDisease.Controls.Add(this.hard);
            this.formDisease.Controls.Add(this.medium);
            this.formDisease.Controls.Add(this.Light);
            this.formDisease.Location = new System.Drawing.Point(196, 255);
            this.formDisease.Name = "formDisease";
            this.formDisease.Size = new System.Drawing.Size(200, 100);
            this.formDisease.TabIndex = 5;
            this.formDisease.TabStop = false;
            this.formDisease.Text = "Форма";
            this.formDisease.Visible = false;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(7, 68);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(58, 17);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Важка";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(7, 43);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(68, 17);
            this.medium.TabIndex = 1;
            this.medium.TabStop = true;
            this.medium.Text = "Середня";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // Light
            // 
            this.Light.AutoSize = true;
            this.Light.Location = new System.Drawing.Point(7, 20);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(56, 17);
            this.Light.TabIndex = 0;
            this.Light.TabStop = true;
            this.Light.Text = "Легка";
            this.Light.UseVisualStyleBackColor = true;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // stadia
            // 
            this.stadia.Controls.Add(this.medicsubcomp);
            this.stadia.Controls.Add(this.subcompens);
            this.stadia.Controls.Add(this.decomp);
            this.stadia.Location = new System.Drawing.Point(446, 255);
            this.stadia.Name = "stadia";
            this.stadia.Size = new System.Drawing.Size(214, 100);
            this.stadia.TabIndex = 6;
            this.stadia.TabStop = false;
            this.stadia.Text = "Стадія";
            this.stadia.Visible = false;
            // 
            // medicsubcomp
            // 
            this.medicsubcomp.AutoSize = true;
            this.medicsubcomp.Location = new System.Drawing.Point(7, 68);
            this.medicsubcomp.Name = "medicsubcomp";
            this.medicsubcomp.Size = new System.Drawing.Size(197, 17);
            this.medicsubcomp.TabIndex = 2;
            this.medicsubcomp.TabStop = true;
            this.medicsubcomp.Text = "Медикаментозної субкомпенсації";
            this.medicsubcomp.UseVisualStyleBackColor = true;
            this.medicsubcomp.Click += new System.EventHandler(this.medicsubcomp_Click);
            // 
            // subcompens
            // 
            this.subcompens.AutoSize = true;
            this.subcompens.Location = new System.Drawing.Point(7, 43);
            this.subcompens.Name = "subcompens";
            this.subcompens.Size = new System.Drawing.Size(104, 17);
            this.subcompens.TabIndex = 1;
            this.subcompens.TabStop = true;
            this.subcompens.Text = "Субкомпенсації";
            this.subcompens.UseVisualStyleBackColor = true;
            this.subcompens.Click += new System.EventHandler(this.subcompens_Click);
            // 
            // decomp
            // 
            this.decomp.AutoSize = true;
            this.decomp.Location = new System.Drawing.Point(7, 20);
            this.decomp.Name = "decomp";
            this.decomp.Size = new System.Drawing.Size(101, 17);
            this.decomp.TabIndex = 0;
            this.decomp.TabStop = true;
            this.decomp.Text = "Декомпенсації";
            this.decomp.UseVisualStyleBackColor = true;
            this.decomp.Click += new System.EventHandler(this.decomp_Click);
            // 
            // formData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 410);
            this.Controls.Add(this.stadia);
            this.Controls.Add(this.formDisease);
            this.Controls.Add(this.mainDs);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 449);
            this.MinimizeBox = false;
            this.Name = "formData";
            this.Text = "formData";
            this.Load += new System.EventHandler(this.formData_Load);
            this.Shown += new System.EventHandler(this.formData_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.formDisease.ResumeLayout(false);
            this.formDisease.PerformLayout();
            this.stadia.ResumeLayout(false);
            this.stadia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.CheckBox mainDs;
        private System.Windows.Forms.GroupBox formDisease;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton Light;
        private System.Windows.Forms.GroupBox stadia;
        private System.Windows.Forms.RadioButton medicsubcomp;
        private System.Windows.Forms.RadioButton subcompens;
        private System.Windows.Forms.RadioButton decomp;
    }
}