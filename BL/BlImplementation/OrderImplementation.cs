using BO;
using DalApi;
using BlApi;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        //Search sales for the specific product received
        public void SearchSaleForProduct(ProductInOrder product, bool isClub)
        {
            if (product.SalesList == null)
                product.SalesList = new List<SaleInProduct>();
            //filter just the sales that meet the conditions and push them to the product's saleslist and sort them by price
            product.SalesList.AddRange(_dal.Sale.ReadAll(s => IsMeetTheConditions(s, product, isClub))
                .Select(s => s.Convert<DO.Sale, BO.Sale>())
                .Select(s => new SaleInProduct(s.Id, s.MinAmount, s.SalePrice, s.IsForClub))
                .Where(s => !product.SalesList.Contains(s))
                .OrderBy(s => s.Price).ToList());
        }

        //Check if the recived sale can be used
        private bool IsMeetTheConditions(DO.Sale sale, ProductInOrder product, bool isClub)
        {
            return sale.ProductId == product.Id && sale.Begin <= DateOnly.FromDateTime(DateTime.Now) &&
                sale.End >= DateOnly.FromDateTime(DateTime.Now) &&
               (!sale.IsForClub || isClub);
        }
        //calculate the cheapest total price for product in order, and choose the sales that should be used for this product for that price
        public void CalcTotalPriceForProduct(ProductInOrder productInOrder)
        {
            productInOrder.FinalPrice = 0;
            int count = productInOrder.Count;
            List<SaleInProduct> usedSales = new List<SaleInProduct>();
            foreach (SaleInProduct saleInProduct in productInOrder.SalesList)
            {
                //if the minimum products for this salse is greater than
                //the current amount, it's not possible to use this sale
                if (saleInProduct.Count > count)
                    continue;
                else
                {
                    usedSales.Add(saleInProduct);
                    productInOrder.FinalPrice += count / saleInProduct.Count * saleInProduct.Price;
                    count %= saleInProduct.Count;
                    //if the order for this product has been completed
                    //then break
                    if (count == 0)
                        break;
                }
            }
            //Calculate the rest amount that didnt match to any sale
            productInOrder.FinalPrice += count * productInOrder.OriginPrice;
            productInOrder.SalesList = usedSales;
        }
        //Determine the total price as sum of the final prices of each product in order
        public void CalcTotalPrice(Order order)
        {
            order.FinalPrice = order.ProductsList.Sum(p => p.FinalPrice);
        }
        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int amount, bool isClubMember)
        {
            Product product = _dal.Product.Read(productId).Convert<DO.Product, BO.Product>();
            ProductInOrder productInOrder = order.ProductsList.Find(p => p.Id == product.Id);
            if (productInOrder != null)
            {
                if (product.Amount < amount || productInOrder.Count + amount < 0)
                    throw new Exception();
                productInOrder.Count += amount;
            }
            else
            {
                if (product.Amount < amount)
                    throw new Exception();
                order.ProductsList.Add(new ProductInOrder(product.Id, null, product.Name, product.Price, amount));
                productInOrder = order.ProductsList.Find(p => p.Id == product.Id);

            }
            SearchSaleForProduct(productInOrder, isClubMember);
            CalcTotalPriceForProduct(productInOrder);
            CalcTotalPrice(order);
            return productInOrder.SalesList;
        }

        //public void RemoveProductFromOrder(Order order, int productId, int amount)
        //{
        //    Product product = _dal.Product.Read(productId).Convert<DO.Product, BO.Product>();
        //    ProductInOrder productInOrder = order.ProductsList.Find(p => p.Id == product.Id);
        //    if (productInOrder != null)
        //    {
        //        if (productInOrder.Count < amount || productInOrder.Count - amount < 0)
        //            throw new Exception();
        //        productInOrder.Count -= amount;
        //        product.Amount += amount;
        //        _dal.Product.Update(product.Convert<BO.Product, DO.Product>());
        //    }
        //    else
        //        throw new Exception();
        //}


        public void DoOrder(Order order)
        {
            foreach (ProductInOrder productInOrder in order.ProductsList)
            {
                Product product = _dal.Product.Read(productInOrder.Id).Convert<DO.Product, BO.Product>();
                product.Amount -= productInOrder.Count;
                _dal.Product.Update(product.Convert<BO.Product, DO.Product>());
            }
        }
    }
}
