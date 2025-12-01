using AutoMapper;
using MoviesApi.DAL.Models;
using MoviesApi.DAL.Models.Dtos;
using MoviesApi.Repository;
using MoviesApi.Repository.IRepository;
using MoviesApi.Services.IServices;

namespace MoviesApi.Services
{
    public class MovieService : IMovieService
    {

        private readonly IMovieRepository _movieRepository;
        public readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<bool> MovieExistByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> MovieExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto movieDto)
        {
            var movieExists =  await _movieRepository.MovieExistByNameAsync(movieDto.Name);

            if (movieExists)
            {
                throw new InvalidOperationException($"Ya existe una pelicula con el nombre '{movieDto.Name}'");
            }

            var movie =_mapper.Map<Movie>(movieDto);

            var movieCreated = await _movieRepository.CreateMovieAsync(movie);

            if(!movieCreated)
            {
                throw new InvalidOperationException("No se pudo crear la pelicula");
            }
            return _mapper.Map<MovieDto>(movie);
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            await GetMovieByIdAsync(id);

            var movieDeleted = await _movieRepository.DeleteMovieAsync(id);

            if(!movieDeleted)
            {
                throw new InvalidOperationException("Error al eliminar la pelicula");
            }
            return movieDeleted;
        }

        public async Task<ICollection<MovieDto>> GetMoviesAsync()
        {
            var movies = await _movieRepository.GetMoviesAsync();
            return _mapper.Map<ICollection<MovieDto>>(movies);
        }

        public async Task<MovieDto?> GetMovieAsync(int id)
        {
            var movie = await _movieRepository.GetMovieAsync(id);

            if (movie == null)
            {
                throw new InvalidOperationException($"No se encontro pelicula con el ID: '{id}'");
            }
            return _mapper.Map<MovieDto>(movie);
        }

        public async Task<MovieDto> UpdateMovieAsync(int id, MovieCreateUpdateDto Dto)
        {
            var existingMovie = await GetMovieByIdAsync(id);

            var nameExists = await _movieRepository.MovieExistByNameAsync(Dto.Name);

            if (nameExists)
            {
                throw new InvalidOperationException($"Ya existe una pelicula con el nombre '{Dto.Name}'");
            }

            _mapper.Map(Dto, existingMovie);
            var movieUpdated = await _movieRepository.UpdateMovieAsync(existingMovie);

            if (!movieUpdated)
            {
                throw new InvalidOperationException("Error al actualizar la pelicula");
            }
            return _mapper.Map<MovieDto>(existingMovie);
        }

        private async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movie = await _movieRepository.GetMovieAsync(id);

            if (movie == null)
            {
                throw new InvalidOperationException($"No se encontró la pelicula con ID: '{id}'");
            }

            return movie;
        }
    }
}
