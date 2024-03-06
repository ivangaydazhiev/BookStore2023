using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        Task <List<Book>> GetAll();

       Task <Book> GetById(int id);

       public Task Add(Book book);

       public Task Remove(int id);

        Task <List<Book>>
            GetAllByAuthorAfterReleaseDate(
                int authorId,
                DateTime afterDate);
    }
}
