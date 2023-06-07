namespace BookRentalFormation.Application.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Pseudo { get; set; }
        public int Credits { get; set; }
    }
}
