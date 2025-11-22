using System.ComponentModel.DataAnnotations;

namespace MoviesApi.DAL.Models
{
    public class Category : AuditBase
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Name is required
        [Display(Name = "Category Name")] // Display attribute for UI
        public string Name { get; set; }

    }
}
