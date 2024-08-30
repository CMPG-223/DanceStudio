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
        public int filledInAmount = 0;
        //public String filledInFName = "", filledinLName = "";

        public frmPayments()
        {
            InitializeComponent();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            //View data in datagridview
            populateDGV();
            //populate values in combobox
           // FillComboBox();
        }

        private void populateDGV()
        {
            try
            {
                using (con = new SqlConnection(connectString))
                {
                    con.Open();
                    string joingQuery = @"SELECT 
                                            d.Dancer_FName AS [First Name], 
                                            d.Dancer_LName AS [Surname], 
                                            SUM(p.Received_Payment) AS [Total Recieved Payments], 
                                            p_recent.Received_Payment AS [Last Recieved Payment], 
                                            d.Dancer_Total_All_Classes - SUM(p.Received_Payment) AS [Outstanding Payements], 
                                            p_recent.Payment_DateTime AS [Last Payment date] 
                                         FROM Dancer d
                                         INNER JOIN Payment_Received p ON p.Dancer_ID = d.Dancer_ID 
                                         CROSS APPLY(           
                                            SELECT TOP 1
                                                pr.Received_Payment, pr.Payment_DateTime
                                            FROM Payment_Received pr
                                            WHERE pr.Dancer_ID = d.Dancer_ID
                                            ORDER BY pr.Payment_DateTime DESC
                                            )p_recent
                                         GROUP BY 
                                            d.Dancer_FName, 
                                            d.Dancer_LName, 
                                            p_recent.Received_Payment, 
                                            p_recent.Payment_DateTime,
                                            d.Dancer_Total_All_Classes";

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
     
        private Double GetDancerTotalClasses(int Dancer_ID)
        {
            Double TotalClassesFee = 0;
            string query = "SELECT Dancer_Total_All_Classes FROM Dancer WHERE Dancer_ID = @Dancer_ID";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("Dancer_ID", Dancer_ID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TotalClassesFee = (Double)reader["Dancer_DoB"];
                    }

                    con.Close();
                }
            }

            return TotalClassesFee;
        }

        private void FillComboBox()
        {/*
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
            }*/
        }

        private void FilterDGV(int dancerID)
        {
/*            try
            {
                using (con = new SqlConnection(connectString))
                {
                    con.Open();
                    string joingQuery = @"SELECT d.Dancer_FName AS [First Name], d.Dancer_LName AS [Surname], " +
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
            }*/
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

            if (String.IsNullOrEmpty(Dancer_FName))
            {
                ErrorFName.SetError(txtDancerFName, "Please choose a dancer by clicking on their name");
                return;
            }
            else
                ErrorFName.Clear();
            
            if (String.IsNullOrEmpty(Dancer_LName))
            {
                errorLName.SetError(txtDancerLName, "Please choose a dancer by clicking on their name");
                return;
            }
            else
                errorLName.Clear();

            //Validation payment filled in
            if (txtPay.Text == "")
            {
                errorPaid.SetError(txtPay, "Please enter the amount paid by dancer");
                txtPay.Text = "";
                txtPay.Focus();
                return;
            }
            else
                errorPaid.Clear();

            if (!double.TryParse(txtPay.Text.Trim(), out Received_Payment))
            {
                errorPaid.SetError(txtPay, "Please enter a valid payment amount");
                txtPay.Text = "";
                txtPay.Focus();
                return;
            }

            Dancer_ID = GetDancerID(Dancer_FName, Dancer_LName);
            //wys nie meer ID's nie
            if (Dancer_ID == 0)
            {
                ErrorFName.SetError(txtDancerFName, "Please choose a dancer by clicking on their name");
                errorLName.SetError(txtDancerLName, "Please choose a dancer by clicking on their name");

                txtDancerFName.Text = "";
                txtDancerLName.Text = "";
                dtpDatePaid.Value = DateTime.Today;
                txtPay.Text = "";
                return;
            }
            else
            {
                ErrorFName.Clear();
                errorLName.Clear();
            }
            
            //add to dancer
            //string qDancer = "INSERT INTO Dancer (Dancer_FName, Dancer_LName, Dancer_DoB, Dancer_Total_All_Classes) " +
           //                 " VALUES (@Dancer_ID, @Dancer_FName, @Dancer_LName, @Dancer_DoB, @Dancer_Total_All_Classes,)";

            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    //Add to payments received
                    string query = "INSERT INTO Payment_Received (Dancer_ID, Received_Payment, Payment_DateTime) " +
                                    " VALUES (@Dancer_ID, @Received_Payment, @Payment_DateTime)";

                    using (SqlCommand cmd = new SqlCommand(query, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Dancer_ID", Dancer_ID);
                        cmd.Parameters.AddWithValue("@Received_Payment", Received_Payment);
                        cmd.Parameters.AddWithValue("@Payment_DateTime", Payment_DateTime);

                        cmd.ExecuteNonQuery();
                    }

                    //update dancer's received payments
                    string updateDancerQuery = "UPDATE Dancer SET Total_Received = Total_Received + @Received_Payment WHERE Dancer_ID = @Dancer_ID";

                    using (SqlCommand updateCmd = new SqlCommand(updateDancerQuery, con, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@Received_Payment", Received_Payment);
                        updateCmd.Parameters.AddWithValue("@Dancer_ID", Dancer_ID);

                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Payment added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDancerFName.Text = "";
                    txtDancerLName.Text = "";
                    dtpDatePaid.Value = DateTime.Today;
                    txtPay.Text = "";

                    populateDGV();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to add payment: " + ex.Message, "Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void cmbSearchPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cmbSearchPay.SelectedValue != null && int.TryParse(cmbSearchPay.SelectedValue.ToString(), out int selectedDancerID))
            {
                FilterDGV(selectedDancerID);
            }
            else
            {
                populateDGV();
            }*/
        }

        private void txtDancerFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDancerFName.Focus();
            }
        }

        private void dtpDatePaid_MouseDown(object sender, MouseEventArgs e)
        {
           // txtPayable.Focus();
        }

        private void txtPayable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPay.Focus();
            }
        }

        private void txtPay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(this, EventArgs.Empty);
            }
        }

        private void txtFSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFSearch.Text))
            {
                populateDGV();
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string searchString = @"SELECT 
                                            d.Dancer_FName AS [First Name], 
                                            d.Dancer_LName AS [Surname], 
                                            SUM(p.Received_Payment) AS [Total Recieved Payments], 
                                            p_recent.Received_Payment AS [Last Recieved Payment], 
                                            d.Dancer_Total_All_Classes - SUM(p.Received_Payment) AS [Outstanding Payements], 
                                            p_recent.Payment_DateTime AS [Last Payment date] 
                                         FROM Dancer d
                                         INNER JOIN Payment_Received p ON p.Dancer_ID = d.Dancer_ID 
                                         CROSS APPLY(           
                                            SELECT TOP 1
                                                pr.Received_Payment, pr.Payment_DateTime
                                            FROM Payment_Received pr
                                            WHERE pr.Dancer_ID = d.Dancer_ID
                                            ORDER BY pr.Payment_DateTime DESC
                                            )p_recent
                                         WHERE d.Dancer_FName  LIKE @Dancer_FName
                                         GROUP BY 
                                            d.Dancer_FName, 
                                            d.Dancer_LName, 
                                            p_recent.Received_Payment, 
                                            p_recent.Payment_DateTime,
                                            d.Dancer_Total_All_Classes";

                        using (SqlCommand cmd = new SqlCommand(searchString, con))
                        {
                            cmd.Parameters.AddWithValue("@Dancer_FName", txtFSearch.Text + "%");

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            ds.Clear();
                            adapter.Fill(ds, "Dancer");
                        }

                        con.Close();

                        dgvPayments.DataSource = ds.Tables["Dancer"].DefaultView;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Sql Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" Error: {ex.Message}");
                }

            }
        }

        private void txtLSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLSearch.Text))
            {
                populateDGV();
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string searchString = @"SELECT 
                                            d.Dancer_FName AS [First Name], 
                                            d.Dancer_LName AS [Surname], 
                                            SUM(p.Received_Payment) AS [Total Recieved Payments], 
                                            p_recent.Received_Payment AS [Last Recieved Payment], 
                                            d.Dancer_Total_All_Classes - SUM(p.Received_Payment) AS [Outstanding Payements], 
                                            p_recent.Payment_DateTime AS [Last Payment date] 
                                         FROM Dancer d
                                         INNER JOIN Payment_Received p ON p.Dancer_ID = d.Dancer_ID 
                                         CROSS APPLY(           
                                            SELECT TOP 1
                                                pr.Received_Payment, pr.Payment_DateTime
                                            FROM Payment_Received pr
                                            WHERE pr.Dancer_ID = d.Dancer_ID
                                            ORDER BY pr.Payment_DateTime DESC
                                            )p_recent
                                         WHERE d.Dancer_LName  LIKE @Dancer_LName
                                         GROUP BY 
                                            d.Dancer_FName, 
                                            d.Dancer_LName, 
                                            p_recent.Received_Payment, 
                                            p_recent.Payment_DateTime,
                                            d.Dancer_Total_All_Classes";

                        using (SqlCommand cmd = new SqlCommand(searchString, con))
                        {
                          //  cmd.Parameters.AddWithValue("@Dancer_FName", txtFSearch.Text + "%");
                            cmd.Parameters.AddWithValue("@Dancer_LName", txtLSearch.Text + "%");

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            ds.Clear();
                            adapter.Fill(ds, "Dancer");
                        }

                        con.Close();

                        dgvPayments.DataSource = ds.Tables["Dancer"].DefaultView;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Sql Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" Error: {ex.Message}");
                }

            }
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPayments.Rows[e.RowIndex];

                txtDancerFName.Text = row.Cells["First Name"].Value.ToString();
                txtDancerLName.Text = row.Cells["Surname"].Value.ToString();
            }

            ErrorFName.Clear();
            errorLName.Clear();
            errorPaid.Clear();
        }

        private void txtDancerLName_TextChanged(object sender, EventArgs e)
        {
            
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

// if (result > 0)
 //                       {
  //                          MessageBox.Show("Payment added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
 //                           txtDancerFName.Text = "";
//                            txtDancerLName.Text = "";
 //                           dtpDatePaid.Value = DateTime.Today;
 //                           txtPay.Text = "";
//                            txtPayable.Text = "";
 //                           populateDGV();
 //                       }
 //                       else
//                        {
 //                           MessageBox.Show("Failed to add payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 //                       }
 //                       con.Close();
