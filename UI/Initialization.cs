using BlApi;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Initialization
    {
        private static IBl? s_bl;

        private static void createCustomer()
        {
            s_bl.Customer.Create(new BO.Customer(21374, "Racheli", "Rashbi", "0556726780"));
            s_bl.Customer.Create(new BO.Customer(2568, "Sari", "Rambam", "05567239854"));
            s_bl.Customer.Create(new BO.Customer(2154, "Tamar", "Ramban", "0527623698"));
            s_bl.Customer.Create(new BO.Customer(9632, "Neomi", "Maharil", "0583279654"));
            s_bl.Customer.Create(new BO.Customer(0214, "Shhshi", "Rashi", "0527695236"));
        }
        private static void createProducts()
        {
            s_bl.Product.Create(new BO.Product(0, "canvas XS", BO.Categories.canvas, 31.2, 1));
            s_bl.Product.Create(new BO.Product(1, "glass S", BO.Categories.glass, 25.6, 2));
            s_bl.Product.Create(new BO.Product(2, "regular M", BO.Categories.regular, 39, 3));
            s_bl.Product.Create(new BO.Product(3, "wood L", BO.Categories.wood, 15, 5));
        }
        private static void createSales()
        {
            s_bl.Sale.Create(new BO.Sale(0, 910, 1, 41.25, true, new DateOnly(2005, 5, 2), new DateOnly(2036, 5, 2)));
            s_bl.Sale.Create(new BO.Sale(8, 920, 1, 12.5, false, new DateOnly(2005, 5, 2), new DateOnly(2036, 5, 2)));
            s_bl.Sale.Create(new BO.Sale(10, 930, 1, 74, true, new DateOnly(2005, 5, 2), new DateOnly(2036, 5, 2)));
            s_bl.Sale.Create(new BO.Sale(9, 940, 1, 12, false, new DateOnly(2005, 5, 2), new DateOnly(2036, 5, 2)));
        }
        public static void Initialize()
        {
            s_bl = BlApi.Factory.Get;
            createCustomer();
            createProducts();
            createSales();
        }
    }
}
