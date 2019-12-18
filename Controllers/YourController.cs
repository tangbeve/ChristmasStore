using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingDojo.Controllers
{
    public class YourController : Controller 
    {
        //private readonly ShopsDbContext _context;
        //public YourController(ShopsDbContext context)
        //{
        //    _context = context; 
        //}

        [HttpGet]
        [Route("")]

        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("home")]

        public ViewResult Home()
        {
            return View();
        }


        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View();
        }
        [HttpGet]
        [Route("about")]
        public IActionResult About()
        {
            ViewBag.About = "Christmas Shop sells christmas stuff";
            return View(); 
        }
        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            ViewBag.Name = "Christmas Shop";
            ViewBag.Location = "6283 Christmas Lane, North Pole";
            ViewBag.Number = "252-209-4185";
            ViewBag.Email = "merryChristmas19@gmail.com";
            return View(); 
        }
        //[HttpGet]
        //[Route("display")]
        //public async Task<IActionResult> Display(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound(); 
        //    }

        //    var shop = await _context.Shops
        //        .FirstOrDefaultAsync(s => s.id == id);
        //    if(shop == null)
        //    {
        //        return NotFound(); 
        //    }

        //    return View(shop); 
       // }

        //public ViewResult Contact()
        //{

        //    //return View(); 
        //}
      
    }
}
