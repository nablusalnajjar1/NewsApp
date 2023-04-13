using FileworxApp.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace FileworxApp
{
    public partial class frmNews : Form
    {
        #region Definitions
        Paths filePath = new Paths();
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
        public string btnSave
        {
            get
            {
                return this.btnNewsSave.Text;
            }
            set
            {
                this.btnNewsSave.Text = value;
            }
        }
        #endregion

        #region Constructors

        public frmNews()
        {
            InitializeComponent();


        }

        public frmNews(NewNews new_News)
        {
            InitializeComponent();
            this.txtNewsTitle.Text = new_News.Title;
            this.txtNewsDescription.Text = new_News.Description;
            this.cbNewsCategory.Text = new_News.Category;
            this.txtNewsBody.Text = new_News.Body;
            ID = new_News.ID;


        }

        #endregion

        #region Events
        private void btnNewsSave_Click(object sender, EventArgs e)
        {
            frmFileworx fileworx = new frmFileworx(ID);
            clsNews news = new clsNews();
            news.ClassID = 1;
            news.LastModifier = this.user;
            news.Name = txtNewsTitle.Text;
            news.Description = txtNewsDescription.Text;
            news.CreationDate = DateTime.Now.ToString();
            news.Body = txtNewsBody.Text;
            if (btnNewsSave.Text == "Edit")
            {
                var Id = Path.GetFileName(ID.Replace(@"\\", @"//"));
                news.Update();
                this.Close();
                fileworx.MouseHover += new System.EventHandler(fileworx.Fileworx_Load);

            }
            else
            {
                Guid id = Guid.NewGuid();
                news.ID = id.ToString();
                news.Category=cbNewsCategory.Text;
                news.Create();
                this.Hide();
                fileworx.MouseHover += new System.EventHandler(fileworx.Fileworx_Load);

            }

            fileworx.MouseHover += new System.EventHandler(fileworx.Fileworx_Load);

        }

        private void Fileworx_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnNewsCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region  Methods

        private int Category(string category)
        {
            switch (category)
            {
                case "Health": return 1; break;
                case "Politics": return 2; break;
                case "Sports": return 3; break;
                default: return 4;
            }
        }

    #endregion

    }}

