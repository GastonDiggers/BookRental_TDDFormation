using BookRentalFormation.Application.Entities;
using BookRentalFormation.Application.Repositories;

namespace BookRentalFormation.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBook(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
