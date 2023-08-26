using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StationeryManagementSystem
{
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R329GNQ\SQLEXPRESS;Initial Catalog=STM;Integrated Security=True");
        void populateOrders()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ManageOrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ViewOrderGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ManageOrder2 user = new ManageOrder2();
            user.Show();
            this.Hide();
        }

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            ViewOrderGV.CurrentRow.Selected = true;
            e.Graphics.DrawString("order Id:" + ViewOrderGV.SelectedRows[0].Cells["OrderId"].Value.ToString() + "", new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Cust Id:" + ViewOrderGV.SelectedRows[0].Cells["CustId"].Value.ToString() + "", new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 135));
            e.Graphics.DrawString("Customer Name:" + ViewOrderGV.SelectedRows[0].Cells["CustName"].Value.ToString() + "", new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 170));
            e.Graphics.DrawString("order Date:" + ViewOrderGV.SelectedRows[0].Cells["OrderDate"].Value.ToString() + "", new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 215));
            e.Graphics.DrawString("Total Amount:" + ViewOrderGV.SelectedRows[0].Cells["TotalAmt"].Value.ToString() + "", new Font("Century", 20, FontStyle.Bold), Brushes.Black, new Point(80, 250));
        }
    }
}
