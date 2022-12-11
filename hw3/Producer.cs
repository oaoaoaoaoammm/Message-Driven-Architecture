using System;
using System.Text;
using RabbitMQ.Client;

namespace ikoLite.Messaging
{
	public class Producer
	{
		private readonly string _queueName;
		private readonly string _hostName;



        public Producer(string queueName, string hostName)
		{
			_queueName = queueName;
			_hostName = hostName;
		}



		public void Send(string message)
		{
			var factory = new ConnectionFactory()
			{
				HostName = _hostName,
				Port = 5672,
				UserName = "vybtzrtm",
				Password = "VXIdPEDcbbDP-JUdPZVnZeBCgKQBCRBO",
				VirtualHost = "vybtzrtm"
            };
			var connection = factory.CreateConnection();
			IModel channel = connection.CreateModel();

			channel.ExchangeDeclare(
                "some_exchange",
				type:"direct",
				durable:false,
				autoDelete:false,
				arguments:null
                );

			var body = Encoding.UTF8.GetBytes(message);

			channel.BasicPublish(exchange: "some_exchange", routingKey: _queueName, basicProperties: null, body:body);
		}
	}
}

