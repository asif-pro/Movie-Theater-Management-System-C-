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
    public partial class Confirmation : MetroForm
    {
        BuyTicket b;
        string sql,id;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Confirmation()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public Confirmation(BuyTicket b, string mn, string st, int t, int amount, string id)
        {
            InitializeComponent();
            this.b = b;
            this.id = id;
            txtMovieName.Text = mn;
            txtShowtime.Text = st;
            txtNumberOfTickets.Text = t.ToString();
            txtTotalAmount.Text = amount.ToString();
            this.Da = new DataAccess();

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            /*this.Visible = false;
            Home h3 = new Home();
            h3.Visible = true;*/
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.b.Visible = true;

        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            if (txtMovieName != null)
            {
                try
                {
                    MessageBox.Show("please pay the amount of " + txtTotalAmount.Text);
                    sql = @"insert into History
                values ('" + this.txtMovieName.Text + "','" + Convert.ToString( this.txtShowtime.Text) + "','" + Convert.ToInt32(txtNumberOfTickets.Text) + "','" + this.id + "');";
                    this.Da.ExecuteQuery(sql);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }



        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

        }
   
    }
}
