namespace EZMenu.Core.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public System.Collections.Generic.List<OrderItem> Items { get; set; } = new();
        public decimal Subtotal => Items.Sum(i => i.Total);
        public decimal Tax { get; set; }
        public decimal Total => Subtotal + Tax;
    }
}
