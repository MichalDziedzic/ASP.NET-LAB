using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index ()
        {
            var model = new ProductIndexModel()
            {
                TodaysDate = DateTime.Now.ToString()
            };

            return View(model);
        }
        public IActionResult RedirectToOnet()
        {
            return Redirect("http://www.onet.pl");
        }
        public IActionResult GetJson()
        {
            return Json(new { Name = "Barbara", Surname = "Jamroga" });
        }
        public IActionResult ProductModel()
        {
            return View(repository.GetItems());
        }
        
    }
}
