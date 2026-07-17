using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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
            if (ModelState.IsValid)
            {
                await _iuser.AddUsers(data);
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel data)
        {
            ClaimsIdentity? identity = null;
            bool isautheticate = false;

            if (ModelState.IsValid)  // TF 
            {
                var res = await _iuser.Validate(data);
                var myroles = await _iuser.GetUsers(data.Email);

                if (res)
                {
                    HttpContext.Session.SetString("loginsession", "userloggedin");

                    // auth & autho
                    // claimidentity

                    identity = new ClaimsIdentity(new[]
                    {
                   new Claim(ClaimTypes.Email,data.Email), // xyz
                   new Claim(ClaimTypes.Role,myroles.Role), // admin
                   }, CookieAuthenticationDefaults.AuthenticationScheme);
                    isautheticate = true;



                    if (isautheticate)
                    {
                        var principals = new ClaimsPrincipal(identity);
                        var redirect = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principals);
                        return RedirectToAction("HomePage", "UsersOps",redirect);  //take the roles
                    }
                }
                else
                {
                    TempData["errormsg"] = "Invalid Credentials";
                    // return View();

                    return PartialView("Errorpartial");
                }
            }
            else
            {
                ModelState.AddModelError("", "");
            }

            return View();
        }


        [AllowAnonymous]
        public IActionResult HomePage()
        {
            if (HttpContext.Session.GetString("loginsession") == null)
            {
                return RedirectToAction("Login", "Usersops");
            }

            ViewBag.sessionvalue = HttpContext.Session.GetString("skey");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult GetArrayData()
        {
            int x = 34;
            int y = 0;
            TempData["res"] = x / y;
            return View();
        }
    }
}
