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

namespace GP_Fitness
{
    public partial class Payments : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=LENOVO;Initial Catalog=GP_Fitness;Integrated Security=True");

        public Payments()
        {
            InitializeComponent();
        }

        public void populate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch_payments", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            Con.Close();

        }
        public void Clear()
        {
            mobile.Text = "";
            name.Text = "";
            fees.Text = "";
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
           
            try
            {

                Con.Open();
        
                    SqlCommand cmd = new SqlCommand("Payments", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p3 = new SqlParameter("@Month", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = period.Text;
                    SqlParameter p4 = new SqlParameter("@MobileNo", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = mobile.Text;
                    SqlParameter p5 = new SqlParameter("@Name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p5).Value = name.Text;
                    SqlParameter p6 = new SqlParameter("@Fees", SqlDbType.Int);
                    cmd.Parameters.Add(p6).Value = fees.Text;
                     int i = cmd.ExecuteNonQuery();
                     if (i > 0)
                     {
                       MessageBox.Show("Amount Paid Successfully");
                     }
            }
            catch (Exception)
            {
                MessageBox.Show("Ex Exception");
            }
            Con.Close();
            populate();
            Clear();
        }

        

        private void search_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_Search", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Search", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = search.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            Con.Close();
            search.Text = "";
            Con.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void get_btn_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_get", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@MobileNo", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = mobile.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                name.Text = rdr.GetValue(1).ToString();

            }
            Con.Close();
        }
    }
}

