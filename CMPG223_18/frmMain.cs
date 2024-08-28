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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDancers_Click(object sender, EventArgs e)
        {
            Form Dancers = new frmDancers();
            Dancers.ShowDialog();
            this.Close();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            Form Classes = new frmClasses();
            Classes.ShowDialog();
            this.Close();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            Form Teachers = new frmTeachers();
            Teachers.ShowDialog();
            this.Close();
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            Form Enrol = new frmEnrol();
            Enrol.ShowDialog();
            this.Close();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Form Pay = new frmPayments();
            Pay.ShowDialog();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form Reports = new frmReports();
            Reports.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form LogIn = new frmLogIn();
            LogIn.ShowDialog();
            this.Close();
        }
    }
}
