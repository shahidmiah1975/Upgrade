using EZMenu.Core.Models;
using System.Collections.Generic;

namespace EZMenu.Data
{
    // Placeholder adapter for typed DataSet artifacts from the original VB project.
    // Once the EZMenuDataSet.xsd / Designer files are inspected, we will generate
    // equivalent C# typed DataSet classes and replace this adapter with actual ADO.NET
    // or EF Core accessors.
    public class TypedDataSetAdapter
    {
        // Temporary in-memory store to support the POC while we port DataSet usage.
        private readonly List<OrderInfoModel> _orders = new();

        public IReadOnlyList<OrderInfoModel> GetOrders() => _orders.AsReadOnly();

        public void Seed(IEnumerable<OrderInfoModel> seed)
        {
            _orders.Clear();
            _orders.AddRange(seed);
        }

        // TODO: implement Load/Save using regenerated typed DataSet or ADO.NET layer.
    }
}
