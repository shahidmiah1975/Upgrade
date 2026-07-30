using System.Windows;
using EZMenu.UI.Wpf.Views;

namespace EZMenu.UI.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenOrderView_Click(object sender, RoutedEventArgs e)
        {
            var view = new OrderView();
            view.Owner = this;
            view.ShowDialog();
        }
    }
}
