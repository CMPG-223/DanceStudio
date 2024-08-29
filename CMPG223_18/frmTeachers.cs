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
using System.Data.SqlClient;

namespace CMPG223_18
{
    public partial class frmTeachers : Form
    {

        private readonly string Constr = @"Data Source=LAPTOP-3GNEJ5LN\MSSQLSERVER01;Initial Catalog=DanceStudio;Integrated Security=True";
        SqlConnection conn;             //Declare variables
        SqlDataAdapter adapt;
        SqlCommand comm;
        DataSet data;
        SqlDataReader reader;

        public frmTeachers()
        {
            InitializeComponent();
        }

        
        public void Display(string var)         //method to display table in datagridview
        {
            
            conn.Open();
            adapt = new SqlDataAdapter();
            data = new DataSet();
            comm = new SqlCommand(var, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(data, "SourceTable");

            dgvTeachers.DataSource = data;
            dgvTeachers.DataMember = "SourceTable";


            conn.Close();
        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(Constr);       //When form load create connection
                conn.Open();
                conn.Close();
                string var = "SELECT * FROM TEACHER";
                Display(var);

                conn.Open();
                cmbDanceType.Items.Clear();



                //comm = new SqlCommand("SELECT Type_Desc FROM DANCE_TYPE ", conn);
                comm = new SqlCommand("SELECT Dance_TYpe_ID FROM DANCE_TYPE ", conn);


                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    cmbDanceType.Items.Add(reader.GetValue(0));
                }

                conn.Close();





            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while loading words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private int getTypeID(string type)
        {
            int Dance_Type_ID = 0;
            string query = "SELECT Dance_Type_ID FROM DANCE_TYPE WHERE Type_Desc = " + type;

            using (SqlConnection con = new SqlConnection(Constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Dance_Type_ID = (int)reader["Dance_Type_ID"];
                    }

                    con.Close();
                }
            }

            return Dance_Type_ID;
        }*/

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (rdbAdd.Checked)
                {
                    string fname = txtFName.Text;     //give values to variables
                    string lname = txtLName.Text;
                    string num = txtCellNum.Text;
                    string email = txtEmail.Text;

                    

                    if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(num) || string.IsNullOrEmpty(email) || cmbDanceType.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please fill in all the fields", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }



                    var confirm = MessageBox.Show("Are you sure you want to add this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        
                        int type = int.Parse(cmbDanceType.SelectedItem.ToString());
                        //int typeID = getTypeID(type);


                        conn.Open();
                        String ins = $"INSERT INTO TEACHER (Dance_Type_ID, Teach_FName, Teach_LName, Teach_Cellphone, Teach_Email) VALUES (@type, @fname, @lname, @cell, @email)";
                        comm = new SqlCommand(ins, conn);
                        comm.Parameters.AddWithValue("@type", type);
                        comm.Parameters.AddWithValue("@fname", fname);
                        comm.Parameters.AddWithValue("@lname", lname);
                        comm.Parameters.AddWithValue("@cell", num);
                        comm.Parameters.AddWithValue("@email", email);

                        adapt = new SqlDataAdapter();
                        adapt.InsertCommand = comm;
                        adapt.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                        String var = "SELECT * FROM TEACHER";
                        Display(var);

                        MessageBox.Show("Added successfully");
                    }
                }
                else if (rdbRemove.Checked)
                {
                    int id = int.Parse(txtID.Text);

                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        MessageBox.Show("Please enter an ID", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var confirm = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        if (int.TryParse(txtID.Text, out id))
                        {
                            conn.Open();

                            string var = "DELETE FROM TEACHER WHERE Teacher_ID = @num";     //Delete certain row based on teacher ID

                            comm = new SqlCommand(var, conn);
                            comm.Parameters.AddWithValue("@num", id);
                            int result = comm.ExecuteNonQuery();
                            conn.Close();


                            if (result > 0)
                            {
                                MessageBox.Show("Successfully deleted");

                            }
                            else
                            {
                                MessageBox.Show("Unsuccessfully deleted");
                            }



                            var = "SELECT * FROM TEACHER";
                            Display(var);
                        }
                        else 
                        {
                            MessageBox.Show("Please enter a valid ID number");
                        }
                    }

                }
                else if (rdbUpdate.Checked)
                {
                    int id;

                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        MessageBox.Show("Please enter an ID", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var confirm = MessageBox.Show("Are you sure you want to update this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        if (int.TryParse(txtID.Text, out id))
                        {
                            
                            
                                //string var = "SELECT * FROM TEACHER WHERE Teacher_id = " + id;
                                //Display(var);

                                conn.Open();

                                //string change = txtFName.Text;
                                string fname = txtFName.Text;     //give values to variables
                                string lname = txtLName.Text;
                                string num = txtCellNum.Text;
                                string email = txtEmail.Text;
                                int type = int.Parse(cmbDanceType.SelectedItem.ToString());
                            
                            
                                string up = @"UPDATE TEACHER SET Dance_Type_ID = @type, Teach_FName = @fname, Teach_LName = @lname, Teach_Cellphone = @cell, Teach_Email = @email WHERE Teacher_ID = @id";



                            comm = new SqlCommand(up, conn);
                                comm.Parameters.AddWithValue("@type", type);
                                comm.Parameters.AddWithValue("@fname", fname);
                                comm.Parameters.AddWithValue("@lname", lname);
                                comm.Parameters.AddWithValue("@cell", num);
                                comm.Parameters.AddWithValue("@email", email);
                                comm.Parameters.AddWithValue("@id", id);
                            

                            comm.ExecuteNonQuery();
                           
                            conn.Close();
                            
                                string var = "SELECT * FROM TEACHER";
                                Display(var);
                                MessageBox.Show("Updated successfully");

                            

                        }

                        else
                        {
                            MessageBox.Show("Please enter a valid ID number");
                        }
                    }
                }
                
                else
                {
                    MessageBox.Show("Please choose a option from 'Maintain Teachers'");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while loading words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            txtCellNum.Clear();
            txtFName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            cmbDanceType.SelectedIndex = -1;
            txtID.Clear();
        }

        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            //Enable and disable labels and inputs
            txtCellNum.Clear();
            txtFName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            cmbDanceType.SelectedIndex = -1;
            txtID.Clear();

            lblID.Enabled = false;
            lblLName.Enabled = true;
            lblCellNum.Enabled = true;
            lblEmail.Enabled = true;
            lblFName.Enabled = true;
            lblDanceType.Enabled = true;


            txtCellNum.Enabled = true;
            txtFName.Enabled = true;
            txtEmail.Enabled = true;
            txtLName.Enabled = true;
            cmbDanceType.Enabled = true;
            txtID.Enabled = false;
        }

        private void rdbRemove_CheckedChanged(object sender, EventArgs e)
        {

            //Enable and disable labels and inputs

            txtCellNum.Clear();
            txtFName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            cmbDanceType.SelectedIndex = -1;
            txtID.Clear();

            lblID.Enabled = true;
            lblLName.Enabled = false;
            lblCellNum.Enabled = false;
            lblEmail.Enabled = false;
            lblFName.Enabled = false;
            lblDanceType.Enabled = false;

            txtCellNum.Enabled = false;
            txtFName.Enabled = false;
            txtEmail.Enabled = false;
            txtLName.Enabled = false;
            cmbDanceType.Enabled = false;
            txtID.Enabled = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn log = new frmLogIn();
            log.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            //Enable and disable labels and inputs

            txtCellNum.Clear();
            txtFName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            cmbDanceType.SelectedIndex = -1;
            txtID.Clear();

            lblID.Enabled = true;
            lblLName.Enabled = true;
            lblCellNum.Enabled = true;
            lblEmail.Enabled = true;
            lblFName.Enabled = true;
            lblDanceType.Enabled = true;


            txtCellNum.Enabled = true;
            txtFName.Enabled = true;
            txtEmail.Enabled = true;
            txtLName.Enabled = true;
            cmbDanceType.Enabled = true;
            txtID.Enabled = true;
        }
       
            private void txtID_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtID.Text, out id))
            {
                string var = "SELECT * FROM TEACHER WHERE Teacher_id = " + id;
                Display(var);
                conn.Open();
                //string searchString = "SELECT t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";
                string searchString = @"SELECT * FROM TEACHER WHERE Teacher_ID = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(searchString, conn);
                data.Clear();
                adapter.Fill(data, "TEACHER");

                conn.Close();

                if (data.Tables["TEACHER"].Rows.Count > 0)
                {
                    DataRow row = data.Tables["Teacher"].Rows[0];
                    txtFName.Text = row["Teach_FName"].ToString();
                    txtLName.Text = row["Teach_LName"].ToString();
                    txtEmail.Text = row["Teach_Email"].ToString();
                    txtCellNum.Text = row["Teach_Cellphone"].ToString();
                    cmbDanceType.SelectedItem = row["Dance_Type_ID"];

                    //dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                }

                dgvTeachers.DataSource = data.Tables["TEACHER"].DefaultView;
            }
            else
            {
                string var = "SELECT * FROM TEACHER";
                Display(var);
            }

           
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

namespace CMPG223_18
{
    public partial class frmTeachers : Form
    {
        public frmTeachers()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> Naledi
