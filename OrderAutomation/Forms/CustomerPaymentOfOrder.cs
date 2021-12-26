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

namespace OrderAutomation.Forms
{
    public partial class CustomerPaymentOfOrder : Form
    {
        public CustomerPaymentOfOrder(Order order)
        {
            _order = order;
            InitializeComponent();
        }
        private Order _order;//= new Order();

        private void CustomerPaymentOfOrder_Load(object sender, EventArgs e)
        {
            tbxCash.Enabled = false;
            tbxCredit.Enabled = false;
            tbxCheck.Enabled = false;
        }

        private void cbxCash_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCash.Checked)
            {
                if (cbxCredit.Checked && cbxCheck.Checked)
                {
                    MessageBox.Show("En fazla 2 Ödeme yöntemi kullanabilirsiniz.");
                    cbxCash.Checked = false;
                }
                else if (cbxCredit.Checked || cbxCheck.Checked)
                {
                    if (cbxCredit.Checked)
                    {
                        tbxCash.Enabled = true;
                        tbxCash.Text = "0.00";
                        tbxCredit.Enabled = true;
                        tbxCredit.Text = "0,00";
                    }
                    else
                    {
                        tbxCash.Enabled = true;
                        tbxCash.Text = "0.00";
                        tbxCheck.Enabled = true;
                        tbxCheck.Text = "0,00";
                    }
                }
                else
                {
                    tbxCash.Text = _order.TotalPrice.ToString();
                }
            }
            else
            {
                tbxCash.Enabled = false;
                tbxCash.Text = "";
            }
        }

        private void cbxCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCredit.Checked)
            {
                if (cbxCash.Checked && cbxCheck.Checked)
                {
                    MessageBox.Show("En fazla 2 Ödeme yöntemi kullanabilirsiniz.");
                    cbxCredit.Checked = false;
                }
                else if (cbxCash.Checked || cbxCheck.Checked)
                {
                    if (cbxCash.Checked)
                    {
                        tbxCredit.Enabled = true;
                        tbxCredit.Text = "0,00";
                        tbxCash.Enabled = true;
                        tbxCash.Text = "0.00";
                    }
                    else
                    {
                        tbxCredit.Enabled = true;
                        tbxCredit.Text = "0,00";
                        tbxCheck.Enabled = true;
                        tbxCheck.Text = "0,00";
                    }

                }
                else
                {
                    tbxCredit.Text = _order.TotalPrice.ToString();
                }
            }
            else
            {
                tbxCredit.Enabled = false;
                tbxCredit.Text = "";
            }
        }

        private void cbxCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCheck.Checked)
            {
                if (cbxCash.Checked && cbxCredit.Checked)
                {
                    MessageBox.Show("En fazla 2 Ödeme yöntemi kullanabilirsiniz.");
                    cbxCheck.Checked = false;

                }
                else if (cbxCash.Checked || cbxCredit.Checked)
                {
                    if (cbxCredit.Checked)
                    {
                        tbxCredit.Enabled = true;
                        tbxCredit.Text = "0,00";
                        tbxCheck.Enabled = true;
                        tbxCheck.Text = "0,00";
                    }
                    else
                    {
                        tbxCash.Enabled = true;
                        tbxCash.Text = "0,00";
                        tbxCheck.Enabled = true;
                        tbxCheck.Text = "0,00";
                    }

                }
                else
                {
                    tbxCheck.Text = _order.TotalPrice.ToString();
                }
            }
            else
            {
                tbxCheck.Enabled = false;
                tbxCheck.Text = "";
            }
        }

        private void tbxCash_TextChanged(object sender, EventArgs e)
        {
            if (tbxCash.Text != "")
            {
                if (Convert.ToDecimal(tbxCash.Text) < _order.TotalPrice)
                {
                    if (cbxCredit.Checked)
                    {
                        tbxCredit.Text = (_order.TotalPrice - Convert.ToDecimal(tbxCash.Text)).ToString();
                    }
                    else if (cbxCheck.Checked)
                    {
                        tbxCheck.Text = (_order.TotalPrice - Convert.ToDecimal(tbxCash.Text)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Ödemeniz gereken miktardan daha fazla girdiniz");
                    tbxCash.Text = _order.TotalPrice.ToString();
                    if (cbxCredit.Checked)
                    {
                        tbxCredit.Text = "0,00";
                    }
                    else if (cbxCheck.Checked)
                    {
                        tbxCheck.Text = "0,00";
                    }
                }
            }
        }

        private void tbxCredit_TextChanged(object sender, EventArgs e)
        {
            if (tbxCredit.Text != "")
            {
                if (Convert.ToDecimal(tbxCredit.Text) < _order.TotalPrice)
                {
                    if (cbxCash.Checked)
                    {
                        tbxCash.Text = (_order.TotalPrice - Convert.ToDecimal(tbxCredit.Text)).ToString();
                    }
                    else if (cbxCheck.Checked)
                    {
                        tbxCheck.Text = (_order.TotalPrice - Convert.ToDecimal(tbxCredit.Text)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Ödemeniz gereken miktardan daha fazla girdiniz");
                    tbxCredit.Text = _order.TotalPrice.ToString();
                    if (cbxCash.Checked)
                    {
                        tbxCash.Text = "0,00";
                    }
                    else if (cbxCheck.Checked)
                    {
                        tbxCheck.Text = "0,00";
                    }
                }
            }
        }

        private void tbxCheck_TextChanged(object sender, EventArgs e)
        {
            if (tbxCheck.Text != "")
            {
                if (Convert.ToDecimal(tbxCheck.Text) < _order.TotalPrice)
                {
                    if (cbxCredit.Checked)
                    {
                        tbxCredit.Text = (_order.TotalPrice - Convert.ToDecimal(tbxCheck.Text)).ToString();
                    }
                    else if (cbxCash.Checked)
                    {
                        tbxCash.Text = (_order.TotalPrice - Convert.ToDecimal(tbxCheck.Text)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Ödemeniz gereken miktardan daha fazla girdiniz");
                    tbxCheck.Text = _order.TotalPrice.ToString();
                    if (cbxCash.Checked)
                    {
                        tbxCash.Text = "0,00";
                    }
                    else if (cbxCredit.Checked)
                    {
                        tbxCredit.Text = "0,00";
                    }
                }
            }
        }

        private void tbxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region decimal control

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            #endregion
        }

        private void tbxCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region decimal control

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            #endregion
        }

        private void tbxCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region decimal control

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            #endregion
        }

        private void pbxGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _order.Status = 1;
            Close();
        }
    }
}
