using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class formData : Form
    {
        private Database lkk = new Database();
        private RichTextBox textArea;
        public enum formTypes
        {
            DOCTORS = 0
           ,REGIONS
           ,DEPARTMENTS
           ,DIAGNOSE
           ,INFERENCELKK
           ,MEMBERSLKK
           ,TOWNS
        };
        public enum formActions
        {
             VIEW = 0
            ,WORK
        }
        private formTypes formType;
        private formActions actions;
        private string stadiaText;
        private string formaText;

        public formData()
        {
            formaText = "";
            stadiaText = "";
            InitializeComponent();
        }

        public void setFormType(formTypes type) 
        {
            formType = type;
        }

        public void setFormActions(formActions action)
        {
            actions = action;
        }

        public void getTextArea(ref RichTextBox text)
        {
            textArea = text;
        }

        private void formData_Shown(object sender, EventArgs e)
        {
            
            switch (formType)
            {
                case formTypes.INFERENCELKK:
                    formType = formTypes.INFERENCELKK;
                    gridInit();
                    this.Size = new Size(728, 372);
                    break;
                case formTypes.DOCTORS:
                    formType = formTypes.DOCTORS;
                    gridInit();          
                    break;
                case formTypes.DEPARTMENTS:
                    formType = formTypes.DEPARTMENTS;
                    gridInit();
                    break;
                case formTypes.REGIONS:
                    formType = formTypes.REGIONS;
                    gridInit();
                    break;
               case formTypes.DIAGNOSE:
                    formType = formTypes.DIAGNOSE;
                    gridInit();
                    break;
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            addData dataAdd = new addData();
            switch (formType)
            {
                case formTypes.DEPARTMENTS:                    
                    dataAdd.setType(addData.formType.DEPARTMENTS, addData.formAction.ADD);
                    dataAdd.ShowDialog();
                    gridInit();
                    break;
                case formTypes.DIAGNOSE:
                    dataAdd.setType(addData.formType.DIAGNOSE, addData.formAction.ADD);
                    dataAdd.ShowDialog();
                    gridInit();
                    break;
                case formTypes.DOCTORS:
                    dataAdd.setType(addData.formType.DOCTORS, addData.formAction.ADD);
                    dataAdd.ShowDialog();
                    gridInit();     
                    break;
                case formTypes.INFERENCELKK:
                    dataAdd.setType(addData.formType.INFERENCELKK, addData.formAction.ADD);
                    dataAdd.ShowDialog();
                    gridInit();
                    break;
                case formTypes.REGIONS:
                    dataAdd.setType(addData.formType.REGIONS, addData.formAction.ADD);
                    dataAdd.ShowDialog();
                    gridInit();
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (actions == formActions.WORK)
            {
                if (mainDs.Visible == true && mainDs.Checked == true)
                {
                    formData subDiagnose = new formData();
                    subDiagnose.ShowDialog();
                    mainDs.Checked = false;

                }
                else
                {
                    textArea.Text += dataGridView1.CurrentCell.Value.ToString() +formaText+stadiaText+". ";
                    formaText = "";
                    stadiaText = "";
                    Light.Checked = false;
                    medium.Checked = false;
                    hard.Checked = false;
                    decomp.Checked = false;
                    subcompens.Checked = false;
                    medicsubcomp.Checked = false;
                    //textArea.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
            }
           
        }

        private void formData_Load(object sender, EventArgs e)
        {
            if ((formType == formTypes.DIAGNOSE && actions == formActions.VIEW) || (formType != formTypes.DIAGNOSE))
            {
                formDisease.Visible = false;
                stadia.Visible = false;
                this.Size = new Size(728, 372);
                this.MaximumSize = new System.Drawing.Size(728, 372);
                insertButton.Location = new Point(220, 265);
                modifyButton.Location = new Point(400, 265);
                deleteButton.Location = new Point(580, 265);
            }
            else
            {
                formDisease.Visible = true;
                stadia.Visible = true;
                mainDs.Visible = true;

            }
        }

        private void Light_Click(object sender, EventArgs e)
        {
            formaText = " легка форма";
        }

        private void medium_Click(object sender, EventArgs e)
        {
            formaText = " середньої важкості";
        }

        private void hard_Click(object sender, EventArgs e)
        {
            formaText = " важка форма";
        }

        private void decomp_Click(object sender, EventArgs e)
        {
            stadiaText = " в стадії декомпенсації";
        }

        private void subcompens_Click(object sender, EventArgs e)
        {
            stadiaText = " в стадії субкомпенсації";
        }

        private void medicsubcomp_Click(object sender, EventArgs e)
        {
            stadiaText = " в стадії медикаментозної субкомпенсації";
        }
        private void gridInit()
        {
            switch (formType)
            {
                case formTypes.INFERENCELKK:                    
                    dataGridView1.DataSource = lkk.getLKK();
                    dataGridView1.Columns[0].HeaderText = "Висновок ЛКК";                  
                    break;
                case formTypes.DOCTORS:                   
                    dataGridView1.DataSource = lkk.getDoctors();
                    dataGridView1.Columns[0].HeaderText = "ФИО";
                    break;
                case formTypes.DEPARTMENTS:                    
                    dataGridView1.DataSource = lkk.getDepartments();
                    dataGridView1.Columns[0].HeaderText = "Назва";
                    break;
                case formTypes.REGIONS:
                   
                    dataGridView1.DataSource = lkk.getRegions();
                    dataGridView1.Columns[0].HeaderText = "Назва";
                    break;
                case formTypes.DIAGNOSE:                 
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Диагноз";
                    break;
            }
            dataGridView1.Sort(dataGridView1.Columns[dataGridView1.ColumnCount - 1], ListSortDirection.Ascending); 
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            addData modifyData = new addData();
            switch (formType)
            {
                case formTypes.DEPARTMENTS:
                    modifyData.setType(addData.formType.DEPARTMENTS, addData.formAction.MODIFY);
                    modifyData.setDataToUpdate(dataGridView1.CurrentCell.Value.ToString(), "");
                    modifyData.ShowDialog();
                    gridInit();
                    break;
                case formTypes.DIAGNOSE:
                    modifyData.setType(addData.formType.DIAGNOSE, addData.formAction.MODIFY);
                    modifyData.setDataToUpdate(dataGridView1.CurrentCell.Value.ToString(), "");
                    modifyData.ShowDialog();                   
                    gridInit();
                    break;
                case formTypes.DOCTORS:
                    modifyData.setType(addData.formType.DOCTORS, addData.formAction.MODIFY);
                    modifyData.setDataToUpdate(dataGridView1.CurrentCell.Value.ToString(), "");
                    modifyData.ShowDialog();
                    gridInit();
                    break;
                case formTypes.INFERENCELKK:
                    modifyData.setType(addData.formType.INFERENCELKK, addData.formAction.MODIFY);
                    modifyData.setDataToUpdate(dataGridView1.CurrentCell.Value.ToString(), "");
                    modifyData.ShowDialog();
                    gridInit();
                    break;
                case formTypes.REGIONS:
                    modifyData.setType(addData.formType.REGIONS, addData.formAction.MODIFY);
                    modifyData.setDataToUpdate(dataGridView1.CurrentCell.Value.ToString(), "");
                    modifyData.ShowDialog();
                    gridInit();
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteQuestion = MessageBox.Show("Ви дійсно бажаєте видалити запис: "+dataGridView1.CurrentCell.Value.ToString(), "Видалення запису", MessageBoxButtons.YesNo);
            if (deleteQuestion == DialogResult.Yes)
            {
                switch (formType)
                {
                    case formTypes.INFERENCELKK:
                        lkk.deleteData(Database.typesData.lkk, "");
                        this.Size = new Size(728, 372);
                        break;
                    case formTypes.DOCTORS:
                        lkk.deleteData(Database.typesData.doctor, "1000");
                        break;
                    case formTypes.DEPARTMENTS:
                        formType = formTypes.DEPARTMENTS;
                        gridInit();
                        break;
                    case formTypes.REGIONS:
                        formType = formTypes.REGIONS;
                        gridInit();
                        break;
                    case formTypes.DIAGNOSE:
                        formType = formTypes.DIAGNOSE;
                        gridInit();
                        break;
                }
            }
        }
    }
}
