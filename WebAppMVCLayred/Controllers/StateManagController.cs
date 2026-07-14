using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Course { get; set; }

        public decimal Fee { get; set; }
    }
    public class StateManagController : Controller
    {
        public IActionResult Page1()
        {
            ViewBag.vbdata = "Data from Viewbag:" + System.DateTime.Now.ToString();
            ViewData["vddata"] = "Data from View data:" + System.DateTime.Now.ToString();


            // One action i,e page 1 to another action page2

            TempData["tddata"] = "Data from Tempdata :" + System.DateTime.Now.ToString();


            HttpContext.Session.SetString("skey", System.DateTime.Now.ToString());

            return RedirectToAction("Page2");
        }
        public IActionResult Page2()
        {
            //ViewBag.data = TempData["tddata"];
            //TempData.Keep("tddata");

            ViewBag.data = TempData.Peek("tddata");

            ViewBag.sessionvalue = HttpContext.Session.GetString("skey");

            return View();
        }
        public IActionResult Page3()
        {

            List<Student> list = new List<Student>() {
            new Student{ Id=1,Name="xyz",Course="Java",Fee=13}
            };


            // ViewBag.stddata = list;

            ViewData["stddata"] = list;
            ViewBag.sessionvalue = HttpContext.Session.GetString("skey");

            return View();
        }
    }
}
