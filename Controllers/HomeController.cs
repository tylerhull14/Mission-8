using Microsoft.AspNetCore.Mvc;
using Mission_8.Models;
using System.Diagnostics;

namespace Mission_8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Matrix()
        {
            return View();
        }
    }
}
