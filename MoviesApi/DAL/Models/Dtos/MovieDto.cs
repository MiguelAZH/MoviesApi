using System.ComponentModel.DataAnnotations;

namespace MoviesApi.DAL.Models.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre de la pelicula es obligatoria")]
        [MaxLength(50, ErrorMessage = "El nombre de la pelicula no puede exceder los 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La pelicula debe tener duración")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "La pelicula debe tener clasificación")]
        public string Clasification { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
