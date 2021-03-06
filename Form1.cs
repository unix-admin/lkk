﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class Form1 : Form
    {
        Database data = new Database();

        public Form1()
        {
            InitializeComponent();
            workMode.Text = "Режим роботи: Робота з протоколами ЛКК";
            Program.status = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                       
        }

        private void recreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            data.createDatabase();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            switch (Program.status){
                case 0:
                    lkkMain insertData = new lkkMain();
                    insertData.MdiParent = this;
                    insertData.Show();
                    break;
                case 1:
                    invalidityRegister insertRegister = new invalidityRegister();
                    insertRegister.MdiParent = this;
                    insertRegister.Show();
                    break;
        }
            

        }

        private void doctrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formData data = new formData();
            data.setFormType(formData.formTypes.DOCTORS);
            data.setFormActions(formData.formActions.VIEW);
            data.ShowDialog();
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formData data = new formData();
            data.setFormType(formData.formTypes.REGIONS);
            data.setFormActions(formData.formActions.VIEW);
            data.ShowDialog();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formData data = new formData();
            data.setFormType(formData.formTypes.DEPARTMENTS);
            data.setFormActions(formData.formActions.VIEW);
            data.ShowDialog();
        }

        private void diagnosesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formData data = new formData();
            data.setFormType(formData.formTypes.DIAGNOSE);
            data.setFormActions(formData.formActions.VIEW);
            data.ShowDialog();
        }

        private void inferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formData data = new formData();
            data.setFormType(formData.formTypes.INFERENCELKK);
            data.setFormActions(formData.formActions.VIEW);
            data.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search lkkSearch = new search();
            lkkSearch.MdiParent = this;
            lkkSearch.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode setMode = new Mode();
            setMode.ShowDialog();
            changeModeText();

        }
        private void changeModeText()
        {
            if (Program.status == 1)
            {
                workMode.Text = "Режим роботи: Робота з реєстром інвалідів";
            }
            else 
            {
                workMode.Text = "Режим роботи: Робота з протоколами ЛКК";
            }

        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formData members = new formData();
            members.setFormType(formData.formTypes.MEMBERSLKK);
            members.setFormActions(formData.formActions.VIEW);
            members.ShowDialog();
        }

        private void aboutSoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.MdiParent = this;
            about.Show();
        }
    }
}
