using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Common;

namespace SzkolenieTechniczne.Cinema.Storage.Entities
{
    [Table("Tickets", Schema ="Cinema")]
    public class Ticket : BaseEntity
    {
        protected Ticket()
        {

        }
        public Ticket(string email, int numberOfTickets)

        {
            Email = email;
            NumberOfTickets = numberOfTickets;
        }
        [Required]
        [MinLength(5)]
        [MaxLength(128)]
        public string Email { get; set; }
        [Required]
        [MinLength(9)]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Range (1,10)]
        public int NumberOfTickets { get; set;}
        [Required]
        public long SeanceId { get; set; }
        public Seance Seance { get; set; }
    }
}
