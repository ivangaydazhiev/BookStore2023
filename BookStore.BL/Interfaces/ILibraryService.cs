using BookStore.Models.Requests;
using BookStore.Models.Responses;


namespace BookStore.BL.Interfaces
{
        public interface ILibraryService
        {
            GetAllBooksByAuthorRespons? GetAllByAuthorAfterReleaseDate(GetAllBooksByAuthorRequest request, DateTime afterDate);
        }
    }
