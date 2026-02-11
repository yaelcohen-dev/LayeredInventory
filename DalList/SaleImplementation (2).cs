using DO;
using DalApi;
using System.Reflection;
using Tools;
namespace Dal
{
    internal class SaleImplementation: ISale
    {
        public int Create(Sale item)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale id:" + item.Id);
            int id = DataSource.Config.GetSale;
            DataSource.Sales.Add(item with { Id=id});
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale id:" + item.Id);
            return id;
        }

        public void Delete(int id)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale id:" + id);
            DataSource.Sales.Remove(Read(id));
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale id:" + id);

        }

        public Sale? Read(int id)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale id:" + id);
            Sale sale = DataSource.Sales.FirstOrDefault(s => s.Id == id);
            if (sale == null)
            {
                LogManager.WriteLoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Sale does not exsist");
                throw new DalExceptionEntityDoesNotExist("Sale does not exsist");
            }
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale id:" + id);
            return sale;
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
            Sale sale = DataSource.Sales.FirstOrDefault(filter);
            if (sale == null)
            {
                LogManager.WriteLoLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Sale does not exsist");
                throw new DalExceptionEntityDoesNotExist("Sale does not exsist");
            }
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
            return sale;
        }
        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read  all sales");
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read  all sales");
            if (filter == null)
                return DataSource.Sales;
            return DataSource.Sales.Where(filter).ToList();
        }
        public void Update(Sale item)
        {
            LogManager.WriteInStart(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale id:"+item.Id);
            Delete(item.Id);
            DataSource.Sales.Add(item);
            LogManager.WriteInEnd(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale id:" + item.Id);
        }

    }
}