using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalXml : IDal
    {
        private static DalXml instance;

        public static DalXml Instance
        {
            get
            {
                if (instance == null)
                    instance = new DalXml();
                return instance;
            }
        }
        private DalXml()
        {
        }
        public ICustomer Customer => new CustomerImplementation();

        public IProduct Product => new ProductImplementation();

        public ISale Sale => new SaleImplementation();
    }
}
