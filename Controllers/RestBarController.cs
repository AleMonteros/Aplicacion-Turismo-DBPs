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
    public class RestBarController : Controller
    {
        public IActionResult indexRB()
        {
            return View();
        }
    }
}