namespace ikoLite
{
    internal class BookingRequest : IBookingRequest
    {
        public Guid OrderId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime CreationDate { get; set; }



        public BookingRequest(Guid guid1, Guid guid2, DateTime utcNow)
        {
            OrderId = guid1;
            ClientId = guid2;
            CreationDate = utcNow;
        }
    }
}