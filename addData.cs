using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class addData : Form
    {
        private Database lkk = new Database();

        public enum formType
        {
            DOCTORS = 0
           ,REGIONS
           ,TOWNS
           ,DEPARTMENTS
           ,DIAGNOSE
           ,INFERENCELKK
           ,INFERENCEMSEK
        };
        public addData()
        {
            InitializeComponent();
        }
    }
}
