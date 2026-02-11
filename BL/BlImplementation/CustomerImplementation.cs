using BO;
using BlApi;

namespace BlImplementation;

internal class CustomerImplementation: ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer item)
    {
        try
        {
            return _dal.Customer.Create(item.Convert<BO.Customer, DO.Customer>());

        }
        catch (Exception)
        {
            throw new Exception();
        }     
    }
    public BO.Customer? Read(int id)
    {
        if (!DoesExist(id))
            throw new Exception();
        return _dal.Customer.Read(id).Convert<DO.Customer, BO.Customer>();
    }
    public bool DoesExist(int id)
    {
        try
        {
            _dal.Customer.Read(id);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public BO.Customer? Read(Func<BO.Customer, bool>? filter=null)
    {
        try
        {
            if (filter == null)
                return _dal.Customer.ReadAll().First().Convert<DO.Customer, BO.Customer>();
            return _dal.Customer.Read(c => filter(c.Convert<DO.Customer, BO.Customer>())).Convert<DO.Customer, BO.Customer>();
        }
        catch
        {
            throw new Exception();
        }
    }
    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Customer.ReadAll().Select(c=>c.Convert<DO.Customer, BO.Customer>()).ToList();
            return _dal.Customer.ReadAll(c => filter(c.Convert<DO.Customer, BO.Customer>())).Select(c => c.Convert<DO.Customer, BO.Customer>()).ToList();
        }
        catch
        {
            throw new Exception();
        }
    }
    public void Update(BO.Customer item)
    {
        try
        {
            _dal.Customer.Update(item.Convert<BO.Customer, DO.Customer>());
        }
        catch
        {
            throw new Exception();
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Customer.Delete(id);
        }
        catch
        {
            throw new Exception();
        }
    }
}
