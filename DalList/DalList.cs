
using DalApi;
namespace Dal
{
    internal sealed class DalList:IDal
    {
        public static DalList Instance { get; } = new DalList();
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
        public ICustomer Customer => new CustomerImplementation();
        private DalList() { }
    }
}
