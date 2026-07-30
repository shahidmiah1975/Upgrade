using System;
using System.Collections.Generic;

namespace EZMenu.Core.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int DishId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class CartModel
    {
        public int Id { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal Total => CalculateTotal();

        private decimal CalculateTotal()
        {
            decimal sum = 0;
            foreach (var it in Items)
                sum += it.Price * it.Quantity;
            return sum;
        }
    }
}
