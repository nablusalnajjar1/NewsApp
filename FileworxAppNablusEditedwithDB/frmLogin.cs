using FileworxApp.Classes;
using FileworxObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileworxApp
{
    public partial class frmLogin : Form
    {
        Paths filePath = new Paths();
         
        #region Events
        public frmLogin()
        {
            InitializeComponent();
        }

        private void llblCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Application.Exit();
            this.Hide();
            frmUser user = new frmUser();
            user.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var pass = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtAdminPassword.Text));
            clsUser user = new clsUser();
            using (var entities=new FileworxAppEntities1())
            {
                user.ID = (from p in entities.BusinessObjects where p.Name == txtUsername.Text select p.ID).FirstOrDefault() ;
                user.Read();
            }
                
                if (user.ID == null)
                {
                    MessageBox.Show("No account found, Please signup.");
                }
                else if (user.Password == pass)
                {
                    this.Hide();
                    frmFileworx fileworx = new frmFileworx(user.ID);
                    fileworx.Show();
                }
                else
                {
                    MessageBox.Show("Password is wrong");
                }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
