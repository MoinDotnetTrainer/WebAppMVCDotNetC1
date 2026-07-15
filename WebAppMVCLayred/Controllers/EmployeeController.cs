using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{
    public class EmployeeController : Controller
    {

        [HttpGet]
        public IActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(DataAnnotationEx data)
        {
            if (ModelState.IsValid)
            {
                // Insert logic
                return View();
            }
            return View();
        }
    }
}
