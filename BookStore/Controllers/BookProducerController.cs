using BookStore.BL.Interfaces;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookProducerController : ControllerBase
    {
        private readonly IBookProducerService _bookProducerService;

        public BookProducerController(IBookProducerService bookProducerService)
        {
            _bookProducerService = bookProducerService;
        }

        [HttpPost("Add")]

        public async Task <IActionResult> Add([FromBody] Book book)
        {
            if (book == null)
            {
                return BadRequest(book);
            }
            await _bookProducerService.ProduceBook(book);

            return Ok(book);
        }
    }
}
