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
    public partial class PreviousTicketHistory : MetroForm
    {
        string id;
        
        CustomerLogin cl;
        string nname;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public PreviousTicketHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public PreviousTicketHistory(CustomerLogin cl, string id)
        {

            InitializeComponent();
            this.id = id;
            this.cl = cl;
            this.Da = new DataAccess();
            this.PopulateGridView();
           
        }

    
        
        public void PopulateGridView(string sql = "select * from History;")
        {
           // string sq = "delete from Manager where id = '" + this.id + "';";
            this.Ds = this.Da.ExecuteQuery(sql);
            

            this.gridHistory.AutoGenerateColumns = false;
            this.gridHistory.DataSource = this.Ds.Tables[0];
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Visible = true;
            this.Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.cl.Visible = true;
            this.Visible = false;
        }

        private void PreviousTicketHistory_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //int t = Convert.ToInt32(this.historyGrid.CurrentRow.Cells["ticket"].Value.ToString());
            //string name = this.historyGrid.CurrentRow.Cells["name"].Value.ToString();

            // string sql = "delete from History where name = '" + name + "';";

            //string name = this.gridHistory.CurrentRow.Cells["name"].Value.ToString();
            string sql = "delete from History where name = '" + this.nname + "';";
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


        }

        private void GridHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                this.nname = this.gridHistory.CurrentRow.Cells["name"].Value.ToString();

        }
    }
}
