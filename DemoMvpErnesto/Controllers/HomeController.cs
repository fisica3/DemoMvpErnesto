using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvpErnesto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Esta es una prueba de concepto con .Net Core.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Pagina de contactos en Construcción.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
