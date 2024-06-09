using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Query.Dtos;

namespace SzkolenieTechniczne.Cinema.Service.Query.Seance
{
    public class GetSeanceQuery : IQuery<MovieSeanceDetailsDto>
    {
        public GetSeanceQuery(long movieId, long seanceId)
        {
            MovieId = movieId;
            SeanceId = seanceId;
        }
        public long MovieId { get; }
        public long SeanceId { get; }
    }
}
