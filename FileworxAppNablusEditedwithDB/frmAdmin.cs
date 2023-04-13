using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileworxApp
{
    public partial class frmAdmin : Form
    {
        public string user;
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtAdminUsername.Text=="admin" && txtAdminPassword.Text == "admin@123")
            {
               
                frmUserList form = new frmUserList();
                form.user=this.user;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not Valid Credentials");
            }
        }

    }
}
