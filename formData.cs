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
           ,INFERENCEMSEK
        };
        public enum formActions
        {
             ADD = 0
            ,WORK
        }
        private formTypes formType;
        private formActions actions;

        public formData()
        {
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
                    break;
                case formTypes.DOCTORS:
                    formType = formTypes.DOCTORS;
                    dataGridView1.DataSource = lkk.getDoctors();
                    dataGridView1.Columns[0].HeaderText = "ФИО";
                    break;
                case formTypes.DEPARTMENTS:
                    formType = formTypes.DEPARTMENTS;
                    break;
               case formTypes.DIAGNOSE:
                    formType = formTypes.DIAGNOSE;
                    dataGridView1.DataSource = lkk.getDiagnose();
                    mainDs.Visible = true;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Диагноз";
                    break;
            }            
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            
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
                    textArea.Text += dataGridView1.CurrentCell.Value.ToString() + ". ";
                    //textArea.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
            }
        }
    }
}
