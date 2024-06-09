using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Delete
{
    public sealed class DeleteMovieCommandHandler : ICommandHandler<DeleteMovieCommand>
    {
        private readonly IMovieRepository _repository;
        public DeleteMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }
        public Result Handle(DeleteMovieCommand command)
        {
            var movie = _repository.GetMovieById(command.Id);
            if (movie == null)
            {
                return Result.Fail("Movie does not exist");
            }

            _repository.RemoveMovie(command.Id);
            return Result.Ok();
        }
    }
}
