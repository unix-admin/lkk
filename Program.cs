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
        public string dateBegin;
        public string dateEnd;
        public string fio;
        public string ageStart;
        public string ageEnd;
        public string region;
        public string diagnose;
        public string lpz;
        public bool orphanDiseases;
    };


}
