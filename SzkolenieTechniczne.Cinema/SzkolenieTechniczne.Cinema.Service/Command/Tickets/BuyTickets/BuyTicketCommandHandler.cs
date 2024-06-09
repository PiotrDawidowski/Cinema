using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Entities;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Command.Tickets.BuyTickets
{
    public sealed class BuyTicketCommandHandler : ICommandHandler<BuyTicketCommand>
    {
        private readonly IMovieRepository _repository;
        public BuyTicketCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }
        public Result Handle(BuyTicketCommand command)
        {
            var validatorResult = new BuyTicketCommandValidator().Validate(command);
            if (validatorResult.IsValid == false) 
            {
                return Result.Fail(validatorResult);
            }
            var movie = _repository.GetMovieById(command.MovieId);
            if (movie == null)
            {
                return Result.Fail("Movie does not exist");
            }
            var ticket = new Ticket(command.Email, command.NumberOfTickets);
            var seance = movie.GetSeanceByDateAndRoomId(command.SeanceDate);
            if (seance == null)
            {
                return Result.Fail("Seance does not exist");
            }

            ticket.SeanceId = seance.Id;
            _repository.BuyTicket(ticket);
            return Result.Ok();
        }
    }
}
