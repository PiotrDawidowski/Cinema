using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Query.Dtos
{
    public class MovieSeanceDetailsDto
    {
        public MovieSeanceDetailsDto(long movieId, string movieName, long seanceId, DateTime seanceDate) 
        {
            MovieName = movieName;
            MovieId = movieId;
            SeanceId = seanceId;
            SeanceDate = seanceDate;
        }
        public long MovieId { get;}
        public long SeanceId { get;}
        public string MovieName { get;}
        public DateTime SeanceDate { get;}
    }
}
