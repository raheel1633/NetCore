using System.Collections.Generic;
using System.Linq;
using LFSCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace NetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly QLCContext _context;
        public OrdersController(QLCContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
           var orders = await _context.Order.Take(15).ToListAsync();
           
           return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id){

            var order = await _context.Order.FirstOrDefaultAsync(c=>c.OrderId == id);
            
            return Ok(order);
        }
    }
}