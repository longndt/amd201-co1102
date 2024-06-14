using Microsoft.AspNetCore.Mvc;
using review.Models;
using System.Diagnostics;

namespace review.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //URL: localhost:PORT/Home/Demo
        public IActionResult Demo()
        {
            //Location: Views/Home/Demo.cshtml
            return View();
        }
    }
}
