using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using SzkolenieTechniczne.Cinema.Storage;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Extensions
{
    public static class CinemaExtensions
    {
        public static IServiceCollection AddCinemaServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMovieRepository, MovieRepository>();
            serviceCollection.AddDbContext<CinemaTicketDbContext, CinemaTicketDbContext>();
            return serviceCollection;
        }
    }
}
