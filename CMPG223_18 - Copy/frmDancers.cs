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
    public partial class frmDancers : Form
    {
        //connection dtring to db
        public String connectString = "Data Source=LAPTOP-E2JAFDM7\\SQLEXPRESS;Initial Catalog=DanceStudio;Integrated Security=True";
        //other public var
        public SqlConnection con = new SqlConnection();
        public SqlCommand command;
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter;
        public String filledInFName = "", filledinLName = "";

        public frmDancers()
        {
            InitializeComponent();
        }

        private void frmDancers_Load(object sender, EventArgs e)
        {
            //View data in datagridview
            populateDGV();

            lblDancerID.Hide();
            txtDancerID.Hide();
        }

        private void populateDGV()
        {
          //  dgvDancers.DefaultCellStyle.SelectionBackColor = Color.OldLace;
          //  dgvDancers.DefaultCellStyle.SelectionForeColor = Color.Black;
            try
            {
                con = new SqlConnection(connectString);
                con.Open();

                string selectDancer = @"SELECT Dancer_FName AS [First Name], Dancer_LName AS [Surname], Dancer_DoB AS [Birthday] FROM Dancer";
                SqlDataAdapter adapter = new SqlDataAdapter(selectDancer, con);
                ds.Clear();
                adapter.Fill(ds, "Dancer");

                con.Close();

                dgvDancers.DataSource = ds.Tables["Dancer"].DefaultView;
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void clearSelection()
        {
            if (rdbAdd.Checked)
            {
                dtp.Enabled = true;
                txtDFName.Enabled = true;
                txtDLName.Enabled = true;
                lblDancerID.Enabled = false;
                txtDancerID.Enabled = false;

                dtp.Value = DateTime.Today;
                txtDancerID.Text = "";
                txtDFName.Text = "";
                txtDLName.Text = "";
            }
            else if (rdbDelete.Checked)
            {
                dtp.Enabled = false;
                txtDFName.Enabled = false;
                txtDLName.Enabled = false;
                lblDancerID.Enabled = true;
                txtDancerID.Enabled = true;

                dtp.Value = DateTime.Today;
                txtDancerID.Text = "";
                txtDFName.Text = "";
                txtDLName.Text = "";
            }
            else if (rdbUpdate.Checked)
            {
                dtp.Enabled = true;
                txtDFName.Enabled = true;
                txtDLName.Enabled = true;
                lblDancerID.Enabled = true;
                txtDancerID.Enabled = true;

                dtp.Value = DateTime.Today;
                txtDancerID.Text = "";
                txtDFName.Text = "";
                txtDLName.Text = "";
            }
        }

        private bool Validation()
        {
            bool isValid = true;
            DateTime maxAge = new DateTime(1994, 12, 31);
            DateTime minAge = new DateTime(2019, 12, 31);

            //Validation that all fields are filled in
            if (string.IsNullOrEmpty(txtDFName.Text))
            {
                FNameError.SetError(txtDFName, "Please fill the dancer's first name.");
                txtDFName.Text = "";
                txtDFName.Focus();
                isValid = false;
            }
            else
                FNameError.Clear();

            if (string.IsNullOrEmpty(txtDLName.Text))
            {
                LNameError.SetError(txtDLName, "Please fill the dancer's last name.");
                txtDLName.Text = "";
                txtDLName.Focus();
                isValid = false;
            }
            else
                LNameError.Clear();

            if (!(rdbDelete.Checked == true) && ((dtp.Value.Date < maxAge.Date) || (dtp.Value.Date > minAge.Date)))
            {
                DoBError.SetError(dtp, "Dancer may not be added due to age restrictions.");
                dtp.Focus();
                isValid = false;
            }
            else
                DoBError.Clear();

            return isValid;
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

        private void ValidateID()
        {
            //validate iD is int
            if (int.TryParse(txtDancerID.Text, out int Dancer_ID))
            {
                //Continue as normal
            }
            else
            {
                MessageBox.Show("Please enter a valid integer");
                txtDancerID.Focus();
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain Mainfrm = new frmMain();
            Mainfrm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            //when add/change or delete was selected 
            radError.Clear();
            clearSelection();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //declare variables
            string Dancer_FName = "", Dancer_LName = "";
            DateTime Dancer_DoB = DateTime.Today;
            double Dancer_Total_All_Classes = 0, Total_Received = 0;
            int Dancer_ID = 0;

            //set variables
            Dancer_FName = txtDFName.Text.Trim();
            Dancer_LName = txtDLName.Text.Trim();
            Dancer_DoB = dtp.Value.Date;

            //Check if radio button is selected
            if (rdbAdd.Checked == false && rdbDelete.Checked == false && rdbUpdate.Checked == false)
            {
                radError.SetError(grpExpLvl, "Please select either add/update/delete");
                return;
            }
            else
                radError.Clear();

            if (!Validation())
            {
                return;
            }
            
            //determine which radio button is checked
            if (rdbAdd.Checked)
            {
                if (!(GetDancerID(Dancer_FName, Dancer_LName) == 0))
                {
                    FNameError.SetError(txtDFName, "No duplicate values allowed. If it is another dancer, please fill in initials for middle name");
                    LNameError.SetError(txtDLName, "Please make sure the dancer you are adding is not already in the system");
                    txtDFName.Text = "";
                    txtDLName.Text = "";
                    txtDFName.Focus();
                    return;
                }

                string query = "INSERT INTO Dancer (Dancer_FName, Dancer_LName, Dancer_DoB, Dancer_Total_All_Classes, Total_Received) " +
                   "           VALUES (@Dancer_FName, @Dancer_LName, @Dancer_DoB, @Dancer_Total_All_Classes, @Total_Received)";

                using (SqlConnection con = new SqlConnection(connectString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Dancer_FName", Dancer_FName);
                        cmd.Parameters.AddWithValue("@Dancer_LName", Dancer_LName);
                        cmd.Parameters.AddWithValue("@Dancer_DoB", Dancer_DoB);
                        cmd.Parameters.AddWithValue("@Dancer_Total_All_Classes", Dancer_Total_All_Classes);
                        cmd.Parameters.AddWithValue("@Total_Received", Total_Received);

                        con.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Dancer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDFName.Text = "";
                            txtDLName.Text = "";
                            dtp.Value = DateTime.Today;
                            populateDGV();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add dancer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }//if
            else if (rdbDelete.Checked)
            {
                //DELETE
                Dancer_ID = GetDancerID(filledInFName, filledinLName);

                var confirm = MessageBox.Show("Are you sure you want to delete this dancer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (con = new SqlConnection(connectString))
                    {
                        try
                        {
                            con.Open();

                            string deleteRecord = @"DELETE FROM Dancer WHERE Dancer_ID = @Dancer_ID";
                            SqlCommand cmd = new SqlCommand(deleteRecord, con);
                            cmd.Parameters.AddWithValue("@Dancer_ID", Dancer_ID);
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Dancer deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ds.Clear();
                                txtDancerID.Text = "";
                                populateDGV();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete dancer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
            else if (rdbUpdate.Checked)
            {
                //UPDATE
                Dancer_ID = GetDancerID(filledInFName, filledinLName);

                var confirm = MessageBox.Show("Are you sure you want to update this dancer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (con = new SqlConnection(connectString))
                    {
                        try
                        {
                            con.Open();

                            string updateRecord = @"UPDATE Dancer SET Dancer_FName = @Dancer_FName, Dancer_LName = @Dancer_LName,
                                                    Dancer_DoB = @Dancer_DoB WHERE Dancer_ID = @Dancer_ID";

                            SqlCommand cmd = new SqlCommand(updateRecord, con);
                            cmd.Parameters.AddWithValue("@Dancer_ID", Dancer_ID);
                            cmd.Parameters.AddWithValue("@Dancer_FName", Dancer_FName);
                            cmd.Parameters.AddWithValue("@Dancer_LName", Dancer_LName);
                            cmd.Parameters.AddWithValue("@Dancer_DoB", Dancer_DoB);

                            int result = cmd.ExecuteNonQuery();

                            int databaseDancerID = GetDancerID(Dancer_FName, Dancer_LName);

                            if (Dancer_ID != databaseDancerID)
                            {
                                MessageBox.Show("You may not update an ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtDancerID.Text = "";
                                return;
                            }

                            if (result > 0)
                            {
                                MessageBox.Show("Dancer updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ds.Clear();
                                populateDGV();
                                clearSelection();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update dancer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        //Find dancer when ID is typed in
        private void txtDancerID_TextChanged(object sender, EventArgs e)
        {
            int Dancer_ID = 0;
                //check not empty
             if (string.IsNullOrEmpty(txtDancerID.Text))
             {
                 populateDGV();
                 return;
             }
             else 
             {      //check id is int
                if (!int.TryParse(txtDancerID.Text, out Dancer_ID))
                {
                    MessageBox.Show("You can only type in integers here", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtDancerID.Focus();
                    txtDancerID.Text = "";
                    return;
                }
                else 
                {
                    con = new SqlConnection(connectString);
                    con.Open();

                    string searchString = @"SELECT * FROM Dancer WHERE Dancer_ID = '" + txtDancerID.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(searchString, con);
                    ds.Clear();
                    adapter.Fill(ds, "Dancer");

                    con.Close();

                    //display database values in textbox+
                    if (ds.Tables["Dancer"].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables["Dancer"].Rows[0];
                        txtDFName.Text = row["Dancer_FName"].ToString();
                        txtDLName.Text = row["Dancer_LName"].ToString();
                        dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                    }

                    dgvDancers.DataSource = ds.Tables["Dancer"].DefaultView;
                }
             }
        }           

        private void txtDancerID_KeyUp(object sender, KeyEventArgs e)
        {
            //SEARCH AS TYPE
            //int searchNum = 0;
            //searchNum = Convert.ToInt32(txtDancerID.Text);

        }

        private void txtDFName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDLName_TextChanged(object sender, EventArgs e)
        {/*
            if (string.IsNullOrEmpty(txtDFName.Text))
            {
                populateDGV();
            }
            else
            {
                con = new SqlConnection(connectString);
                con.Open();

                string searchString = @"SELECT * FROM Dancer WHERE Dancer_LName like @Dancer_LName";

                if (!string.IsNullOrEmpty(txtDancerID.Text))
                {
                    searchString += " AND Dancer_ID = @Dancer_ID";
                }

                using (SqlCommand cmd = new SqlCommand(searchString, con))
                {
                    cmd.Parameters.AddWithValue("@Dancer_FName", txtDFName.Text + "%");
                    cmd.Parameters.AddWithValue("@Dancer_LName", txtDLName.Text + "%");
                    if (!string.IsNullOrEmpty(txtDancerID.Text))
                    {
                        cmd.Parameters.AddWithValue("@Dancer_ID", txtDancerID.Text);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    ds.Clear();
                    adapter.Fill(ds, "Dancer");
                }

                con.Close();

                if (ds.Tables["Dancer"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["Dancer"].Rows[0];
                    txtDFName.Text = row["Dancer_FName"].ToString();
                    dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                    txtDancerID.Text = row["Dancer_ID"].ToString();
                }

                dgvDancers.DataSource = ds.Tables["Dancer"].DefaultView;
            }*/
        }

        private void txtDancerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDFName.Focus();
            }
        }

        private void txtDFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDLName.Focus();
            }
        }

        private void dtp_MouseDown(object sender, MouseEventArgs e)
        {
            //btnComplete_Click(this, EventArgs.Empty);
            
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dtp.Value.ToString());
        }

        private void txtFSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFSearch.Text))
            {
                //populateDGV();
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string searchString = @"SELECT Dancer_FName AS [First Name], Dancer_LName AS [Surname], Dancer_DoB AS [Birthday] FROM Dancer WHERE Dancer_FName like @Dancer_FName";
                       /* if (!string.IsNullOrEmpty(txtDancerID.Text))
                        {
                            searchString += " AND Dancer_ID = @Dancer_ID";
                        }*/

                        using (SqlCommand cmd = new SqlCommand(searchString, con))
                        {
                            cmd.Parameters.AddWithValue("@Dancer_FName", txtFSearch.Text + "%");
                           /* if (!string.IsNullOrEmpty(txtDancerID.Text))
                            {
                                cmd.Parameters.AddWithValue("@Dancer_ID", txtDancerID.Text);
                            }*/


                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            ds.Clear();
                            adapter.Fill(ds, "Dancer");
                        }
                        
                        con.Close();

                        /*if (ds.Tables["Dancer"].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables["Dancer"].Rows[0];
                            txtDLName.Text = row["Dancer_LName"].ToString();
                            dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                            txtDancerID.Text = row["Dancer_ID"].ToString();
                        }*/

                        dgvDancers.DataSource = ds.Tables["Dancer"].DefaultView;
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
                //populateDGV();
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string searchString = @"SELECT Dancer_FName AS [First Name], Dancer_LName AS [Surname], Dancer_DoB AS [Birthday] FROM Dancer WHERE Dancer_LName like @Dancer_LName";
                        
                        using (SqlCommand cmd = new SqlCommand(searchString, con))
                        {
                            cmd.Parameters.AddWithValue("@Dancer_LName", txtLSearch.Text + "%");
                            
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            ds.Clear();
                            adapter.Fill(ds, "Dancer");
                        }

                        con.Close();

                        dgvDancers.DataSource = ds.Tables["Dancer"].DefaultView;
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

        private void dgvDancers_MouseDown(object sender, MouseEventArgs e)
        {
          //  txtDFName.Text = dgvDancers.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvDancers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDancers.Rows[e.RowIndex];

                filledInFName = row.Cells["First Name"].Value.ToString();
                filledinLName = row.Cells["Surname"].Value.ToString();
                txtDFName.Text = filledInFName;
                txtDLName.Text = filledinLName;
                dtp.Value = (DateTime)row.Cells["Birthday"].Value;
            }

            FNameError.Clear();
            LNameError.Clear();
            DoBError.Clear();
        }
    }
}
