using System.ComponentModel.DataAnnotations;

namespace MoviesApi.DAL.Models
{
    public class Movie : AuditBase
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Title is required
        public string Name { get; set; }

        public int Duration { get; set; }
        public string? Description { get; set; }
        public string Clasification { get; set; }
    }
}
