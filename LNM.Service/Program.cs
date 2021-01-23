using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LNM.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LNM.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Apply migrations
            using(var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<LNMContext>();
                db.Database.EnsureDeleted();
                db.Database.Migrate();
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
