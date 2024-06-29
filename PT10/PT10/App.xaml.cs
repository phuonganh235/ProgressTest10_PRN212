using Microsoft.Extensions.DependencyInjection;
using PT10.Models;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Extensions.Configuration;
namespace PT10
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }
        public IConfiguration Configuration { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<MainWindow>();
            serviceCollection.AddScoped<PrnSpr23B1Context>();
            ServiceProvider = serviceCollection.BuildServiceProvider();
            ServiceProvider.GetRequiredService<MainWindow>().Show();
        }
    }

}
