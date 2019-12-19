using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ChristmasStore.Services;
using Microsoft.EntityFrameworkCore;
//using System.Configuration;
using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging.Configuration; 

namespace ChristmasStore
{

    public class Startup
    {
        public static IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString ="Server=localhost;Database=ShopDB;User Id=sa;Password=Passw0rd!";

            services
              .AddDbContext<ShopsDbContext>(o =>
                o.UseSqlServer(connectionString));

            services
                .AddDbContext<UsersDbContext>(o =>
                o.UseSqlServer(connectionString));

            services.AddMvc();
            services.AddControllers(options => options.EnableEndpointRouting = false);
        }
       

        public void Configure(IApplicationBuilder app,IHostEnvironment env, ShopsDbContext shopsDbContext, UsersDbContext usersDbContext)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            }
            app.UseStaticFiles();

            shopsDbContext.CreateSeedData();
            usersDbContext.CreateSeedData(); 

            app.UseMvc(); 


            //app.Run(async (context) =>
            //{
            //    await context
            //            .Response
            //            .WriteAsync("Hello");
            //});

        }
    }
}
