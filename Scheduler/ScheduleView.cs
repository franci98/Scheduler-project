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
        public ScheduleView(string schedule_id)
        {
            InitializeComponent();
            string sid = schedule_id;
            //string query = "";
        }

        OleDbConnection con = new System.Data.OleDb.OleDbConnection(Program.GetConStr());
        //Ustvarjanje dataseta / making of a data set
        DataSet ds1 = new DataSet();
        //Adapter / Posrednik med datasetom in povezavo
        OleDbDataAdapter da;

        private void ScheduleView_Load(object sender, EventArgs e)
        {
            string sch_id = Program.GetCurrSch();

            string qry = "";

            con.Open();
            LoadGrid(qry);
            con.Close();
        }

        private void LoadGrid(string qry)
        {
            da = new OleDbDataAdapter(qry, con);
            da.Fill(ds1);
            ScheduleGridView.DataSource = ds1.Tables[0];
        }
    }
}
