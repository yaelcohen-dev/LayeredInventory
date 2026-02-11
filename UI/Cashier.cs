using BlApi;
using BO;
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
    public partial class Cashier : Form
    {
        private IOrder _order = BlApi.Factory.Get.Order;
        IProduct _product = BlApi.Factory.Get.Product;
        private ISale _sale = BlApi.Factory.Get.Sale;

        BO.Order order;
        bool isClubMember;
        public Cashier(bool isForClub)
        {
            InitializeComponent();
            productsGrid.DataSource = _product.ReadAll().Where(p=>p.Amount>0).OrderBy(p=>p.Id).ToList();
            productsGrid.ReadOnly = true;
            sales.ReadOnly = true;
            order = new BO.Order(new List<BO.ProductInOrder>());
            productsInOrderGrid.DataSource = order.ProductsList;
            isClubMember = isForClub;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void addProductInput_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productsGrid.Rows)
            {
                var item = row.DataBoundItem as BO.Product;
                if (item != null && item.Id == addProductInput.Value)
                {
                    productsGrid.ClearSelection();
                    row.Selected = true;
                    productsGrid.CurrentCell = row.Cells[0];
                    break;
                }
            }
            addProductInput.Value = ((BO.Product)productsGrid.CurrentRow.DataBoundItem).Id;


        }


        private void allProductsTable_Selected(object sender, TabControlEventArgs e)
        {
        }

        private void allProductsTable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productsGrid_SelectionChanged(object sender, EventArgs e)
        {
            addProductInput.Value = ((BO.Product)productsGrid.CurrentRow.DataBoundItem).Id;

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            BO.Product product;
            try
            {
                product = _product.Read((int)addProductInput.Value);
            }
            catch
            {
                MessageBox.Show("Product not found");
                return;
            }
            if (amountInput.Value <= 0 )
            {
                MessageBox.Show("Quantity must be greater than zero");
                return;
            }
            if (order.ProductsList.Any(p=>p.Id == product.Id)
                && product.Amount - order.ProductsList.First(p=>p.Id==product.Id).Count <  (int)amountInput.Value)
            {
                MessageBox.Show("Total quantity in cart exceeds available stock");
                return;
            }
            else if (amountInput.Value > product.Amount)
            {
                MessageBox.Show($"Invalid quantity. You can order up to {product.Amount} units.");
                return;
            }
            List<BO.SaleInProduct> salesList = _order.AddProductToOrder(order, product.Id, (int)amountInput.Value, isClubMember);
            amountInput.Value = 1;

            updateProductsInOrder();
            updateSales();
            updateProducts();
            totalPrice.Text = order.FinalPrice.ToString("C2");
        }

        private void productsInOrderGrid_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void updateProductsInOrder()
        {
            productsInOrderGrid.DataSource = null;
            productsInOrderGrid.DataSource = order.ProductsList;
        }

        public void updateProducts()
        {
            productsGrid.DataSource = null;
            productsGrid.DataSource = _product.ReadAll().Where(p => p.Amount > 0).OrderBy(p => p.Id).ToList();
        }

        public void updateSales()
        {
            sales.DataSource = null;
            List<BO.SaleInProduct> salesList = order.ProductsList.SelectMany(p => p.SalesList).ToList();
            List<BO.Sale> finalList = salesList.Select(s => s.Id).Select(s => _sale.Read(s)).ToList();
            sales.DataSource = finalList;



        }

        private void productsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addProductInput.Value = ((BO.Product)productsGrid.CurrentRow.DataBoundItem).Id;

        }

        private void doOrderBtn_Click(object sender, EventArgs e)
        {
            _order.DoOrder(order);
            MessageBox.Show("Order completed successfully");
            this.Close();
        }
    }
}
