using System.Collections.Generic;
using System.Threading.Tasks;
using LFSCore.Models;

namespace NetCore.API.Data
{
    public interface ILFSRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<Order>> GetOrders();
         Task<Order> GetOrder(int id);
    }
}