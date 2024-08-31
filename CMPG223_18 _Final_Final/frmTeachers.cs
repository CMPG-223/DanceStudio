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
            
            rdbAdd.Checked = false;
            rdbRemove.Checked = false;
            rdbUpdate.Checked = false;

            try
            {
                conn = new SqlConnection(Constr);       //When form load create connection
                conn.Open();
                conn.Close();
                string var = "SELECT t.Teacher_ID, t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";

                //string var = "SELECT * FROM TEACHER";
                Display(var);

                conn.Open();
                cmbDanceType.Items.Clear();

                

                comm = new SqlCommand("SELECT Type_Desc FROM DANCE_TYPE ", conn);
                //comm = new SqlCommand("SELECT Dance_TYpe_ID FROM DANCE_TYPE ", conn);


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

        private int getTeacherID(string firstName, string lastName)
        {
            int id = 0;
            
            string query = @"SELECT Teacher_ID FROM TEACHER WHERE Teach_FName = @fname AND Teach_LName = @lname";
            using (SqlConnection con = new SqlConnection(Constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);

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



        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (rdbAdd.Checked)
                {
                    string fname = txtFName.Text;     //give values to variables
                    string lname = txtLName.Text;
                    string num = "";
                    string email = txtEmail.Text;
                    

                    int cell;

                    

                    if (string.IsNullOrEmpty(fname) )
                    {
                        fnameError.SetError(txtFName, "Please fill the teacher's first name.");
                       
                        txtFName.Text = "";
                       

                        return;
                    }
                    else
                    {
                        fnameError.Clear();
                        
                    }
                    if (string.IsNullOrEmpty(lname) )
                    {
                        lnameError.SetError(txtLName, "Please fill the teacher's last name.");

                        txtLName.Text = "";
                        return;
                    }
                    else
                    {
                        lnameError.Clear();
                    }
                    if (string.IsNullOrEmpty(txtCellNum.Text))
                    {
                        cellError.SetError(txtCellNum, "Please fill the teacher's cellphone number.");
                        txtCellNum.Text = "";

                        return;

                    }
                    else
                    {

                        cellError.Clear();

                        if (!int.TryParse(txtCellNum.Text, out cell))
                        {
                            cellError.SetError(txtCellNum, "Please fill a valid teacher's cellphone number.");
                            txtCellNum.Clear();

                            return;
                        }
                        else
                        {
                            cellError.Clear();
                            num = txtCellNum.Text;
                            if (num.Length != 10)
                            {
                                cellError.SetError(txtCellNum, "Please fill a complete teacher's cellphone number.");
                                txtCellNum.Clear();

                                return;
                            }
                            else
                            {
                                cellError.Clear();
                            }
                        }

                    }
                    if (string.IsNullOrEmpty(email))
                    {
                        emailError.SetError(txtEmail, "Please fill the teacher's email.");
                        txtEmail.Text = "";
                        return;
                    }
                    else
                    {
                        emailError.Clear();


                    }
                    if (cmbDanceType.SelectedIndex == -1)
                    {
                        typeError.SetError(cmbDanceType, "Please fill the dance type.");
                        cmbDanceType.SelectedIndex = -1;
                        return;
                    }
                    else
                    {
                        typeError.Clear();

                    }
                    




                    var confirm = MessageBox.Show("Are you sure you want to add this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {

                        //int typeID = getTypeID(type);
                        string typed = cmbDanceType.SelectedItem.ToString();
                        int type = getTypeID(typed);

                        conn.Open();
                        string ins = $"INSERT INTO TEACHER (Dance_Type_ID, Teach_FName, Teach_LName, Teach_Cellphone, Teach_Email) VALUES (@type, @fname, @lname, @cell, @email)";
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
                        string var = "SELECT t.Teacher_ID, t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";
                        Display(var);

                        MessageBox.Show("Added successfully");
                    }
                }
                else if (rdbRemove.Checked)
                {
                    if (string.IsNullOrEmpty(txtFName.Text))
                    {
                        fnameError.SetError(txtFName, "Please fill the teacher's first name.");

                        txtFName.Text = "";


                        return;
                    }
                    else
                    {
                        fnameError.Clear();

                    }
                    if (string.IsNullOrEmpty(txtLName.Text))
                    {
                        lnameError.SetError(txtLName, "Please fill the teacher's last name.");

                        txtLName.Text = "";
                        return;
                    }
                    int id =getTeacherID(txtFName.Text, txtLName.Text);

                   

                    var confirm = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
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



                        //var = "SELECT * FROM TEACHER";
                        var = "SELECT t.Teacher_ID, t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";

                        Display(var);
                        
                        
                    }

                }
                else if (rdbUpdate.Checked)
                {
                    int id;



                    
                    var confirm = MessageBox.Show("Are you sure you want to update this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {

                        id = getTeacherID(txtFName.Text, txtLName.Text);
                        //txtID.Text = id.ToString();

                        //string var = "SELECT * FROM TEACHER WHERE Teacher_id = " + id;
                        //Display(var);



                        //string change = txtFName.Text;
                        string fname = txtFName.Text;     //give values to variables
                                string lname = txtLName.Text;
                            string num;//= txtCellNum.Text;
                                string email = txtEmail.Text;

                            int cell;// = AreDigitsOnly(num);



                        string typed = cmbDanceType.SelectedItem.ToString();
                        int type = getTypeID(typed);

                        if (string.IsNullOrEmpty(fname))
                            {
                                fnameError.SetError(txtFName, "Please fill the teacher's first name.");

                                txtFName.Text = "";


                                return;
                            }
                            else
                            {
                                fnameError.Clear();

                            }
                            if (string.IsNullOrEmpty(lname))
                            {
                                lnameError.SetError(txtLName, "Please fill the teacher's last name.");

                                txtLName.Text = "";
                                return;
                            }
                            else
                            {
                                lnameError.Clear();
                            }
                            if (string.IsNullOrEmpty(txtCellNum.Text))
                            {
                                cellError.SetError(txtCellNum, "Please fill the teacher's cellphone number.");
                                txtCellNum.Text = "";

                                return;

                            }
                            else
                            {

                                cellError.Clear();

                                if (!int.TryParse(txtCellNum.Text, out cell))
                                {
                                    cellError.SetError(txtCellNum, "Please fill a valid teacher's cellphone number.");
                                    txtCellNum.Clear();

                                    return;
                                }
                                else
                                {
                                    cellError.Clear();
                                    num = txtCellNum.Text;
                                    if (num.Length != 10)
                                    {
                                        cellError.SetError(txtCellNum, "Please fill a complete teacher's cellphone number.");
                                        txtCellNum.Clear();

                                        return;
                                    }
                                    else
                                    {
                                        cellError.Clear();
                                    }
                                }

                            }
                            if (string.IsNullOrEmpty(email))
                            {
                                emailError.SetError(txtEmail, "Please fill the teacher's email.");
                                txtEmail.Text = "";
                                return;
                            }
                            else
                            {
                                emailError.Clear();


                            }
                            if (cmbDanceType.SelectedIndex == -1)
                            {
                                typeError.SetError(cmbDanceType, "Please fill the dance type.");
                                cmbDanceType.SelectedIndex = -1;
                                return;
                            }
                            else
                            {
                                typeError.Clear();

                            }

                            conn.Open();
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

                        //string var = "SELECT * FROM TEACHER";
                        string var = "SELECT t.Teacher_ID, t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";

                        Display(var);
                                MessageBox.Show("Updated successfully");

                            

                        
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
        }

        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            //Enable and disable labels and inputs
            txtCellNum.Clear();
            txtFName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            cmbDanceType.SelectedIndex = -1;

            lblLName.Visible = true;
            lblCellNum.Visible = true;
            lblEmail.Visible = true;
            lblFName.Visible = true;
            lblDanceType.Visible = true;


            txtCellNum.Visible = true;
            txtFName.Visible = true;
            txtEmail.Visible = true;
            txtLName.Visible = true;
            cmbDanceType.Visible = true;
        }

        private void rdbRemove_CheckedChanged(object sender, EventArgs e)
        {
            deleteTip.SetToolTip(rdbRemove, "Double click on table to select teacher to delete");
            //Enable and disable labels and inputs

            txtCellNum.Clear();
            txtFName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            cmbDanceType.SelectedIndex = -1;

            lblLName.Visible = true;
            lblCellNum.Visible = false;
            lblEmail.Visible = false;
            lblFName.Visible = true;
            lblDanceType.Visible = false;

            txtCellNum.Visible = false;
            txtFName.Visible = true;
            txtEmail.Visible = false;
            txtLName.Visible = true;
            cmbDanceType.Visible = false;
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

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            //Enable and disable labels and inputs

            updateTip.SetToolTip(rdbUpdate, "Double click on table to select teacher to update");

            txtCellNum.Clear();
            txtFName.Clear();
            txtEmail.Clear();
            txtLName.Clear();
            cmbDanceType.SelectedIndex = -1;

            lblLName.Visible = true;
            lblCellNum.Visible = true;
            lblEmail.Visible = true;
            lblFName.Visible = true;
            lblDanceType.Visible = true;


            txtCellNum.Visible = true;
            txtFName.Visible = true;
            txtEmail.Visible = true;
            txtLName.Visible = true;
            cmbDanceType.Visible = true;
        }
       
            

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string var = "SELECT t.Teacher_ID, t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";

                //string var = "SELECT * FROM TEACHER WHERE Teach_FName LIKE '%" + txtSearch.Text + "%'";        //Display info in listbox based on charcters typed for movie name
                Display(var);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while loading words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvTeachers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //getting thee row selected
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];

                //getting the dancer id from the selected row
                int id = Convert.ToInt32(row.Cells["Teacher_ID"].Value);
                conn.Open();
                string searchString = "SELECT t.Teacher_ID, t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID WHERE Teacher_ID = '" + id + "'";
                //string searchString = @"SELECT * FROM TEACHER WHERE Teacher_ID = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(searchString, conn);
                data.Clear();
                adapter.Fill(data, "TEACHER");

                conn.Close();

                if (data.Tables["TEACHER"].Rows.Count > 0)
                {
                    DataRow rows = data.Tables["Teacher"].Rows[0];
                    txtFName.Text = rows["Teach_FName"].ToString();
                    txtLName.Text = rows["Teach_LName"].ToString();
                    txtEmail.Text = rows["Teach_Email"].ToString();
                   
                    txtCellNum.Text = (rows["Teach_Cellphone"].ToString()).Trim();

                    cmbDanceType.SelectedItem = rows["Type_Desc"].ToString();
                   // int  = rows["Dance_Type_ID"];

                    //dtp.Value = Convert.ToDateTime(row["Dancer_DoB"]);
                }
                string var = "SELECT t.Teacher_ID, t.Teach_FName, t.Teach_LName, t.Teach_Email, t.Teach_Cellphone, td.Type_Desc FROM TEACHER t INNER JOIN DANCE_TYPE td ON t.Dance_Type_ID = td.Dance_Type_ID";

                //string var = "SELECT * FROM TEACHER";
                Display(var);

            }
        }
    }
}
