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
    public class PromocionesController : Controller
    {
        private ApplicationDbContext _context;

        public PromocionesController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult indexP()
        {
            IEnumerable<Promocion> promocion = _context.Promocion;
            return View(promocion);
        }

        public IActionResult CrearP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("Promo,TipoNegocio,NombreNegocio,Direccion,DatosPromo")] Promocion promocion)
        {
            promocion.ID = Guid.NewGuid();

            _context.Promocion.Add(promocion);
            _context.SaveChanges();

            return View("DetallesP", promocion);
        }

        public IActionResult EditarP(Guid Id)
        {
            Promocion promocionesEditar = _context.Promocion.Find(Id);
            return View ("EditarP");
        }

        [HttpPost]
        public IActionResult EditarP([Bind("ID,Promo,TipoNegocio,NombreNegocio,Direccion,DatosPromo")] Promocion promocion)
        {
            _context.Promocion.Update(promocion);
            _context.SaveChanges();

            return View(promocion);
        }

   // GET: Promociones/DetallesP/5
   public IActionResult DetallesP(Guid? id)
   {
       if (id == null)
       {
           return NotFound();
       }

       var promocion = _context.Promocion.FirstOrDefault(m => m.ID == id);
       if (promocion == null)
       {
           return NotFound();
       }

       return View (promocion);
   }

     // GET: Promociones/EliminarP/5
        public IActionResult EliminarP(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promocion = _context.Promocion.FirstOrDefault(m => m.ID == id);
            if (promocion == null)
            {
                return NotFound();
            }

            return View(promocion);
        }

        // POST: Promociones/EliminarP/5
        [HttpPost, ActionName("EliminarP")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var promocion = _context.Promocion.Find(id);
            _context.Promocion.Remove(promocion);
            _context.SaveChanges();
            return RedirectToAction(nameof(indexP));
        }

        private bool PromocionExists(Guid id)
        {
            return _context.Promocion.Any(e => e.ID == id);
        }

    }
}        