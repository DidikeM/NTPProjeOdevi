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
    public partial class DnmForm : Form
    {
        public DnmForm()
        {
            InitializeComponent();
        }

        private CustomerDal _customerDal = new CustomerDal();
        private void DnmForm_Load(object sender, EventArgs e)
        {
            //dgwdeneme.DataSource = _customerDal.GetAll();
            //Customer customer = new Customer()
            //{
            //    AddressID = 2,
            //    Name = "asdased",
            //    PhoneNumber = 05511307142,
            //    Password = "asdasdasd",
            //    Username = "asdasdaasd"
            //};
            //_customerDal.Add(customer);
            //dgwdeneme.DataSource = _customerDal.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
