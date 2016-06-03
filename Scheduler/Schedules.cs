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
using Scheduler.Forms;

namespace Scheduler
{
    public partial class Schedules : Form
    {
        public Schedules()
        {
            InitializeComponent();
        }

        System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(Program.GetConStr());
        //Ustvarjanje dataseta / making of a data set
        DataSet ds1 = new DataSet();
        //Adapter / Posrednik med datasetom in povezavo
        System.Data.OleDb.OleDbDataAdapter da;
        

        private void Schedules_Load(object sender, EventArgs e)
        {
            string user_id = Program.GetUserID();
            
            string qry = "SELECT * FROM schedules WHERE user_id="+ user_id +";";

            con.Open();
            LoadGrid(qry);
            con.Close();
            
        }

        private void LoadGrid(string qry)
        {
            da = new OleDbDataAdapter(qry, con);
            ds1.Clear();
            da.Fill(ds1);
            SchedulesDataGridView1.DataSource = ds1.Tables[0];
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            SchedulesDataGridView1.Columns.Add(btn);
            btn.Text = "Pojdi";
        }

        private void SchedulesDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                string sel_id = SchedulesDataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                writeSchedule(sel_id);
            }
        }

        private void writeSchedule(string sc_id)
        {
            FileStream fs = new FileStream("current_schedule.txt", FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(sc_id);
            sw.Flush();
            sw.Close();
        }

        private void CreateScheduleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleNew ScNw = new ScheduleNew();
            ScNw.ShowDialog();
            this.Close();
        }
    }
}
