using System;
using Microsoft.EntityFrameworkCore;
using ChristmasStore.Models;

namespace ChristmasStore.Services
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
    
}
