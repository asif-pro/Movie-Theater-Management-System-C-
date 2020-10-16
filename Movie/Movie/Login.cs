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
    public partial class Login : MetroForm
    {
        Home h;
        string status;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public Login(Home h1)
        {
            InitializeComponent();
            this.h = h1;
            this.Da = new DataAccess();

        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string un = "select * from Login where id = '" + this.txtUserName.Text.ToString() + "' and password = '" + this.txtPassword.Text.ToString() + "';";
            this.Ds = this.Da.ExecuteQuery(un);

            status = this.Ds.Tables[0].Rows[0]["status"].ToString();
            string id = txtUserName.Text;
            string pw = txtPassword.Text;


            if (this.Ds.Tables[0].Rows.Count == 1)
            {
               
                if (status == "1")

                {
                    this.Visible = false;
                    HomeOfAdmin a = new HomeOfAdmin(this,id,pw);
                    a.Visible = true;
                }
                  else if (status == "2")
                  {
                      this.Visible = false;
                      ManagerHome m = new ManagerHome(this);
                      m.Visible = true;
                  }
                  else if (status == "3")
                  {
                    

                      this.Visible = false;
                      CustomerLogin u = new CustomerLogin(this,id,pw);
                      u.Visible = true;
                  }

            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.h.Visible = true;
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp(this);
            su.Visible = true;
            this.Visible = false;
        }

        private void TxtUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
