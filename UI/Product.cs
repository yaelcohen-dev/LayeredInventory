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
    public partial class Product : Form
    {
        private IProduct _product = BlApi.Factory.Get.Product;
        DataGridView grid;
        private enum Category
        {
            wood = BO.Categories.wood,
            canvas = BO.Categories.canvas,
            shirt = BO.Categories.shirt,
            glass = BO.Categories.glass,
            regular = BO.Categories.regular
        }

        public Product()
        {
            InitializeComponent();
            grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true,
                ReadOnly = true,
                DataSource = _product.ReadAll().OrderBy(p => p.Id).ToList()
            };

            tabPage1.Controls.Add(grid);
            categoryFilter.Items.AddRange(Enum.GetNames(typeof(Category)));
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void categoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryFilter.SelectedItem == null)
            {
                grid.DataSource = null;
                grid.DataSource = _product.ReadAll().OrderBy(p => p.Id).ToList();
                return;
            }
            grid.DataSource = null;
            grid.DataSource = _product.ReadAll(p => p.Category.ToString() == categoryFilter.SelectedItem.ToString()).OrderBy(p => p.Id).ToList();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {


            if (grid.CurrentRow == null || grid.CurrentRow.DataBoundItem == null)
                MessageBox.Show("Please select product first");
            else
            {
                var result = MessageBox.Show("Are you sure you want to delete this sale?",
                             "Confirm Delete",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                BO.Product selectedProduct = (BO.Product)grid.CurrentRow.DataBoundItem;
                _product.Delete(selectedProduct.Id);
                if (categoryFilter.SelectedItem != null)
                {
                    grid.DataSource = null;
                    grid.DataSource = _product.ReadAll(p => p.Category.ToString() == categoryFilter.SelectedItem.ToString()).OrderBy(p => p.Id).ToList();
                }
                else
                {
                    grid.DataSource = null;
                    grid.DataSource = _product.ReadAll().OrderBy(p => p.Id).ToList().OrderBy(p => p.Id).ToList();
                }
            }
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            ProductEditor p = new ProductEditor("ADD");
            p.Show();
            p.FormClosed += UpdateDetails;

        }

        private void UpdateDetails(object? sender, FormClosedEventArgs e)
        {
            if (categoryFilter.SelectedItem != null)
            {
                grid.DataSource = null;
                grid.DataSource = _product.ReadAll(p => p.Category.ToString() == categoryFilter.SelectedItem.ToString()).OrderBy(p => p.Id).ToList();
            }
            else
            {
                grid.DataSource = null;
                grid.DataSource = _product.ReadAll().OrderBy(p => p.Id).ToList();
            }

        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }
            ProductEditor p = new ProductEditor("UPDATE", (BO.Product)grid.CurrentRow.DataBoundItem);
            p.Show();
            p.FormClosed += UpdateDetails;
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            categoryFilter.SelectedItem = null;
            grid.DataSource = null;
            grid.DataSource = _product.ReadAll().OrderBy(p => p.Id).ToList();
        }
    }
}
