using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class invalidityRegister : Form
    {
        private enum formActions
        {
            INSERT = 0
            , UPDATE

        }
        private formActions action;
        Database Data = new Database();
        private static string mkbCode;
        private string id;
        Database.invalidityData data;
        public invalidityRegister()
        {
            InitializeComponent();
            action = formActions.INSERT;
            region.DataSource = Data.getRegions();
            region.DisplayMember = "title";
            LPZ.DataSource = Data.getLPZ();
            LPZ.DisplayMember = "title";
            sex.SelectedIndex = 0;
            invalidityGroupe.DataSource = Data.getInvalidityGroups();
            invalidityGroupe.DisplayMember = "groupe";


        }

        public static void setMkb(string code)
        {
            mkbCode = code;
        }

        private void toDatabase_Click(object sender, EventArgs e)
        {
            data.fio = fio.Text;
            data.address = address.Text;
            data.sex = sex.Text;
            data.dateBirth = birthDate.Value.Date;
            data.age = age.Text;
            data.region = region.Text;
            data.town = town.Text;
            data.address = address.Text;
            data.addressWork = work.Text;
            data.position = position.Text;
            data.LPZ = LPZ.Text;            
            data.mkbCode = mkbCode;
            data.diagnose = diagnose.Text;
            data.addition = additions.Text;
            data.invalidityGroupe = invalidityGroupe.Text;
            data.InvalidityDate = invalidityDate.Value.Date;
            if (noLimit.Checked)
            {
                data.InvalidityDate = Convert.ToDateTime("31.12.9998");
            }
            if (to18yo.Checked)
            {
                data.InvalidityDate = birthDate.Value.AddYears(18).Date;
            }            
            if (action == formActions.INSERT)
            {
                Data.insertInvalidityData(data);
                DialogResult result;
                result = MessageBox.Show("Додати ще один Запис?", "Реєстр", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    clearData();
                else
                    Close();
            }
            else
            {
                Data.updateINdalidityData(data,id);
                Close();
            }
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
                town.DataSource = Data.getTown(region.Text);
                town.DisplayMember = "town";
            }

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

        private void addTown_Click(object sender, EventArgs e)
        {
            addData townAdd = new addData();
            townAdd.setType(addData.formType.TOWNS, addData.formAction.ADD);
            townAdd.setRegionID(this.region.Text);
            townAdd.ShowDialog();
            getTown();
        }

        private void buttonAddLPZ_Click(object sender, EventArgs e)
        {
            addData lpzAdd = new addData();
            lpzAdd.setType(addData.formType.LPZ, addData.formAction.ADD);
            lpzAdd.ShowDialog();
            LPZ.DataSource = Data.getLPZ();
            LPZ.DisplayMember = "title";
        }

        private void noLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (noLimit.Checked && to18yo.Checked) 
            {
                to18yo.Checked = false;
            }
        }

        private void to18yo_CheckedChanged(object sender, EventArgs e)
        {
            if (noLimit.Checked && to18yo.Checked)
            {
                noLimit.Checked = false;
            }
        }

        private void birthDate_Leave(object sender, EventArgs e)
        {
                       
            int patientAge = DateTime.Now.Year - birthDate.Value.Year;            
            if ((DateTime.Now.Month < birthDate.Value.Month) ||(DateTime.Now.Month == birthDate.Value.Month && DateTime.Now.Day < birthDate.Value.Day)) patientAge--;
            age.Text = patientAge.ToString();
        
        }

        private void clearData() 
        {
            data.fio = null;
            data.address = null;
            data.sex = null;
            data.dateBirth = Convert.ToDateTime("01.01.1900");
            data.age = null;
            data.region = null;
            data.town = null;
            data.address = null;
            data.addressWork = null;
            data.position = null;
            data.LPZ = null;
            data.mkbCode = null;
            data.diagnose = null;
            data.addition = null;
            data.InvalidityDate = Convert.ToDateTime("01.01.1900");
            to18yo.Checked = false;
            noLimit.Checked = false;
            fio.Text = null;
            address.Text = null;
            sex.SelectedIndex = 0;
            birthDate.Value = DateTime.Now;
            age.Text = null;
            region.SelectedIndex = 0;
            getTown();
            town.SelectedIndex = 0;            
            work.Text = null;
            position.Text = null;
            LPZ.SelectedIndex = 0;            
            diagnose.Text = null;
            invalidityDate.Value = DateTime.Now;
            additions.Text = null;
            invalidityGroupe.SelectedIndex = 0;
        }
        public void setUpdateData(string _id)
        {
            id = _id;
            action = formActions.UPDATE;
            this.Text = "Зміна даних";
            data = Data.selectinvalidity(id);
            fio.Text = data.fio;
            sex.SelectedIndex = sex.FindString(data.sex);
            birthDate.Value = data.dateBirth;
            age.Text = data.age;
            region.SelectedIndex = region.FindString(data.region);
            getTown();
            town.SelectedIndex = town.FindString(data.town);
            address.Text = data.address;
            work.Text = data.addressWork;
            position.Text = data.position;
            LPZ.SelectedIndex = LPZ.FindString(data.LPZ);
            invalidityGroupe.SelectedIndex = invalidityGroupe.FindString(data.invalidityGroupe);
            diagnose.Text = data.diagnose;
            additions.Text = data.addition;
            mkbCode = data.mkbCode;
            if (data.InvalidityDate.Date == Convert.ToDateTime("31.12.9998"))
            {
                invalidityDate.Value = DateTime.Now.Date;
                noLimit.Checked = true;
                to18yo.Checked = false;
            }
            else
                if (data.InvalidityDate.Date == data.dateBirth.AddYears(18).Date)
                {
                    invalidityDate.Value = DateTime.Now.Date;
                    noLimit.Checked = false;
                    to18yo.Checked = true;
                }
                else
                {
                    invalidityDate.Value = data.InvalidityDate.Date;
                    noLimit.Checked = false;
                    to18yo.Checked = false;
                }
            
           
        }
     
    }
}
