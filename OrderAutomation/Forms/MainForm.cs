using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderAutomation.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            using (AdminLoginForm adminLoginForm = new AdminLoginForm())
            {
                this.Hide();
                adminLoginForm.ShowDialog();
                this.Show();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            using (CustomerLoginForm customerLoginForm = new CustomerLoginForm())
            {
                this.Hide();
                customerLoginForm.ShowDialog();
                this.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
