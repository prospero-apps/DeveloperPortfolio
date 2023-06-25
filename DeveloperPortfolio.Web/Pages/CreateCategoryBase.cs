using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class CreateCategoryBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public CategoryDto CategoryDto = new CategoryDto();

        [Inject]
        public ICategoryService CategoryService { get; set; }

        protected async Task CreateCategory_Submit()
        {
            try
            {
                await CategoryService.CreateCategory(CategoryDto);
                NavigationManager.NavigateTo("/");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
