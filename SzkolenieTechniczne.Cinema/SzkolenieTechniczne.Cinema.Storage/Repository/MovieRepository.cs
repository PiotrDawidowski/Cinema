using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Entities;

namespace SzkolenieTechniczne.Cinema.Storage.Repository
{
    public class MovieRepository: IMovieRepository
    {
        private readonly CinemaTicketDbContext _context;
        public MovieRepository(CinemaTicketDbContext context)
        {
            _context = context;
        }
        public void AddMovie(Entities.Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
        public void AddSeance(Seance seance)
        {
            _context.Seances.Add(seance);
            _context.SaveChanges();
        }
        public void BuyTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }
        public void EditMovie(Entities.Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }
        public Entities.Movie GetMovieById(long movieId) { 
            return _context.Movies
                .Include(c => c.Seances)
                .ThenInclude(c => c.Tickets)
                .SingleOrDefault(x=>x.Id == movieId);
        }
        public List<Entities.Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
        public Entities.Movie GetSeanceDetails(long movieId)
        {
            return _context.Movies.Where(x => x.Id == movieId)
                .Include(t => t.Seances)
                .SingleOrDefault();
        }
        public List<Seance> GetSeancesByMovieId(long movieId)
        {
            return _context.Seances.Where(x=>x.MovieId == movieId)
                .ToList();
        }
        public bool IsMovieExist(long movieId)
        {
            return _context.Movies.Any(
                x=> x.Id == movieId);
        }
        public bool IsMovieExist(string name,int year)
        {
            return _context.Movies.Any(
                x => x.Name == name && x.Year == year);
        }

        public bool IsSeanceExist(DateTime date)
        {
            return _context.Seances.Any(x => x.Date == date);
        }
        public void RemoveMovie(long id)
        {
            var movie =_context.Movies.FirstOrDefault(x => x.Id == id);
            _context.Remove(movie);
            _context.SaveChanges();
        }
    }
}
