using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Seance.RegisterSeance
{
    internal class RegisterSeanceCommandValidator : AbstractValidator<RegisterSeanceCommand>
    {
        public RegisterSeanceCommandValidator()
        {
            RuleFor(x => x.MovieId).NotEmpty();
            RuleFor(x => x.SeanceDate).NotEmpty();
            RuleFor(x => x.SeanceDate).GreaterThan(DateTime.UtcNow);
        }
    }
}
