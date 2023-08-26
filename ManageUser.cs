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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R329GNQ\SQLEXPRESS;Initial Catalog=STM;Integrated Security=True");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UserGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {


            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserGV.CurrentRow.Selected = true;
            UnameTb.Text = UserGV.Rows[e.RowIndex].Cells["Uname"].Value.ToString();
            FnameTb.Text = UserGV.Rows[e.RowIndex].Cells["Ufullname"].Value.ToString();
            PasswordTb.Text = UserGV.Rows[e.RowIndex].Cells["Upassword"].Value.ToString();
            PhoneTb.Text = UserGV.Rows[e.RowIndex].Cells["Uphone"].Value.ToString();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + UnameTb.Text + "','" + FnameTb.Text +
               "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Added");
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
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='" + UnameTb.Text + "',Ufullname='" +
               FnameTb.Text + "',Upassword='" + PasswordTb.Text + "' where Uphone='" + PhoneTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Update");
                Con.Close();
                populate();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Enter the Users Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where UPhone='" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm user = new HomeForm();
            user.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
 }

