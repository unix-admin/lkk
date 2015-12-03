namespace LKK
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.workMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.townsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSoftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workMode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(419, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // workMode
            // 
            this.workMode.Image = global::LKK.Properties.Resources.Documents3422334;
            this.workMode.Name = "workMode";
            this.workMode.Size = new System.Drawing.Size(104, 17);
            this.workMode.Text = "Режим роботи";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // workToolStripMenuItem
            // 
            this.workToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.workToolStripMenuItem.Name = "workToolStripMenuItem";
            this.workToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.workToolStripMenuItem.Text = "Робота з програмою";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "Новий";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.changeToolStripMenuItem.Text = "Режим роботи";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.searchToolStripMenuItem.Text = "Пошук";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctrosToolStripMenuItem,
            this.regionsToolStripMenuItem,
            this.townsToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.membersToolStripMenuItem,
            this.diagnosesToolStripMenuItem,
            this.inferenceToolStripMenuItem,
            this.administerToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.databaseToolStripMenuItem.Text = "База даних";
            // 
            // doctrosToolStripMenuItem
            // 
            this.doctrosToolStripMenuItem.Name = "doctrosToolStripMenuItem";
            this.doctrosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.doctrosToolStripMenuItem.Text = "Лікарі";
            this.doctrosToolStripMenuItem.Click += new System.EventHandler(this.doctrosToolStripMenuItem_Click);
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.regionsToolStripMenuItem.Text = "Райони";
            this.regionsToolStripMenuItem.Click += new System.EventHandler(this.regionsToolStripMenuItem_Click);
            // 
            // townsToolStripMenuItem
            // 
            this.townsToolStripMenuItem.Name = "townsToolStripMenuItem";
            this.townsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.townsToolStripMenuItem.Text = "Міста";
            this.townsToolStripMenuItem.Visible = false;
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.departmentsToolStripMenuItem.Text = "Відділення";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.membersToolStripMenuItem.Text = "Комісія ЛКК";
            this.membersToolStripMenuItem.Click += new System.EventHandler(this.membersToolStripMenuItem_Click);
            // 
            // diagnosesToolStripMenuItem
            // 
            this.diagnosesToolStripMenuItem.Name = "diagnosesToolStripMenuItem";
            this.diagnosesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.diagnosesToolStripMenuItem.Text = "Діагнози";
            this.diagnosesToolStripMenuItem.Click += new System.EventHandler(this.diagnosesToolStripMenuItem_Click);
            // 
            // inferenceToolStripMenuItem
            // 
            this.inferenceToolStripMenuItem.Name = "inferenceToolStripMenuItem";
            this.inferenceToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.inferenceToolStripMenuItem.Text = "Висновки ЛКК";
            this.inferenceToolStripMenuItem.Click += new System.EventHandler(this.inferenceToolStripMenuItem_Click);
            // 
            // administerToolStripMenuItem
            // 
            this.administerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.recreateToolStripMenuItem});
            this.administerToolStripMenuItem.Name = "administerToolStripMenuItem";
            this.administerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.administerToolStripMenuItem.Text = "Адміністрування";
            this.administerToolStripMenuItem.Visible = false;
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.backupToolStripMenuItem.Text = "Резервна копія";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.restoreToolStripMenuItem.Text = "Відновлення з резервної копії";
            // 
            // recreateToolStripMenuItem
            // 
            this.recreateToolStripMenuItem.Name = "recreateToolStripMenuItem";
            this.recreateToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.recreateToolStripMenuItem.Text = "Створити нову базу даних";
            this.recreateToolStripMenuItem.Click += new System.EventHandler(this.recreateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSoftToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.aboutToolStripMenuItem.Text = "Про програму";
            // 
            // aboutSoftToolStripMenuItem
            // 
            this.aboutSoftToolStripMenuItem.Name = "aboutSoftToolStripMenuItem";
            this.aboutSoftToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutSoftToolStripMenuItem.Text = "Про програму";
            this.aboutSoftToolStripMenuItem.Click += new System.EventHandler(this.aboutSoftToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "АРМ комісії ЛКК";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem townsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSoftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel workMode;
    }
}

