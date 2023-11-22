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

namespace GP_Fitness
{
    public partial class ViewMembers : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=LENOVO;Initial Catalog=GP_Fitness;Integrated Security=True");

        public ViewMembers()
        {
            InitializeComponent();
        }
        public void Members()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch_Members",Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            Members();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            dgv.DataSource = ds.Tables[0];
            Con.Close();
            search.Text = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            Members();

        }
    }
}
