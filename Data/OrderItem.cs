using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingBargain.Data
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }   // FK to Order
        public int ProductId { get; set; } // FK to Product
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Price at the time of purchase
    }
}
