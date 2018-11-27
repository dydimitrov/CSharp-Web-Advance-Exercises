using System;
using Eventures.Models.ViewModels.Order;
using Eventures.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orders;

        public OrderController(IOrderService orders)
        {
            this.orders = orders;
        }
        [HttpPost]
        public IActionResult Add(OrderEventViewModel model)
        {
            model.User = this.User.Identity.Name;
            this.orders.Create(DateTime.UtcNow, model.User,model.EventId, model.TicketCount);
            return RedirectToAction("All", "Events");
        }

        public IActionResult All()
        {
            var model = this.orders.All();
            return this.View(model);
        }
        
    }
}