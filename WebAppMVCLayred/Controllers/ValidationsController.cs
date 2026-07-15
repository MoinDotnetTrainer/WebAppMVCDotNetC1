using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{
    public class ValidationsController : Controller
    {
        [HttpGet]
        public IActionResult ValidateData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidateData(Valid dta)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}
