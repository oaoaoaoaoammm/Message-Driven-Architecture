using System;
using ikoLite.Messaging;
using ikoLite.Services.Booking;
using MassTransit;
using Microsoft.Extensions.Hosting;

namespace ikoLite
{
	public class Worker : BackgroundService
	{
		private readonly IBus _bus;
		private readonly BookingService _restaurant;



        public Worker(IBus bus, BookingService booking)
		{
			_bus = bus;
			_restaurant = booking;
		}



		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			while (!stoppingToken.IsCancellationRequested)
			{
				await Task.Delay(3000, stoppingToken);
				//var result = await _restaurant.BookFreeTableAsync(1);
				//await _bus.Publish(new TableBooked(NewId.NextGuid(), NewId.NextGuid(), result ?? false), x => x.Durable = false, stoppingToken);
			}
		}
	}
}

