namespace BookRentalFormation.Application.Entities
{
    public enum BookAvailability { Available, Rented, Reserved }
    public class Rent
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public BookAvailability BookAvailability { get; set; }
        public DateTime RentDate { get; set; }
    }
}
