using System;
namespace ikoLite
{
	public class BookingExp :IBookingExp
	{
        private readonly RestaurantBooking _instance;



        public BookingExp(RestaurantBooking restaurant)
        {
            _instance = restaurant;
        }



        public Guid OrderId => _instance.OrderId;
    }
}

