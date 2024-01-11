using BookStore.BL.Interfaces;
using BookStore.Models.Requests;
using BookStore.Models.Responses;

using ILibraryService = BookStore.BL.Interfaces.ILibraryService;

namespace BookStore.BL.Services
{
    public class LibraryService : ILibraryService
    {

        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        public LibraryService(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public GetAllBooksByAuthorRespons?
          GetAllByAuthorAfterReleaseDate(GetAllBooksByAuthorRequest request, DateTime afterDate)
        {
            var books = _bookService.GetAllByAuthorAfterReleaseDate(request.AuthorId, request.DateAfter);
            if(books.Count > 0)
            {
                var response = new GetAllBooksByAuthorRespons()
                {
                    Author = _authorService.GetAuthor(request.AuthorId),
                    Books = books.Where(b => b.ReleaseDate == afterDate).ToList()
                };
                return response;
            }
            return null;
        }
   
    }
}
