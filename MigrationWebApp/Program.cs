using System;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using MigrationWebApp.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MigrationWebApp
{
   public class Program
   {
      public static void Main(string[] args)
      {
         var host = BuildWebHost(args);
         using (var scope = host.Services.CreateScope())
         {
            var services = scope.ServiceProvider;
            try
            {
               var context = services.GetRequiredService<DataContext>();
               if (!context.Employee.Any()) // Check for Employee data
               {
                  // Seed the database with employees
                  context.Employee.Add(new Employee() { FirstName = "John", LastName = "Kocer" });
                  context.Employee.Add(new Employee() { FirstName = "Adam", LastName = "Lee" });
                  context.Employee.Add(new Employee() { FirstName = "Jon", LastName = "Walker" });
                  context.Employee.Add(new Employee() { FirstName = "Jen", LastName = "Walker" });
                  context.SaveChanges();
               }
            }
            catch (Exception ex)
            {
               var logger = services.GetRequiredService<ILogger<Program>>();
               logger.LogError(ex, "An error occurred while seeding the database.");
            }
         }

         host.Run();
      }

      public static IWebHost BuildWebHost(string[] args) =>
          WebHost.CreateDefaultBuilder(args)
              .UseStartup<Startup>()
              .Build();
   }
}