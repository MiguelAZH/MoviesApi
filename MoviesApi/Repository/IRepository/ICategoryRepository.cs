using MoviesApi.DAL.Models;

namespace MoviesApi.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); // Get all categories
        Task<Category?> GetCategoryAsync(int id); // Get category by ID
        Task<bool> CategoryExistsByIdAsync(int id); // Check if category exists fot ID
        Task<bool> CategoryExistByNameAsync(string name); // Check if category exists for name
        Task<bool> CreateCategoryAsync(Category category); // Create a new category
        Task<bool> UpdateCategoryAsync(Category category); //  Update existing category (Name and UpdateDate)
        Task<bool> DeleteCategoryAsync(int id); // Delete a category
    }
}
