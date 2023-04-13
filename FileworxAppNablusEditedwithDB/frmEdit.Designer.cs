namespace FileworxApp
{
    partial class frmEdit
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
            this.txtUserListConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserListPassword = new System.Windows.Forms.TextBox();
            this.txtUserListFullName = new System.Windows.Forms.TextBox();
            this.txtUserListUserName = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserListConfirm
            // 
            this.txtUserListConfirm.Location = new System.Drawing.Point(165, 100);
            this.txtUserListConfirm.MaximumSize = new System.Drawing.Size(500, 550);
            this.txtUserListConfirm.Name = "txtUserListConfirm";
            this.txtUserListConfirm.PasswordChar = '*';
            this.txtUserListConfirm.Size = new System.Drawing.Size(184, 20);
            this.txtUserListConfirm.TabIndex = 33;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(28, 106);
            this.lblConfirm.MaximumSize = new System.Drawing.Size(500, 550);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(131, 16);
            this.lblConfirm.TabIndex = 32;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 135);
            this.btnCancel.MaximumSize = new System.Drawing.Size(500, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 135);
            this.btnSave.MaximumSize = new System.Drawing.Size(500, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserListPassword
            // 
            this.txtUserListPassword.Location = new System.Drawing.Point(165, 74);
            this.txtUserListPassword.MaximumSize = new System.Drawing.Size(500, 550);
            this.txtUserListPassword.Name = "txtUserListPassword";
            this.txtUserListPassword.PasswordChar = '*';
            this.txtUserListPassword.Size = new System.Drawing.Size(184, 20);
            this.txtUserListPassword.TabIndex = 28;
            // 
            // txtUserListFullName
            // 
            this.txtUserListFullName.Location = new System.Drawing.Point(165, 48);
            this.txtUserListFullName.MaximumSize = new System.Drawing.Size(500, 550);
            this.txtUserListFullName.Name = "txtUserListFullName";
            this.txtUserListFullName.Size = new System.Drawing.Size(184, 20);
            this.txtUserListFullName.TabIndex = 27;
            // 
            // txtUserListUserName
            // 
            this.txtUserListUserName.Location = new System.Drawing.Point(165, 22);
            this.txtUserListUserName.MaximumSize = new System.Drawing.Size(500, 550);
            this.txtUserListUserName.Name = "txtUserListUserName";
            this.txtUserListUserName.Size = new System.Drawing.Size(184, 20);
            this.txtUserListUserName.TabIndex = 26;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(28, 52);
            this.lblFullname.MaximumSize = new System.Drawing.Size(500, 550);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(77, 16);
            this.lblFullname.TabIndex = 25;
            this.lblFullname.Text = "Full Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(28, 79);
            this.lblPassword.MaximumSize = new System.Drawing.Size(500, 550);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 16);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(28, 25);
            this.lblUsername.MaximumSize = new System.Drawing.Size(500, 550);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 16);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "UserName";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 177);
            this.Controls.Add(this.txtUserListConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUserListPassword);
            this.Controls.Add(this.txtUserListFullName);
            this.Controls.Add(this.txtUserListUserName);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 216);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 216);
            this.Name = "frmEdit";
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserListConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUserListPassword;
        private System.Windows.Forms.TextBox txtUserListFullName;
        private System.Windows.Forms.TextBox txtUserListUserName;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}