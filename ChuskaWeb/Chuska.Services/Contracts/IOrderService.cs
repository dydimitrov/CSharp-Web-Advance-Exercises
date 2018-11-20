using Chuska.Models.ViewModels.Order;
using System.Collections.Generic;

namespace Chuska.Services.Contracts
{
    public interface IOrderService
    {
        List<OrderViewModel> All();
    }
}
