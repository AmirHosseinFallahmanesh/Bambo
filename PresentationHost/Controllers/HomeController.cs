using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bambo.Core.Entites;
using Bambo.Domin.Contract;
using Microsoft.AspNetCore.Mvc;
using PresentationHost.Models;

namespace PresentationHost.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdctService productService;

        public HomeController(IProdctService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            List<Product> prodcuts = productService.GetChippestProduct();
            return View(prodcuts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
