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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//manager
        {
            Manager manager = new Manager();
            manager.Show();
            this.Hide();
            manager.FormClosed += Manager_FormClosed;
        }

        private void Manager_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)//chashier
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
            logIn.FormClosed += Cashier_FormClosed;
        }

        private void Cashier_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
