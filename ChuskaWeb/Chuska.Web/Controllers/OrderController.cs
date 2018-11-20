
using Chuska.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Chuska.Web.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService orders;
        public OrderController(IOrderService orders)
        {
            this.orders = orders;
        }
        public IActionResult All()
        {
            var model = orders.All();
            return View(model);
        }
    }
}