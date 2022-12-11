using System;
using ikoLite.Messaging;
using MassTransit;

namespace ikoLite.Kitchen
{
	public class Manager
	{
		private readonly IBus _bus;


		public Manager(IBus bus)
		{
			_bus = bus;
		}


		public void CheckKitchenready(Guid guid, Dish? dish)  //add random events
        {
			_bus.Publish<IKitchenReady>(new KitchenReady(guid, true));
		}
	}
}

