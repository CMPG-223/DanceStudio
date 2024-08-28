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
            ViewAllDancer();
        }        

        public void ViewAllDancer()
        {
            //needs to include dancer_ID, dancer_FName, dancer_LName,  
            //classID, dancerID,  name surname, enrolment status
            try
            {
                using (conn = new SqlConnection(conString))
                {
                    conn.Open();

                    string query1 = "SELECT Class_ID,  DISTINCT Dancer_ID, DISTINCT Enrollment_Status FROM ENROLLMENT_CLASS";
                    string query2 = "SELECT Dancer_ID, DISTINCT Dancer_FName, DISTINCT Dancer_LName FROM DANCER";
                                        
                    // Create two separate DataTables to store the data from each table
                    DataTable table1 = new DataTable();
                    DataTable table2 = new DataTable();

                    // Fill the DataTables with the data from each table
                    using (SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn))
                    {
                        adapter1.Fill(table1);
                    }

                    using (SqlDataAdapter adapter2 = new SqlDataAdapter(query2, conn))
                    {
                        adapter2.Fill(table2);
                    }

                    // Merge the two DataTables into a single DataTable
                    table1.Merge(table2);

                    // Bind the merged DataTable to the DataGridView
                    dgvAllDisplay.DataSource = table1;


                    //string cmdString = "SELECT ENROLLMENT_CLASS.Class_ID, DANCER.Dancer_ID, DANCER.Dancer_FName, DANCER.Dancer_LName, ENROLLMENT_CLASS.Enrollment_Status FROM ENROLLMENT_CLASS i " +
                    //                    "FULL OUTER JOIN DANCER ON DANCER.Dancer_ID = ENROLLMENT_CLASS.Dancer_ID ";
                    //cmd = new SqlCommand(cmdString, conn);

                    //adpt = new SqlDataAdapter();
                    //dset = new DataSet();
                    //adpt.SelectCommand = cmd;
                    //adpt.Fill(dset, "Enrollment_Class");

                    //dgvAllDisplay.DataSource = dset;
                    //dgvAllDisplay.DataMember = "Enrollment_Class";

                    //conn.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void PopulateEnrolledClasses()//for enrolled classes to be efficient, it needs to include dancer info with corresponding class info
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
