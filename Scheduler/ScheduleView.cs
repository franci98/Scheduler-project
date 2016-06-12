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

namespace Scheduler
{
    public partial class ScheduleView : Form
    {
        public ScheduleView()
        {
            InitializeComponent();
        }

        OleDbConnection con = new System.Data.OleDb.OleDbConnection(Program.GetConStr());
        //Ustvarjanje dataseta / making of a data set
        DataSet ds1 = new DataSet();
        //Adapter / Posrednik med datasetom in povezavo
        OleDbDataAdapter da;
        string sch_id = Program.GetCurrSch();

        private void ScheduleView_Load(object sender, EventArgs e)
        {
        }

        private void LoadGrid(string qry)
        {
            da = new OleDbDataAdapter(qry, con);
            da.Fill(ds1);
            ScheduleGridView.DataSource = ds1.Tables[0];
        }

        private void MondayButton_Click(object sender, EventArgs e)
        {
            string qry = "SELECT hours.title, hours.start_time, hours.end_time, subjects.abbr, lessons.comment, lessons.rating "+
                         "FROM subjects INNER JOIN (schedules INNER JOIN(hours INNER JOIN(days INNER JOIN lessons ON days.ID = lessons.day_id) ON hours.ID = lessons.hour_id) ON schedules.ID = lessons.schedule_id) ON subjects.ID = lessons.subject_id "+
                         "WHERE(((schedules.ID) = "+ sch_id +") AND((days.ID) = 1));";

            con.Open();
            LoadGrid(qry);
            con.Close();
        }

        private void TuesdayButton_Click(object sender, EventArgs e)
        {
            string qry = "SELECT hours.title, hours.start_time, hours.end_time, subjects.abbr, lessons.comment, lessons.rating " +
                         "FROM subjects INNER JOIN (schedules INNER JOIN(hours INNER JOIN(days INNER JOIN lessons ON days.ID = lessons.day_id) ON hours.ID = lessons.hour_id) ON schedules.ID = lessons.schedule_id) ON subjects.ID = lessons.subject_id " +
                         "WHERE(((schedules.ID) = " + sch_id + ") AND((days.ID) = 2));";

            con.Open();
            LoadGrid(qry);
            con.Close();
        }

        private void WednesdayButton_Click(object sender, EventArgs e)
        {
            string qry = "SELECT hours.title, hours.start_time, hours.end_time, subjects.abbr, lessons.comment, lessons.rating " +
                         "FROM subjects INNER JOIN (schedules INNER JOIN(hours INNER JOIN(days INNER JOIN lessons ON days.ID = lessons.day_id) ON hours.ID = lessons.hour_id) ON schedules.ID = lessons.schedule_id) ON subjects.ID = lessons.subject_id " +
                         "WHERE(((schedules.ID) = " + sch_id + ") AND((days.ID) = 3));";

            con.Open();
            LoadGrid(qry);
            con.Close();
        }

        private void ThursdayButton_Click(object sender, EventArgs e)
        {
            string qry = "SELECT hours.title, hours.start_time, hours.end_time, subjects.abbr, lessons.comment, lessons.rating " +
                         "FROM subjects INNER JOIN (schedules INNER JOIN(hours INNER JOIN(days INNER JOIN lessons ON days.ID = lessons.day_id) ON hours.ID = lessons.hour_id) ON schedules.ID = lessons.schedule_id) ON subjects.ID = lessons.subject_id " +
                         "WHERE(((schedules.ID) = " + sch_id + ") AND((days.ID) = 4));";

            con.Open();
            LoadGrid(qry);
            con.Close();
        }

        private void FridayButton_Click(object sender, EventArgs e)
        {
            string qry = "SELECT hours.title, hours.start_time, hours.end_time, subjects.abbr, lessons.comment, lessons.rating " +
                         "FROM subjects INNER JOIN (schedules INNER JOIN(hours INNER JOIN(days INNER JOIN lessons ON days.ID = lessons.day_id) ON hours.ID = lessons.hour_id) ON schedules.ID = lessons.schedule_id) ON subjects.ID = lessons.subject_id " +
                         "WHERE(((schedules.ID) = " + sch_id + ") AND((days.ID) = 5));";

            con.Open();
            LoadGrid(qry);
            con.Close();
        }

        private void mojiUrnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedules pogled = new Schedules();
            pogled.ShowDialog();
        }

        private void predmeteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
