using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using SzkolenieTechniczne.Cinema.Storage.Common;

namespace SzkolenieTechniczne.Cinema.Storage.Entities
{
    [Table("Movies", Schema = "Cinema")]
    public class Movie : BaseEntity
    {
        protected Movie() { }
        public Movie(string name, int year, int seanceTime, string description, long movieCategoryId)
        {
            Name = name;
            Year = year;
            TimeMinutes = seanceTime;
            Description = description;
            IsActive = true;
            MovieCategoryId = movieCategoryId;
        }

        [Required]
        public long MovieCategoryId { get; set; }
        [Required]
        public MovieCategory MovieCategory { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public int TimeMinutes { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public ICollection<Seance> Seances { get; set; }

        public Seance GetSeanceByDateAndRoomId(DateTime date)
        {
            return Seances.SingleOrDefault(x => DateTime.Compare(x.Date, date) == 1);
        }


    }
}
