using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChristmasStore.Services;
using Microsoft.EntityFrameworkCore;
using ChristmasStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChristmasStore.Controllers
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

       
       private  ShopsDbContext _context;
       private   UsersDbContext context_;

        public YourController(ShopsDbContext context, UsersDbContext context1)
        {
            _context = context;
            context_ = context1; 
        }

        [HttpGet]
        [Route("display")]
        public IActionResult Display()
        {
            List<Shop> shop = _context.Shops
                .OrderBy(s => s.Item)
                .ToList(); 

            ViewBag.AllShops = shop;
            return View();  
           
        }


        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            List<User> user = context_.Users
                .OrderBy(s => s.FirstName)
                .ToList();

            ViewBag.AllUsers = user;
            return View();

        }



    }
}
