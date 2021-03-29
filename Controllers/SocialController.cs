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
    public class SocialController : Controller
    {
        public IActionResult indexS()
        {
            return View();
        }
    }
}