using MoviesApi.DAL.Models;
using MoviesApi.DAL.Models.Dtos;

namespace MoviesApi.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); 
        Task<CategoryDto?> GetCategoryByIdAsync(int id);
        Task<CategoryDto> CreateCategoryAsync(CategoryCreateDto categoryDto);
        Task<CategoryDto> UpdateCategoryAsync(int id, CategoryCreateDto categoryDto); 
        Task<bool> CategoryExistsByIdAsync(int id); 
        Task<bool> DeleteCategoryAsync(int id);
        Task<bool> CategoryExistByNameAsync(string name); 
    }
}
