using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Query.Dtos;

namespace SzkolenieTechniczne.Cinema.Service.Query.Movie
{
    public sealed class GetMovieQuery : IQuery<MovieDetailsDto>
    {
        public GetMovieQuery(long movieId)
        {
            MovieId = movieId;
        }
        public long MovieId { get;}
    }
}
