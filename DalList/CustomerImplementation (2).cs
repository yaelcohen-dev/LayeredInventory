using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        public int Create(Customer item)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer id:"+item.Id);
            if (DataSource.Customers.Any(other=>item.Id==other.Id))
            {
                LogManager.WriteLoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "item exists");
                throw new DalExceptionEntityExists("customer exist");
            }
            DataSource.Customers.Add(item);
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create customer id:" + item.Id);
            return item.Id;
        }

        public void Delete(int id)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer id:" + id);
            DataSource.Customers.Remove(Read(id));
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete customer id:" + id);
        }

        public Customer? Read(int id)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer id:" + id);
            Customer customer = DataSource.Customers.FirstOrDefault(c=> c.Id == id);
            if(customer == null)
            {
                LogManager.WriteLoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer does not exsist id:" + id);
                throw new DalExceptionEntityDoesNotExist("Customer does not exsist");
            }
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer id:" + id);
            return customer;
        } 
        public Customer? Read(Func<Customer, bool> filter)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
            Customer customer = DataSource.Customers.FirstOrDefault(filter);
            if (customer == null)
            {
                LogManager.WriteLoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer does not exsist");
                throw new DalExceptionEntityDoesNotExist("Customer does not exsist");
            }
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer");
            return customer;
        }
        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all customers");
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all customers");
            if (filter == null)
                return DataSource.Customers;
            return DataSource.Customers.Where(filter).ToList();
        }
        public void Update(Customer item)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customers id:"+item.Id);
            Customer customer = DataSource.Customers.FirstOrDefault(c => c.Id == item.Id);
            Delete(customer.Id);
            DataSource.Customers.Add(item);
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update customers id:" + item.Id);

        }
    }
}