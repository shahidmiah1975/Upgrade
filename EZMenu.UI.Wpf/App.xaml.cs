using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using EZMenu.Services;

namespace EZMenu.UI.Wpf
{
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current!;
        public IServiceProvider Services { get; private set; } = default!;

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            Services = services.BuildServiceProvider();

            base.OnStartup(e);
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IPrintService, PrintService>();
        }
    }
}
