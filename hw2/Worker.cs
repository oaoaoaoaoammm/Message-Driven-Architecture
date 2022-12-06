using System.Text;
using ikoLite.Messaging;
using Microsoft.Extensions.Hosting;

namespace ikoLite.Notification
{
	public class Worker : BackgroundService
	{
		private readonly Consumer _consumer;


		public Worker()
		{
			_consumer = new("BookingNotification", "rattlesnake.rmq.cloudamqp.com");
		}


		protected override async Task ExecuteAsync(CancellationToken token)
		{
			_consumer.Recieve((sender, args) =>
			{
				var body = args.Body.ToArray();
				var message = Encoding.UTF8.GetString(body);
				Console.WriteLine("[x] received {0}", message);
			});
		}
	}
}

