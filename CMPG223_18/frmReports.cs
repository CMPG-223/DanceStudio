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
    public partial class frmReports : Form
    {
        //connection
        public String connectString = "Data Source=LAPTOP-E2JAFDM7\\SQLEXPRESS;Initial Catalog=DanceStudio;Integrated Security=True";
        //other public var
        public SqlConnection con = new SqlConnection();
        public SqlCommand command;
        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter;
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            rdbTop3Dance.Checked = true;
            rdbTop3Dance_CheckedChanged(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain Mainfrm = new frmMain();
            Mainfrm.Show();
        }

        private void rdbTop3Dance_CheckedChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (rdbTop3Dance.Checked)
            {
                //Disable sorting because not neccesary
                cmbSortBy.Enabled = false;
                lblSort.Enabled = false;

                lblExplain.Text = "Dance types are ranked by number of dancers taking it";

                //Display top 3 dance types
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string showTop3 = @"With RankedDanceTypes AS (SELECT COUNT(ec.Dancer_ID) AS [Number of Students], dt.Type_Desc AS [Dance Type], " +
                                             "ROW_NUMBER() OVER (ORDER BY COUNT(ec.Dancer_ID) DESC) AS Rank " +
                                             "FROM Dance_Type dt " +
                                             "JOIN [Class] c ON dt.Dance_Type_ID = c.Dance_Type_ID JOIN Enrollment_Class ec ON c.Class_ID = ec.Class_ID " +
                                             "WHERE c.Class_DateTime BETWEEN @startDate AND @endDate " +
                                             " GROUP BY dt.Type_Desc ) " +
                                             "SELECT TOP 3 Rank, [Dance Type], [Number of Students] FROM RankedDanceTypes ";

                        using (SqlCommand command = new SqlCommand(showTop3, con))
                        {
                            command.Parameters.AddWithValue("@startDate", startDate);
                            command.Parameters.AddWithValue("@endDate", endDate);

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            ds.Clear();
                            adapter.Fill(ds, "Dance_Type");

                            con.Close();

                            dgvReports.DataSource = ds.Tables["Dance_Type"].DefaultView;
                        }
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (rdbOutPay.Checked)
            {
                //Enable sorting
                cmbSortBy.Enabled = true;

                lblExplain.Text = "Dancers who owe us money and how much are displayed.";

                //Display outstanding payments
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string showReport = @"SELECT Dancer_FName, Dancer_LName, Dancer_Total_All_Classes, Total_Received,  " +
                                                "Dancer_Total_All_Classes - Total_Received AS [Outstanding] FROM Dancer " +
                                             "WHERE Dancer_Total_All_Classes - Total_Received > 0 " ;
                        SqlDataAdapter adapter = new SqlDataAdapter(showReport, con);
                        ds.Clear();
                        adapter.Fill(ds, "Dancer");

                        con.Close();

                        dgvReports.DataSource = ds.Tables["Dancer"].DefaultView;
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortBy.SelectedIndex == 0)
            {
                //alphabetical a-z
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string showReport = @"SELECT Dancer_FName, Dancer_LName, Dancer_Total_All_Classes, Total_Received,  " +
                                                "Dancer_Total_All_Classes - Total_Received AS [Outstanding] FROM Dancer " +
                                             "WHERE Dancer_Total_All_Classes - Total_Received > 0 " + 
                                             "ORDER BY Dancer_LName ASC, Dancer_FName ASC";
                        SqlDataAdapter adapter = new SqlDataAdapter(showReport, con);
                        ds.Clear();
                        adapter.Fill(ds, "Dancer");

                        con.Close();

                        dgvReports.DataSource = ds.Tables["Dancer"].DefaultView;
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (cmbSortBy.SelectedIndex == 1)
            {
                //alphabetical z-a
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string showReport = @"SELECT Dancer_FName, Dancer_LName, Dancer_Total_All_Classes, Total_Received,  " +
                                                "Dancer_Total_All_Classes - Total_Received AS [Outstanding] FROM Dancer " +
                                             "WHERE Dancer_Total_All_Classes - Total_Received > 0 " +
                                             "ORDER BY Dancer_LName DESC, Dancer_FName DESC";
                        SqlDataAdapter adapter = new SqlDataAdapter(showReport, con);
                        ds.Clear();
                        adapter.Fill(ds, "Dancer");

                        con.Close();

                        dgvReports.DataSource = ds.Tables["Dancer"].DefaultView;
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (cmbSortBy.SelectedIndex == 2)
            {
                //outstanding most - least
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string showReport = @"SELECT Dancer_FName, Dancer_LName, Dancer_Total_All_Classes, Total_Received,  " +
                                                "Dancer_Total_All_Classes - Total_Received AS [Outstanding] FROM Dancer " +
                                             "WHERE Dancer_Total_All_Classes - Total_Received > 0 " +
                                             "ORDER BY Dancer_Total_All_Classes - Total_Received DESC";
                        SqlDataAdapter adapter = new SqlDataAdapter(showReport, con);
                        ds.Clear();
                        adapter.Fill(ds, "Dancer");

                        con.Close();

                        dgvReports.DataSource = ds.Tables["Dancer"].DefaultView;
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (cmbSortBy.SelectedIndex == 3)
            {
                //outstanding least - most
                try
                {
                    using (SqlConnection con = new SqlConnection(connectString))
                    {
                        con.Open();

                        string showReport = @"SELECT Dancer_FName, Dancer_LName, Dancer_Total_All_Classes, Total_Received,  " +
                                                "Dancer_Total_All_Classes - Total_Received AS [Outstanding] FROM Dancer " +
                                             "WHERE Dancer_Total_All_Classes - Total_Received > 0 " +
                                             "ORDER BY Dancer_Total_All_Classes - Total_Received ASC";
                        SqlDataAdapter adapter = new SqlDataAdapter(showReport, con);
                        ds.Clear();
                        adapter.Fill(ds, "Dancer");

                        con.Close();

                        dgvReports.DataSource = ds.Tables["Dancer"].DefaultView;
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report in queue for printing.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            rdbTop3Dance_CheckedChanged(sender, e);
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            rdbTop3Dance_CheckedChanged(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> Naledi
