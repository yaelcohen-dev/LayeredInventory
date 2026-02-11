using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public bool IsForClub { get; set; }
        public SaleInProduct(int id, int count, double price, bool isForClub)
        {
            this.Id = id;
            this.Count = count;
            this.Price = price;
            this.IsForClub = isForClub;
        }
    }
}
