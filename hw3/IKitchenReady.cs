using System;
namespace ikoLite.Messaging
{
	public interface IKitchenReady
	{
		public Guid OrderId { get; }

		public bool Ready { get; }
	}
}

