using Chuska.Models.ViewModels.Order;
using Chuska.Services.Contracts;
using Chuska.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace Chuska.Services
{
    public class OrderService : IOrderService
    {
        private readonly ChuskaDbContext db;
        public OrderService(ChuskaDbContext db)
        {
            this.db = db;
        }

        public List<OrderViewModel> All()
        {
            return db.Orders.Select(x => new OrderViewModel()
            {
                Id = x.Id.ToString(),
                Customer = x.Client.UserName,
                ProductName = x.Product.Name,
                OrderedOn = x.OrderedOn
            }).ToList();
        }
    }
}
