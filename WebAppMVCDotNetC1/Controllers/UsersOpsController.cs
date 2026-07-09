using Microsoft.AspNetCore.Mvc;
using WebAppMVCDotNetC1.Models;

namespace WebAppMVCDotNetC1.Controllers
{
    public class UsersOpsController : Controller
    {
        public AppDb _db;

        public UsersOpsController() {
            _db = new AppDb();
        }


        [HttpGet]
        public IActionResult AddUsers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUsers(UserModel data)
        {
            _db.userModels.Add(data);
            _db.SaveChanges();
            return View();
        }
    }
}
