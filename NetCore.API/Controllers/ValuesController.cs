using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LFSCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly QLCContext _context;
        public ValuesController(QLCContext context) => _context = context;
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
          //  return new string[] { "value1", "value4" };
        //}

        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
           var orders = _context.Order.Take(15).ToList();
           return orders;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
