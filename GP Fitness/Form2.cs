using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Fitness
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddMembers_btn_Click(object sender, EventArgs e)
        {
            AddMembers addMembers = new AddMembers();
            addMembers.Show();
            this.Hide();
        }

        private void ViewMember_btn_Click(object sender, EventArgs e)
        {
            ViewMembers vm = new ViewMembers();
            vm.Show();
            this.Hide();

        }

        private void Employees_btn_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void Update_delete_btn_Click(object sender, EventArgs e)
        {
            Update ud = new Update();
            ud.Show();
            this.Hide();
        }
        private void Payment_btn_Click(object sender, EventArgs e)
        {
            Payments p = new Payments();
            p.Show();
            this.Hide();

        }
    }
}
