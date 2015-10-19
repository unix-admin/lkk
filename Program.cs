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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            status = "1";
            
        }
        public static string status;
   
    }

}
