
using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Requests;
using BookStore.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        [HttpPost("GetAllBooksByAuthorAndDate")]
        public GetAllBooksByAuthorRespons? GetAllBooksByAuthorAndDate([FromBody] GetAllBooksByAuthorRequest request, DateTime afterDate)
        {
            return _libraryService.GetAllByAuthorAfterReleaseDate(request, afterDate);
        }
        [HttpPost("GetAllBooksByAuthorRequestValidator")]
        public string GetAllBooksByAuthorRequestValidator(GetAllBooksByAuthorRequest request)
        {
            return "ok";
        }
    
    }

 }

