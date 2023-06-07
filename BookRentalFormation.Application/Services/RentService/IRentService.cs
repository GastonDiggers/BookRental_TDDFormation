namespace BookRentalFormation.Application.Services.RentService
{
    public interface IRentService
    {
        Task RentBook(Guid bookId, Guid userId);
    }
}
