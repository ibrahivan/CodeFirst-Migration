using CodeFirst_Migration.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirst_Migration.Controllers
{
    public class HomeController : Controller
    {
        private readonly Contexto contexto;
        public HomeController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}