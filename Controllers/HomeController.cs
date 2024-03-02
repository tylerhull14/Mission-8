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
        private IActivityRepository _repo;

        public HomeController(IActivityRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Matrix()
        {
            var Activity = _repo.Activities;
            return View(Activity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var ActivityToEdit = _repo.Activities
                .SingleOrDefault(x => x.ActivityId == id);

            return View("Add", ActivityToEdit);
        }



        [HttpPost]
        public IActionResult Edit(Activity updatedInfo)

        {
            _repo.EditActivity(updatedInfo);
            return RedirectToAction("Matrix");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Activity = _repo.Activities
                .Single(x => x.ActivityId == id);
            return View(Activity);
        }

        [HttpPost]
        public IActionResult Delete(Activity updatedInfo)
        {
            _repo.DeleteActivity(updatedInfo);
            return RedirectToAction("Matrix");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View(new Activity());
        }



        [HttpGet]
        public IActionResult EditActivity(int id)
        {

            var activityToEdit = _repo.Activities
            .Single(x => x.ActivityId == id);

            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Add", activityToEdit);
        }



        [HttpPost]
        public IActionResult Add(Activity response)
        {
            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            _repo.AddActivity(response);

            return RedirectToAction("Matrix");
        }

        [HttpGet]
        public IActionResult Test()
        {
            var allActivities = _repo.GetAllActivities();
            return View(allActivities);
        }
    }
}