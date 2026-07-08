using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCDotNetC1.Controllers
{
    public class SampleController : Controller
    {

        //Action method

        [HttpGet] // exectes on load
        public IActionResult GetDatetime()
        {
            // Business Logic
            TempData["CurrentDateTime"] ="Date Time on Httpget:"+ DateTime.Now.ToString();  
            return View();
        }

        [HttpPost] // exectes on click
        public IActionResult GetDatetime(int x)
        {
            // Business Logic
            TempData["CurrentDateTime"] = "Date Time on Httppost:" + DateTime.Now.ToString();
            return View();
        }



    }
}
