using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Entities;

namespace SzkolenieTechniczne.Cinema.Storage.Repository
{
    public interface IMovieRepository
    {
        List<Entities.Movie> GetMovies();
        Entities.Movie GetMovieById(long movieId);
        void AddMovie(Entities.Movie movie);
        void EditMovie(Entities.Movie movie);
        void RemoveMovie(long id);
        bool IsMovieExist(long movieId);
        bool IsMovieExist(string name, int year);
        bool IsSeanceExist(DateTime date);
        void AddSeance(Entities.Seance seance);
        List<Seance> GetSeancesByMovieId(long movieId);
        Entities.Movie GetSeanceDetails(long movieId);
       
        void BuyTicket(Ticket ticket);
        
    }
}
