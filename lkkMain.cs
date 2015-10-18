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
            Database.lkkData lkkDataToInsert;
            lkkDataToInsert.date = lkkDate.Value.ToShortDateString();
            lkkDataToInsert.number = lkkNumber.Text;
            lkkDataToInsert.department = department.Text;
            lkkDataToInsert.doctor = doctor.Text;
            lkkDataToInsert.fio = name.Text;
            lkkDataToInsert.birth = yearBirth.Text;
            lkkDataToInsert.age = age.Text;
            lkkDataToInsert.region = region.Text;
            lkkDataToInsert.town = town.Text;
            lkkDataToInsert.address = address.Text;
            lkkDataToInsert.addressWork = work.Text;
            lkkDataToInsert.position = position.Text;
            //lkkDataToInsert.mkbCode;
            lkkDataToInsert.diagnose = diagnose.Text;
            lkkDataToInsert.lkk = lkk.Text;
            lkkDataToInsert.msek = msek.Text;
            lkkDataToInsert.addition = additions.Text;
            lkkDataToInsert.sex = sex.Text;
            lkkDataToInsert.status = "1";
            lkkData.insertData(lkkDataToInsert);
            string[] words = town.Text.Split('.');
            string a = words[0];
            string b = words[words.Length - 1]; 
        }

        private void addDoctor_Click(object sender, EventArgs e)
        {
            addData doctorAdd = new addData();
            doctorAdd.setType(addData.formType.DOCTORS, addData.formAction.ADD);
            doctorAdd.ShowDialog();   
         
        }

        private void addDiagnose_Click(object sender, EventArgs e)
        {
            formData diagnosis = new formData();
            diagnosis.setFormType(formData.formTypes.DIAGNOSE);
            diagnosis.setFormActions(formData.formActions.WORK);
            diagnosis.getTextArea(ref diagnose);
            diagnosis.ShowDialog();            
        }

        private void addRegion_Click(object sender, EventArgs e)
        {
            addData regionAdd = new addData();
            regionAdd.setType(addData.formType.REGIONS, addData.formAction.ADD);
            regionAdd.ShowDialog();
        }

        private void addLkk_Click(object sender, EventArgs e)
        {
            formData LKK = new formData();
            LKK.setFormType(formData.formTypes.INFERENCELKK);
            LKK.setFormActions(formData.formActions.WORK);
            LKK.getTextArea(ref lkk);
            LKK.ShowDialog();


        }

        private void addTown_Click(object sender, EventArgs e)
        {
            addData townAdd = new addData();
            townAdd.setType(addData.formType.TOWNS, addData.formAction.ADD);
            townAdd.ShowDialog();

        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            addData departmentAdd = new addData();
            departmentAdd.setType(addData.formType.DEPARTMENTS, addData.formAction.ADD);
            departmentAdd.ShowDialog();
        }
    }
}
