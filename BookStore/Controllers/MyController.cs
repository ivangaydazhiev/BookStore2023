using BookStore.BL.Interfaces;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Book2Controller : ControllerBase
    {
        private readonly IBookService _bookService;

        public Book2Controller(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetBookById")]
        public Book GetBookById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody]Book book)
        {
            _bookService.Add(book);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookService.Remove(id);
        }

    }
}
