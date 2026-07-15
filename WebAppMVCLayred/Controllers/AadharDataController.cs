using BusinessLogicLayer.Irepo;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{
    public class AadharDataController : Controller
    {
        public readonly IAadhar _IAadhar;
        public AadharDataController(IAadhar IAadhar)
        {
            _IAadhar = IAadhar;
        }

        public async Task<IActionResult> GetAadharList()
        {
            var res = await _IAadhar.GetAadhar();
            return View(res);
        }
        public async Task<IActionResult> GetPanList()
        {
            var res = await _IAadhar.GetPan();
            return View(res);
        }
        public async Task<IActionResult> GetCountryList()
        {
            var res = await _IAadhar.GetCountry();
            return View(res);
        }

    }
}
