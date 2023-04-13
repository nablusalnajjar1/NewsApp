using FileworxApp.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FileworxApp
{
    public partial class frmFileworx : Form
    {
        #region Parameters
        Paths filePath = new Paths();
        public string user = null;
        public string User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
            }
        }
        #endregion

        #region Constructor 

        public frmFileworx()
        {
            
            InitializeComponent();

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.textBox3.Anchor = ( AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right );

            var newsList = new clsNewsQuery();
            newsList.Run();
            var photoList=new clsPhotoQuery();
            photoList.Run();
            foreach (var news in newsList.NewsList) 
            {
                string[] row = { news.Name, news.CreationDate, news.Description, news.LastModifier, news.ID };
                var listViewItem = new ListViewItem(row);
                lstvFileworx.Items.Add(listViewItem);
                //lstvFileworx.Items.Add(new ListViewItem(new string[] { news.Name, news.CreationDate, news.Description, news.LastModifier, news.ID }));
            }
            foreach (var photo in photoList.PhotoList)
            {
                lstvFileworx.Items.Add(new ListViewItem(new string[] { photo.Name, photo.CreationDate, photo.Description, photo.LastModifier, photo.ID }));
            }


        }
        public frmFileworx(string ID)
        {

            InitializeComponent();
            this.User= ID;
            frmPhoto photo= new frmPhoto();
            frmUserList form= new frmUserList();
            form.user= ID;
            photo.user = this.user;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.textBox3.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.lstvFileworx.View = View.Details;
            var businessObjects = new Classes.clsBusinessObject();
            var newsList = new clsNewsQuery();
            newsList.Run();
            var photoList = new clsPhotoQuery();
            photoList.Run();
            foreach (var news in newsList.NewsList)
            {
                string[] row = { news.Name, news.CreationDate, news.Description, news.LastModifier, news.ID };
                var listViewItem = new ListViewItem(row);
                lstvFileworx.Items.Add(listViewItem);
                //lstvFileworx.Items.Add(new ListViewItem(new string[] { news.Name, news.CreationDate, news.Description, news.LastModifier, news.ID }));
            }
            foreach (var photos in photoList.PhotoList)
            {
                lstvFileworx.Items.Add(new ListViewItem(new string[] { photos.Name, photos.CreationDate, photos.Description, photos.LastModifier, photos.ID }));
            }

        }
        #endregion

        #region Events
        private void lstvFileworx_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            lstvFileworx.FullRowSelect = true;
            
            if (lstvFileworx.SelectedIndices.Count > 0)
            {
                ListViewItem item = lstvFileworx.SelectedItems[0];
                DisplaySelectedData(item);
            }
        }

        private void lstvFileworx_DoubleClick(object sender, EventArgs e)
        {
            if (lstvFileworx.SelectedItems.Count == 1)

            {
                ListViewItem item = lstvFileworx.SelectedItems[0];
                EditListItem(item);
            }
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            
            user.Show();
        }
        
        private void photoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhoto photo=new frmPhoto();
            photo.User = this.User;
            photo.Show();
            
        }
        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNews news = new frmNews();
            news.User = this.User;
            news.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to logout?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("logged out.");
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void showListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin form = new frmAdmin();
            form.user= this.User;
            form.Show();
        }

        private void Fileworx_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string message = "Are you sure you want to delete this row?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ListViewItem item = lstvFileworx.SelectedItems[0];

               // ListViewItem item = lstUserList.SelectedItems[0];
                if (item.SubItems[0].Text == this.user)
                {
                    MessageBox.Show("Can't delete this user.");
                }
                else
                {
                    clsBusinessObject news = new clsBusinessObject();
                    news.ID = item.SubItems[3].Text;
                    news.Delete();
                    item.Remove();
                }

            }
        }
        private void Fileworx_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult infoBoxResult;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                infoBoxResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNoCancel);
                if (infoBoxResult == DialogResult.Yes)
                {
                    Application.Exit();
                  
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
       
        public void Fileworx_Load(object sender, EventArgs e)
        {

            lstvFileworx.Items.Clear();
          
        }
        #endregion

        #region Functions
        private string Category(string category)
        {
            switch (category)
            {
                case "1": return "Health"; break;
                case "2": return "Politics"; break;
                case "3": return "Sports"; break;
                default: return "General";
            }
        }
        private void DisplaySelectedData(ListViewItem item)
        {
            clsFile clsFile=new clsFile();
            clsFile.ID = item.SubItems[4].Text;
            clsFile.Read();

            this.txtFileworxTilte.Text = clsFile.Name;
            this.txtFileworxCreationDate.Text = clsFile.Description;
            this.txtFileworxTilte.ReadOnly = true;
            this.txtFileworxCreationDate.ReadOnly = true;

            if (clsFile.ClassID == 1) {
                clsNews clsnews = new clsNews();
                clsnews.ID = item.SubItems[4].Text;
                clsnews.Read();
                lblfileworxCategory.Visible = true;
                cbFileworxCategory.Visible = true;

                if (tbcFileworxPreview.TabCount > 1)
                {
                    this.Controls.Remove(tbcFileworxPreview.TabPages[1]);
                }
                this.textBox3.Text = clsnews.Body;
                this.cbFileworxCategory.Text = Category(clsnews.Category);

                if (this.tbcFileworxPreview.TabPages.Count > 1)
                {
                    this.tbcFileworxPreview.Controls.Remove(this.tbcFileworxPreview.TabPages[1]);
                }

            }
            else
            {
                clsphoto clsphoto = new clsphoto();
                clsphoto.ID = item.SubItems[4].Text;
                clsphoto.Read();
                TabPage newPage = new TabPage("Image");
                var pic = clsphoto.PhotoPath;

                newPage.BackgroundImageLayout = ImageLayout.Zoom;
                newPage.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;


                this.textBox3.Text = clsphoto.Body;

                if (this.tbcFileworxPreview.TabCount == 1)
                {
                    this.tbcFileworxPreview.TabPages.Add(newPage);
                }
                else
                {

                    this.tbcFileworxPreview.TabPages[1].BackgroundImage = Image.FromFile(pic);
                }
                cbFileworxCategory.Visible = false;
                lblfileworxCategory.Visible = false;
            }

            
        }
        private void EditListItem(ListViewItem item)
        {
            clsFile clsFile = new clsFile();
            clsFile.ID = item.SubItems[4].Text;
            clsFile.Read();
            if(clsFile.ClassID== 2)
            {
                NewPhoto newPhoto = new NewPhoto()
                {
                    Title = item.SubItems[1].Text,
                    Description = item.SubItems[3].Text,
                    Body = textBox3.Text,
                    ImagePath = item.Text.Substring(0, item.Text.Length - 3) + "jpeg"

                };
                frmPhoto photo = new frmPhoto(newPhoto);
                photo.Show();
                photo.btnSave = "Edit";
                photo.Text = "Edit Photo";
                photo.User = this.User;
                photo.edit = item.Text;
            }
            else
            {
                NewNews newNews = new NewNews()
                {
                    Title = item.SubItems[1].Text,
                    Description = item.SubItems[3].Text,
                    Category = this.cbFileworxCategory.Text,
                    Body = textBox3.Text
                };
                frmNews news = new frmNews(newNews);
                news.Text = "Edit News";
                news.Show();
                news.btnSave = "Edit";
                news.edit = item.Text;
                news.User = this.User;
            }
        
        }
        #endregion

    }
}
