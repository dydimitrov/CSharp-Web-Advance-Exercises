using System;
using System.Collections.Generic;
using System.Linq;
using Eventures.Data;
using Eventures.Models;
using Eventures.Models.ViewModels.Order;
using Eventures.Services.Contracts;

namespace Eventures.Services
{
    public class OrderService : IOrderService
    {
        private readonly EventuresDbContext db;
        public OrderService(EventuresDbContext db)
        {
            this.db = db;
        }

        public void Create(DateTime createdOn, string username, int eventId, int ticketsCount)
        {
            var user = db.Users.First(u => u.UserName == username);
            var order = new Order()
            {
                CreatedOn = createdOn,
                Customer = user,
                EventId = eventId,
                TicketsCount = ticketsCount
            };
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public IEnumerable<OrderListViewModel> All()
        {
            var orders = db.Orders.Select(o => new OrderListViewModel()
            {
                EventName = o.Event.Name,
                CustomerName = o.Customer.UserName,
                OrderedOn = o.CreatedOn
            })
             .ToList();

            return orders;
        }
    }
}
