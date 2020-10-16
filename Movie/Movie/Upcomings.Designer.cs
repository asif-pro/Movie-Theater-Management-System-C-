namespace Movie
{
    partial class Upcomings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upcomings));
            this.picBoxUpcoming = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridViewUpcomings = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTheaterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTheaterDataSet = new Movie.MovieTheaterDataSet();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpcoming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUpcomings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTheaterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTheaterDataSet)).BeginInit();
            this.pnlGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxUpcoming
            // 
            this.picBoxUpcoming.Location = new System.Drawing.Point(23, 63);
            this.picBoxUpcoming.Name = "picBoxUpcoming";
            this.picBoxUpcoming.Size = new System.Drawing.Size(409, 198);
            this.picBoxUpcoming.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUpcoming.TabIndex = 0;
            this.picBoxUpcoming.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Black;
            this.btnUpload.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(44, 350);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 32);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(192, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(176, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(342, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.White;
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.ForeColor = System.Drawing.Color.Black;
            this.txtMovieName.Location = new System.Drawing.Point(176, 283);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(209, 19);
            this.txtMovieName.TabIndex = 6;
            this.txtMovieName.TextChanged += new System.EventHandler(this.TxtMovieName_TextChanged);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(54, 283);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(111, 23);
            this.lblMovieName.TabIndex = 7;
            this.lblMovieName.Text = "Movie Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(176, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 1);
            this.panel1.TabIndex = 8;
            // 
            // gridViewUpcomings
            // 
            this.gridViewUpcomings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUpcomings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.path});
            this.gridViewUpcomings.Location = new System.Drawing.Point(7, 9);
            this.gridViewUpcomings.Name = "gridViewUpcomings";
            this.gridViewUpcomings.RowHeadersWidth = 51;
            this.gridViewUpcomings.Size = new System.Drawing.Size(443, 153);
            this.gridViewUpcomings.TabIndex = 9;
            this.gridViewUpcomings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUpcomings_CellDoubleClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // path
            // 
            this.path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.path.DataPropertyName = "path";
            this.path.HeaderText = "Path";
            this.path.MinimumWidth = 6;
            this.path.Name = "path";
            // 
            // movieTheaterDataSetBindingSource
            // 
            this.movieTheaterDataSetBindingSource.DataSource = this.movieTheaterDataSet;
            this.movieTheaterDataSetBindingSource.Position = 0;
            // 
            // movieTheaterDataSet
            // 
            this.movieTheaterDataSet.DataSetName = "MovieTheaterDataSet";
            this.movieTheaterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.gridViewUpcomings);
            this.pnlGridView.Location = new System.Drawing.Point(-1, 382);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(453, 165);
            this.pnlGridView.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(328, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 18;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Black;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.Location = new System.Drawing.Point(363, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 32);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.UseCustomBackColor = true;
            this.btnLogOut.UseCustomForeColor = true;
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // Upcomings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 547);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picBoxUpcoming);
            this.Name = "Upcomings";
            this.Text = "Upcomings";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpcoming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUpcomings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTheaterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTheaterDataSet)).EndInit();
            this.pnlGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxUpcoming;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridViewUpcomings;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.BindingSource movieTheaterDataSetBindingSource;
        private MovieTheaterDataSet movieTheaterDataSet;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
    }
}