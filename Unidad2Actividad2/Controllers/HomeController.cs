using Microsoft.AspNetCore.Mvc;
using Unidad2Actividad2.Models.ViewModels;
using Unidad2Actividad2.Models.Entities;

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
        // intentar recordar porque queria cambiar la ruta por defecto
        public IActionResult Detalles() 
        {
            return View();
        }
    }
}
