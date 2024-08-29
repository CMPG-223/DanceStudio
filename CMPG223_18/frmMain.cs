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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayments Paymentsfrm = new frmPayments();
            Paymentsfrm.Show();
            this.Hide();
        }

        private void btnDancers_Click(object sender, EventArgs e)
        {
            frmDancers DancerFrm = new frmDancers();
            DancerFrm.Show();
            this.Hide();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {

        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports ReportsFrm = new frmReports();
            ReportsFrm.Show();
            this.Hide();
        }

        private void btnEnrol_Click(object sender, EventArgs e)
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> Naledi
