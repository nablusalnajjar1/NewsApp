namespace FileworxApp
{
    partial class frmPhoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcPhoto = new System.Windows.Forms.TabControl();
            this.tbpFileDescription = new System.Windows.Forms.TabPage();
            this.btnPhotoCancel = new System.Windows.Forms.Button();
            this.btnPhotoSave = new System.Windows.Forms.Button();
            this.txtPhotoBody = new System.Windows.Forms.TextBox();
            this.lblPhotoBody = new System.Windows.Forms.Label();
            this.txtPhotoDescription = new System.Windows.Forms.TextBox();
            this.txtPhotoTitle = new System.Windows.Forms.TextBox();
            this.lblPhotoDescription = new System.Windows.Forms.Label();
            this.lblPhotoTitle = new System.Windows.Forms.Label();
            this.tbpImage = new System.Windows.Forms.TabPage();
            this.pbPhotoImage = new System.Windows.Forms.PictureBox();
            this.btnPhotoBrowse = new System.Windows.Forms.Button();
            this.txtPhotoBrowse = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tcPhoto.SuspendLayout();
            this.tbpFileDescription.SuspendLayout();
            this.tbpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tcPhoto
            // 
            this.tcPhoto.Controls.Add(this.tbpFileDescription);
            this.tcPhoto.Controls.Add(this.tbpImage);
            this.tcPhoto.Location = new System.Drawing.Point(-1, -1);
            this.tcPhoto.Name = "tcPhoto";
            this.tcPhoto.SelectedIndex = 0;
            this.tcPhoto.Size = new System.Drawing.Size(472, 348);
            this.tcPhoto.TabIndex = 3;
            // 
            // tbpFileDescription
            // 
            this.tbpFileDescription.Controls.Add(this.btnPhotoCancel);
            this.tbpFileDescription.Controls.Add(this.btnPhotoSave);
            this.tbpFileDescription.Controls.Add(this.txtPhotoBody);
            this.tbpFileDescription.Controls.Add(this.lblPhotoBody);
            this.tbpFileDescription.Controls.Add(this.txtPhotoDescription);
            this.tbpFileDescription.Controls.Add(this.txtPhotoTitle);
            this.tbpFileDescription.Controls.Add(this.lblPhotoDescription);
            this.tbpFileDescription.Controls.Add(this.lblPhotoTitle);
            this.tbpFileDescription.Location = new System.Drawing.Point(4, 22);
            this.tbpFileDescription.Name = "tbpFileDescription";
            this.tbpFileDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFileDescription.Size = new System.Drawing.Size(464, 322);
            this.tbpFileDescription.TabIndex = 0;
            this.tbpFileDescription.Text = "File Description";
            this.tbpFileDescription.UseVisualStyleBackColor = true;
            // 
            // btnPhotoCancel
            // 
            this.btnPhotoCancel.Location = new System.Drawing.Point(360, 292);
            this.btnPhotoCancel.Name = "btnPhotoCancel";
            this.btnPhotoCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPhotoCancel.TabIndex = 13;
            this.btnPhotoCancel.Text = "Cancel";
            this.btnPhotoCancel.UseVisualStyleBackColor = true;
            this.btnPhotoCancel.Click += new System.EventHandler(this.btnPhotoCancel_Click);
            // 
            // btnPhotoSave
            // 
            this.btnPhotoSave.Location = new System.Drawing.Point(279, 292);
            this.btnPhotoSave.Name = "btnPhotoSave";
            this.btnPhotoSave.Size = new System.Drawing.Size(75, 23);
            this.btnPhotoSave.TabIndex = 12;
            this.btnPhotoSave.Text = "Save";
            this.btnPhotoSave.UseVisualStyleBackColor = true;
            this.btnPhotoSave.Click += new System.EventHandler(this.btnPhotoSave_Click);
            // 
            // txtPhotoBody
            // 
            this.txtPhotoBody.Location = new System.Drawing.Point(127, 82);
            this.txtPhotoBody.MaxLength = 10000;
            this.txtPhotoBody.Multiline = true;
            this.txtPhotoBody.Name = "txtPhotoBody";
            this.txtPhotoBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhotoBody.Size = new System.Drawing.Size(308, 204);
            this.txtPhotoBody.TabIndex = 11;
            // 
            // lblPhotoBody
            // 
            this.lblPhotoBody.AutoSize = true;
            this.lblPhotoBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoBody.Location = new System.Drawing.Point(19, 86);
            this.lblPhotoBody.Name = "lblPhotoBody";
            this.lblPhotoBody.Size = new System.Drawing.Size(43, 16);
            this.lblPhotoBody.TabIndex = 10;
            this.lblPhotoBody.Text = "Body";
            // 
            // txtPhotoDescription
            // 
            this.txtPhotoDescription.Location = new System.Drawing.Point(127, 47);
            this.txtPhotoDescription.MaxLength = 255;
            this.txtPhotoDescription.Name = "txtPhotoDescription";
            this.txtPhotoDescription.Size = new System.Drawing.Size(308, 20);
            this.txtPhotoDescription.TabIndex = 9;
            // 
            // txtPhotoTitle
            // 
            this.txtPhotoTitle.Location = new System.Drawing.Point(127, 16);
            this.txtPhotoTitle.MaxLength = 255;
            this.txtPhotoTitle.Name = "txtPhotoTitle";
            this.txtPhotoTitle.Size = new System.Drawing.Size(308, 20);
            this.txtPhotoTitle.TabIndex = 8;
            // 
            // lblPhotoDescription
            // 
            this.lblPhotoDescription.AutoSize = true;
            this.lblPhotoDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoDescription.Location = new System.Drawing.Point(19, 51);
            this.lblPhotoDescription.Name = "lblPhotoDescription";
            this.lblPhotoDescription.Size = new System.Drawing.Size(86, 16);
            this.lblPhotoDescription.TabIndex = 7;
            this.lblPhotoDescription.Text = "Description";
            // 
            // lblPhotoTitle
            // 
            this.lblPhotoTitle.AutoSize = true;
            this.lblPhotoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoTitle.Location = new System.Drawing.Point(19, 17);
            this.lblPhotoTitle.Name = "lblPhotoTitle";
            this.lblPhotoTitle.Size = new System.Drawing.Size(38, 16);
            this.lblPhotoTitle.TabIndex = 6;
            this.lblPhotoTitle.Text = "Title";
            // 
            // tbpImage
            // 
            this.tbpImage.Controls.Add(this.button1);
            this.tbpImage.Controls.Add(this.button2);
            this.tbpImage.Controls.Add(this.pbPhotoImage);
            this.tbpImage.Controls.Add(this.btnPhotoBrowse);
            this.tbpImage.Controls.Add(this.txtPhotoBrowse);
            this.tbpImage.Location = new System.Drawing.Point(4, 22);
            this.tbpImage.Name = "tbpImage";
            this.tbpImage.Padding = new System.Windows.Forms.Padding(3);
            this.tbpImage.Size = new System.Drawing.Size(464, 322);
            this.tbpImage.TabIndex = 1;
            this.tbpImage.Text = "Image";
            this.tbpImage.UseVisualStyleBackColor = true;
            // 
            // pbPhotoImage
            // 
            this.pbPhotoImage.Location = new System.Drawing.Point(23, 51);
            this.pbPhotoImage.Name = "pbPhotoImage";
            this.pbPhotoImage.Size = new System.Drawing.Size(401, 243);
            this.pbPhotoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhotoImage.TabIndex = 8;
            this.pbPhotoImage.TabStop = false;
            // 
            // btnPhotoBrowse
            // 
            this.btnPhotoBrowse.Location = new System.Drawing.Point(23, 14);
            this.btnPhotoBrowse.Name = "btnPhotoBrowse";
            this.btnPhotoBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPhotoBrowse.TabIndex = 7;
            this.btnPhotoBrowse.Text = "Browse";
            this.btnPhotoBrowse.UseVisualStyleBackColor = true;
            this.btnPhotoBrowse.Click += new System.EventHandler(this.btnPhotoBrowse_Click);
            // 
            // txtPhotoBrowse
            // 
            this.txtPhotoBrowse.Location = new System.Drawing.Point(117, 14);
            this.txtPhotoBrowse.MaxLength = 255;
            this.txtPhotoBrowse.Name = "txtPhotoBrowse";
            this.txtPhotoBrowse.Size = new System.Drawing.Size(308, 20);
            this.txtPhotoBrowse.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 352);
            this.Controls.Add(this.tcPhoto);
            this.MinimumSize = new System.Drawing.Size(487, 383);
            this.Name = "frmPhoto";
            this.Text = "New Photo";
            this.tcPhoto.ResumeLayout(false);
            this.tbpFileDescription.ResumeLayout(false);
            this.tbpFileDescription.PerformLayout();
            this.tbpImage.ResumeLayout(false);
            this.tbpImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tcPhoto;
        private System.Windows.Forms.TabPage tbpFileDescription;
        private System.Windows.Forms.TextBox txtPhotoDescription;
        private System.Windows.Forms.TextBox txtPhotoTitle;
        private System.Windows.Forms.Label lblPhotoDescription;
        private System.Windows.Forms.Label lblPhotoTitle;
        private System.Windows.Forms.TextBox txtPhotoBody;
        private System.Windows.Forms.Label lblPhotoBody;
        private System.Windows.Forms.TabPage tbpImage;
        private System.Windows.Forms.TextBox txtPhotoBrowse;
        private System.Windows.Forms.Button btnPhotoBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pbPhotoImage;
        private System.Windows.Forms.Button btnPhotoCancel;
        private System.Windows.Forms.Button btnPhotoSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}