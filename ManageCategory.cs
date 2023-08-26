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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R329GNQ\SQLEXPRESS;Initial Catalog=STM;Integrated Security=True");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoryGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + CatIdTb.Text + "','" + CatNameTb.Text +
               "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {
            }
        }

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryGV.CurrentRow.Selected = true;

            CatIdTb.Text = CategoryGV.Rows[e.RowIndex].Cells["CatId"].Value.ToString();
            CatNameTb.Text = CategoryGV.Rows[e.RowIndex].Cells["CatName"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTbl set CatName='" + CatNameTb.Text + "' where CatId='" + CatIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Update");
                Con.Close();
                populate();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (CatIdTb.Text == "")
                {
                    MessageBox.Show("Enter the Category Id");
                }
                else
                {
                    Con.Open();
                    string myquery = "delete from CategoryTbl where CatId='" + CatIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Deleted");
                    Con.Close();
                    populate();
                }

            }
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm user = new HomeForm();
            user.Show();
            this.Hide();
        }
    }
}
    

