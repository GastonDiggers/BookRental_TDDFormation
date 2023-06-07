using BookRentalFormation.Application.Entities;

namespace BookRentalFormation.Application.Repositories
{
    public interface IBookRepository
    {
        Task AddBook(Book book);
        Task<Book> GetBook(Guid bookId);
        Task UpdateBook(Book book);
    }
}
