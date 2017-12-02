using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MigrationWebApp.Models;
using SharedClassLibrary;

namespace MigrationWebApp.Controllers
{
   public class HomeController : Controller
    {
      private readonly DataContext _context;

      public HomeController(DataContext context)
      {
         _context = context;
      }
      public IActionResult Index()
        {
         ViewData["Message"] =DDebug.ToStringify(_context.Employee.ToList());
         return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
