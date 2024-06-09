namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Edit
{
    public sealed class EditMovieCommand : ICommand
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int TimeMinutes { get; set; }

    }
}
