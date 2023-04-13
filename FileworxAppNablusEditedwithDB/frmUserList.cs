using FileworxApp.Classes;
using Microsoft.Win32;
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
using static FileworxApp.frmLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FileworxApp
{
    public partial class frmUserList : Form
    {
        Paths filePath = new Paths();
        public string user = null;
        public frmUserList()
        {
            InitializeComponent();
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.MaximumSize= new Size(width, height);

            clsUsersQuery clsUsersQuery= new clsUsersQuery();
            clsUsersQuery.Run();
            var usersList = clsUsersQuery.UsersList;
            if (usersList == null)
            {
                lstUserList.Items.Add(new ListViewItem(new string[] { "", "", "", "", "" }));
            }
            else
            {
                foreach (var user in usersList)
                {
                        string[] row = { user.Name, user.FullName, user.Password, user.ID };
                        var listViewItem = new ListViewItem(row);
                        lstUserList.Items.Add(listViewItem);
                }
            }
        }

        #region Events



        private void lstvFileworx_DoubleClick(object sender, EventArgs e)
        {
            if (lstUserList.SelectedItems.Count == 1)

            {
                ListViewItem item = lstUserList.SelectedItems[0];
                // EditListItem(item); 

                frmEdit edit = new frmEdit(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text);
                edit.id = item.SubItems[3].Text;
                edit.Show();
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to delete this user?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ListViewItem item = lstUserList.SelectedItems[0];
                if (item.SubItems[0].Text == this.user)
                {
                    MessageBox.Show("Can't delete this user.");
                }
                else
                {
                    clsBusinessObject user = new clsBusinessObject();
                    user.ID = item.SubItems[3].Text;
                    user.Delete();
                    item.Remove();
                }

            }
        }
        private void lstUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUserList.FullRowSelect = true;

            if (lstUserList.SelectedIndices.Count > 0)
            {
                ListViewItem item = lstUserList.SelectedItems[0];
             //  DisplaySelectedData(item);
            }
        }
       
       

      

        private void Fileworx_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {

                Application.Exit();

            }
        }
        #endregion

        #region Methods

        //private void DisplaySelectedData(ListViewItem item)
        //{
        //    //FileworxAppEntities entities = new FileworxAppEntities();
        //    //var users = from p in entities.FXUsers
        //    //                where p.UserName == item.Text
        //    //                select new
        //    //                {
        //    //                    Username = p.UserName,
        //    //                    fullName = p.FullName,
        //    //                    password = p.Password,
        //    //                };
        //    FXUser fXUser=new FXUser();
        //    fXUser.ID = item.SubItems[1].Text;
        //    var user=fXUser.Read();
        //   // var z = users.ToList();
        //    txtUserListUserName.Text = user.UserName;
        //    txtUserListFullName.Text = user.FullName;
        //    txtUserListPassword.Text = user.Password;
        //}

        #endregion


     
    }
}


