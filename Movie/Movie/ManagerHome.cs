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
    public partial class ManagerHome : MetroForm
    {
        Login lg;
        public ManagerHome()
        {
            InitializeComponent();
        }
        public ManagerHome(Login lg)
        {
            InitializeComponent();
            this.lg = lg;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Visible = true;
            this.Visible = false;
        }

        private void TxtManageAccount_Click(object sender, EventArgs e)
        {
            SetMovie sm = new SetMovie(this);
            sm.Visible = true;
            this.Visible = false;
        }

        private void TxtManageMovie_Click(object sender, EventArgs e)
        {
            Upcomings up = new Upcomings(this);
            up.Visible = true;
            this.Visible = false;
        }
    }
}
