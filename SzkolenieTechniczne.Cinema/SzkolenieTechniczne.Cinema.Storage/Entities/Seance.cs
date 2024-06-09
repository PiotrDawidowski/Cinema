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
    [Table("Seances", Schema ="Cinema")]
    public class Seance : BaseEntity
    {
        protected Seance()
        {

        }
        public Seance(DateTime date, long movieId)
        {
            Date = date;
            MovieId = movieId;
        }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int NumberOfTickets { get; set; }
        [Required]
        public long MovieId { get; set; }
        [Required]
        public Movie Movie { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
