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
        System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(Program.GetConStr());
        //Ustvarjanje dataseta / making of a data set
        DataTable ds1 = new DataTable();
        //Adapter / Posrednik med datasetom in povezavo
        System.Data.OleDb.OleDbDataAdapter da;

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM users";
            da = new OleDbDataAdapter(sql, con);
            con.Open();
            da.Fill(ds1);
            con.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string first_name = FirstNameTextBox.Text;
            string last_name = LastNameTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PassTextBox.Text;
            string email = EmailTextBox.Text;

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO users ([first_name], [last_name], [username], [password], [email]) VALUES (@first_name,@last_name,@username,@password,@email);";
            cmd.Parameters.AddWithValue("@first_name", first_name);
            cmd.Parameters.AddWithValue("@last_name", last_name);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Uporabnik ustvarjen");
            this.Hide();

            Login login = new Login();
            login.ShowDialog();

            this.Close();
        }


    }
}