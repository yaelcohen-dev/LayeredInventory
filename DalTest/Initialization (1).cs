namespace DalTest;
using DO;
using DalApi;
using System.Security.Cryptography;

public static class Initialization
{
    private static IDal? s_dal;
    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer(21374, "Racheli", "Rashbi", "0556726780"));
        s_dal.Customer.Create(new Customer(2568, "Sari", "Rambam", "05567239854"));
        s_dal.Customer.Create(new Customer(2154, "Tamar", "Ramban", "0527623698"));
        s_dal.Customer.Create(new Customer(9632, "Neomi", "Maharil", "0583279654"));
        s_dal.Customer.Create(new Customer(0214, "Shhshi", "Rashi", "0527695236"));
    }
    private static void createProducts()
    {
        s_dal.Product.Create(new Product(0, "canvas XS", Categories.canvas, 31.2, 1));
        s_dal.Product.Create(new Product(1, "glass S", Categories.glass, 25.6, 2));
        s_dal.Product.Create(new Product(2, "regular M", Categories.regular, 39, 3));
        s_dal.Product.Create(new Product(3, "wood L", Categories.wood, 15, 5));
    }
    private static void createSales()
    {
        s_dal.Sale.Create(new Sale(0, 12345, 2, 41.25, true, new DateOnly(), new DateOnly()));
        s_dal.Sale.Create(new Sale(8, 2587, 9, 12.5, false, new DateOnly(), new DateOnly()));
        s_dal.Sale.Create(new Sale(10, 12345, 7, 74, true, new DateOnly(), new DateOnly()));
        s_dal.Sale.Create(new Sale(9, 12345, 8, 12, false, new DateOnly(), new DateOnly()));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        createCustomer();
        createProducts();
        createSales();
    }
}