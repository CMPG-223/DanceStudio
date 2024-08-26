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
    public partial class frmPayments : Form
    {
        //connection
        public String connectString = "Data Source=laptop-e2jafdm7\\sqlexpress;Initial Catalog=DanceStudio;Integrated Security=True";
        //other public var
        public SqlConnection con = new SqlConnection();
        public SqlCommand command;
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter;
        public string Dancer_FName = "", Dancer_LName = "";
        public DateTime Payment_DateTime = DateTime.Today;
        public double Received_Payment = 0;
        public int Dancer_ID = 0, Payment_ID = 0;

        public frmPayments()
        {
            InitializeComponent();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            //View data in datagridview
            populateDGV();
            //populate values in combobox
            FillComboBox();
        }

        private void populateDGV()
        {
            try
            {
                using (con = new SqlConnection(connectString))
                {
                    con.Open();
                    string joingQuery = @"SELECT d.Dancer_FName, d.Dancer_LName, " + 
                                            "SUM(p.Received_Payment) AS [Total Recieved Payments], " +
                                            "p_recent.Received_Payment AS [Last Recieved Payment], p_recent.Payment_DateTime AS [Last Payment date] " +
                                         "FROM Payment_Received p " +
                                         "INNER JOIN Dancer d on p.Dancer_ID = d.Dancer_ID " +
                                            "INNER JOIN( " +
                                            "SELECT Dancer_ID, Received_Payment, Payment_DateTime FROM Payment_Received "+
                                                "WHERE Payment_DateTime = (SELECT MAX(Payment_DateTime) FROM Payment_Received pr " +
                                                " WHERE pr.Dancer_ID = Payment_Received.Dancer_ID) ) p_recent ON p.Dancer_ID = p_recent.Dancer_ID " +
                                                 "GROUP BY d.Dancer_FName, d.Dancer_LName, p_recent.Received_Payment, p_recent.Payment_DateTime";

                    SqlDataAdapter adapter = new SqlDataAdapter(joingQuery, con);
                    ds.Clear();
                    adapter.Fill(ds, "PAYMENT_RECEIVED");

                    dgvPayments.DataSource = ds.Tables["PAYMENT_RECEIVED"].DefaultView;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private int GetDancerID(string firstName, string lastName)
        {
            int dancerID = 0;
            string query = "SELECT Dancer_ID FROM Dancer WHERE Dancer_FName = @Dancer_FName AND Dancer_Lname = @Dancer_LName";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("Dancer_FName", firstName);
                    cmd.Parameters.AddWithValue("Dancer_LName", lastName);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        dancerID = (int)reader["Dancer_ID"];
                    }

                    con.Close();
                }
            }

            return dancerID;
        }

        private void FillComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectString))
                {
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Dancer_ID, Dancer_FName, Dancer_LName FROM Dancer ORDER BY Dancer_FName", con);

                    DataTable dancerTable = new DataTable();
                    adapter.Fill(dancerTable);

                    dancerTable.Columns.Add("FullName", typeof(string), "Dancer_FName + ' ' + Dancer_LName");
                    
                    cmbSearchPay.DisplayMember = "FullName";
                    cmbSearchPay.ValueMember = "Dancer_ID";
                    cmbSearchPay.DataSource = dancerTable;

                    con.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void FilterDGV(int dancerID)
        {
            try
            {
                using (con = new SqlConnection(connectString))
                {
                    con.Open();
                    string joingQuery = @"SELECT d.Dancer_FName, d.Dancer_LName, " +
                                            "SUM(p.Received_Payment) AS [Total Recieved Payments], " +
                                            "p_recent.Received_Payment AS [Last Recieved Payment], p_recent.Payment_DateTime AS [Last Payment date] " +
                                         "FROM Payment_Received p " +
                                         "INNER JOIN Dancer d on p.Dancer_ID = d.Dancer_ID " +
                                            "INNER JOIN( " +
                                                "SELECT pr1.Dancer_ID, pr1.Received_Payment, pr1.Payment_DateTime " +
                                                "FROM Payment_Received pr1 " +
                                                "WHERE pr1.Payment_DateTime = ( " +
                                                    "SELECT MAX(pr2.Payment_DateTime) " + 
                                                    "FROM Payment_Received pr2 " +
                                                    "WHERE pr2.Dancer_ID = pr1.Dancer_ID ) " +
                                            ")p_recent ON p.Dancer_ID = p_recent.Dancer_ID " +
                                                "WHERE p.Dancer_ID = @Dancer_ID "+
                                                "GROUP BY d.Dancer_FName, d.Dancer_LName, p_recent.Received_Payment, p_recent.Payment_DateTime";

                    using (SqlCommand cmd = new SqlCommand(joingQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Dancer_ID", dancerID);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet filteredDS = new DataSet();
                        adapter.Fill(filteredDS, "PAYMENT_RECEIVED");

                        dgvPayments.DataSource = filteredDS.Tables["PAYMENT_RECEIVED"].DefaultView;
                    }
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn LogInFrm = new frmLogIn();
            LogInFrm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain Mainfrm = new frmMain();
            Mainfrm.Show();
        }

        private void lblPayNow_Click(object sender, EventArgs e)
        {

        }

        private void lblPayable_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //set variables
            Dancer_FName = txtDancerFName.Text.Trim();
            Dancer_LName = txtDancerLName.Text.Trim();
            Payment_DateTime = dtpDatePaid.Value.Date;

            if (!double.TryParse(txtPay.Text.Trim(), out Received_Payment))
            {
                MessageBox.Show("Please eneter a valid payment amount", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validation that all fields are filled in
            if (string.IsNullOrEmpty(Dancer_FName) || string.IsNullOrEmpty(Dancer_LName))
            {
                MessageBox.Show("Please fill in your name", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (Received_Payment == 0)
            {
                MessageBox.Show("Please fill in what the dancer has paid", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dancer_ID = GetDancerID(Dancer_FName, Dancer_LName);
            if (Dancer_ID == 0)
            {
                MessageBox.Show("Dancer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtDancerFName.Text = "";
                txtDancerLName.Text = "";
                dtpDatePaid.Value = DateTime.Today;
                txtPay.Text = "";
                txtPayable.Text = "";

                return;
            }

            string query = "INSERT INTO Payment_Received (Dancer_ID, Received_Payment, Payment_DateTime) " +
                            " VALUES (@Dancer_ID, @Received_Payment, @Payment_DateTime)";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Dancer_ID", Dancer_ID);                    
                    cmd.Parameters.AddWithValue("@Received_Payment", Received_Payment);                    
                    cmd.Parameters.AddWithValue("@Payment_DateTime", Payment_DateTime);

                    con.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Payment added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDancerFName.Text = "";
                        txtDancerLName.Text = "";
                        dtpDatePaid.Value = DateTime.Today;
                        txtPay.Text = "";
                        txtPayable.Text = "";
                        populateDGV();
                        }
                    else
                    {
                        MessageBox.Show("Failed to add payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
        }

        private void cmbSearchPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchPay.SelectedValue != null && int.TryParse(cmbSearchPay.SelectedValue.ToString(), out int selectedDancerID))
            {
                FilterDGV(selectedDancerID);
            }
            else
            {
                populateDGV();
            }
        }

        private void txtDancerLName_TextChanged(object sender, EventArgs e)
        {/*
            if (string.IsNullOrEmpty(txtDancerLName.Text))
            {
                populateDGV();
            }
            else
            {
                con = new SqlConnection(connectString);
                con.Open();
                
                string searchString = @"SELECT d.Dancer_FName, d.Dancer_LName, p.Payment_ID, d.Dancer_Total_All_Classes, d.Total_Received, 
                                        p.Received_Payment, p.Payment_DateTime 
                                        FROM Payment_Received p INNER JOIN Dancer d on p.Dancer_ID = p.Dancer_ID 
                                        WHERE Dancer_FName like '"+ txtDancerFName.Text + "%' AND Dancer_LName like '" + txtDancerLName.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(searchString, con);
                ds.Clear();
                adapter.Fill(ds, "Payment_Received");

                con.Close();

                if (ds.Tables["Dancer"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["Dancer"].Rows[0];
                    txtDancerFName.Text = row["Dancer_FName"].ToString();
                    txtDancerLName.Text = row["Dancer_LName"].ToString();
                    //dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                    //.Text = row["Dancer_ID"].ToString();
                }

                dgvPayments.DataSource = ds.Tables["Payment_Received"].DefaultView;
            }*/
        }

        private void txtDancerFName_TextChanged(object sender, EventArgs e)
        {/*
            if (string.IsNullOrEmpty(txtDancerLName.Text))
            {
                populateDGV();
            }
            else
            {
                con = new SqlConnection(connectString);
                con.Open();

                string searchString = @"SELECT d.Dancer_FName, d.Dancer_LName, p.Payment_ID, d.Dancer_Total_All_Classes, d.Total_Received, 
                                        p.Received_Payment, p.Payment_DateTime 
                                        FROM Payment_Received p INNER JOIN Dancer d on p.Dancer_ID = p.Dancer_ID 
                                        WHERE Dancer_FName like '" + txtDancerFName.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(searchString, con);
                ds.Clear();
                adapter.Fill(ds, "Payment_Received");

                con.Close();

                if (ds.Tables["Dancer"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["Dancer"].Rows[0];
                    txtDancerFName.Text = row["Dancer_FName"].ToString();
                    //dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                    //.Text = row["Dancer_ID"].ToString();
                }

                dgvPayments.DataSource = ds.Tables["Payment_Received"].DefaultView;
            }*/
        }
    }
}
//Add as enter druk na volgende text box