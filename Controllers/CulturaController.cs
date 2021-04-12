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
     public class CulturaController : Controller
    {
         private ApplicationDbContext _context;

         public CulturaController (ApplicationDbContext context)
         {
             _context = context;
         }

         public IActionResult indexC()
         {
             IEnumerable<Cultura> cultura = _context.Cultura;
             return View(cultura);
         }

         public IActionResult CrearC()
         {
             return View();
         }

         [HttpPost]
         public IActionResult Guardar([Bind("Nombre,Direccion,Horario,Historia,Categoria")] Cultura cultura)
         {
             cultura.ID = Guid.NewGuid();

             _context.Cultura.Add(cultura);
             _context.SaveChanges();

             return View("DetallesC", cultura);
         }

         public IActionResult EditarC(Guid Id)
         {
             Cultura culturaEditar = _context.Cultura.Find(Id);
             return View ("DetallesC");
         }

         [HttpPost]
         public IActionResult EditarC([Bind("ID,Nombre,Direccion,Horario,Historia,Categoria")] Cultura cultura)
         {
             _context.Cultura.Update(cultura);
             _context.SaveChanges();

             return View(cultura);
         }

    // GET: Cultura/DetallesC/5
    public IActionResult DetallesC(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var cultura = _context.Cultura.FirstOrDefault(m => m.ID == id);
        if (cultura == null)
        {
            return NotFound();
        }

        return View (cultura);
    }

      // GET: Cultura/EliminarC/5
         public IActionResult EliminarC(Guid? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var cultura = _context.Cultura.FirstOrDefault(m => m.ID == id);
             if (cultura == null)
             {
                 return NotFound();
             }

             return View(cultura);
         }

         // POST: Cultura/EliminarC/5
         [HttpPost, ActionName("EliminarC")]
         public IActionResult DeleteConfirmed(Guid id)
         {
             var cultura = _context.Cultura.Find(id);
             _context.Cultura.Remove(cultura);
             _context.SaveChanges();
             return RedirectToAction(nameof(indexC));
         }

         private bool CulturaExists(Guid id)
         {
             return _context.Cultura.Any(e => e.ID == id);
         }

     }
}