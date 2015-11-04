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
            diagnoseBox.DataSource = lkkDatabase.getDiagnose();
            diagnoseBox.DisplayMember = "diagnose";
            lpzBox.DataSource = lkkDatabase.getLPZ();
            lpzBox.DisplayMember = "title";
        }
        private void initSearchData()
        {
            searchData.dateBegin = null;
            searchData.dateEnd = null;
            searchData.ageStart = null;
            searchData.ageEnd = null;
            searchData.fio = null;
            searchData.region = null;
            searchData.diagnose = null;
            searchData.lpz = null;           
            searchData.orphanDiseases = false;
        }

        private void startSearch_Click(object sender, EventArgs e)
        {

            searchData.dateBegin = startLKKdate.Value.ToString("yyyy-MM-dd");
            searchData.dateEnd = endLKKDate.Value.ToString("yyyy-MM-dd");

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
            if (manWoman.Checked)
            {
               // searchData.percentManWoman = true;
            }
            if (orphanDiseases.Checked)
            {
                searchData.orphanDiseases = true;
            }
            searchResult result = new searchResult();
            result.start(searchData);
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

       
    }
}
