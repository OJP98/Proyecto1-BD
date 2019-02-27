using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aerolineas.Models;

namespace aerolineas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Analisis()
        {
            return View();
        }

        public IActionResult Conclusion()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Diagrama()
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
