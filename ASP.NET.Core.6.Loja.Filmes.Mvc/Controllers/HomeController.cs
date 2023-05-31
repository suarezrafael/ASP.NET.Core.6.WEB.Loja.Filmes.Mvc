using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
