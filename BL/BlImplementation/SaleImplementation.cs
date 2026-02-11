using BO;
using BlApi;

namespace BlImplementation;

internal class SaleImplementation:ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale item)
    {
        try
        {
            return _dal.Sale.Create(item.Convert<BO.Sale, DO.Sale>());
        }
        catch (Exception)
        {
            throw new Exception();
        }
    }
    public BO.Sale? Read(int id)
    {
        if (!DoesExist(id))
            throw new Exception();
        return _dal.Sale.Read(id).Convert<DO.Sale, BO.Sale>();
    }
    public bool DoesExist(int id)
    {
        try
        {
            _dal.Sale.Read(id);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public BO.Sale? Read(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Sale.ReadAll().First().Convert<DO.Sale, BO.Sale>();
            return _dal.Sale.Read(c => filter(c.Convert<DO.Sale, BO.Sale>())).Convert<DO.Sale, BO.Sale>();
        }
        catch
        {
            throw new Exception();
        }
    }
    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Sale.ReadAll().Select(c => c.Convert<DO.Sale, BO.Sale>()).ToList();
            return _dal.Sale.ReadAll(c => filter(c.Convert<DO.Sale, BO.Sale>())).Select(c => c.Convert<DO.Sale, BO.Sale>()).ToList();
        }
        catch
        {
            throw new Exception();
        }
    }
    public void Update(BO.Sale item)
    {
        try
        {
            _dal.Sale.Update(item.Convert<BO.Sale, DO.Sale>());
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
            _dal.Sale.Delete(id);
        }
        catch
        {
            throw new Exception();
        }
    }
}
