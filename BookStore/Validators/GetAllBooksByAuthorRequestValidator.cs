using BookStore.Models.Requests;
using FluentValidation;
using System.Runtime.InteropServices;

namespace BookStore.Validators
{
    public class GetAllBookByAuthorRequestValidator : AbstractValidator<GetAllBooksByAuthorRequest>
    {
        public GetAllBookByAuthorRequestValidator()
        {
            RuleFor(x => x.AuthorId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.DateAfter).NotEmpty().GreaterThan(new DateTime(1978, 01, 01));
        }
    }
}
