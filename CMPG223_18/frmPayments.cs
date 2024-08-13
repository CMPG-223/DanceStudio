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
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            InitializeComponent();
        }

        //connectString

        private void frmPayments_Load(object sender, EventArgs e)
        {
            //View data in datagridview

            try 
            {
                const = new SqlConnection(connectString);
                const.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Payments FROM dbName", con);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frm
        }
    }
}
