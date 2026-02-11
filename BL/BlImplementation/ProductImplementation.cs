using BO;
using BlApi;

namespace BlImplementation;

internal class ProductImplementation:IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Product item)
    {
        try
        {
            return _dal.Product.Create(item.Convert<BO.Product, DO.Product>());

        }
        catch (Exception)
        {
            throw new Exception();
        }
    }
    public BO.Product? Read(int id)
    {
        if (!DoesExist(id))
            throw new Exception();
        return _dal.Product.Read(id).Convert<DO.Product, BO.Product>();
    }
    public bool DoesExist(int id)
    {
        try
        {
            _dal.Product.Read(id);
            return true;
        }
        catch
        {
            return false;
        }
    }
   public BO.Product? Read(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Product.ReadAll().First().Convert<DO.Product, BO.Product>();
            return _dal.Product.Read(c => filter(c.Convert<DO.Product, BO.Product>())).Convert<DO.Product, BO.Product>();
        }
        catch
        {
            throw new Exception();
        }
    }
    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Product.ReadAll().Select(c => c.Convert<DO.Product, BO.Product>()).ToList();
            return _dal.Product.ReadAll(c => filter(c.Convert<DO.Product, BO.Product>())).Select(c => c.Convert<DO.Product, BO.Product>()).ToList();
        }
        catch
        {
            throw new Exception();
        }
    }
    public void Update(BO.Product item)
    {
        try
        {
            _dal.Product.Update(item.Convert<BO.Product, DO.Product>());
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
            _dal.Product.Delete(id);
        }
        catch
        {
            throw new Exception();
        }
    }

    public List<Sale> AllSales(int id, bool IsClubMember)
    {
       return  _dal.Sale.ReadAll(s=>s.Id==id&&s.IsForClub==false||IsClubMember==true).Select(s => s.Convert<DO.Sale, BO.Sale>()).ToList();
    }
}
