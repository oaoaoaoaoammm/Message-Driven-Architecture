namespace ikoLite
{
    public interface IBookingRequest
    {
        public Guid OrderId { get; }

        public Guid ClientId { get; }

        public DateTime CreationDate { get; set; }
    }
}