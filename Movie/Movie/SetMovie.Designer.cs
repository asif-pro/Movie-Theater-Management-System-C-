namespace Movie
{
    partial class SetMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMovie));
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new MetroFramework.Controls.MetroDateTime();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.lblHallName = new System.Windows.Forms.Label();
            this.txtHallName = new System.Windows.Forms.TextBox();
            this.lblGener = new System.Windows.Forms.Label();
            this.txtGener = new System.Windows.Forms.TextBox();
            this.txtImdb = new System.Windows.Forms.TextBox();
            this.lblImdb = new System.Windows.Forms.Label();
            this.lblTotalTicket = new System.Windows.Forms.Label();
            this.txtTotalTicket = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSetUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.picBoxMoviePoster = new System.Windows.Forms.PictureBox();
            this.btnChoosePoster = new System.Windows.Forms.Button();
            this.pnlSetMoviGrid = new System.Windows.Forms.Panel();
            this.gridSetMovie = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoviePoster)).BeginInit();
            this.pnlSetMoviGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.Black;
            this.lblMovieName.Location = new System.Drawing.Point(429, 226);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(105, 23);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Movie Name :";
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.White;
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMovieName.Location = new System.Drawing.Point(540, 226);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(216, 19);
            this.txtMovieName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(541, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 1);
            this.panel1.TabIndex = 2;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.ForeColor = System.Drawing.Color.Black;
            this.lblMovieID.Location = new System.Drawing.Point(23, 223);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(77, 23);
            this.lblMovieID.TabIndex = 3;
            this.lblMovieID.Text = "Movie ID :";
            // 
            // txtMovieID
            // 
            this.txtMovieID.AllowDrop = true;
            this.txtMovieID.BackColor = System.Drawing.Color.White;
            this.txtMovieID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMovieID.Location = new System.Drawing.Point(124, 227);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(215, 19);
            this.txtMovieID.TabIndex = 4;
            this.txtMovieID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(125, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 1);
            this.panel2.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(288, 342);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 23);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date & Time :";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(401, 339);
            this.datePicker.MinDate = new System.DateTime(2019, 8, 18, 14, 25, 7, 0);
            this.datePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 30);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2019, 8, 18, 14, 25, 7, 0);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(734, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 20;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Black;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.Location = new System.Drawing.Point(769, 7);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 32);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // lblHallName
            // 
            this.lblHallName.AutoSize = true;
            this.lblHallName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallName.ForeColor = System.Drawing.Color.Black;
            this.lblHallName.Location = new System.Drawing.Point(23, 281);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(90, 23);
            this.lblHallName.TabIndex = 21;
            this.lblHallName.Text = "Hall Name :";
            // 
            // txtHallName
            // 
            this.txtHallName.BackColor = System.Drawing.Color.White;
            this.txtHallName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHallName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHallName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHallName.Location = new System.Drawing.Point(124, 285);
            this.txtHallName.Name = "txtHallName";
            this.txtHallName.Size = new System.Drawing.Size(134, 19);
            this.txtHallName.TabIndex = 22;
            this.txtHallName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGener
            // 
            this.lblGener.AutoSize = true;
            this.lblGener.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGener.ForeColor = System.Drawing.Color.Black;
            this.lblGener.Location = new System.Drawing.Point(328, 285);
            this.lblGener.Name = "lblGener";
            this.lblGener.Size = new System.Drawing.Size(62, 23);
            this.lblGener.TabIndex = 23;
            this.lblGener.Text = "Gener :";
            // 
            // txtGener
            // 
            this.txtGener.BackColor = System.Drawing.Color.White;
            this.txtGener.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGener.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGener.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtGener.Location = new System.Drawing.Point(396, 289);
            this.txtGener.Name = "txtGener";
            this.txtGener.Size = new System.Drawing.Size(132, 19);
            this.txtGener.TabIndex = 24;
            this.txtGener.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImdb
            // 
            this.txtImdb.BackColor = System.Drawing.Color.White;
            this.txtImdb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImdb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImdb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtImdb.Location = new System.Drawing.Point(132, 342);
            this.txtImdb.Name = "txtImdb";
            this.txtImdb.Size = new System.Drawing.Size(132, 19);
            this.txtImdb.TabIndex = 26;
            this.txtImdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtImdb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImdb_KeyPress);
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImdb.ForeColor = System.Drawing.Color.Black;
            this.lblImdb.Location = new System.Drawing.Point(23, 338);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(103, 23);
            this.lblImdb.TabIndex = 25;
            this.lblImdb.Text = "IMDB Rating :";
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.AutoSize = true;
            this.lblTotalTicket.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTicket.ForeColor = System.Drawing.Color.Black;
            this.lblTotalTicket.Location = new System.Drawing.Point(577, 289);
            this.lblTotalTicket.Name = "lblTotalTicket";
            this.lblTotalTicket.Size = new System.Drawing.Size(103, 23);
            this.lblTotalTicket.TabIndex = 27;
            this.lblTotalTicket.Text = "Total Tickets :";
            // 
            // txtTotalTicket
            // 
            this.txtTotalTicket.BackColor = System.Drawing.Color.White;
            this.txtTotalTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTicket.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTotalTicket.Location = new System.Drawing.Point(708, 293);
            this.txtTotalTicket.Name = "txtTotalTicket";
            this.txtTotalTicket.Size = new System.Drawing.Size(132, 19);
            this.txtTotalTicket.TabIndex = 28;
            this.txtTotalTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotalTicket_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(124, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 1);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(396, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 1);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(132, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(131, 1);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(708, 313);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(132, 1);
            this.panel6.TabIndex = 32;
            // 
            // btnSetUpdate
            // 
            this.btnSetUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSetUpdate.Location = new System.Drawing.Point(23, 406);
            this.btnSetUpdate.Name = "btnSetUpdate";
            this.btnSetUpdate.Size = new System.Drawing.Size(160, 35);
            this.btnSetUpdate.TabIndex = 33;
            this.btnSetUpdate.Text = "SET/UPDATE";
            this.btnSetUpdate.UseVisualStyleBackColor = false;
            this.btnSetUpdate.Click += new System.EventHandler(this.BtnSetUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(708, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 35);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(20, 22);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(292, 410);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search Movie";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(312, 32);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.UseCustomBackColor = true;
            this.txtSearch.UseCustomForeColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search Movie";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(628, 342);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 23);
            this.lblTime.TabIndex = 38;
            this.lblTime.Text = "Time :";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "  ";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(708, 348);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(127, 20);
            this.timePicker.TabIndex = 39;
            this.timePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimePicker_MouseDown);
            // 
            // picBoxMoviePoster
            // 
            this.picBoxMoviePoster.Location = new System.Drawing.Point(149, 18);
            this.picBoxMoviePoster.Name = "picBoxMoviePoster";
            this.picBoxMoviePoster.Size = new System.Drawing.Size(241, 192);
            this.picBoxMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMoviePoster.TabIndex = 40;
            this.picBoxMoviePoster.TabStop = false;
            // 
            // btnChoosePoster
            // 
            this.btnChoosePoster.BackColor = System.Drawing.Color.Black;
            this.btnChoosePoster.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePoster.ForeColor = System.Drawing.Color.White;
            this.btnChoosePoster.Location = new System.Drawing.Point(405, 110);
            this.btnChoosePoster.Name = "btnChoosePoster";
            this.btnChoosePoster.Size = new System.Drawing.Size(123, 35);
            this.btnChoosePoster.TabIndex = 41;
            this.btnChoosePoster.Text = "Choose Poster";
            this.btnChoosePoster.UseVisualStyleBackColor = false;
            this.btnChoosePoster.Click += new System.EventHandler(this.BtnChoosePoster_Click);
            // 
            // pnlSetMoviGrid
            // 
            this.pnlSetMoviGrid.Controls.Add(this.gridSetMovie);
            this.pnlSetMoviGrid.Location = new System.Drawing.Point(4, 449);
            this.pnlSetMoviGrid.Name = "pnlSetMoviGrid";
            this.pnlSetMoviGrid.Size = new System.Drawing.Size(899, 259);
            this.pnlSetMoviGrid.TabIndex = 43;
            // 
            // gridSetMovie
            // 
            this.gridSetMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSetMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.hall,
            this.gener,
            this.totalticket,
            this.rating,
            this.date,
            this.time,
            this.path});
            this.gridSetMovie.Location = new System.Drawing.Point(6, 3);
            this.gridSetMovie.Name = "gridSetMovie";
            this.gridSetMovie.RowHeadersWidth = 51;
            this.gridSetMovie.Size = new System.Drawing.Size(892, 255);
            this.gridSetMovie.TabIndex = 0;
            this.gridSetMovie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSetMovie_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
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
            this.hall.HeaderText = "Hall Name";
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
            // totalticket
            // 
            this.totalticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalticket.DataPropertyName = "totalticket";
            this.totalticket.HeaderText = "Total Ticket";
            this.totalticket.MinimumWidth = 6;
            this.totalticket.Name = "totalticket";
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
            this.time.HeaderText = "Time";
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
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(620, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 44;
            this.textBox1.Visible = false;
            // 
            // SetMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 711);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlSetMoviGrid);
            this.Controls.Add(this.btnChoosePoster);
            this.Controls.Add(this.picBoxMoviePoster);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSetUpdate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTotalTicket);
            this.Controls.Add(this.lblTotalTicket);
            this.Controls.Add(this.txtImdb);
            this.Controls.Add(this.lblImdb);
            this.Controls.Add(this.txtGener);
            this.Controls.Add(this.lblGener);
            this.Controls.Add(this.txtHallName);
            this.Controls.Add(this.lblHallName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.lblMovieName);
            this.Name = "SetMovie";
            this.Text = "SetMovie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMoviePoster)).EndInit();
            this.pnlSetMoviGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSetMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDate;
        private MetroFramework.Controls.MetroDateTime datePicker;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.TextBox txtHallName;
        private System.Windows.Forms.Label lblGener;
        private System.Windows.Forms.TextBox txtGener;
        private System.Windows.Forms.TextBox txtImdb;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Label lblTotalTicket;
        private System.Windows.Forms.TextBox txtTotalTicket;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSetUpdate;
        private System.Windows.Forms.Button btnDelete;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.PictureBox picBoxMoviePoster;
        private System.Windows.Forms.Button btnChoosePoster;
        private System.Windows.Forms.Panel pnlSetMoviGrid;
        private System.Windows.Forms.DataGridView gridSetMovie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn gener;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
    }
}