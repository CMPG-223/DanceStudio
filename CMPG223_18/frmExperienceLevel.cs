<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_18
{
    public partial class frmExperienceLevel : Form
    {
        public frmExperienceLevel()
        {
            InitializeComponent();
        }
    }
}
=======
﻿using System;
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
    public partial class frmExperienceLevel : Form
    {
        string conString = @"Data Source=STARHAPPY_07\SQLEXPRESS;Initial Catalog=DanceStudio1;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand insertCmd;
        SqlDataAdapter adpt;
        DataSet dset;
        SqlDataReader reader;

        public frmExperienceLevel()
        {
            InitializeComponent();
        }

        private void frmExperienceLevel_Load(object sender, EventArgs e)
        {

            //use try catch for everything
            conn = new SqlConnection(conString);
            conn.Open();
            //MessageBox.Show("Connection to Shufflez Studio Database successful.");
            PopulateExperienceLevel();
            PopulateDanceType();
            PopulateClasses();
            ViewAllData();
            conn.Close();           
        }

        private void ViewAllData()
        {
            try
            {
                using (conn = new SqlConnection(conString))
                {
                    conn.Open();

                    string cmdString = "SELECT * FROM EXPERIENCE_LEVEL";
                    cmd = new SqlCommand(cmdString, conn);

                    adpt = new SqlDataAdapter();
                    dset = new DataSet();
                    adpt.SelectCommand = cmd;
                    adpt.Fill(dset, "EXPERIENCE_LEVEL");

                    dgvExpLvl.DataSource = dset;
                    dgvExpLvl.DataMember = "EXPERIENCE_LEVEL";

                    conn.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void PopulateExperienceLevel()
        {
            try
            {
                using (conn = new SqlConnection(conString))
                {
                    conn.Open();
                    cmbExpLvl.Items.Clear();

                    string cmdString = "SELECT DISTINCT exp_Desc FROM EXPERIENCE_LEVEL";
                    cmd = new SqlCommand(cmdString, conn);

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbExpLvl.Items.Add(reader.GetValue(0));
                    }
                    conn.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }           
        }

        private void PopulateDanceType()
        {
            try
            {
                using (conn = new SqlConnection(conString))
                {
                    conn.Open();
                    cmbDanceType.Items.Clear();
                    string cmdString = "SELECT DISTINCT Type_Desc FROM DANCE_TYPE";
                    cmd = new SqlCommand(cmdString, conn);

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbDanceType.Items.Add(reader.GetValue(0));
                    }

                    conn.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }    
        }

        private void PopulateClasses()
        {
            try
            {
                using (conn = new SqlConnection(conString))
                {
                    conn.Open();

                    lstClasses.Items.Clear();
                    string cmdString = "SELECT DISTINCT Class_Description FROM CLASS";
                    cmd = new SqlCommand(cmdString, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lstClasses.Items.Add(reader.GetValue(0));
                    }
                    conn.Close();
                }
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }     
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIn startPage = new frmLogIn();
            startPage.ShowDialog();            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain mainPage = new frmMain();
            mainPage.ShowDialog();
        }

        private int GetExperienceID()
        {
            int experienceID = 0;
            string expLvl = cmbExpLvl.SelectedItem.ToString();
            string cmdString = "SELECT exp_ID FROM EXPERIENCE_LEVEL WHERE exp_Desc = @exp_Desc";

            using (conn = new SqlConnection(conString))
            {
                cmd = new SqlCommand(cmdString, conn);
                cmd.Parameters.AddWithValue("@exp_Desc", expLvl);

                conn.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    experienceID = (int)reader["exp_ID"];
                }
                conn.Close();
            }

            return experienceID;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (rdbUpdate.Checked)
            {
                var confirm = MessageBox.Show("Are you sure you want to update the experience level?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (conn = new SqlConnection(conString))
                    {
                        try
                        {                            
                            string updateTxt = txtAddExpLvl.Text;
                            int expID = GetExperienceID();

                            string newExpLvl = "UPDATE EXPERIENCE_LEVEL SET exp_Desc = @updateTxt WHERE exp_ID = @expID";

                            cmd = new SqlCommand(newExpLvl, conn);
                            cmd.Parameters.AddWithValue("@updateTxt", txtAddExpLvl.Text);

                            conn.Open();

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Experience level updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dset.Clear();
                                RefreshDGV();
                                ViewAllData();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update experience level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            conn.Close();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                }
            }
            else if (rdbDelete.Checked)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete the experience level", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(confirm == DialogResult.Yes)
                {
                    
                    try
                    {
                        using (conn = new SqlConnection(conString))
                        {
                            string deleteExpLvl = cmbExpLvl.SelectedItem.ToString();
                            string cmdDelete = @"DELETE FROM EXPERIENCE_LEVEL WHERE exp_Desc = @deleteExpLvl";

                            cmd = new SqlCommand(cmdDelete, conn);
                            cmd.Parameters.AddWithValue("@deleteExpLvl", deleteExpLvl);
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Experience Level deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dset.Clear();
                                RefreshDGV();
                                RefreshExperienceLvl();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete experience level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            conn.Close();
                        }
                                                        
                    }
                    catch(SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }                    
                }
            }
            else
                MessageBox.Show("Please select radio button.");
        }

        private void RefreshDGV()
        {
            try
            {
                using (conn = new SqlConnection(conString))
                {
                    string newDisplay = "SELECT * FROM EXPERIENCE_LEVEL";
                    cmd = new SqlCommand(newDisplay, conn);
                    conn.Open();
                    
                    adpt = new SqlDataAdapter();
                    dset = new DataSet();
                    adpt.SelectCommand = cmd;
                    adpt.Fill(dset, "EXPERIENCE_LEVEL");

                    dgvExpLvl.DataSource = dset;
                    dgvExpLvl.DataMember = "EXPERIENCE_LEVEL";

                    conn.Close();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }           
        }

        private void btnAddExpLvl_Click(object sender, EventArgs e)
        {          
            try
            {
                if (rdbAdd.Checked)
                {
                    using (conn = new SqlConnection(conString))
                    {
                        string newExpLvl = txtAddExpLvl.Text;
                        string cmdString = $"INSERT INTO EXPERIENCE_LEVEL(exp_Desc) VALUES (@newExpLvl)";

                        using (insertCmd = new SqlCommand(cmdString, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@newExpLvl", txtAddExpLvl.Text);
                            conn.Open();
                            int result = insertCmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Experience level added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtAddExpLvl.Text = "";
                                RefreshExperienceLvl();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add dancer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            conn.Close();
                        }
                    }                    
                }                                                       
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }    
        }

        public void RefreshExperienceLvl()
        {
            using(conn = new SqlConnection(conString))
            {
                string cmdString = "SELECT * FROM EXPERIENCE_LEVEL";

                cmd = new SqlCommand(cmdString, conn);
                conn.Open();
                reader = cmd.ExecuteReader();

                cmbExpLvl.Items.Clear();
                while(reader.Read())
                {
                    cmbExpLvl.Items.Add(reader["exp_Desc"].ToString());
                }
                conn.Close();
            }
        }
    }
}
>>>>>>> Naledi
