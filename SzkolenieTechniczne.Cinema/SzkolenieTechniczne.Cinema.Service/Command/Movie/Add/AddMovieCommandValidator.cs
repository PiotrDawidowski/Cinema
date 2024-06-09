using FluentValidation;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Add
{
    public class AddMovieCommandValidator : AbstractValidator<AddMovieCommand>
    {
        public AddMovieCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Year).InclusiveBetween(1900, 2040);
            RuleFor(x => x.SeanceTime).InclusiveBetween(30, 300);
        }
    }
}
