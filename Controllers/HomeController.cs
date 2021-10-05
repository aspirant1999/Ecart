using Ecart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using products;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecart.Controllers
{

    public class HomeController : Controller
    {
        productRepository repository = null;

        //public HomeController()
        //{
        //    repository = new productRepository();
        //}

        [Route("/")]
        public IActionResult GetallProducts()
        {
            var result = repository.getAllProducts();
            if(result != null)
                return View(result);
            else
                ViewBag
        }
    }
}
