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
    public class NovedadesController : Controller
    {
        private ApplicationDbContext _context;

        public NovedadesController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult indexN()
        {
            IEnumerable<Novedad> novedad = _context.Novedad;
            return View(novedad);
        }

        public IActionResult CrearN()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("Noticia, Lugar, Direccion,Mensaje")] Novedad novedad)
        {
            novedad.ID = Guid.NewGuid();

            _context.Novedad.Add(novedad);
            _context.SaveChanges();

            return View("DetallesN", novedad);
        }

        public IActionResult EditarN(Guid Id)
        {
            Novedad novedadEditar = _context.Novedad.Find(Id);
            return View ("DetallesN");
        }

        [HttpPost]
        public IActionResult EditarN([Bind("ID, Noticia, Lugar, Direccion, Mensaje")] Novedad novedad)
        {
            _context.Novedad.Update(novedad);
            _context.SaveChanges();

            return View(novedad);
        }

   // GET: Novedades/DetallesN/5
   public IActionResult DetallesN(Guid? id)
   {
       if (id == null)
       {
           return NotFound();
       }

       var novedad = _context.Novedad.FirstOrDefault(m => m.ID == id);
       if (novedad == null)
       {
           return NotFound();
       }

       return View (novedad);
   }

     // GET: Novedades/EliminarN/5
        public IActionResult EliminarN(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novedad = _context.Novedad.FirstOrDefault(m => m.ID == id);
            if (novedad == null)
            {
                return NotFound();
            }

            return View(novedad);
        }

        // POST: Novedades/EliminarN/5
        [HttpPost, ActionName("EliminarN")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var novedad = _context.Novedad.Find(id);
            _context.Novedad.Remove(novedad);
            _context.SaveChanges();
            return RedirectToAction(nameof(indexN));
        }

        private bool NovedadExists(Guid id)
        {
            return _context.Novedad.Any(e => e.ID == id);
        }

    }
}      