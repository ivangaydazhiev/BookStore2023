

using BookStore.BL.Interfaces;
using BookStore.DL.InMemoryDb;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using System.Data;

namespace BookStore.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)

        {
            _bookRepository = bookRepository;
        }
        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void DeleteBook(int id)
        {
           _bookRepository.DeleteBook(id);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public Book? GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }
        
        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }

      
        public List<Book> GetAllByAuthorAfterReleaseDate(int authorId, DateTime afterDate)
        {
            var result = _bookRepository.GetAllByAuthor(authorId);
            return result
                .Where(b => b.ReleaseDate >= afterDate)
                .ToList();
        }

    }
}
