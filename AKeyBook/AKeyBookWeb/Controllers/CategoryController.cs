using AKeyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace AKeyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            return View(categories);
        }
    }
}
