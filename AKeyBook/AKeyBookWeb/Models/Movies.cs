using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AKeyBookWeb.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        public string MovieImgUrl { get; set; }
        [Required]
        public int Rating { get; set; } 
    }
}
