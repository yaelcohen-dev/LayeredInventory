using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace Dal
{
    internal class ProductImplementation:IProduct
    {
        public int Create(Product item)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product id:" + item.Id);
            int id = DataSource.Config.GetProduct;
            DataSource.Products.Add(item with { Id=id});
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create product id:" + item.Id);
            return id;
        }
        public void Delete(int id)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product id:" + id);
            DataSource.Products.Remove(Read(id));
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product id:" + id);
        }
        public Product? Read(int id)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product id:" + id);
            Product product = DataSource.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                LogManager.WriteLoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product does not exsist");
                throw new DalExceptionEntityDoesNotExist("Product does not exsist");
            }
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product id:" + id);
            return product;
        }

        public Product? Read(Func<Product, bool> filter)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
            Product product = DataSource.Products.FirstOrDefault(filter);
            if (product == null)
            {
                LogManager.WriteLoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product does not exsist");
                throw new DalExceptionEntityDoesNotExist("Product does not exsist");
            }
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read product");
            return product;
        }

        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read  all products");
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read  all products");
            if (filter == null)
                return DataSource.Products;
            return DataSource.Products.Where(filter).ToList();
        }
        public void Update(Product item)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product id:"+item.Id);
            Delete(item.Id);
            DataSource.Products.Add(item);
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update product id:" + item.Id);

        }
    }
}
