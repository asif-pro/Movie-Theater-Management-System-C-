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
    public partial class TicketHistory : MetroForm
    {
        CustomerLogin cl;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        public TicketHistory()
        {
          
            InitializeComponent();
           this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public TicketHistory(CustomerLogin cl)
        {

            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.cl = cl;
        }
        public void PopulateGridView(string sql = "select * from History;")
    {
        this.Ds = this.Da.ExecuteQuery(sql);

        this.historyGrid.AutoGenerateColumns = false;
        this.historyGrid.DataSource = this.Ds.Tables[0];
            this.PopulateGridView();
        }

    private void BtnDelete_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(this.historyGrid.CurrentRow.Cells["ticket"].Value.ToString());


            string name = this.historyGrid.CurrentRow.Cells["name"].Value.ToString();
            string sql = "delete from History where name = '" + name + "';";
            try
            {

                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                this.PopulateGridView();

                string sql1 = "select * from  where name = '" + name + "';";
                this.Ds = this.Da.ExecuteQuery(sql1);

               int a = Convert.ToInt32(this.Ds.Tables[0].Rows[0]["remainingticket"].ToString());

                a = a + t ;

                string sql2 = "update Movies remainingticket = '" + a + "';";
              //  this.Ds = this.Da.ExecuteUpdateQuery(sql2);

                


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }

        private void TicketHistory_Load(object sender, EventArgs e)
        {
            //this.Visible = true;
            this.PopulateGridView();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.cl.Visible = true;
            this.Visible = false;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Visible = true;
            this.Visible = false;
        }
    }
}
