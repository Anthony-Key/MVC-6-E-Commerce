using AKeyBookWeb.Data;
using AKeyBookWeb.Models;
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

        [HttpGet]
        public IActionResult Index(int catId)
        {
            var movies = new List<Movies>(_dbContext.Movies.ToList());
            movies.ForEach(movie =>
            {
                if(movie.Id == catId)
                {
                    movies.Add(movie);
                } 
            });

;            return View(movies);
        }
    }
}
