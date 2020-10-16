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
    public partial class Upcomings : MetroForm
    {
        ManagerHome mh;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public Upcomings()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public Upcomings(ManagerHome mh)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.mh = mh;
        }
        public void PopulateGridView(string sql = "select * from Upcomigs;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.gridViewUpcomings.AutoGenerateColumns = false;
            this.gridViewUpcomings.DataSource = this.Ds.Tables[0];
        }



        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                picBoxUpcoming.Image = new Bitmap(open.FileName);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine(@"C:\Users\USER\Desktop\Movie\Movie\UpcomingImages\", Path.GetFileName(textBox1.Text)), true);
            //MessageBox.Show("Poster Saved Successfully");
            string sql = @"insert into Upcomigs
                values ('" + this.txtMovieName.Text + "', '" + this.textBox1.Text + "');";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Insertion Done.");
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string filepath = textBox1.Text;
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
                MessageBox.Show("Poster Deleted");

                string sql = "delete from Upcomigs where name = '" + this.txtMovieName.Text + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Movie Deleted");
                    this.PopulateGridView();

                    txtMovieName.Clear();
                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else { MessageBox.Show("No such Movie Found"); }



        }

        private void GridViewUpcomings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.txtMovieName.Text = this.gridViewUpcomings.CurrentRow.Cells["name"].Value.ToString();
            this.textBox1.Text = this.gridViewUpcomings.CurrentRow.Cells["path"].Value.ToString();
        }

        private void TxtMovieName_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Upcomigs where name like '" + this.txtMovieName.Text + "%';";
            this.PopulateGridView(sql);


        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
           this.Visible = false;
            Home h2 = new Home();
            h2.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.mh.Visible = true;
            this.Visible = false;
        }
    }
}
