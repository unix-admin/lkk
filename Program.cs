using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;


namespace LKK
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        

        static void Main()
        {
            status = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
        public static int status;
   
    }

    public struct lkkSearchData
    {
        public DateTime dateBegin;
        public DateTime dateEnd;
        public string fio;
        public string ageStart;
        public string ageEnd;
        public string region;
        public string diagnose;
        public string lpz;
        public bool excludeTill18;
        public bool orphanDiseases;
    };

    public struct invaliditySearchData
    {
        public bool working;        
        public string fio;
        public string ageStart;
        public string ageEnd;
        public string region;
        public string diagnose;
        public string lpz;
        public bool excludeTill18;
        public bool orphanDiseases;
    };


}
