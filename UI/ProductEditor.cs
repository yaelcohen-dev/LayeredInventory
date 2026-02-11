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
    public partial class ProductEditor : Form
    {
        private string action;
        BO.Product product;
        private IProduct _product = BlApi.Factory.Get.Product;

        public ProductEditor(string action,BO.Product product=null)
        {
            InitializeComponent();
            this.action = action;
            if (action == "ADD")
            {
                AddState();
            }
            else if (action == "UPDATE")
            {
                this.product = product;
                UpdateState();
            }
            else
            {
                throw new ArgumentException("Invalid action");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameInput.Text) || (int)amountInput.Value==0 || (int)priceInput.Value == 0)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            if (action == "ADD")
            {
                AddProduct();
            }
            else if (action == "UPDATE")
            {
                UpdateProduct();
            }
            this.Close();
        }

        private void AddProduct()
        {
            BO.Product product = new BO.Product()
            {
                Name = nameInput.Text,
                Amount = (int)amountInput.Value,
                Price = (double)priceInput.Value,
                Category = (BO.Categories)Enum.Parse(typeof(BO.Categories), categoryInput.SelectedItem.ToString())
            };
            _product.Create(product);
        }
        private void UpdateProduct()
        {
            product.Name = nameInput.Text;
            product.Amount = (int)amountInput.Value;
            product.Price = (int)priceInput.Value;
            product.Category = (BO.Categories)Enum.Parse(typeof(BO.Categories), categoryInput.SelectedItem.ToString());
            _product.Update(product);
        }

        private void UpdateState()
        {
            this.Text = "Edit Product";
            actionLable.Text = "Edit Product";
            OK.Text = "Edit";
            nameInput.Text = product.Name;
            amountInput.Value = product.Amount;
            priceInput.Text = product.Price.ToString();
            categoryInput.DataSource = Enum.GetValues(typeof(BO.Categories)).Cast<BO.Categories>().Select(c => c.ToString()).ToList();
            if (product.Category != null)
            {
                categoryInput.SelectedItem = product.Category.ToString();
            }
            else
            {
                categoryInput.SelectedItem = "regular";
            }

        }

        private void AddState()
        {
            this.Text = "Add Product";
            actionLable.Text = "Add Product";
            OK.Text = "Add";
            categoryInput.DataSource = Enum.GetValues(typeof(BO.Categories)).Cast<BO.Categories>().Select(c => c.ToString()).ToList();

        }

    }
}
