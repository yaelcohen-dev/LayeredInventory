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
    public partial class Sale : Form
    {
        private ISale _sale = BlApi.Factory.Get.Sale;
        DataGridView grid;
        public Sale()
        {
            InitializeComponent();
            grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = true,
                ReadOnly = true,
                DataSource = _sale.ReadAll().OrderBy(p => p.Id).ToList()
            };

            tabPage1.Controls.Add(grid);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }
            SaleEditor s = new SaleEditor("UPDATE", (BO.Sale)grid.CurrentRow.DataBoundItem);
            s.Show();
            s.FormClosed += UpdateDetails;
        }

        private void UpdateDetails(object? sender, FormClosedEventArgs e)
        {
            updateForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.DataBoundItem == null)
                MessageBox.Show("Please select sale");
            else
            {
                var result = MessageBox.Show("Are you sure you want to delete this sale?",
                             "Confirm Delete",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                BO.Sale selectedSale = (BO.Sale)grid.CurrentRow.DataBoundItem;
                _sale.Delete(selectedSale.Id);
                updateForm();
            }
        }
        public void updateForm()
        {
            grid.DataSource = null;
            grid.DataSource = _sale.ReadAll(s => s.IsForClub || !checkBox1.Checked).OrderBy(p => p.Id).ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SaleEditor s = new SaleEditor("ADD");
            s.Show();
            s.FormClosed += UpdateDetails;
        }
    }
}
