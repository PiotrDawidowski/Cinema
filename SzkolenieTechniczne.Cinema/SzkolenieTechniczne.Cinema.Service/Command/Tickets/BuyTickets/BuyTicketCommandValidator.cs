using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Tickets.BuyTickets
{
    internal class BuyTicketCommandValidator : AbstractValidator<BuyTicketCommand>
    {
        public BuyTicketCommandValidator()
        {
            RuleFor(x => x.MovieId).NotEmpty();
            RuleFor(x => x.SeanceDate).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.NumberOfTickets).GreaterThan(0);
        }
    }
}
