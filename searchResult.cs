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
        public invaliditySearchData invalidityData;
        Database lkk = new Database();
        DataTable result = new DataTable();
        public void start(lkkSearchData dataToSearch)
        {
            searchData = dataToSearch;                        
        }

        public void start(invaliditySearchData dataToSearch)
        {
            invalidityData = dataToSearch;
        }

        private void searchResult_Shown(object sender, EventArgs e)
        {
            int mansCount;
            int womansCount;
            int invalidCount = 0;
            int count = 0;
            double percent;
            if (Program.status == 0)
            {                                            
                result = lkk.search(searchData);
                resultsLKK.DataSource = result;
                resultsLKK.Columns[0].HeaderText = "№ з/п";
                resultsLKK.Columns[0].Width = 5;
                resultsLKK.Columns[1].HeaderText = "Дата";
                resultsLKK.Columns[1].Width = 5;
                resultsLKK.Columns[2].HeaderText = "Протокол №";
                resultsLKK.Columns[2].Width = 7;
                resultsLKK.Columns[3].Visible = false;
                resultsLKK.Columns[4].Visible = false;
                resultsLKK.Columns[5].Visible = false;
                resultsLKK.Columns[6].HeaderText = "ПІБ";
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
                resultsLKK.Columns[24].Visible = false;
                resultsLKK.Columns[25].Visible = false;
                result.DefaultView.RowFilter = "haveInvalidity=1";
                invalidCount = result.DefaultView.Count;
                result.DefaultView.RowFilter = null;
                percent = Convert.ToDouble(invalidCount) / Convert.ToDouble(count);
                invalidity.Text = "Інвалідів:" + Math.Round(percent * 100, 2).ToString() + "%";
            }
            else
            {
                printAll.Visible = false;
                printLKK.Visible = false;
                printReport.Visible = false;
                result = lkk.selectInvalidity(invalidityData);
                resultsLKK.DataSource = result;
                resultsLKK.Columns[0].Visible = false;
                resultsLKK.Columns[1].HeaderText = "ПІБ";
                resultsLKK.Columns[1].Width = 80;
                resultsLKK.Columns[2].HeaderText = "Дата народження";
                resultsLKK.Columns[2].Width = 15;
                resultsLKK.Columns[3].HeaderText = "Вік";
                resultsLKK.Columns[3].Width = 15;                
                resultsLKK.Columns[4].Visible = false;
                resultsLKK.Columns[5].Visible = false;
                resultsLKK.Columns[6].Visible = false;
                resultsLKK.Columns[7].Visible = false;
                resultsLKK.Columns[8].HeaderText = "Група інвалідності";
                resultsLKK.Columns[8].Width = 25;
                resultsLKK.Columns[9].Visible = false;
                resultsLKK.Columns[10].Visible = false;
                invalidity.Text = "";
            }
            if (resultsLKK.Rows.Count > 0)
            {
                resultsLKK.Rows[0].Selected = true;

                count = result.Rows.Count;
                result.DefaultView.RowFilter = "sex='Ч'";
                mansCount = result.DefaultView.Count;
                result.DefaultView.RowFilter = "sex='Ж'";
                womansCount = result.DefaultView.Count;
                
                result.DefaultView.RowFilter = null;
                allRows.Text = "Всього записів: " + count.ToString();
                if (count > 0)
                {
                    percent = Convert.ToDouble(mansCount) / Convert.ToDouble(count);
                    mans.Text = "Чоловіків: " + Math.Round(percent * 100, 2).ToString() + "% (" + mansCount.ToString() + ")";
                    percent = Convert.ToDouble(womansCount) / Convert.ToDouble(count);
                    womans.Text = "Жінок: " + Math.Round(percent * 100, 2).ToString() + "% (" + womansCount.ToString() + ")";
                    
                    
                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            ReportLKK report = new ReportLKK();
            if (Program.status == 0)
            {
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
            else
            {
                report.showReportLKK("", result);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (Program.status == 0)
            {
                lkkMain lkkForm = new lkkMain();
                lkkForm.setUpdateData(resultsLKK.CurrentRow.Cells[0].Value.ToString());
                lkkForm.ShowDialog();
            }
            else
            {
                invalidityRegister regForm = new invalidityRegister();
                regForm.setUpdateData(resultsLKK.CurrentRow.Cells[0].Value.ToString());
                regForm.ShowDialog();

            }
            result.Clear();
            resultsLKK.DataSource = null;
            resultsLKK.Refresh();
            searchResult_Shown(this, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult question;
            question = MessageBox.Show("Ви бажаєте видалити запис?", "ЛКК", MessageBoxButtons.YesNo);
            if (question == System.Windows.Forms.DialogResult.Yes)
            {
                if (Program.status == 0)
                    lkk.setDeleted(Database.typesData.lkk, resultsLKK.CurrentRow.Cells[0].Value.ToString());
                else
                    lkk.setDeleted(Database.typesData.invalidityRedister, resultsLKK.CurrentRow.Cells[0].Value.ToString());
                result.Clear();
                resultsLKK.DataSource = null;
                resultsLKK.Refresh();
                searchResult_Shown(this, e);
            }
        }

    }
}
