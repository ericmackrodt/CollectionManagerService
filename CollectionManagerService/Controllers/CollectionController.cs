using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionManagerService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollectionManagerService.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CollectionController : Controller
    {
        private readonly DatabaseContext _context;

        public CollectionController(DatabaseContext context) {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Collection>> Get()
        {
            return await _context.Collections.ToListAsync();
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
