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
                HttpContext.Session.SetString("loginsession","userloggedin");
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
            if (HttpContext.Session.GetString("loginsession")==null)
            {
                return RedirectToAction("Login","Usersops");
            }

            ViewBag.sessionvalue = HttpContext.Session.GetString("skey");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
