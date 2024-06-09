namespace SzkolenieTechniczne.Cinema.Service.Query.Dtos
{
    public class MovieDto
    {
        public MovieDto(string name, long id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; }
        public long Id { get; }
    }
}
