using Microsoft.EntityFrameworkCore;
using ResturantManagement.Data;
using ResturantManagement.Models.Entities;
using ResturantManagement.Repository.Interfaces;

namespace ResturantManagement.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ResturantDbContext dbContext;

        public CategoryRepository(ResturantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.AddAsync(category);
            await dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category?> DeleteAsync(int id)
        {
            var existingCategory = await dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (existingCategory == null)
            {
                return null;
            }

            dbContext.Categories.Remove(existingCategory);
            await dbContext.SaveChangesAsync();

            return existingCategory;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await dbContext.Categories.Include(c => c.menuItems).ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Category?> UpdateAsync(int id, Category category)
        {
            var existingCategory = await dbContext.Categories.FirstOrDefaultAsync(C => C.Id == id);
            if (existingCategory == null)
            {
                return null;
            }

            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;

            await dbContext.SaveChangesAsync();

            return existingCategory;

        }
    }
}
