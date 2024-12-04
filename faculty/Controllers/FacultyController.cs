using faculty.Models;
using Microsoft.AspNetCore.Mvc;


namespace faculty.Controllers
{
    public class FacultyController : Controller
    {
        private readonly EnvironmentDbContext _faculty;
        public FacultyController(EnvironmentDbContext faculty)
        {
            this._faculty = faculty;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Departments = _faculty.Departments.Select(f => new { f.DId, f.Departments }).ToList();


            return View();
        }
        [HttpPost]
        public IActionResult Index(Facultysurveyform Fs)
        {
            if (ModelState.IsValid)
            {
                _faculty.Facultysurveyforms.Add(Fs);
                _faculty.SaveChanges();

                return RedirectToAction("Index");
            }


            ViewBag.Departments = _faculty.Departments.Select(f => new { f.DId, f.Departments }).ToList();
            return View(Fs);
        }
    }
}
