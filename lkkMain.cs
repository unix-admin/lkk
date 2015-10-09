using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class lkkMain : Form
    {
        Database lkkData = new Database();
        
        public lkkMain()
        {
            InitializeComponent();
            DataSet data = lkkData.getData();
            doctor.DataSource = data.Tables["doctors"];
            doctor.DisplayMember = "fio";
            region.DataSource = data.Tables["regions"];
            region.DisplayMember = "title";
            department.DataSource = data.Tables["departments"];
            department.DisplayMember = "title";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void region_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void region_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (region.Text != "")
            {
                town.DataSource = lkkData.getTown(region.Text);
                town.DisplayMember = "town";
            }
        }

        private void toDatabase_Click(object sender, EventArgs e)
        {

            string[] words = town.Text.Split('.');
            string a = words[0];
            string b = words[words.Length - 1]; 
        }

        private void addDoctor_Click(object sender, EventArgs e)
        {
            
            
        }

        private void addDiagnose_Click(object sender, EventArgs e)
        {
            formData diagnosis = new formData();
            diagnosis.setFormType(formData.formTypes.DIAGNOSE);
            
            diagnosis.ShowDialog();

            
        }

        private void addRegion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
