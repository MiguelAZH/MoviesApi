using MoviesApi.DAL.Models;
using MoviesApi.DAL.Models.Dtos;

namespace MoviesApi.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDto>> GetCategoriesAsync(); 
        Task<CategoryDto?> GetCategoryByIdAsync(int id);
        Task<bool> CategoryExistsByIdAsync(int id); 
        Task<bool> CategoryExistByNameAsync(string name); 
        Task<bool> CreateCategoryAsync(Category category);
        Task<bool> UpdateCategoryAsync(Category category); 
        Task<bool> DeleteCategoryAsync(int id);
    }
}
