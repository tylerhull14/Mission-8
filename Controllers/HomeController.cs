using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission_8.Models;
using System.Diagnostics;
using Activity = Mission_8.Models.Activity;
using ActivityContext = Mission_8.Models.ActivityContext;

namespace Mission_8.Controllers
{

    public class HomeController : Controller
    {
        private ActivityContext _context;

        public HomeController(ActivityContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Matrix()
        {
            return View();
        }


        public IActionResult EditActivity(int id)
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
