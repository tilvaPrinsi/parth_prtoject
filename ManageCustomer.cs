using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Microsoft.VisualBasic.ApplicationServices;


namespace StationeryManagementSystem
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R329GNQ\SQLEXPRESS;Initial Catalog=STM;Integrated Security=True");
        void populate()
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
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomersGV.CurrentRow.Selected = true;
            CustomerIdTb.Text = CustomersGV.Rows[e.RowIndex].Cells["CustId"].Value.ToString();
            CustomerNameTb.Text = CustomersGV.Rows[e.RowIndex].Cells["CustName"].Value.ToString();
            CustomerPhoneTb.Text = CustomersGV.Rows[e.RowIndex].Cells["CustPhone"].Value.ToString();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ManageOrderTbl where CustId=" + CustomerIdTb.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Orderlabel.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("select sum(TotalAmt) from ManageOrderTbl where CustId=" + CustomerIdTb.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLable.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from ManageOrderTbl where CustId=" + CustomerIdTb.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Datelabel.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerIdTb.Text == "")
            {
                MessageBox.Show("Enter the Customer Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomersTbl where CustId='" + CustomerIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomersTbl values(" + CustomerIdTb.Text + ",'" +
               CustomerNameTb.Text + "','" + CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomersTbl set CustName='" + CustomerNameTb.Text +
               "',CustPhone='" + CustomerPhoneTb.Text + "' where CustId='" + CustomerIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Update");
                Con.Close();
                populate();
            }
            catch
            {
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm user = new HomeForm();
            user.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AmountLable_Click(object sender, EventArgs e)
        {

        }
    }
    } 


