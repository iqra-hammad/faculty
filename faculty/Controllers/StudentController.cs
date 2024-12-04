using faculty.Models;
using Microsoft.AspNetCore.Mvc;

namespace faculty.Controllers
{
    public class StudentController : Controller
    {
        private readonly EnvironmentDbContext _student;
        public StudentController(EnvironmentDbContext student)
        {
            this._student = student;
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Class = _student.Classes.Select(c => new { c.CId, c.Class1 }).ToList();
            ViewBag.Specification = _student.Specifications.Select(s => new { s.SId, s.SName }).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentSurveyForm Sf)
        {
            if (ModelState.IsValid)
            {
                _student.StudentSurveyForms.Add(Sf);
                _student.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Class = _student.Classes.Select(c => new { c.CId, c.Class1 }).ToList();
            ViewBag.Specification = _student.Specifications.Select(s => new { s.SId, s.SName }).ToList();

            return View(Sf);
        }


    }
}

