using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderAutomation.Entities.Dal;

namespace OrderAutomation.Forms
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private AdminDal _adminDal = new AdminDal();

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            //Controls.Remove(gbxMenage);
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
                if (_adminDal.GetByUsername(tbxUsername.Text) == null)
                {
                    MessageBox.Show("Bu kullanıcı sisteme kayıtlı değildir.");
                }
                else if (!_adminDal.CheckByLogin(tbxUsername.Text, tbxPassword.Text))
                {
                    MessageBox.Show("Yanlış şifre girdiniz.");
                }
                else
                {
                    //Controls.Add(gbxMenage);
                    //Controls.Remove(gbxLogin);
                    using (AdminMenageForm adminMenageForm = new AdminMenageForm())
                    {
                        this.Hide();
                        adminMenageForm.ShowDialog();
                        this.Show();
                    }
                    tbxUsername.Text = "";
                    tbxUsername.Enabled = false;
                    tbxPassword.Text = "";
                    tbxPassword.Enabled = false;
                }
            }
        }

        //private void btnItem_Click(object sender, EventArgs e)
        //{
        //    using (AdminItemMenageForm adminItemMenageForm = new AdminItemMenageForm())
        //    {
        //        this.Hide();
        //        adminItemMenageForm.ShowDialog();
        //        this.Show();
        //    }
        //}

        //private void btnCustomer_Click(object sender, EventArgs e)
        //{
        //    using (AdminCustomerMenageForm adminCustomerMenageForm = new AdminCustomerMenageForm())
        //    {
        //        this.Hide();
        //        adminCustomerMenageForm.ShowDialog();
        //        this.Show();
        //    }
        //}

        //private void btnTax_Click(object sender, EventArgs e)
        //{
        //    using (AdminTaxMenageForm adminTaxMenageForm = new AdminTaxMenageForm())
        //    {
        //        this.Hide();
        //        adminTaxMenageForm.ShowDialog();
        //        this.Show();
        //    }
        //}

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
