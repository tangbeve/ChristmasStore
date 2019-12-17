 using System;
using Microsoft.EntityFrameworkCore;
using CodingDojo.Models;

namespace CodingDojo.Services
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
