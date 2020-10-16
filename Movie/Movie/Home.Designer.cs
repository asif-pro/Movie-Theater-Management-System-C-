namespace Movie
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlHome = new System.Windows.Forms.Panel();
            this.tileUCPrevious = new MetroFramework.Controls.MetroTile();
            this.tileUCNext = new MetroFramework.Controls.MetroTile();
            this.pBoxNowShowing = new System.Windows.Forms.PictureBox();
            this.pBoxUpcomings = new System.Windows.Forms.PictureBox();
            this.lblNowShowing = new System.Windows.Forms.Label();
            this.lblUpcomings = new System.Windows.Forms.Label();
            this.tileNSPrevious = new MetroFramework.Controls.MetroTile();
            this.tileNSNext = new MetroFramework.Controls.MetroTile();
            this.btnLoginorSignup = new MetroFramework.Controls.MetroTile();
            this.timerUpcoming = new System.Windows.Forms.Timer(this.components);
            this.timerNowShowing = new System.Windows.Forms.Timer(this.components);
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNowShowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUpcomings)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackgroundImage = global::Movie.Properties.Resources.org;
            this.pnlHome.Controls.Add(this.tileUCPrevious);
            this.pnlHome.Controls.Add(this.tileUCNext);
            this.pnlHome.Controls.Add(this.pBoxNowShowing);
            this.pnlHome.Controls.Add(this.pBoxUpcomings);
            this.pnlHome.Controls.Add(this.lblNowShowing);
            this.pnlHome.Controls.Add(this.lblUpcomings);
            this.pnlHome.Controls.Add(this.tileNSPrevious);
            this.pnlHome.Controls.Add(this.tileNSNext);
            resources.ApplyResources(this.pnlHome, "pnlHome");
            this.pnlHome.Name = "pnlHome";
            // 
            // tileUCPrevious
            // 
            this.tileUCPrevious.ActiveControl = null;
            this.tileUCPrevious.BackColor = System.Drawing.Color.Transparent;
            this.tileUCPrevious.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.tileUCPrevious, "tileUCPrevious");
            this.tileUCPrevious.Name = "tileUCPrevious";
            this.tileUCPrevious.TileImage = ((System.Drawing.Image)(resources.GetObject("tileUCPrevious.TileImage")));
            this.tileUCPrevious.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUCPrevious.UseCustomBackColor = true;
            this.tileUCPrevious.UseCustomForeColor = true;
            this.tileUCPrevious.UseSelectable = true;
            this.tileUCPrevious.UseTileImage = true;
            this.tileUCPrevious.Click += new System.EventHandler(this.TileUCPrevious_Click);
            // 
            // tileUCNext
            // 
            this.tileUCNext.ActiveControl = null;
            this.tileUCNext.BackColor = System.Drawing.Color.Transparent;
            this.tileUCNext.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.tileUCNext, "tileUCNext");
            this.tileUCNext.Name = "tileUCNext";
            this.tileUCNext.TileImage = ((System.Drawing.Image)(resources.GetObject("tileUCNext.TileImage")));
            this.tileUCNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUCNext.UseCustomBackColor = true;
            this.tileUCNext.UseCustomForeColor = true;
            this.tileUCNext.UseSelectable = true;
            this.tileUCNext.UseTileImage = true;
            this.tileUCNext.Click += new System.EventHandler(this.TileUCNext_Click);
            // 
            // pBoxNowShowing
            // 
            resources.ApplyResources(this.pBoxNowShowing, "pBoxNowShowing");
            this.pBoxNowShowing.Name = "pBoxNowShowing";
            this.pBoxNowShowing.TabStop = false;
            // 
            // pBoxUpcomings
            // 
            resources.ApplyResources(this.pBoxUpcomings, "pBoxUpcomings");
            this.pBoxUpcomings.Name = "pBoxUpcomings";
            this.pBoxUpcomings.TabStop = false;
            // 
            // lblNowShowing
            // 
            resources.ApplyResources(this.lblNowShowing, "lblNowShowing");
            this.lblNowShowing.BackColor = System.Drawing.Color.Transparent;
            this.lblNowShowing.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNowShowing.Name = "lblNowShowing";
            // 
            // lblUpcomings
            // 
            resources.ApplyResources(this.lblUpcomings, "lblUpcomings");
            this.lblUpcomings.BackColor = System.Drawing.Color.Transparent;
            this.lblUpcomings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUpcomings.Name = "lblUpcomings";
            // 
            // tileNSPrevious
            // 
            this.tileNSPrevious.ActiveControl = null;
            this.tileNSPrevious.BackColor = System.Drawing.Color.Transparent;
            this.tileNSPrevious.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.tileNSPrevious, "tileNSPrevious");
            this.tileNSPrevious.Name = "tileNSPrevious";
            this.tileNSPrevious.TileImage = ((System.Drawing.Image)(resources.GetObject("tileNSPrevious.TileImage")));
            this.tileNSPrevious.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNSPrevious.UseCustomBackColor = true;
            this.tileNSPrevious.UseCustomForeColor = true;
            this.tileNSPrevious.UseSelectable = true;
            this.tileNSPrevious.UseTileImage = true;
            this.tileNSPrevious.Click += new System.EventHandler(this.TileNSPrevious_Click);
            // 
            // tileNSNext
            // 
            this.tileNSNext.ActiveControl = null;
            this.tileNSNext.BackColor = System.Drawing.Color.Transparent;
            this.tileNSNext.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.tileNSNext, "tileNSNext");
            this.tileNSNext.Name = "tileNSNext";
            this.tileNSNext.TileImage = ((System.Drawing.Image)(resources.GetObject("tileNSNext.TileImage")));
            this.tileNSNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNSNext.UseCustomBackColor = true;
            this.tileNSNext.UseCustomForeColor = true;
            this.tileNSNext.UseSelectable = true;
            this.tileNSNext.UseTileImage = true;
            this.tileNSNext.Click += new System.EventHandler(this.TileNSNext_Click);
            // 
            // btnLoginorSignup
            // 
            this.btnLoginorSignup.ActiveControl = null;
            resources.ApplyResources(this.btnLoginorSignup, "btnLoginorSignup");
            this.btnLoginorSignup.Name = "btnLoginorSignup";
            this.btnLoginorSignup.UseSelectable = true;
            this.btnLoginorSignup.UseTileImage = true;
            this.btnLoginorSignup.Click += new System.EventHandler(this.BtnLoginorSignup_Click);
            // 
            // timerUpcoming
            // 
            this.timerUpcoming.Interval = 2000;
            this.timerUpcoming.Tick += new System.EventHandler(this.TimerUpcoming_Tick);
            // 
            // timerNowShowing
            // 
            this.timerNowShowing.Enabled = true;
            this.timerNowShowing.Interval = 2000;
            this.timerNowShowing.Tick += new System.EventHandler(this.TimerNowShowing_Tick);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoginorSignup);
            this.Controls.Add(this.pnlHome);
            this.Name = "Home";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNowShowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUpcomings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNowShowing;
        private System.Windows.Forms.Label lblUpcomings;
        private System.Windows.Forms.PictureBox pBoxNowShowing;
        private System.Windows.Forms.PictureBox pBoxUpcomings;
        private System.Windows.Forms.Panel pnlHome;
        private MetroFramework.Controls.MetroTile tileNSNext;
        private MetroFramework.Controls.MetroTile tileNSPrevious;
        private MetroFramework.Controls.MetroTile tileUCPrevious;
        private MetroFramework.Controls.MetroTile tileUCNext;
        private MetroFramework.Controls.MetroTile btnLoginorSignup;
        private System.Windows.Forms.Timer timerUpcoming;
        private System.Windows.Forms.Timer timerNowShowing;
    }
}

