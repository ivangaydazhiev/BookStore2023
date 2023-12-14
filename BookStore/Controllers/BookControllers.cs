
using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAllBooks")]

        public List<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }

        [HttpGet]
        public Book? Get(int id)
        {
            if (id < 0) return null;
            return _bookService.GetBook(id);
        }

        [HttpPost("Add")]

        public void Add([FromBody] Book book)
        {
            _bookService.AddBook(book);
        }

        [HttpPost("Update")]

        public void UpdateBook([FromBody] Book book)
        {
            _bookService.UpdateBook(book);
        }


        [HttpDelete("Delete")]

        public void Delete(int id)
        {
            _bookService.DeleteBook(id);
        }
    }
}