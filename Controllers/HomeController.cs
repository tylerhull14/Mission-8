using Microsoft.AspNetCore.Mvc;
using Mission_8.Models;
using Mission08_Practice.Models;
using System.Diagnostics;

namespace Mission_8.Controllers
{
    public class HomeController : Controller
    {
        private Mission08_Practice.Models.ActivityContext _context;
        public HomeController(Mission08_Practice.Models.ActivityContext temp) //set up an instance of the database
        {
            _context = temp;
        }
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return base.View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
