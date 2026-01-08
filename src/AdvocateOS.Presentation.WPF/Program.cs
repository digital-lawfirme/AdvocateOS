using AdvocateOS.Application;
using AdvocateOS.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AdvocateOS.Presentation.WPF;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddApplication();
                services.AddInfrastructure(context.Configuration);

                services.AddSingleton<App>();
                services.AddSingleton<MainWindow>();
            })
            .Build();

        var app = host.Services.GetRequiredService<App>();
        app.InitializeComponent();

        var mainWindow = host.Services.GetRequiredService<MainWindow>();
        app.Run(mainWindow);
    }
}
