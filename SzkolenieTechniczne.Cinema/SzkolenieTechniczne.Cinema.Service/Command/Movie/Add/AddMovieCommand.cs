using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Add
{
    public sealed class AddMovieCommand : ICommand
    {   
        public long CategoryId {  get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int SeanceTime { get; set; }
        public string Description { get; set; }


    }
}
