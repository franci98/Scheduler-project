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
        DataSet ds1;
        //Adapter / Posrednik med datasetom in povezavo
        System.Data.OleDb.OleDbDataAdapter da;

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ds1 = new DataSet();
            string sql = "SELECT * FROM users";
            da = new OleDbDataAdapter(sql, con);
            con.Open();
            da.Fill(ds1, "users");
            con.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dRow = ds1.Tables["users"].NewRow();
                string FirstName = FirstNameTextBox.Text;
                string LastName = LastNameTextBox.Text;
                string Username = UsernameTextBox.Text;
                string Password = PassTextBox.Text;
                string Email = EmailTextBox.Text;
                con.Open();
                string querry = "INSERT INTO users ([username], [first_name], [last_name], [password], [email]) VALUES ('markok', 'Marko', 'Klavž', 'klavzm', 'marko.klavz@gmail.com');";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = querry;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data saved successfuly...!");
            }

            catch (OleDbException ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        
    }
}
