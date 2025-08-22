using ResturantManagement.Models.Entities;

namespace ResturantManagement.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
        
        Task<List<Category>> GetAllAsync(); 

        Task<Category> GetByIdAsync(int id);

        Task<Category?> UpdateAsync(int id, Category category);

        Task<Category?> DeleteAsync(int id);
    }
}
