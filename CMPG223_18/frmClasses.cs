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
    public partial class frmClasses : Form
    {
        private readonly string Constr = @"Data Source=LAPTOP-3GNEJ5LN\MSSQLSERVER01;Initial Catalog=DanceStudio;Integrated Security=True";
        SqlConnection conn;             //Declare variables
        SqlDataAdapter adapt;
        SqlCommand comm;
        DataSet data;
        SqlDataReader reader;


        public void Display(string var)         //method to display table in datagridview
        {
            conn.Open();
            adapt = new SqlDataAdapter();
            data = new DataSet();
            comm = new SqlCommand(var, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(data, "SourceTable");

            dgvClasses.DataSource = data;
            dgvClasses.DataMember = "SourceTable";


            conn.Close();
        }
        public frmClasses()
        {
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdbAdd.Checked)
                {

                    if (string.IsNullOrEmpty(txtClassPrice.Text) || string.IsNullOrEmpty(txtDescr.Text) || string.IsNullOrEmpty(txtHours.Text) || string.IsNullOrEmpty(txtMinutes.Text) || cmbDanceType.SelectedIndex == -1 || cmbExpLvl.SelectedIndex == -1 || cmbTeacher.SelectedIndex == -1|| dtpClassDate.Value.Date == DateTime.Today)
                    {
                        MessageBox.Show("Please fill in all the fields", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var confirm = MessageBox.Show("Are you sure you want to add this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        //give values to variables
                        decimal price = decimal.Parse(txtClassPrice.Text);


                        DateTime date = dtpClassDate.Value.Date;

                        if (date < DateTime.Today)
                        {
                            MessageBox.Show("Date out of bounds");
                            return;
                        }

                        if (string.IsNullOrEmpty(txtHours.Text) || string.IsNullOrEmpty(txtMinutes.Text))
                        {
                            MessageBox.Show("Enter both Hours and Minutes for ' Duration'");
                        }

                        TimeSpan duration = new TimeSpan(int.Parse(txtHours.Text), int.Parse(txtMinutes.Text), 0);

                        int type = int.Parse(cmbDanceType.SelectedItem.ToString());
                        int exp = int.Parse(cmbExpLvl.SelectedItem.ToString());
                        int teacher = int.Parse(cmbTeacher.SelectedItem.ToString());
                        string desc = txtDescr.Text;

                        conn.Open();
                        String ins = $"INSERT INTO CLASS (Dance_Type_ID, Teacher_ID, exp_ID, Class_Description, Class_Duration, Class_DateTime, Class_Cost) VALUES (@type, @teach, @exp, @desc, @duration, @date, @cost)";
                        comm = new SqlCommand(ins, conn);


                        comm.Parameters.AddWithValue("@type", type);
                        comm.Parameters.AddWithValue("@teach", teacher);
                        comm.Parameters.AddWithValue("@exp", exp);
                        comm.Parameters.AddWithValue("@desc", desc);
                        comm.Parameters.AddWithValue("@duration", duration);
                        comm.Parameters.AddWithValue("@date", date);
                        comm.Parameters.AddWithValue("@cost", price);


                        adapt = new SqlDataAdapter();
                        adapt.InsertCommand = comm;
                        adapt.InsertCommand.ExecuteNonQuery();

                        conn.Close();
                        String var = "SELECT * FROM CLASS";
                        Display(var);
                        MessageBox.Show("Added successfully");
                    }
                }
                
                else if (rdbRemove.Checked)
                {
                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        MessageBox.Show("Please enter an ID", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var confirm = MessageBox.Show("Are you sure you want to delete this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        int id = int.Parse(txtID.Text);

                        conn.Open();

                        string var = "DELETE FROM CLASS WHERE CLass_ID = @num";     //Delete certain row based on teacher ID

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



                        var = "SELECT * FROM CLASS";
                        Display(var);

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
                    var confirm = MessageBox.Show("Are you sure you want to update this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        if (int.TryParse(txtID.Text, out id))
                        {
                             conn.Open();

                                //string change = txtFName.Text;
                                decimal price = decimal.Parse(txtClassPrice.Text);     //give values to variables
                                string desc = txtDescr.Text;
                                
                                int type = int.Parse(cmbDanceType.SelectedItem.ToString());
                                int teach = int.Parse(cmbTeacher.SelectedItem.ToString());
                                int exp = int.Parse(cmbExpLvl.SelectedItem.ToString());
                            DateTime date = dtpClassDate.Value.Date;
                            if (date < DateTime.Today)
                            {
                                MessageBox.Show("Date out of bounds");
                                return;
                            }


                            TimeSpan time = new TimeSpan(int.Parse(txtHours.Text), int.Parse(txtMinutes.Text), 0);



                            //string up = @"UPDATE CLASS SET Teacher_ID = @type, Teach_FName = @fname, Teach_LName = @lname, Teach_Cellphone = @cell, Teach_Email = @email WHERE Class_ID = @id";
                            string up = @"UPDATE CLASS SET Dance_Type_ID = @type, Teacher_ID = @teach, exp_ID = @exp, Class_Description = @desc, Class_Duration = @duration, Class_DateTime = @date, Class_Cost = @cost WHERE Class_ID = @id";



                            comm = new SqlCommand(up, conn);
                            comm.Parameters.AddWithValue("@type", type);
                            comm.Parameters.AddWithValue("@teach", teach);
                            comm.Parameters.AddWithValue("@exp", exp);
                            comm.Parameters.AddWithValue("@desc", desc);
                            comm.Parameters.AddWithValue("@duration", time);
                            comm.Parameters.AddWithValue("@date", date);
                            comm.Parameters.AddWithValue("@cost", price);
                            comm.Parameters.AddWithValue("@id", id);

                            comm.ExecuteNonQuery();
                           
                            conn.Close();
                            
                                string var = "SELECT * FROM CLASS";
                                Display(var);
                                MessageBox.Show("Updated successfully");
                            

                        }
                        else
                        {
                            MessageBox.Show("Please enter an ID number");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please choose a option from 'Maintain CLasses'");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while loading words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            
            
            
            

            txtID.Clear();
            txtClassPrice.Clear();
            txtHours.Clear();
            txtMinutes.Clear();
            txtDescr.Clear();
            cmbDanceType.SelectedIndex = -1;
            cmbExpLvl.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;



        }

        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            lblClassPrice.Enabled = true;
            lblDanceType.Enabled = true;
            lblDateOfClass.Enabled = true;
            lblDescription.Enabled = true;
            lblDuration.Enabled = true;
            lblExpLvl.Enabled = true;
            lblHours.Enabled = true;
            lblID.Enabled = false;
            lblMinutes.Enabled = true;
            lblTeacher.Enabled = true;


            cmbExpLvl.Enabled = true;
            cmbTeacher.Enabled = true;
            txtClassPrice.Enabled = true;
            txtDescr.Enabled = true;
            dtpClassDate.Enabled = true;
            txtHours.Enabled = true;
            txtMinutes.Enabled = true;
            cmbDanceType.Enabled = true;
            txtID.Enabled = false;
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(Constr);       //When form load create connection
                conn.Open();
                conn.Close();
                string var = "SELECT * FROM CLASS";
                Display(var);

                conn.Open();
                cmbDanceType.Items.Clear();



                comm = new SqlCommand("SELECT Dance_Type_ID FROM DANCE_TYPE ", conn);


                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    cmbDanceType.Items.Add(reader.GetValue(0));
                }
                conn.Close();
                conn.Open();

                cmbTeacher.Items.Clear();


                comm = new SqlCommand("SELECT Teacher_ID FROM TEACHER ", conn);


                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    cmbTeacher.Items.Add(reader.GetValue(0));
                }
                conn.Close();
                conn.Open();

                cmbExpLvl.Items.Clear();
                comm = new SqlCommand("SELECT exp_ID FROM EXPERIENCE_LEVEL ", conn);


                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    cmbExpLvl.Items.Add(reader.GetValue(0));
                }

                conn.Close();





            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while loading words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbRemove_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Clear();
            txtClassPrice.Clear();
            txtHours.Clear();
            txtMinutes.Clear();
            txtDescr.Clear();
            cmbDanceType.SelectedIndex = -1;
            cmbExpLvl.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;



            lblClassPrice.Enabled = false;
            lblDanceType.Enabled = false;
            lblDateOfClass.Enabled = false;
            lblDescription.Enabled = false;
            lblDuration.Enabled = false;
            lblExpLvl.Enabled = false;
            lblHours.Enabled = false;
            lblID.Enabled = true;
            lblMinutes.Enabled = false;
            lblTeacher.Enabled = false;


            cmbExpLvl.Enabled = false;
            cmbTeacher.Enabled = false;
            txtClassPrice.Enabled = false;
            txtDescr.Enabled = false;
            dtpClassDate.Enabled = false;
            txtHours.Enabled = false;
            txtMinutes.Enabled = false;
            cmbDanceType.Enabled = false;
            txtID.Enabled = true;

        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Clear();
            txtClassPrice.Clear();
            txtHours.Clear();
            txtMinutes.Clear();
            txtDescr.Clear();
            cmbDanceType.SelectedIndex = -1;
            cmbExpLvl.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;


            lblClassPrice.Enabled = true;
            lblDanceType.Enabled = true;
            lblDateOfClass.Enabled = true;
            lblDescription.Enabled = true;
            lblDuration.Enabled = true;
            lblExpLvl.Enabled = true;
            lblHours.Enabled = true;
            lblID.Enabled = true;
            lblMinutes.Enabled = true;
            lblTeacher.Enabled = true;


            cmbExpLvl.Enabled = true;
            cmbTeacher.Enabled = true;
            txtClassPrice.Enabled = true;
            txtDescr.Enabled = true;
            dtpClassDate.Enabled = true;
            txtHours.Enabled = true;
            txtMinutes.Enabled = true;
            cmbDanceType.Enabled = true;
            txtID.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtID.Text, out id))
            {
                string var = "SELECT * FROM CLASS WHERE Class_ID = " + id;
                Display(var);

                conn.Open();
                //string searchString = "SELECT t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";
                string searchString = @"SELECT * FROM CLASS WHERE Class_ID = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(searchString, conn);
                data.Clear();
                adapter.Fill(data, "CLASS");

                conn.Close();

                if (data.Tables["CLASS"].Rows.Count > 0)
                {
                    DataRow row = data.Tables["CLASS"].Rows[0];
                    txtClassPrice.Text = row["Class_Cost"].ToString();
                    txtDescr.Text = row["Class_Description"].ToString();


                    string time = row["Class_Duration"].ToString();
                    string[] split = time.Split(':');

                    txtHours.Text =split[0];


                    txtMinutes.Text =split [1];
                    cmbDanceType.SelectedItem = row["Dance_Type_ID"];
                    cmbExpLvl.SelectedItem = row["exp_ID"];
                    cmbTeacher.SelectedItem = row["Teacher_ID"];
                    dtpClassDate.Value = Convert.ToDateTime(row["Class_DateTime"]);

                    //dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                }

                dgvClasses.DataSource = data.Tables["CLASS"].DefaultView;
            }
            else
            {
                string var = "SELECT * FROM CLASS";
                Display(var);
            }
        }
    }
}
