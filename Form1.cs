using System;
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
            lkkMain insertData = new lkkMain();
            insertData.MdiParent = this;
            insertData.Show();

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
    }
}
