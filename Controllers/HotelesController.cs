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
    public class HotelesController : Controller
    {
        private ApplicationDbContext _context;

        public HotelesController (ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult indexH()
        {
            IEnumerable<Hotel> hotel = _context.Hotel;
            return View(hotel);
        }

        public IActionResult CrearH()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("NombreEmpresa,TipoEmpresa,Direccion,Horario,Telefono,SitioWeb,Datos,Representante")] Hotel hotel)
        {
            hotel.ID = Guid.NewGuid();

            _context.Hotel.Add(hotel);
            _context.SaveChanges();

            return View("DetallesH", hotel);
        }

        public IActionResult EditarH(Guid Id)
        {
            Hotel hotelEditar = _context.Hotel.Find(Id);
            return View ("DetallesH");
        }

        [HttpPost]
        public IActionResult EditarH([Bind("ID,NombreEmpresa,TipoEmpresa,Direccion,Horario,Telefono,SitioWeb,Datos,Representante")] Hotel hotel)
        {
            _context.Hotel.Update(hotel);
            _context.SaveChanges();

            return View(hotel);
        }

   // GET: Hoteles/DetallesH/5
   public IActionResult DetallesH(Guid? id)
   {
       if (id == null)
       {
           return NotFound();
       }

       var hotel = _context.Hotel.FirstOrDefault(m => m.ID == id);
       if (hotel == null)
       {
           return NotFound();
       }

       return View (hotel);
   }

     // GET: Hoteles/EliminarH/5
        public IActionResult EliminarH(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = _context.Hotel.FirstOrDefault(m => m.ID == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // POST: Hoteles/EliminarH/5
        [HttpPost, ActionName("EliminarH")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var hotel = _context.Hotel.Find(id);
            _context.Hotel.Remove(hotel);
            _context.SaveChanges();
            return RedirectToAction(nameof(indexH));
        }

        private bool HotelExists(Guid id)
        {
            return _context.Hotel.Any(e => e.ID == id);
        }


    // public void GuardarHotelEnSeccion(Hotel hotelAGuardar)
    // {
    //     HttpContext.Session.Set<Hotel>("HotelActivo", hotelAGuardar);
    // }

    // public JsonResult VerHotelEnSeccion()
    // {
    //     Hotel hotelEnSession = HttpContext.Session.Get<Hotel>("HotelActivo");
    //     return Json(HotelEnSeccion);
    // }
        
    }
}