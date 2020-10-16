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
    public partial class HomeOfAdmin : MetroForm
    {
        string cp,idd;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        Login l;
        public HomeOfAdmin()
        {
            InitializeComponent();
        }
        public HomeOfAdmin(Login lg,string cp,string id)
        {
            InitializeComponent();
            this.l = lg;
            this.cp = cp;
            this.idd = id;
            this.Da = new DataAccess();
            this.PopulateGridView();
        }


        public void PopulateGridView(string sql = "select * from Movies;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.gridMovie.AutoGenerateColumns = false;
            this.gridMovie.DataSource = this.Ds.Tables[0];
        }
        private void BtnAccountSettings_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangePassword cpp = new ChangePassword(this,cp,idd);
            cpp.Visible = true;
        }

        private void BtnManageEmployee_Click(object sender, EventArgs e)
        {
            ManageEmployee me = new ManageEmployee(this);
            me.Visible = true;
            this.Visible = false;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.l.Visible = true;
            this.Visible = false;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Movies where id like '" + this.txtSearch.Text + "%' or name like '" + this.txtSearch.Text + "%' or hall like '" + this.txtSearch.Text + "%' or gener like  '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }
    }
}
