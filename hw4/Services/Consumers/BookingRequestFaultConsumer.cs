using System;
using MassTransit;

namespace ikoLite
{
	public class BookingRequestFaultConsumer : IConsumer<Fault<IBookingRequest>>
	{
        public Task Consume(ConsumeContext<Fault<IBookingRequest>> context)
        {
            Console.WriteLine($"[OrderId: {context.Message.Message.OrderId}] decliend");
            return Task.CompletedTask;
        }
    }
}

