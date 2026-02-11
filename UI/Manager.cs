using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Sale().Show();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            //Products products = new Products();
            //products.FormClosed += Products_FormClosed;
            //this.Hide
            //DataManagement dataManagement = new DataManagement();
            //dataManagement.Show();
            Product product = new Product();
            product.Show();
        }

        private void Products_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }
    }
}
