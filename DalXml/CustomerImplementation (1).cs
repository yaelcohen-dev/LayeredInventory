
using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;
using Tools;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
    string filePath = @"..\xml\customers.xml";
    List<Customer> customers = new List<Customer>();

    private List<Customer> LoadArray()
    {
        try
        {
            using (StreamReader fileStream = new StreamReader(filePath))
            {
                customers= xmlSerializer.Deserialize(fileStream) as List<Customer>;
            }
            return customers;
        }
        catch {
            return new List<Customer>();
        }

    }

    public int Create(Customer item)
    {
        customers = LoadArray();

        if (customers.Any(other => item.Id == other.Id))
        {
            throw new DalExceptionEntityExists("customer exist");
        }
        customers.Add(item);
        using (StreamWriter fileStream = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(fileStream, customers);
        }
        return item.Id;
    }


    public void Delete(int id)
    {
        customers = LoadArray();
        customers.RemoveAll(c=>c.Id==id);
        using (StreamWriter fileStream = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(fileStream, customers);
        }

    }

    public Customer? Read(int id)
    {
        Customer customer = LoadArray().FirstOrDefault(c => c.Id == id);
        if (customer == null)
        {
            throw new DalExceptionEntityDoesNotExist("Customer does not exsist");
        }
        return customer;
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        Customer customer = LoadArray().FirstOrDefault(filter);
        if (customer == null)
        {
            throw new DalExceptionEntityDoesNotExist("Customer does not exsist");
        }
        return customer;
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        if(filter != null)
             return LoadArray().Where(filter).ToList();
        return LoadArray();
    }

    public void Update(Customer item)
    {

        customers = LoadArray();
        Customer customer = customers.FirstOrDefault(c => c.Id == item.Id);
        Delete(customer.Id);
        customers.Remove(customer);
        customers.Add(item);
        using (StreamWriter fileStream = new StreamWriter(filePath))
        {
            xmlSerializer.Serialize(fileStream, customers);
        }
    }
}
