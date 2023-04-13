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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FileworxApp
{

    public partial class frmPhoto : Form
    {
        #region Parameters
        public string btnSave
        {
            get
            {
                return this.btnPhotoSave.Text;
            }
            set
            {
                this.btnPhotoSave.Text = value;
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
        public frmPhoto()
        {
            InitializeComponent();
            this.tcPhoto.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.StartPosition= FormStartPosition.CenterScreen;
            this.txtPhotoBody.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.txtPhotoDescription.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.txtPhotoTitle.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.pbPhotoImage.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.txtPhotoBrowse.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnPhotoBrowse.Anchor = (AnchorStyles.Left | AnchorStyles.Top );
            this.btnPhotoCancel.Anchor = ( AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnPhotoSave.Anchor = (  AnchorStyles.Bottom | AnchorStyles.Right);

        }
        public frmPhoto(NewPhoto new_Photo)
        {
            InitializeComponent();
            this.tcPhoto.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);

            this.txtPhotoBody.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.txtPhotoDescription.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.txtPhotoTitle.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.pbPhotoImage.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.txtPhotoBrowse.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnPhotoBrowse.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            this.btnPhotoCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnPhotoSave.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.txtPhotoTitle.Text = new_Photo.Title;
            this.txtPhotoDescription.Text = new_Photo.Description;
            this.txtPhotoBody.Text = new_Photo.Body;
            this.txtPhotoBrowse.Text= new_Photo.ImagePath;
            this.pbPhotoImage.Image= new Bitmap(new_Photo.ImagePath);

        }
        #endregion

        #region Events 
        private void btnPhotoBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = @"c:\";
            fileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPhotoBrowse.Text = fileDialog.FileName;

                pbPhotoImage.Image = new Bitmap(fileDialog.FileName);
            }
        }


        private void btnPhotoSave_Click(object sender, EventArgs e)
        {
            clsphoto photo1 = new clsphoto();
            photo1.ClassID = 2;
            photo1.LastModifier = this.user;
            photo1.Name = txtPhotoTitle.Text;
            photo1.Description = txtPhotoDescription.Text;
            photo1.CreationDate = DateTime.Now.ToString();
            photo1.Body = txtPhotoBody.Text;

            if (btnPhotoSave.Text == "Edit")
            {
                var photoPath = Path.GetFileName(this.edit.Replace(@"\\", @"//"));
               
                photo1.Update();
                this.Close();

            }
            else
            {
                Guid id = Guid.NewGuid();
                photo1.ID = id.ToString();
                photo1.PhotoPath = filePath.PhotoPath + id + ".jpeg";
                if (pbPhotoImage.Image == null)
                {
                    MessageBox.Show("No picture added!");
                }
                else
                {
                    pbPhotoImage.Image.Save(filePath.PhotoPath + id + ".jpeg", ImageFormat.Jpeg);
                    photo1.Create();
                    this.Hide();
                }

            }

        }

        private void btnPhotoCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

       

    }
}
