using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        Task <List<Book>> GetAll();

       Task <Book> GetById(Guid id);

       public Task Add(Book book);

       public Task Remove(Guid id);

        Task <List<Book>>
            GetAllByAuthorAfterReleaseDate(
                int authorId,
                DateTime afterDate);
    }
}
