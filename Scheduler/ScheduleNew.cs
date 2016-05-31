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
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Franci/Documents/GitHub/Scheduler/Scheduler/schedulerDB.accdb");
        //Ustvarjanje dataseta / making of a data set
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        //Adapter / Posrednik med datasetom in povezavo
        OleDbDataAdapter da;

        public ScheduleNew()
        {
            InitializeComponent();
        }

        private void InsertSchedule_Click(object sender, EventArgs e)
        {
            
            string schedule_title = ScheduleTitleTextBox.Text;
            string user_id = Program.GetUserID();
            int user_id_num = Convert.ToInt32(user_id);

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO schedules (title, user_id) VALUES(@title, @user_id);";
            cmd.Parameters.AddWithValue("@title", schedule_title);
            cmd.Parameters.AddWithValue("@user_id", user_id_num);
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();

            writeSchedule();

            
            InsertScheduleComboBox.Visible = false;
            InsertLessonComboBox.Visible = true;

        }
        

        private void InsertLessonComboBox_VisibleChanged(object sender, EventArgs e)
        {
            loadDays();
            loadHours();
            loadSubjects();
        }

        private void loadDays()
        {
            con.Open();
            string sql = "SELECT * FROM days;";
            da = new OleDbDataAdapter(sql, con);
            da.Fill(dt1);
            con.Close();

            DayComboBox.DataSource = dt1;
            DayComboBox.DisplayMember = "title";
            DayComboBox.ValueMember = "ID";
            
        }

        private void loadHours()
        {
            con.Open();
            string sql = "SELECT * FROM hours;";
            da = new OleDbDataAdapter(sql, con);
            da.Fill(dt2);
            con.Close();

            HourComboBox.DataSource = dt2;
            HourComboBox.DisplayMember = "title";
            HourComboBox.ValueMember = "ID";
        }

        private void loadSubjects()
        {
            con.Open();
            string sql = "SELECT * FROM subjects;";
            da = new OleDbDataAdapter(sql, con);
            da.Fill(dt3);
            con.Close();

            SubjectComboBox.DataSource = dt3;
            SubjectComboBox.DisplayMember = "title";
            SubjectComboBox.ValueMember = "ID";
        }

        private void LessonAddButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = DayComboBox.SelectedIndex;
            int day_id = (int)DayComboBox.SelectedValue;
            //MessageBox.Show("Izbrali ste dan: " + Convert.ToString(day_id));
            
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO lessons " +
                                "(schedule_id, subject_id, comment, rating, day_id, hour_id)"+
                                "VALUES(@schedule_id, @subject_id, @comment, @rating, @day_id, @hour_id)";
            //cmd.Parameters.AddWithValue();
            //cmd.Parameters.AddWithValue();
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void writeSchedule()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT @@IDENTITY";
            cmd.Connection = con;
            
            int ID = (int)cmd.ExecuteScalar();
            con.Close();
            FileStream fs = new FileStream("current_schedule.txt", FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(Convert.ToString(ID));
            sw.Flush();
            sw.Close();
        }
    }
}
