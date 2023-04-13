namespace FileworxApp
{
    partial class frmNews
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
            this.lblNewsTitle = new System.Windows.Forms.Label();
            this.lblNewsBody = new System.Windows.Forms.Label();
            this.lblNewsCategory = new System.Windows.Forms.Label();
            this.lblNewsDescription = new System.Windows.Forms.Label();
            this.txtNewsTitle = new System.Windows.Forms.TextBox();
            this.txtNewsDescription = new System.Windows.Forms.TextBox();
            this.txtNewsBody = new System.Windows.Forms.TextBox();
            this.cbNewsCategory = new System.Windows.Forms.ComboBox();
            this.btnNewsSave = new System.Windows.Forms.Button();
            this.btnNewsCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblNewsTitle
            // 
            this.lblNewsTitle.AutoSize = true;
            this.lblNewsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsTitle.Location = new System.Drawing.Point(39, 24);
            this.lblNewsTitle.Name = "lblNewsTitle";
            this.lblNewsTitle.Size = new System.Drawing.Size(38, 16);
            this.lblNewsTitle.TabIndex = 0;
            this.lblNewsTitle.Text = "Title";
            // 
            // lblNewsBody
            // 
            this.lblNewsBody.AutoSize = true;
            this.lblNewsBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsBody.Location = new System.Drawing.Point(39, 121);
            this.lblNewsBody.Name = "lblNewsBody";
            this.lblNewsBody.Size = new System.Drawing.Size(43, 16);
            this.lblNewsBody.TabIndex = 1;
            this.lblNewsBody.Text = "Body";
            // 
            // lblNewsCategory
            // 
            this.lblNewsCategory.AutoSize = true;
            this.lblNewsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsCategory.Location = new System.Drawing.Point(39, 89);
            this.lblNewsCategory.Name = "lblNewsCategory";
            this.lblNewsCategory.Size = new System.Drawing.Size(70, 16);
            this.lblNewsCategory.TabIndex = 2;
            this.lblNewsCategory.Text = "Category";
            // 
            // lblNewsDescription
            // 
            this.lblNewsDescription.AutoSize = true;
            this.lblNewsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsDescription.Location = new System.Drawing.Point(39, 58);
            this.lblNewsDescription.Name = "lblNewsDescription";
            this.lblNewsDescription.Size = new System.Drawing.Size(86, 16);
            this.lblNewsDescription.TabIndex = 3;
            this.lblNewsDescription.Text = "Description";
            // 
            // txtNewsTitle
            // 
            this.txtNewsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewsTitle.Location = new System.Drawing.Point(147, 23);
            this.txtNewsTitle.MaxLength = 255;
            this.txtNewsTitle.Name = "txtNewsTitle";
            this.txtNewsTitle.Size = new System.Drawing.Size(308, 20);
            this.txtNewsTitle.TabIndex = 4;
            // 
            // txtNewsDescription
            // 
            this.txtNewsDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewsDescription.Location = new System.Drawing.Point(147, 54);
            this.txtNewsDescription.MaxLength = 255;
            this.txtNewsDescription.Name = "txtNewsDescription";
            this.txtNewsDescription.Size = new System.Drawing.Size(308, 20);
            this.txtNewsDescription.TabIndex = 5;
            // 
            // txtNewsBody
            // 
            this.txtNewsBody.AllowDrop = true;
            this.txtNewsBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewsBody.Location = new System.Drawing.Point(147, 117);
            this.txtNewsBody.MaxLength = 10000;
            this.txtNewsBody.Multiline = true;
            this.txtNewsBody.Name = "txtNewsBody";
            this.txtNewsBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNewsBody.Size = new System.Drawing.Size(308, 158);
            this.txtNewsBody.TabIndex = 6;
            // 
            // cbNewsCategory
            // 
            this.cbNewsCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNewsCategory.FormattingEnabled = true;
            this.cbNewsCategory.Items.AddRange(new object[] {
            "General",
            "Sports",
            "Health",
            "Politics"});
            this.cbNewsCategory.Location = new System.Drawing.Point(147, 84);
            this.cbNewsCategory.Name = "cbNewsCategory";
            this.cbNewsCategory.Size = new System.Drawing.Size(308, 21);
            this.cbNewsCategory.TabIndex = 7;
            // 
            // btnNewsSave
            // 
            this.btnNewsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewsSave.Location = new System.Drawing.Point(299, 292);
            this.btnNewsSave.Name = "btnNewsSave";
            this.btnNewsSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewsSave.TabIndex = 8;
            this.btnNewsSave.Text = "Save";
            this.btnNewsSave.UseVisualStyleBackColor = true;
            this.btnNewsSave.Click += new System.EventHandler(this.btnNewsSave_Click);
            // 
            // btnNewsCancel
            // 
            this.btnNewsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewsCancel.Location = new System.Drawing.Point(380, 292);
            this.btnNewsCancel.Name = "btnNewsCancel";
            this.btnNewsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewsCancel.TabIndex = 9;
            this.btnNewsCancel.Text = "Cancel";
            this.btnNewsCancel.UseVisualStyleBackColor = true;
            this.btnNewsCancel.Click += new System.EventHandler(this.btnNewsCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // News
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 333);
            this.Controls.Add(this.btnNewsCancel);
            this.Controls.Add(this.btnNewsSave);
            this.Controls.Add(this.cbNewsCategory);
            this.Controls.Add(this.txtNewsBody);
            this.Controls.Add(this.txtNewsDescription);
            this.Controls.Add(this.txtNewsTitle);
            this.Controls.Add(this.lblNewsDescription);
            this.Controls.Add(this.lblNewsCategory);
            this.Controls.Add(this.lblNewsBody);
            this.Controls.Add(this.lblNewsTitle);
            this.MinimumSize = new System.Drawing.Size(542, 372);
            this.Name = "News";
            this.Text = "New News";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewsTitle;
        private System.Windows.Forms.Label lblNewsBody;
        private System.Windows.Forms.Label lblNewsCategory;
        private System.Windows.Forms.Label lblNewsDescription;
        private System.Windows.Forms.TextBox txtNewsTitle;
        private System.Windows.Forms.TextBox txtNewsDescription;
        private System.Windows.Forms.TextBox txtNewsBody;
        private System.Windows.Forms.ComboBox cbNewsCategory;
        private System.Windows.Forms.Button btnNewsSave;
        private System.Windows.Forms.Button btnNewsCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

