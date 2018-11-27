

using System;

namespace Eventures.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }

        public EventuresUser Customer { get; set; }
        public string CustomerId { get; set; }

        public int TicketsCount { get; set; }
    }
}
