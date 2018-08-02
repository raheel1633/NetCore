using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LFSCore.Models;
using Microsoft.EntityFrameworkCore;
using NetCore.API.Helpers;

namespace NetCore.API.Data
{
    public class LFSRepository : ILFSRepository
    {
        public QLCContext _context { get; set; }
        public LFSRepository(QLCContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Order> GetOrder(int id)
        {
            return await _context.Order.FirstOrDefaultAsync(o => o.OrderId == id);
        }

        //public async Task<IEnumerable<Order>> GetOrders()
        //{
          //  var orders = await  _context.Order.Take(15).Include(o => o.BilltoCliententity).ThenInclude(c => c.Entity).ToListAsync();
            //var orders = await  _context.Order.Take(15).ToListAsync();
            
            //return orders;
        //}
        public async Task<PagedList<Order>> GetOrders(Params orderParams)
        {
            var orders =  _context.Order.Where(c=>c.ClientId == 49 && c.OrdertypeId == 1 && c.OrderstatusId == 39).Include(o => o.BilltoCliententity).ThenInclude(c => c.Entity);
            //var orders = await  _context.Order.Take(15).ToListAsync();
            
            return await PagedList<Order>.CreateAsync(orders, orderParams.PageNumber, orderParams.PageSize);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}