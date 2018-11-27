using System;

namespace Eventures.Models.ViewModels.Order
{
    public class OrderListViewModel
    {
        public string EventName { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
