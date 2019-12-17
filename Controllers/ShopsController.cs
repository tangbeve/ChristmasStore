using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodingDojo.Services; 

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingDojo.Controllers
{
    [Route("api/[controller]")]
    public class ShopsController : Controller
    {
        private ShopsDbContext _context;

        public ShopsController(ShopsDbContext context)
        {
            _context = context;
        }


        public IActionResult GetShops()
        {
            return Ok(_context.Shops); 
        }
    }
}
