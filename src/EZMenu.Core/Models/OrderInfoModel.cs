namespace EZMenu.Core.Models
{
    public class OrderInfoModel
    {
        public int OrderId { get; set; }
        public int TableNumber { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime CreatedAt { get; set; } = System.DateTime.UtcNow;
        public System.Collections.Generic.List<OrderItem> Items { get; set; } = new();
    }
}
