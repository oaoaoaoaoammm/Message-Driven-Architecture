using ikoLite.Notification;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


ConnectionBuilder(args).Build().Run();

static IHostBuilder ConnectionBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices(
        (hostContext, services) =>
        {
            services.AddHostedService<Worker>();
        });

