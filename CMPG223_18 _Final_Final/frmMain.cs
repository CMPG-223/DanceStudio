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

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            frmTeachers teach = new frmTeachers();
            teach.Show();
            this.Hide();
          
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            frmClasses classes = new frmClasses();
            classes.Show();
            this.Hide();
           
        }
    }
}
