using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Movie
{
    public partial class ManageEmployee : MetroForm
    {
        HomeOfAdmin ha;
        string p;
       
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public ManageEmployee()
        {
            InitializeComponent();
           
        }
        public ManageEmployee(HomeOfAdmin ha)
        {
            this.ha = ha;
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public void PopulateGridView(string sql = "select * from Manager;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.gridManageEmployee.AutoGenerateColumns = false;
            this.gridManageEmployee.DataSource = this.Ds.Tables[0];
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string id = this.gridManageEmployee.CurrentRow.Cells["id"].Value.ToString();
            string sql = "delete from Manager where id = '" + id + "';";
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

            txtId.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtSalary.Clear();
            txtEmail.Clear();
            txtDesignation.Clear();

            AutoId();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home h2 = new Home();
            h2.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ha.Visible = true;
        }

        private string AutoPassword()
        {
            string sql = "select * from Manager where dbid = (select MAX(dbid)  from Manager )";
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);

                int a = Convert.ToInt32(this.Ds.Tables[0].Rows[0]["dbid"]);
                // MessageBox.Show(""+a);
                a++;
                p = (a.ToString().PadLeft(3, '0') + 00 + DateTime.Now.Year);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            return p;
        }
        private void AutoId()
        {

            string sql = "select * from Manager where dbid = (select MAX(dbid)  from Manager )";
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);

                int a = Convert.ToInt32(this.Ds.Tables[0].Rows[0]["dbid"]);
                // MessageBox.Show(""+a);
                a++;
                txtId.Text = ("E-" + a.ToString().PadLeft(3, '0') + "-" + DateTime.Now.Year);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            AutoId();
        }

        private void BtnInsertorUpdate_Click(object sender, EventArgs e)
        {
            string sql = "select * from Manager where id ='" + this.txtId.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update Manager
                set id = '" + this.txtId.Text + @"',
                name = '" + this.txtName.Text + @"',
                designation = '" + this.txtDesignation.Text + @"',
                phonenumber = '" + this.txtPhoneNumber.Text + @"',
                salary = '" + this.txtSalary.Text + @"',
                email = '" + this.txtEmail.Text + @"'

                where id = '" + this.txtId.Text + "';";

                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Upgradation Done.");
                    this.PopulateGridView();

                    txtId.Clear();
                    txtName.Clear();
                    txtPhoneNumber.Clear();
                    txtSalary.Clear();
                    txtEmail.Clear();
                    txtDesignation.Clear();

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else if (this.txtName.Text == "")
            {
                MessageBox.Show("You must provie a name..");
            }
            else if (this.txtEmail.Text == "")
            {
                MessageBox.Show("You must provie an email..");
            }
            else if (this.txtDesignation.Text == "")
            {
                MessageBox.Show("You must provie an designation..");
            }
            else if (this.txtPhoneNumber.Text == "")
            {
                MessageBox.Show("You must provie a phone number..");
            }
            else if (this.txtSalary.Text == "")
            {
                MessageBox.Show("You must provie salary..");
            }

            else
            {



                sql = @"insert into Manager
                values ('" + this.txtId.Text + "','" + this.txtName.Text + "','" + this.txtDesignation.Text + "','" + this.txtPhoneNumber.Text + "','" + this.txtSalary.Text + "','" + this.txtEmail.Text + "');";
                try
                {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Insertion Done.");
                    this.PopulateGridView();

                    string sql2 = @"insert into Login
                values ('" + this.txtId.Text + "','" + AutoPassword() + "', " + 2 + ");";
                    this.Da.ExecuteUpdateQuery(sql2);
                    MessageBox.Show("ID : " + txtId.Text +"Password : "+ p);
                   // MessageBox.Show(""+p);




                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
                txtId.Clear();
                txtName.Clear();
                txtPhoneNumber.Clear();
                txtSalary.Clear();
                txtEmail.Clear();
                txtDesignation.Clear();

                AutoId();

            }

        }

        private void GridManageEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = this.gridManageEmployee.CurrentRow.Cells["id"].Value.ToString();
            this.txtName.Text = this.gridManageEmployee.CurrentRow.Cells["name"].Value.ToString();
            this.txtDesignation.Text = this.gridManageEmployee.CurrentRow.Cells["designation"].Value.ToString();
            this.txtPhoneNumber.Text = this.gridManageEmployee.CurrentRow.Cells["phonenumber"].Value.ToString();
            this.txtSalary.Text = this.gridManageEmployee.CurrentRow.Cells["salary"].Value.ToString();
            this.txtEmail.Text = this.gridManageEmployee.CurrentRow.Cells["email"].Value.ToString();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Manager where id like '" + this.txtSearch.Text + "%' or name like '" + this.txtSearch.Text + "%' or designation like '" + this.txtSearch.Text + "%' or phonenumber like '" + this.txtSearch.Text + "%' or email like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
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

    }
}
