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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            

        }

        //Ustvarjanje povezave / Making a connection
        System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = schedulerDB.accdb");
        //Ustvarjanje dataseta / making of a data set
        DataTable ds1 = new DataTable();
        //Adapter / Posrednik med datasetom in povezavo
        System.Data.OleDb.OleDbDataAdapter da;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            con.Open();

            string username = UsernameTextBox.Text;
            string password = PassTextBox.Text;

            string sql = "SELECT * FROM users u Where u.username ='"+ username +"' AND u.password='"+ password +"'";
            da = new System.Data.OleDb.OleDbDataAdapter(sql, con);
            da.Fill(ds1);
            con.Close();
            
            if (ds1.Rows.Count == 1)
            {
                MessageBox.Show("Vpisani ste kot" + username);

                this.Hide();

                RegisterForm register = new RegisterForm();
                register.ShowDialog();

                this.Close();
            }
            else
                MessageBox.Show("Vnešeni podatki niso pravilni");

            ds1.Clear();

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm register = new RegisterForm();
            register.ShowDialog();

            this.Close();
        }
    }
}
