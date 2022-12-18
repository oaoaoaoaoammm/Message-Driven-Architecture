using System;
namespace ikoLite
{
	public interface IBookingCancellation
	{
        public Guid OrderId { get; }

        public Guid ClientId { get; }

        public DateTime CancellationDate { get; set; }
    }
}

