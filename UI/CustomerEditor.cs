using BlApi;

namespace UI
{
    public partial class CustomerEditor : Form
    {
        private string action;
        BO.Customer customer;
        private ICustomer _customer = BlApi.Factory.Get.Customer;
        public CustomerEditor(string action, BO.Customer customer = null)
        {
            InitializeComponent();
            this.action = action;
            if (action == "ADD")
            {
                AddState();
            }
            else if (action == "UPDATE")
            {
                this.customer = customer;
                idInput.Value = customer.Id;
                idInput.Enabled = false;
                UpdateState();
            }
            else
            {
                throw new ArgumentException("Invalid action");
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameInput.Text) || (int)idInput.Value == 0 || string.IsNullOrEmpty(addressInput.Text)|| string.IsNullOrEmpty(phoneInput.Text))
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
            BO.Customer customer = new BO.Customer()
            {
                Id = (int)idInput.Value,
                Name = nameInput.Text,
                Address = addressInput.Text,
                Phone = phoneInput.Text
            };
            try
            {
                _customer.Create(customer);
            }
            catch
            {
                MessageBox.Show("customer exsits");
            }
        }
        private void UpdateProduct()
        {
            customer.Name = nameInput.Text;
            customer.Address = addressInput.Text;
            customer.Phone = phoneInput.Text;
            _customer.Update(customer);
        }

        private void UpdateState()
        {
            this.Text = "Edit Product";
            actionLable.Text = "Edit Product";
            OK.Text = "Edit";
            idInput.Value = customer.Id;
            nameInput.Text = customer.Name;
            addressInput.Text = customer.Address;
            phoneInput.Text = customer.Phone;
        }

        private void AddState()
        {
            this.Text = "Add Product";
            actionLable.Text = "Add Product";
            OK.Text = "Add";
        }
    }
}
