using System;
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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string PasswordAdmin = "AdminPassword123", UsernameAdmin= "Receptionist";
            string PasswordOwner = "PasswordOwner321", UsernameOwner = "Owner";

            if ((txtUsername.Text == UsernameAdmin) && (txtPassword.Text == PasswordAdmin))
            {
                Form Main = new frmMain();
                Main.ShowDialog();
                this.Close();   
            }else if ((txtUsername.Text == UsernameOwner) && (txtPassword.Text == PasswordOwner))
            {
                Form Reports = new frmReports();
                Reports.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

        }
    }
}
