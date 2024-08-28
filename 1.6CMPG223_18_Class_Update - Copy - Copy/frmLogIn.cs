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
            
            frmMain main = new frmMain();
            main.Show();
            //this.Hide();
            //this.Close();


        }
    }
}
