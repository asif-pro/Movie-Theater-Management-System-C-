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
    public partial class Home : MetroForm
    {
        int j = 1;
        int i = 1;
        public Home()
        {
            InitializeComponent();
        }

        private void BtnLoginorSignup_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login l1 = new Login(this);
            l1.Visible = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timerUpcoming.Start();
            timerNowShowing.Start();
        }



        private void TileUCNext_Click(object sender, EventArgs e)
        {
            if (j < 8)
            {
                j++;
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\UpcomingImages\\" + j + ".jpg";
                pBoxUpcomings.Image = Image.FromFile(sql);
            }
            else { j = 1; }
        }
        
        private void TimerUpcoming_Tick(object sender, EventArgs e)
        {
            if (j < 8)
            {
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\UpcomingImages\\" + j + ".jpg";
                pBoxUpcomings.Image = Image.FromFile(sql);
                j++;
            }
            else { j = 1; }
        }
       
        private void TimerNowShowing_Tick(object sender, EventArgs e)
        {

            if (i < 9)
            {
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\Poster2\\" + i + ".jpg";
                pBoxNowShowing.Image = Image.FromFile(sql);
                i++;
            }
            else { i = 1; }

        }

        private void TileNSNext_Click(object sender, EventArgs e)
        {
            if (i < 9)
            {
                i++;
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\Poster2\\" + i + ".jpg";
                pBoxNowShowing.Image = Image.FromFile(sql);
            }
            else { i = 1; }
        }

        private void TileNSPrevious_Click(object sender, EventArgs e)
        {
            
            if (i>1)
            {
                --i;
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\Poster2\\" + i + ".jpg";
                pBoxNowShowing.Image = Image.FromFile(sql);
            }
            else { i = 9; }
        }

        private void TileUCPrevious_Click(object sender, EventArgs e)
        {
            if (j > 1)
            {
                --j;
                string sql = "C:\\Users\\USER\\Desktop\\Movie\\Movie\\UpcomingImages\\" + j + ".jpg";
                pBoxUpcomings.Image = Image.FromFile(sql);
            }
            else { j = 8; }
        }
    }
}
