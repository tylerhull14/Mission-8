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
            return View("Matrix");
        }

        public IActionResult Matrix()
        {
            var Activity = _context.Activities.Include(x => x.Category).ToList();
            return View(Activity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var activityToEdit = _context.Activities
                .SingleOrDefault(x => x.ActivityId == id);
            return View("Add", activityToEdit);
        }




        [HttpPost]
        public IActionResult Edit(Activity updatedInfo)

        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("Add");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Activity = _context.Activities
                .Single(x => x.ActivityId == id);
            return View(Activity);
        }

        [HttpPost]
        public IActionResult Delete(Activity updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("Matrix");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View();
        }



        [HttpGet]
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
        public IActionResult Add(Activity response)
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            _context.Activities.Add(response); // Add record to database
            _context.SaveChanges();

            return RedirectToAction("Matrix");
        }

    }
}
