using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")] //menampilkan langsung pada UI tanpa memberikan label pada index
        [Range(1,100,ErrorMessage ="Display Order must be between 1-100")] //custom error message
        public int DisplayOrder { get; set; }
    }
}
