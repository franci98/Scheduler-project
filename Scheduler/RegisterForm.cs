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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        //Ustvarjanje povezave / Making a connection
        System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = schedulerDB.accdb");
        //Ustvarjanje dataseta / making of a data set
        DataTable ds1 = new DataTable();
        //Adapter / Posrednik med datasetom in povezavo
        System.Data.OleDb.OleDbDataAdapter da;

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            string FirstName = FirstNameTextBox.Text;
            string LastName = LastNameTextBox.Text;
            string Username = UsernameTextBox.Text;
            string Password = PassTextBox.Text;
            string Email = EmailTextBox.Text;
            //tole bo treba posodobit 18.5.2016
            cmd.CommandText = "INSERT INTO users (username, first_name, last_name, password, email) VALUES ('"+ Username + "','" + FirstName + "','" + LastName + "','" + Password + "','" + Email + "');";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Account Succefully Created", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
