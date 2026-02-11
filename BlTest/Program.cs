// See https://aka.ms/new-console-template for more information


using BO;

namespace BlTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BO.Customer c = new BO.Customer(123);
            DO.Customer c2 = c.Convert<BO.Customer, DO.Customer>();
            Console.WriteLine("customer converted successfully!");
            Console.WriteLine("Probebly you're genuis");

        }
    }

}
