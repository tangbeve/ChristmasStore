using System;
using System.Collections.Generic;
using System.Linq;
using ChristmasStore.Models;

namespace ChristmasStore.Services
{
    public static class UserDbContextExtensions
    {
        public static void CreateSeedData
           (this UsersDbContext context)
        {
            if (context.Users.Any())
                return;

            var users = new List<User>()
            {
                new User()
                {
                    FirstName = "Tangee",
                    LastName = "Beverly",
                    UserName = "tang",
                    Email="tlbeverly96@gmail.com",
                    Password="abcd1234",
                    PhoneNumber="252-209-0054"

                },
                new User()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    UserName = "jan12",
                    Email="jan12@gmail.com",
                    Password="abcd1235",
                    PhoneNumber="252-209-0000"
                },
                new User()
                {
                     FirstName = "John",
                    LastName = "Doe",
                    UserName = "joh13",
                    Email="joh13@gmail.com",
                    Password="abcd1236",
                    PhoneNumber="123-456-7890"
                }
            };
            context.AddRange(users);
            context.SaveChanges();
        }

        
    }
}
