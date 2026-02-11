using BO;

namespace BlApi
{
    public interface IOrder
    {
        List<SaleInProduct> AddProductToOrder(Order order, int ProductId, int amount, bool isClubMember);
        void CalcTotalPriceForProduct(ProductInOrder productInOrder);
        void CalcTotalPrice(Order order);
        void DoOrder(Order order);
        public void SearchSaleForProduct(ProductInOrder product, bool isClub);
    }
}
