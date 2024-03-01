using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public IActionResult EditActivity(ActivtyID)
        {

        var activityToEdit = _context.Activities
        .Single(x => x.ActivityId == id);

        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();

        return View("Add", activityToEdit);
        }


        




        [HttpPost]
        public IActionResult Name()
        {
            return View("");
        }




    }
}
