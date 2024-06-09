using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Query.Dtos
{
    public class TicketDetailsDto
    {
        public TicketDetailsDto(string email, int peopleCount, DateTime purchaseDate)
        {
            Email = email;
            PeopleCount = peopleCount;
            PurchaseDate = purchaseDate;
        }
        public string Email { get; }
        public int PeopleCount { get; }
        public DateTime PurchaseDate { get; }
    }
}
