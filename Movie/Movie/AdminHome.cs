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
    public partial class AdminHome : MetroForm
    {
        Login l;
        public AdminHome()
        {
            InitializeComponent();
        }
        public AdminHome(Login lg)
        {
            InitializeComponent();
            this.l = lg;

        }

        private void BtnLgO_Click(object sender, EventArgs e)
        {
            this.l.Visible = true;
            this.Visible = false;
        }

        private void BtnManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee me = new ManageEmployee();
            me.Visible = true;
            this.Visible = false;
        }
    }
}
