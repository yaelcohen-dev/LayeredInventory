
using DalApi;
using DalXml;
using DO;
using System.Xml.Serialization;

namespace Dal;

internal class ProductImplementation : IProduct
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
    string filePath = @"..\xml\products.xml";
    List<Product> products = new List<Product>();

    private List<Product> LoadArray()
    {
        try
        {
            using (StreamReader fileStream = new StreamReader(filePath))
            {
                return (List<Product>)xmlSerializer.Deserialize(fileStream);
            }
        }
        catch
        {
            return new List<Product>();
        }
    }

    public int Create(Product item)
    {
        products = LoadArray();

        int id = Config.ProductCode;
        item = item with { Id = id };
        products.Add(item);
        using (StreamWriter fileStream = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(fileStream, products);
        }
        return item.Id;
    }


    public void Delete(int id)
    {
        products = LoadArray();
        products.RemoveAll(c => c.Id == id);
        using (StreamWriter fileStream = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(fileStream, products);
        }
    }

    public Product? Read(int id)
    {
        Product product = LoadArray().FirstOrDefault(c => c.Id == id);
        if (product == null)
        {
            throw new DalExceptionEntityDoesNotExist("Product does not exsist");
        }
        return product;
    }

    public Product? Read(Func<Product, bool> filter)
    {
        Product product = LoadArray().FirstOrDefault(filter);
        if (product == null)
        {
            throw new DalExceptionEntityDoesNotExist("Product does not exsist");
        }
        return product;
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        if (filter != null)
            return LoadArray().Where(filter).ToList();
        return LoadArray();
    }

    public void Update(Product item)
    {

        products = LoadArray();
        Product product = products.FirstOrDefault(c => c.Id == item.Id);
        Delete(product.Id);
        products.Remove(product);
        products.Add(item);
        using (StreamWriter fileStream = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(fileStream, products);
        }
    }
}
