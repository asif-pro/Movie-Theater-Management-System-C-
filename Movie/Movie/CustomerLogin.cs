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
    public partial class CustomerLogin : MetroForm
    {    Login lg;
        string id,pw;

        public CustomerLogin()
        {
            InitializeComponent();
        }
        public CustomerLogin(Login lg,string id, string pw )
        {
            InitializeComponent();
            this.id = id;
            this.lg = lg;
            this.pw = pw;
        }

        private void TxtPreviousHistory_Click(object sender, EventArgs e)
        {
            PreviousTicketHistory ph = new PreviousTicketHistory (this,id);
            ph.Visible = true;
            this.Visible = false;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home hm = new Home();
            hm.Visible = true;
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            
           /* ChangePassword cp = new ChangePassword(this,id);
            cp.Visible = true;
            this.Visible = false;*/
        }

        private void TxtBuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicket bt = new BuyTicket(this,id);
            bt.Visible = true;
            this.Visible = false;
        }
    }
}
