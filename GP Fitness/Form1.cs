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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LENOVO;Initial Catalog=GP_Fitness;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            id_txt.Text ="";
            password_txt.Text = "";
        
        }
        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Id");

                }
                if (password_txt.Text == "")
                {
                    MessageBox.Show("Please Enter Password");
                }
                else
                {
                    Con.Open();
                    
                    
                    if (id_txt.Text == "admin" && password_txt.Text == "admin")
                    {
                        MessageBox.Show("Login Successfully");
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Password");
                        Clear();
                    }
            }



            }
           catch(Exception)
            {
                MessageBox.Show("something problem");
            }
            Con.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
