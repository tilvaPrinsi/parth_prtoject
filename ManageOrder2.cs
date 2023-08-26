using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    public partial class ManageOrder2 : Form
    {
        public ManageOrder2()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R329GNQ\SQLEXPRESS;Initial Catalog=STM;Integrated Security=True");
        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                // CatCombo.ValueMember = "CatName";
                // CatCombo.DataSource = dt;
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {
            }
        }
        void populateOrders()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomersTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        void populateProduct()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl1";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
            }
        }
        void updateproduct()
        {
            ProductsGV.CurrentRow.Selected = true;
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0)
                MessageBox.Show("Operation Failed");
            else
            {
                Con.Open();
                string query = "update ProductTbl1 set ProdQty = " + newQty + " where ProdId=" + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateProduct();
            }
        }
        private void ManageOrder2_Load(object sender, EventArgs e)
        {
           
            populateOrders();
            populateProduct();
            fillcategory();
            OrderGv.ColumnCount = 5;
            OrderGv.Columns[0].Name = "No.";
            OrderGv.Columns[1].Name = "Product Name";
            OrderGv.Columns[2].Name = "Price";
            OrderGv.Columns[3].Name = "Qnt";
            OrderGv.Columns[4].Name = "Total Price";
            OrderGv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderGv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderGv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderGv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderGv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        int num = 0;
        int uprice, totprice, qty;
        string product;

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustIdTb.Text = CustomersGV.Rows[e.RowIndex].Cells["CustId"].Value.ToString();
            CustNameTb.Text = CustomersGV.Rows[e.RowIndex].Cells["CustName"].Value.ToString();
        }
        private void CatCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl1 where ProdCat='" + CatCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {
            }
        }
        int flag = 0;
        int stock;
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductsGV.CurrentRow.Selected = true;
            ProductIdTb.Text = ProductsGV.Rows[e.RowIndex].Cells["ProdId"].Value.ToString();
            ProductNameTb.Text = ProductsGV.Rows[e.RowIndex].Cells["ProdName"].Value.ToString();
            ProdPriceTb.Text = ProductsGV.Rows[e.RowIndex].Cells["ProdPrice"].Value.ToString();
            StockTb.Text = ProductsGV.Rows[e.RowIndex].Cells["ProdQty"].Value.ToString();
            id = Convert.ToInt32(ProductIdTb.Text);
            stock = Convert.ToInt32(StockTb.Text);
            QtyTb.Text = "";
            flag = 1;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        int sum = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CustomerIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void OrderDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrderIdTb.Text == "" || CustIdTb.Text == "" || CustNameTb.Text == "" || TotalAmountTb.Text == "")
            {
                MessageBox.Show("Fill The data Correctly");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ManageOrderTbl values(" + OrderIdTb.Text + ",'" + CustIdTb.Text
               + "','" + CustNameTb.Text + "'," + OrderDate.Text + "," + TotalAmountTb.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully ");
                Con.Close();
                populateOrders();
                try
                {
                }
                catch
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewOrder View = new ViewOrder();
            View.Show();
            this.Hide();
        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm user = new HomeForm();
            user.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
                MessageBox.Show("enter the Quantity of Product");
            else if (flag == 0)
                MessageBox.Show("select the product");
            else if (Convert.ToInt32(QtyTb.Text) >= stock)
                MessageBox.Show("No Enough Stock Available");
            else
            {
                num = num + 1;
                product = ProductNameTb.Text;
                uprice = Convert.ToInt32(ProdPriceTb.Text);
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                OrderGv.Rows.Add(num, product, uprice, qty, totprice);
                flag = 0;
            }
            sum = sum + totprice;
            TotalAmountTb.Text = sum.ToString();
            updateproduct();
        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
