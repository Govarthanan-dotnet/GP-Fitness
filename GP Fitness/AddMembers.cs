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
    public partial class AddMembers : Form
    {
        public AddMembers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LENOVO;Initial Catalog=GP_Fitness;Integrated Security=True");

        public void Clear()
        {
            name.Text = "";
            age.Text = "";
            mobileno.Text = "";
            gender.Text = "";
            fees.Text = "";
            time.Text = "";
        }
        private void AddMembers_Add_btn_Click(object sender, EventArgs e)
        {
            if (name.Text == ""|| age.Text == "" || mobileno.Text == "" || gender.Text == "" || time.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("sp_insert_Members", Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@Name", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = name.Text;
                    SqlParameter p2 = new SqlParameter("@Age", SqlDbType.Int);
                    cmd.Parameters.Add(p2).Value = age.Text;
                    SqlParameter p3 = new SqlParameter("@MobileNo", SqlDbType.VarChar);
                    cmd.Parameters.Add(p3).Value = mobileno.Text;
                    SqlParameter p4 = new SqlParameter("@Gender", SqlDbType.VarChar);
                    cmd.Parameters.Add(p4).Value = gender.Text;
                    SqlParameter p5 = new SqlParameter("@Fees", SqlDbType.Int);
                    cmd.Parameters.Add(p5).Value = fees.Text;
                    SqlParameter p6 = new SqlParameter("@Timings", SqlDbType.VarChar);
                    cmd.Parameters.Add(p6).Value = time.Text;
                    
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Members Added");
                    }
                    else
                    {
                        MessageBox.Show("Members Not Added");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Ex Exception");
                }

                Con.Close();
                Clear();

            }
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddMembers_Cancel_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();

        }

        private void AddMembers_Load(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
