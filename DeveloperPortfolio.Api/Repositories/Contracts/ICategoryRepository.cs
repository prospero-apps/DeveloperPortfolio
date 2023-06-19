using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Api.Repositories.Contracts
{
    public interface ICategoryRepository
    {             
        Task<IEnumerable<Category>> GetAllCategories();    
        
        Task<Category> GetCategory(int id);
        
        Task<Category> CreateCategory(CategoryDto categoryDto);
                
        Task<Category> UpdateCategory(int id, CategoryDto categoryDto);

        Task<Category> DeleteCategory(int id);
    }
}
