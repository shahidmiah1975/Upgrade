using System;
using System.Collections.Generic;

namespace EZMenu.Core.Models
{
    public class OrderInfoModel
    {
        public int OrderId { get; set; }
        public int TableNumber { get; set; }
        public CustomerModel? Customer { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }
}
