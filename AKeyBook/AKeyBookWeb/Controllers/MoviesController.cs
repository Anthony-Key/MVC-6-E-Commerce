using AKeyBookWeb.Data;
using AKeyBookWeb.Models;
using AKeyBookWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AKeyBookWeb.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public MoviesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Create()
        {
            var movCat = new MovieCategory();
            movCat.movie = new Movie();
            movCat.categories = _dbContext.Categories.ToList();
            return View(movCat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePOST(MovieCategory movie)
        {
            /*if (ModelState.IsValid)
            {
                _dbContext.Movies.Add(movie);
                _dbContext.SaveChanges();
                return RedirectToAction("Create");
            }*/

            return RedirectToAction("Create");
        }
    }
}
