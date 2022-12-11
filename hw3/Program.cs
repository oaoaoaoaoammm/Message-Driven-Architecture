using ikoLite;
using ikoLite.Notification;
using ikoLite.Services.Booking;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;




ConnectionBuilder(args).Build().Run();



static IHostBuilder ConnectionBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddMassTransit(x =>
            {
                x.AddConsumer<NotiferTableBookedConsumer>();
                x.AddConsumer<KitchenReadyConsumer>();

                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host("rattlesnake.rmq.cloudamqp.com", 5671, "vybtzrtm", conf =>
                    {
                        conf.Username("vybtzrtm");
                        conf.Password("VXIdPEDcbbDP-JUdPZVnZeBCgKQBCRBO");

                        //ForSSl Port 5671
                        conf.UseSsl(s =>
                        {
                            s.Protocol = System.Security.Authentication.SslProtocols.Tls12;
                        });

                    });

                    cfg.ConfigureEndpoints(context);
                });
                //services.AddMassTransitHostedService(true);

                services.AddTransient<BookingService>();

                services.AddScoped<Notifier>();

                services.AddHostedService<Worker>();
            });
        });

