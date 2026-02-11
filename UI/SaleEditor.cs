using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SaleEditor : Form
    {
        private string action;
        BO.Sale sale;
        private ISale _sale = BlApi.Factory.Get.Sale;
        public SaleEditor(string action, BO.Sale sale = null)
        {
            InitializeComponent();
            this.action = action;
            if (action == "ADD")
            {
                AddState();
            }
            else if (action == "UPDATE")
            {
                this.sale = sale;
                UpdateState();
            }
            else
            {
                throw new ArgumentException("Invalid action");
            }
        }

        private void UpdateState()
        {
            this.Text = "Edit Sale";
            actionLable.Text = "Edit Sale";
            OK.Text = "Edit";
            productIdInput.Value = sale.ProductId;
            minAmountInput.Value = sale.MinAmount;
            salePriceInput.Value = (int)sale.SalePrice;
            isForClub.Checked = sale.IsForClub;
            begin.Value = sale.Begin.ToDateTime(TimeOnly.MinValue);
            if (sale.End.HasValue)
                end.Value = sale.End.Value.ToDateTime(TimeOnly.MinValue);
            else
                end.Value = DateTime.Today;
        }

        private void AddState()
        {
            this.Text = "Add Sale";
            actionLable.Text = "Add Sale";
            OK.Text = "Add";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(salePriceInput.Value <= 0)
            {
                MessageBox.Show("Please write valid sale price");
                return;
            }
            if(begin.Value >= end.Value)
            {
                MessageBox.Show("Please fill valid end date");
                return;
            }
            try
            {
                Factory.Get.Product.Read((int)productIdInput.Value);
            }
            catch
            {
                MessageBox.Show("product ID not found");
                return;
            }
            if (action == "ADD")
            {
                AddSale();
            }
            else if (action == "UPDATE")
            {
                UpdateSale();
            }
            this.Close();
        }

        private void UpdateSale()
        {
            sale.ProductId = (int)productIdInput.Value;
            sale.MinAmount = (int)minAmountInput.Value;
            sale.SalePrice = (int)salePriceInput.Value;
            sale.IsForClub = isForClub.Checked;
            sale.Begin = DateOnly.FromDateTime(begin.Value);
            sale.End = DateOnly.FromDateTime(end.Value);
            _sale.Update(sale);
        }

        private void AddSale()
        {
            BO.Sale sale = new BO.Sale()
            {
                ProductId = (int)productIdInput.Value,
                MinAmount = (int)minAmountInput.Value,
                SalePrice = (int)salePriceInput.Value,
                IsForClub = isForClub.Checked,
                Begin = DateOnly.FromDateTime(begin.Value),
                End = DateOnly.FromDateTime(end.Value)
        };
            _sale.Create(sale);
        }
    }
}
