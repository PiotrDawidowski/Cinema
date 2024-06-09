using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SzkolenieTechniczne.Cinema.Service.Command.Movie.Add;
using SzkolenieTechniczne.Cinema.Service.Query.Dtos;
using SzkolenieTechniczne.Cinema.Service.Query.Movie;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
       
        
        public MovieController(IMovieRepository movieRepository) 
        {
           _movieRepository = movieRepository;
        }
        public IActionResult Index()
        {
            var handler = new GetAllMoviesQueryHandler(_movieRepository);
            var query = new GetAllMoviesQuery();
            var movies = handler.Handle(query);
            return View(movies);
        }
        public IActionResult Add() {
            return View();
        }
        public IActionResult Edit(long id) {
            return View();
                }
        [HttpPost]
        public IActionResult Add(AddMovieCommand command)
        {
            var handler = new AddMovieCommandHandler(_movieRepository);
            var result = handler.Handle(command);
            if (result.IsFailure)
            {
                return View(command);
            }
            return RedirectToAction("Index");
        }
    }
}
