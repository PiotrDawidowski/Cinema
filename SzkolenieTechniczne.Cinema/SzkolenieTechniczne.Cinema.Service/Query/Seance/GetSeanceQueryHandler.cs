using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Query.Dtos;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Query.Seance
{
    public class GetSeanceQueryHandler : IQueryHandler<GetSeanceQuery, MovieSeanceDetailsDto>
    {
        private readonly IMovieRepository _repository;
        public GetSeanceQueryHandler(IMovieRepository repository)
        {
            _repository = repository;
        }
        public MovieSeanceDetailsDto Handle(GetSeanceQuery query)
        {
            var movie = _repository.GetSeanceDetails(query.MovieId);
            if(movie == null)
            {
                throw new NullReferenceException("Given Movie does not exist");
            }
            var seance = movie.Seances.SingleOrDefault(x => x.Id == query.SeanceId);
            if (seance == null) 
            {
                throw new NullReferenceException("Given seance does not exist.");
            }

            return new MovieSeanceDetailsDto(movie.Id, movie.Name, seance.Id, seance.Date);
        }
    }
}
