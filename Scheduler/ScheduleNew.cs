using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Scheduler.Forms
{
    public partial class ScheduleNew : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = schedulerDB.accdb");
        //Ustvarjanje dataseta / making of a data set
        DataSet ds1 = new DataSet();
        //Adapter / Posrednik med datasetom in povezavo
        //OleDbDataAdapter da;

        public ScheduleNew()
        {
            InitializeComponent();
            
        }

        private void InsertSchedule_Click(object sender, EventArgs e)
        {
            string schedule_title = ScheduleTitleTextBox.Text;
            string user_id = Program.GetUserID();
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO schedules ([title], [user_id]) VALUES (@schedule_title, @user_id);";
            cmd.Parameters.AddWithValue("@schedule_title", schedule_title);
            cmd.Parameters.AddWithValue("@user_id", Convert.ToInt32(user_id));
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            InsertScheduleComboBox.Visible = false;
            InsertLessonComboBox.Visible = true;

        }
    }
}
