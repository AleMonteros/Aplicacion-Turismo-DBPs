using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppSocialTour.Models;

namespace AppSocialTour.Controllers 
{
    public class MenuController : Controller
    {
        public IActionResult Historia()
        {
            return View();
        }

        public IActionResult Mapas()
        {
            return View();
        }

        public IActionResult Novedades()
        {
            return View();
        }

        public IActionResult Promociones()
        {
            return View();
        }

        public IActionResult Configuracion()
        {
            return View();
        } 
    }
}
