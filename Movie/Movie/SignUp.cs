using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Movie
{
    public partial class SignUp : Form
    {
        Login lg;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public SignUp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public SignUp(Login lg)
        {
            this.lg = lg;
            InitializeComponent();
            this.Da = new DataAccess();
        }


        private void AutoId()
        {

            string sql = "select * from Customer where dbid = (select MAX(dbid)  from Customer )";
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);

                int a = Convert.ToInt32(this.Ds.Tables[0].Rows[0]["dbid"]);
                // MessageBox.Show(""+a);
                a++;
                txtCustomerId.Text = ("C-" + a.ToString().PadLeft(3, '0') + "-" + DateTime.Now.Year);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }
        private void BtnProceed_Click(object sender, EventArgs e)
        {

            if (this.txtPassword.Text == this.txtConfirmPassword.Text)
            {
                string sql = @"insert into Customer
                values ('" + this.txtCustomerId.Text + "','" + this.txtName.Text + "','" + this.txtPhoneNumber.Text + "','" + this.txtEmail.Text + "');";
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Insertion Done.");
                    // this.PopulateGridView();

                    string sql2 = @"insert into Login
                values ('" + this.txtCustomerId.Text + "','" + this.txtPassword.Text + "', " + 3 + ");";
                    this.Da.ExecuteUpdateQuery(sql2);
                    // MessageBox.Show("ID : " + this.txtCustomerId.Text);




                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Password doesnt match!");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            AutoId();
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            { }

            else
            {
                MessageBox.Show("Please provide a valid email");
            }
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            this.lg.Visible = true;
            this.Visible = false;
        }
    }
}
