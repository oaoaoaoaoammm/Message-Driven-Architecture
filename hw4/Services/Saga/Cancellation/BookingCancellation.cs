namespace ikoLite
{
    internal class BookingCancellation : IBookingCancellation
    {
        public Guid OrderId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime CancellationDate { get; set; }



        public BookingCancellation(Guid orderId, Guid clientId, DateTime cancellationDate)
        {
            OrderId = orderId;
            ClientId = clientId;
            CancellationDate = cancellationDate;
        }
    }
}