using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
    }
}
