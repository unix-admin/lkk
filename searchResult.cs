using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class searchResult : Form
    {
        public searchResult()
        {
            InitializeComponent();
        }
        public lkkSearchData searchData;
        DataTable result = new DataTable();
        public void start(lkkSearchData dataToSearch)
        {
            searchData = dataToSearch;                        
        }

        private void searchResult_Shown(object sender, EventArgs e)
        {
            Database lkk = new Database();
            
            int mansCount;
            int womansCount;
            int invalidCount = 0;
            int count;
            double percent;
            result = lkk.search(searchData);
            count = result.Rows.Count;
            result.DefaultView.RowFilter = "sex='Ч'";
            mansCount = result.DefaultView.Count;
            result.DefaultView.RowFilter = "sex='Ж'";
            womansCount = result.DefaultView.Count;
            result.DefaultView.RowFilter = "haveInvalidity=1";
            invalidCount = result.DefaultView.Count;
            result.DefaultView.RowFilter = null;
            allRows.Text += count.ToString();
            if (count > 0)
            {
                percent = Convert.ToDouble(mansCount) / Convert.ToDouble(count);
                mans.Text += Math.Round(percent * 100, 2).ToString() + "% (" + mansCount.ToString()+")";
                percent = Convert.ToDouble(womansCount) / Convert.ToDouble(count);
                womans.Text += Math.Round(percent * 100, 2).ToString() + "% (" + womansCount.ToString() + ")";
                percent = Convert.ToDouble(invalidCount) / Convert.ToDouble(count);
                invalidity.Text += Math.Round(percent * 100, 2).ToString() + "%";
            }

            resultsLKK.DataSource = result;
            resultsLKK.Columns[0].HeaderText = "№ з/п";
            resultsLKK.Columns[0].Width = 5;
            resultsLKK.Columns[1].HeaderText = "Дата";
            resultsLKK.Columns[1].Width = 5;
            resultsLKK.Columns[2].HeaderText = "Протокол №";
            resultsLKK.Columns[2].Width = 7;
            resultsLKK.Columns[3].Visible = false;
            resultsLKK.Columns[4].Visible = false;
            resultsLKK.Columns[5].HeaderText = "ПІБ";

            resultsLKK.Columns[6].Visible = false;
            resultsLKK.Columns[7].Visible = false;
            resultsLKK.Columns[8].Visible = false;
            resultsLKK.Columns[9].Visible = false;
            resultsLKK.Columns[10].Visible = false;
            resultsLKK.Columns[11].Visible = false;
            resultsLKK.Columns[12].Visible = false;
            resultsLKK.Columns[13].Visible = false;
            resultsLKK.Columns[14].Visible = false;
            resultsLKK.Columns[15].Visible = false;
            resultsLKK.Columns[16].Visible = false;
            resultsLKK.Columns[17].Visible = false;
            resultsLKK.Columns[18].Visible = false;
            resultsLKK.Columns[19].Visible = false;
            resultsLKK.Columns[20].Visible = false;
            resultsLKK.Columns[21].Visible = false;
            resultsLKK.Columns[22].Visible = false;
            resultsLKK.Columns[23].Visible = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            ReportLKK report = new ReportLKK();
            if (printLKK.Checked)
            {
                report.showInfedenceLKK(resultsLKK.CurrentRow.Cells[0].Value.ToString());
            }
            if (printAll.Checked)
            {
                report.showReportLKK("", result);                
            }
            if (printReport.Checked)
            {
                report.showReportLKK(resultsLKK.CurrentRow.Cells[0].Value.ToString(), result);
            }
        }

    }
}
