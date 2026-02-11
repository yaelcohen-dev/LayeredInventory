using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool IsForClub { get; set; }
        public List<ProductInOrder> ProductsList { get; set; }
        public double FinalPrice { get; set; }
        public Order( List<ProductInOrder> productList, bool isForClub = false,double finalPrice=0)
        {
            this.ProductsList = productList;
            this.FinalPrice = finalPrice;
            this.IsForClub = isForClub;
        }
    }
}
