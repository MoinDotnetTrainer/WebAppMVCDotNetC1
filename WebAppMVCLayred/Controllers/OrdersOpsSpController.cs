using BusinessLogicLayer.Irepo;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Repo;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCLayred.Controllers
{
    public class OrdersOpsSpController : Controller
    {
        public readonly IOrders _iorders;
        public OrdersOpsSpController(IOrders iorders)
        {
            _iorders = iorders;
        }

       


        [HttpGet]
        public IActionResult AddOrders()
        {
            if (HttpContext.Session.GetString("loginsession") == null)
            {
                return RedirectToAction("Login", "Usersops");
            }
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
            if (HttpContext.Session.GetString("loginsession") == null)
            {
                return RedirectToAction("Login", "Usersops");
            }
            var res = await _iorders.OrdersList();
            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetOrdersByID(int OrderID)
        {
            if (HttpContext.Session.GetString("loginsession") == null)
            {
                return RedirectToAction("Login", "Usersops");
            }
            var res = await _iorders.GetOrdersByID(OrderID);
            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> EditOrders(int OrderID)
        {
            if (HttpContext.Session.GetString("loginsession") == null)
            {
                return RedirectToAction("Login", "Usersops");
            }
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
            if (HttpContext.Session.GetString("loginsession") == null)
            {
                return RedirectToAction("Login", "Usersops");
            }
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
