﻿using System;
namespace ikoLite.Messaging
{
	public class KitchenReady : IKitchenReady
	{
		public KitchenReady(Guid orderId, bool ready)
		{
			OrderId = orderId;
			Ready = ready;
		}



        public Guid OrderId { get; }

        public bool Ready { get; }
    }
}

