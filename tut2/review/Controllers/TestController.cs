using Microsoft.AspNetCore.Mvc;
using review.Models;

namespace review.Controllers
{
    public class TestController : Controller
    {
        //Default URL: localhost:PORT/Test/Index

        //set custom (user-defined) url
        [Route("/testpage")]
        //localhost:PORT/testpage
        public IActionResult Index()
        {
            //default view location: Views/Test/Index.cshtml
            //return View();

            //set custom view location: Views/Home/Greenwich.cshtml
            return View("~/Views/Home/Greenwich.cshtml");
        }

        public IActionResult Demo()
        {
            string mobile = "iphone";
            
            ViewBag.Mobile1 = mobile;
            ViewBag.Mobile2 = "samsung";

            ViewData["Laptop"] = "Macbook";

            TempData["Error"] = "Add mobile error !";

            return View();
        }

        public IActionResult StudentList()
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student
            {
                Name = "Student 1",
                Age = 20
            };
            Student s2 = new Student
            {
                Name = "Student 2",
                Age = 22
            };
            students.Add(s1);
            students.Add(s2);

            return View(students);
        }
    }
}
