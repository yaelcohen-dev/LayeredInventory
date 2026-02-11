using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface ICrud<T>
    {
        int Create(T item); //Creates new entity item in DAL
        T? Read(int id); //Reads entity item by its ID 
        T? Read(Func<T, bool> filter); //Reads entity item by filter function
        List<T?> ReadAll(Func<T, bool>? filter = null); //stage 1 only, Reads all entity items by filter function
        void Update(T item); //Updates entity item
        void Delete(int id); //Deletes an item by its Id
    }
}
