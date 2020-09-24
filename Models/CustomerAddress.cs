using System;

namespace simple_stock_manager.Models
{
    public class CustomerAddress : Address
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
