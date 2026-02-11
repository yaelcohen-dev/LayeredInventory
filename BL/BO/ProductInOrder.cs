using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public double OriginPrice { get; set; }
        public int Count { get; set; }
        public List<SaleInProduct> SalesList { get; set; }
        public double FinalPrice { get; set; }
        public ProductInOrder(int id, List<SaleInProduct> list, string name=null,double originPrice=0,int count=0, double FinalPrice=0)
        {
            this.Id = id;
            this.ProductName = name;
            this.OriginPrice = originPrice;
            this.Count = count;
            this. SalesList = list;
            this.FinalPrice = FinalPrice;
        }
    }
}