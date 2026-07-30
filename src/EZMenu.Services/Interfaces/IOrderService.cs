using EZMenu.Core.Models;
using System.Collections.Generic;

namespace EZMenu.Services.Interfaces
{
    public interface IOrderService
    {
        IReadOnlyList<OrderItem> GetAll();
        OrderItem Add(OrderItem item);
        void Remove(int id);
    }
}
