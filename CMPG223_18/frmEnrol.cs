using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_18
{
    public partial class frmEnrol : Form
    {
        string conString = @"Data Source=STARHAPPY_07\SQLEXPRESS;Initial Catalog=DanceStudio1;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand insertCmd;
        SqlDataAdapter adpt;
        DataSet dset;
        SqlDataReader reader;

        public frmEnrol()
        {
            InitializeComponent();
        }

        private void frmEnrol_Load(object sender, EventArgs e)
        {
                      
        }

        public void PopulateAvailClasses()
        {
            
        }

        public void PopulateEnrolledClasses()//for enrolled classes to be efficient, it needs to include dancer info with corresponding class info
        {
            
        }

        public void ViewAllDancer()
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn startPage = new frmLogIn();
            startPage.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
