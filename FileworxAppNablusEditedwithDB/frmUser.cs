using FileworxApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileworxApp
{
    public partial class frmUser : Form
    {
        #region Parameters
        public string btnSave
        {
            get
            {
                return this.btnUserSave.Text;
            }
            set
            {
                this.btnUserSave.Text = value;
            }
        }
        public string ID = null;
        public string edit
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.ID = value;
            }
        }
        Paths filePath = new Paths();
        #endregion

        #region Constructors
        public frmUser()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        private void btnUserSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtUserPassword.Text))
            {
                MessageBox.Show("Username or password is empty! ");
            }
            else if (txtConfirmPass.Text != txtUserPassword.Text)
            {
                MessageBox.Show("Password and confirm password don't match.");
            }
            else
            {
               clsUser user= new clsUser();
                user.ID = Guid.NewGuid().ToString();
                user.Name= txtUserName.Text;
                user.FullName= txtUserLoginName.Text;
                user.Password = txtUserPassword.Text;
                user.CreationDate = DateTime.Now.ToString();
               
                user.ClassID = 3;
                user.Create();
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
        
        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void Fileworx_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason == CloseReason.UserClosing)
            {
               
                    Application.Exit();

            }
        }
        #endregion


        
    }
}
