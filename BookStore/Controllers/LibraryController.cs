﻿using BookStore.BL.Interfaces;
using BookStore.Models.Requests;
using BookStore.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Validators;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        [HttpPost("GetAllBooksByAuthorAndDate")]
        public async Task <IActionResult> GetAllBooksByAuthor(GetAllBooksByAuthorRequest request)
        {
            if (request == null) return BadRequest();

            var result = await _libraryService.GetAllBooksByAuthorAfterReleaseDate(request);

            if (result == null) return NotFound();

            return Ok(result);

        }
        [HttpPost("SomeEndPoint")]
        public string GetSomeData([FromBody] SomeRequest request) 
        {
            return "Ok";
        }
    }
}
