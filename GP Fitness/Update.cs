using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Fitness
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LENOVO;Initial Catalog=GP_Fitness;Integrated Security=True");

        public void Members()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch_Members", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            Members();
        }
        public void Clear()
        {
            id.Text = "";
            name.Text = "";
            age.Text = "";
            mobileno.Text = "";
            gender.Text = "";
            fees.Text = "";
            time.Text = "";
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            age.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            mobileno.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            gender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            fees.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            time.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Search_ViewMembers", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Search", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = search.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
            search.Text = "";
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            Members();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_delete_Members", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Id", SqlDbType.Int);
            cmd.Parameters.Add(p1).Value = id.Text;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Deleted Successfully");
            }
            Con.Close();
            Members();
            Clear();
        }

        private void Update_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_Members", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@Id", SqlDbType.Int);
                cmd.Parameters.Add(p1).Value = id.Text;
                SqlParameter p2 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = name.Text;
                SqlParameter p3 = new SqlParameter("@Age", SqlDbType.Int);
                cmd.Parameters.Add(p3).Value = age.Text;
                SqlParameter p4 = new SqlParameter("@MobileNo", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = mobileno.Text;
                SqlParameter p5 = new SqlParameter("@Gender", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = gender.Text;
                SqlParameter p6 = new SqlParameter("@Fees", SqlDbType.Int);
                cmd.Parameters.Add(p6).Value = fees.Text;
                SqlParameter p7 = new SqlParameter("@Timings", SqlDbType.VarChar);
                cmd.Parameters.Add(p7).Value = time.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                Con.Close();
                Members();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("ex Exception");
            }
        }
    }
}
