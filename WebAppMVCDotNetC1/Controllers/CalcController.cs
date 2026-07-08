using Microsoft.AspNetCore.Mvc;
using WebAppMVCDotNetC1.Models;

namespace WebAppMVCDotNetC1.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            TempData["res"] = "No Result on Load";
            return View();
        }

        [HttpPost]
        public IActionResult Add(int number1, int number2)
        {
            int z = number1 + number2;
            TempData["res"] = "On Submit: " + z;
            return View();
        }

        [HttpGet]
        public IActionResult Sub()
        {
            TempData["res"] = "No Result on Load";
            return View();
        }
        [HttpPost]
        public IActionResult Sub(MyvaluesModel obj)
        {
            int z= obj.x - obj.y;
            TempData["res"] = z;
            return View();
        }



    }
}
