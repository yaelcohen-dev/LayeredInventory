using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace DalTest
{
    internal class Program
    {
        static readonly IDal s_dal = DalApi.Factory.Get;

        static void Main(string[] args)
        {
            Initialize();
        }

        private static void Initialize()
        {
            LogManager.CleanDirs();
            Console.WriteLine("Welcome to the DalTest program!");
            Initialization.Initialize();
            int selection = printMainMenu();
            while (selection != 0)
            {
                switch (selection)
                {
                    case 1:
                        productMenu();
                        break;
                    case 2:
                        saleMenu();
                        break;
                    case 3:
                        customerMenu();
                        break;
                    default:
                        Console.WriteLine("Wrong selection, please select again");
                        break;
                }
                selection = printMainMenu();
            }
        }

        private static int printMainMenu()
        {
            Console.WriteLine("For product press 1");
            Console.WriteLine("For sale press 2");
            Console.WriteLine("For customer press 3");
            Console.WriteLine("To exit press 0");
            int selection;
            if (!int.TryParse(Console.ReadLine(), out selection))
                selection = -1;
            return selection;
        }
        public static int printSubMenu(string entity)
        {
            Console.WriteLine($"To create {entity} press 1");
            Console.WriteLine($"To delete {entity} press 2");
            Console.WriteLine($"To update {entity} press 3");
            Console.WriteLine($"To read {entity} press 4");
            Console.WriteLine($"To read all {entity}s press 5");
            Console.WriteLine("to return press 0");
            int selection;
            if (!int.TryParse(Console.ReadLine(), out selection))
                selection = -1;
            return selection;
        }
        public static void saleMenu()
        {
            int selection = printSubMenu("sale");
            while (selection != 0)
            {
                switch (selection)
                {
                    case 1:
                        try
                        {
                            int id = s_dal.Sale.Create(newSale(0));
                            Console.WriteLine("id: " + id);
                        }
                        catch 
                        { 
                            Console.WriteLine("Item exsist");

                        }
                        break;
                    case 2:
                        delete<Sale>(s_dal.Sale, "sale");
                        break;
                    case 3:
                        try
                        {
                            int id;
                            Console.WriteLine("enter id for update");
                            int.TryParse(Console.ReadLine(), out id);
                            s_dal.Sale.Update(newSale(id));
                        }
                        catch { Console.WriteLine("Id does not exsist"); }
                        break;
                    case 4:
                        read<Sale>(s_dal.Sale, "sale"); 
                        break;
                    case 5:
                        readAll<Sale>(s_dal.Sale);
                        break;
                    default:
                        Console.WriteLine("your selection is wrong");
                        break;
                }
                selection = printSubMenu("sale");
            }
        }
        private static Sale newSale(int id)
        {
            try
            {
                Console.WriteLine("Enter product id, min amount, sale price, is for club, begin date and read date");
                int ProductId = int.Parse(Console.ReadLine());
                int MinAmount = int.Parse(Console.ReadLine());
                double SalePric = double.Parse(Console.ReadLine());
                bool IsForClub = bool.Parse(Console.ReadLine());
                DateOnly Begin = DateOnly.Parse(Console.ReadLine());
                DateOnly End = DateOnly.Parse(Console.ReadLine());
                return new Sale(id, ProductId, MinAmount, SalePric, IsForClub, Begin, End);
            }
            catch
            {
                Console.WriteLine("action faild");
                Console.WriteLine("Maybe on of the details was wrong");
                return newSale(id);
            }
        }
        public static void productMenu()
        {
            int selection = printSubMenu("product");
            while (selection != 0)
            {
                switch (selection)
                {
                    case 1:
                        try
                        {
                            int id = s_dal.Product.Create(newProduct(0));
                            Console.WriteLine("id: " + id);
                        }
                        catch
                        { Console.WriteLine("Item exsists"); }
                        break;
                    case 2:
                        delete<Product>(s_dal.Product, "product");
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("enter id for update");
                            int id = int.Parse(Console.ReadLine());
                            s_dal.Product.Update(newProduct(id));
                        }
                        catch { Console.WriteLine("Id does not exist"); }
                        break;
                    case 4:
                        read<Product>(s_dal.Product, "product"); 
                        break;
                    case 5:
                        readAll<Product>(s_dal.Product);
                        break;
                    default:
                        Console.WriteLine("Your selection is wrong");
                        break;
                }
                selection = printSubMenu("product");
            }
        }
        static Categories switchCategory()
        {
            int selection;
            Console.WriteLine("for wood press 1, canvas press 2, shirt press 3, glass press 4, regular press 5");
            if (!int.TryParse(Console.ReadLine(), out selection))
                selection = -1;
            switch (selection)
            {
                case 1:
                    return Categories.wood;
                case 2:
                    return Categories.canvas;
                case 3:
                    return Categories.shirt;
                case 4:
                    return Categories.glass;
                case 5:
                    return Categories.regular;
                default:
                    Console.WriteLine("invalid input, please try again");
                    return switchCategory();
            }
        }
        private static Product newProduct(int id)
        {
            try
            {
                Console.WriteLine("Enter name, category, price and amount");
                string Name=Console.ReadLine();
                Categories Category = switchCategory();
                double Price=double.Parse(Console.ReadLine());
                int Amount=int.Parse(Console.ReadLine());
                return new Product(id, Name, Category, Price, Amount);
            }
            catch
            {
                Console.WriteLine("action faild");
                Console.WriteLine("Maybe on of the details was wrong");
                return newProduct(id);
            }
        }
        private static void readAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }                     
        }
        private static void read<T>(ICrud<T> crud, string entity)
        {
            Console.WriteLine($"Enter {entity} id");
            try
            {
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(crud.Read(id));
            }
            catch
            {
                Console.WriteLine("The id is not valid, please try again");
                read<T>(crud, entity);
            }
        }
        private static void delete<T>(ICrud<T> crud, string entity)
        {
            Console.WriteLine($"Enter {entity} id");
            try
            {
                int id = int.Parse(Console.ReadLine());
                crud.Delete(id);
            }
            catch
            {
                Console.WriteLine("The id is not valid, please try again");
                delete<T>(crud, entity);
            }
        }
        private static void customerMenu()
        {
            int selection = printSubMenu("customer");
            while (selection != 0)
            {
                switch (selection)
                {
                    case 1:
                        try
                        {
                            int id = s_dal.Customer.Create(newCustomer());
                            Console.WriteLine("id: " + id);
                        }
                        catch { Console.WriteLine("Item exists"); }
                        break;
                    case 2:
                        delete<Customer>(s_dal.Customer, "customer");
                        break;
                    case 3:
                        try
                        {
                            s_dal.Customer.Update(newCustomer());
                        }
                        catch { Console.WriteLine("Id does not exsist"); }
                        break;
                    case 4:
                        read<Customer>(s_dal.Customer, "sale"); 
                        break;
                    case 5:
                        readAll<Customer>(s_dal.Customer);
                        break;
                    default:
                        Console.WriteLine("your selection is wrong");
                        break;
                }
                selection = printSubMenu("customer");
            }
        }
        private static Customer newCustomer()
        {
            try
            {
                Console.WriteLine("Enter id, name, address and phone");
                int Id=int.Parse(Console.ReadLine());
                string Name=Console.ReadLine();
                string Address=Console.ReadLine();
                string Phone=Console.ReadLine();
                return new Customer(Id, Name, Address, Phone);
            }
            catch
            {
                Console.WriteLine("action faild");
                Console.WriteLine("Maybe on of the details was wrong");
                return newCustomer();
            }
        }
    }
}
