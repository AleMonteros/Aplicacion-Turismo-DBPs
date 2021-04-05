using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppSocialTour.Models;
using AppSocialTour.Data;

namespace AppSocialTour.Controllers 
{
    public class SocialController : Controller
    {
        private ApplicationDbContext _context;

        public SocialController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult indexS()
        {
            IEnumerable<Social> social = _context.Social;
            return View(social);
        }

        public IActionResult CrearS()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("Nombre,Direccion,Horario,Telefono,SitioWeb,Historia")] Social social)
        {
            social.ID = Guid.NewGuid();

            _context.Social.Add(social);
            _context.SaveChanges();

            return View("DetallesS", social);
        }

        public IActionResult EditarS(Guid Id)
        {
            Social socialEditar = _context.Social.Find(Id);
            return View ("EditarS");
        }

        [HttpPost]
        public IActionResult EditarS([Bind("ID,Nombre,Direccion,Horario,Telefono,SitioWeb,Historia")] Social social)
        {
            _context.Social.Update(social);
            _context.SaveChanges();

            return View(social);
        }

   // GET: Social/DetallesS/5
   public IActionResult DetallesS(Guid? id)
   {
       if (id == null)
       {
           return NotFound();
       }

       var social = _context.Social.FirstOrDefault(m => m.ID == id);
       if (social == null)
       {
           return NotFound();
       }

       return View (social);
   }

     // GET: Social/EliminarS/5
        public IActionResult EliminarS(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var social = _context.Social.FirstOrDefault(m => m.ID == id);
            if (social == null)
            {
                return NotFound();
            }

            return View(social);
        }

        // POST: Social/EliminarS/5
        [HttpPost, ActionName("EliminarS")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var social = _context.Social.Find(id);
            _context.Social.Remove(social);
            _context.SaveChanges();
            return RedirectToAction(nameof(indexS));
        }

        private bool HotelExists(Guid id)
        {
            return _context.Hotel.Any(e => e.ID == id);
        }

    }
}