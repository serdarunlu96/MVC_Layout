using ANK13Layout.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ANK13Layout.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YurtIci()
        {
            return View();
        }

        public IActionResult YurtDisi()
        {
            return View();
        }
        public IActionResult Ege()
        {
            return View();
        }

        public IActionResult Akdeniz()
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