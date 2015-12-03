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
        private enum formActions {
            INSERT =0
            ,UPDATE
        
        }
        private formActions action;        
        Database lkkData = new Database();
        private static string mkbCode;
        private string id;
        private Database.lkkData infedenceData = new Database.lkkData();
        public static void setMkb(string code)
        {            
            mkbCode = code;
        }

        
        public lkkMain()
        {
            InitializeComponent();
            action = formActions.INSERT;
            doctor.DataSource = lkkData.getDoctors();
            doctor.DisplayMember = "fio";
            region.DataSource = lkkData.getRegions();
            region.DisplayMember = "title";            
            department.DataSource = lkkData.getDepartments();
            department.DisplayMember = "title";
            LPZ.DataSource = lkkData.getLPZ();
            LPZ.DisplayMember = "title";
            sex.SelectedIndex = 0;   
        }

        private void region_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (action == formActions.INSERT)
            getTown();
        }

        private void getTown()
        {
            if (region.Text != "")
            {
                town.DataSource = lkkData.getTown(region.Text);
                town.DisplayMember = "town";
            }
        
        }

        private bool check()
        {
            bool result = true;
            if ((lkkNumber.Text == "") || (department.Text == "") || (doctor.Text == "") || (name.Text == "") || (age.Text == "") || (region.Text == "") || (town.Text == "") ||
                (mkbCode == null) || (mkbCode == "") || (lkk.Text == ""))
            {

                string fiends = "";
                if (lkkNumber.Text == "")
                {
                    fiends += "Номер проктоколу ЛКК \n";
                }
                if (department.Text == "")
                {
                    fiends += "Відділення \n";
                }
                if (doctor.Text == "")
                {
                    fiends += "Лікар \n";
                }
                if (name.Text == "")
                {
                    fiends += "ПІБ хворого \n";
                }
                if (age.Text == "")
                {
                    fiends += "Вік хворого \n";
                }
                if (region.Text == "")
                {
                    fiends += "Район \n";
                }
                if (town.Text == "")
                {
                    fiends += "Місто \n";
                }
                if (mkbCode == null || mkbCode == "")
                {
                    fiends += "Не вибраний зі списку основний діагноз \n";
                }
                if (lkk.Text == "")
                {
                    fiends += "Рішення ЛКК \n";
                }
                 MessageBox.Show("Не заповнені обобв'язкові поля: \n \n"+fiends, "Помилка",MessageBoxButtons.OK,MessageBoxIcon.Hand);

                
                  

                result = false;
            }
            return result;
        }

        private void toDatabase_Click(object sender, EventArgs e)
        {

            if (check())
            {
                infedenceData.date = lkkDate.Value.Date;
                infedenceData.number = lkkNumber.Text;
                infedenceData.department = department.Text;
                infedenceData.doctor = doctor.Text;
                infedenceData.fio = name.Text;
                infedenceData.birth = yearBirth.Text;
                infedenceData.age = age.Text;
                infedenceData.region = region.Text;
                infedenceData.town = town.Text;
                infedenceData.address = address.Text;
                infedenceData.addressWork = work.Text;
                infedenceData.position = position.Text;
                infedenceData.mkbCode = mkbCode;
                infedenceData.diagnose = diagnose.Text;
                infedenceData.lkk = lkk.Text;
                infedenceData.msek = msek.Text;
                infedenceData.addition = additions.Text;
                infedenceData.sex = sex.Text;
                infedenceData.status = Program.status.ToString();
                infedenceData.haveInvalidity = invalidity.Checked;
                infedenceData.InvalidityDate = invalidityDate.Value.Date;
                infedenceData.LPZ = LPZ.Text;
                if (action == formActions.INSERT)
                {
                    id = lkkData.insertData(infedenceData);
                }
                else
                {
                    lkkData.updateData(infedenceData, id);
                }
                if (print.Checked)
                {
                    ReportLKK rep = new ReportLKK();
                    rep.showInfedenceLKK(id);
                }
                if (action == formActions.INSERT)
                {
                    DialogResult result;
                    result = MessageBox.Show("Додати ще один протокол?", "ЛКК", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        clearData(this, e);
                    else
                        Close();
                }
                else
                    Close();
            }
            
            
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

        private void lkkMain_Shown(object sender, EventArgs e)
        {
            region_SelectionChangeCommitted(this, e);
        }

        private void clearData(object sender, EventArgs e) 
        {
            lkkNumber.Text = null;
            department.SelectedIndex = 0;
            doctor.SelectedIndex = 0;
            name.Text = null;
            sex.SelectedIndex = 0;
            yearBirth.Text = null;
            age.Text = null;
            region.SelectedIndex = 0;
            getTown();
            address.Text = null;
            work.Text = null;
            position.Text = null;
            invalidity.Checked = false;
            LPZ.SelectedIndex = 0;
            diagnose.Text = null;
            lkk.Text = null;
            msek.Text = null;
            additions.Text = null;
        }

        public void setUpdateData(string _id)
        {
            id = _id;
            action = formActions.UPDATE;
            this.Text = "Зміна даних";
            infedenceData = lkkData.selectLKK(id);
            lkkDate.Value = Convert.ToDateTime(infedenceData.date);
            lkkNumber.Text = infedenceData.number;
            department.SelectedIndex = department.FindString(infedenceData.department);
            doctor.SelectedIndex = doctor.FindString(infedenceData.doctor);
            name.Text = infedenceData.fio;                        
            sex.SelectedIndex = sex.FindString(infedenceData.sex);             
            yearBirth.Text = infedenceData.birth;
            age.Text = infedenceData.age;
            region.SelectedIndex = region.FindString(infedenceData.region);
            getTown();
            town.SelectedIndex = town.FindString(infedenceData.town);
            address.Text = infedenceData.address;
            work.Text = infedenceData.addressWork;
            position.Text = infedenceData.position;
            invalidity.Checked = infedenceData.haveInvalidity;
            if (infedenceData.haveInvalidity)
            {
                invalidityDate.Value = Convert.ToDateTime(infedenceData.InvalidityDate);
            }
            LPZ.SelectedIndex = LPZ.FindString(infedenceData.LPZ);
            diagnose.Text = infedenceData.diagnose;
            lkk.Text = infedenceData.lkk;
            msek.Text = infedenceData.msek;
            additions.Text = infedenceData.addition;
            mkbCode = infedenceData.mkbCode;
            
        }
    }
}
