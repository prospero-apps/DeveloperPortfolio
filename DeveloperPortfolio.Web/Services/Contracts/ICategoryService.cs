using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Web.Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategories();
        Task<CategoryDto> GetCategory(int id);
        Task<CategoryDto> CreateCategory(CategoryDto categoryDto);
        Task<CategoryDto> UpdateCategory(CategoryDto categoryDto);
        Task<CategoryDto> DeleteCategory(int id);
    }
}
