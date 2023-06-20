using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class CreateCategoryBase : ComponentBase
    {
        public CategoryDto CategoryDto = new CategoryDto();

        [Inject]
        public ICategoryService CategoryService { get; set; }

        protected async void CreateCategory_Submit()
        {
            try
            {
                await CategoryService.CreateCategory(CategoryDto);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
