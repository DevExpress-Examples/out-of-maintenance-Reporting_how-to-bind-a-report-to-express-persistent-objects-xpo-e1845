using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;

namespace XpoXtraReports
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitDAL();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void InitDAL()
        {
            string cstr = AccessConnectionProvider.GetConnectionString("database.mdb");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(cstr, AutoCreateOption.DatabaseAndSchema);
            DevExpress.Xpo.XpoDefault.Session = null;
        }

    }
}
