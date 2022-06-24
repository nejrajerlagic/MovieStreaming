using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_Streaming_Platform.Models.DB;
using System;
using System.Linq;
using Movie_Streaming_Platform.ViewModels;

namespace Movie_Streaming_Platform.Controllers
{
    public class MovieController : Controller
    {
        public readonly MoviesContext _context;

        public MovieController(MoviesContext context) 
        {
            _context = context;
        }
        // GET: MovieController
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        // GET: MovieController/MoviePage/5
        public ActionResult MoviePage(int id)
        {
            // id 0 = movies first or default 
            // id 1 = action
            // id 2 = Comdy
            // id 3 = Drama
            // id 4 = Horror
            // id 5 = Romance
            // id 6 = SciFi
            var searchString ="";
            switch (id)
            {
                case 1:
                    searchString = "Action";
                    break;
                case 2:
                    searchString = "Comedy";
                    break;
                case 3:
                    searchString = "Drama";
                    break;
                case 4:
                    searchString = "Horror";
                    break;
                case 5:
                    searchString = "Romance";
                    break;
                case 6:
                    searchString = "SciFI";
                    break;
                default:
                    searchString = "Comedy"; //for tesing -> -Layout does not parse the id properly
                    break;
            }

            var movies = _context.Movies.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Category.Contains(searchString)).ToList();
            }

            var model = new MoviePageViewModel
            {
                Genre = searchString,
                Movies = movies

            };

            return View(model);
        }

        // GET: MovieController/PlayerPage
        public ActionResult PlayerPage(string movieLocation)
        {
            var model = new PlayerViewModel
            {
                MovieLocation =  movieLocation
            };
            return View(model);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
