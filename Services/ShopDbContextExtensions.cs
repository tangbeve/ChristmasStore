using System;
using System.Collections.Generic;
using System.Linq;
using ChristmasStore.Models;

namespace ChristmasStore.Services
{
    public static class ShopDbContextExtensions
    {
        public static void CreateSeedData
            (this ShopsDbContext context)
        {
            if (context.Shops.Any())
                return;

            var shops = new List<Shop>()
            {
                new Shop()
                {
                    Item = "tree",
                    Price = 2.99
                },
                new Shop()
                {
                    Item = "big tree",
                    Price = 4.99
                },
                new Shop()
                {
                    Item = "big big tree",
                    Price = 20.99
                }
            };
            context.AddRange(shops);
            context.SaveChanges(); 
        }
    }
}
