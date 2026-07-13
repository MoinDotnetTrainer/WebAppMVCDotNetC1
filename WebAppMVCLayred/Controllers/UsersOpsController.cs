using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{
    public class UsersOpsController : Controller
    {

        public readonly IUsers _iuser;
        public UsersOpsController(IUsers iuser)
        {
            _iuser = iuser;
        }

        [HttpGet]
        public IActionResult AddUsers()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUsers(Users data)
        {
            await _iuser.AddUsers(data);
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel data)
        {
            var res = await _iuser.Validate(data);
            if (res)
            {
                return RedirectToAction("HomePage");
            }
            else
            {
                TempData["errormsg"] = "Invalid Credentials";
                return View();
            }
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}
