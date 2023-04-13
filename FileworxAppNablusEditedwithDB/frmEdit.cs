using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileworxApp
{
    public partial class frmEdit : Form
    {
        public string id;
        public frmEdit()
        {
            InitializeComponent();
        }
        public frmEdit(string username, string fullname, string password)
        {
            InitializeComponent();
            txtUserListUserName.Text = username;
            txtUserListPassword.Text = password;
            txtUserListFullName.Text = fullname;
        }
        private void frmEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserListPassword.Text == txtUserListConfirm.Text)
            {
                Classes.clsUser user = new Classes.clsUser();
                user.ID = this.id;
                user.Update();
                this.Close();
                MessageBox.Show("changes saved successfully.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
