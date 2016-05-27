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
using System.IO;

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
                string user_id = Convert.ToString(ds1.Rows[0]["ID"]);
                username = Convert.ToString(ds1.Rows[0]["first_name"]);
                password = Convert.ToString(ds1.Rows[0]["last_name"]);
                MessageBox.Show("Vpisani ste kot " + username + " "+ password);

                SaveUserData(user_id);
                
                this.Hide();
                Schedules sch = new Schedules();
                sch.ShowDialog();
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

        public void SaveUserData(string user_id)
        {
            try
            {
                // najprej ustvarimo datotečni tok, ki ga poimenujemo, povemo ime datoteke in     
                //način odpiranja datoteke
                FileStream fs = new FileStream("user_data.txt", FileMode.Open);

                // nato kreiramo zapisovalnik v tok in mu povemo, v kateri tok naj piše
                StreamWriter sw = new StreamWriter(fs);

                sw.Write(user_id);

                // izpraznimo morebitni medpomnilnik in te podatke zapišemo v datoteko
                sw.Flush();

                // zapremo datoteko
                sw.Close();
            }
	        catch (Exception ex)

            {
                        MessageBox.Show(ex.Message, "Napaka!");
                    }

        }
    }
}
