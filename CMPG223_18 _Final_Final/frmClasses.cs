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

        private int getClassID(string desc)
        {
            int id = 0;

            string query = "SELECT Class_ID FROM CLASS WHERE Class_Description = @desc";
            using (SqlConnection con = new SqlConnection(Constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("desc", desc);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        id = (int)reader["Class_ID"];
                    }

                    conn.Close();
                }
            }


            return id;
        }

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

        private int getTypeID(string type)
        {
            int Dance_Type_ID = 0;
            string query = @"SELECT Dance_Type_ID FROM DANCE_TYPE WHERE Type_Desc = @type";

            using (SqlConnection con = new SqlConnection(Constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@type", type);

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
        }

        private int getTeachID(string fname)
        {
            int id = 0;
            string query = @"SELECT Teacher_ID FROM TEACHER WHERE Teach_FName = @fname";

            using (SqlConnection con = new SqlConnection(Constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fname", fname);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        id = (int)reader["Teacher_ID"];
                    }

                    con.Close();
                }
            }

            return id;
        }
        private int getExpID(string desc)
        {
            int id = 0;
            string query = @"SELECT exp_ID FROM EXPERIENCE_LEVEL WHERE exp_Desc = @desc";

            using (SqlConnection con = new SqlConnection(Constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@desc", desc);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        id = (int)reader["exp_ID"];
                    }

                    con.Close();
                }
            }

            return id;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdbAdd.Checked)
                {
                    decimal price;
                    if (cmbDanceType.SelectedIndex == -1)
                    {
                        typeError.SetError(cmbDanceType, "Please fill the class's dance type.");
                        cmbDanceType.SelectedIndex = -1;

                        return;
                    }
                    else
                    {
                        typeError.Clear();
                    }
                    if (cmbExpLvl.SelectedIndex == -1)
                    {
                        expError.SetError(cmbExpLvl, "Please fill the class's experience level.");
                        cmbExpLvl.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        expError.Clear();
                    }
                    if (cmbTeacher.SelectedIndex == -1)
                    {
                        teachError.SetError(cmbTeacher, "Please fill the class's teahcer.");
                        cmbTeacher.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        teachError.Clear();
                    }
                   
                    
                    if (string.IsNullOrEmpty(txtHours.Text))
                    {
                        timeError.SetError(txtHours, "Please fill the class's time.");
                        txtHours.Text = "";
                        return;


                    }
                    else
                    {
                        timeError.Clear();

                    }
                    if (string.IsNullOrEmpty(txtMinutes.Text) )
                    {
                        timeError.SetError(txtMinutes, "Please fill the class's time.");
                        txtMinutes.Text = "";
                        return;

                    }
                    else
                    {
                        timeError.Clear();
                    }
                    
                    if (dtpClassDate.Value.Date < DateTime.Today)
                    {
                        dateError.SetError(dtpClassDate, "Please choose a class date today or onwards");
                        dtpClassDate.Value = DateTime.Today;
                        return;
                    }
                    else
                    {
                        dateError.Clear();
                    }
                    if (string.IsNullOrEmpty(txtClassPrice.Text))
                    {
                        priceError.SetError(txtClassPrice, "Please fill the class's price.");

                        txtClassPrice.Text = "";



                        return;
                    }
                    else
                    {
                        priceError.Clear();

                        if (!decimal.TryParse(txtClassPrice.Text, out price))
                        {
                            priceError.SetError(txtClassPrice, "Please fill a valid price.");

                            txtClassPrice.Text = "";
                            return;
                        }
                        else//give values to variables
                        {
                            priceError.Clear();
                            price = decimal.Parse(txtClassPrice.Text);
                        }
;
                    }
                    if (string.IsNullOrEmpty(txtDescr.Text))
                    {
                        descError.SetError(txtDescr, "Please fill the class's description.");
                        txtDescr.Text = "";

                        return;
                    }
                    else
                    {
                        descError.Clear();
                    }



                    var confirm = MessageBox.Show("Are you sure you want to add this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        //give values to variables
                      
                       


                        DateTime date = dtpClassDate.Value.Date;

                       

                        if (string.IsNullOrEmpty(txtHours.Text) || string.IsNullOrEmpty(txtMinutes.Text))
                        {
                            MessageBox.Show("Enter both Hours and Minutes for ' Duration'");
                        }

                        TimeSpan duration = new TimeSpan(int.Parse(txtHours.Text), int.Parse(txtMinutes.Text), 0);

                        string typed = cmbDanceType.SelectedItem.ToString();
                        int type = getTypeID(typed);
                        string expD = cmbExpLvl.SelectedItem.ToString();
                        int exp = getExpID(expD);
                        
                        string tID = cmbTeacher.SelectedItem.ToString();
                        int teacher = getTeachID(tID);

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
                        string var = "SELECT c.Class_ID ,td.Type_Desc, t.Teach_FName, e.exp_Desc, c.Class_Description, c.Class_Duration, c.Class_DateTime, c.Class_Cost  FROM CLASS c INNER JOIN DANCE_TYPE td ON c.Dance_Type_ID = td.Dance_Type_ID INNER JOIN TEACHER t ON c.Teacher_ID = t.Teacher_ID INNER JOIN EXPERIENCE_LEVEL e ON c.exp_ID = e.exp_ID";
                        Display(var);
                        MessageBox.Show("Added successfully");
                    }
                }
                
                else if (rdbRemove.Checked)
                {
                    
                    var confirm = MessageBox.Show("Are you sure you want to delete this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        int id = getClassID(txtDescr.Text);

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



                        var = "SELECT c.Class_ID ,td.Type_Desc, t.Teach_FName, e.exp_Desc, c.Class_Description, c.Class_Duration, c.Class_DateTime, c.Class_Cost  FROM CLASS c INNER JOIN DANCE_TYPE td ON c.Dance_Type_ID = td.Dance_Type_ID INNER JOIN TEACHER t ON c.Teacher_ID = t.Teacher_ID INNER JOIN EXPERIENCE_LEVEL e ON c.exp_ID = e.exp_ID";
                        Display(var);

                    }
                }
                

                else if (rdbUpdate.Checked)
                {
                    int id;
                    decimal price;
                    if (cmbDanceType.SelectedIndex == -1)
                    {
                        typeError.SetError(cmbDanceType, "Please fill the class's dance type.");
                        cmbDanceType.SelectedIndex = -1;

                        return;
                    }
                    else
                    {
                        typeError.Clear();
                    }
                    if (cmbExpLvl.SelectedIndex == -1)
                    {
                        expError.SetError(cmbExpLvl, "Please fill the class's experience level.");
                        cmbExpLvl.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        expError.Clear();
                    }
                    if (cmbTeacher.SelectedIndex == -1)
                    {
                        teachError.SetError(cmbTeacher, "Please fill the class's teahcer.");
                        cmbTeacher.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        teachError.Clear();
                    }


                    if (string.IsNullOrEmpty(txtHours.Text))
                    {
                        timeError.SetError(txtHours, "Please fill the class's time.");
                        txtHours.Text = "";
                        return;


                    }
                    else
                    {
                        timeError.Clear();

                    }
                    if (string.IsNullOrEmpty(txtMinutes.Text))
                    {
                        timeError.SetError(txtMinutes, "Please fill the class's time.");
                        txtMinutes.Text = "";
                        return;

                    }
                    else
                    {
                        timeError.Clear();
                    }

                    if (dtpClassDate.Value.Date < DateTime.Today)
                    {
                        dateError.SetError(dtpClassDate, "Please choose a class date today or onwards");
                        dtpClassDate.Value = DateTime.Today;
                        return;
                    }
                    else
                    {
                        dateError.Clear();
                    }
                    if (string.IsNullOrEmpty(txtClassPrice.Text))
                    {
                        priceError.SetError(txtClassPrice, "Please fill the class's price.");

                        txtClassPrice.Text = "";



                        return;
                    }
                    else
                    {
                        priceError.Clear();

                        if (!decimal.TryParse(txtClassPrice.Text, out price))
                        {
                            priceError.SetError(txtClassPrice, "Please fill a valid price.");

                            txtClassPrice.Text = "";
                            return;
                        }
                        else//give values to variables
                        {
                            priceError.Clear();
                            price = decimal.Parse(txtClassPrice.Text);
                        }
;
                    }
                    if (string.IsNullOrEmpty(txtDescr.Text))
                    {
                        descError.SetError(txtDescr, "Please fill the class's description.");
                        txtDescr.Text = "";

                        return;
                    }
                    else
                    {
                        descError.Clear();
                    }
                    var confirm = MessageBox.Show("Are you sure you want to update this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        id = getClassID(txtDescr.Text);
                            
                            
                            

                            //string change = txtFName.Text;
                           
                                string desc = txtDescr.Text;

                        string typed = cmbDanceType.SelectedItem.ToString();
                        int type = getTypeID(typed);
                        string tID = cmbTeacher.SelectedItem.ToString();
                        int teach = getTeachID(tID);
                        string expD = cmbExpLvl.SelectedItem.ToString();
                        int exp = getExpID(expD);
                        DateTime date = dtpClassDate.Value.Date;
                            
                          
                            TimeSpan time;
                            
                                time = new TimeSpan(int.Parse(txtHours.Text), int.Parse(txtMinutes.Text), 0);
                            

                           

                            conn.Open();
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

                        string var = "SELECT c.Class_ID ,td.Type_Desc, t.Teach_FName, e.exp_Desc, c.Class_Description, c.Class_Duration, c.Class_DateTime, c.Class_Cost  FROM CLASS c INNER JOIN DANCE_TYPE td ON c.Dance_Type_ID = td.Dance_Type_ID INNER JOIN TEACHER t ON c.Teacher_ID = t.Teacher_ID INNER JOIN EXPERIENCE_LEVEL e ON c.exp_ID = e.exp_ID";
                        Display(var);
                                MessageBox.Show("Updated successfully");
                            

                        
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
            txtClassPrice.Clear();
            txtHours.Clear();
            txtMinutes.Clear();
            txtDescr.Clear();
            cmbDanceType.SelectedIndex = -1;
            cmbExpLvl.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;

            lblClassPrice.Visible = true;
            lblDanceType.Visible = true;
            lblDateOfClass.Visible = true;
            lblDescription.Visible = true;
            lblDuration.Visible = true;
            lblExpLvl.Visible = true;
            lblHours.Visible = true;
            lblMinutes.Visible = true;
            lblTeacher.Visible = true;


            cmbExpLvl.Visible = true;
            cmbTeacher.Visible = true;
            txtClassPrice.Visible = true;
            txtDescr.Visible = true;
            dtpClassDate.Visible = true;
            txtHours.Visible = true;
            txtMinutes.Visible = true;
            cmbDanceType.Visible = true;
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            rdbAdd.Checked = false;
            rdbRemove.Checked = false;
            rdbUpdate.Checked = false;
            try
            {
                conn = new SqlConnection(Constr);       //When form load create connection
                conn.Open();
                conn.Close();
                //string var = "SELECT * FROM CLASS";
                string var = "SELECT c.Class_ID ,td.Type_Desc, t.Teach_FName, e.exp_Desc, c.Class_Description, c.Class_Duration, c.Class_DateTime, c.Class_Cost  FROM CLASS c INNER JOIN DANCE_TYPE td ON c.Dance_Type_ID = td.Dance_Type_ID INNER JOIN TEACHER t ON c.Teacher_ID = t.Teacher_ID INNER JOIN EXPERIENCE_LEVEL e ON c.exp_ID = e.exp_ID";

                Display(var);

                conn.Open();
                cmbDanceType.Items.Clear();



                comm = new SqlCommand("SELECT Type_Desc FROM DANCE_TYPE ", conn);


                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    cmbDanceType.Items.Add(reader.GetValue(0));
                }
                conn.Close();
                conn.Open();

                cmbTeacher.Items.Clear();


                comm = new SqlCommand("SELECT Teach_FName FROM TEACHER ", conn);


                reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    cmbTeacher.Items.Add(reader.GetValue(0));
                }
                conn.Close();
                conn.Open();

                cmbExpLvl.Items.Clear();
                comm = new SqlCommand("SELECT exp_Desc FROM EXPERIENCE_LEVEL ", conn);


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
            deleteTip.SetToolTip(rdbRemove, "Double click on table to select class to delete");


            txtClassPrice.Clear();
            txtHours.Clear();
            txtMinutes.Clear();
            txtDescr.Clear();
            cmbDanceType.SelectedIndex = -1;
            cmbExpLvl.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;



            lblClassPrice.Visible = false;
            lblDanceType.Visible = false;
            lblDateOfClass.Visible = false;
            lblDescription.Visible = true;
            lblDuration.Visible = false;
            lblExpLvl.Visible = false;
            lblHours.Visible = false;
            lblMinutes.Visible = false;
            lblTeacher.Visible = false;


            cmbExpLvl.Visible = false;
            cmbTeacher.Visible = false;
            txtClassPrice.Visible = false;
            txtDescr.Visible = true;
            dtpClassDate.Visible = false;
            txtHours.Visible = false;
            txtMinutes.Visible = false;
            cmbDanceType.Visible = false;

        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {

            updateTip.SetToolTip(rdbUpdate, "Double click on table to select class to update");

            txtClassPrice.Clear();
            txtHours.Clear();
            txtMinutes.Clear();
            txtDescr.Clear();
            cmbDanceType.SelectedIndex = -1;
            cmbExpLvl.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;


            lblClassPrice.Visible = true;
            lblDanceType.Visible = true;
            lblDateOfClass.Visible = true;
            lblDescription.Visible = true;
            lblDuration.Visible = true;
            lblExpLvl.Visible = true;
            lblHours.Visible = true;
            lblMinutes.Visible = true;
            lblTeacher.Visible = true;


            cmbExpLvl.Visible = true;
            cmbTeacher.Visible = true;
            txtClassPrice.Visible = true;
            txtDescr.Visible = true;
            dtpClassDate.Visible = true;
            txtHours.Visible = true;
            txtMinutes.Visible = true;
            cmbDanceType.Visible = true;
        }

        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn log = new frmLogIn();
            log.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string var = "SELECT c.Class_ID ,td.Type_Desc, t.Teach_FName, e.exp_Desc, c.Class_Description, c.Class_Duration, c.Class_DateTime, c.Class_Cost  FROM CLASS c INNER JOIN DANCE_TYPE td ON c.Dance_Type_ID = td.Dance_Type_ID INNER JOIN TEACHER t ON c.Teacher_ID = t.Teacher_ID INNER JOIN EXPERIENCE_LEVEL e ON c.exp_ID = e.exp_ID WHERE Class_Description LIKE '" + txtSearch.Text + "%'";

                //string var = "SELECT * FROM CLASS WHERE Class_Description LIKE '" + txtSearch.Text + "%'";        //Display info in listbox based on charcters typed for movie name
                Display(var);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while loading words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtClassPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClasses_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //getting thee row selected
                DataGridViewRow row = dgvClasses.Rows[e.RowIndex];

                //getting the dancer id from the selected row
                int id = Convert.ToInt32(row.Cells["Class_ID"].Value);
                conn.Open();
                string searchString = "SELECT c.Class_ID ,td.Type_Desc, t.Teach_FName, e.exp_Desc, c.Class_Description, c.Class_Duration, c.Class_DateTime, c.Class_Cost  FROM CLASS c INNER JOIN DANCE_TYPE td ON c.Dance_Type_ID = td.Dance_Type_ID INNER JOIN TEACHER t ON c.Teacher_ID = t.Teacher_ID INNER JOIN EXPERIENCE_LEVEL e ON c.exp_ID = e.exp_ID WHERE Class_ID = '" + id + "'";
                //string searchString = @"SELECT * FROM CLASS WHERE Class_ID = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(searchString, conn);
                data.Clear();
                adapter.Fill(data, "CLASS");

                conn.Close();

                if (data.Tables["CLASS"].Rows.Count > 0)
                {
                    DataRow rows = data.Tables["CLASS"].Rows[0];
                    txtClassPrice.Text = rows["Class_Cost"].ToString();
                    txtDescr.Text = rows["Class_Description"].ToString();


                    string time = rows["Class_Duration"].ToString();
                    string[] split = time.Split(':');

                    txtHours.Text = split[0];


                    txtMinutes.Text = split[1];

                    cmbDanceType.SelectedItem = rows["Type_Desc"].ToString();
                    cmbExpLvl.SelectedItem = rows["exp_Desc"].ToString();
                    cmbTeacher.SelectedItem = rows["Teach_FName"].ToString();
                    dtpClassDate.Value = Convert.ToDateTime(rows["Class_DateTime"]);

                    //dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                }
                string var = "SELECT c.Class_ID ,td.Type_Desc, t.Teach_FName, e.exp_Desc, c.Class_Description, c.Class_Duration, c.Class_DateTime, c.Class_Cost  FROM CLASS c INNER JOIN DANCE_TYPE td ON c.Dance_Type_ID = td.Dance_Type_ID INNER JOIN TEACHER t ON c.Teacher_ID = t.Teacher_ID INNER JOIN EXPERIENCE_LEVEL e ON c.exp_ID = e.exp_ID";
                Display(var);

            }
        }
    }
}
