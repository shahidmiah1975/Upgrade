namespace EZMenu.Core.Models
{
    public class CustomerOrderModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public System.Collections.Generic.List<OrderItem> Items { get; set; } = new();
        public decimal Total => Items.Sum(i => i.Total);
    }
}
