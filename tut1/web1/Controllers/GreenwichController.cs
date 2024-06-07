using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers
{
    public class GreenwichController : Controller
    {
        //default url1: localhost:PORT/Greenwich
        //default url2: localhost:PORT/Greenwich/Index
        //set custom url (route)
        [Route("/")]  //homepage
        public IActionResult Index()
        {
            //default view path: Views/Greenwich/Index.cshtml
            //return View();
            
            //set custom view path (location)
            return View("~/Views/FPT/Greenwich.cshtml");
        }

        [Route("/hanoi")]
        //url: localhost:PORT/Greenwich/Hanoi
        public IActionResult HaNoi()
        {
            //path: Views/Greenwich/HaNoi.cshtml
            return View();
        }

        public IActionResult HCMCity()
        { 
            return View();
        }

        public IActionResult DaNang()
        {
            return View();
        }

        public IActionResult CanTho()
        {
            return View();
        }
    }
}
