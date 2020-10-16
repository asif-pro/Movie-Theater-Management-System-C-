namespace Movie
{
    partial class BuyTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicket));
            this.pnlBuyTicket = new System.Windows.Forms.Panel();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.gridBuyTicket = new MetroFramework.Controls.MetroGrid();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtShowTime = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.tileNSPrevious = new MetroFramework.Controls.MetroTile();
            this.tileNSNext = new MetroFramework.Controls.MetroTile();
            this.picBoxMovie = new System.Windows.Forms.PictureBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.timerPoster = new System.Windows.Forms.Timer(this.components);
            this.pnlBuyTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuyTicket
            // 
            this.pnlBuyTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlBuyTicket.Controls.Add(this.rBtn2);
            this.pnlBuyTicket.Controls.Add(this.rBtn1);
            this.pnlBuyTicket.Controls.Add(this.gridBuyTicket);
            this.pnlBuyTicket.Controls.Add(this.pictureBox1);
            this.pnlBuyTicket.Controls.Add(this.txtSearch);
            this.pnlBuyTicket.Controls.Add(this.btnBuy);
            this.pnlBuyTicket.Controls.Add(this.txtShowTime);
            this.pnlBuyTicket.Controls.Add(this.txtMovieName);
            this.pnlBuyTicket.Controls.Add(this.tileNSPrevious);
            this.pnlBuyTicket.Controls.Add(this.tileNSNext);
            this.pnlBuyTicket.Controls.Add(this.picBoxMovie);
            this.pnlBuyTicket.Location = new System.Drawing.Point(0, 53);
            this.pnlBuyTicket.Name = "pnlBuyTicket";
            this.pnlBuyTicket.Size = new System.Drawing.Size(592, 629);
            this.pnlBuyTicket.TabIndex = 0;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn2.ForeColor = System.Drawing.Color.White;
            this.rBtn2.Location = new System.Drawing.Point(321, 307);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(36, 24);
            this.rBtn2.TabIndex = 16;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "2";
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn1.ForeColor = System.Drawing.Color.White;
            this.rBtn1.Location = new System.Drawing.Point(211, 308);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(36, 24);
            this.rBtn1.TabIndex = 15;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "1";
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // gridBuyTicket
            // 
            this.gridBuyTicket.AllowUserToResizeRows = false;
            this.gridBuyTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBuyTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBuyTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridBuyTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBuyTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridBuyTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuyTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.hall,
            this.gener,
            this.remainingticket,
            this.rating,
            this.date,
            this.time,
            this.path});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBuyTicket.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridBuyTicket.EnableHeadersVisualStyles = false;
            this.gridBuyTicket.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridBuyTicket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridBuyTicket.Location = new System.Drawing.Point(0, 450);
            this.gridBuyTicket.Name = "gridBuyTicket";
            this.gridBuyTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBuyTicket.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridBuyTicket.RowHeadersWidth = 51;
            this.gridBuyTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBuyTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBuyTicket.Size = new System.Drawing.Size(589, 176);
            this.gridBuyTicket.TabIndex = 14;
            this.gridBuyTicket.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBuyTicket_CellDoubleClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Movie Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // hall
            // 
            this.hall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hall.DataPropertyName = "hall";
            this.hall.HeaderText = "Hall";
            this.hall.MinimumWidth = 6;
            this.hall.Name = "hall";
            // 
            // gener
            // 
            this.gener.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gener.DataPropertyName = "gener";
            this.gener.HeaderText = "Gener";
            this.gener.MinimumWidth = 6;
            this.gener.Name = "gener";
            // 
            // remainingticket
            // 
            this.remainingticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remainingticket.DataPropertyName = "remainingticket";
            this.remainingticket.HeaderText = "Tickets Available";
            this.remainingticket.MinimumWidth = 6;
            this.remainingticket.Name = "remainingticket";
            // 
            // rating
            // 
            this.rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rating.DataPropertyName = "rating";
            this.rating.HeaderText = "IMDB Rating";
            this.rating.MinimumWidth = 6;
            this.rating.Name = "rating";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Show Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            // 
            // path
            // 
            this.path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.path.DataPropertyName = "path";
            this.path.HeaderText = "Path";
            this.path.MinimumWidth = 6;
            this.path.Name = "path";
            this.path.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(28, 30);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(139, 407);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(327, 39);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.UseCustomBackColor = true;
            this.txtSearch.UseCustomForeColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.White;
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuy.Location = new System.Drawing.Point(241, 356);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(83, 36);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // txtShowTime
            // 
            this.txtShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtShowTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowTime.Enabled = false;
            this.txtShowTime.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTime.ForeColor = System.Drawing.Color.Magenta;
            this.txtShowTime.Location = new System.Drawing.Point(139, 266);
            this.txtShowTime.Name = "txtShowTime";
            this.txtShowTime.Size = new System.Drawing.Size(307, 26);
            this.txtShowTime.TabIndex = 9;
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieName.Enabled = false;
            this.txtMovieName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.ForeColor = System.Drawing.Color.Magenta;
            this.txtMovieName.Location = new System.Drawing.Point(139, 219);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(307, 26);
            this.txtMovieName.TabIndex = 8;
            // 
            // tileNSPrevious
            // 
            this.tileNSPrevious.ActiveControl = null;
            this.tileNSPrevious.BackColor = System.Drawing.Color.Transparent;
            this.tileNSPrevious.ForeColor = System.Drawing.Color.Gray;
            this.tileNSPrevious.Location = new System.Drawing.Point(74, 74);
            this.tileNSPrevious.Name = "tileNSPrevious";
            this.tileNSPrevious.Size = new System.Drawing.Size(56, 50);
            this.tileNSPrevious.TabIndex = 7;
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
            this.tileNSNext.Location = new System.Drawing.Point(448, 74);
            this.tileNSNext.Name = "tileNSNext";
            this.tileNSNext.Size = new System.Drawing.Size(56, 50);
            this.tileNSNext.TabIndex = 6;
            this.tileNSNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNSNext.TileImage = ((System.Drawing.Image)(resources.GetObject("tileNSNext.TileImage")));
            this.tileNSNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNSNext.UseCustomBackColor = true;
            this.tileNSNext.UseCustomForeColor = true;
            this.tileNSNext.UseSelectable = true;
            this.tileNSNext.UseTileImage = true;
            this.tileNSNext.Click += new System.EventHandler(this.TileNSNext_Click);
            // 
            // picBoxMovie
            // 
            this.picBoxMovie.Location = new System.Drawing.Point(136, 3);
            this.picBoxMovie.Name = "picBoxMovie";
            this.picBoxMovie.Size = new System.Drawing.Size(306, 200);
            this.picBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMovie.TabIndex = 5;
            this.picBoxMovie.TabStop = false;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblMovieName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.White;
            this.lblMovieName.Location = new System.Drawing.Point(12, 272);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(121, 25);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "Movie Name :";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblShowTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblShowTime.Location = new System.Drawing.Point(12, 317);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(110, 25);
            this.lblShowTime.TabIndex = 2;
            this.lblShowTime.Text = "Show Time :";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblNumberOfTickets.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTickets.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfTickets.Location = new System.Drawing.Point(12, 359);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(169, 25);
            this.lblNumberOfTickets.TabIndex = 3;
            this.lblNumberOfTickets.Text = "Number Of Tickets :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(434, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Black;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.Location = new System.Drawing.Point(475, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 32);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // timerPoster
            // 
            this.timerPoster.Interval = 2000;
            this.timerPoster.Tick += new System.EventHandler(this.TimerPoster_Tick);
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblNumberOfTickets);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.pnlBuyTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyTicket";
            this.Opacity = 0.85D;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "BuyTicket";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.BuyTicket_Load);
            this.pnlBuyTicket.ResumeLayout(false);
            this.pnlBuyTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuyTicket;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.PictureBox picBoxMovie;
        private MetroFramework.Controls.MetroTile tileNSNext;
        private System.Windows.Forms.TextBox txtMovieName;
        private MetroFramework.Controls.MetroTile tileNSPrevious;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtShowTime;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid gridBuyTicket;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.Timer timerPoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn gener;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
    }
}