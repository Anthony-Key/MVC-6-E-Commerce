using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AKeyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public List<Movies> Movies = new List<Movies>(); 
    }
}
