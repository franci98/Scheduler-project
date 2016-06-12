using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scheduler
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(Program.GetConStr());

        private void InsertSchedule_Click(object sender, EventArgs e)
        {
            string schedule_title = ScheduleTitleTextBox.Text;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO subjects (title) VALUES(@title);";
            cmd.Parameters.AddWithValue("@title", schedule_title);
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
