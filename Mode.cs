using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
           
        }

        private void Mode_Shown(object sender, EventArgs e)
        {
            if (Program.status == 0)
            {
                modeLkk.Checked = true;
                modeInsulin.Checked = false;
            }
            else
            {
                modeLkk.Checked = false;
                modeInsulin.Checked = true;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (modeLkk.Checked)
            {
                Program.status = 0;
            }
            else
            {
                Program.status = 1;
            }
            Close();
        }
    }
}
