using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Fitness
{
    public partial class Employees : Form
    {

        public Employees()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LENOVO;Initial Catalog=GP_Fitness;Integrated Security=True");
        public void Clear()
        {
            id.Text = "";
            name.Text = "";
            age.Text = "";
            mobileno.Text = "";
            designation.Text = "";
            gender.Text = "";
            
        }
        public void Populate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch_Employees", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Employee_Add_btn_Click(object sender, EventArgs e)
        {
            if(name.Text == "" || age.Text == "" || mobileno.Text == "" ||
                designation.Text == "" || gender.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("sp_Employees", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@Name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = name.Text;
                    SqlParameter p2 = new SqlParameter("@Age", SqlDbType.Int);
                    cmd.Parameters.Add(p2).Value = age.Text;
                    SqlParameter p3 = new SqlParameter("@MobileNo", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = mobileno.Text;
                    SqlParameter p4 = new SqlParameter("@Designation", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = designation.Text;
                    SqlParameter p5 = new SqlParameter("@Gender", SqlDbType.VarChar);
                    cmd.Parameters.Add(p5).Value = gender.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Added");
                    Con.Close();
                    Populate();
                    Clear();
                }
                catch(Exception)
                {
                    MessageBox.Show("Ex exception");
                }
            }
            
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_Employees", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@Id", SqlDbType.Int);
                cmd.Parameters.Add(p1).Value = id.Text;
                SqlParameter p2 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = name.Text;
                SqlParameter p3 = new SqlParameter("@Age", SqlDbType.Int);
                cmd.Parameters.Add(p3).Value = age.Text;
                SqlParameter p4 = new SqlParameter("@MobileNo", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = mobileno.Text;
                SqlParameter p5 = new SqlParameter("@Designation", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = designation.Text;
                SqlParameter p6 = new SqlParameter("@Gender", SqlDbType.VarChar);
                cmd.Parameters.Add(p6).Value = gender.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully"); ;
                Con.Close();
                Populate();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ex exception");
            }
        }
        
            
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete_Employees", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@Id", SqlDbType.Int);
                cmd.Parameters.Add(p1).Value = id.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully"); ;
                Con.Close();
                Populate();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ex exception");
            }
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
         
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_search_Employees", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Search", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = search.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            Con.Close();
            search.Text = "";
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            age.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            mobileno.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            designation.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            gender.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mobileno_TextChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}

  