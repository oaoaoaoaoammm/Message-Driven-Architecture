﻿using System;
using MassTransit;

namespace ikoLite.Models
{
	public class RestaurantBooking : SagaStateMachineInstance
	{
		public Guid CorrelationId { get; set; }

		public int CurrentState { get; set; }

		public Guid OrderId { get; set; }

		public Guid ClientId { get; set; }

		public int ReadyEventStatus { get; set; }

		public Guid? ExpId { get; set; }
	}
}

