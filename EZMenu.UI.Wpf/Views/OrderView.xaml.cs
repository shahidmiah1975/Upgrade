using System.Windows;
using EZMenu.Core.Models;
using EZMenu.Services;

namespace EZMenu.UI.Wpf.Views
{
    public partial class OrderView : Window
    {
        private readonly IPrintService _printService;
        private readonly OrderInfoModel _order;

        public OrderView()
        {
            InitializeComponent();

            _printService = App.Current.Services.GetService(typeof(IPrintService)) as IPrintService!;

            // sample data for POC
            _order = new OrderInfoModel
            {
                OrderId = 1001,
                TableNumber = 5,
                Items = new System.Collections.Generic.List<CartItem>
                {
                    new CartItem { Id = 1, DishId = 10, Name = "Burger", Price = 8.99m, Quantity = 1 },
                    new CartItem { Id = 2, DishId = 12, Name = "Fries", Price = 3.49m, Quantity = 2 }
                }
            };

            ItemsList.ItemsSource = _order.Items;
            TotalText.Text = $"Total: {_order.Total:C}";
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            _printService?.PrintOrder(_order);
            MessageBox.Show("Print invoked (POC)", "Print", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
