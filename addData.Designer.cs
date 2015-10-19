namespace LKK
{
    partial class addData
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
            this.valueToEdit = new System.Windows.Forms.TextBox();
            this.confirn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.nameValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueToEdit
            // 
            this.valueToEdit.Location = new System.Drawing.Point(12, 39);
            this.valueToEdit.Name = "valueToEdit";
            this.valueToEdit.Size = new System.Drawing.Size(435, 20);
            this.valueToEdit.TabIndex = 0;
            // 
            // confirn
            // 
            this.confirn.Location = new System.Drawing.Point(211, 77);
            this.confirn.Name = "confirn";
            this.confirn.Size = new System.Drawing.Size(75, 23);
            this.confirn.TabIndex = 1;
            this.confirn.Text = "ОК";
            this.confirn.UseVisualStyleBackColor = true;
            this.confirn.Click += new System.EventHandler(this.confirn_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(325, 77);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // nameValue
            // 
            this.nameValue.AutoSize = true;
            this.nameValue.Location = new System.Drawing.Point(52, 15);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(60, 13);
            this.nameValue.TabIndex = 3;
            this.nameValue.Text = "nameValue";
            // 
            // addData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 112);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirn);
            this.Controls.Add(this.valueToEdit);
            this.Name = "addData";
            this.Text = "addData";
            this.Load += new System.EventHandler(this.addData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueToEdit;
        private System.Windows.Forms.Button confirn;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label nameValue;
    }
}