using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{
    public class StateManagController : Controller
    {
        public IActionResult Page1()
        {
            ViewBag.vbdata = "Data from Viewbag:" + System.DateTime.Now.ToString();
            ViewData["vddata"] = "Data from View data:" + System.DateTime.Now.ToString();
         

            // One action i,e page 1 to another action page2
            
            TempData["tddata"] = "Data from Tempdata :" + System.DateTime.Now.ToString();
            return RedirectToAction("Page2");
        }
        public IActionResult Page2()
        {
           TempData["tddata"]
            return View();
        }
        public IActionResult Page3()
        {
            return View();
        }
    }
}
