namespace LKK
{
    partial class Mode
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
            this.modeLkk = new System.Windows.Forms.RadioButton();
            this.modeInsulin = new System.Windows.Forms.RadioButton();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modeLkk
            // 
            this.modeLkk.AutoSize = true;
            this.modeLkk.Location = new System.Drawing.Point(48, 30);
            this.modeLkk.Name = "modeLkk";
            this.modeLkk.Size = new System.Drawing.Size(165, 17);
            this.modeLkk.TabIndex = 0;
            this.modeLkk.TabStop = true;
            this.modeLkk.Text = "Робота з протоколами ЛКК";
            this.modeLkk.UseVisualStyleBackColor = true;
            // 
            // modeInsulin
            // 
            this.modeInsulin.AutoSize = true;
            this.modeInsulin.Location = new System.Drawing.Point(48, 70);
            this.modeInsulin.Name = "modeInsulin";
            this.modeInsulin.Size = new System.Drawing.Size(167, 17);
            this.modeInsulin.TabIndex = 1;
            this.modeInsulin.TabStop = true;
            this.modeInsulin.Text = "Робота з реєстром інвалідів";
            this.modeInsulin.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(47, 117);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(188, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Змінити";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.modeInsulin);
            this.Controls.Add(this.modeLkk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим роботи";
            this.Shown += new System.EventHandler(this.Mode_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton modeLkk;
        private System.Windows.Forms.RadioButton modeInsulin;
        private System.Windows.Forms.Button changeButton;
    }
}