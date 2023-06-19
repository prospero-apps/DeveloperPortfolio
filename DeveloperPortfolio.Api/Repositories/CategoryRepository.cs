using DeveloperPortfolio.Api.Data;
using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Api.Repositories.Contracts;
using DeveloperPortfolio.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DeveloperPortfolio.Api.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DeveloperPortfolioDbContext developerPortfolioDbContext;

        public CategoryRepository(DeveloperPortfolioDbContext developerPortfolioDbContext)
        {
            this.developerPortfolioDbContext = developerPortfolioDbContext;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var categories = await developerPortfolioDbContext.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await developerPortfolioDbContext.Categories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Category> CreateCategory(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
            //if (await CategoryWithThisNameExists(categoryDto.Name) == false)
            //{
            //    var item = new Category
            //    {
            //        Id = categoryDto.Id,
            //        Name = categoryDto.Name,
            //        Icon = categoryDto.Icon
            //    };

            //    if (item != null)
            //    {
            //        var result = await developerPortfolioDbContext.Categories.AddAsync(item);
            //        await developerPortfolioDbContext.SaveChangesAsync();
            //        return result.Entity;
            //    }
            //}

            //return null;
        }

        public Task<Category> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }
            
        public Task<Category> UpdateCategory(int id, CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        private async Task<bool> CategoryWithThisNameExists(string name)
        {
            return await developerPortfolioDbContext.Categories.AnyAsync(c => c.Name == name);
        }
    }
}
