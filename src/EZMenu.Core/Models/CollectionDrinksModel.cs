namespace EZMenu.Core.Models
{
    public class CollectionDrinksModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public System.Collections.Generic.List<OrderItem> Drinks { get; set; } = new();
    }
}
