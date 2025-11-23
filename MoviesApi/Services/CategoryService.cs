using AutoMapper;
using MoviesApi.DAL.Models;
using MoviesApi.DAL.Models.Dtos;
using MoviesApi.Repository.IRepository;
using MoviesApi.Services.IServices;

namespace MoviesApi.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        public readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
             _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<bool> CategoryExistByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync(); //Llamo al metodo desde la capa de repositorio
            return _mapper.Map<ICollection<CategoryDto>>(categories); //mapeo la lista de categorias a una lista de categorias DTO
        }

        public async Task<CategoryDto?> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryRepository.GetCategoryByIdAsync(id); //Llamo al metodo desde la capa de repositorio
            return _mapper.Map<CategoryDto>(category); //mapeo la lista de categorias a una lista de categorias DTO
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
