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
    public class RestBarController : Controller
    {
        private ApplicationDbContext _context;

        public RestBarController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult indexRB()
        {
            IEnumerable<RestBar> restbar = _context.RestBar;
            return View(restbar);
        }

        public IActionResult CrearRB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("NombreEmpresa,TipoEmpresa,Direccion,Horario,Telefono,SitioWeb,Datos,Representante")] RestBar restbar)
        {
            restbar.ID = Guid.NewGuid();

            _context.RestBar.Add(restbar);
            _context.SaveChanges();

            return View("DetallesRB", restbar);
        }

        public IActionResult EditarRB(Guid Id)
        {
            RestBar restbarEditar = _context.RestBar.Find(Id);
            return View ("EditarRB");
        }

        [HttpPost]
        public IActionResult EditarRB([Bind("ID,NombreEmpresa,TipoEmpresa,Direccion,Horario,Telefono,SitioWeb,Datos,Representante")] RestBar restbar)
        {
            _context.RestBar.Update(restbar);
            _context.SaveChanges();

            return View(restbar);
        }

   // GET: RestBar/DetallesRB/5
   public IActionResult DetallesRB(Guid? id)
   {
       if (id == null)
       {
           return NotFound();
       }

       var restbar = _context.RestBar.FirstOrDefault(m => m.ID == id);
       if (restbar == null)
       {
           return NotFound();
       }

       return View (restbar);
   }

     // GET: RestBar/EliminarRB/5
        public IActionResult EliminarRB(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restbar = _context.RestBar.FirstOrDefault(m => m.ID == id);
            if (restbar == null)
            {
                return NotFound();
            }

            return View(restbar);
        }

        // POST: RestBar/EliminarRB/5
        [HttpPost, ActionName("EliminarRB")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var restbar = _context.RestBar.Find(id);
            _context.RestBar.Remove(restbar);
            _context.SaveChanges();
            return RedirectToAction(nameof(indexRB));
        }

        private bool RestBarExists(Guid id)
        {
            return _context.RestBar.Any(e => e.ID == id);
        }
    }
}