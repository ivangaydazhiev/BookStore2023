using BookStore.Models.Models;
using BookStore.Models.Requests;
using FluentValidation;
using FluentValidation.Validators;

namespace BookStore.BL.Interfaces
{
    public class GetAllBooksByAuthorRequestValidator: AbstractValidator<GetAllBooksByAuthorRequest>
    {
        public GetAllBooksByAuthorRequestValidator()
        {
            RuleFor(x => x.AuthorId).NotEmpty()
            .GreaterThan(0);
            RuleFor(x => x.DateAfter).NotEmpty()
                .NotNull();

        }
    }
}
