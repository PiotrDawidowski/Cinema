using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Query.Dtos;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Query.Movie
{
    public class GetMovieQueryHandler : IQueryHandler<GetMovieQuery, MovieDetailsDto>
    {
        private readonly IMovieRepository _repository;
        public GetMovieQueryHandler(IMovieRepository repository)
        {
            _repository = repository;
        }


        public MovieDetailsDto Handle(GetMovieQuery query)
        {
            var movie = _repository.GetMovieById(query.MovieId);
            if (movie == null)
            {
                throw new NullReferenceException("Given movie does not exist.");
            }
            var seances = new List<SeanceDto>();
            if (movie.Seances != null)
            {
                seances = movie.Seances
                    .Select(item => new SeanceDto(item.Id, item.Date))
                    .ToList();
            }
            return new MovieDetailsDto(movie.Id, movie.Name, movie.Year, movie.TimeMinutes, seances);
        }
    }
}
