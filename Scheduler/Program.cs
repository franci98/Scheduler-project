using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Scheduler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static string GetUserID()
        {
            try
            {
                FileStream fs = new FileStream("user_data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string user_id = sr.ReadLine();
                sr.Close();

                return user_id;
            }
            catch (Exception)
            {
                return "err";
            }
        }

        public static string GetConStr()
        {
            string connection_string = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:/3.TRA/Franc Klavž/PRO/Scheduler/Scheduler/schedulerDB.accdb";
            return connection_string;
        }

        


    }
}
