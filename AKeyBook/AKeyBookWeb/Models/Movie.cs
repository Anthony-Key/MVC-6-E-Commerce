using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AKeyBookWeb.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? MovieName { get; set; }
        public string? MovieImgUrl { get; set; }
        [Required]
        public int Rating { get; set; }
        public virtual List<Category>? Categories { get; set; }
    }
}
