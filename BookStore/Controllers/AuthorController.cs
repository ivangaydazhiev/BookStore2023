
using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {

        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("GetAllAuthor")]

        public List<Author> GetAllAuthor()
        {
            return _authorService.GetAllAuthors();
        }

        [HttpGet]
        public Author? Get(int id)
        {
            if (id < 0) return null;
            return _authorService.GetAuthor(id);
        }

        [HttpPost("Add")]

        public void Add([FromBody] Author author)
        {
            _authorService.AddAuthor(author);
        }

        [HttpPost("Update")]

        public void UpdateAuthor([FromBody] Author author)
        {
            _authorService.UpdateAuthor(author);
        }


        [HttpDelete("Delete")]

        public void Delete(int id)
        {
            _authorService.DeleteAuthor(id);
        }
    }
}