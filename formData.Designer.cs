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
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mainDs = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.insertButton.Location = new System.Drawing.Point(220, 265);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(118, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Додати дані";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(571, 265);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Видилити дані";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(402, 265);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Змінити дані";
            this.deleteButton.UseVisualStyleBackColor = true;
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
            // formData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 309);
            this.Controls.Add(this.mainDs);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 348);
            this.MinimizeBox = false;
            this.Name = "formData";
            this.Text = "formData";
            this.Shown += new System.EventHandler(this.formData_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckBox mainDs;
    }
}