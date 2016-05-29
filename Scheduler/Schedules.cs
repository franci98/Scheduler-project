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

        System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = schedulerDB.accdb");
        //Ustvarjanje dataseta / making of a data set
        DataSet ds1 = new DataSet();
        //Adapter / Posrednik med datasetom in povezavo
        System.Data.OleDb.OleDbDataAdapter da;
        

        private void Schedules_Load(object sender, EventArgs e)
        {
            string user_id = Program.GetUserID();

            Console.WriteLine("User is: " + user_id);
            string qry = "SELECT * FROM schedules WHERE user_id="+ user_id +";";

            con.Open();
            LoadGrid(qry);
            con.Close();
            
        }

        private void LoadGrid(string qry)
        {
            da = new OleDbDataAdapter(qry, con);
            da.Fill(ds1);
            SchedulesDataGridView1.DataSource = ds1.Tables[0];
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            SchedulesDataGridView1.Columns.Add(btn);
            btn.Text = "Pojdi na urnik";
        }

        private void SchedulesDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
            }
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
