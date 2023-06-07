namespace BookRentalFormation.Application.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookAvailability BookAvailability { get; set; }
        public int Credits { get; set; }
    }
}
