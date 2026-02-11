using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MinAmount { get; set; }
        public double SalePrice { get; set; }
        public bool IsForClub { get; set; }
        public DateOnly Begin { get; set; }
        public DateOnly? End { get; set; }
        public Sale(int id, int productId, int minAmount, double salePrice, bool isForClub, DateOnly begin, DateOnly end)
        {
            this.Id = id;
            this.ProductId = productId;
            this.MinAmount = minAmount;
            this.SalePrice = salePrice;
            this.IsForClub = isForClub;
            this.Begin = begin;
            this.End = end;
        }
        public Sale():this(-1, -1, 0, 0.0, false, new DateOnly(), new DateOnly())
        { }
    }
}
