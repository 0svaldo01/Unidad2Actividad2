using Microsoft.AspNetCore.Mvc;

namespace Unidad2Actividad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
