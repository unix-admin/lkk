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
        private static string mkbCode;

        public static void setMkb(string code)
        {
            mkbCode = code;
        }

        
        public lkkMain()
        {
            InitializeComponent();
            doctor.DataSource = lkkData.getDoctors();
            doctor.DisplayMember = "fio";
            region.DataSource = lkkData.getRegions();
            region.DisplayMember = "title";
            department.DataSource = lkkData.getDepartments();
            department.DisplayMember = "title";
            LPZ.DataSource = lkkData.getLPZ();
            LPZ.DisplayMember = "title";
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
            lkkDataToInsert.date = lkkDate.Value.ToString("yyyy-MM-dd");
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
            lkkDataToInsert.mkbCode = mkbCode;
            lkkDataToInsert.diagnose = diagnose.Text;
            lkkDataToInsert.lkk = lkk.Text;
            lkkDataToInsert.msek = msek.Text;
            lkkDataToInsert.addition = additions.Text;
            lkkDataToInsert.sex = sex.Text;
            lkkDataToInsert.status = Program.status.ToString();
            lkkDataToInsert.haveInvalidity = invalidity.Checked;
            lkkDataToInsert.InvalidityDate = invalidityDate.Value.ToShortDateString();
            lkkDataToInsert.InvalidityLPZ = LPZ.Text;
            string id = lkkData.insertData(lkkDataToInsert);
            ReportLKK rep = new ReportLKK();
            rep.showInfedenceLKK(id);            
        }

        private void addDoctor_Click(object sender, EventArgs e)
        {
            addData doctorAdd = new addData();
            doctorAdd.setType(addData.formType.DOCTORS, addData.formAction.ADD);
            doctorAdd.ShowDialog();
            doctor.DataSource = lkkData.getDoctors();
            doctor.DisplayMember = "fio";
 
         
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

        private void invalidity_CheckedChanged(object sender, EventArgs e)
        {
            if (invalidity.Checked)
            {
                invalidityDate.Enabled = true;
                
                
            }
            else 
            {
                invalidityDate.Enabled = false;
                
                
            }
        }

        private void yearBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void yearBirth_TextChanged(object sender, EventArgs e)
        {
            if (yearBirth.Text != "")
            age.Text = (DateTime.Now.Year - Int16.Parse(yearBirth.Text)).ToString();
        }

        private void buttonAddLPZ_Click(object sender, EventArgs e)
        {
            addData lpzAdd = new addData();
            lpzAdd.setType(addData.formType.LPZ, addData.formAction.ADD);
            lpzAdd.ShowDialog();
            doctor.DataSource = lkkData.getLPZ();
            doctor.DisplayMember = "title";
        }
    }
}
