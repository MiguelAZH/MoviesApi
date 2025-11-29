using MoviesApi.DAL.Models;

namespace MoviesApi.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync(); // Get all Movies
        Task<Movie?> GetMovieAsync(int id); // Get Movie by ID
        Task<bool> MovieExistsByIdAsync(int id); // Check if Movie exists fot ID
        Task<bool> MovieExistByNameAsync(string name); // Check if Movie exists for name
        Task<bool> CreateMovieAsync(Movie movie); // Create a new Movie
        Task<bool> UpdateMovieAsync(Movie movie); //  Update existing Movie (Name and UpdateDate)
        Task<bool> DeleteMovieAsync(int id); // Delete a Movie
    }
}
