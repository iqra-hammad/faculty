using faculty.Models;
using Microsoft.AspNetCore.Mvc;

namespace faculty.Controllers
{
    public class SupportController : Controller

    {
        private readonly EnvironmentDbContext _environmentDb;
        public SupportController (EnvironmentDbContext environmentDb)
        {
            this._environmentDb = environmentDb;
        }
        
        public IActionResult Index()
        {
            ViewBag.Email =_environmentDb.Emailaddresses.Select(x => x.Email).FirstOrDefault();
            ViewBag.Contact=_environmentDb.Contactnumbers.Select(c => c.Number).FirstOrDefault(); 
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contactform cf)
        {
            if (ModelState.IsValid) { 
            _environmentDb.Contactforms.Add(cf);
                _environmentDb.SaveChanges();
                return View(cf);
            
            
            }
            return View("Index");

        }
    }
}
