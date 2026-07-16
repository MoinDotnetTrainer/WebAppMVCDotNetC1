using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Admin")]

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

        [HttpGet]
        public async Task<IActionResult> GetOrdersByID(int OrderID)
        {
            var res = await _iorders.GetOrdersByID(OrderID);
            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> EditOrders(int OrderID)
        {
            var res = await _iorders.GetOrdersByID(OrderID);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> EditOrders(Orders data)
        {
            await _iorders.UpdateOrders(data);
            return RedirectToAction("GetOrders");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteOrders(int OrderID)
        {
            var res = await _iorders.GetOrdersByID(OrderID);
            return View(res);
        }

        [HttpPost, ActionName("DeleteOrders")]
        public async Task<IActionResult> DeleteOrdersConfirm(int OrderID)
        {
            await _iorders.DeleteOrders(OrderID);
            return RedirectToAction("GetOrders");
        }

    }
}
