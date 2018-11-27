using System;

namespace Eventures.Models.ViewModels.Order
{
    public class OrderEventViewModel
    {
        public int EventId { get; set; }
        public string User { get; set; }
        public int TicketCount { get; set; }
    }
}
