using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Command.Seance.RegisterSeance
{
    public sealed class RegisterSeanceCommandHandler : ICommandHandler<RegisterSeanceCommand>
    {
        private readonly IMovieRepository _repository;
        public RegisterSeanceCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }
        public Result Handle(RegisterSeanceCommand command)
        {
            var validationResult = new RegisterSeanceCommandValidator().Validate(command);
            if(validationResult.IsValid == false) 
            {
                return Result.Fail(validationResult);
            }
            
            var isSeanceExist = _repository.IsSeanceExist(command.SeanceDate);
            if (isSeanceExist)
            {
                return Result.Fail("This seance already exists");
            }

            var movie = _repository.GetMovieById(command.MovieId);
            if(movie == null)
            {
                return Result.Fail("This movie does not exists");
            }
            
            var seance = new Storage.Entities.Seance(command.SeanceDate, command.MovieId);
            movie.Seances.Add(seance);
            return Result.Ok();
        }
    }
}
