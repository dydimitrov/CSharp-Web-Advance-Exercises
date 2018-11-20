using System;

namespace Chuska.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ChuskaUser Client { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
