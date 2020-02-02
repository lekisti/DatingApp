using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        // IActionResult return type allows returning http responses to the client.
        // Synchronous calls block thread until code gets value from database and returns it.
            // And doesn't allow for multiple requests.
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            // use FirstOrDefault because exceptions can be heavy.
            var value = await _context.Values.FirstOrDefaultAsync(val => val.Id == id);
            return Ok(value);
        }
    }
}