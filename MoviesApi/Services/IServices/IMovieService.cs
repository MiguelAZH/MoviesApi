using MoviesApi.DAL.Models.Dtos;

namespace MoviesApi.Services.IServices
{
    public interface IMovieService
    {
        Task<ICollection<MovieDto>> GetMoviesAsync();
        Task<MovieDto?> GetMovieAsync(int id);
        Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto movieDto);
        Task<MovieDto> UpdateMovieAsync(int id, MovieCreateUpdateDto Dto);
        Task<bool> MovieExistsByIdAsync(int id);
        Task<bool> DeleteMovieAsync(int id);
        Task<bool> MovieExistByNameAsync(string name);
    }
}
