using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class search : Form
    {
        public lkkSearchData searchData;
        private Database lkkDatabase = new Database();
        public search()
        {
            InitializeComponent();
            initSearchData();
            regionBox.DataSource = lkkDatabase.getRegions();
            regionBox.DisplayMember = "title";
            diagnoseBox.DataSource = lkkDatabase.getDiagnose(true);
            diagnoseBox.DisplayMember = "diagnose";
            lpzBox.DataSource = lkkDatabase.getLPZ();
            lpzBox.DisplayMember = "title";
        }
        private void initSearchData()
        {
            searchData.dateBegin = Convert.ToDateTime("01.01.1900");
            searchData.dateEnd = Convert.ToDateTime("01.01.1900");
            searchData.ageStart = null;
            searchData.ageEnd = null;
            searchData.fio = null;
            searchData.region = null;
            searchData.diagnose = null;
            searchData.lpz = null;
            searchData.excludeTill18 = false;
            searchData.orphanDiseases = false;
        }

        private void startSearch_Click(object sender, EventArgs e)
        {
            if (lkkDateBox.Checked)
            {
                searchData.dateBegin = startLKKdate.Value.Date;
                searchData.dateEnd = endLKKDate.Value.Date;
            }
            if (Surname.Checked)
            {
                searchData.fio = surnameText.Text;        
            }
            if (age.Checked)
            {
                searchData.ageStart = ageStart.Value.ToString();
                searchData.ageEnd = ageEnd.Value.ToString();
            }
            if (region.Checked)
            {
                searchData.region = regionBox.Text;
            }
            if (diagnose.Checked)
            {
                searchData.diagnose = diagnoseBox.Text;
            }
            if (checkLPZ.Checked)
            {
                searchData.lpz = lpzBox.Text;
            }
            if (excludeTill18.Checked)
            {
               searchData.excludeTill18 = true;
            }
            if (orphanDiseases.Checked)
            {
                searchData.orphanDiseases = true;
            }
            searchResult result = new searchResult();
            result.start(searchData);
            result.MdiParent = this.MdiParent;
            result.Show();
            initSearchData();
        }

        private void Surname_CheckedChanged(object sender, EventArgs e)
        {
            if (Surname.Checked)            
                surnameText.Enabled = true;            
            else
                surnameText.Enabled = false;
        }

        private void age_CheckedChanged(object sender, EventArgs e)
        {
            if (age.Checked)
            {
                ageStart.Enabled = true;
                ageEnd.Enabled = true;
            }
            else
            {
                ageStart.Enabled = false;
                ageEnd.Enabled = false;
            }
        }

        private void region_CheckedChanged(object sender, EventArgs e)
        {
            if (region.Checked)
                regionBox.Enabled = true;
            else
                regionBox.Enabled = false;
        }

        private void diagnose_CheckedChanged(object sender, EventArgs e)
        {
            if (diagnose.Checked)
                diagnoseBox.Enabled = true;
            else
                diagnoseBox.Enabled = false;
        }

        private void checkLPZ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLPZ.Checked)
                lpzBox.Enabled = true;
            else
                lpzBox.Enabled = false;
        }

        private void endLKKDate_ValueChanged(object sender, EventArgs e)
        {
            if (endLKKDate.Value < startLKKdate.Value)
            {
                endLKKDate.Value = startLKKdate.Value;
            }
        }

        private void startLKKdate_ValueChanged(object sender, EventArgs e)
        {
            if (startLKKdate.Value > endLKKDate.Value)
            {
                startLKKdate.Value = endLKKDate.Value;
            }
        }

        private void ageStart_ValueChanged(object sender, EventArgs e)
        {
            if (ageStart.Value > ageEnd.Value)
            {
                ageStart.Value = ageEnd.Value;
            }

        }

        private void ageEnd_ValueChanged(object sender, EventArgs e)
        {
            if(ageEnd.Value < ageStart.Value)
            {
                ageEnd.Value = ageStart.Value;
            }
        }

        private void lkkDateBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lkkDateBox.Checked)
            {
                startLKKdate.Enabled = true;
                endLKKDate.Enabled = true;
            }
            else
            {
                startLKKdate.Enabled = false;
                endLKKDate.Enabled = false;
            }
        }                        

       
    }
}
