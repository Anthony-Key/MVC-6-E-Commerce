using AKeyBookWeb.Models;

namespace AKeyBookWeb.ViewModels
{
    public class MovieCategory
    {
        public Movie movie { get; set; }
        public List<Category> categories { get; set; }
    }
}
