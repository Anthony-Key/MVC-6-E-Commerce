using AKeyBookWeb.Data;
using AKeyBookWeb.Models;
using AKeyBookWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AKeyBookWeb.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private Movie createdMovie;
        private List<Category> attachedCategories = new List<Category>();

        public MoviesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Create()
        {
            var movie = new Movie();
            return View(movie);
        }

        public IActionResult Select()
        {
            var movCat = new MovieCategory();
            movCat.movie = new Movie();
            movCat.categories = _dbContext.Categories.ToList();
            return View(movCat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBase(Movie movie)
        {
            createdMovie = movie;
            return RedirectToAction("Select");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePOST(MovieCategory movie)
        {
            attachedCategories = movie.categories;
            return RedirectToAction("Create");
        }
    }
}
