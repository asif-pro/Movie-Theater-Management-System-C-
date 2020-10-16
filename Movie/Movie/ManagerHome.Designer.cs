namespace Movie
{
    partial class ManagerHome
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
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.btnUpcomingMovie = new MetroFramework.Controls.MetroTile();
            this.btnManageAccount = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(535, 50);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(56, 24);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnUpcomingMovie
            // 
            this.btnUpcomingMovie.ActiveControl = null;
            this.btnUpcomingMovie.Location = new System.Drawing.Point(335, 154);
            this.btnUpcomingMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpcomingMovie.Name = "btnUpcomingMovie";
            this.btnUpcomingMovie.Size = new System.Drawing.Size(240, 162);
            this.btnUpcomingMovie.TabIndex = 4;
            this.btnUpcomingMovie.Text = "Upcoming Movies";
            this.btnUpcomingMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpcomingMovie.UseSelectable = true;
            this.btnUpcomingMovie.Click += new System.EventHandler(this.TxtManageMovie_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.ActiveControl = null;
            this.btnManageAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnManageAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManageAccount.Location = new System.Drawing.Point(10, 154);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(240, 162);
            this.btnManageAccount.TabIndex = 3;
            this.btnManageAccount.Text = "Set Movie";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageAccount.UseSelectable = true;
            this.btnManageAccount.Click += new System.EventHandler(this.TxtManageAccount_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUpcomingMovie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerHome";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "ManagerHome";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogOut;
        private MetroFramework.Controls.MetroTile btnUpcomingMovie;
        private MetroFramework.Controls.MetroTile btnManageAccount;
    }
}