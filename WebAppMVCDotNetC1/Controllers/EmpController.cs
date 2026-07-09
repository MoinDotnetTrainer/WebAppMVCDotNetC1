using Microsoft.AspNetCore.Mvc;
using WebAppMVCDotNetC1.Models;

namespace WebAppMVCDotNetC1.Controllers
{
    public class EmpController : Controller
    {

        public AppDb _db;
        public EmpController()
        {
            _db = new AppDb();
        }

        [HttpGet]
        public IActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(EmpModel data)
        {
            // where the data with be transfered --> database

            _db.EmpModels.Add(data);
            _db.SaveChanges();

            // to insert into db using ef
            return View();
        }
    }
}
