using System;

namespace SzkolenieTechniczne.Cinema.Service.Command.Tickets.BuyTickets
{
    public sealed class BuyTicketCommand : ICommand
    {
        public BuyTicketCommand(long movieId, DateTime seanceDate, string email, int numberOfTickets)
        {
            SeanceDate = seanceDate;
            Email = email;
            NumberOfTickets = numberOfTickets;
            Email = email;
        }

        public long MovieId { get; set; }
        public DateTime SeanceDate { get; set; }
        public string Email { get; set; }
        public int NumberOfTickets { get; set;}
    }
}
