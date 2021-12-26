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
    public partial class AdminMenageForm : Form
    {
        public AdminMenageForm()
        {
            InitializeComponent();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            using (AdminItemMenageForm adminItemMenageForm = new AdminItemMenageForm())
            {
                this.Hide();
                adminItemMenageForm.ShowDialog();
                this.Show();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            using (AdminCustomerMenageForm adminCustomerMenageForm = new AdminCustomerMenageForm())
            {
                this.Hide();
                adminCustomerMenageForm.ShowDialog();
                this.Show();
            }
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            using (AdminTaxMenageForm adminTaxMenageForm = new AdminTaxMenageForm())
            {
                this.Hide();
                adminTaxMenageForm.ShowDialog();
                this.Show();
            }
        }

        private void pbxGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminMenageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
