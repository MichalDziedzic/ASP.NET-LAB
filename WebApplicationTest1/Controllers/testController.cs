using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest1.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Wsei()
        {
            ViewData["Message"] = "Your application description page.";
            //ViewData['']
            return View();
        }
        public IActionResult RedirectToGoogle()
        {
            return Redirect("http://google.com");
        }
        public IActionResult Json()
        {
            return Json(new { person = "Misza", age = "22", surname = "Dziedzic" });
        }
    }
}