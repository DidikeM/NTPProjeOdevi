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
    public partial class CustomerToOrderForm : Form
    {
        public CustomerToOrderForm(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
        }

        private Customer _customer = new Customer();
        private Item _itemAdd = new Item();
        private ItemDal _itemDal = new ItemDal();
        private Tax _tax = new Tax();
        private TaxDal _taxDal = new TaxDal();
        private List<OrderDetail> _orderDetails = new List<OrderDetail>();
        private OrderDetailDal _orderDetailDal = new OrderDetailDal();
        private OrderDal _orderDal = new OrderDal();
        private void CustomerToOrder_Load(object sender, EventArgs e)
        {
            LoadItemDgw();
            LoadOrderDetailDgw();
        }

        private void LoadOrderDetailDgw()
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var _orderDetail in _orderDetails)
            {
                orderDetails.Add(_orderDetail);
            }
            dgwOrderDetail.DataSource = orderDetails;
        }

        private void LoadItemDgw()
        {
            dgwItem.DataSource = _itemDal.GetAll();
        }

        private void dgwItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _itemAdd.ID = Convert.ToInt32(dgwItem.CurrentRow.Cells[0].Value);
            _itemAdd = _itemDal.GetByID(_itemAdd.ID);
            lblIItemName.Text = _itemAdd.ItemName;
            lblShippingWeight.Text = _itemAdd.ShippingWeight.ToString();
            lblDescription.Text = _itemAdd.Description;
            _tax = _taxDal.GetByID(_itemAdd.TaxID);
            lblTax.Text = _tax.TaxName.TrimEnd() + " %" + _tax.TaxPercent;
            lblPrice.Text = _itemAdd.Price.ToString();
        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region int control

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_itemAdd.ID == 0)
            {
                MessageBox.Show("Lütfen önce soldaki listeden ürün seçiniz.");
            }
            else if (tbxQuantity.Text == "" || Convert.ToInt32(tbxQuantity.Text) <= 0)
            {
                MessageBox.Show("Lütfen şipariş etmek istediğiniz ürün adedini giriniz!");
            }
            else
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.calcAll(_itemAdd.ID, Convert.ToInt32(tbxQuantity.Text));
                _orderDetails.Add(orderDetail);
                tbxQuantity.Text = "";
                LoadOrderDetailDgw();
            }
        }

        private void btnToOrder_Click(object sender, EventArgs e)
        {
            if (_orderDetails.Count == 0)
            {
                MessageBox.Show("Siparişi tamamlamak için lütfer ürün ekleyiniz!");
            }
            else
            {
                Order order = new Order();
                order.calcAll(_orderDetails);
                order.CustomerID = _customer.ID;
                order.Date = DateTime.Today;
                order.Status = 0;
                _orderDal.Add(order);
                foreach (var orderDetail in _orderDetails)
                {
                    orderDetail.OrderID = order.ID;
                    _orderDetailDal.Add(orderDetail);
                }
                using (CustomerPaymentOfOrder customerPaymentOfOrder = new CustomerPaymentOfOrder(order))
                {
                    this.Hide();
                    customerPaymentOfOrder.ShowDialog();
                    this.Show();
                }
                MessageBox.Show("Sipariş başarıyla tamamlandı.");
                this.Close();
            }
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
