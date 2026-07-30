using EZMenu.Core.Models;
using EZMenu.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EZMenu.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<OrderItem> _items = new();
        private int _nextId = 1;

        public IReadOnlyList<OrderItem> GetAll() => _items.AsReadOnly();

        public OrderItem Add(OrderItem item)
        {
            item.Id = _nextId++;
            _items.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            var ex = _items.FirstOrDefault(x => x.Id == id);
            if (ex != null) _items.Remove(ex);
        }
    }
}
