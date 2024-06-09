using Microsoft.AspNetCore.Mvc;
using System;
using SzkolenieTechniczne.Cinema.Service.Command.Seance.RegisterSeance;
using SzkolenieTechniczne.Cinema.Service.Query.Movie;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Controllers
{
    [Route("[controller]/[action]")]
    public class SeancesController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        public SeancesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        [HttpGet("{Id}")]
        public IActionResult Index(long id)
        {
            var handler = new GetMovieQueryHandler(_movieRepository);
            var query = new GetMovieQuery(id);
            var movie = handler.Handle(query);
            return View(movie);
        }
        [HttpGet("{movieId}")]
        public IActionResult Add(long movieId) 
        {
            var command = new RegisterSeanceCommand
            {
                MovieId = movieId,
                SeanceDate = DateTime.UtcNow
            };
            return View(command);
        }

        public IActionResult Add(long movieId, RegisterSeanceCommand command) 
        {
            var handler = new RegisterSeanceCommandHandler(_movieRepository);
            var result = handler.Handle(command);
            if(result.IsFailure)
            {
                return View(command);
            }
            return RedirectToAction("Index", new {id = movieId});
        }
    }
}
