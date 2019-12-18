using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodingDojo.Services;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingDojo.Controllers
{
    //[Route("api/[controller]")]
    [Route("api")]
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

        [HttpGet]
        [Route("display")]
        public async Task<IActionResult> Display(int? ID)
        {
            ViewBag.Title = "Christmas shop";

            if (ID == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .FirstOrDefaultAsync(s => s.ID == ID);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }
    }
}