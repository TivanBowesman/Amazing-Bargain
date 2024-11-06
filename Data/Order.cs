using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingBargain.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // FK to ApplicationUser
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }  // Collection of items
    }
}
