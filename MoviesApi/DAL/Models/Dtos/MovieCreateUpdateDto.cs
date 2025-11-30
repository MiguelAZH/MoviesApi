using System.ComponentModel.DataAnnotations;

namespace MoviesApi.DAL.Models.Dtos
{
    public class MovieCreateUpdateDto
    {
        [Required(ErrorMessage = "El nombre de la categoria es obligatoria")]
        [MaxLength(100, ErrorMessage = "El nombre de la categoria no puede exceder los 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La pelicula debe tener duración")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "La pelicula debe tener clasificación")]
        public string Clasification { get; set; }
    }
}
