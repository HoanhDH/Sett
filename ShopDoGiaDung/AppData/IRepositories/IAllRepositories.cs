using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepositories
{
    public interface IAllRepositories<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool CreateItem(T item);
        bool UpdateItem(T item);
        bool DeleteItem(T item);
    }
}
