namespace FileworxApp
{
    partial class frmUserList
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
            this.lstUserList = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUserList
            // 
            this.lstUserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.columnHeader2});
            this.lstUserList.ContextMenuStrip = this.contextMenuStrip1;
            this.lstUserList.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUserList.HideSelection = false;
            this.lstUserList.Location = new System.Drawing.Point(16, 12);
            this.lstUserList.MaximumSize = new System.Drawing.Size(500, 550);
            this.lstUserList.Name = "lstUserList";
            this.lstUserList.Size = new System.Drawing.Size(331, 410);
            this.lstUserList.TabIndex = 0;
            this.lstUserList.UseCompatibleStateImageBehavior = false;
            this.lstUserList.View = System.Windows.Forms.View.Details;
            this.lstUserList.SelectedIndexChanged += new System.EventHandler(this.lstUserList_SelectedIndexChanged);
            this.lstUserList.Click += new System.EventHandler(this.lstUserList_SelectedIndexChanged);
            this.lstUserList.DoubleClick += new System.EventHandler(this.lstvFileworx_DoubleClick);
            // 
            // UserName
            // 
            this.UserName.Text = "UserName";
            this.UserName.Width = 115;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FullName";
            this.columnHeader2.Width = 100;
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 434);
            this.Controls.Add(this.lstUserList);
            this.MinimumSize = new System.Drawing.Size(383, 392);
            this.Name = "frmUserList";
            this.Text = "UserList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fileworx_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstUserList;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}