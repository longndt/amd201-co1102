using Microsoft.AspNetCore.Mvc;
using web1.Models;

namespace web1.Controllers
{
    public class MobileController : Controller
    {
        [HttpGet]
        public IActionResult AddMobile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ViewMobile(Mobile mobile)
        {
            return View(mobile); 
        }

        public IActionResult ListMobile()
        {
            List<Mobile> mobiles = new List<Mobile>();
            Mobile m1 = new Mobile
            {
                Name = "iphone",
                Price = 999.99,
                Quantity = 10,
                Color = "Red"
            };
            Mobile m2 = new Mobile
            {
                Name = "samsung",
                Price = 888.88,
                Quantity = 20,
                Color = "Blue"
            };
            mobiles.Add(m1);
            mobiles.Add(m2);
            mobiles.Add(
                new Mobile
                {
                    Name = "huawei",
                    Price = 666.66,
                    Quantity = 30,
                    Color = "Silver"
                }
            );

            //data binding (data passing)
            //method 4: pass data with model
            return View(mobiles);
        }
    }
}
