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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePOST(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Movies.Add(movie);
                _dbContext.SaveChanges();
                return RedirectToAction("Create");
            }

            return RedirectToAction("Create");
        }
    }
}
