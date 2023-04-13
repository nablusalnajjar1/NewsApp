namespace FileworxApp
{
    partial class frmUser
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
            this.txtUserLoginName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserLoginName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUseerPassword = new System.Windows.Forms.Label();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserLoginName
            // 
            this.txtUserLoginName.Location = new System.Drawing.Point(168, 72);
            this.txtUserLoginName.MaxLength = 255;
            this.txtUserLoginName.Name = "txtUserLoginName";
            this.txtUserLoginName.Size = new System.Drawing.Size(156, 20);
            this.txtUserLoginName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUserName.Location = new System.Drawing.Point(168, 41);
            this.txtUserName.MaxLength = 255;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserLoginName
            // 
            this.lblUserLoginName.AutoSize = true;
            this.lblUserLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoginName.Location = new System.Drawing.Point(20, 76);
            this.lblUserLoginName.Name = "lblUserLoginName";
            this.lblUserLoginName.Size = new System.Drawing.Size(77, 16);
            this.lblUserLoginName.TabIndex = 2;
            this.lblUserLoginName.Text = "Full Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(22, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(48, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Name";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(168, 106);
            this.txtUserPassword.MaxLength = 255;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(156, 20);
            this.txtUserPassword.TabIndex = 5;
            // 
            // lblUseerPassword
            // 
            this.lblUseerPassword.AutoSize = true;
            this.lblUseerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseerPassword.Location = new System.Drawing.Point(22, 113);
            this.lblUseerPassword.Name = "lblUseerPassword";
            this.lblUseerPassword.Size = new System.Drawing.Size(75, 16);
            this.lblUseerPassword.TabIndex = 4;
            this.lblUseerPassword.Text = "Password";
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Location = new System.Drawing.Point(249, 184);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUserCancel.TabIndex = 9;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(168, 184);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.TabIndex = 8;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(168, 143);
            this.txtConfirmPass.MaxLength = 255;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(156, 20);
            this.txtConfirmPass.TabIndex = 7;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(22, 150);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(131, 16);
            this.lblConfirmPass.TabIndex = 6;
            this.lblConfirmPass.Text = "Confirm Password";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 219);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.btnUserCancel);
            this.Controls.Add(this.btnUserSave);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.lblUseerPassword);
            this.Controls.Add(this.txtUserLoginName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserLoginName);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fileworx_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserLoginName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserLoginName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUseerPassword;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
    }
}