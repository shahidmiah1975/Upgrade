using System;
using EZMenu.Core.Models;

namespace EZMenu.Services
{
    public interface IPrintService
    {
        void PrintOrder(OrderInfoModel order);
    }

    public class PrintService : IPrintService
    {
        public void PrintOrder(OrderInfoModel order)
        {
            // stub - implement print logic (port from clsPrintOrder.vb) during UI migration
            Console.WriteLine($"Printing order {order.OrderId} for table {order.TableNumber}");
        }
    }
}
