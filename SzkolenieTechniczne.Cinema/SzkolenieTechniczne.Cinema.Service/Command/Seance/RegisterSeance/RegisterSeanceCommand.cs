using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Seance.RegisterSeance
{
    public class RegisterSeanceCommand : ICommand
    {
        public long MovieId {get; set;}
        public DateTime SeanceDate { get; set;}

        public int NumberOfTickets { get; set;}
    }
}
