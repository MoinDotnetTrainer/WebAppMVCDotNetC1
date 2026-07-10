using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
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
            return RedirectToAction("DisplayEmp");
        }

        [HttpGet]
        public IActionResult DisplayEmp()
        {
            IEnumerable<EmpModel> res = from s in _db.EmpModels select s;
            return View(res);
        }

        [HttpGet]
        public IActionResult EditEmp(int EmpID)
        {
            var res = _db.EmpModels.Find(EmpID);

            return View(res);
        }

        [HttpPost]
        public IActionResult EditEmp(EmpModel data)
        {
            _db.EmpModels.Update(data);
            _db.SaveChanges();

            return RedirectToAction("DisplayEmp");
        }
        [HttpGet]
        public IActionResult DeleteEmp(int EmpID)
        {
            var res = _db.EmpModels.Find(EmpID);

            return View(res);
        }
        [HttpPost, ActionName("DeleteEmp")]
        public IActionResult DeleteConfirm(int EmpID)
        {
            var find = _db.EmpModels.Find(EmpID);
            if (find != null)
            {
                _db.EmpModels.Remove(find);
                _db.SaveChanges();
            }

            return RedirectToAction("DisplayEmp");
        }

    }
}
