using Microsoft.AspNetCore.Mvc;
using Unidad2Actividad2.Models.ViewModels;
using Unidad2Actividad2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Unidad2Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PerrosContext context = new();
            var datos = context.Razas.OrderBy(x => x.Nombre)
                .Select(x => new IndexPerrosViewModel
            {
                Id = (int)x.Id,
                NombreRaza = x.Nombre ?? ""                
            });

            return View(datos);
        }
        [Route("/{Nombre}/Detalles")]
        // intentar recordar porque queria cambiar la ruta por defecto 
        //era porque se supone que la ruta seria algo como Home/NombreRaza/Detalles
        //por eso no es la ruta por defecto
        public IActionResult Detalles(string Nombre) 
        {
            PerrosContext context = new();
            var existe = context.Razas.Any(c => c.Nombre.ToLower() == Nombre);

            if (existe is false) 
            {
                return RedirectToAction("Index");
            }

            var datos=context.Razas.Where(x=>x.Nombre.ToLower()==Nombre).Select
            return View(datos);
        }
    }
}
