namespace EZMenu.Core.Models
{
    public class TableBillModel
    {
        public int TableNumber { get; set; }
        public int BillId { get; set; }
        public System.Collections.Generic.List<OrderItem> Items { get; set; } = new();
        public decimal Total => Items.Sum(i => i.Total);
    }
}
