using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest1.Models;

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
        public IActionResult TestModel()
        {
            var model = new List<ModelTest>
            {
                new ModelTest { TestMessage = "to jest model testowy na Laboratoriach 0" },
                new ModelTest { TestMessage = "to jest model testowy na Laboratoriach 1" },
                new ModelTest { TestMessage = "to jest model testowy na Laboratoriach 2" },
                new ModelTest { TestMessage = "to jest model testowy na Laboratoriach 3" }
        };
            //var model = new ModelTest { TestMessage = "to jest model testowy na Laboratoriach" }; 
            return View(model);
        }
        public IActionResult ShopItems()
        {
            var itemsList = new List<shopItems>
            {
                new shopItems { Item = "shoes" , Price = 420 , Describe = " buty Nike 97 Plus 2020!"},
                new shopItems { Item = "socks" , Price = 20 , Describe = " skarpety Fila 39-42!"},
                new shopItems { Item = "belt" , Price = 280 , Describe = "pasek Lacoste green!"},
                new shopItems { Item = "shoulderbag" , Price = 68 , Describe = "Zelando essentials shoulderbag unisex!"},
                new shopItems { Item = "pants" , Price = 118 , Describe = "spodnie Zara 2020 men black!"},
                new shopItems { Item = "jacket" , Price = 200 , Describe = "kurtka Tommy Hilfiger white!"}
            };

            return View(itemsList);
        }
    }
}