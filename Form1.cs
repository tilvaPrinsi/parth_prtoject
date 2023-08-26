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

namespace StationeryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R329GNQ\SQLEXPRESS;Initial Catalog=STM;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*  private void button2_Click(object sender, EventArgs e)
         {



          private void checkBox1_CheckedChanged(object sender, EventArgs e)
          {

          }
      }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                PwdTb.UseSystemPasswordChar = false;
            else
                PwdTb.UseSystemPasswordChar = true;



        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PwdTb.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PwdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Uname='" + UNameTb.Text + "' and Upassword = '" + PwdTb.Text + "'",Con);
           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm cust = new HomeForm();
                cust.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
            }
            Con.Close();
        }

        private void UNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

