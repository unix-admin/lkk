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
        
        public enum formTypes
        {
             DOCTORS=0
            ,REGIONS
            ,DEPARTMENTS
            ,INFERENCE
        };

        private formTypes formType;

        public formData()
        {
            InitializeComponent();
        }

        public formData(formTypes type)
        {
            
 
            InitializeComponent();
            switch (type)
            {
                case formTypes.REGIONS:
                    formType = formTypes.REGIONS;
                    break;

                case formTypes.DOCTORS:
                    formType = formTypes.DOCTORS;
                    dataGridView1.DataSource = lkk.getDoctors();
                    dataGridView1.Columns[0].HeaderText = "ФИО";
//                    DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
//                    CheckBox chk = new CheckBox();
//                    CheckboxColumn.Width = 10;
//                    dataGridView1.Columns.Add(CheckboxColumn);
//                    dataGridView1.Columns[0].HeaderText = "ФИО";
//                    dataGridView1.Columns[1].HeaderText = "ФИО1";
                    break;
                case formTypes.DEPARTMENTS:
                    formType = formTypes.DEPARTMENTS;
                    break;
            }
        }
    }
}
