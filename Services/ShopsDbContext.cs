 using System;
using Microsoft.EntityFrameworkCore;
using ChristmasStore.Models;

namespace ChristmasStore.Services
{
    public class ShopsDbContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public ShopsDbContext(DbContextOptions<ShopsDbContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }

    }
}
