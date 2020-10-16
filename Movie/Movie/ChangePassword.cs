using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class ChangePassword : Form
    {
        HomeOfAdmin ha;
        string id,cp;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(HomeOfAdmin ha,string id,string cp)
        {
            this.id = id;
            this.cp = cp;
            this.ha = ha;
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            this.ha.Visible = true;
            this.Visible = false;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            string sql = "select * from Login where id ='" + this.id + "';";
            this.Ds = this.Da.ExecuteQuery(sql);


            if (cp == txtOldPassword.Text)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                     sql = @"update Login
                set password = '" + this.txtConfirmPassword.Text + @"'
                where id = '" + this.id + "';";

                    try
                    {
                        this.Da.ExecuteUpdateQuery(sql); 
                        MessageBox.Show("Password Changed Successfully");
                        MessageBox.Show("You Need to Log in Again providing new Password");

                        Login lg = new Login();
                        lg.Visible = true;
                        this.Visible = false;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error: " + exc.Message);
                    }
                }
                else { MessageBox.Show("New Password & Password didn't Mactched"); }
            }
            else { MessageBox.Show("Old Password didn't Mactched"); }

            

        }
    }
}
