

using BookStore.Models.Models;
using System.Data;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        public void AddBook(Book book);

        public void DeleteBook(int id);

        public void UpdateBook(Book book);

        public Book? GetBook(int id);

        public List<Book> GetAllBooks();

        public List<Book> GetAllByAuthorAfterReleaseDate(int authorId, DateTime afterDate);
    }
}
