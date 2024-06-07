using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //data binding (passing) from controller (back-end) to view (front-end)

            //method 1: using ViewBag
            ViewBag.Day = "Friday";
            ViewBag.Year = 2024;

            //method 2: using ViewData
            ViewData["DateTime"] = DateTime.Now;

            //method 3: using TempData
            TempData["Message"] = "Add new product succeed";

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            //render form login for user to input
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            //check login information & return result 
            if (username == "admin" && password == "123456")
            {
                ViewBag.Result = "Login Succeed !";
            } else
            {
                ViewBag.Result = "Login Failed !";
            }
            return View("~/Views/Demo/Result.cshtml");
        }
    }
}
