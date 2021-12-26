using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomation.Entities;
using OrderAutomation.Entities.Dal;

namespace OrderAutomation.Forms
{
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private Customer _customer = new Customer();
        private CustomerDal _customerDal = new CustomerDal();
        private void CusstomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                MessageBox.Show("Lütfen bütün kutucukları doldurunuz");
            }
            else
            {
                //MessageBox.Show(_customerDal.GetByUsername(tbxUsername.Text).Username);
                if (_customerDal.GetByUsername(tbxUsername.Text) == null)
                {
                    MessageBox.Show("Bu kullanıcı sisteme kayıtlı değildir.");
                }
                else if (!_customerDal.CheckByLogin(tbxUsername.Text, tbxPassword.Text))
                {
                    MessageBox.Show("Yanlış şifre girdiniz.");
                }
                else
                {
                    using (CustomerListOrderForm customerListOrderForm = new CustomerListOrderForm(_customerDal.GetByUsername(tbxUsername.Text)))
                    {
                        this.Hide();
                        customerListOrderForm.ShowDialog();
                        this.Show();
                    }

                    tbxUsername.Text = "";
                    tbxPassword.Text = "";
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (CustomerRegisterForm customerRegisterForm = new CustomerRegisterForm())
            {
                this.Hide();
                customerRegisterForm.ShowDialog();
                this.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
