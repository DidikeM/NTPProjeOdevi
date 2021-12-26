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
    public partial class CustomerListOrderForm : Form
    {
        public CustomerListOrderForm(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
        }
        private Customer _customer = new Customer();
        private OrderDal _orderDal = new OrderDal();
        private OrderDetailDal _orderDetailDal = new OrderDetailDal();

        private void CustomerListOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrdersDgw();
        }

        private void LoadOrdersDgw()
        {
            dgwOrder.DataSource = _orderDal.GetByCustomerID(_customer.ID);
        }

        private void btnToOrder_Click(object sender, EventArgs e)
        {
            using (CustomerToOrderForm customerToOrderForm = new CustomerToOrderForm(_customer))
            {
                this.Hide();
                customerToOrderForm.ShowDialog();
                this.Show();
            }
            LoadOrdersDgw();
        }

        private void dgwOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadOrderDetailDgw();
        }

        private void LoadOrderDetailDgw()
        {
            dgwOrderDetail.DataSource = _orderDetailDal.GetByOrderID(Convert.ToInt32(dgwOrder.CurrentRow.Cells[0].Value));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
