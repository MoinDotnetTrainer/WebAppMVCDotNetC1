using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{
    public class OrdersTaskController : Controller
    {
        public readonly IOrders _iorders;
        public OrdersTaskController(IOrders iorders)
        {
            _iorders = iorders;
        }


        [HttpGet]
        public IActionResult AddOrders()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddOrders(Orders data)
        {
            await _iorders.AddOrders(data);
            return RedirectToAction("GetOrders");
        }


        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var res = await _iorders.OrdersList();
            return View(res);
        }

    }
}
