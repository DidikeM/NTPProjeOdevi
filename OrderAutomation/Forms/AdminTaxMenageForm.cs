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
    public partial class AdminTaxMenageForm : Form
    {
        public AdminTaxMenageForm()
        {
            InitializeComponent();
        }

        private TaxDal _taxDal = new TaxDal();

        private void AdminTaxMenageForm_Load(object sender, EventArgs e)
        {
            LoadTaxDgw();
        }

        private void LoadTaxDgw()
        {
            dgwTax.DataSource = _taxDal.GetAll();
        }

        private void dgwTax_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxTaxPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Int control

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxTaxName.Text == "" || tbxTaxPercent.Text == "")
            {
                MessageBox.Show("Lütfen bütün Kutuları doldurunuz!");
            }
            else
            {
                _taxDal.Add(new Tax
                {
                    TaxName = tbxTaxName.Text,
                    TaxPercent = Convert.ToInt32(tbxTaxPercent.Text)
                });
                LoadTaxDgw();
                tbxTaxName.Text = "";
                tbxTaxPercent.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
