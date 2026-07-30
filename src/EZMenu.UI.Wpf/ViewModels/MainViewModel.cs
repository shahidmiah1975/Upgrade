using EZMenu.Core.Models;
using EZMenu.Services;
using EZMenu.Services.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EZMenu.UI.Wpf.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IOrderService _orderService;

        public ObservableCollection<OrderItem> Items { get; } = new();

        private OrderItem? _selectedItem;
        public OrderItem? SelectedItem
        {
            get => _selectedItem;
            set { _selectedItem = value; OnPropertyChanged(); }
        }

        public ICommand AddItemCommand { get; }
        public ICommand RemoveSelectedCommand { get; }

        public MainViewModel()
        {
            // simple composition - in a full app this would be injected
            _orderService = new OrderService();

            AddItemCommand = new Helpers.RelayCommand(_ => AddItem());
            RemoveSelectedCommand = new Helpers.RelayCommand(_ => RemoveSelected(), _ => SelectedItem != null);

            // seed
            AddItem();
            AddItem();
        }

        private void AddItem()
        {
            var item = _orderService.Add(new OrderItem { Name = "Sample Dish", Price = 5.99m, Quantity = 1 });
            Items.Add(item);
        }

        private void RemoveSelected()
        {
            if (SelectedItem is null) return;
            _orderService.Remove(SelectedItem.Id);
            Items.Remove(SelectedItem);
            SelectedItem = null;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
