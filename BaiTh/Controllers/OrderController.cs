using BaiTh.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace BaiTh.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderResponsioty _orderResponsioty;

        public OrderController(IOrderResponsioty orderResponsioty)
        {
            _orderResponsioty = orderResponsioty;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderResponsioty.GetAllAsync();
            return View(orders);
        }
    }
}
