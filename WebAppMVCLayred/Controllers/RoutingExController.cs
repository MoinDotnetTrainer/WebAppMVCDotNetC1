using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{


    // Incoming req is mapped with sa conyroller name na action name
    // [Route("[controller]/[Action]")]


    // Incoming req will be ammaped to a controller , it look for Action name , whicvh we define
    // [Route("[controller]")]


    // controller end is getting changed and action will be as it is
    // [Route("xyz/[action]")]


    // diff controller and diff action
    [Route("xyz")]

    public class RoutingExController : Controller
    {

        [Route("GetUsersData")]
        public IActionResult Get()
        {
            return View();
        }


        [Route("AddUsersData")]
        public IActionResult Add()
        {
            return View();
        }


        [Route("GetUsersByID")]
        public IActionResult GetDataByID()
        {
            return View();
        }

        [Route("DeleteData/{id}")]
        public IActionResult Delete(int id)
        {

            TempData["id"] = id;
            return View();
        }

    }
}
