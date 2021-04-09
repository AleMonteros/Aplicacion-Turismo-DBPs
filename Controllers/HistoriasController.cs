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
    public class HistoriasController : Controller
    {
        private ApplicationDbContext _context;

        public HistoriasController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult History()
        {
            IEnumerable<Historia> historia = _context.Historia;
            return View(historia);
        }

        public IActionResult ContarH()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("Titulo,Desarrollo,PaginasReferencia,Historiador,EmailHistoriador")] Historia historia)
        {
            historia.ID = Guid.NewGuid();

            _context.Historia.Add(historia);
            _context.SaveChanges();

            return View("MostrarH", historia);
        }

        public IActionResult ModificarH(Guid Id)
        {
            Historia historiaModificar = _context.Historia.Find(Id);
            return View ("ModificarH");
        }

        [HttpPost]
        public IActionResult ModificarH([Bind("ID,Titulo,Desarrollo,PaginasReferencia,Historiador,EmailHistoriador")] Historia historia)
        {
            _context.Historia.Update(historia);
            _context.SaveChanges();

            return View(historia);
        }

        // GET: Historia/MostrarH/5
        public IActionResult MostrarH(Guid? id)
        {
            if (id == null)
            {
            return NotFound();
        }

            var historia = _context.Historia.FirstOrDefault(m => m.ID == id);
            if (historia == null)
            {
                return NotFound();
            }

            return View (historia);
        }

        // GET: Historia/BorrarH/5
        public IActionResult BorrarH(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historia = _context.Historia.FirstOrDefault(m => m.ID == id);
            if (historia == null)
            {
                return NotFound();
            }

            return View(historia);
        }

        // POST: Historia/BorrarH/5
        [HttpPost, ActionName("BorrarH")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var historia = _context.Historia.Find(id);
            _context.Historia.Remove(historia);
            _context.SaveChanges();
            return RedirectToAction(nameof(History));
        }

        private bool HistoriaExists(Guid id)
        {
            return _context.Historia.Any(e => e.ID == id);
        }

    }
}