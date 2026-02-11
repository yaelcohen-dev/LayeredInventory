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
    public partial class LogIn : Form
    {
        private ICustomer _customer = BlApi.Factory.Get.Customer;

        public LogIn()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int id = (int)customerIdInput.Value;
            try
            {
                BO.Customer customer = _customer.Read(id);
                Cashier cashier = new Cashier(true);
                this.Close();
                cashier.Show();

            }
            catch
            {
                MessageBox.Show("Id is not valid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier(false);
            this.Close();
            cashier.Show();

        }
    }
}
