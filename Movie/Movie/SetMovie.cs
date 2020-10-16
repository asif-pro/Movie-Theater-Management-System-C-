using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace Movie
{
    public partial class SetMovie : MetroForm
    {
        ManagerHome mh;

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public SetMovie()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public SetMovie(ManagerHome mh)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.mh = mh;
        }

        public void PopulateGridView(string sql = "select * from Movies;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.gridSetMovie.AutoGenerateColumns = false;
            this.gridSetMovie.DataSource = this.Ds.Tables[0];
        }
        private void TimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            timePicker.CustomFormat = "HH:mm:ss";
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home h3 = new Home();
            h3.Visible = true;
        }
        private void BtnChoosePoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                picBoxMoviePoster.Image = new Bitmap(open.FileName);
            }
        }

        private void BtnSetUpdate_Click(object sender, EventArgs e)
        {
            string sql = "select * from Movies where id ='" + this.txtMovieID.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update Movies
                set name = '" + this.txtMovieName.Text + @"',
                hall = '" + this.txtHallName.Text + @"',
                gener = '" + this.txtGener.Text + @"', 
                totalticket = '" + this.txtTotalTicket.Text + @"',
                rating = '" + this.txtImdb.Text + @"',
                date = '" + this.datePicker.Value + @"',
                time = '" + this.timePicker.Value + @"',
                remainingticket = '" + this.txtTotalTicket.Text + @"'
                where id = '" + this.txtMovieID.Text + "';";

               

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Movie Updated");
                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }

            else if (this.txtTotalTicket.Text == "")
            {
                MessageBox.Show("You must provie a total ticket..");
            }
            else if (this.txtMovieID.Text == "")
            {
                MessageBox.Show("You must provie a ID..");

            }
            else if (this.txtMovieName.Text == "")
            {
                MessageBox.Show("You must provie a Movie Name..");
            }
            else if (this.txtHallName.Text == "")
            {
                MessageBox.Show("You must provie a Hall Name..");
            }
            else if (this.txtGener.Text == "")
            {
                MessageBox.Show("You must provie a Gener..");
            }
            else if (this.txtImdb.Text == "")
            {
                MessageBox.Show("You must provie the IMDB Rating..");
            }
            else if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must provide a poster..");
            }
            else
            {

                File.Copy(textBox1.Text, Path.Combine(@"C:\Users\USER\Desktop\Movie\Movie\Poster2\", Path.GetFileName(textBox1.Text)), true);
                sql = @"insert into Movies 
                    values ('" + this.txtMovieID.Text + "','" + this.txtMovieName.Text + "','" + this.txtHallName.Text + "', '" + this.txtGener.Text + "','" + this.txtTotalTicket.Text + "','" + this.txtImdb.Text + "','" + this.datePicker.Value + "','" + this.timePicker.Text + "','" + this.textBox1.Text + "'," + this.txtTotalTicket.Text + ");";
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Poster Saved Successfully");
                    this.PopulateGridView();
                    MessageBox.Show("Movie Inserted Successfully");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }

            txtHallName.Clear();
            txtMovieID.Clear();
            txtMovieName.Clear();
            textBox1.Clear();
            txtGener.Clear();
            txtTotalTicket.Clear();
            txtImdb.Clear();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string filepath = textBox1.Text;
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
                MessageBox.Show("Poster Deleted");

                string sql = "delete from Movies where id = '" + this.txtMovieID.Text + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Movie Deleted");
                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else { MessageBox.Show("No such Movie Found"); }
        }

        private void GridSetMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMovieName.Text = this.gridSetMovie.CurrentRow.Cells["name"].Value.ToString();
            this.textBox1.Text = this.gridSetMovie.CurrentRow.Cells["path"].Value.ToString();
            this.txtMovieID.Text = this.gridSetMovie.CurrentRow.Cells["id"].Value.ToString();
            this.txtHallName.Text = this.gridSetMovie.CurrentRow.Cells["hall"].Value.ToString();
            this.txtGener.Text = this.gridSetMovie.CurrentRow.Cells["gener"].Value.ToString();
            this.txtTotalTicket.Text = this.gridSetMovie.CurrentRow.Cells["totalticket"].Value.ToString();
            this.txtImdb.Text = this.gridSetMovie.CurrentRow.Cells["rating"].Value.ToString();
            this.datePicker.Text = this.gridSetMovie.CurrentRow.Cells["date"].Value.ToString();
            this.timePicker.Text = this.gridSetMovie.CurrentRow.Cells["time"].Value.ToString();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Movies where id like '" + this.txtSearch.Text + "%' or name like '" + this.txtSearch.Text + "%' or hall like '" + this.txtSearch.Text + "%' or gener like  '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TxtTotalTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void TxtImdb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != '.')
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.mh.Visible = true;
        }
    }
}
