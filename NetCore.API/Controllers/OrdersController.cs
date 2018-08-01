using System.Collections.Generic;
using System.Linq;
using LFSCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NetCore.API.Data;

namespace NetCore.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILFSRepository _repo;
        public OrdersController(ILFSRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _repo.GetOrders();

            return Ok(orders);
        }

        //[AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {

            var order = await _repo.GetOrder(id);

            return Ok(order);
        }
    }
}