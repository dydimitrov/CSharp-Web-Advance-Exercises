using System;
using System.Collections.Generic;
using Eventures.Models.ViewModels.Order;

namespace Eventures.Services.Contracts
{
    public interface IOrderService
    {
        void Create(DateTime createdOn, string userId, int eventId, int ticketsCount);

        IEnumerable<OrderListViewModel> All();
    }
}