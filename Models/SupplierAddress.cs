using System;

namespace simple_stock_manager.Models
{
    public class SupplierAddress : Address
    {
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
