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

namespace Movie
{
    
    public partial class BuyTicket : MetroForm
    {
        string id;
        CustomerLogin cl;
        int t, amount;
        int i = 1;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public BuyTicket()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public BuyTicket(CustomerLogin cl, string id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.cl = cl;
            this.id = id;
        }

        public void PopulateGridView(string sql = "select * from Movies;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.gridBuyTicket.AutoGenerateColumns = false;
            this.gridBuyTicket.DataSource = this.Ds.Tables[0];
        }

        private void Radiobtncheck()
        {
            if (rBtn1.Checked == true) { this.t = 1; this.amount = 250; }
            else if (rBtn2.Checked == true) { this.t = 2; this.amount = 500; }
            else { MessageBox.Show("Please Select Number of Tickets"); }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            if (txtMovieName.Text != null || txtShowTime.Text!=null || txtMovieName.Text!=" ")
            {
                if (rBtn1.Checked == true || rBtn2.Checked == true)
                {
                    Radiobtncheck();
                    this.Visible = false;
                    Confirmation c = new Confirmation(this, txtMovieName.Text, txtShowTime.Text, t, amount,id);
                    c.Visible = true;
                }
                else { MessageBox.Show("Please Select Number of Tickets"); }
            }
            else { MessageBox.Show("Please Select a Movie"); }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home h3 = new Home();
            h3.Visible = true;
        }

        private void GridBuyTicket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtMovieName.Text = this.gridBuyTicket.CurrentRow.Cells["name"].Value.ToString();
            this.txtShowTime.Text = this.gridBuyTicket.CurrentRow.Cells["time"].Value.ToString();
        }
        

        private void TimerPoster_Tick(object sender, EventArgs e)
        {
            if (i < 9)
            {
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\Poster2\\" + i + ".jpg";
                picBoxMovie.Image = Image.FromFile(sql);
                i++;
            }
            else { i = 1; }
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            timerPoster.Start();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Movies where name like '" + this.txtSearch.Text + "%' or gener like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void TileNSNext_Click(object sender, EventArgs e)
        {
            if (i < 9)
            {
                i++;
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\Poster2\\" + i + ".jpg";
                picBoxMovie.Image = Image.FromFile(sql);
            }
            else { i = 1; }
        }

        private void TileNSPrevious_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                --i;
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\Poster2\\" + i + ".jpg";
                picBoxMovie.Image = Image.FromFile(sql);
            }
            else { i = 9; }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.cl.Visible = true;
        }
    }
}
