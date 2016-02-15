using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FastReport;

using FastReport.Data;

namespace LKK
{
    class ReportLKK
    {
        public void showInfedenceLKK(string id)
        {
            Database dataToReport = new Database();
            DataSet rep = new DataSet();
            rep = dataToReport.getInfedenceLKK (id);
            Report infedence = new Report();
            infedence.Load("infedence.frx");
            infedence.RegisterData(rep);
            infedence.Show();
        }
        public void showReportLKK(string id, DataTable results)
        {            
            Report reportLKK = new Report();
            if (Program.status == 0)
            {
                reportLKK.Load("report.frx");
            }
            else 
            {
                reportLKK.Load("register.frx");
            }
            reportLKK.RegisterData(results, "resultData");
            if (id != "")                            
            {
                DataBand dataBand = reportLKK.FindObject("reportData") as DataBand;
                dataBand.Filter = "[resultData.id]==" + id;
                
            }            
            reportLKK.Show();                        
        }   

    }
    
}
