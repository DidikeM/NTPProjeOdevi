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
    public partial class CustomerRegisterForm : Form
    {
        public CustomerRegisterForm()
        {
            InitializeComponent();
        }

        private Customer _Customer = new Customer();
        private Address _Address = new Address();
        private AddressDal _addressDal = new AddressDal();
        private CustomerDal _customerDal = new CustomerDal();
        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {

        }

        #region User Proparties

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            _Customer.Name = tbxName.Text;
        }

        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region int kontrol

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            #endregion
        }

        private void tbxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbxPhoneNumber.Text != "")
            {
                _Customer.PhoneNumber = Convert.ToDouble(tbxPhoneNumber.Text);
            }
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            _Customer.Username = tbxUsername.Text;
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            _Customer.Password = tbxPassword.Text;
        }

        #endregion

        #region Address proparties

        private void tbxCountry_TextChanged(object sender, EventArgs e)
        {
            _Address.Country = tbxCountry.Text;
        }

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            _Address.City = tbxCity.Text;
        }

        private void tbxDistrict_TextChanged(object sender, EventArgs e)
        {
            _Address.District = tbxDistrict.Text;
        }

        private void tbxStreet_TextChanged(object sender, EventArgs e)
        {
            _Address.Street = tbxStreet.Text;
        }

        private void tbxNo_TextChanged(object sender, EventArgs e)
        {
            _Address.No = tbxNo.Text;
        }

        private void tbxNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region int or / kontrol

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }

            #endregion
        }

        private void tbxDescriotion_TextChanged(object sender, EventArgs e)
        {
            _Address.Description = tbxDescriotion.Text;
        }

        #endregion

        private void btnCheckAndPush_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPhoneNumber.Text == "" || tbxUsername.Text == "" || tbxPassword.Text == "" || tbxCountry.Text == "" || tbxCity.Text == "" || tbxDistrict.Text == "" || tbxStreet.Text == "" || tbxNo.Text == "" || tbxDescriotion.Text == "")
            {
                MessageBox.Show("Lütfen bütün kutucukları doldurunuz");
            }
            else
            {
                //MessageBox.Show(_customerDal.GetByUsername(tbxUsername.Text).Username);
                if (_customerDal.GetByUsername(tbxUsername.Text) != null)
                {
                    MessageBox.Show("Bu kullanıcı adı kullanılmaktadır.");
                }
                else if (_customerDal.GetByPhoneNumber(Convert.ToDouble(tbxPhoneNumber.Text)) != null)
                {
                    MessageBox.Show("Bu telefon numarası kullanılmaktadır.");
                }
                else
                {
                    _addressDal.Add(_Address);
                    _Customer.AddressID = _Address.ID;
                    _customerDal.Add(_Customer);
                    //MessageBox.Show("Yok");
                    this.Close();
                }
            }
            //dgwdnm.DataSource = _addressDal.GetAll();
            //MessageBox.Show(_Address.Country + "\n" + _Address.City + "\n" + _Address.District + "\n" + _Address.Street + "\n" + _Address.No + "\n" + _Address.Description);
            //_addressDal.Add(_Address);
            //MessageBox.Show(_Address.ID.ToString());
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
