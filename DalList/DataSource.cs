
using DO;
namespace Dal;


internal class DataSource
{
    static internal List<Customer?> Customers = new List<Customer?>();
    static internal List<Product?> Products = new List<Product?>();
    static internal List<Sale?> Sales = new List<Sale?>();
    static internal class Config
    {
        internal const int MINSale = 100;
        private static int idSale = MINSale;
        public static int GetSale=> idSale++;//returns the value of ID and increase Id by one.

        internal const int MINProduct = 10;
        private static int idProduct = MINProduct;
        public static int GetProduct=> idProduct++; //returns the value of ID and increase Id by one.
    }
}