namespace BO
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories?  Category { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public List<SaleInProduct> SalesForProduct { get; set; }
        public Product(int id,string name, Categories category, double price, int amount)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.Amount = amount;
            this.SalesForProduct = new List<SaleInProduct>();
        }
        public Product():this(-1, "", Categories.regular, 0.0, 0) { }
    }
}
