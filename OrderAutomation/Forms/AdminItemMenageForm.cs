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
    public partial class AdminItemMenageForm : Form
    {
        public AdminItemMenageForm()
        {
            InitializeComponent();
        }

        private Item _itemAdd = new Item();
        private Item _itemUpdate = new Item();
        private ItemDal _itemDal = new ItemDal();
        private TaxDal _taxDal = new TaxDal();

        private void AdminİtemMenageForm_Load(object sender, EventArgs e)
        {
            LoadItem();
            List<Taxlst> taxlstsAdd = new List<Taxlst>();
            List<Taxlst> taxlstsUpdate = new List<Taxlst>();
            List<Tax> taxes = new List<Tax>();
            taxes = _taxDal.GetAll();

            foreach (var tax in taxes)
            {
                taxlstsAdd.Add(new Taxlst
                {
                    ID = tax.ID,
                    VergiName = tax.TaxName,
                    VergiPercent = tax.TaxPercent,
                    Text = tax.TaxName.TrimEnd() + ", %" + tax.TaxPercent.ToString()
                });

                taxlstsUpdate.Add(new Taxlst
                {
                    ID = tax.ID,
                    VergiName = tax.TaxName,
                    VergiPercent = tax.TaxPercent,
                    Text = tax.TaxName.TrimEnd() + ", %" + tax.TaxPercent.ToString()
                });
            }
            cbxAddTax.DataSource = taxlstsAdd;
            cbxAddTax.ValueMember = "ID";
            cbxAddTax.DisplayMember = "Text";

            cbxUpdateTax.DataSource = taxlstsUpdate;
            cbxUpdateTax.ValueMember = "ID";
            cbxUpdateTax.DisplayMember = "Text";
        }

        private void LoadItem()
        {
            dgwItem.DataSource = _itemDal.GetAll();
        }

        #region Item Add

        private void tbxAddItemName_TextChanged(object sender, EventArgs e)
        {
            _itemAdd.ItemName = tbxAddItemName.Text;
        }

        private void tbxAddShippingWeight_TextChanged(object sender, EventArgs e)
        {
            if (tbxAddShippingWeight.Text != "" && tbxAddShippingWeight.Text != ",")
            {
                _itemAdd.ShippingWeight = Convert.ToDecimal(tbxAddShippingWeight.Text);
            }
        }

        private void tbxAddShippingWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxAddTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _itemAdd.TaxID = Convert.ToInt32(cbxAddTax.SelectedValue.ToString());
            }
            catch
            {
                // ignored
            }
        }

        private void tbxAddPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbxAddPrice.Text != "" && tbxAddPrice.Text != ",")
            {
                _itemAdd.Price = Convert.ToDecimal(tbxAddPrice.Text);
            }
        }

        private void tbxAddPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxAddDescription_TextChanged(object sender, EventArgs e)
        {
            _itemAdd.Description = tbxAddDescription.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxAddItemName.Text == "" || tbxAddShippingWeight.Text == "" || tbxAddPrice.Text == "" || tbxAddDescription.Text == "")
            {
                MessageBox.Show("Lütfen bütün kutucukları doldurunuz!");
            }
            else
            {
                _itemDal.Add(_itemAdd);
                tbxAddItemName.Text = "";
                tbxAddShippingWeight.Text = "";
                tbxAddPrice.Text = "";
                tbxAddDescription.Text = "";
                LoadItem();
                MessageBox.Show("Ürün başarıyla eklendi.");
            }
        }

        #endregion

        #region Update

        private void tbxUpdateItemName_TextChanged(object sender, EventArgs e)
        {
            _itemUpdate.ItemName = tbxUpdateItemName.Text;
        }

        private void tbxUpdateShippingWeight_TextChanged(object sender, EventArgs e)
        {
            if (tbxUpdateShippingWeight.Text != "" && tbxUpdateShippingWeight.Text != ",")
            {
                _itemUpdate.ShippingWeight = Convert.ToDecimal(tbxUpdateShippingWeight.Text);
            }
        }

        private void tbxUpdateShippingWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxUpdateTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _itemUpdate.TaxID = Convert.ToInt32(cbxUpdateTax.SelectedValue.ToString());
            }
            catch
            {
                // ignored
            }
        }

        private void tbxUpdatePrice_TextChanged(object sender, EventArgs e)
        {
            if (tbxUpdatePrice.Text != "" && tbxUpdatePrice.Text != ",")
            {
                _itemUpdate.Price = Convert.ToDecimal(tbxUpdatePrice.Text);
            }
        }

        private void tbxUpdatePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxUpdateDescription_TextChanged(object sender, EventArgs e)
        {
            _itemUpdate.Description = tbxUpdateDescription.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxUpdateItemName.Text == "" || tbxUpdateShippingWeight.Text == "" || tbxUpdatePrice.Text == "" || tbxUpdateDescription.Text == "")
            {
                MessageBox.Show("Lütfen bütün kutucukları doldurunuz!");
            }
            else
            {
                _itemDal.Update(_itemUpdate);
                tbxUpdateItemName.Text = "";
                tbxUpdateShippingWeight.Text = "";
                tbxUpdatePrice.Text = "";
                tbxUpdateDescription.Text = "";
                //MessageBox.Show(_itemUpdate.ID.ToString() + "\n" );
                //MessageBox.Show(_itemUpdate.ItemName.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.ShippingWeight.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.TaxID.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.Description.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.Price.ToString() + "\n");
                LoadItem();
                MessageBox.Show("Ürün başarıyla güncellendi.");
            }
        }

        private void dgwItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _itemUpdate.ID = Convert.ToInt32(dgwItem.CurrentRow.Cells[0].Value);
            tbxUpdateItemName.Text = dgwItem.CurrentRow.Cells[1].Value.ToString().TrimEnd();
            tbxUpdateShippingWeight.Text = dgwItem.CurrentRow.Cells[2].Value.ToString().TrimEnd();
            tbxUpdateDescription.Text = dgwItem.CurrentRow.Cells[3].Value.ToString().TrimEnd();
            cbxUpdateTax.SelectedValue = dgwItem.CurrentRow.Cells[4].Value;
            tbxUpdatePrice.Text = dgwItem.CurrentRow.Cells[5].Value.ToString().TrimEnd();
        }

        #endregion

        #region Delate

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxUpdateItemName.Text == "" || tbxUpdateShippingWeight.Text == "" || tbxUpdatePrice.Text == "" || tbxUpdateDescription.Text == "")
            {
                MessageBox.Show("Lütfen bütün kutucukları doldurunuz!");
            }
            else
            {
                _itemDal.Delate(_itemUpdate);
                tbxUpdateItemName.Text = "";
                tbxUpdateShippingWeight.Text = "";
                tbxUpdatePrice.Text = "";
                tbxUpdateDescription.Text = "";
                //MessageBox.Show(_itemUpdate.ID.ToString() + "\n" );
                //MessageBox.Show(_itemUpdate.ItemName.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.ShippingWeight.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.TaxID.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.Description.ToString() + "\n");
                //MessageBox.Show(_itemUpdate.Price.ToString() + "\n");
                LoadItem();
                MessageBox.Show("Ürün başarıyla silindi.");
            }
        }

        #endregion

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
